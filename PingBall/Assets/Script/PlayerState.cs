using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerState : MonoBehaviour
{
    public GameObject BallPrefab;
    public SphereCollider Ballcol;
    public Rigidbody rb;
    public Slider powerSlider;

    private void Start()
    {
        Debug.Log("deathstart");
        gameObject.GetComponent<Player>().OnDeathEvent += OnPlyaerDeath;
        gameObject.GetComponent<Player>().OnDeathEvent += OnPlusScore;
    }
    private void Update()
    {

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
        Debug.Log("Plus");
        Manager.Score = Manager.Score + 10;

        print(Manager.Score);
    }
}