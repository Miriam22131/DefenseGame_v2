using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowPile : MonoBehaviour
{
    public float damage = 10f; // Amount of damage dealt
    public float slowEffect = 0.5f; // Slow effect multiplier (0.5 means 50% speed)
    public float slowDuration = 3f; // Duration of the slow effect

    private void OnTriggerEnter(Collider other)
    {
        // Check if the other object has a Health component
        Health health = other.GetComponent<Health>();
        if (health != null)
        {
            // Deal damage
            health.TakeDamage(damage);

            // Check if the other object has a Movement component
            Movement movement = other.GetComponent<Movement>();
            if (movement != null)
            {
                // Apply slow effect
                movement.ApplySlow(slowEffect, slowDuration);
            }
        }
    }
}