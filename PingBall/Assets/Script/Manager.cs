using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [Header("碰撞")]
    public GameObject[] Plus_GameObject;
    public GameObject Ball;
    Collider[] col;

    private void Start()
    {
        Plus_GameObject = GameObject.FindGameObjectsWithTag("Space");

        for (int i = 0; i >= 20; i++)
        {
            col[i] = Plus_GameObject[i].GetComponent<Collider>();
        }
    }


    private void OncOnCollisionEnter(Collider other)
    {
        for(int i = 0; i  >=20; i++)
        {
            //if (Plus_GameObject[i].tag == "Bouncy" && objB.tag == "Bouncy") // 如果 A 是標籤為 "A" 的物體，B 是標籤為 "B" 的物體
            //{
            //    print("Bom");
            //}
        }
    }
}