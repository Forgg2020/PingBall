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
        if (Player != null)
        {
            print("sus");
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void Playerdead()
    {
        print("dead");
    }
}
