using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class subduct : MonoBehaviour
{
    public DistanceToCheckpoint dist;
    public Color32 whitecolorreal;
    public float lerp;
    public SpriteRenderer thissd;

    void Start()
    {
        thissd = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (dist.distance > 12300)
        {
            thissd.color = Color.Lerp(thissd.color, whitecolorreal, Time.deltaTime / 20f);
        }
    }
}