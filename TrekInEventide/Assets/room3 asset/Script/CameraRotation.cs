using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public float rotationSpeed = 5f; // Adjust the rotation speed as needed
    public float maxRotationAngle = 45f; // Maximum rotation angle in degrees

    private void Update()
    {
        // Rotate the camera horizontally using A/D keys
        float rotationInput = Input.GetAxis("Horizontal");
        float rotationAmount = rotationInput * rotationSpeed * Time.deltaTime;
        transform.Rotate(0f, rotationAmount, 0f);

        // Clamp the rotation to a limited scale
        Vector3 currentRotation = transform.localRotation.eulerAngles;
        currentRotation.y = Mathf.Clamp(currentRotation.y, -maxRotationAngle, maxRotationAngle);
        transform.localRotation = Quaternion.Euler(currentRotation);
    }
}
