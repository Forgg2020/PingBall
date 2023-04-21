using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using BouncyNameSpace;


public class Player : TagCollisionTriiger
{
    

    [Header("分數")]
    //public GameObject PlayerBall;
    public int score;

    [Header("速度")]
    public static Rigidbody rb;
    public float maxSpeed = 5f;
    public float minSpeed = 0f;



    GameObject Manager;
    public GameObject BallPrefab;
    private bool CanCreate;
    public static SphereCollider PlayerCol;

    public SphereCollider Ballcol { get; private set; }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        PlayerCol = GetComponent<SphereCollider>();
        Manager = GameObject.Find("Manager");
        Manager.GetComponent<Manager>().OnDeathEvent += OnPlyaerDeath;
        print("yes");
    }

    public void FixedUpdate()
    {
        Vector3 currentVelocity = rb.velocity;
        float ballSpeed = currentVelocity.magnitude;
        ballSpeed = Mathf.Clamp(ballSpeed, 10, 25);
        rb.velocity = currentVelocity;
    }
    IEnumerator DelayedAction()
    {
        yield return new WaitForSeconds(1f); // 等待1秒
         // 要執行的程式碼
    }
    public void OnPlyaerDeath()
    {        
        if(!CanCreate)
        {
            Destroy(gameObject);
            Instantiate(BallPrefab, new Vector3(4.2f, -2.5f, -0.1f), new Quaternion(0, 0, 0, 0));
            Ballcol = gameObject.GetComponent<SphereCollider>();
            Debug.Log("death");
            CanCreate = true;
            rb = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();
            //SceneManager.LoadScene(0);
        }
    }
}
