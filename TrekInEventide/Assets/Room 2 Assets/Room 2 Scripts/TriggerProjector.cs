using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerProjector : MonoBehaviour
{

    [Header("Projector Script")] 
    public ProjectorCycle projectorCycle;

   // [Header("Film")] 

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
