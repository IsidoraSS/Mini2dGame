using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodajZivot : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Health h = collision.gameObject.GetComponent<Health>();
            h.health = h.maxHealth;
            h.healthBar.healthNaMax(h.maxHealth);
            Destroy(gameObject);
        }
    }
}
