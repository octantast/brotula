using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chorn : MonoBehaviour
{
    private Color32 blackcolor;
    private int randomizer;

    // Start is called before the first frame update
    void Start()
    {
        Color32 blackcolor = new Color32(64, 64, 64, 255);
        randomizer = Random.Range(1, 3);
        switch (randomizer)
        {
            case 1:
                foreach (Transform child in transform)
                {
                    child.gameObject.GetComponent<Renderer>().material.color = blackcolor;

                }
                break;
            default:
                break;
        }

    }



}
