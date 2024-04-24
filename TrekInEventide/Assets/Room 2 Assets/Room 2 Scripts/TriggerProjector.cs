using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerProjector : MonoBehaviour
{

    [Header("Projector Script")] 
    public ProjectorCycle projectorCycle;

    [Header("Film UI Popup")]
    public GameObject filmUIPuzzle;

    [Header("PlayerController")]
    public FPSController playerController;

    //[Header("Objects")] 

   // [Header("Film")] 

    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("canPickUp"))
        {
            filmUIPuzzle.SetActive(true);
            playerController.enabled = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
