using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Collections;
using BouncyNameSpace;
using UnityEngine.Events;
using UnityEngine.UI;

public class Manager : TagCollisionTriiger
{
    [Header("分數")]
    public static int Score;
    public Text ScoreInt;

    public delegate void OnLevelEvent();
    public event OnLevelEvent OnSouceEvent;


    private void Update()
    {
        ScoreInt.text = Score.ToString();        
    }
}

    