using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : TagCollisionTriiger
{
    [Header("碰撞")]
    public GameObject[] Plus_GameObject;
    public Collider[] col;
    public GameObject Ball;
    public Collider Ballcol;

    [Header("分數")]
    public int Score;

    [Header("關卡")]
    public GameObject PlayerBall;
    public void Start()
    {
        //Instantiate(PlayerBall, new Vector3(4.2f, -2.4f, 0), Quaternion.identity);

        Plus_GameObject = GameObject.FindGameObjectsWithTag("Space");
        Ball = GameObject.FindGameObjectWithTag("Player");
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
                Invoke("ResetLevel", 2f);
            }
        }
    }

    public void ResetLevel()
    {
        SceneManager.LoadScene(0);
        Destroy(Ball);
        Score = Score + 10;
    }
}