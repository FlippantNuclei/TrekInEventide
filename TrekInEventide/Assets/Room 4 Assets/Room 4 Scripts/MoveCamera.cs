using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [Header("Sensitivity + Mouse")]
    public float sensitivity = 2.0f; // Mouse sensitivity

    [Header("Player Camera")]
    public Transform playerBody; // Reference to the player's body (or whatever object you want the camera to rotate around)

    private float rotationX = 0.0f; // Current rotation around the X-axis
    private float rotationY = 0.0f; // Current rotation around the Y-axis

    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked; // Lock the cursor to the center of the screen
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        playerBody.Rotate(Vector3.up * mouseX);

        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -90.0f, 90.0f); // Limit the vertical rotation
        transform.localRotation = Quaternion.Euler(rotationX, 0.0f, 0.0f);

    // Adjust the limit for how much you can look behind
        float maxYRotation = 90.0f; // Limit the rotation to 90 degrees to the left and right
        rotationY = Mathf.Clamp(rotationY + mouseX, -maxYRotation, maxYRotation);
        transform.localRotation *= Quaternion.Euler(0.0f, rotationY, 0.0f);
    }

}