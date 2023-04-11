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
    private float timer = 0.0f;        // 計時器

    // Start is called before the first frame update
    void Start()
    {
        powerSlider.minValue = 0f;
        powerSlider.maxValue = maxPower;
        ballList = new List<Rigidbody>();
    }

    // Update is called once per frame
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
                foreach(Rigidbody r in ballList)
                {
                    r.AddForce(Vector3.up * power * 5);
                    print(power);
                }
            }
            if(isTriggered)
            {
                power -= 200 * Time.deltaTime;
            }
        }
        else
        {
            ballReady = false;
            power = 0f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            ballList.Add(other.gameObject.GetComponent<Rigidbody>());
            ballReady = true;
            isTriggered = false;
            //print(ballList.Count);
            //print(ballReady);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // ballList.Remove(other.gameObject.GetComponent<Rigidbody>());
            //print(ballReady);
            StartCoroutine(WaitForPrint());
            isTriggered = true;
            timer = 0.0f;
        }
    }

    private IEnumerator WaitForPrint()
    {
        while (timer < 2.0f)
        {
            yield return null;

            if (isTriggered)  // 如果再度碰到
            {
                timer = 0.0f;
                isTriggered = false;
            }
            else
            {
                timer += Time.deltaTime;
            }
        }       
        power = 0f;
        ballReady = false;
    }
}
