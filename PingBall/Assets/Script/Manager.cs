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
    public int Score;

 

    public delegate void OnLevelEvent();
    public event OnLevelEvent OnSouceEvent;
    private void Update()
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
}

    