using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving3 : MonoBehaviour
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
    [SerializeField] private GameObject opuhol;
    [SerializeField] private Vector3 scaleChange; // мощность изменений размера
    [SerializeField] private Vector3 sizeNormie; // размер
    [SerializeField] private Vector3 sizeUnNormie;
    [SerializeField] private float kolebanie;
    [SerializeField] private float elozit;
    [SerializeField] private float balda;
    [SerializeField] private float telesa;
    [SerializeField] private float timer;
    [SerializeField] private float puls;
    [SerializeField] private bool ziklnogi;
    [SerializeField] private bool ziklruki;
    [SerializeField] private bool ziklbashki;
    [SerializeField] private bool zikltela;
    [SerializeField] private bool randommove;
    [SerializeField] private float randomtime;
    [SerializeField] private float randomtimeset;

    private bool sizenormie;

    // Start is called before the first frame update
    void Start()
    {
        sizeNormie = new Vector3(1.5f, 1.5f, 0f); // нормальный размер
        sizeUnNormie = new Vector3(0.5f, 0.5f, 0f);
        legzad = transform.GetChild(0).gameObject;
        armzad = transform.GetChild(1).gameObject;
        body = transform.GetChild(2).gameObject;
        head = transform.GetChild(3).gameObject;
        armpered = transform.GetChild(4).gameObject;
        legpered = transform.GetChild(5).gameObject;
        opuhol = transform.GetChild(6).gameObject;
        rb = GetComponent<Rigidbody2D>(); // всё тело
        rblegzad = legzad.GetComponent<Rigidbody2D>();
        rbarmzad = armzad.GetComponent<Rigidbody2D>();
        rbbody = body.GetComponent<Rigidbody2D>();
        rbarmpered = armpered.GetComponent<Rigidbody2D>();
        rblegpered = legpered.GetComponent<Rigidbody2D>();
        rbhead = head.GetComponent<Rigidbody2D>();
        scaleChange = new Vector3(0.0003f, 0.0003f, 0f);
        kolebanie = 0f;
        elozit = 1f;
        balda = 0f;
        randomtime = Random.Range(10f, 30f);
        randomtimeset = randomtime;
    }

    // Update is called once per frame
    void Update()
    {

        // движение ног вверх-вниз

        if (kolebanie < 1.5f && ziklnogi == false)
        {
            kolebanie += Time.deltaTime;
        }
        else if (ziklnogi == false)
        {
            ziklnogi = true;
        }
        if (kolebanie > -1.5f && ziklnogi)
        {
            kolebanie -= Time.deltaTime;
        }
        else
        {
            ziklnogi = false;
        }
        legpered.transform.position = new Vector3(legpered.transform.position.x, Mathf.Lerp(legpered.transform.position.y, legpered.transform.position.y - kolebanie * 0.05f, Time.deltaTime), legpered.transform.position.z);
        legzad.transform.position = new Vector3(legzad.transform.position.x, Mathf.Lerp(legzad.transform.position.y, legzad.transform.position.y - kolebanie * 0.04f, Time.deltaTime), legzad.transform.position.z);



        // движение ушей

        if (elozit < 3.1f && ziklruki == false)
        {
            elozit += Time.deltaTime * 0.5f;
        }
        else
        {
            ziklruki = true;
        }
        if (elozit > -3.1f && ziklruki)
        {

            elozit -= Time.deltaTime * 0.5f;
        }
        else
        {
            ziklruki = false;
        }
        armzad.transform.localEulerAngles = new Vector3(0f, 0f, elozit);
        armpered.transform.localEulerAngles = new Vector3(0f, 0f, elozit * -0.5f);
        legzad.transform.localEulerAngles = new Vector3(0f, 0f, elozit * 1.5f);


        // движение башки
        if (balda < 0.1f && ziklbashki == false)
        {
            balda += Time.deltaTime * 0.2f;
        }
        else if (ziklbashki == false)
        {
            ziklbashki = true;
            timer = 5f;
        }
        if (balda > -0.1f && ziklbashki)
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

        // пульсация опухоли
        if (sizenormie == false && opuhol.transform.localScale.y < 1.02f)
        {
            opuhol.transform.localScale += scaleChange;
        }
        else if (sizenormie == false)
        {
            sizenormie = true;
        }
        if (sizenormie && opuhol.transform.localScale.y > 0.9f)
        {
            opuhol.transform.localScale -= scaleChange;
        }
        else if (sizenormie)
        {
            sizenormie = false;
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
    }
}
