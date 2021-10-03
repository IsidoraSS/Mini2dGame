using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public HealthBar healthBar;
    public int maxHealth = 100;
    public int health;
    void Start()
    {
        health = maxHealth;
        healthBar.healthNaMax(maxHealth);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Metak"))
        {
            if (health > 0)
            {
                health -= 5;
                healthBar.namestiHealth(health);
            }
            else
            {
                FindObjectOfType<GameOver>().gameOver();
            }
        }
    }

}
