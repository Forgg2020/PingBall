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
    public bool ballReady; 
    public bool isTriggered = false;
    public Slider powerSlider;
    Rigidbody rb;

    // Start is called before the first frame update
    private void Start()
    {
        powerSlider.minValue = 0f;
        powerSlider.maxValue = maxPower;
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
                GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerState>().enabled = true;
                if (power > 0)
                {
                    power -= 1500 * Time.deltaTime;
                }
                if(Player.rb != null)
                {
                    Player.rb.AddForce(Vector3.up * power);
                }else if (Player.rb == null) 
                {
                    Player.rb = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();
                }
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