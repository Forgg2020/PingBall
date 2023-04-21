using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerChanger : MonoBehaviour
{
    public Collider myTrigger;
    public Collider[] ColliderEorD;
    public bool TopandDown;
    public Collider[] ColliderTopandDown;

    

    private void Update()
    {
        if (myTrigger != null)
        {
            if (Player.PlayerCol.bounds.Intersects(ColliderEorD[0].bounds)) //Disable
            {
                myTrigger.isTrigger = true;
            }
            if (Player.PlayerCol.bounds.Intersects(ColliderEorD[1].bounds)) //Enable
            {
                myTrigger.isTrigger = false;
            }
        }
    }
}

