using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [Header("¸I¼²")]
    public GameObject[] Plus_GameObject;
    public Collider[] col;
    public GameObject Ball;
    public Collider Ballcol;


    public void Start()
    {
        Plus_GameObject = GameObject.FindGameObjectsWithTag("Space");

        col = new Collider[5]; // ªì©l¤Æ Collider °}¦C

        for (int i = 0; i < 5; i++)
        {
            col[i] = Plus_GameObject[i].GetComponent<BoxCollider>();
        }

        Ballcol = Ball.GetComponent<SphereCollider>();
    }

    private void Update()
    {
        for (int i = 0; i < 5; i++)
        {
            if (col[i].bounds.Intersects(Ballcol.bounds))
            {
                print("end");
            }
        }
    }
    public void OncOnCollisionEnter(Collider other)
    {
        
    }
}