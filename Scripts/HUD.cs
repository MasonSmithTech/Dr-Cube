using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    [SerializeField] private Slider healthbar;
    [SerializeField] private GameObject player;

    private int maxHealth;
    public PlayerHealth playerHealth;

    private void OnEnable()
    {
        PlayerHealth.OnPlayerTakeDamage += UpdateHealthBar;
    }

    private void Start()
    {
        playerHealth = player.GetComponent<PlayerHealth>();
        SetupHealthBar();
    }

    private void UpdateHealthBar(int currentHealth)
    {
        healthbar.value = (float)currentHealth / maxHealth;
    }

    private void SetupHealthBar()
    {
        maxHealth = playerHealth.maxHealth;

        healthbar.minValue = 0;
        healthbar.maxValue = 1;

        healthbar.value = (float)playerHealth.currentHealth / maxHealth;
    }

    private void OnDisable()
    {
        PlayerHealth.OnPlayerTakeDamage -= UpdateHealthBar;
    }
}