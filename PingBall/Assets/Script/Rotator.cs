using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float totalTime = 5f; // ã`ŽžŠÔ
    private float timeLeft = 0f;
    public int minRotationVaule = 40;
    public int maxRotationVaule = 50;


    private void Start()
    {
        timeLeft = totalTime;
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {
        while (timeLeft > 0)
        {
            yield return new WaitForSeconds(1f);
            timeLeft--;
        }

    }
}
