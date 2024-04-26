using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectorExit : MonoBehaviour
{

    [Header("Projector Script")] 
    public ProjectorCycle projectorCycle;

    [Header("Film UI Popup")]
    public GameObject filmUIPuzzle;

    [Header("PlayerController")]
    public FPSController playerController;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            filmUIPuzzle.SetActive(false);
            playerController.enabled = true;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
