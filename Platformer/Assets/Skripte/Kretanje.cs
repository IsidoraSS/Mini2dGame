using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kretanje : MonoBehaviour
{
    public Rigidbody2D rb;
    public SpriteRenderer sr;
    public float brzinaKretanja;
    public bool okrenut = false;
    private GameObject puska;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        puska = transform.GetChild(0).gameObject;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            if (!okrenut)
            {
                puska.GetComponent<RotiranjePuske>().enabled = false;
                transform.Rotate(0f, 180f, 0f);
                puska.GetComponent<RotiranjePuske>().enabled = true;
                okrenut = true;
            }
            rb.velocity = new Vector2(-brzinaKretanja,rb.velocity.y);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            if (okrenut)
            {
                puska.GetComponent<RotiranjePuske>().enabled = false;
                transform.Rotate(0f, 180f, 0f);
                puska.GetComponent<RotiranjePuske>().enabled = true;
                okrenut = false;
            }
            rb.velocity = new Vector2(brzinaKretanja,rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
        
    }
}
