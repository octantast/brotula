using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class blokcolor : MonoBehaviour
{
    public Levels leveler;
    public battleplayer playingmode;
    private float lerp;

    public Image thisimage;

    void Start()
    {
        thisimage = GetComponent<Image>();
    }
    // Update is called once per frame
    void Update()
    {
        if (leveler.animateo == 1)
        {
            lerp = Mathf.PingPong(Time.time, 10f) / 10f;
            if (thisimage.color != playingmode.normalcolor)
            {
                thisimage.color = Color.Lerp(playingmode.normalcolor, thisimage.color, lerp);
            }
        }
        else if (leveler.animateo == 2)
        {
            lerp = Mathf.PingPong(Time.time, 8f) / 8f;
            if (thisimage.color != playingmode.normalcolor)
            {
                thisimage.color = Color.Lerp(playingmode.normalcolor, thisimage.color, lerp);
            }
        }


    }
}
