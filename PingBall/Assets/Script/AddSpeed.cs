using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddSpeed : MonoBehaviour
{
    AudioSource AS;
    public Transform Ball;
    // Start is called before the first frame update
    public float speed = 10f; // ���骺�t��
    Vector3 direction;
    private void Update()
    {
        // �p��ؼФ�V�V�q
        direction = Ball.position - transform.position;

        // �N��V�V�q�k�@�ơA�Ϩ䦨�����V�q
        direction.Normalize();

        // �N�[�t�����Ω���W�A�Ϩ�u�ۥؼФ�V����
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            print(direction);
            print("FK");
            Ball.GetComponent<Rigidbody>().AddForce(direction * speed, ForceMode.Acceleration);
    }
}
