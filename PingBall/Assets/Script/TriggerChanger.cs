using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerChanger : MonoBehaviour
{
    public Collider myTrigger;
    public Collider[] ColliderEorD;    

    private void Update()
    {
        if (Manager.Ball.GetComponent<SphereCollider>().bounds.Intersects(ColliderEorD[0].bounds)) //Disable
        {
            myTrigger.isTrigger = true;
        }
        if (Manager.Ball.GetComponent<SphereCollider>().bounds.Intersects(ColliderEorD[1].bounds)) //Enable
        { 
            myTrigger.isTrigger = false;
        }
    }
}
