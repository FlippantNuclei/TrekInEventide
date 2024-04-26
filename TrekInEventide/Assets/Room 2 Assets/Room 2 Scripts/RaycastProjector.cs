using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastProjector : MonoBehaviour
{
    public float interactionDistance = 2f; // Distance from the camera to interact
    public LayerMask Projector; // Layer mask for the objects to interact with


    [Header("Projector Script")] 
    public ProjectorCycle projectorCycle;

    [Header("Film UI Popup")]
    public GameObject filmUIPuzzle;

    [Header("PlayerController")]
    public FPSController playerController;

    void Update()
    {
        // Cast a ray from the camera forward
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, interactionDistance, Projector))
        {
            // Check if the object hit has the "Projector" layer
            if (hit.collider.gameObject.layer == LayerMask.NameToLayer("Projector"))
            {
                // Check if the player pressed the E key
                if (Input.GetKeyDown(KeyCode.E))
                {
                    filmUIPuzzle.SetActive(true);
                    playerController.enabled = false;
                    Cursor.visible = true;
                    Cursor.lockState = CursorLockMode.None;
                    
                }
            }
        }
    }
}
