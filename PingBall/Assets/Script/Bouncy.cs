using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncy : TagCollisionTriiger
{
    Rigidbody rb;
    bool canRebound;
    public float ballSpeed;
    Vector3 currentVelocity;
    void Start()
    {
        rb = GameObject.FindGameObjectWithTag(CollisionTag).GetComponent<Rigidbody>();        
    }

    void FixedUpdate()
    {
        currentVelocity = rb.velocity;
        ballSpeed = currentVelocity.magnitude;
    }

    protected override void onCollisionPlayer(Collision other)
    {
        ballSpeed = Mathf.Clamp(ballSpeed, 10, 30);
        Vector3 limitedVelocity = currentVelocity.normalized * ballSpeed;
        rb.velocity = limitedVelocity;
    }

}


public class TagCollisionTriiger : MonoBehaviour
{
    protected virtual string CollisionTag { get; } = "Player";

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag(CollisionTag))
        {
            onCollisionPlayer(other);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(CollisionTag))
        {
            onTriggerPlayer(other);
        }
    }
    protected virtual void onCollisionPlayer(Collision other)
    {

    }
    protected virtual void onTriggerPlayer(Collider other)
    {

    }
}