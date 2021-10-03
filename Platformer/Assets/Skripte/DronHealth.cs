using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DronHealth : MonoBehaviour
{
    public int maxHealthDron = 100;
    public int healthDron;
    void Start()
    {
        healthDron = maxHealthDron;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Metak"))
        {
            if (healthDron > 0)
            {
                healthDron -= 5;
            }
            else Destroy(gameObject);
        }
    }
}
