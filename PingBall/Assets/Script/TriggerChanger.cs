using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerChanger : MonoBehaviour
{
    public Collider myTrigger;
    public Collider[] ColliderEorD;

    private void Update()
    {
        if(Player.PlayerCol != null)
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
        else if (Player.PlayerCol == null) 
        {
            Player.PlayerCol = GameObject.FindGameObjectWithTag("Player").GetComponent<SphereCollider>();
        }

    }
}

