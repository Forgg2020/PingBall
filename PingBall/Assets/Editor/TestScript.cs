using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestScript
{
    // A Test behaves as an ordinary method
    [Test]
    [TestCase(10, '+', 2, 12)]
    [TestCase(10, '-', 2, 8)]
    [TestCase(10, '*', 2, 20)]
    [TestCase(500, '/', 10, 50)]
    [TestCase(20,'+',10,10)]
    public void Calculate_Test(float x, char pointer, float y, float result)
    {
        var Calculator = new Calculator(x, y, pointer);

        var score = Calculator.ScoreCount();

        Assert.That(score, Is.EqualTo(result));
    }
    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator NewTestScriptWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
