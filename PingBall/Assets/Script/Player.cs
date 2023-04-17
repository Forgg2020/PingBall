using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : PlayerCollision
{
    [Header("關卡")]
    //public GameObject PlayerBall;
    public int score;

    [Header("速度")]
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
        // 取得當前速度向量

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
