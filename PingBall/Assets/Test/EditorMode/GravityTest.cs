using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using BouncyNameSpace;

public class GravityTest : MonoBehaviour
{
    [Test]

    [TestCase]

    public void GravityT()
    {
        var Gravity = new GravityGenerater();

        Assert.AreEqual(Gravity.gravity, Vector3.down * 9.8f);
    }
}