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
    public float maxSpeed = 5f;
    public float minSpeed = 0f;

    public static GameObject Manager;
    public static bool CanCreate;
    public static SphereCollider PlayerCol;

    public SphereCollider Ballcol { get; private set; }

    public delegate void OnPlayerEvent();
    public event OnPlayerEvent OnDeathEvent;
    public event OnPlayerEvent OnSpawnEvent;

    private void Start()
    {
        CanCreate = true;
        rb = GetComponent<Rigidbody>();
        PlayerCol = GetComponent<SphereCollider>();
        //Manager.GetComponent<Manager>().OnSouceEvent += OnScorePlus;
    }

    public void FixedUpdate()
    {
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
    }

    public void OnScorePlus()
    {

    }
}
