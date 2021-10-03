using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoljeSkakanje : MonoBehaviour
{

    public float gravitacijaPada=3f;
    public float jacinaSkoka = 2f;
    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector2.up * Time.deltaTime * Physics2D.gravity.y * (gravitacijaPada-1);
        }
        else if(rb.velocity.y>0 && !Input.GetKey(KeyCode.Space))
        {
            rb.velocity += Vector2.up * Time.deltaTime * Physics2D.gravity.y * jacinaSkoka;
        }
    }
}
