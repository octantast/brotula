using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class txtappear : MonoBehaviour
{
    public Text itself;
    private Color32 whitecolorreal;

    void Start()
    {
        whitecolorreal = new Color32(165, 24, 26, 225);
    }

    // Update is called once per frame
    void Update()
    {
        itself.color = Color.Lerp(itself.color, whitecolorreal, Time.deltaTime / 0.5f);
    }
}
