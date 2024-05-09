using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController: MonoBehaviour
{
    public Animator camAnim;
    public bool isAnimating = false;
    public float animationResetTime = 1.5f; // Adjust this as needed

    void Start()
    {
        Cursor.visible = true;
    }

    void Update()
    {
        // Check if the animation is not currently playing
        if (!isAnimating)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                // Set the flag to indicate that animation is playing
                isAnimating = true;
                camAnim.SetTrigger("Right");
                StartCoroutine(ResetAnimationFlag(animationResetTime));
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                // Set the flag to indicate that animation is playing
                isAnimating = true;
                camAnim.SetTrigger("Left");
                StartCoroutine(ResetAnimationFlag(animationResetTime));
            }
        }
    }

    IEnumerator ResetAnimationFlag(float delay)
    {
        // Wait for the specified delay
        yield return new WaitForSeconds(delay);

        // Reset the flag to indicate that animation is complete
        isAnimating = false;
    }
}