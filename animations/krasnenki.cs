using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class krasnenki : MonoBehaviour
{
    private Color32 redcolor;
    private Color32 lightredcolor;
    private int randomizer;

    // Start is called before the first frame update
    void Start()
    {
        Color32 redcolor = new Color32(97, 14, 14, 255);
        Color32 lightredcolor = new Color32(135, 0, 2, 255);
        randomizer = Random.Range(1, 3);
        switch (randomizer)
        {
            case 1:
                foreach (Transform child in transform)
                {
                    child.gameObject.GetComponent<Renderer>().material.color = redcolor;

                }
                if (this.name == "Cirrat(Clone)")
                {
                    transform.GetChild(2).gameObject.GetComponent<Renderer>().material.color = lightredcolor;
                    transform.GetChild(3).gameObject.GetComponent<Renderer>().material.color = lightredcolor;
                    transform.GetChild(6).gameObject.GetComponent<Renderer>().material.color = lightredcolor;
                }
                else if (this.name == "Nemin(Clone)")
                {
                    transform.GetChild(3).gameObject.GetComponent<Renderer>().material.color = lightredcolor;
                }
                else if (this.name == "Phobel(Clone)")
                {
                    transform.GetChild(3).gameObject.GetComponent<Renderer>().material.color = lightredcolor;
                }
                else if (this.name == "Heeth(Clone)")
                {
                    transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = lightredcolor;
                    transform.GetChild(2).gameObject.GetComponent<Renderer>().material.color = lightredcolor;
                    transform.GetChild(3).gameObject.GetComponent<Renderer>().material.color = lightredcolor;
                    transform.GetChild(5).gameObject.GetComponent<Renderer>().material.color = lightredcolor;
                }
                else if (this.name == "Sciph(Clone)")
                {
                    transform.GetChild(2).gameObject.GetComponent<Renderer>().material.color = lightredcolor;
                }
                break;
            default:
                break;
        }

    }
}
