using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fortap : MonoBehaviour
{
    public GameObject maliutka;
    public Color32 normalcolor;
    public Color32 transpcolor;
    public Vector3 scaleChange;
    public Vector3 sizeNormie;
    private bool onlyonce;
    public Image malutkin;

    void Start()
    {
        sizeNormie = new Vector3(1.5f, 1.5f, 0f);
        scaleChange = new Vector3(0.5f, 0.5f, 0f);
        malutkin = maliutka.GetComponent<Image>();
    }

    void Update()
    {
        
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            if (onlyonce == false)
            {
                maliutka.SetActive(true);
                onlyonce = true;
                maliutka.transform.localScale = scaleChange; // делает малютку маленькой для начала тапа
                malutkin.color = normalcolor;
            }
            maliutka.transform.position = new Vector2(touch.position.x, touch.position.y); // двигает малютку к пальцу
        }
        else // 0 тапов
        {
            onlyonce = false;
            if (malutkin.color == transpcolor)
            {
                maliutka.SetActive(false);
            }
        }

    }
}
