using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [Header("�I��")]
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
            //if (Plus_GameObject[i].tag == "Bouncy" && objB.tag == "Bouncy") // �p�G A �O���Ҭ� "A" ������AB �O���Ҭ� "B" ������
            //{
            //    print("Bom");
            //}
        }
    }
}