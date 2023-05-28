using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knopkamoving : MonoBehaviour
{
    public battlefinal final;
    public DistanceToCheckpoint distancePoints;
    private Vector2 motherpos;
    private Vector2 hidepos;
    // Start is called before the first frame update
    void Start()
    {
        motherpos = new Vector2(transform.localPosition.x, transform.localPosition.y);
        transform.localPosition = new Vector2(transform.localPosition.x, transform.localPosition.y + 185f);
        hidepos = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (distancePoints.distance >= 5070 && final.deathmode == false)
        {
            transform.localPosition = Vector2.MoveTowards(transform.localPosition, motherpos, 50f);
        }
        else
        {
            transform.localPosition = Vector2.MoveTowards(transform.localPosition, hidepos, 50f);
        }
    }
}