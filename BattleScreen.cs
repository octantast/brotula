using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class BattleScreen : MonoBehaviour
{
    public DistanceToCheckpoint distan;
    public mermenreader mermanreader;
    public Slo1 slotsmerman;
    public music musica;
    public Levels leveler;
    public battlefinal resulter;
    public PlayerController startTouch;
    public EnemySpawnerB1 enemySpawner;
    public GenController gens;
    public bool battleMode = false; // когда враг на экране
    public bool skippingMode = false; // когда игрок возвращается в исходную позицию
    public int mermaidPlace1; // номер русалки-награды для 1 слота
    public int mermaidPlace2; // номер русалки-награды для 2 слота
    public bool nagradaspawned = false;
    public bool mermanChitaetsya = false;

    public int newMermaids; // выбрал ли игрок русалку как награду
    public int randomObilia; // сколько русалок генерирует враг
    public int randomIkornyy; // сколько икры генерирует враг
    public float mermaidprevious;

    private int sixdom;
    private int sixdom2;

    public float zapiski;
    public Text zapiska;
    public GameObject zapiskaart;
    private Color32 whitecolor;

    public GameObject zapiska1;
    public GameObject zapiska2;
    public GameObject zapiska3;
    public GameObject zapiska4;
    public GameObject zapiska5;
    public GameObject zapiska6;
    public GameObject zapiska7;
    public GameObject zapiska8;
    public GameObject zapiska9;
    public GameObject zapiska10;

    public float timerzapiski;

    public float readfish;
    public float readAliss;
    public float readAsce;
    public float readAbbet;
    public float readBabil;
    public float readBatiz;
    public float readBent;
    public float readCellisee;
    public float readCirrat;
    public float readDemos;
    public float readEchin;
    public float readEkhir;
    public float readGalan;
    public float readGolor;
    public float readGren;
    public float readHadee;
    public float readHeeth;
    public float readHio;
    public float readKhirond;
    public float readKoryph;
    public float readKridei;
    public float readLat;
    public float readLihet;
    public float readMarius;
    public float readMikt;
    public float readNemin;
    public float readNerrelid;
    public float readNophor;
    public float readPareed;
    public float readPaster;
    public float readPhanos;
    public float readPharn;
    public float readPhiu;
    public float readPhobel;
    public float readPlog;
    public float readPopmp;
    public float readProkt;
    public float readRago;
    public float readRoid;
    public float readSactin;
    public float readSciph;
    public float readSothet;
    public float readThanaid;
    public float readThemum;
    public float readTheus;
    public float readTkhar;
    public float readTopel;
    public float readTyphlon;
    public float readZem;

    void Start()
    {
        zapiski = PlayerPrefs.GetFloat("zapiski");
        whitecolor = new Color32(225, 225, 225, 0);
        mermaidprevious = 0;
        zapisoidOff();
        timerzapiski = 2;
    }

    public void zapisoidOff()
    {
        if (timerzapiski <= 0)
        {
            resulter.zametkascreen.SetActive(false);
            // текст становится прозрачным и нулевым
            zapiska.text = " ";
            zapiska.color = whitecolor;
            // картинка дестроится
            foreach (Transform child in zapiskaart.transform)
            {
                child.gameObject.SetActive(false);
            }
            timerzapiski = 2;
        }
    }

    public void Update()
    {
        if (resulter.zametkascreen.activeSelf == true)
        {
            timerzapiski -= Time.deltaTime;
        }
    }

    public void zapisoid()
    {
        // спавнится текст и проявляется
        if (zapiski == 1) // если первая
        {
            if (leveler.languager == 0)
            {
                zapiska.text = "\"My wife and I tested the\nfirst social network built\ninto the mind - \"Brotula\"...\"";
            }
            if (leveler.languager == 1)
            {
                zapiska.text = "\"Мы с женой тестировали\n\"Бротулу\" - первую соцсеть,\nвстроенную в сознание...\"";
            }
            else if (leveler.languager == 2)
            {
                zapiska.text = "\"Ми з дружиною тестували\n\"Бротулу\" - першу соцмережу,\nвбудовану у свідомість...\"";
            }
            // спавнится картинка
            zapiska1.SetActive(true);

        }
        else if (zapiski == 2) // если первая
        {
            if (leveler.languager == 0)
            {
                zapiska.text = "\"...Fast communication due to\nthe power of thought\nanytime anywhere on Earth...\"";
            }
            if (leveler.languager == 1)
            {
                zapiska.text = "\"...Быстрое общение одной\nсилой мысли, в любое время\n из любой точки Земли...\"";
            }
            else if (leveler.languager == 2)
            {
                zapiska.text = "\"...Швидке спілкування однією\nсилою думки, у будь-який час\nз будь-якої точки Землі...\"";
            }
            // спавнится картинка
            zapiska2.SetActive(true);

        }
        else if (zapiski == 3) // если первая
        {
            if (leveler.languager == 0)
            {
                zapiska.text = "\"...I've watched her eyes\nfade as she sinks...\"";
            }
            if (leveler.languager == 1)
            {
                zapiska.text = "\"...Я наблюдал, как её глаза\nтеряют блеск, когда\nона погружается...\"";
            }
            else if (leveler.languager == 2)
            {
                zapiska.text = "\"...Я спостерігав, як її очі\nвтрачають блиск, коли\nвона занурюється...\"";
            }
            // спавнится картинка
            zapiska3.SetActive(true);

        }
        else if (zapiski == 4) // если первая
        {
            if (leveler.languager == 0)
            {
                zapiska.text = "\"...the network became public\nand many people no\nlonger needed reality...\"";
            }
            if (leveler.languager == 1)
            {
                zapiska.text = "\"...сеть стала общедоступной.\nи многим реальность уже\nне была нужна...\"";
            }
            else if (leveler.languager == 2)
            {
                zapiska.text = "\"...і багатьом реальність вже\nне була потрібна, коли мережа\nстала загальнодоступною...\"";
            }
            // спавнится картинка
            zapiska4.SetActive(true);

        }
        else if (zapiski == 5) // если первая
        {
            if (leveler.languager == 0)
            {
                zapiska.text = "\"...I don't think anyone\nnoticed when I disappeared\nlooking for anything real...\"";
            }
            if (leveler.languager == 1)
            {
                zapiska.text = "\"...думаю, никто и не заметил,\nкогда я пропал в поисках\nчего-то настоящего...\"";
            }
            else if (leveler.languager == 2)
            {
                zapiska.text = "\"...здається, ніхто не помітив,\nколи я зник у пошуках\nчогось справжнього...\"";
            }
            // спавнится картинка
            zapiska5.SetActive(true);

        }
        else if (zapiski == 6) // если первая
        {
            if (leveler.languager == 0)
            {
                zapiska.text = "\"...I found like-minded people\nin the most unexpected\nplace...\"";
            }
            if (leveler.languager == 1)
            {
                zapiska.text = "\"...я нашел единомышленников\nв самом неожиданном месте...\"";
            }
            else if (leveler.languager == 2)
            {
                zapiska.text = "\"...я знайшов однодумців у \nнесподіваному місці...\"";
            }
            // спавнится картинка
            zapiska6.SetActive(true);

        }
        else if (zapiski == 7) // если первая
        {
            if (leveler.languager == 0)
            {
                zapiska.text = "\"...deep sea people condemned\n\"brotula\" in me and I could\nhardly wear natural byssus...\"";
            }
            if (leveler.languager == 1)
            {
                zapiska.text = "\"...подводных жителей пугала \n\"бротула\" во мне, а я не мог\nносить натуральный биссус...\"";
            }
            else if (leveler.languager == 2)
            {
                zapiska.text = "\"...підводних людей лякала \n\"бротула\" в мені, а я не міг \nносити натуральний бісус...\"";
            }
            // спавнится картинка
            zapiska7.SetActive(true);

        }
        else if (zapiski == 8) // если первая
        {
            if (leveler.languager == 0)
            {
                zapiska.text = "\"...the ability to communicate\nwith hydronauts was the\nadvantage of people like me...\"";
            }
            if (leveler.languager == 1)
            {
                zapiska.text = "\"...но такие как я оказались\nполезными, ведь мы научились\nобщаться с гидронавтами...\"";
            }
            else if (leveler.languager == 2)
            {
                zapiska.text = "\"...але такі як я виявилися\nкорисними, адже ми навчилися\nспілкуватися з гідронавтами...\"";
            }
            // спавнится картинка
            zapiska8.SetActive(true);

        }
        else if (zapiski == 9) // если первая
        {
            if (leveler.languager == 0)
            {
                zapiska.text = "\"...our community grew, so\ndid the alertness on land.\nfrequent checks began...\"";
            }
            if (leveler.languager == 1)
            {
                zapiska.text = "\"...наша община росла, а с ней\nи настороженность людей\nна суше. Зачастили проверки...\"";
            }
            else if (leveler.languager == 2)
            {
                zapiska.text = "\"...наша громада росла, а з нею\nнасторога людей на суші.\nперевірки стали частішими...\"";
            }
            // спавнится картинка
            zapiska9.SetActive(true);

        }
        else if (zapiski == 10) // если первая
        {
            if (leveler.languager == 0)
            {
                zapiska.text = "\"...so we started looking for\na way to protect ourselves\nfrom people from above.\"";
            }
            if (leveler.languager == 1)
            {
                zapiska.text = "\"...И чтобы защититься, мы\nначали искать рычаг\nвлияния на людей сверху.\"";
            }
            else if (leveler.languager == 2)
            {
                zapiska.text = "\"...І щоб захиститися, ми\nпочали шукати важіль\nвпливу на людей зверху.\"";
            }
            // спавнится картинка
            zapiska10.SetActive(true);

        }





    }

    //встреча врага, назначение наград
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("finalette"))
        {
            musica.finalka.volume = 0;
            musica.viseoplayer.SetActive(true);
            musica.cutscene3ringwood.Play();
        }

        if (resulter.deathmode == false)
        {
            if (other.name == "Kridei(Clone)")
            {
                PlayerPrefs.SetFloat("readKridei", 1);
                enemySpawner.bKridei = true; // личный бул мермена
                randomObilia = Random.Range(1, 3);
                sixdom = Random.Range(1, 11);
                sixdom2 = Random.Range(1, 11);
                switch (sixdom)
                {
                    case 1:
                        mermaidPlace1 = 7;
                        break;
                    case 2:
                        mermaidPlace1 = 10;
                        break;
                    case 3:
                        mermaidPlace1 = 48;
                        break;
                    case 4:
                        mermaidPlace1 = 2;
                        break;
                    case 5:
                        mermaidPlace1 = 18;
                        break;
                    case 6:
                        mermaidPlace1 = 47;
                        break;
                    case 7:
                        mermaidPlace1 = 13;
                        break;
                    default:
                        mermaidPlace1 = 1;
                        break;
                }
                if(randomObilia == 2 && zapiski != 10 && mermaidprevious != 60 && distan.distance > 5650) // максимальное кол-во
                {
                    mermaidPlace2 = 60; // код записки
                }
                else if (randomObilia == 2)
                {
                    switch (sixdom2)
                    {
                        case 1:
                            mermaidPlace2 = 7;
                            break;
                        case 2:
                            mermaidPlace2 = 10;
                            break;
                        case 3:
                            mermaidPlace2 = 48;
                            break;
                        case 4:
                            mermaidPlace2 = 2;
                            break;
                        case 5:
                            mermaidPlace2 = 18;
                            break;
                        case 6:
                            mermaidPlace2 = 47;
                            break;
                        case 7:
                            mermaidPlace2 = 13;
                            break;
                        default:
                            mermaidPlace2 = 1;
                            break;
                    }
                }
                randomIkornyy = Random.Range(5, 10); // награда-икра
            }

            else if (other.name == "Batiz(Clone)")
            {
                PlayerPrefs.SetFloat("readBatiz", 1);
                enemySpawner.bBatiz = true; // личный бул мермена
                randomObilia = Random.Range(1, 3);
                sixdom = Random.Range(1, 16); // 6 вариантов русалок
                sixdom2 = Random.Range(1, 16); // 6 вариантов русалок
                switch (sixdom)
                {
                    case 1:
                        mermaidPlace1 = 7;
                        break;
                    case 2:
                        mermaidPlace1 = 10;
                        break;
                    case 3:
                        mermaidPlace1 = 48;
                        break;
                    case 4:
                        mermaidPlace1 = 2;
                        break;
                    case 5:
                        mermaidPlace1 = 1;
                        break;
                    case 6:
                        mermaidPlace1 = 9;
                        break;
                    case 7:
                        mermaidPlace1 = 6;
                        break;
                    case 8:
                        mermaidPlace1 = 11;
                        break;
                    case 9:
                        mermaidPlace1 = 5;
                        break;
                    case 10:
                        mermaidPlace1 = 4;
                        break;
                    case 11:
                        mermaidPlace1 = 42;
                        break;
                    default:
                        mermaidPlace1 = 2;
                        break;
                }

                if (randomObilia == 2 && zapiski != 10 && mermaidprevious != 60 && distan.distance > 5650) // максимальное кол-во
                {
                    mermaidPlace2 = 60; // код записки
                }
                else if (randomObilia == 2)
                {
                    switch (sixdom2)
                    {
                        case 1:
                            mermaidPlace2 = 7;
                            break;
                        case 2:
                            mermaidPlace2 = 10;
                            break;
                        case 3:
                            mermaidPlace2 = 48;
                            break;
                        case 4:
                            mermaidPlace2 = 2;
                            break;
                        case 5:
                            mermaidPlace2 = 1;
                            break;
                        case 6:
                            mermaidPlace2 = 9;
                            break;
                        case 7:
                            mermaidPlace2 = 6;
                            break;
                        case 8:
                            mermaidPlace2 = 11;
                            break;
                        case 9:
                            mermaidPlace2 = 5;
                            break;
                        case 10:
                            mermaidPlace2 = 4;
                            break;
                        case 11:
                            mermaidPlace2 = 42;
                            break;
                        default:
                            mermaidPlace2 = 2;
                            break;
                    }
                }
                randomIkornyy = Random.Range(5, 10); // награда-икра
            }

            else if (other.name == "Cirrat(Clone)")
            {
                PlayerPrefs.SetFloat("readCirrat", 1);
                enemySpawner.bCirrat = true; // личный бул мермена
                randomObilia = Random.Range(1, 3);
                sixdom = Random.Range(1, 11); // 6 вариантов русалок
                sixdom2 = Random.Range(1, 11); // 6 вариантов русалок
                switch (sixdom)
                {
                    case 1:
                        mermaidPlace1 = 7;
                        break;
                    case 2:
                        mermaidPlace1 = 10;
                        break;
                    case 3:
                        mermaidPlace1 = 48;
                        break;
                    case 4:
                        mermaidPlace1 = 1;
                        break;
                    case 5:
                        mermaidPlace1 = 9;
                        break;
                    case 6:
                        mermaidPlace1 = 3;
                        break;
                    case 7:
                        mermaidPlace1 = 42;
                        break;
                    default:
                        mermaidPlace1 = 3;
                        break;
                }

                if (randomObilia == 2 && zapiski != 10 && mermaidprevious != 60 && distan.distance > 5650) // максимальное кол-во
                {
                    mermaidPlace2 = 60; // код записки
                }
                else if (randomObilia == 2)
                {
                    switch (sixdom2)
                    {
                        case 1:
                            mermaidPlace2 = 7;
                            break;
                        case 2:
                            mermaidPlace2 = 10;
                            break;
                        case 3:
                            mermaidPlace2 = 48;
                            break;
                        case 4:
                            mermaidPlace2 = 1;
                            break;
                        case 5:
                            mermaidPlace2 = 9;
                            break;
                        case 6:
                            mermaidPlace2 = 3;
                            break;
                        case 7:
                            mermaidPlace2 = 42;
                            break;
                        default:
                            mermaidPlace2 = 3;
                            break;
                    }
                }
                randomIkornyy = 1; // награда-икра
            }

            else if (other.name == "Plog(Clone)")
            {
                PlayerPrefs.SetFloat("readPlog", 1);
                enemySpawner.bPlog = true; // личный бул мермена
                randomObilia = Random.Range(1, 3);
                sixdom = Random.Range(1, 20); // 6 вариантов русалок
                sixdom2 = Random.Range(1, 20); // 6 вариантов русалок
                switch (sixdom)
                {
                    case 1:
                        mermaidPlace1 = 7;
                        break;
                    case 2:
                        mermaidPlace1 = 10;
                        break;
                    case 3:
                        mermaidPlace1 = 48;
                        break;
                    case 4:
                        mermaidPlace1 = 4;
                        break;
                    case 5:
                        mermaidPlace1 = 1;
                        break;
                    case 6:
                        mermaidPlace1 = 2;
                        break;
                    case 7:
                        mermaidPlace1 = 5;
                        break;
                    case 8:
                        mermaidPlace1 = 6;
                        break;
                    case 9:
                        mermaidPlace1 = 9;
                        break;
                    case 10:
                        mermaidPlace1 = 42;
                        break;
                    default:
                        mermaidPlace1 = 4;
                        break;
                }

                if (randomObilia == 2 && zapiski != 10 && mermaidprevious != 60 && distan.distance > 5650) // максимальное кол-во
                {
                    mermaidPlace2 = 60; // код записки
                }
                else if (randomObilia == 2)
                {
                    switch (sixdom2)
                    {
                        case 1:
                            mermaidPlace2 = 7;
                            break;
                        case 2:
                            mermaidPlace2 = 10;
                            break;
                        case 3:
                            mermaidPlace2 = 48;
                            break;
                        case 4:
                            mermaidPlace2 = 4;
                            break;
                        case 5:
                            mermaidPlace2 = 1;
                            break;
                        case 6:
                            mermaidPlace2 = 2;
                            break;
                        case 7:
                            mermaidPlace2 = 5;
                            break;
                        case 8:
                            mermaidPlace2 = 6;
                            break;
                        case 9:
                            mermaidPlace2 = 9;
                            break;
                        case 10:
                            mermaidPlace2 = 42;
                            break;
                        default:
                            mermaidPlace2 = 4;
                            break;
                    }
                }
                randomIkornyy = Random.Range(1, 5); // награда-икра
            }

            else if (other.name == "Pharn(Clone)")
            {
                PlayerPrefs.SetFloat("readPharn", 1);
                enemySpawner.bPharn = true; // личный бул мермена
                randomObilia = Random.Range(1, 3);
                sixdom = Random.Range(1, 16); // 6 вариантов русалок
                sixdom2 = Random.Range(1, 16); // 6 вариантов русалок
                switch (sixdom)
                {
                    case 1:
                        mermaidPlace1 = 7;
                        break;
                    case 2:
                        mermaidPlace1 = 10;
                        break;
                    case 3:
                        mermaidPlace1 = 48;
                        break;
                    case 4:
                        mermaidPlace1 = 3;
                        break;
                    case 5:
                        mermaidPlace1 = 25;
                        break;
                    case 6:
                        mermaidPlace1 = 28;
                        break;
                    case 7:
                        mermaidPlace1 = 29;
                        break;
                    case 8:
                        mermaidPlace1 = 42;
                        break;
                    case 9:
                        mermaidPlace1 = 5;
                        break;
                    case 10:
                        mermaidPlace1 = 34;
                        break;
                    default:
                        mermaidPlace1 = 5;
                        break;
                }

                if (randomObilia == 2 && zapiski != 10 && mermaidprevious != 60 && distan.distance > 5650) // максимальное кол-во
                {
                    mermaidPlace2 = 60; // код записки
                }
                else if (randomObilia == 2)
                {
                    switch (sixdom2)
                    {
                        case 1:
                            mermaidPlace2 = 7;
                            break;
                        case 2:
                            mermaidPlace2 = 10;
                            break;
                        case 3:
                            mermaidPlace2 = 48;
                            break;
                        case 4:
                            mermaidPlace2 = 3;
                            break;
                        case 5:
                            mermaidPlace2 = 25;
                            break;
                        case 6:
                            mermaidPlace2 = 28;
                            break;
                        case 7:
                            mermaidPlace2 = 29;
                            break;
                        case 8:
                            mermaidPlace2 = 42;
                            break;
                        case 9:
                            mermaidPlace2 = 5;
                            break;
                        case 10:
                            mermaidPlace2 = 34;
                            break;
                        default:
                            mermaidPlace2 = 5;
                            break;
                    }
                }
                randomIkornyy = Random.Range(1, 5); // награда-икра
            }

            else if (other.name == "Typhlon(Clone)")
            {
                PlayerPrefs.SetFloat("readTyphlon", 1);
                enemySpawner.bTyphlon = true; // личный бул мермена
                randomObilia = Random.Range(1, 3);
                sixdom = Random.Range(1, 11); // 6 вариантов русалок
                sixdom2 = Random.Range(1, 11); // 6 вариантов русалок
                switch (sixdom)
                {
                    case 1:
                        mermaidPlace1 = 7;
                        break;
                    case 2:
                        mermaidPlace1 = 10;
                        break;
                    case 3:
                        mermaidPlace1 = 48;
                        break;
                    case 4:
                        mermaidPlace1 = 6;
                        break;
                    case 5:
                        mermaidPlace1 = 30;
                        break;
                    case 6:
                        mermaidPlace1 = 9;
                        break;
                    case 7:
                        mermaidPlace1 = 14;
                        break;
                    case 8:
                        mermaidPlace1 = 15;
                        break;
                    default:
                        mermaidPlace1 = 6;
                        break;
                }

                if (randomObilia == 2 && zapiski != 10 && mermaidprevious != 60 && distan.distance > 5650) // максимальное кол-во
                {
                    mermaidPlace2 = 60; // код записки
                }
                else if (randomObilia == 2)
                {
                    switch (sixdom2)
                    {
                        case 1:
                            mermaidPlace2 = 7;
                            break;
                        case 2:
                            mermaidPlace2 = 10;
                            break;
                        case 3:
                            mermaidPlace2 = 48;
                            break;
                        case 4:
                            mermaidPlace2 = 6;
                            break;
                        case 5:
                            mermaidPlace2 = 30;
                            break;
                        case 6:
                            mermaidPlace2 = 9;
                            break;
                        case 7:
                            mermaidPlace2 = 14;
                            break;
                        case 8:
                            mermaidPlace2 = 15;
                            break;
                        default:
                            mermaidPlace2 = 6;
                            break;
                    }
                }
                randomIkornyy = Random.Range(2, 9); // награда-икра
            }

            else if (other.name == "Nemin(Clone)")
            {
                PlayerPrefs.SetFloat("readNemin", 1);
                enemySpawner.bNemin = true; // личный бул мермена
                randomObilia = Random.Range(1, 3);
                mermaidPlace1 = Random.Range(1, 48);
                if (mermaidPlace1 == 26 || mermaidPlace1 == 39 || mermaidPlace1 == 43 || mermaidPlace1 == 45)
                {
                    mermaidPlace1 = 7;
                }
                if (randomObilia == 2 && zapiski != 10 && mermaidprevious != 60 && distan.distance > 5650) // максимальное кол-во
                {
                    mermaidPlace2 = 60; // код записки
                }
                else if (randomObilia == 2)
                {
                    mermaidPlace2 = Random.Range(1, 48);
                    if (mermaidPlace2 == 26 || mermaidPlace2 == 39 || mermaidPlace2 == 43 || mermaidPlace2 == 45)
                    {
                        mermaidPlace2 = 7;
                    }
                }
                randomIkornyy = 1; // награда-икра
            }

            else if (other.name == "Bent(Clone)")
            {
                PlayerPrefs.SetFloat("readBent", 1);
                enemySpawner.bBent = true; // личный бул мермена
                randomObilia = Random.Range(1, 3);
                sixdom = Random.Range(1, 16); // 6 вариантов русалок
                sixdom2 = Random.Range(1, 16); // 6 вариантов русалок
                switch (sixdom)
                {
                    case 1:
                        mermaidPlace1 = 7;
                        break;
                    case 2:
                        mermaidPlace1 = 10;
                        break;
                    case 3:
                        mermaidPlace1 = 48;
                        break;
                    case 4:
                        mermaidPlace1 = 14;
                        break;
                    case 5:
                        mermaidPlace1 = 15;
                        break;
                    case 6:
                        mermaidPlace1 = 19;
                        break;
                    case 7:
                        mermaidPlace1 = 24;
                        break;
                    case 8:
                        mermaidPlace1 = 38;
                        break;
                    case 9:
                        mermaidPlace1 = 41;
                        break;
                    case 10:
                        mermaidPlace1 = 8;
                        break;
                    default:
                        mermaidPlace1 = 8;
                        break;
                }

                if (randomObilia == 2 && zapiski != 10 && mermaidprevious != 60 && distan.distance > 5650) // максимальное кол-во
                {
                    mermaidPlace2 = 60; // код записки
                }
                else if (randomObilia == 2)
                {
                    switch (sixdom2)
                    {
                        case 1:
                            mermaidPlace2 = 7;
                            break;
                        case 2:
                            mermaidPlace2 = 10;
                            break;
                        case 3:
                            mermaidPlace2 = 48;
                            break;
                        case 4:
                            mermaidPlace2 = 14;
                            break;
                        case 5:
                            mermaidPlace2 = 15;
                            break;
                        case 6:
                            mermaidPlace2 = 19;
                            break;
                        case 7:
                            mermaidPlace2 = 24;
                            break;
                        case 8:
                            mermaidPlace2 = 38;
                            break;
                        case 9:
                            mermaidPlace2 = 41;
                            break;
                        case 10:
                            mermaidPlace2 = 8;
                            break;
                        default:
                            mermaidPlace2 = 8;
                            break;
                    }
                }
                randomIkornyy = Random.Range(1, 3); // награда-икра
            }

            else if (other.name == "Aliss(Clone)")
            {
                PlayerPrefs.SetFloat("readAliss", 1);
                enemySpawner.bAliss = true; // личный бул мермена
                randomObilia = Random.Range(1, 3);
                sixdom = Random.Range(1, 8); // 6 вариантов русалок
                sixdom2 = Random.Range(1, 8); // 6 вариантов русалок
                switch (sixdom)
                {
                    case 1:
                        mermaidPlace1 = 7;
                        break;
                    case 2:
                        mermaidPlace1 = 10;
                        break;
                    case 3:
                        mermaidPlace1 = 48;
                        break;
                    case 4:
                        mermaidPlace1 = 15;
                        break;
                    default:
                        mermaidPlace1 = 9;
                        break;
                }

                if (randomObilia == 2 && zapiski != 10 && mermaidprevious != 60 && distan.distance > 5650) // максимальное кол-во
                {
                    mermaidPlace2 = 60; // код записки
                }
                else if (randomObilia == 2)
                {
                    switch (sixdom2)
                    {
                        case 1:
                            mermaidPlace2 = 7;
                            break;
                        case 2:
                            mermaidPlace2 = 10;
                            break;
                        case 3:
                            mermaidPlace2 = 48;
                            break;
                        case 4:
                            mermaidPlace2 = 15;
                            break;
                        default:
                            mermaidPlace2 = 9;
                            break;
                    }
                }
                randomIkornyy = Random.Range(1, 3); // награда-икра
            }

            else if (other.name == "Phiu(Clone)")
            {
                PlayerPrefs.SetFloat("readPhiu", 1);
                enemySpawner.bPhiu = true; // личный бул мермена
                randomObilia = Random.Range(1, 3);
                mermaidPlace1 = Random.Range(1, 48);
                if (mermaidPlace1 == 26 || mermaidPlace1 == 39 || mermaidPlace1 == 43 || mermaidPlace1 == 45)
                {
                    mermaidPlace1 = 10;
                }
                if (randomObilia == 2 && zapiski != 10 && mermaidprevious != 60 && distan.distance > 5650) // максимальное кол-во
                {
                    mermaidPlace2 = 60; // код записки
                }
                else if (randomObilia == 2)
                {
                    mermaidPlace2 = Random.Range(1, 48);
                    if (mermaidPlace2 == 26 || mermaidPlace2 == 39 || mermaidPlace2 == 43 || mermaidPlace2 == 45)
                    {
                        mermaidPlace2 = 10;
                    }
                }
                randomIkornyy = Random.Range(1, 3); // награда-икра
            }

            else if (other.name == "Abbet(Clone)")
            {
                PlayerPrefs.SetFloat("readAbbet", 1);
                enemySpawner.bAbbet = true; // личный бул мермена
                randomObilia = Random.Range(1, 3);
                sixdom = Random.Range(1, 20); // 6 вариантов русалок
                sixdom2 = Random.Range(1, 20); // 6 вариантов русалок
                switch (sixdom)
                {
                    case 1:
                        mermaidPlace1 = 7;
                        break;
                    case 2:
                        mermaidPlace1 = 10;
                        break;
                    case 3:
                        mermaidPlace1 = 48;
                        break;
                    case 4:
                        mermaidPlace1 = 1;
                        break;
                    case 5:
                        mermaidPlace1 = 2;
                        break;
                    case 6:
                        mermaidPlace1 = 11;
                        break;
                    case 7:
                        mermaidPlace1 = 4;
                        break;
                    case 8:
                        mermaidPlace1 = 5;
                        break;
                    case 9:
                        mermaidPlace1 = 6;
                        break;
                    case 10:
                        mermaidPlace1 = 16;
                        break;
                    default:
                        mermaidPlace1 = 11;
                        break;
                }

                if (randomObilia == 2 && zapiski != 10 && mermaidprevious != 60 && distan.distance > 5650) // максимальное кол-во
                {
                    mermaidPlace2 = 60; // код записки
                }
                else if (randomObilia == 2)
                {
                    switch (sixdom2)
                    {
                        case 1:
                            mermaidPlace2 = 7;
                            break;
                        case 2:
                            mermaidPlace2 = 10;
                            break;
                        case 3:
                            mermaidPlace2 = 48;
                            break;
                        case 4:
                            mermaidPlace2 = 1;
                            break;
                        case 5:
                            mermaidPlace2 = 2;
                            break;
                        case 6:
                            mermaidPlace2 = 11;
                            break;
                        case 7:
                            mermaidPlace2 = 4;
                            break;
                        case 8:
                            mermaidPlace2 = 5;
                            break;
                        case 9:
                            mermaidPlace2 = 6;
                            break;
                        case 10:
                            mermaidPlace2 = 16;
                            break;
                        default:
                            mermaidPlace2 = 11;
                            break;
                    }
                }
                randomIkornyy = Random.Range(5, 10); // награда-икра
            }

            else if (other.name == "Phobel(Clone)")
            {
                PlayerPrefs.SetFloat("readPhobel", 1);
                enemySpawner.bPhobel = true; // личный бул мермена
                randomObilia = Random.Range(1, 3);
                sixdom = Random.Range(1, 18); // 6 вариантов русалок
                sixdom2 = Random.Range(1, 18); // 6 вариантов русалок
                switch (sixdom)
                {
                    case 1:
                        mermaidPlace1 = 7;
                        break;
                    case 2:
                        mermaidPlace1 = 10;
                        break;
                    case 3:
                        mermaidPlace1 = 48;
                        break;
                    case 4:
                        mermaidPlace1 = 36;
                        break;
                    case 5:
                        mermaidPlace1 = 24;
                        break;
                    case 6:
                        mermaidPlace1 = 13;
                        break;
                    case 7:
                        mermaidPlace1 = 22;
                        break;
                    case 8:
                        mermaidPlace1 = 17;
                        break;
                    default:
                        mermaidPlace1 = 12;
                        break;
                }

                if (randomObilia == 2 && zapiski != 10 && mermaidprevious != 60 && distan.distance > 5650) // максимальное кол-во
                {
                    mermaidPlace2 = 60; // код записки
                }
                else if (randomObilia == 2)
                {
                    switch (sixdom2)
                    {
                        case 1:
                            mermaidPlace2 = 7;
                            break;
                        case 2:
                            mermaidPlace2 = 10;
                            break;
                        case 3:
                            mermaidPlace2 = 48;
                            break;
                        case 4:
                            mermaidPlace2 = 36;
                            break;
                        case 5:
                            mermaidPlace2 = 24;
                            break;
                        case 6:
                            mermaidPlace2 = 13;
                            break;
                        case 7:
                            mermaidPlace2 = 22;
                            break;
                        case 8:
                            mermaidPlace2 = 17;
                            break;
                        default:
                            mermaidPlace2 = 12;
                            break;
                    }
                }
                randomIkornyy = 1; // награда-икра
            }

            else if (other.name == "Paster(Clone)")
            {
                PlayerPrefs.SetFloat("readPaster", 1);
                enemySpawner.bPaster = true; // личный бул мермена
                randomObilia = Random.Range(1, 3);
                sixdom = Random.Range(1, 12); // 6 вариантов русалок
                sixdom2 = Random.Range(1, 12); // 6 вариантов русалок
                switch (sixdom)
                {
                    case 1:
                        mermaidPlace1 = 7;
                        break;
                    case 2:
                        mermaidPlace1 = 10;
                        break;
                    case 3:
                        mermaidPlace1 = 48;
                        break;
                    case 4:
                        mermaidPlace1 = 13;
                        break;
                    case 5:
                        mermaidPlace1 = 12;
                        break;
                    case 6:
                        mermaidPlace1 = 18;
                        break;
                    case 7:
                        mermaidPlace1 = 33;
                        break;
                    case 8:
                        mermaidPlace1 = 29;
                        break;
                    default:
                        mermaidPlace1 = 13;
                        break;
                }

                if (randomObilia == 2 && zapiski != 10 && mermaidprevious != 60 && distan.distance > 5650) // максимальное кол-во
                {
                    mermaidPlace2 = 60; // код записки
                }
                else if (randomObilia == 2)
                {
                    switch (sixdom2)
                    {
                        case 1:
                            mermaidPlace2 = 7;
                            break;
                        case 2:
                            mermaidPlace2 = 10;
                            break;
                        case 3:
                            mermaidPlace2 = 48;
                            break;
                        case 4:
                            mermaidPlace2 = 13;
                            break;
                        case 5:
                            mermaidPlace2 = 12;
                            break;
                        case 6:
                            mermaidPlace2 = 18;
                            break;
                        case 7:
                            mermaidPlace2 = 33;
                            break;
                        case 8:
                            mermaidPlace2 = 29;
                            break;
                        default:
                            mermaidPlace2 = 13;
                            break;
                    }
                }
                randomIkornyy = Random.Range(1, 3); // награда-икра
            }

            else if (other.name == "Popmp(Clone)")
            {
                PlayerPrefs.SetFloat("readPopmp", 1);
                enemySpawner.bPopmp = true; // личный бул мермена
                randomObilia = 1;
                sixdom = Random.Range(1, 11); // 6 вариантов русалок
                sixdom2 = Random.Range(1, 11); // 6 вариантов русалок
                switch (sixdom)
                {
                    case 1:
                        mermaidPlace1 = 7;
                        break;
                    case 2:
                        mermaidPlace1 = 10;
                        break;
                    case 3:
                        mermaidPlace1 = 48;
                        break;
                    case 4:
                        mermaidPlace1 = 8;
                        break;
                    case 5:
                        mermaidPlace1 = 41;
                        break;
                    case 6:
                        mermaidPlace1 = 21;
                        break;
                    default:
                        mermaidPlace1 = 14;
                        break;
                }

                if (randomObilia == 2 && zapiski != 10 && mermaidprevious != 60 && distan.distance > 5650) // максимальное кол-во
                {
                    mermaidPlace2 = 60; // код записки
                }
                else if (randomObilia == 2)
                {
                    switch (sixdom2)
                    {
                        case 1:
                            mermaidPlace2 = 7;
                            break;
                        case 2:
                            mermaidPlace2 = 10;
                            break;
                        case 3:
                            mermaidPlace2 = 48;
                            break;
                        case 4:
                            mermaidPlace2 = 8;
                            break;
                        case 5:
                            mermaidPlace2 = 41;
                            break;
                        case 6:
                            mermaidPlace2 = 21;
                            break;
                        default:
                            mermaidPlace2 = 14;
                            break;
                    }
                }
                randomIkornyy = 1; // награда-икра
            }

            else if (other.name == "Topel(Clone)")
            {
                PlayerPrefs.SetFloat("readTopel", 1);
                enemySpawner.bTopel = true; // личный бул мермена
                randomObilia = Random.Range(1, 3);
                sixdom = Random.Range(1, 10); // 6 вариантов русалок
                sixdom2 = Random.Range(1, 10); // 6 вариантов русалок
                switch (sixdom)
                {
                    case 1:
                        mermaidPlace1 = 7;
                        break;
                    case 2:
                        mermaidPlace1 = 10;
                        break;
                    case 3:
                        mermaidPlace1 = 48;
                        break;
                    case 4:
                        mermaidPlace1 = 25;
                        break;
                    case 5:
                        mermaidPlace1 = 9;
                        break;
                    default:
                        mermaidPlace1 = 15;
                        break;
                }

                if (randomObilia == 2 && zapiski != 10 && mermaidprevious != 60 && distan.distance > 5650) // максимальное кол-во
                {
                    mermaidPlace2 = 60; // код записки
                }
                else if (randomObilia == 2)
                {
                    switch (sixdom2)
                    {
                        case 1:
                            mermaidPlace2 = 7;
                            break;
                        case 2:
                            mermaidPlace2 = 10;
                            break;
                        case 3:
                            mermaidPlace2 = 48;
                            break;
                        case 4:
                            mermaidPlace2 = 25;
                            break;
                        case 5:
                            mermaidPlace2 = 9;
                            break;
                        default:
                            mermaidPlace2 = 15;
                            break;
                    }
                }
                randomIkornyy = 1; // награда-икра
            }

            else if (other.name == "Lihet(Clone)")
            {
                PlayerPrefs.SetFloat("readLihet", 1);
                enemySpawner.bLihet = true; // личный бул мермена
                randomObilia = Random.Range(1, 3);
                sixdom = Random.Range(1, 16); // 6 вариантов русалок
                sixdom2 = Random.Range(1, 16); // 6 вариантов русалок
                switch (sixdom)
                {
                    case 1:
                        mermaidPlace1 = 7;
                        break;
                    case 2:
                        mermaidPlace1 = 10;
                        break;
                    case 3:
                        mermaidPlace1 = 48;
                        break;
                    case 4:
                        mermaidPlace1 = 3;
                        break;
                    case 5:
                        mermaidPlace1 = 9;
                        break;
                    case 6:
                        mermaidPlace1 = 19;
                        break;
                    case 7:
                        mermaidPlace1 = 23;
                        break;
                    case 8:
                        mermaidPlace1 = 37;
                        break;
                    case 9:
                        mermaidPlace1 = 38;
                        break;
                    default:
                        mermaidPlace1 = 16;
                        break;
                }

                if (randomObilia == 2 && zapiski != 10 && mermaidprevious != 60 && distan.distance > 5650) // максимальное кол-во
                {
                    mermaidPlace2 = 60; // код записки
                }
                else if (randomObilia == 2)
                {
                    switch (sixdom2)
                    {
                        case 1:
                            mermaidPlace2 = 7;
                            break;
                        case 2:
                            mermaidPlace2 = 10;
                            break;
                        case 3:
                            mermaidPlace2 = 48;
                            break;
                        case 4:
                            mermaidPlace2 = 3;
                            break;
                        case 5:
                            mermaidPlace2 = 9;
                            break;
                        case 6:
                            mermaidPlace2 = 19;
                            break;
                        case 7:
                            mermaidPlace2 = 23;
                            break;
                        case 8:
                            mermaidPlace2 = 37;
                            break;
                        case 9:
                            mermaidPlace2 = 38;
                            break;
                        default:
                            mermaidPlace2 = 16;
                            break;
                    }
                }

                randomIkornyy = 1; // награда-икра
            }

            else if (other.name == "Babil(Clone)")
            {
                PlayerPrefs.SetFloat("readBabil", 1);
                enemySpawner.bBabil = true; // личный бул мермена
                randomObilia = Random.Range(1, 3);
                sixdom = Random.Range(1, 16); // 6 вариантов русалок
                sixdom2 = Random.Range(1, 16); // 6 вариантов русалок
                switch (sixdom)
                {
                    case 1:
                        mermaidPlace1 = 7;
                        break;
                    case 2:
                        mermaidPlace1 = 10;
                        break;
                    case 3:
                        mermaidPlace1 = 48;
                        break;
                    case 4:
                        mermaidPlace1 = 17;
                        break;
                    case 5:
                        mermaidPlace1 = 40;
                        break;
                    case 6:
                        mermaidPlace1 = 28;
                        break;
                    case 7:
                        mermaidPlace1 = 14;
                        break;
                    case 8:
                        mermaidPlace1 = 42;
                        break;
                    default:
                        mermaidPlace1 = 17;
                        break;
                }

                if (randomObilia == 2 && zapiski != 10 && mermaidprevious != 60 && distan.distance > 5650) // максимальное кол-во
                {
                    mermaidPlace2 = 60; // код записки
                }
                else if (randomObilia == 2)
                {
                    switch (sixdom2)
                    {
                        case 1:
                            mermaidPlace2 = 7;
                            break;
                        case 2:
                            mermaidPlace2 = 10;
                            break;
                        case 3:
                            mermaidPlace2 = 48;
                            break;
                        case 4:
                            mermaidPlace2 = 17;
                            break;
                        case 5:
                            mermaidPlace2 = 40;
                            break;
                        case 6:
                            mermaidPlace2 = 28;
                            break;
                        case 7:
                            mermaidPlace2 = 14;
                            break;
                        case 8:
                            mermaidPlace2 = 42;
                            break;
                        default:
                            mermaidPlace2 = 17;
                            break;
                    }
                }
                randomIkornyy = 1; // награда-икра
            }

            else if (other.name == "Sactin(Clone)")
            {
                PlayerPrefs.SetFloat("readSactin", 1);
                enemySpawner.bSactin = true; // личный бул мермена
                randomObilia = Random.Range(1, 3);
                sixdom = Random.Range(1, 16); // 6 вариантов русалок
                sixdom2 = Random.Range(1, 16); // 6 вариантов русалок
                switch (sixdom)
                {
                    case 1:
                        mermaidPlace1 = 7;
                        break;
                    case 2:
                        mermaidPlace1 = 10;
                        break;
                    case 3:
                        mermaidPlace1 = 48;
                        break;
                    case 4:
                        mermaidPlace1 = 1;
                        break;
                    case 5:
                        mermaidPlace1 = 18;
                        break;
                    case 6:
                        mermaidPlace1 = 40;
                        break;
                    case 7:
                        mermaidPlace1 = 13;
                        break;
                    case 8:
                        mermaidPlace1 = 12;
                        break;
                    case 9:
                        mermaidPlace1 = 33;
                        break;
                    case 10:
                        mermaidPlace1 = 29;
                        break;
                    default:
                        mermaidPlace1 = 18;
                        break;
                }

                if (randomObilia == 2 && zapiski != 10 && mermaidprevious != 60 && distan.distance > 5650) // максимальное кол-во
                {
                    mermaidPlace2 = 60; // код записки
                }
                else if (randomObilia == 2)
                {
                    switch (sixdom2)
                    {
                        case 1:
                            mermaidPlace2 = 7;
                            break;
                        case 2:
                            mermaidPlace2 = 10;
                            break;
                        case 3:
                            mermaidPlace2 = 48;
                            break;
                        case 4:
                            mermaidPlace2 = 1;
                            break;
                        case 5:
                            mermaidPlace2 = 18;
                            break;
                        case 6:
                            mermaidPlace2 = 40;
                            break;
                        case 7:
                            mermaidPlace2 = 13;
                            break;
                        case 8:
                            mermaidPlace2 = 12;
                            break;
                        case 9:
                            mermaidPlace2 = 33;
                            break;
                        case 10:
                            mermaidPlace2 = 29;
                            break;
                        default:
                            mermaidPlace2 = 18;
                            break;
                    }
                }
                randomIkornyy = Random.Range(1, 10); // награда-икра
            }

            else if (other.name == "Heeth(Clone)")
            {
                PlayerPrefs.SetFloat("readHeeth", 1);
                enemySpawner.bHeeth = true; // личный бул мермена
                randomObilia = Random.Range(1, 3);
                sixdom = Random.Range(1, 7); // 6 вариантов русалок
                sixdom2 = Random.Range(1, 7); // 6 вариантов русалок
                switch (sixdom)
                {
                    case 1:
                        mermaidPlace1 = 7;
                        break;
                    case 2:
                        mermaidPlace1 = 10;
                        break;
                    case 3:
                        mermaidPlace1 = 48;
                        break;
                    case 4:
                        mermaidPlace1 = 8;
                        break;
                    default:
                        mermaidPlace1 = 19;
                        break;
                }

                if (randomObilia == 2 && zapiski != 10 && mermaidprevious != 60 && distan.distance > 5650) // максимальное кол-во
                {
                    mermaidPlace2 = 60; // код записки
                }
                else if (randomObilia == 2)
                {
                    switch (sixdom2)
                    {
                        case 1:
                            mermaidPlace2 = 7;
                            break;
                        case 2:
                            mermaidPlace2 = 10;
                            break;
                        case 3:
                            mermaidPlace2 = 48;
                            break;
                        case 4:
                            mermaidPlace2 = 8;
                            break;
                        default:
                            mermaidPlace2 = 19;
                            break;
                    }
                }
                randomIkornyy = Random.Range(6, 10); // награда-икра
            }

            else if (other.name == "Sothet(Clone)")
            {
                PlayerPrefs.SetFloat("readSothet", 1);
                enemySpawner.bSothet = true; // личный бул мермена
                randomObilia = Random.Range(1, 3);
                sixdom = Random.Range(1, 16); // 6 вариантов русалок
                sixdom2 = Random.Range(1, 16); // 6 вариантов русалок
                switch (sixdom)
                {
                    case 1:
                        mermaidPlace1 = 7;
                        break;
                    case 2:
                        mermaidPlace1 = 10;
                        break;
                    case 3:
                        mermaidPlace1 = 48;
                        break;
                    case 4:
                        mermaidPlace1 = 20;
                        break;
                    case 5:
                        mermaidPlace1 = 16;
                        break;
                    case 6:
                        mermaidPlace1 = 3;
                        break;
                    case 7:
                        mermaidPlace1 = 19;
                        break;
                    case 8:
                        mermaidPlace1 = 23;
                        break;
                    case 9:
                        mermaidPlace1 = 37;
                        break;
                    case 10:
                        mermaidPlace1 = 38;
                        break;
                    default:
                        mermaidPlace1 = 20;
                        break;
                }

                if (randomObilia == 2 && zapiski != 10 && mermaidprevious != 60 && distan.distance > 5650) // максимальное кол-во
                {
                    mermaidPlace2 = 60; // код записки
                }
                else if (randomObilia == 2)
                {
                    switch (sixdom2)
                    {
                        case 1:
                            mermaidPlace2 = 7;
                            break;
                        case 2:
                            mermaidPlace2 = 10;
                            break;
                        case 3:
                            mermaidPlace2 = 48;
                            break;
                        case 4:
                            mermaidPlace2 = 20;
                            break;
                        case 5:
                            mermaidPlace2 = 16;
                            break;
                        case 6:
                            mermaidPlace2 = 3;
                            break;
                        case 7:
                            mermaidPlace2 = 19;
                            break;
                        case 8:
                            mermaidPlace2 = 23;
                            break;
                        case 9:
                            mermaidPlace2 = 37;
                            break;
                        case 10:
                            mermaidPlace2 = 38;
                            break;
                        default:
                            mermaidPlace2 = 20;
                            break;
                    }
                }
                randomIkornyy = 10; // награда-икра
            }

            else if (other.name == "Echin(Clone)")
            {
                PlayerPrefs.SetFloat("readEchin", 1);
                enemySpawner.bEchin = true; // личный бул мермена
                randomObilia = Random.Range(1, 3);
                sixdom = Random.Range(1, 16); // 6 вариантов русалок
                sixdom2 = Random.Range(1, 16); // 6 вариантов русалок
                switch (sixdom)
                {
                    case 1:
                        mermaidPlace1 = 7;
                        break;
                    case 2:
                        mermaidPlace1 = 10;
                        break;
                    case 3:
                        mermaidPlace1 = 48;
                        break;
                    case 4:
                        mermaidPlace1 = 21;
                        break;
                    case 5:
                        mermaidPlace1 = 13;
                        break;
                    case 6:
                        mermaidPlace1 = 18;
                        break;
                    case 7:
                        mermaidPlace1 = 29;
                        break;
                    case 8:
                        mermaidPlace1 = 8;
                        break;
                    case 9:
                        mermaidPlace1 = 40;
                        break;
                    case 10:
                        mermaidPlace1 = 46;
                        break;
                    default:
                        mermaidPlace1 = 21;
                        break;
                }

                if (randomObilia == 2 && zapiski != 10 && mermaidprevious != 60 && distan.distance > 5650) // максимальное кол-во
                {
                    mermaidPlace2 = 60; // код записки
                }
                else if (randomObilia == 2)
                {
                    switch (sixdom2)
                    {
                        case 1:
                            mermaidPlace2 = 7;
                            break;
                        case 2:
                            mermaidPlace2 = 10;
                            break;
                        case 3:
                            mermaidPlace2 = 48;
                            break;
                        case 4:
                            mermaidPlace2 = 21;
                            break;
                        case 5:
                            mermaidPlace2 = 13;
                            break;
                        case 6:
                            mermaidPlace2 = 18;
                            break;
                        case 7:
                            mermaidPlace2 = 29;
                            break;
                        case 8:
                            mermaidPlace2 = 8;
                            break;
                        case 9:
                            mermaidPlace2 = 40;
                            break;
                        case 10:
                            mermaidPlace2 = 46;
                            break;
                        default:
                            mermaidPlace2 = 21;
                            break;
                    }
                }
                randomIkornyy = Random.Range(5, 10); // награда-икра
            }

            else if (other.name == "Phanos(Clone)")
            {
                PlayerPrefs.SetFloat("readPhanos", 1);
                enemySpawner.bPhanos = true; // личный бул мермена
                randomObilia = Random.Range(1, 3);
                sixdom = Random.Range(1, 18); // 6 вариантов русалок
                sixdom2 = Random.Range(1, 18); // 6 вариантов русалок
                switch (sixdom)
                {
                    case 1:
                        mermaidPlace1 = 7;
                        break;
                    case 2:
                        mermaidPlace1 = 10;
                        break;
                    case 3:
                        mermaidPlace1 = 48;
                        break;
                    case 4:
                        mermaidPlace1 = 22;
                        break;
                    case 5:
                        mermaidPlace1 = 36;
                        break;
                    case 6:
                        mermaidPlace1 = 13;
                        break;
                    case 7:
                        mermaidPlace1 = 17;
                        break;
                    case 8:
                        mermaidPlace1 = 12;
                        break;
                    case 9:
                        mermaidPlace1 = 33;
                        break;
                    default:
                        mermaidPlace1 = 22;
                        break;
                }

                if (randomObilia == 2 && zapiski != 10 && mermaidprevious != 60 && distan.distance > 5650) // максимальное кол-во
                {
                    mermaidPlace2 = 60; // код записки
                }
                else if (randomObilia == 2)
                {
                    switch (sixdom2)
                    {
                        case 1:
                            mermaidPlace2 = 7;
                            break;
                        case 2:
                            mermaidPlace2 = 10;
                            break;
                        case 3:
                            mermaidPlace2 = 48;
                            break;
                        case 4:
                            mermaidPlace2 = 22;
                            break;
                        case 5:
                            mermaidPlace2 = 36;
                            break;
                        case 6:
                            mermaidPlace2 = 13;
                            break;
                        case 7:
                            mermaidPlace2 = 17;
                            break;
                        case 8:
                            mermaidPlace2 = 12;
                            break;
                        case 9:
                            mermaidPlace2 = 33;
                            break;
                        default:
                            mermaidPlace2 = 22;
                            break;
                    }
                }
                randomIkornyy = Random.Range(1, 10); // награда-икра
            }

            else if (other.name == "Theus(Clone)")
            {
                PlayerPrefs.SetFloat("readTheus", 1);
                enemySpawner.bTheus = true; // личный бул мермена
                randomObilia = Random.Range(1, 3);
                sixdom = Random.Range(1, 20); // 6 вариантов русалок
                sixdom2 = Random.Range(1, 20); // 6 вариантов русалок
                switch (sixdom)
                {
                    case 1:
                        mermaidPlace1 = 7;
                        break;
                    case 2:
                        mermaidPlace1 = 10;
                        break;
                    case 3:
                        mermaidPlace1 = 48;
                        break;
                    case 4:
                        mermaidPlace1 = 42;
                        break;
                    case 5:
                        mermaidPlace1 = 24;
                        break;
                    case 6:
                        mermaidPlace1 = 25;
                        break;
                    case 7:
                        mermaidPlace1 = 37;
                        break;
                    case 8:
                        mermaidPlace1 = 38;
                        break;
                    case 9:
                        mermaidPlace1 = 41;
                        break;
                    case 10:
                        mermaidPlace1 = 46;
                        break;
                    default:
                        mermaidPlace1 = 23;
                        break;
                }

                if (randomObilia == 2 && zapiski != 10 && mermaidprevious != 60 && distan.distance > 5650) // максимальное кол-во
                {
                    mermaidPlace2 = 60; // код записки
                }
                else if (randomObilia == 2)
                {
                    switch (sixdom2)
                    {
                        case 1:
                            mermaidPlace2 = 7;
                            break;
                        case 2:
                            mermaidPlace2 = 10;
                            break;
                        case 3:
                            mermaidPlace2 = 48;
                            break;
                        case 4:
                            mermaidPlace2 = 42;
                            break;
                        case 5:
                            mermaidPlace2 = 24;
                            break;
                        case 6:
                            mermaidPlace2 = 25;
                            break;
                        case 7:
                            mermaidPlace2 = 37;
                            break;
                        case 8:
                            mermaidPlace2 = 38;
                            break;
                        case 9:
                            mermaidPlace2 = 41;
                            break;
                        case 10:
                            mermaidPlace2 = 46;
                            break;
                        default:
                            mermaidPlace2 = 23;
                            break;
                    }
                }
                randomIkornyy = 1; // награда-икра
            }

            else if (other.name == "Zem(Clone)")
            {
                PlayerPrefs.SetFloat("readZem", 1);
                enemySpawner.bZem = true; // личный бул мермена
                randomObilia = Random.Range(1, 3);
                sixdom = Random.Range(1, 16); // 6 вариантов русалок
                sixdom2 = Random.Range(1, 16); // 6 вариантов русалок
                switch (sixdom)
                {
                    case 1:
                        mermaidPlace1 = 7;
                        break;
                    case 2:
                        mermaidPlace1 = 10;
                        break;
                    case 3:
                        mermaidPlace1 = 48;
                        break;
                    case 4:
                        mermaidPlace1 = 40;
                        break;
                    case 5:
                        mermaidPlace1 = 14;
                        break;
                    case 6:
                        mermaidPlace1 = 8;
                        break;
                    case 7:
                        mermaidPlace1 = 41;
                        break;
                    case 8:
                        mermaidPlace1 = 21;
                        break;
                    case 9:
                        mermaidPlace1 = 46;
                        break;
                    default:
                        mermaidPlace1 = 24;
                        break;
                }
                if (randomObilia == 2 && zapiski != 10 && mermaidprevious != 60 && distan.distance > 5650) // максимальное кол-во
                {
                    mermaidPlace2 = 60; // код записки
                }
                else if (randomObilia == 2)
                {
                    switch (sixdom2)
                    {
                        case 1:
                            mermaidPlace2 = 7;
                            break;
                        case 2:
                            mermaidPlace2 = 10;
                            break;
                        case 3:
                            mermaidPlace2 = 48;
                            break;
                        case 4:
                            mermaidPlace2 = 40;
                            break;
                        case 5:
                            mermaidPlace2 = 14;
                            break;
                        case 6:
                            mermaidPlace2 = 8;
                            break;
                        case 7:
                            mermaidPlace2 = 41;
                            break;
                        case 8:
                            mermaidPlace2 = 21;
                            break;
                        case 9:
                            mermaidPlace2 = 46;
                            break;
                        default:
                            mermaidPlace2 = 24;
                            break;
                    }
                }
                randomIkornyy = 1; // награда-икра
            }

            else if (other.name == "Gren(Clone)")
            {
                PlayerPrefs.SetFloat("readGren", 1);
                enemySpawner.bGren = true; // личный бул мермена
                randomObilia = Random.Range(1, 3);
                sixdom = Random.Range(1, 16); // 6 вариантов русалок
                sixdom2 = Random.Range(1, 16); // 6 вариантов русалок
                switch (sixdom)
                {
                    case 1:
                        mermaidPlace1 = 7;
                        break;
                    case 2:
                        mermaidPlace1 = 10;
                        break;
                    case 3:
                        mermaidPlace1 = 48;
                        break;
                    case 4:
                        mermaidPlace1 = 15;
                        break;
                    case 5:
                        mermaidPlace1 = 5;
                        break;
                    case 6:
                        mermaidPlace1 = 21;
                        break;
                    case 7:
                        mermaidPlace1 = 20;
                        break;
                    case 8:
                        mermaidPlace1 = 27;
                        break;
                    case 9:
                        mermaidPlace1 = 31;
                        break;
                    case 10:
                        mermaidPlace1 = 31;
                        break;
                    default:
                        mermaidPlace1 = 25;
                        break;
                }

                if (randomObilia == 2 && zapiski != 10 && mermaidprevious != 60 && distan.distance > 5650) // максимальное кол-во
                {
                    mermaidPlace2 = 60; // код записки
                }
                else if (randomObilia == 2)
                {
                    switch (sixdom2)
                    {
                        case 1:
                            mermaidPlace2 = 7;
                            break;
                        case 2:
                            mermaidPlace2 = 10;
                            break;
                        case 3:
                            mermaidPlace2 = 48;
                            break;
                        case 4:
                            mermaidPlace2 = 15;
                            break;
                        case 5:
                            mermaidPlace2 = 5;
                            break;
                        case 6:
                            mermaidPlace2 = 21;
                            break;
                        case 7:
                            mermaidPlace2 = 20;
                            break;
                        case 8:
                            mermaidPlace2 = 27;
                            break;
                        case 9:
                            mermaidPlace2 = 31;
                            break;
                        case 10:
                            mermaidPlace2 = 31;
                            break;
                        default:
                            mermaidPlace2 = 25;
                            break;
                    }
                }
                randomIkornyy = Random.Range(5, 10); // награда-икра
            }

            else if (other.name == "Mikt(Clone)")
            {
                PlayerPrefs.SetFloat("readMikt", 1);
                enemySpawner.bMikt = true; // личный бул мермена
                randomObilia = Random.Range(1, 3);
                sixdom = Random.Range(1, 17); // 6 вариантов русалок
                sixdom2 = Random.Range(1, 17); // 6 вариантов русалок
                switch (sixdom)
                {
                    case 1:
                        mermaidPlace1 = 7;
                        break;
                    case 2:
                        mermaidPlace1 = 10;
                        break;
                    case 3:
                        mermaidPlace1 = 48;
                        break;
                    case 4:
                        mermaidPlace1 = 20;
                        break;
                    case 5:
                        mermaidPlace1 = 16;
                        break;
                    case 6:
                        mermaidPlace1 = 19;
                        break;
                    case 7:
                        mermaidPlace1 = 23;
                        break;
                    case 8:
                        mermaidPlace1 = 37;
                        break;
                    case 9:
                        mermaidPlace1 = 38;
                        break;
                    case 10:
                        mermaidPlace1 = 35;
                        break;
                    default:
                        mermaidPlace1 = 27;
                        break;
                }

                if (randomObilia == 2 && zapiski != 10 && mermaidprevious != 60 && distan.distance > 5650) // максимальное кол-во
                {
                    mermaidPlace2 = 60; // код записки
                }
                else if (randomObilia == 2)
                {
                    switch (sixdom2)
                    {
                        case 1:
                            mermaidPlace2 = 7;
                            break;
                        case 2:
                            mermaidPlace2 = 10;
                            break;
                        case 3:
                            mermaidPlace2 = 48;
                            break;
                        case 4:
                            mermaidPlace2 = 20;
                            break;
                        case 5:
                            mermaidPlace2 = 16;
                            break;
                        case 6:
                            mermaidPlace2 = 19;
                            break;
                        case 7:
                            mermaidPlace2 = 23;
                            break;
                        case 8:
                            mermaidPlace2 = 37;
                            break;
                        case 9:
                            mermaidPlace2 = 38;
                            break;
                        case 10:
                            mermaidPlace2 = 35;
                            break;
                        default:
                            mermaidPlace2 = 27;
                            break;
                    }
                }
                randomIkornyy = Random.Range(5, 10); // награда-икра
            }

            else if (other.name == "Nophor(Clone)")
            {
                PlayerPrefs.SetFloat("readNophor", 1);
                enemySpawner.bNophor = true; // личный бул мермена
                randomObilia = Random.Range(1, 3);
                sixdom = Random.Range(1, 16); // 6 вариантов русалок
                sixdom2 = Random.Range(1, 16); // 6 вариантов русалок
                switch (sixdom)
                {
                    case 1:
                        mermaidPlace1 = 7;
                        break;
                    case 2:
                        mermaidPlace1 = 10;
                        break;
                    case 3:
                        mermaidPlace1 = 48;
                        break;
                    case 4:
                        mermaidPlace1 = 17;
                        break;
                    case 5:
                        mermaidPlace1 = 30;
                        break;
                    case 6:
                        mermaidPlace1 = 36;
                        break;
                    case 7:
                        mermaidPlace1 = 44;
                        break;
                    case 8:
                        mermaidPlace1 = 47;
                        break;
                    default:
                        mermaidPlace1 = 28;
                        break;
                }
                if (randomObilia == 2 && zapiski != 10 && mermaidprevious != 60 && distan.distance > 5650) // максимальное кол-во
                {
                    mermaidPlace2 = 60; // код записки
                }
                else if (randomObilia == 2)
                {
                    switch (sixdom2)
                    {
                        case 1:
                            mermaidPlace2 = 7;
                            break;
                        case 2:
                            mermaidPlace2 = 10;
                            break;
                        case 3:
                            mermaidPlace2 = 48;
                            break;
                        case 4:
                            mermaidPlace2 = 17;
                            break;
                        case 5:
                            mermaidPlace2 = 30;
                            break;
                        case 6:
                            mermaidPlace2 = 36;
                            break;
                        case 7:
                            mermaidPlace2 = 44;
                            break;
                        case 8:
                            mermaidPlace2 = 47;
                            break;
                        default:
                            mermaidPlace2 = 28;
                            break;
                    }
                }
                randomIkornyy = 1; // награда-икра
            }

            else if (other.name == "Asce(Clone)")
            {
                PlayerPrefs.SetFloat("readAsce", 1);
                enemySpawner.bAsce = true; // личный бул мермена
                randomObilia = Random.Range(1, 3);
                mermaidPlace1 = 29;
                if (randomObilia == 2 && zapiski != 10 && mermaidprevious != 60 && distan.distance > 5650) // максимальное кол-во
                {
                    mermaidPlace2 = 60; // код записки
                }
                else if (randomObilia == 2)
                {
                    mermaidPlace2 = 29;
                }
                randomIkornyy = 1; // награда-икра
                mermanreader.speshlblok1.SetActive(true);
                mermanreader.speshlblok2.SetActive(true);
                mermanreader.speshlblok3.SetActive(true);
                mermanreader.speshlblok4.SetActive(true);
                mermanreader.speshlblok5.SetActive(true);
                mermanreader.speshlblok6.SetActive(true);
                mermanreader.speshlblok7.SetActive(true);
                mermanreader.speshlblok8.SetActive(true);
                mermanreader.speshlblok9.SetActive(true);
                slotsmerman.slo1blocked.SetActive(true);
                slotsmerman.slo2blocked.SetActive(true);
                slotsmerman.slo3blocked.SetActive(true);
                slotsmerman.slo4blocked.SetActive(true);
                slotsmerman.slo5blocked.SetActive(true);
                slotsmerman.slo6blocked.SetActive(true);
                slotsmerman.slo7blocked.SetActive(true);
                slotsmerman.slo8blocked.SetActive(true);
                slotsmerman.slo9blocked.SetActive(true);


            }

            else if (other.name == "Tkhar(Clone)")
            {
                PlayerPrefs.SetFloat("readTkhar", 1);
                enemySpawner.bTkhar = true; // личный бул мермена
                randomObilia = Random.Range(1, 3);
                sixdom = Random.Range(1, 10); // 6 вариантов русалок
                sixdom2 = Random.Range(1, 10); // 6 вариантов русалок
                switch (sixdom)
                {
                    case 1:
                        mermaidPlace1 = 7;
                        break;
                    case 2:
                        mermaidPlace1 = 10;
                        break;
                    case 3:
                        mermaidPlace1 = 48;
                        break;
                    case 4:
                        mermaidPlace1 = 44;
                        break;
                    case 5:
                        mermaidPlace1 = 47;
                        break;
                    default:
                        mermaidPlace1 = 30;
                        break;
                }

                if (randomObilia == 2 && zapiski != 10 && mermaidprevious != 60 && distan.distance > 5650) // максимальное кол-во
                {
                    mermaidPlace2 = 60; // код записки
                }
                else if (randomObilia == 2)
                {
                    switch (sixdom2)
                    {
                        case 1:
                            mermaidPlace2 = 7;
                            break;
                        case 2:
                            mermaidPlace2 = 10;
                            break;
                        case 3:
                            mermaidPlace2 = 48;
                            break;
                        case 4:
                            mermaidPlace2 = 44;
                            break;
                        case 5:
                            mermaidPlace2 = 47;
                            break;
                        default:
                            mermaidPlace2 = 30;
                            break;
                    }
                }
                randomIkornyy = 1; // награда-икра
            }

            else if (other.name == "Prokt(Clone)")
            {
                PlayerPrefs.SetFloat("readProkt", 1);
                enemySpawner.bProkt = true; // личный бул мермена
                randomObilia = Random.Range(1, 3);
                sixdom = Random.Range(1, 14); // 6 вариантов русалок
                sixdom2 = Random.Range(1, 14); // 6 вариантов русалок
                switch (sixdom)
                {
                    case 1:
                        mermaidPlace1 = 7;
                        break;
                    case 2:
                        mermaidPlace1 = 10;
                        break;
                    case 3:
                        mermaidPlace1 = 48;
                        break;
                    case 4:
                        mermaidPlace1 = 32;
                        break;
                    case 5:
                        mermaidPlace1 = 37;
                        break;
                    case 6:
                        mermaidPlace1 = 38;
                        break;
                    case 7:
                        mermaidPlace1 = 42;
                        break;
                    case 8:
                        mermaidPlace1 = 44;
                        break;
                    case 9:
                        mermaidPlace1 = 47;
                        break;
                    default:
                        mermaidPlace1 = 31;
                        break;
                }

                if (randomObilia == 2 && zapiski != 10 && mermaidprevious != 60 && distan.distance > 5650) // максимальное кол-во
                {
                    mermaidPlace2 = 60; // код записки
                }
                else if (randomObilia == 2)
                {
                    switch (sixdom2)
                    {
                        case 1:
                            mermaidPlace2 = 7;
                            break;
                        case 2:
                            mermaidPlace2 = 10;
                            break;
                        case 3:
                            mermaidPlace2 = 48;
                            break;
                        case 4:
                            mermaidPlace2 = 32;
                            break;
                        case 5:
                            mermaidPlace2 = 37;
                            break;
                        case 6:
                            mermaidPlace2 = 38;
                            break;
                        case 7:
                            mermaidPlace2 = 42;
                            break;
                        case 8:
                            mermaidPlace2 = 44;
                            break;
                        case 9:
                            mermaidPlace2 = 47;
                            break;
                        default:
                            mermaidPlace2 = 31;
                            break;
                    }
                }
                randomIkornyy = Random.Range(5, 10); // награда-икра
            }

            else if (other.name == "Pareed(Clone)")
            {
                PlayerPrefs.SetFloat("readPareed", 1);
                enemySpawner.bPareed = true; // личный бул мермена
                randomObilia = Random.Range(1, 3);
                sixdom = Random.Range(1, 14); // 6 вариантов русалок
                sixdom2 = Random.Range(1, 14); // 6 вариантов русалок
                switch (sixdom)
                {
                    case 1:
                        mermaidPlace1 = 7;
                        break;
                    case 2:
                        mermaidPlace1 = 10;
                        break;
                    case 3:
                        mermaidPlace1 = 48;
                        break;
                    case 4:
                        mermaidPlace1 = 32;
                        break;
                    case 5:
                        mermaidPlace1 = 37;
                        break;
                    case 6:
                        mermaidPlace1 = 38;
                        break;
                    case 7:
                        mermaidPlace1 = 42;
                        break;
                    case 8:
                        mermaidPlace1 = 44;
                        break;
                    case 9:
                        mermaidPlace1 = 47;
                        break;
                    default:
                        mermaidPlace1 = 32;
                        break;
                }

                if (randomObilia == 2 && zapiski != 10 && mermaidprevious != 60 && distan.distance > 5650) // максимальное кол-во
                {
                    mermaidPlace2 = 60; // код записки
                }
                else if (randomObilia == 2)
                {
                    switch (sixdom2)
                    {
                        case 1:
                            mermaidPlace2 = 7;
                            break;
                        case 2:
                            mermaidPlace2 = 10;
                            break;
                        case 3:
                            mermaidPlace2 = 48;
                            break;
                        case 4:
                            mermaidPlace2 = 32;
                            break;
                        case 5:
                            mermaidPlace2 = 37;
                            break;
                        case 6:
                            mermaidPlace2 = 38;
                            break;
                        case 7:
                            mermaidPlace2 = 42;
                            break;
                        case 8:
                            mermaidPlace2 = 44;
                            break;
                        case 9:
                            mermaidPlace2 = 47;
                            break;
                        default:
                            mermaidPlace2 = 31;
                            break;
                    }
                }
                randomIkornyy = Random.Range(5, 10); // награда-икра
            }

            else if (other.name == "Hio(Clone)")
            {
                PlayerPrefs.SetFloat("readHio", 1);
                enemySpawner.bHio = true; // личный бул мермена
                randomObilia = Random.Range(1, 3);
                sixdom = Random.Range(1, 9); // 6 вариантов русалок
                sixdom2 = Random.Range(1, 9); // 6 вариантов русалок
                switch (sixdom)
                {
                    case 1:
                        mermaidPlace1 = 7;
                        break;
                    case 2:
                        mermaidPlace1 = 10;
                        break;
                    case 3:
                        mermaidPlace1 = 48;
                        break;
                    case 4:
                        mermaidPlace1 = 13;
                        break;
                    case 5:
                        mermaidPlace1 = 18;
                        break;
                    default:
                        mermaidPlace1 = 33;
                        break;
                }

                if (randomObilia == 2 && zapiski != 10 && mermaidprevious != 60 && distan.distance > 5650) // максимальное кол-во
                {
                    mermaidPlace2 = 60; // код записки
                }
                else if (randomObilia == 2)
                {
                    switch (sixdom2)
                    {
                        case 1:
                            mermaidPlace2 = 7;
                            break;
                        case 2:
                            mermaidPlace2 = 10;
                            break;
                        case 3:
                            mermaidPlace2 = 48;
                            break;
                        case 4:
                            mermaidPlace2 = 13;
                            break;
                        case 5:
                            mermaidPlace2 = 18;
                            break;
                        default:
                            mermaidPlace2 = 33;
                            break;
                    }
                }
                randomIkornyy = Random.Range(5, 10); // награда-икра
            }

            else if (other.name == "Galan(Clone)")
            {
                PlayerPrefs.SetFloat("readGalan", 1);
                enemySpawner.bGalan = true; // личный бул мермена
                randomObilia = Random.Range(1, 3);
                sixdom = Random.Range(1, 18); // 6 вариантов русалок
                sixdom2 = Random.Range(1, 18); // 6 вариантов русалок
                switch (sixdom)
                {
                    case 1:
                        mermaidPlace1 = 7;
                        break;
                    case 2:
                        mermaidPlace1 = 10;
                        break;
                    case 3:
                        mermaidPlace1 = 48;
                        break;
                    case 4:
                        mermaidPlace1 = 20;
                        break;
                    case 5:
                        mermaidPlace1 = 25;
                        break;
                    case 6:
                        mermaidPlace1 = 27;
                        break;
                    case 7:
                        mermaidPlace1 = 32;
                        break;
                    case 8:
                        mermaidPlace1 = 33;
                        break;
                    case 9:
                        mermaidPlace1 = 35;
                        break;
                    default:
                        mermaidPlace1 = 34;
                        break;
                }

                if (randomObilia == 2 && zapiski != 10 && mermaidprevious != 60 && distan.distance > 5650) // максимальное кол-во
                {
                    mermaidPlace2 = 60; // код записки
                }
                else if (randomObilia == 2)
                {
                    switch (sixdom2)
                    {
                        case 1:
                            mermaidPlace2 = 7;
                            break;
                        case 2:
                            mermaidPlace2 = 10;
                            break;
                        case 3:
                            mermaidPlace2 = 48;
                            break;
                        case 4:
                            mermaidPlace2 = 20;
                            break;
                        case 5:
                            mermaidPlace2 = 25;
                            break;
                        case 6:
                            mermaidPlace2 = 27;
                            break;
                        case 7:
                            mermaidPlace2 = 32;
                            break;
                        case 8:
                            mermaidPlace2 = 33;
                            break;
                        case 9:
                            mermaidPlace2 = 35;
                            break;
                        default:
                            mermaidPlace2 = 34;
                            break;
                    }
                }
                randomIkornyy = 1; // награда-икра
            }

            else if (other.name == "Lat(Clone)")
            {
                PlayerPrefs.SetFloat("readLat", 1);
                enemySpawner.bLat = true; // личный бул мермена
                randomObilia = Random.Range(1, 3);
                sixdom = Random.Range(1, 12); // 6 вариантов русалок
                sixdom2 = Random.Range(1, 12); // 6 вариантов русалок
                switch (sixdom)
                {
                    case 1:
                        mermaidPlace1 = 7;
                        break;
                    case 2:
                        mermaidPlace1 = 10;
                        break;
                    case 3:
                        mermaidPlace1 = 48;
                        break;
                    case 4:
                        mermaidPlace1 = 27;
                        break;
                    case 5:
                        mermaidPlace1 = 37;
                        break;
                    case 6:
                        mermaidPlace1 = 44;
                        break;
                    case 7:
                        mermaidPlace1 = 47;
                        break;
                    default:
                        mermaidPlace1 = 35;
                        break;
                }

                if (randomObilia == 2 && zapiski != 10 && mermaidprevious != 60 && distan.distance > 5650) // максимальное кол-во
                {
                    mermaidPlace2 = 60; // код записки
                }
                else if (randomObilia == 2)
                {
                    switch (sixdom2)
                    {
                        case 1:
                            mermaidPlace2 = 7;
                            break;
                        case 2:
                            mermaidPlace2 = 10;
                            break;
                        case 3:
                            mermaidPlace2 = 48;
                            break;
                        case 4:
                            mermaidPlace2 = 27;
                            break;
                        case 5:
                            mermaidPlace2 = 37;
                            break;
                        case 6:
                            mermaidPlace2 = 44;
                            break;
                        case 7:
                            mermaidPlace2 = 47;
                            break;
                        default:
                            mermaidPlace2 = 35;
                            break;
                    }
                }
                randomIkornyy = Random.Range(10, 15); // награда-икра
            }

            else if (other.name == "Sciph(Clone)")
            {
                PlayerPrefs.SetFloat("readSciph", 1);
                enemySpawner.bSciph = true; // личный бул мермена
                randomObilia = Random.Range(1, 3);
                sixdom = Random.Range(1, 16); // 6 вариантов русалок
                sixdom2 = Random.Range(1, 16); // 6 вариантов русалок
                switch (sixdom)
                {
                    case 1:
                        mermaidPlace1 = 7;
                        break;
                    case 2:
                        mermaidPlace1 = 10;
                        break;
                    case 3:
                        mermaidPlace1 = 48;
                        break;
                    case 4:
                        mermaidPlace1 = 28;
                        break;
                    case 5:
                        mermaidPlace1 = 46;
                        break;
                    case 6:
                        mermaidPlace1 = 35;
                        break;
                    case 7:
                        mermaidPlace1 = 31;
                        break;
                    case 8:
                        mermaidPlace1 = 32;
                        break;
                    default:
                        mermaidPlace1 = 36;
                        break;
                }

                if (randomObilia == 2 && zapiski != 10 && mermaidprevious != 60 && distan.distance > 5650) // максимальное кол-во
                {
                    mermaidPlace2 = 60; // код записки
                }
                else if (randomObilia == 2)
                {
                    switch (sixdom2)
                    {
                        case 1:
                            mermaidPlace2 = 7;
                            break;
                        case 2:
                            mermaidPlace2 = 10;
                            break;
                        case 3:
                            mermaidPlace2 = 48;
                            break;
                        case 4:
                            mermaidPlace2 = 28;
                            break;
                        case 5:
                            mermaidPlace2 = 46;
                            break;
                        case 6:
                            mermaidPlace2 = 35;
                            break;
                        case 7:
                            mermaidPlace2 = 31;
                            break;
                        case 8:
                            mermaidPlace2 = 32;
                            break;
                        default:
                            mermaidPlace2 = 36;
                            break;
                    }
                }
                randomIkornyy = 1; // награда-икра
            }

            else if (other.name == "Rago(Clone)")
            {
                PlayerPrefs.SetFloat("readRago", 1);
                enemySpawner.bRago = true; // личный бул мермена
                randomObilia = Random.Range(1, 3);
                sixdom = Random.Range(1, 7); // 6 вариантов русалок
                sixdom2 = Random.Range(1, 7); // 6 вариантов русалок
                switch (sixdom)
                {
                    case 1:
                        mermaidPlace1 = 7;
                        break;
                    case 2:
                        mermaidPlace1 = 10;
                        break;
                    case 3:
                        mermaidPlace1 = 48;
                        break;
                    case 4:
                        mermaidPlace1 = 47;
                        break;
                    default:
                        mermaidPlace1 = 37;
                        break;
                }

                if (randomObilia == 2 && zapiski != 10 && mermaidprevious != 60 && distan.distance > 5650) // максимальное кол-во
                {
                    mermaidPlace2 = 60; // код записки
                }
                else if (randomObilia == 2)
                {
                    switch (sixdom2)
                    {
                        case 1:
                            mermaidPlace2 = 7;
                            break;
                        case 2:
                            mermaidPlace2 = 10;
                            break;
                        case 3:
                            mermaidPlace2 = 48;
                            break;
                        case 4:
                            mermaidPlace2 = 47;
                            break;
                        default:
                            mermaidPlace2 = 37;
                            break;
                    }
                }
                randomIkornyy = 1; // награда-икра
            }

            else if (other.name == "Ekhir(Clone)")
            {
                PlayerPrefs.SetFloat("readEkhir", 1);
                enemySpawner.bEkhir = true; // личный бул мермена
                randomObilia = Random.Range(1, 3);
                sixdom = Random.Range(1, 6); // 6 вариантов русалок
                sixdom2 = Random.Range(1, 6); // 6 вариантов русалок
                switch (sixdom)
                {
                    case 1:
                        mermaidPlace1 = 7;
                        break;
                    case 2:
                        mermaidPlace1 = 10;
                        break;
                    case 3:
                        mermaidPlace1 = 48;
                        break;
                    default:
                        mermaidPlace1 = 38;
                        break;
                }

                if (randomObilia == 2 && zapiski != 10 && mermaidprevious != 60 && distan.distance > 5650) // максимальное кол-во
                {
                    mermaidPlace2 = 60; // код записки
                }
                else if (randomObilia == 2)
                {
                    switch (sixdom2)
                    {
                        case 1:
                            mermaidPlace2 = 7;
                            break;
                        case 2:
                            mermaidPlace2 = 10;
                            break;
                        case 3:
                            mermaidPlace2 = 48;
                            break;
                        default:
                            mermaidPlace2 = 38;
                            break;
                    }
                }
                randomIkornyy = 1; // награда-икра
            }

            else if (other.name == "Marius(Clone)")
            {
                PlayerPrefs.SetFloat("readMarius", 1);
                enemySpawner.bMarius = true; // личный бул мермена
                randomObilia = Random.Range(1, 3);
                sixdom = Random.Range(1, 7); // 6 вариантов русалок
                sixdom2 = Random.Range(1, 7); // 6 вариантов русалок
                switch (sixdom)
                {
                    case 1:
                        mermaidPlace1 = 7;
                        break;
                    case 2:
                        mermaidPlace1 = 10;
                        break;
                    case 3:
                        mermaidPlace1 = 48;
                        break;
                    case 4:
                        mermaidPlace1 = 46;
                        break;
                    default:
                        mermaidPlace1 = 40;
                        break;
                }

                if (randomObilia == 2 && zapiski != 10 && mermaidprevious != 60 && distan.distance > 5650) // максимальное кол-во
                {
                    mermaidPlace2 = 60; // код записки
                }
                else if (randomObilia == 2)
                {
                    switch (sixdom2)
                    {
                        case 1:
                            mermaidPlace2 = 7;
                            break;
                        case 2:
                            mermaidPlace2 = 10;
                            break;
                        case 3:
                            mermaidPlace2 = 48;
                            break;
                        case 4:
                            mermaidPlace2 = 46;
                            break;
                        default:
                            mermaidPlace2 = 40;
                            break;
                    }
                }
                randomIkornyy = 1; // награда-икра
            }

            else if (other.name == "Cellisee(Clone)")
            {
                PlayerPrefs.SetFloat("readCellisee", 1);
                enemySpawner.bCellisee = true; // личный бул мермена
                randomObilia = Random.Range(1, 3);
                sixdom = Random.Range(1, 12); // 6 вариантов русалок
                sixdom2 = Random.Range(1, 12); // 6 вариантов русалок
                switch (sixdom)
                {
                    case 1:
                        mermaidPlace1 = 7;
                        break;
                    case 2:
                        mermaidPlace1 = 10;
                        break;
                    case 3:
                        mermaidPlace1 = 48;
                        break;
                    case 4:
                        mermaidPlace1 = 14;
                        break;
                    case 5:
                        mermaidPlace1 = 8;
                        break;
                    case 6:
                        mermaidPlace1 = 24;
                        break;
                    case 7:
                        mermaidPlace1 = 21;
                        break;
                    case 8:
                        mermaidPlace1 = 46;
                        break;
                    default:
                        mermaidPlace1 = 41;
                        break;
                }

                if (randomObilia == 2 && zapiski != 10 && mermaidprevious != 60 && distan.distance > 5650) // максимальное кол-во
                {
                    mermaidPlace2 = 60; // код записки
                }
                else if (randomObilia == 2)
                {
                    switch (sixdom2)
                    {
                        case 1:
                            mermaidPlace2 = 7;
                            break;
                        case 2:
                            mermaidPlace2 = 10;
                            break;
                        case 3:
                            mermaidPlace2 = 48;
                            break;
                        case 4:
                            mermaidPlace2 = 14;
                            break;
                        case 5:
                            mermaidPlace2 = 8;
                            break;
                        case 6:
                            mermaidPlace2 = 24;
                            break;
                        case 7:
                            mermaidPlace2 = 21;
                            break;
                        case 8:
                            mermaidPlace2 = 46;
                            break;
                        default:
                            mermaidPlace2 = 41;
                            break;
                    }
                }
                randomIkornyy = 1; // награда-икра
            }

            else if (other.name == "Thanaid(Clone)")
            {
                PlayerPrefs.SetFloat("readThanaid", 1);
                enemySpawner.bThanaid = true; // личный бул мермена
                randomObilia = Random.Range(1, 3);
                sixdom = Random.Range(1, 6); // 6 вариантов русалок
                sixdom2 = Random.Range(1, 6); // 6 вариантов русалок
                switch (sixdom)
                {
                    case 1:
                        mermaidPlace1 = 7;
                        break;
                    case 2:
                        mermaidPlace1 = 10;
                        break;
                    case 3:
                        mermaidPlace1 = 48;
                        break;
                    default:
                        mermaidPlace1 = 42;
                        break;
                }

                if (randomObilia == 2 && zapiski != 10 && mermaidprevious != 60 && distan.distance > 5650) // максимальное кол-во
                {
                    mermaidPlace2 = 60; // код записки
                }
                else if (randomObilia == 2)
                {
                    switch (sixdom2)
                    {
                        case 1:
                            mermaidPlace2 = 7;
                            break;
                        case 2:
                            mermaidPlace2 = 10;
                            break;
                        case 3:
                            mermaidPlace2 = 48;
                            break;
                        default:
                            mermaidPlace2 = 42;
                            break;
                    }
                }
                randomIkornyy = 1; // награда-икра
            }


            else if (other.name == "Khirond(Clone)")
            {
                PlayerPrefs.SetFloat("readKhirond", 1);
                enemySpawner.bKhirond = true; // личный бул мермена
                randomObilia = Random.Range(1, 3);
                sixdom = Random.Range(1, 6); // 6 вариантов русалок
                sixdom2 = Random.Range(1, 6); // 6 вариантов русалок
                switch (sixdom)
                {
                    case 1:
                        mermaidPlace1 = 7;
                        break;
                    case 2:
                        mermaidPlace1 = 10;
                        break;
                    case 3:
                        mermaidPlace1 = 48;
                        break;
                    default:
                        mermaidPlace1 = 44;
                        break;
                }

                if (randomObilia == 2 && zapiski != 10 && mermaidprevious != 60 && distan.distance > 5650) // максимальное кол-во
                {
                    mermaidPlace2 = 60; // код записки
                }
                else if (randomObilia == 2)
                {
                    switch (sixdom2)
                    {
                        case 1:
                            mermaidPlace2 = 7;
                            break;
                        case 2:
                            mermaidPlace2 = 10;
                            break;
                        case 3:
                            mermaidPlace2 = 48;
                            break;
                        default:
                            mermaidPlace2 = 44;
                            break;
                    }
                }
                randomIkornyy = 1; // награда-икра
            }

            else if (other.name == "Demos(Clone)")
            {
                PlayerPrefs.SetFloat("readDemos", 1);
                enemySpawner.bDemos = true; // личный бул мермена
                randomObilia = Random.Range(1, 3);
                sixdom = Random.Range(1, 12); // 6 вариантов русалок
                sixdom2 = Random.Range(1, 12); // 6 вариантов русалок
                switch (sixdom)
                {
                    case 1:
                        mermaidPlace1 = 7;
                        break;
                    case 2:
                        mermaidPlace1 = 10;
                        break;
                    case 3:
                        mermaidPlace1 = 48;
                        break;
                    case 4:
                        mermaidPlace1 = 21;
                        break;
                    case 5:
                        mermaidPlace1 = 24;
                        break;
                    case 6:
                        mermaidPlace1 = 40;
                        break;
                    case 7:
                        mermaidPlace1 = 41;
                        break;
                    default:
                        mermaidPlace1 = 46;
                        break;
                }

                if (randomObilia == 2 && zapiski != 10 && mermaidprevious != 60 && distan.distance > 5650) // максимальное кол-во
                {
                    mermaidPlace2 = 60; // код записки
                }
                else if (randomObilia == 2)
                {
                    switch (sixdom2)
                    {
                        case 1:
                            mermaidPlace2 = 7;
                            break;
                        case 2:
                            mermaidPlace2 = 10;
                            break;
                        case 3:
                            mermaidPlace2 = 48;
                            break;
                        case 4:
                            mermaidPlace2 = 21;
                            break;
                        case 5:
                            mermaidPlace2 = 24;
                            break;
                        case 6:
                            mermaidPlace2 = 40;
                            break;
                        case 7:
                            mermaidPlace2 = 41;
                            break;
                        default:
                            mermaidPlace2 = 46;
                            break;
                    }
                }
                randomIkornyy = 1; // награда-икра
            }

            else if (other.name == "Nerrelid(Clone)")
            {
                PlayerPrefs.SetFloat("readNerrelid", 1);
                enemySpawner.bNerrelid = true; // личный бул мермена
                randomObilia = Random.Range(1, 3);
                sixdom = Random.Range(1, 6); // 6 вариантов русалок
                sixdom2 = Random.Range(1, 6); // 6 вариантов русалок
                switch (sixdom)
                {
                    case 1:
                        mermaidPlace1 = 7;
                        break;
                    case 2:
                        mermaidPlace1 = 10;
                        break;
                    case 3:
                        mermaidPlace1 = 48;
                        break;
                    default:
                        mermaidPlace1 = 47;
                        break;
                }

                if (randomObilia == 2 && zapiski != 10 && mermaidprevious != 60 && distan.distance > 5650) // максимальное кол-во
                {
                    mermaidPlace2 = 60; // код записки
                }
                else if (randomObilia == 2)
                {
                    switch (sixdom2)
                    {
                        case 1:
                            mermaidPlace2 = 7;
                            break;
                        case 2:
                            mermaidPlace2 = 10;
                            break;
                        case 3:
                            mermaidPlace2 = 48;
                            break;
                        default:
                            mermaidPlace2 = 47;
                            break;
                    }
                }
                randomIkornyy = Random.Range(1, 3); // награда-икра
            }

            else if (other.name == "Golor(Clone)")
            {
                PlayerPrefs.SetFloat("readGolor", 1);
                enemySpawner.bGolor = true; // личный бул мермена
                randomObilia = Random.Range(1, 3);
                mermaidPlace1 = Random.Range(1, 48);
                if (mermaidPlace1 == 26 || mermaidPlace1 == 39 || mermaidPlace1 == 43 || mermaidPlace1 == 45)
                {
                    mermaidPlace1 = 48;
                }
                if (randomObilia == 2 && zapiski != 10 && mermaidprevious != 60 && distan.distance > 5650) // максимальное кол-во
                {
                    mermaidPlace2 = 60; // код записки
                }
                else if (randomObilia == 2)
                {
                    mermaidPlace2 = Random.Range(1, 48);
                    if (mermaidPlace2 == 26 || mermaidPlace2 == 39 || mermaidPlace2 == 43 || mermaidPlace2 == 45)
                    {
                        mermaidPlace2 = 48;
                    }
                }
                randomIkornyy = Random.Range(1, 3); // награда-икра
            }

            else if (other.name == "doto") // первая точка финала
            {
                enemySpawner.dot1 = true; // личный бул мермена
                                          // здесь совершенно другие призы

                randomObilia = 2; // заспавнит на 2 место
                mermaidPlace1 = 0; // на 1 никого
                mermaidPlace2 = 100; // это переменная рингвудита

                randomIkornyy = 0; // награда-икра не должна показываться
            }
            else if (other.name == "dotc")
            {
                enemySpawner.dot2 = true;
                randomObilia = 2;
                mermaidPlace1 = 0;
                mermaidPlace2 = 100;
                randomIkornyy = 0;
            }
            else if (other.name == "dott")
            {
                enemySpawner.dot3 = true;
                randomObilia = 2;
                mermaidPlace1 = 0;
                mermaidPlace2 = 100;
                randomIkornyy = 0;
            }

            else if (other.name == "fish")
            {
                PlayerPrefs.SetFloat("readfish", 1);
                enemySpawner.fishbiom = true;
                randomObilia = 1;
                mermaidPlace1 = 0;
                mermaidPlace2 = 0;
                randomIkornyy = Random.Range(40, 60);
            }

            if (other.CompareTag("Merman"))
            {
                startTouch.currentMerman = GameObject.FindWithTag("Merman");
                mermanChitaetsya = true;
                battleMode = true;
                //startTouch.startTouchPosition = Input.GetTouch(0).position;
                PlayerPrefs.Save();
            }
        }
        if (other.name == "Biom2")
        {
            enemySpawner.spawned7 = false;
            enemySpawner.spawned8 = false;
            enemySpawner.spawned9 = false;
            enemySpawner.spawned10 = false;
            enemySpawner.spawned11 = false;
        }
        else if (other.name == "Biom3")
        {
            enemySpawner.spawned12 = false;
            enemySpawner.spawned13 = false;
            enemySpawner.spawned14 = false;

        }
        else if (other.name == "Biom4")
        {
            mermaidprevious = 0;
            enemySpawner.spawned15 = false;
            enemySpawner.spawned16 = false;
            enemySpawner.spawned17 = false;
        }
        else if (other.name == "Biom5")
        {
            mermaidprevious = 0;
        }
    }


}