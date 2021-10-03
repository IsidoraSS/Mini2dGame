using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotiranjePuske : MonoBehaviour
{

    private SpriteRenderer sr;

    public float brzinaOkretanja = 100f;
    public Texture2D kursor;
    bool okrenut_;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        Cursor.visible = true;
        Cursor.SetCursor(kursor, new Vector2(kursor.width/2,kursor.height/2), CursorMode.Auto);
    }

    void Update()
    {
        okrenut_ = transform.parent.GetComponent<Kretanje>().okrenut;
        Vector2 smer = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float ugao = Mathf.Atan2(smer.y, smer.x)*Mathf.Rad2Deg;
        Quaternion rotacija = Quaternion.AngleAxis(ugao, Vector3.forward);
        if ((ugao >= 0 && ugao <= 30) && !okrenut_)
        {
            sr.flipY = false;
            transform.rotation = Quaternion.Slerp(transform.rotation, rotacija, brzinaOkretanja * Time.deltaTime);
        }
        else if ((ugao >= 150 && ugao <= 180) && okrenut_)
        {
            sr.flipY = true;
            transform.rotation = Quaternion.Slerp(transform.rotation, rotacija, brzinaOkretanja * Time.deltaTime);
        }
    }
}
