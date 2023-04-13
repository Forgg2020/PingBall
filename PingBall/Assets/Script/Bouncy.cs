using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncy : MonoBehaviour
{
    public float bounceForce = 10f; // �ϼu�O�j�p
    public GameObject Ball;

    private void Start()
    {
        Ball = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnCollisionEnter(Collision collision)
    {
        // �p��ϼu��V
       Vector3 bounceDirection = Vector3.Reflect(transform.position, collision.contacts[0].normal);

        // �N�ϼu�O���Ω���W
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
        Ball.GetComponent<Rigidbody>().velocity = new Vector3(1, 0, 0); // ��_�t��
    }

}