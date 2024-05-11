using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableGameObjectAfterTime: MonoBehaviour
{
    public float disableTime = 2.0f; // Time after which the GameObject will be disabled
    private bool hasDisabled = false;
    public GameObject Canvas;

    void Update()
    {
        // If the GameObject hasn't been disabled yet and the time has passed
        if (!hasDisabled && Time.time >= disableTime)
        {
            // Disable the GameObject
            Canvas.SetActive(false);
            hasDisabled = true; // Set the flag to true to prevent repeated disabling
        }
    }
}