using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerChanger : MonoBehaviour
{
    public GameObject myTrigger;
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            print("yes");
        }
    }

    public void OnTriggerExit(Collider other)
    {
        myTrigger.GetComponent<MeshCollider>().isTrigger = false;
        Invoke("TriggerBack", 1.5f);
    }
    private void TriggerBack()
    {
        myTrigger.GetComponent<MeshCollider>().isTrigger = true;
    }
}
