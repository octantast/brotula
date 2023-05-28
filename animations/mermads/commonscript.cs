using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class commonscript : MonoBehaviour
{

    private Color32 colordefaultwhite;
    private Color32 colorlightgrey;
    private Color32 colorgrey;
    private Color32 colorblack;
    private Color32 colorlightpink;
    private Color32 colorred;
    private Color32 colorultrared;

    private int randomcolorus;

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
        colordefaultwhite = new Color32(226, 226, 226, 255);
        colorlightgrey = new Color32(153, 153, 153, 255);
        colorgrey = new Color32(100, 100, 100, 255);
        colorblack = new Color32(64, 64, 64, 255);
        colorlightpink = new Color32(150, 95, 96, 255);
        colorred = new Color32(165, 24, 26, 255);
        colorultrared = new Color32(114, 15, 16, 255);

        // скрипт креветты
        if (this.name == "Alissa(Clone)" || this.name == "Khironda(Clone)" || this.name == "Krideia(Clone)" || this.name == "Nerrelida(Clone)" || this.name == "Thanaida(Clone)")
        {
            randomcolorus = Random.Range(0, 4);
            switch (randomcolorus)
            {
                case 1:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colorlightpink;
                    }
                    break;
                case 2:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colorred;
                    }
                    break;
                case 3:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colorultrared;
                    }
                    break;
                default:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colordefaultwhite;
                    }
                    break;
            }

            sizeNormie = new Vector3(1f, 1f, 0f); // нормальный размер
            legzad = transform.GetChild(1).gameObject;
            armzad = transform.GetChild(4).gameObject;
            body = transform.GetChild(0).gameObject;
            head = transform.GetChild(5).gameObject;
            armpered = transform.GetChild(3).gameObject;
            legpered = transform.GetChild(2).gameObject;
        }



        // медузины
        if (this.name == "Babila(Clone)" || this.name == "Scipha(Clone)" || this.name == "Nophora(Clone)" || this.name == "Tkhara(Clone)")
        {
            if (this.name == "Babila(Clone)")
            {
                randomcolorus = Random.Range(1, 3);
            }
            else
            {
                randomcolorus = Random.Range(0, 4);
            }

            switch (randomcolorus)
            {
                case 1:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colorlightpink;
                    }
                    break;
                case 2:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colorred;
                    }
                    break;
                case 3:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colorultrared;
                    }
                    break;
                default:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colordefaultwhite;
                    }
                    break;
            }

            sizeNormie = new Vector3(1f, 1f, 0f); // нормальный размер
            legzad = transform.GetChild(4).gameObject;
            armzad = transform.GetChild(1).gameObject;
            body = transform.GetChild(0).gameObject;
            head = transform.GetChild(3).gameObject;
            armpered = transform.GetChild(2).gameObject;
            legpered = transform.GetChild(5).gameObject;
        }

        // рыболики
        if (this.name == "Sotheta(Clone)" || this.name == "Prokta(Clone)" || this.name == "Typhlona(Clone)" || this.name == "Abbeta(Clone)" || this.name == "Batiza(Clone)" || this.name == "Hioa(Clone)" || this.name == "Lata(Clone)" || this.name == "Grena(Clone)" || this.name == "Mikta(Clone)" || this.name == "Liheta(Clone)" || this.name == "Pareeda(Clone)" || this.name == "Ploga(Clone)" || this.name == "Pharna(Clone)")
        {
            if (this.name != "Pharna(Clone)" && this.name != "Batiza(Clone)")
            {
                randomcolorus = Random.Range(0, 7);
            }
            else
            {
                randomcolorus = Random.Range(1, 3);
            }
            switch (randomcolorus)
            {
                case 1:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colorlightgrey;
                    }
                    break;
                case 2:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colorgrey;
                    }
                    break;
                case 3:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colorblack;
                    }
                    break;
                case 4:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colorlightpink;
                    }
                    break;
                case 5:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colorred;
                    }
                    break;
                case 6:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colorultrared;
                    }
                    break;
                default:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colordefaultwhite;
                    }
                    break;
            }

            sizeNormie = new Vector3(1f, 1f, 0f); // нормальный размер
            legzad = transform.GetChild(5).gameObject;
            armzad = transform.GetChild(0).gameObject;
            body = transform.GetChild(2).gameObject;
            head = transform.GetChild(1).gameObject;
            armpered = transform.GetChild(3).gameObject;
            legpered = transform.GetChild(4).gameObject;
        }

        // звездолики
        if (this.name == "Benta(Clone)" || this.name == "Phiua(Clone)" || this.name == "Echina(Clone)")
        {
            if (this.name != "Echina(Clone)")
            {
                randomcolorus = Random.Range(0, 7);
            }
            else
            {
                randomcolorus = Random.Range(4, 6);
            }
            switch (randomcolorus)
            {
                case 1:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colorlightgrey;
                    }
                    break;
                case 2:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colorgrey;
                    }
                    break;
                case 3:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colorblack;
                    }
                    break;
                case 4:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colorlightpink;
                    }
                    break;
                case 5:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colorred;
                    }
                    break;
                case 6:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colorultrared;
                    }
                    break;
                default:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colordefaultwhite;
                    }
                    break;
            }

            sizeNormie = new Vector3(1f, 1f, 0f); // нормальный размер
            legzad = transform.GetChild(2).gameObject;
            armzad = transform.GetChild(0).gameObject;
            body = transform.GetChild(1).gameObject;
            head = transform.GetChild(3).gameObject;
            armpered = transform.GetChild(4).gameObject;
            legpered = transform.GetChild(5).gameObject;
        }

        // черволики
        if (this.name == "Celliseea(Clone)" || this.name == "Demosa(Clone)" || this.name == "Popmpa(Clone)" || this.name == "Nemina(Clone)" || this.name == "Zema(Clone)")
        {
            randomcolorus = Random.Range(0, 7);
            switch (randomcolorus)
            {
                case 1:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colorlightgrey;
                    }
                    break;
                case 2:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colorgrey;
                    }
                    break;
                case 3:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colorblack;
                    }
                    break;
                case 4:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colorlightpink;
                    }
                    break;
                case 5:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colorred;
                    }
                    break;
                case 6:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colorultrared;
                    }
                    break;
                default:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colordefaultwhite;
                    }
                    break;
            }

            sizeNormie = new Vector3(1f, 1f, 0f); // нормальный размер
            legzad = transform.GetChild(2).gameObject;
            armzad = transform.GetChild(4).gameObject;
            body = transform.GetChild(3).gameObject;
            head = transform.GetChild(5).gameObject;
            armpered = transform.GetChild(0).gameObject;
            legpered = transform.GetChild(1).gameObject;
        }

        // осьминоги
        if (this.name == "Cirrata(Clone)" || this.name == "Theusa(Clone)")
        {
            if (this.name != "Pharna(Clone)" && this.name != "Batiza(Clone)")
            {
                randomcolorus = Random.Range(0, 7);
            }
            else
            {
                randomcolorus = Random.Range(1, 3);
            }
            switch (randomcolorus)
            {
                case 1:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colorlightgrey;
                    }
                    break;
                case 2:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colorgrey;
                    }
                    break;
                case 3:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colorblack;
                    }
                    break;
                case 4:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colorlightpink;
                    }
                    break;
                case 5:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colorred;
                    }
                    break;
                case 6:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colorultrared;
                    }
                    break;
                default:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colordefaultwhite;
                    }
                    break;
            }

            sizeNormie = new Vector3(1f, 1f, 0f); // нормальный размер
            legzad = transform.GetChild(5).gameObject;
            armzad = transform.GetChild(0).gameObject;
            body = transform.GetChild(1).gameObject;
            head = transform.GetChild(2).gameObject;
            armpered = transform.GetChild(4).gameObject;
            legpered = transform.GetChild(3).gameObject;
        }

        // молли
        if (this.name == "Ragoa(Clone)" || this.name == "Ekhira(Clone)" || this.name == "Heetha(Clone)" || this.name == "Topela(Clone)")
        {
            randomcolorus = Random.Range(0, 4);
            switch (randomcolorus)
            {
                case 1:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colorlightgrey;
                    }
                    break;
                case 2:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colorgrey;
                    }
                    break;
                case 3:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colorblack;
                    }
                    break;
                default:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colordefaultwhite;
                    }
                    break;
            }


            sizeNormie = new Vector3(1f, 1f, 0f); // нормальный размер
            legzad = transform.GetChild(3).gameObject;
            armzad = transform.GetChild(2).gameObject;
            body = transform.GetChild(4).gameObject;
            head = transform.GetChild(5).gameObject;
            armpered = transform.GetChild(1).gameObject;
            legpered = transform.GetChild(2).gameObject;
        }

        // актиния или корал
        if (this.name == "Galana(Clone)" || this.name == "Phanosa(Clone)" || this.name == "Phobela(Clone)" || this.name == "Mariusa(Clone)")
        {

            randomcolorus = Random.Range(0, 7);
            switch (randomcolorus)
            {
                case 1:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colorlightgrey;
                    }
                    break;
                case 2:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colorgrey;
                    }
                    break;
                case 3:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colorblack;
                    }
                    break;
                case 4:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colorlightpink;
                    }
                    break;
                case 5:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colorred;
                    }
                    break;
                case 6:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colorultrared;
                    }
                    break;
                default:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colordefaultwhite;
                    }
                    break;
            }

            sizeNormie = new Vector3(1f, 1f, 0f); // нормальный размер
            legzad = transform.GetChild(3).gameObject;
            armzad = transform.GetChild(1).gameObject;
            body = transform.GetChild(4).gameObject;
            head = transform.GetChild(5).gameObject;
            armpered = transform.GetChild(0).gameObject;
            legpered = transform.GetChild(2).gameObject;
        }


        // губки
        if (this.name == "Pastera(Clone)" || this.name == "Sactina(Clone)" || this.name == "Golora(Clone)" || this.name == "Ascea(Clone)")
        {

            randomcolorus = Random.Range(0, 7);
            switch (randomcolorus)
            {
                case 1:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colorlightgrey;
                    }
                    break;
                case 2:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colorgrey;
                    }
                    break;
                case 3:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colorblack;
                    }
                    break;
                case 4:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colorlightpink;
                    }
                    break;
                case 5:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colorred;
                    }
                    break;
                case 6:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colorultrared;
                    }
                    break;
                default:
                    foreach (Transform child in transform)
                    {
                        child.gameObject.GetComponent<Image>().color = colordefaultwhite;
                    }
                    break;
            }

            sizeNormie = new Vector3(1f, 1f, 0f); // нормальный размер
            legzad = transform.GetChild(2).gameObject;
            armzad = transform.GetChild(0).gameObject;
            body = transform.GetChild(4).gameObject;
            head = transform.GetChild(5).gameObject;
            armpered = transform.GetChild(1).gameObject;
            legpered = transform.GetChild(3).gameObject;
        }


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
            if (elozit < 1.2f && ziklruki == false)
            {
                elozit += Time.deltaTime;
            }
            else
            {
                ziklruki = true;
            }
            if (elozit > -2f && ziklruki)
            {

                elozit -= Time.deltaTime;
            }
            else
            {
                ziklruki = false;
            }
            if (this.name == "Pastera(Clone)" || this.name == "Sactina(Clone)")
            {
                armzad.transform.localEulerAngles = new Vector3(0f, 0f, elozit * 0.3f);
                armpered.transform.localEulerAngles = new Vector3(0f, 0f, elozit * 0.3f);
            }
            else
            {
                armzad.transform.localEulerAngles = new Vector3(0f, 0f, elozit);
                armpered.transform.localEulerAngles = new Vector3(0f, 0f, elozit * 0.8f);
            }
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
            head.transform.position = new Vector3(head.transform.position.x, Mathf.Lerp(head.transform.position.y, head.transform.position.y - balda, 14f * Time.deltaTime), head.transform.position.z);
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

        transform.position = new Vector3(transform.position.x, Mathf.Lerp(transform.position.y, transform.position.y + telesa, 14f * Time.deltaTime), transform.position.z);
    }
}
