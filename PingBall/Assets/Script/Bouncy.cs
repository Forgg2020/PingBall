using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncy : MonoBehaviour
{
    Rigidbody rb;
    bool canRebound;
    public float ballSpeed;
    Vector3 currentVelocity;
    // Start is called before the first frame update
    void Start()
    {
        rb = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // 取得當前速度向量
        currentVelocity = rb.velocity;
        ballSpeed = currentVelocity.magnitude;
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            ballSpeed = Mathf.Clamp(ballSpeed, 10, 30);
            Vector3 limitedVelocity = currentVelocity.normalized * ballSpeed;
            rb.velocity = limitedVelocity;
        }
    }
}