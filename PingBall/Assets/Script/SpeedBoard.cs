using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedBoard : TagCollisionTriiger
{
    public float acceleration = 1.0f;
    Transform accelerationPoint;
    private Rigidbody rb;

    private void Start()
    {
        //Player = GameObject.FindGameObjectWithTag("Player");
        //accelerationPoint = Player.transform;
        //rb = Player.GetComponent<Rigidbody>();
    }
    protected override void onCollisionPlayer(Collision other)
    {
        if (other.gameObject.CompareTag(CollisionTag))
        {
            rb = other.gameObject.GetComponent<Rigidbody>();
            accelerationPoint = other.gameObject.transform;
            rb.AddForce(Vector3.up * acceleration, ForceMode.Impulse);
        }
    }
}
