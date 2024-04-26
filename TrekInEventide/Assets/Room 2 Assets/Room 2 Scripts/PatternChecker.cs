using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PatternChecker : MonoBehaviour
{
    public Image[] images; // Array to hold the images
    public BoxCollider[] colliders; // Array to hold the BoxCollider2D components for each spot
    [Header("Projector Script")] 
    public ProjectorCycle projectorCycle;
    

    public void OnTriggerEnter()
    {
        CheckPattern();
    }
    public void CheckPattern()
    {
        // Check if the number of images matches the number of colliders
        if (images.Length != colliders.Length)
        {
            Debug.Log("Number of images and colliders do not match.");
            return;
        }

        // Check if each image is within its corresponding collider
        for (int i = 0; i < images.Length; i++)
        {
            if (!colliders[i].bounds.Contains(images[i].transform.position))
            {
                Debug.Log("Image " + (i + 1) + " is not in the correct position.");
                return;
            }
        }

        // If all images are in their correct positions, trigger the action
        projectorCycle.enabled = true;
        Debug.Log("Action triggered.");
    }
}