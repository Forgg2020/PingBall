using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    private void OncollisionEnter(Collision collision)
    {
        GameObject objA = collision.gameObject; // ���o�I������ A
        GameObject objB = collision.gameObject; // ���o�I������ B
        if(objA.tag == "Player" && objB.tag == "Bouncy") // �p�G A �O���Ҭ� "A" ������AB �O���Ҭ� "B" ������
        {
            print("Bom");
        }
    }
}