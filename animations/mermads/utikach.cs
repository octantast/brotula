using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class utikach : MonoBehaviour
{
    public float timer;
    public bool otschot;
    public bool pobeg;

    void Start()
    {
        timer = 10f;
    }

    void Update()
    {
        if (otschot && timer > 0) // если есть взм убежать, время отсчитывается
        {
            timer -= Time.deltaTime;
        }
        else if (otschot && timer <= 0) // побег состоится
        {
            pobeg = true;
            otschot = false;
        }

        if(pobeg) // сам побег
        {
            transform.position = new Vector3(transform.position.x, Mathf.Lerp(transform.position.y, transform.position.y - 10, 1 * Time.deltaTime), transform.position.z);
        }

    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            otschot = false; // не дает убежать
        }

        if (other.CompareTag("Utikach"))
        {
            otschot = true; // не дает убежать
        }

        if (other.CompareTag("Merman"))
        {
            DestroyObject(this);
        }

        
    }
}