using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameSwitch : MonoBehaviour
{
    public battlefinal final;

    private float timer;
    private bool schet;
    public GameObject activeFrame;

    private void Update()
    {
        if(timer > 0 && schet)
        {
            timer -= Time.deltaTime;
        }
        else if(timer <= 0 && schet && final.deathmode == false)
        {
            activeFrame.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            activeFrame.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            timer = 1.5f;
            schet = true;
        }
    }
}
