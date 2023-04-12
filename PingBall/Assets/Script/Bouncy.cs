using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncy : MonoBehaviour
{
    public float bounceForce = 10f; // 反彈力大小
    public GameObject Ball;

    private void OnCollisionEnter(Collision collision)
    {
        // 計算反彈方向
        Vector3 bounceDirection = Vector3.Reflect(transform.position, collision.contacts[0].normal);

        // 將反彈力應用於物體上
        Ball.GetComponent<Rigidbody>().AddForce(bounceDirection * bounceForce, ForceMode.Impulse);
    }
}