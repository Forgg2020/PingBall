using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plunger_Script : MonoBehaviour
{
    float power;
    float minPower;
    public float maxPower = 100;
    public Slider powerSlider;
    List<Rigidbody> ballList;
    bool ballReady; 
    public bool isTriggered = false;  // 是否有物體觸發
    //private float timer = 0.0f;        // 計時器

    // Start is called before the first frame update
    void Start()
    {
        powerSlider.minValue = 0f;
        powerSlider.maxValue = maxPower;
        ballList = new List<Rigidbody>();
    }

    void Update()
    {
        powerSlider.value = power;
        if (ballReady)
        {
            powerSlider.gameObject.SetActive(true);
        }else
        {
            powerSlider.gameObject.SetActive(false);
        }        

        if(ballList.Count > 0)
        {
            ballReady = true;
            if (Input.GetKey(KeyCode.Space))
            {
                if(power <= maxPower)
                {
                    power += 50 * Time.deltaTime;
                }
            }
            if (Input.GetKeyUp(KeyCode.Space))
            {
                power -= 10 * Time.deltaTime;
                foreach (Rigidbody r in ballList)
                {
                    r.AddForce(Vector3.up * power * 0.1f);
                    print(power);
                }

                if(isTriggered == false)
                {
                    power -= 50 * Time.deltaTime;
                }
            }
            //if(isTriggered)
            //{
            //    power -= 200 * Time.deltaTime;
            //}
        }
        else
        {
            ballReady = false;
            power = 0f;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            ballList.Add(other.gameObject.GetComponent<Rigidbody>());
            ballReady = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isTriggered = false;
        }
    }
}
