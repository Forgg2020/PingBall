using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [Header("碰撞")]
    public GameObject[] Plus_GameObject;
    public Collider[] col;
    public GameObject Ball;
    public Collider Ballcol;

    [Header("分數")]
    public int Score;
    public void Start()
    {
        Plus_GameObject = GameObject.FindGameObjectsWithTag("Space");

        col = new Collider[5]; // 初始化 Collider 陣列

        for (int i = 0; i < 5; i++)
        {
            col[i] = Plus_GameObject[i].GetComponent<BoxCollider>();
        }

        Ballcol = Ball.GetComponent<SphereCollider>();
    }

    private void Update()
    {
        for (int i = 0; i < 5; i++)
        {
            if (col[i].bounds.Intersects(Ballcol.bounds))
            {
                print("end");

                Score = Score + 10;
            }
        }
    }
    public void OncOnCollisionEnter(Collider other)
    {
        
    }
}