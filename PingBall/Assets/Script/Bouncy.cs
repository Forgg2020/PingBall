using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncy : MonoBehaviour
{
    public float bounceForce = 10f; // 反彈力大小
    public GameObject Ball;

    private void Start()
    {
        Ball = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnCollisionEnter(Collision collision)
    {
        // 計算反彈方向
       Vector3 bounceDirection = Vector3.Reflect(transform.position, collision.contacts[0].normal);

        // 將反彈力應用於物體上
       Ball.GetComponent<Rigidbody>().AddForce(bounceDirection * bounceForce, ForceMode.Impulse);

        if (collision.gameObject.CompareTag("Player"))
        {
            
            StartCoroutine(StopBallForSeconds());
            

        }
    }


    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Invoke("Shooting", 2f);
        }
    }
    public void Shooting()
    {
        Ball.GetComponent<Rigidbody>().velocity = new Vector3(0, 10, 0);
        print("back");
    }

    private IEnumerator StopBallForSeconds()
    {
        Ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
        yield return new WaitForSeconds(0.5f);
        Ball.GetComponent<Rigidbody>().velocity = new Vector3(1, 0, 0); // 恢復速度
    }

}