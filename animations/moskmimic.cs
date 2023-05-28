using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moskmimic : MonoBehaviour
{
    public Color32 transpcolorus;
    public Color32 nottranspcolor;
    private float lerp;
    public Image imager;

    void Start()
    {
        imager = GetComponent<Image>();
    }
    // Update is called once per frame
    void Update()
    {
        lerp = Mathf.PingPong(Time.time, 1.5f) / 1.5f;
        imager.color = Color.Lerp(transpcolorus, nottranspcolor, lerp);
    }
}
