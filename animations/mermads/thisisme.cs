using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class thisisme : MonoBehaviour
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
            itself.color = whitecolor;
        }

        itself.color = Color.Lerp(itself.color, whitecolorreal, Time.deltaTime / 0.5f);
    }
}
