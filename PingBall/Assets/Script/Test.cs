using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // 取得當前速度向量

        Vector3 currentVelocity = rb.velocity;
        float ballSpeed = currentVelocity.magnitude;

        print(ballSpeed);

        ballSpeed = Mathf.Clamp(ballSpeed, 10, 15);

        Vector3 limitedVelocity = currentVelocity.normalized * ballSpeed;
        rb.velocity = limitedVelocity;

    }
}
