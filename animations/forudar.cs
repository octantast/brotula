using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class forudar : MonoBehaviour
{
    public GameObject udarus;
    public GameObject udarus2;
    public GameObject udarus3;

    public Color32 ggcolor;
    public Color32 vragcolor;
    public GameObject slot1GGsvet;
    public GameObject slot2GGsvet;
    public GameObject slot3GGsvet;
    public GameObject slot4GGsvet;
    public GameObject slot5GGsvet;
    public GameObject slot6GGsvet;
    public GameObject slot7GGsvet;
    public GameObject slot8GGsvet;
    public GameObject slot9GGsvet;
    public GameObject slot1Vragsvet;
    public GameObject slot2Vragsvet;
    public GameObject slot3Vragsvet;
    public GameObject slot4Vragsvet;
    public GameObject slot5Vragsvet;
    public GameObject slot6Vragsvet;
    public GameObject slot7Vragsvet;
    public GameObject slot8Vragsvet;
    public GameObject slot9Vragsvet;

    public Image udar1;
    public Image udar2;
    public Image udar3;
    public Image udar4;
    public Image udar5;
    public Image udar6;


    // Start is called before the first frame update
    void Start()
    {
        Color32 ggcolor = new Color32(255, 255, 255, 255);
        Color32 vragcolor = new Color32(165, 24, 26, 255);
    }

    // Update is called once per frame
    void Update()
    {
        if (slot1Vragsvet.activeSelf == true || slot2Vragsvet.activeSelf == true || slot3Vragsvet.activeSelf == true || slot4Vragsvet.activeSelf == true || slot5Vragsvet.activeSelf == true || slot6Vragsvet.activeSelf == true || slot7Vragsvet.activeSelf == true || slot8Vragsvet.activeSelf == true || slot9Vragsvet.activeSelf == true)
        {
            udar1.color = vragcolor;
            udar2.color = vragcolor;
            udar3.color = vragcolor;
            udar4.color = vragcolor;
            udar5.color = vragcolor;
            udar6.color = vragcolor;
        }
        else if(slot1GGsvet.activeSelf == true || slot2GGsvet.activeSelf == true || slot3GGsvet.activeSelf == true || slot4GGsvet.activeSelf == true || slot5GGsvet.activeSelf == true || slot6GGsvet.activeSelf == true || slot7GGsvet.activeSelf == true || slot8GGsvet.activeSelf == true || slot9GGsvet.activeSelf == true)
        {
            udar1.color = ggcolor;
            udar2.color = ggcolor;
            udar3.color = ggcolor;
            udar4.color = ggcolor;
            udar5.color = ggcolor;
            udar6.color = ggcolor;
        }
    }
}
