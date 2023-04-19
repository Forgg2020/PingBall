using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using BouncyNameSpace;
public class Plunger : TagCollisionTriiger
{
    public float power;
    float minPower;
    public float maxPower = 2000;
    public Slider powerSlider;
    public bool ballReady; 
    public bool isTriggered = false;  // 是否有物體觸發

    Rigidbody rb;

    // Start is called before the first frame update
    private void Start()
    {
        powerSlider.minValue = 0f;
        powerSlider.maxValue = maxPower;
        rb = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();
    }

    public void Update()
    {
        
        powerSlider.value = power;
        if (ballReady)
        {
            powerSlider.gameObject.SetActive(true);
            if (Input.GetKey(KeyCode.Space))
            {
                if (power <= maxPower)
                {
                    power += 1000 * Time.deltaTime;
                }
            }
            if (Input.GetKeyUp(KeyCode.Space))
            {
                if (power > 0)
                {
                    power -= 1500 * Time.deltaTime;
                }
                rb.AddForce(Vector3.up * power);
                StartCoroutine(DecreasePower());
            }
            if (power < 0)
            {
                power = 0;
            }
        }
        else
        {
            powerSlider.gameObject.SetActive(false);
        }
    }
    public IEnumerator DecreasePower()
    {
        float startTime = Time.time;
        float endTime = startTime + 2f;

        while (Time.time < endTime)
        {
            float t = (Time.time - startTime) / 2f;
            power = Mathf.Lerp(power, 0.0f, t);
            yield return null;
        }
    }

    protected override void onTriggerPlayer(Collider other)
    {
        ballReady = true;
        isTriggered = true;
    }

    protected override void onTriggerPlayerOut(Collider other)
    {        
        isTriggered = false;
    }
}