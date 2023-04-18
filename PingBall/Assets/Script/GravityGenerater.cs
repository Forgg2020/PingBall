using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityGenerater : MonoBehaviour
{
    public Vector3 gravity = Vector3.down * 9.8f;
    Rigidbody rb;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(gravity);
    }
}