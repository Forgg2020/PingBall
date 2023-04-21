using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Collections;
using BouncyNameSpace;
using UnityEngine.Events;

public class Manager : TagCollisionTriiger//, IEndObserver
{
    [Header("�I��")]
    public GameObject BallPrefab;
    public GameObject[] SpaceGameObject;
    public GameObject[] ScoreGameObject;
    public Collider[] SpaceCol = new Collider[5];
    public Collider[] ScoreCol = new Collider[2];
    public Collider Ballcol;

    [Header("分數")]
    public int Score;

 
    public delegate void OnDeath();
    public event OnDeath OnDeathEvent;
    
    private void Start()
    {
        SpaceGameObject = GameObject.FindGameObjectsWithTag("Space");
        ScoreGameObject = GameObject.FindGameObjectsWithTag("Score");

        for (int i = 0; i < 5; i++)
        {
            SpaceCol[i] = SpaceGameObject[i].GetComponent<BoxCollider>();
        }
        for (int i = 0; i < 2; i++)
        {
            ScoreCol[i] = ScoreGameObject[i].GetComponent<SphereCollider>();
        }
    }
    private void Update()
    {
        for (int i = 0; i < 5; i++)
        {
            if (SpaceCol[i].bounds.Intersects(Player.PlayerCol.bounds))
            {
                OnDeathEvent?.Invoke();
            }
        }
        for (int i = 0; i < 2; i++)
        {
            if (ScoreCol[i].bounds.Intersects(Player.PlayerCol.bounds))
            {
                Score = Score + 10;
            }
        }
    }
}

    