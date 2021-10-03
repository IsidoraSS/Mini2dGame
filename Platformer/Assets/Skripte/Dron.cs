using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dron : MonoBehaviour
{
    public Transform tackaPucanjaDron;
    public GameObject metak;
    public GameObject player;
    public float pucnjiPoSekundiDronRec = 1f;
    private float sledeciPucanj = 0f;

    private void Update()
    {
        Vector2 smerPucanja = player.transform.position - tackaPucanjaDron.position;
        float ugaoPucanja= Mathf.Atan2(smerPucanja.y, smerPucanja.x) * Mathf.Rad2Deg;
        Quaternion rotacijaPucanja = Quaternion.AngleAxis(ugaoPucanja, Vector3.forward);
        tackaPucanjaDron.rotation = Quaternion.Slerp(tackaPucanjaDron.rotation, rotacijaPucanja, 100f * Time.deltaTime);
        if (Time.time > sledeciPucanj)
        {
            sledeciPucanj = Time.time + pucnjiPoSekundiDronRec;
            pucaj();
        }
    }

    private void pucaj()
    {
        GameObject metak_ = (GameObject)Instantiate(metak, tackaPucanjaDron.position, tackaPucanjaDron.rotation);
        Destroy(metak_, 10);
    }

}
