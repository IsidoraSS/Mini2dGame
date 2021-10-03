using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;

public class AutomatskaPuska : MonoBehaviour
{
    public Transform tackaPucanja;
    public GameObject metak;
    public int kolicinaMunicijeUkupno = 30;
    public int velicinaSarzera = 20;
    public StringBuilder municijaGraficki;
    public int uSarzeru;

    public TextMeshPro prikazTeksta;
    public TextMeshPro municijaBroj;

    private void Awake()
    {
        uSarzeru = velicinaSarzera;
        municijaGraficki = napraviString('|', velicinaSarzera);
        prikazTeksta.text = municijaGraficki.ToString();
        municijaBroj.text = kolicinaMunicijeUkupno.ToString();
    }

    void Update()
    {
        if (uSarzeru > 0)
        {
            if (Input.GetButtonDown("pucaj"))
            {
                pucaj();
            }
        }
        else
        {
            reload();
        }
        prikazTeksta.text = municijaGraficki.ToString();
    }

    void pucaj()
    {
        GameObject metak_=(GameObject)Instantiate(metak, tackaPucanja.position, tackaPucanja.rotation);
        uSarzeru--;
        municijaGraficki.Remove(0, 1);
        Destroy(metak_, 10);
    }

    void reload()
    {
        if (Input.GetButtonDown("pucaj"))
        {
            //TODO: pusti zvuk
            Debug.Log("NEMA MUNICIJE");
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (kolicinaMunicijeUkupno > 0)
            {
                if (kolicinaMunicijeUkupno >= velicinaSarzera)
                {
                    uSarzeru = velicinaSarzera;
                    municijaGraficki = napraviString('|', velicinaSarzera);
                    kolicinaMunicijeUkupno -= velicinaSarzera;
                    municijaBroj.text = kolicinaMunicijeUkupno.ToString();
                }
                else
                {
                    uSarzeru = kolicinaMunicijeUkupno;
                    municijaGraficki = napraviString('|', kolicinaMunicijeUkupno);
                    kolicinaMunicijeUkupno = 0;
                    municijaBroj.text = kolicinaMunicijeUkupno.ToString();
                }
                //TODO: pusti zvuk
            }
            else
            {
                //TODO: pusti zvuk
                Debug.Log("NEMA MUNICIJE");
            }
        }
    }

    static StringBuilder napraviString(char input, int times)
    {
        StringBuilder sb = new StringBuilder(input * times);
        for (int i = 0; i < times; i++)
        {
            sb.Append(input);
        }
        return sb;
    }

}
