using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PlungerTest : MonoBehaviour
{
    [Test]

    public void PowerInitialValueTest()
    {
        var GameObject = new GameObject();
        var PlungerScript = GameObject.AddComponent<Plunger>();

        Assert.That(PlungerScript.power, Is.EqualTo(0f));
    }

}
