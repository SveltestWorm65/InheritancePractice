using UnityEngine;

public class RotateTowardMouse : MonoBehaviour
{
    public float rotationSpeed = 360; // Degrees per second

    void Update()
    {
        // Convert mouse position into world coordinates
        Vector3 mouseScreenPosition = Input.mousePosition;
        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(mouseScreenPosition);

        // Adjust for 2D by setting z to gameObject's z
        mouseWorldPosition.z = transform.position.z;

        // Calculate direction from current position to mouse position
        Vector3 directionToMouse = mouseWorldPosition - transform.position;

        // Create a quaternion (rotation) based on looking down the Z-axis with the calculated direction
        Quaternion targetRotation = Quaternion.LookRotation(forward: Vector3.forward, upwards: directionToMouse);

        // Smoothly rotate towards the target rotation. Here we use the corrected method call.
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
    }
}
