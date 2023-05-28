using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mimicria : MonoBehaviour
{
    private Color32 redcolor = new Color32(114, 15, 16, 255);
    private Color32 whitecolor = new Color32(255, 255, 255, 255);
    private float lerp;
    public List<Renderer> listformimcry;

    void Start()
    {
        foreach (Transform child in transform)
        {
            listformimcry.Add(child.gameObject.GetComponent<Renderer>());
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        lerp = Mathf.PingPong(Time.time, 12f) / 12f;
        foreach (Renderer tempObject in listformimcry)
        {
            tempObject.material.color = Color.Lerp(whitecolor, redcolor, lerp);
        }
    }
}
