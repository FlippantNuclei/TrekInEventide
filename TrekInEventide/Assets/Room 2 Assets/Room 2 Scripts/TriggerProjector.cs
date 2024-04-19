using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerProjector : MonoBehaviour
{

    public ProjectorCycle projectorCycle;

    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("canPickUp"))
        {
            projectorCycle.enabled = true;
        }
    }
}
