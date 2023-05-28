using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kruzhok : MonoBehaviour
{
    private Color32 whitecolor;
    private Image itself;
    private Color32 whitecolorreal;
    private bool once;

    void Start()
    {
        itself = GetComponent<Image>();
        whitecolor = new Color32(225, 225, 225, 0);
        whitecolorreal = new Color32(225, 225, 225, 225);
    }

    // Update is called once per frame
    void Update()
    {
        if (once == false)
        {
            once = true;
            itself.color = whitecolorreal;
        }

        if (itself.color != whitecolor)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(1.5f, 1.5f, 0f), 0.05f);
            itself.color = Color.Lerp(whitecolorreal, whitecolor, Mathf.PingPong(Time.time * 2f, 2));
        }
        else
        {
            once = false;
            gameObject.SetActive(false);
        }
    }
}
