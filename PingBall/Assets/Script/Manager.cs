using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    private void OncollisionEnter(Collision collision)
    {
        GameObject objA = collision.gameObject; // 取得碰撞物體 A
        GameObject objB = collision.gameObject; // 取得碰撞物體 B
        if(objA.tag == "Player" && objB.tag == "Bouncy") // 如果 A 是標籤為 "A" 的物體，B 是標籤為 "B" 的物體
        {
            print("Bom");
        }
    }
}