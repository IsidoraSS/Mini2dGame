using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sacmarica : MonoBehaviour
{
    public Transform tackaPucanja1;
    public Transform tackaPucanja2;
    public Transform tackaPucanja3;
    public GameObject metak;

    public float pucnjiPoSekundiRec=1f;
    private float sledeciPucanj = 0f;

    void Update()
    {
        if (Input.GetButtonDown("pucaj") && Time.time>sledeciPucanj)
        {
            sledeciPucanj = Time.time + pucnjiPoSekundiRec;
            pucaj();
        }
    }

    void pucaj()
    {
        Instantiate(metak, tackaPucanja1.position, tackaPucanja1.rotation);
        Instantiate(metak, tackaPucanja2.position, tackaPucanja2.rotation);
        Instantiate(metak, tackaPucanja3.position, tackaPucanja3.rotation);
    }
}
