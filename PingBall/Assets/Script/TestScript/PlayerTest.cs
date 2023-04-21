using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTest : MonoBehaviour
{

    public delegate void PlayerDeathEvent();
    public event PlayerDeathEvent PlayerDeath;
    // Start is called before the first fr()ame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerDeath?.Invoke();
    }

}
