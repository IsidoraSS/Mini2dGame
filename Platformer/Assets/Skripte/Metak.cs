using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metak : MonoBehaviour
{

    public float brzinaMetka = 10f;
    public GameObject impactEfekat;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.right * brzinaMetka, ForceMode2D.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Zemlja"))
        {
            upucano();
        }
        if (collision.gameObject.CompareTag("Unistivo"))
        {
            Destroy(collision.gameObject);
            upucano();
        }
        if (collision.gameObject.CompareTag("Neprijatelj"))
        {
            upucano();
        }
    }

    void upucano()
    {
        GameObject klon = (GameObject)Instantiate(impactEfekat, transform.position, transform.rotation);
        Destroy(gameObject);
        Destroy(klon, 1f);
    }

}
