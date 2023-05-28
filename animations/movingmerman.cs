using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingmerman : MonoBehaviour
{
    Rigidbody2D rb;
    Rigidbody2D rblegzad;
    Rigidbody2D rbarmzad;
    Rigidbody2D rbbody;
    Rigidbody2D rbarmpered;
    Rigidbody2D rblegpered;
    Rigidbody2D rbhead;
    [SerializeField] private GameObject legzad;
    [SerializeField] private GameObject armzad;
    [SerializeField] private GameObject body;
    [SerializeField] private GameObject armpered;
    [SerializeField] private GameObject legpered;
    [SerializeField] private GameObject head;
    [SerializeField] private Vector3 scaleChange; // мощность изменений размера
    [SerializeField] private Vector3 sizeNormie; // размер
    [SerializeField] private float kolebanie;
    [SerializeField] private float elozit;
    [SerializeField] private float balda;
    [SerializeField] private float telesa;
    [SerializeField] private float timer;
    [SerializeField] private bool ziklnogi;
    [SerializeField] private bool ziklruki;
    [SerializeField] private bool ziklbashki;
    [SerializeField] private bool zikltela;
    [SerializeField] private bool randommove;
    [SerializeField] private float randomtime;
    [SerializeField] private float randomtimeset;

    // Start is called before the first frame update
    void Start()
    {
        sizeNormie = new Vector3(1f, 1f, 0f); // нормальный размер
        legzad = transform.GetChild(0).gameObject;
        armzad = transform.GetChild(1).gameObject;
        body = transform.GetChild(2).gameObject;
        head = transform.GetChild(3).gameObject;
        armpered = transform.GetChild(4).gameObject;
        legpered = transform.GetChild(5).gameObject;
        rb = GetComponent<Rigidbody2D>(); // всё тело
        rblegzad = legzad.GetComponent<Rigidbody2D>();
        rbarmzad = armzad.GetComponent<Rigidbody2D>();
        rbbody = body.GetComponent<Rigidbody2D>();
        rbarmpered = armpered.GetComponent<Rigidbody2D>();
        rblegpered = legpered.GetComponent<Rigidbody2D>();
        rbhead = head.GetComponent<Rigidbody2D>();
        scaleChange = new Vector3(0.01f, 0.01f, 0f);
        kolebanie = 0f;
        elozit = 1f;
        balda = 0f;
        randomtime = Random.Range(10f, 30f);
        randomtimeset = randomtime;
    }

    // Update is called once per frame
    void Update()
    {
        // возможно это все запускается только, когда столкновение с гг

        //if(randomtime > 0)
       // {
         //   randomtime -= Time.deltaTime;
        //    randommove = false;
       // }
        //else if (randommove == false)
       // {
        //    elozit = -1f;
        //    randommove = true;
       // }
        


        // вращение ног
        if (kolebanie < 3.1f && ziklnogi == false)
        {
            kolebanie += Time.deltaTime * 0.5f;
        }
        else
        {
            ziklnogi = true;
        }
        if (kolebanie > -3.1f && ziklnogi)
        {

            kolebanie -= Time.deltaTime * 0.5f;
        }
        else
        {
            ziklnogi = false;
        }
        legzad.transform.localEulerAngles = new Vector3(0f, 0f, kolebanie);
        legpered.transform.localEulerAngles = new Vector3(0f, 0f, kolebanie * -0.5f);

        // движение рук
        if (randommove == false)
        {
            if (elozit < 2f && ziklruki == false)
            {
                elozit += Time.deltaTime;
            }
            else
            {
                ziklruki = true;
            }
            if (elozit > -2.8f && ziklruki)
            {

                elozit -= Time.deltaTime;
            }
            else
            {
                ziklruki = false;
            }

            armzad.transform.localEulerAngles = new Vector3(0f, 0f, elozit);
            armpered.transform.localEulerAngles = new Vector3(0f, 0f, elozit * 0.8f);
        }

        // движение башки

        if (balda < 0.3f && ziklbashki == false)
        {
            balda += Time.deltaTime * 0.2f;
        }
        else if (ziklbashki == false)
        {
            ziklbashki = true;
            timer = 5f;
        }
        if (balda > -0.5f && ziklbashki)
        {
            balda -= Time.deltaTime * 0.2f;
        }
        else
        {
            ziklbashki = false;
        }
        if (timer > 0f)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            timer = 0f;
            head.transform.position = new Vector3(head.transform.position.x, Mathf.Lerp(head.transform.position.y, head.transform.position.y - balda, 0.3f * Time.deltaTime), head.transform.position.z);
        }

        // движение всего тела

        if (telesa < 0.4f && zikltela == false)
        {
            telesa += Time.deltaTime * 0.05f;
        }
        else
        {
            zikltela = true;
        }
        if (telesa > -0.4f && zikltela)
        {

            telesa -= Time.deltaTime * 0.05f;
        }
        else
        {
            zikltela = false;
        }

        transform.position = new Vector3(transform.position.x, Mathf.Lerp(transform.position.y, transform.position.y + telesa, 0.3f * Time.deltaTime), transform.position.z);


        // рандомное перебирание лапками (вверх в минус, вниз в плюс)
        // if(randommove) // присваивается с рандомным интервалом времени
        //{
            
            //elozit += Time.deltaTime;

            //if (elozit > 1f)
            //randomtime = randomtimeset;
                 // когда цикл закончен

        //}
    }
}
