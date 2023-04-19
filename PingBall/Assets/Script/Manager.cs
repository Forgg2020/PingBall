using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Collections;
using BouncyNameSpace;


public class Manager : TagCollisionTriiger
{
    [Header("�I��")]
    public static GameObject Ball;
    public GameObject[] SpaceGameObject;
    public GameObject[] ScoreGameObject;
    public Collider[] SpaceCol = new Collider[5];
    public Collider[] ScoreCol = new Collider[5];
    public Collider Ballcol;

    [Header("����")]
    public int Score;



    public void Start()
    {
        Ball = GameObject.FindGameObjectWithTag("Player");
        SpaceGameObject = GameObject.FindGameObjectsWithTag("Space");
        ScoreGameObject = GameObject.FindGameObjectsWithTag("Score");
        Ballcol = Ball.GetComponent<SphereCollider>();

        for (int i = 0; i < 5; i++)
        {
            SpaceCol[i] = SpaceGameObject[i].GetComponent<BoxCollider>();
        }
        for (int i = 0; i < 3; i++)
        {
            ScoreCol[i] = ScoreGameObject[i].GetComponent<SphereCollider>();
        }

    }

    private void Update()
    {
        for (int i = 0; i < 5; i++)
        {
            if (SpaceCol[i].bounds.Intersects(Ballcol.bounds))
            {
                SceneManager.LoadScene(0);
                Destroy(Ball);
            }

            if (ScoreCol[i].bounds.Intersects(Ballcol.bounds))
            {
                Score = Score + 10;
            }
        }
    }
}