using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DronKretanje : MonoBehaviour
{
    [SerializeField]
    private float brzinaDrona=2;
    [SerializeField]
    private Vector3[] lokacijeDrona;
    private int i;
    private void Start()
    {
        i = 0;
    }
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, lokacijeDrona[i],Time.deltaTime*brzinaDrona);
        if (transform.position == lokacijeDrona[i])
        {
            if (i == lokacijeDrona.Length - 1)
            {
                i = 0;
            }
            else i++;
        }
    }
}
