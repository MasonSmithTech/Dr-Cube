using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour

{
    [SerializeField] private int health = 10;
    public int currentHealth {get; private set;}
    public int maxHealth {get; private set;}
    public static Action<int> OnPlayerTakeDamage;
    public Transform respawnAnchor;

    // Start is called before the first frame update
    void Awake()
    {
        currentHealth = health;
        maxHealth = health;
    }

    public void DamagePlayer(int damageAmount)
    {
    currentHealth -= damageAmount;

    if (currentHealth <= 0)
    {
        Rigidbody2D playerRB = GetComponent<Rigidbody2D>();

        if (playerRB != null)
        {
            playerRB.position = respawnAnchor.position;
            playerRB.velocity = Vector2.zero;
        }

        currentHealth = health;
    }

    // Notify HUD AFTER health has been updated
     OnPlayerTakeDamage?.Invoke(currentHealth);
    }
}
