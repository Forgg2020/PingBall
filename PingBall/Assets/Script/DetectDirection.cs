using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectDirection : MonoBehaviour
{
    private Vector3 lastPosition;
    private Rigidbody rb;
    void Start()
    {
        lastPosition = transform.position;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 position = transform.position;
        Vector3 direction = (position - lastPosition).normalized;
    }
}
