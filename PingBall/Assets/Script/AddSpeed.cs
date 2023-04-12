using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddSpeed : MonoBehaviour
{
    AudioSource AS;
    public Transform Ball;
    // Start is called before the first frame update
    public float speed = 10f; // 物體的速度
    Vector3 direction;
    private void Update()
    {
        // 計算目標方向向量
        direction = Ball.position - transform.position;

        // 將方向向量歸一化，使其成為單位向量
        direction.Normalize();

        // 將加速度應用於物體上，使其沿著目標方向移動
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            print(direction);
            print("FK");
            Ball.GetComponent<Rigidbody>().AddForce(direction * speed, ForceMode.Acceleration);
    }
}
