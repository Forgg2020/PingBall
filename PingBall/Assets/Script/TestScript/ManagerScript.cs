using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerScript : MonoBehaviour
{
    [SerializeField]GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        
        Player.GetComponent<PlayerTest>().PlayerDeath += Playerdead;
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
