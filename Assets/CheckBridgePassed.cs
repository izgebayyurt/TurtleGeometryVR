using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CheckBridgePassed : MonoBehaviour
{
    public CheckBridgePassed OppositeEntrance;
    public static GameObject LastEntrance;

    private void OnTriggerEnter(Collider other)
    {
        if (LastEntrance != null && LastEntrance == OppositeEntrance.gameObject)
        {
            Destroy(transform.parent.gameObject);
        }
        
        /*if (OppositeEntrance.enabled)
        {
            Destroy(this);
        }*/

        LastEntrance = this.gameObject;
    }
}
