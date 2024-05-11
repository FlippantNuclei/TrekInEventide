using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RaycastForExitDoor : MonoBehaviour
{
    public float interactionDistance = 2f; // Distance from the camera to interact
    public LayerMask ExitDoor; // Layer mask for the objects to interact with

    [Header("PRESS E")]
    public GameObject PressE;

    [Header("Animator")]
    public Animator FadeScreen;
    public int sceneTime = 1;
    

    void Update()
    {
        // Draw a debug ray to visualize the raycast
        Debug.DrawRay(transform.position, transform.forward * interactionDistance, Color.red);

        bool hitDoor = Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, interactionDistance, ExitDoor);

        if (hitDoor)
        {
            // Check if the object hit has the "Projector" layer
            if (hit.collider.gameObject.layer == LayerMask.NameToLayer("ExitDoor"))
            {
                PressE.SetActive(true);
                // Check if the player pressed the E key
                if (Input.GetKeyDown(KeyCode.E))
                {
                    StartCoroutine(ChangeScene());
                    FadeScreen.SetTrigger("FadeOut");
                    
                  
                }
            }
        }
        else
        {
            // If raycast doesn't hit a projector, deactivate PressE
            PressE.SetActive(false);
        }
    }

    public IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(sceneTime);
        SceneManager.LoadScene(1);
    }
}
