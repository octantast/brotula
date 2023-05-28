using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class maliutkasript : MonoBehaviour
{

    public fortap batko;
    public Image malutkin;


    // Start is called before the first frame update
    void Start()
    {
        malutkin = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        // это было для тапа
        malutkin.color = Color.Lerp(malutkin.color, batko.transpcolor, Mathf.PingPong(Time.time, 7f) / 7f);
        transform.localScale = Vector3.Lerp(transform.localScale, batko.sizeNormie, 0.2f);
    }
}
