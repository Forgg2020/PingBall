using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MT : MonoBehaviour
{
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        Player.GetComponent<PT>().PlayerDeath += Playerdead;
    }

    public void Update()
    {
        if(Input.GetKey(KeyCode.G))
        {
            print("ddd");
        }
    }
    private void Playerdead()
    {
        print("dead");
    }
}
