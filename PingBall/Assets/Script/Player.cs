using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [Header("���d")]
    //public GameObject PlayerBall;
    public int score;

    [Header("�t��")]
    Rigidbody rb;
    public float maxSpeed = 5f;
    public float minSpeed = 0f;


    public void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void FixedUpdate()
    {
        // ���o��e�t�צV�q

        Vector3 currentVelocity = rb.velocity;
        float ballSpeed = currentVelocity.magnitude;

        ballSpeed = Mathf.Clamp(ballSpeed, 10, 25);

        rb.velocity = currentVelocity;

    }
}
