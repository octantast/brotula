using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class justimgchange : MonoBehaviour
{

    private Color32 whitecolor;
    private Color32 whitecolorreal;
    private Image malutkin;
    private float randomlerp;

    // Start is called before the first frame update
    void Start()
    {
        whitecolor = new Color32(91, 91, 91, 225);
        whitecolorreal = new Color32(225, 225, 225, 0);
        malutkin = GetComponent<Image>();
        randomlerp = Random.Range(2f, 6f);
    }

    // Update is called once per frame
    void Update()
    {
        malutkin.color = Color.Lerp(whitecolor, whitecolorreal, Mathf.PingPong(Time.time, randomlerp) / randomlerp);
    }
}
