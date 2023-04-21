using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using BouncyNameSpace;
public class SpeedBoard : TagCollisionTriiger
{
    public float acceleration = 1.0f;
    Transform accelerationPoint;
    private Rigidbody rb;
    AudioSource AS;
    Vector3 direction;
    Vector3 lastPosition;
    public void Start()
    {
        AS = GetComponent<AudioSource>();
    }

    protected override void onCollisionPlayer(Collision other)
    {
        if (other.gameObject.CompareTag(CollisionTag))
        {
            rb = other.gameObject.GetComponent<Rigidbody>();
            accelerationPoint = other.gameObject.transform;
            rb.AddForce(Vector3.up * acceleration, ForceMode.Impulse);
            AS.Play();
        }
    }

    public void FixedUpdate()
    {
        direction = transform.position;
    }


    protected override void onTriggerPlayer(Collider other)
    {
        rb = other.gameObject.GetComponent<Rigidbody>();
        accelerationPoint = other.gameObject.transform;
        rb.AddForce(Vector3.up * acceleration, ForceMode.Impulse);
        AS.Play();
        print(direction);
    }
}