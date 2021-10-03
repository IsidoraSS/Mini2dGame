using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodajMuniciju : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (collision.gameObject.GetComponentInChildren<AutomatskaPuska>() != null)
            {
                AutomatskaPuska puska = collision.gameObject.GetComponentInChildren<AutomatskaPuska>();
                puska.kolicinaMunicijeUkupno += 30;
                puska.municijaBroj.text = puska.kolicinaMunicijeUkupno.ToString();
                Destroy(gameObject);
            }
            if (collision.gameObject.GetComponentInChildren<Sacmarica>() != null)
            {
                // TODO: dodaj dodavanje municije za sacmaricu
            }
        }
    }

}
