using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    public GameObject[] Objects;
    public ProjectorCycle projectorCycle;

    [Header("Projector")]
    public GameObject projectorUI;
    public RaycastProjector raycastProjector;

    [Header("PlayerControls")]
    public FPSController PlayerControls;

    // Update is called once per frame
    void Update()
    {
        bool allActive = true;
        foreach (GameObject obj in Objects)
        {
            if (!obj.activeSelf)
            {
                allActive = false;
                break;
            }
        }

        if (allActive)
        {
            //This can change to enable Game Object with video
            projectorCycle.enabled = true;
            projectorUI.SetActive(false);
            raycastProjector.enabled = false;
            PlayerControls.enabled = true;
            Cursor.visible = false;
        }
    }
}
