using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomlight : MonoBehaviour
{
    [SerializeField] private GameObject one;
    [SerializeField] private GameObject two;
    [SerializeField] private GameObject three;
    [SerializeField] private GameObject vrashalka;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {

        one = transform.GetChild(0).gameObject;
        two = transform.GetChild(1).gameObject;
        three = transform.GetChild(2).gameObject;
        vrashalka = transform.GetChild(3).gameObject;
        one.SetActive(false);
        two.SetActive(false);
        three.SetActive(false);
        timer = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer < 0f)
        {
            timer = 0.5f;
            one.SetActive(false);
            two.SetActive(false);
            three.SetActive(false);
        }
        if (timer >= 0.5f)
        {
            switch (Random.Range(0, 3))
            {
                case 1:
                    one.transform.position = vrashalka.transform.position;
                    one.SetActive(true);
                    two.SetActive(false);
                    three.SetActive(false);
                    break;
                case 2:
                    two.transform.position = vrashalka.transform.position;
                    one.SetActive(false);
                    two.SetActive(true);
                    three.SetActive(false);
                    break;
                default:
                    three.transform.position = vrashalka.transform.position;
                    one.SetActive(false);
                    two.SetActive(false);
                    three.SetActive(true);
                    break;
            }
        }
    }
}
