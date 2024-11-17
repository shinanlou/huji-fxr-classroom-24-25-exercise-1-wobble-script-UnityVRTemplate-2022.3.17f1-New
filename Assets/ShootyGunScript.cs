using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootyGunScript : MonoBehaviour
{
    public GameObject bulletPrefab;      // Reference to the Bullet prefab
    public float bulletSpeed = 10f;      // Speed of the bullet
    public Transform bulletSpawnPoint;   // Where the bullet will spawn (e.g., end of the gun)

    void Update()
    {
        // Check if the mouse button (left-click) is released
        if (Input.GetMouseButtonUp(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Instantiate a new bullet at the spawn point
        GameObject newBullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);

        // Get the Rigidbody2D of the new bullet
        Rigidbody2D bulletRb = newBullet.GetComponent<Rigidbody2D>();

        // Set the bullet's velocity in the direction the gun is facing
        if (bulletRb != null)
        {
            bulletRb.velocity = bulletSpawnPoint.up * bulletSpeed;  // Use the "up" direction of the spawn point to determine the direction
        }

        // Set the bullet to active (it should already be active, but this ensures it is)
        newBullet.SetActive(true);
    }
}
