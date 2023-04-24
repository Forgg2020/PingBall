using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerDeath : MonoBehaviour
{
    public GameObject BallPrefab;
    public SphereCollider Ballcol;
    public Rigidbody rb;
    public Text ScoreInt;

    private void Start()
    {
        gameObject.GetComponent<Player>().OnDeathEvent += OnPlyaerDeath;
        gameObject.GetComponent<Player>().OnScoreEvent += OnPlusScore;
    }

    public void OnPlyaerDeath()
    {
        Debug.Log("death");
        Destroy(gameObject);
        Instantiate(BallPrefab, new Vector3(4.2f, -2.5f, -0.1f), new Quaternion(0, 0, 0, 0));
        //SceneManager.LoadScene(0);
    }

    public void OnPlusScore()
    {
        Manager.Score = Manager.Score + 10;
        print(Manager.Score);
    }
}