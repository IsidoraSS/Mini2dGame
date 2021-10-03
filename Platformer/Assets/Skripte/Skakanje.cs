using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skakanje : MonoBehaviour
{
    private Rigidbody2D rb;
    public float jacinaSkoka=6;
    private bool naZemlji;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && naZemlji) //obican skok
        {
            rb.velocity = Vector2.up * jacinaSkoka;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Zemlja"))
        {
            naZemlji = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Zemlja"))
        {
            naZemlji = false;
        }
    }
}
