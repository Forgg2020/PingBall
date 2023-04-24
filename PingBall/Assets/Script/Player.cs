using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using BouncyNameSpace;

public class Player : TagCollisionTriiger
{
    [Header("ï™ù…")]
    public int score;

    [Header("ë¨ìx")]
    public static Rigidbody rb;
    public float minSpeed = 0f;
    public float maxSpeed = 5f;


    public static bool CanCreate;
    public static GameObject Manager;
    public static SphereCollider PlayerCol; 
    public SphereCollider Ballcol { get; private set; }


    public delegate void OnPlayerEvent();
    public event OnPlayerEvent OnDeathEvent;
    public event OnPlayerEvent OnScoreEvent;

    private void OnEnable()
    {
        rb = GetComponent<Rigidbody>();
        PlayerCol = GetComponent<SphereCollider>();
    }

    public void FixedUpdate()
    {
        rb = GetComponent<Rigidbody>();
        PlayerCol = GetComponent<SphereCollider>();
        Vector3 currentVelocity = rb.velocity;
        float ballSpeed = currentVelocity.magnitude;
        ballSpeed = Mathf.Clamp(ballSpeed, 10, 25);
        rb.velocity = currentVelocity;
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Space"))
        {
            OnDeathEvent?.Invoke();
            print("yes");
        }
        if (other.gameObject.CompareTag("Score"))
        {
            OnScoreEvent?.Invoke();
            print("No");
        }
    }
}
