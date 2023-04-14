using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddSpeed : MonoBehaviour
{
    public float acceleration = 1.0f;
    Transform accelerationPoint;
    public GameObject Player;
    private Rigidbody rb;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        accelerationPoint = Player.transform;
        rb = Player.GetComponent<Rigidbody>();
    }

    public void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            // rb.AddForce(Vector3.up * 10);
            rb.AddForce(Vector3.up * acceleration, ForceMode.Impulse);
            print("Pork");
        }
    }
}
