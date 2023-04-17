using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : PlayerCollision
{
    [Header("���d")]
    //public GameObject PlayerBall;
    public int score;

    [Header("�t��")]
    Rigidbody rb;
    public float maxSpeed = 5f;
    public float minSpeed = 0f;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    protected virtual void onPlayerCollision(Collision other)
    {
        if (other.gameObject.CompareTag("Space"))
        {
            SceneManager.LoadScene(0);
        }
    }
    void FixedUpdate()
    {
        // ���o��e�t�צV�q

        Vector3 currentVelocity = rb.velocity;
        float ballSpeed = currentVelocity.magnitude;

        ballSpeed = Mathf.Clamp(ballSpeed, 10, 25);

        rb.velocity = currentVelocity;

    }
}


public class PlayerCollision : MonoBehaviour
{
    protected virtual string CollisionTag { get; } = "Space";

    public void OncOnCollisionEnter(Collider other)
    {
        if (other.gameObject.CompareTag(CollisionTag))
        {
            SceneManager.LoadScene(0);
        }
    }

    protected virtual void onPlayerCollision()
    {

    }
}
