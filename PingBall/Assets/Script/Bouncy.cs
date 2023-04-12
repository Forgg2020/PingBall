using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncy : MonoBehaviour
{
    public float bounceForce = 10f; // �ϼu�O�j�p
    public GameObject Ball;

    private void OnCollisionEnter(Collision collision)
    {
        // �p��ϼu��V
        Vector3 bounceDirection = Vector3.Reflect(transform.position, collision.contacts[0].normal);

        // �N�ϼu�O���Ω���W
        Ball.GetComponent<Rigidbody>().AddForce(bounceDirection * bounceForce, ForceMode.Impulse);
    }
}