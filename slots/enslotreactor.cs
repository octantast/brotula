using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enslotreactor : MonoBehaviour
{
    [SerializeField] private bool sizenormie;
    [SerializeField] private Vector3 sizeNormie;
    [SerializeField] private Vector3 scaleChange;

    // Start is called before the first frame update
    void Start()
    {
        sizeNormie = new Vector3(1f, 1f, 0f);
        scaleChange = new Vector3(0.01f, 0.01f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (sizenormie) // был запрос вернуть скиллу его нормальный размер
        {
            if (transform.localScale != sizeNormie)
            {
                transform.localScale = Vector3.Lerp(transform.localScale, sizeNormie, 0.05f);
            }
            else
            {
                sizenormie = false;
            }

        }



    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Sizerrr"))
        {
            if (transform.localScale.y < 1.15f)
            {
                transform.localScale += scaleChange;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Sizerrr"))
        {
            sizenormie = true;
        }
    }
}
