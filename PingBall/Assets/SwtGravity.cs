using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwtGravity : MonoBehaviour
{
    public GameObject Player;
    public Vector3 gravity = Vector3.down * 9.8f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(gravity);
    }
}
