using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerTest : MonoBehaviour
{
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        //if (Player != null)
        //{
        //    print("sus");
        //}
    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.G))
        {
            print("ddd");
            Player.GetComponent<PT>().PlayerDeath += Playerdead;
        }
    }
    private void Playerdead()
    {
        print("dead");
    }
}
