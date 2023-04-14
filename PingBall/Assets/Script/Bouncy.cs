using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncy : MonoBehaviour
{
    Rigidbody rb;
    bool canRebound;
    // Start is called before the first frame update
    void Start()
    {
        rb = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // 取得當前速度向量

        Vector3 currentVelocity = rb.velocity;
        float ballSpeed = currentVelocity.magnitude;

        print(ballSpeed);

        if(canRebound)
        {
            ballSpeed = Mathf.Clamp(ballSpeed, 0, 15);
            Vector3 limitedVelocity = currentVelocity.normalized * ballSpeed;
            rb.velocity = limitedVelocity;
        }        
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            canRebound = true;
        }
    }
}