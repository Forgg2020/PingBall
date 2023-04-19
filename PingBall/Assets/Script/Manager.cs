using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using BouncyNameSpace;

public class Manager : TagCollisionTriiger
{
    [Header("�I��")]
    public GameObject[] Plus_GameObject;
    public Collider[] col;
    public Collider Ballcol;
    public static GameObject Ball;

    [Header("����")]
    public int Score;

    [Header("���d")]
    public GameObject PlayerBall;


    public void Start()
    {
        Plus_GameObject = GameObject.FindGameObjectsWithTag("Space");
        Ball = GameObject.FindGameObjectWithTag("Player");
        col = new Collider[5]; 

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
                ResetLevel();
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