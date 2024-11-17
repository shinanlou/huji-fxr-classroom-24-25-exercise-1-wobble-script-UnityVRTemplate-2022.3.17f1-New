using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunAimScript : MonoBehaviour
{
    private Camera mainCamera; // Reference to the main camera

    void Start()
    {
        // Get the main camera
        mainCamera = Camera.main;
    }

    void Update()
    {
        AimGun();
    }

    void AimGun()
    {
        // Get the mouse position in screen space
        Vector3 mouseScreenPosition = Input.mousePosition;

        // Convert the mouse position from screen space to world space
        Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(mouseScreenPosition);

        // Get the direction from the gun to the mouse
        Vector3 direction = mouseWorldPosition - transform.position;

        // Remove the z-axis, since we only care about 2D rotation
        direction.z = 0;

        // Calculate the rotation angle in radians using Mathf.Atan2
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Apply the rotation to the gun (set the z-axis rotation)
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}

