﻿using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 100; // Maximum health of the enemy.
    private int currentHealth; // Current health of the enemy.

    // Called when the enemy is initialized.
    private void Start()
    {
        currentHealth = maxHealth; // Set the initial health to the maximum health.
    }

    // Function to apply damage to the enemy.
    public void TakeDamage(int damageAmount)
    {
        // Reduce the current health by the damage amount.
        currentHealth -= damageAmount;

        // Check if the enemy's health has reached zero or below.
        if (currentHealth <= 0)
        {
            Die(); // Call the function to handle the enemy's death.
        }
    }

    // Function to handle the enemy's death.
    private void Die()
    {
        gameObject.GetComponent<Animator>().SetBool("Death", true);
    }
}
