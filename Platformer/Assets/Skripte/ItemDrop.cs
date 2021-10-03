using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDrop : MonoBehaviour
{
    public GameObject municija;
    public GameObject zivot;
    
    void stvoriItem()
    {
        int random = UnityEngine.Random.Range(0, 2);
        switch (random)
        {
            case 0:
                Instantiate(municija, transform.position, transform.rotation);
                break;
            case 1:
                Instantiate(zivot, transform.position, transform.rotation);
                break;
            case 2:
                break;
            default:
                break;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Metak"))
        {
            Destroy(gameObject);
            stvoriItem();
        }
    }
}
