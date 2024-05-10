using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectorCycle : MonoBehaviour
{
    public GameObject[] objectsToCycle; // Array of GameObjects to cycle through
    public GameObject projectorLight;
    public GameObject projectorSound; // Reference to the ProjectorLight GameObject
    public float cycleInterval = 1.0f; // Interval between cycling in seconds
    private int currentIndex = 0; // Index of the current active GameObject
    private bool fourthActivated = false; // Flag to track if the fourth GameObject has been activated

    void Start()
    {
        // Ensure at least one GameObject is provided
        if (objectsToCycle.Length == 0)
        {
            Debug.LogError("No GameObjects assigned to cycle through!");
            enabled = false;
            return;
        }

        // Activate the first GameObject and deactivate others
        SetActiveObject(currentIndex);

        // Start cycling through GameObjects based on the specified interval
        InvokeRepeating("CycleObjects", cycleInterval, cycleInterval);
    }

    // Method called at regular intervals to cycle through GameObjects
    void CycleObjects()
    {
        // If we've already activated the fourth GameObject, do nothing
        if (fourthActivated)
            return;

        // Deactivate the current GameObject
        objectsToCycle[currentIndex].SetActive(false);

        // Move to the next index
        currentIndex++;

        // If we reached the end of the array, activate the fourth GameObject
        if (currentIndex >= objectsToCycle.Length)
        {
            currentIndex = objectsToCycle.Length - 1; // Set index to the last GameObject
    
    // Activate the last GameObject
            objectsToCycle[currentIndex].SetActive(true);

    // Deactivate the projector light and sound
            if (projectorLight != null && projectorSound != null)
            {
                projectorSound.SetActive(false);
                projectorLight.SetActive(false);
            }

            fourthActivated = true; // Mark the fourth GameObject as activated
            CancelInvoke("CycleObjects"); // Stop cycling
            return;
        }
        // Activate the next GameObject
        SetActiveObject(currentIndex);
    }

    // Helper method to activate the GameObject at the specified index
    void SetActiveObject(int index)
    {
        objectsToCycle[index].SetActive(true);
    }
}