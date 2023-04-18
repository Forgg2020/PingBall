using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    private void Start()
    {
        PowerMaxValueTest();
    }
    public void PowerMaxValueTest()
    {
        var GameObject = new GameObject();
        var PlungerScript = GameObject.AddComponent<Plunger>();

        PlungerScript.ballReady = true;

        for (float t = 0f; t <= 3f; t += Time.deltaTime)
        {
            PlungerScript.Update();
            //PlungerScript.powerSlider.value = PlungerScript.power;
        }

        print(PlungerScript.power);
        //Assert.That(PlungerScript.power, Is.EqualTo(PlungerScript.maxPower));
    }
}
