using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Collections;
using BouncyNameSpace;
using UnityEngine.Events;

public class Manager : TagCollisionTriiger
{
    [Header("�I��")]
    public Collider SpaceCol;
    public Collider[] ScoreCol;

    [Header("分數")]
    public static int Score;

    public void Start()
    {
        
    }

    public delegate void OnLevelEvent();
    public event OnLevelEvent OnSouceEvent;
    private void Update()
    {
        if (Player.PlayerCol != null)
        {
            if (SpaceCol.bounds.Intersects(Player.PlayerCol.bounds))
            {
            }
            for (int i = 0; i < ScoreCol.Length; i++)
            {
                if (ScoreCol[i].bounds.Intersects(Player.PlayerCol.bounds))
                {
                    OnSouceEvent?.Invoke();
                }
            }
        }
        else if((Player.PlayerCol == null)) 
        {
            Player.PlayerCol = GameObject.FindGameObjectWithTag("Player").GetComponent<SphereCollider>();
        }
    }
}

    