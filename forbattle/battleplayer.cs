using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class battleplayer : MonoBehaviour
{
    public EnemySpawnerB1 enemyspawner;
    public SkillsController skills;
    public GenController gens;
    public skillsreader skreader;
    public mermenreader mermenreader;
    public Levels leveler;

    // звуки боя
    public AudioSource attak;
    public AudioSource hill;
    public AudioSource lovushka;
    public AudioSource bloksstart;

    // для анимаций боя
    public GameObject udar;
    public GameObject udar2;
    public GameObject udar3;
    // атаки
    public GameObject udarus;
    public GameObject udarus2;
    public GameObject udarus3;
    public GameObject udaruskrug;
    public GameObject udarus2krug;
    public GameObject udarus3krug;
    public GameObject udarusklaw;
    public GameObject udarus2klaw;
    public GameObject udarus3klaw;
    // блоки
    public Color32 normalcolor;
    public Color32 transpcolor;
    public Color32 whitetranspcolor;

    public float shkalaUzhasaGG;
    public float shkalaUzhasaVraga;

    public bool playingMode = false;
    public battlefinal playEnded;
    public Slot1 slotsgg;
    public Slo1 slotsmerman;
    [SerializeField] private float pervohod;
    public bool hpustanovleny;

    public GameObject chitalkaTarget1;
    public GameObject chitalkaTarget2;
    public GameObject chitalkaTarget3;
    public float playingSkill;

    // последовательность ходов
    public bool slot1GGpohodil;
    public bool slot2GGpohodil;
    public bool slot3GGpohodil;
    public bool slot4GGpohodil;
    public bool slot5GGpohodil;
    public bool slot6GGpohodil;
    public bool slot7GGpohodil;
    public bool slot8GGpohodil;
    public bool slot9GGpohodil;
    public bool slot1Vragpohodil;
    public bool slot2Vragpohodil;
    public bool slot3Vragpohodil;
    public bool slot4Vragpohodil;
    public bool slot5Vragpohodil;
    public bool slot6Vragpohodil;
    public bool slot7Vragpohodil;
    public bool slot8Vragpohodil;
    public bool slot9Vragpohodil;

    // защиты
    public GameObject hodantiBlok;
    public GameObject hodantiBlok2;
    public GameObject slot1GGshield;
    public GameObject slot2GGshield;
    public GameObject slot3GGshield;
    public GameObject slot4GGshield;
    public GameObject slot5GGshield;
    public GameObject slot6GGshield;
    public GameObject slot7GGshield;
    public GameObject slot8GGshield;
    public GameObject slot9GGshield;
    public GameObject slot1Vragshield;
    public GameObject slot2Vragshield;
    public GameObject slot3Vragshield;
    public GameObject slot4Vragshield;
    public GameObject slot5Vragshield;
    public GameObject slot6Vragshield;
    public GameObject slot7Vragshield;
    public GameObject slot8Vragshield;
    public GameObject slot9Vragshield;

    // блоки слотов
    public GameObject hodBlok;
    public GameObject hodBlok2;
    public GameObject slot1GGbloch;
    public GameObject slot2GGbloch;
    public GameObject slot3GGbloch;
    public GameObject slot4GGbloch;
    public GameObject slot5GGbloch;
    public GameObject slot6GGbloch;
    public GameObject slot7GGbloch;
    public GameObject slot8GGbloch;
    public GameObject slot9GGbloch;
    public GameObject slot1Vragbloch;
    public GameObject slot2Vragbloch;
    public GameObject slot3Vragbloch;
    public GameObject slot4Vragbloch;
    public GameObject slot5Vragbloch;
    public GameObject slot6Vragbloch;
    public GameObject slot7Vragbloch;
    public GameObject slot8Vragbloch;
    public GameObject slot9Vragbloch;

    // подсветки слотов, которые ходят
    public GameObject hodSvet;
    public GameObject hodSvet2;
    public GameObject slot1GGsvet;
    public GameObject slot2GGsvet;
    public GameObject slot3GGsvet;
    public GameObject slot4GGsvet;
    public GameObject slot5GGsvet;
    public GameObject slot6GGsvet;
    public GameObject slot7GGsvet;
    public GameObject slot8GGsvet;
    public GameObject slot9GGsvet;
    public GameObject slot1Vragsvet;
    public GameObject slot2Vragsvet;
    public GameObject slot3Vragsvet;
    public GameObject slot4Vragsvet;
    public GameObject slot5Vragsvet;
    public GameObject slot6Vragsvet;
    public GameObject slot7Vragsvet;
    public GameObject slot8Vragsvet;
    public GameObject slot9Vragsvet;

    // затухания слотов
    public GameObject hoddamag;
    public GameObject hoddamag2;
    public GameObject slot1GGdamag;
    public GameObject slot2GGdamag;
    public GameObject slot3GGdamag;
    public GameObject slot4GGdamag;
    public GameObject slot5GGdamag;
    public GameObject slot6GGdamag;
    public GameObject slot7GGdamag;
    public GameObject slot8GGdamag;
    public GameObject slot9GGdamag;
    public GameObject slot1Vragdamag;
    public GameObject slot2Vragdamag;
    public GameObject slot3Vragdamag;
    public GameObject slot4Vragdamag;
    public GameObject slot5Vragdamag;
    public GameObject slot6Vragdamag;
    public GameObject slot7Vragdamag;
    public GameObject slot8Vragdamag;
    public GameObject slot9Vragdamag;

    // хиллы слотов
    public GameObject hodhilli;
    public GameObject hodhilli2;
    public GameObject slot1GGhilli;
    public GameObject slot2GGhilli;
    public GameObject slot3GGhilli;
    public GameObject slot4GGhilli;
    public GameObject slot5GGhilli;
    public GameObject slot6GGhilli;
    public GameObject slot7GGhilli;
    public GameObject slot8GGhilli;
    public GameObject slot9GGhilli;
    public GameObject slot1Vraghilli;
    public GameObject slot2Vraghilli;
    public GameObject slot3Vraghilli;
    public GameObject slot4Vraghilli;
    public GameObject slot5Vraghilli;
    public GameObject slot6Vraghilli;
    public GameObject slot7Vraghilli;
    public GameObject slot8Vraghilli;
    public GameObject slot9Vraghilli;

    // токсины
    public GameObject hodtoxins;
    public GameObject hodtoxins2;
    public GameObject slot1GGtoxins;
    public GameObject slot2GGtoxins;
    public GameObject slot3GGtoxins;
    public GameObject slot4GGtoxins;
    public GameObject slot5GGtoxins;
    public GameObject slot6GGtoxins;
    public GameObject slot7GGtoxins;
    public GameObject slot8GGtoxins;
    public GameObject slot9GGtoxins;
    public GameObject slot1Vragtoxins;
    public GameObject slot2Vragtoxins;
    public GameObject slot3Vragtoxins;
    public GameObject slot4Vragtoxins;
    public GameObject slot5Vragtoxins;
    public GameObject slot6Vragtoxins;
    public GameObject slot7Vragtoxins;
    public GameObject slot8Vragtoxins;
    public GameObject slot9Vragtoxins;

    public float timerHoda;

    private float sravnslot1gg;
    private float sravnslot2gg;
    private float sravnslot3gg;
    private float sravnslot4gg;
    private float sravnslot5gg;
    private float sravnslot6gg;
    private float sravnslot7gg;
    private float sravnslot8gg;
    private float sravnslot9gg;
    private float sravnslot1vraga;
    private float sravnslot2vraga;
    private float sravnslot3vraga;
    private float sravnslot4vraga;
    private float sravnslot5vraga;
    private float sravnslot6vraga;
    private float sravnslot7vraga;
    private float sravnslot8vraga;
    private float sravnslot9vraga;

    public bool hilloid;

    [SerializeField] private bool animation_bol;
    private Vector3 sizeNormie;
    private Vector3 sizeSmol;
    private Vector3 sizeverySmol;
    private Vector3 sizeBig;
    [SerializeField] private Vector3 scaleChange;

    // для мимикрии Теуза
    public float fortheus1;
    public float fortheus2;
    public float fortheus3;
    public float fortheus4;
    public float fortheus5;
    public float fortheus6;
    public float fortheus7;
    public float fortheus8;
    public float fortheus9;

    public float otrava1;
    public float otrava2;
    public float otrava3;
    public float otrava4;
    public float otrava5;
    public float otrava6;
    public float otrava7;
    public float otrava8;
    public float otrava9;
    public float otrava10;
    public float otrava11;
    public float otrava12;
    public float otrava13;
    public float otrava14;
    public float otrava15;
    public float otrava16;
    public float otrava17;
    public float otrava18;

    void Start()
    {
        hodantiBlok.SetActive(false);
        hodantiBlok2.SetActive(false);
        slot1GGshield.SetActive(false);
        slot2GGshield.SetActive(false);
        slot3GGshield.SetActive(false);
        slot4GGshield.SetActive(false);
        slot5GGshield.SetActive(false);
        slot6GGshield.SetActive(false);
        slot7GGshield.SetActive(false);
        slot8GGshield.SetActive(false);
        slot9GGshield.SetActive(false);
        slot1Vragshield.SetActive(false);
        slot2Vragshield.SetActive(false);
        slot3Vragshield.SetActive(false);
        slot4Vragshield.SetActive(false);
        slot5Vragshield.SetActive(false);
        slot6Vragshield.SetActive(false);
        slot7Vragshield.SetActive(false);
        slot8Vragshield.SetActive(false);
        slot9Vragshield.SetActive(false);
        shkalaUzhasaGG = 0;
        shkalaUzhasaVraga = 0;
        hodSvet.SetActive(false);
        hodSvet2.SetActive(false);
        playingMode = false;
        hpustanovleny = false;
        slot1GGpohodil = false;
        slot2GGpohodil = false;
        slot3GGpohodil = false;
        slot4GGpohodil = false;
        slot5GGpohodil = false;
        slot6GGpohodil = false;
        slot7GGpohodil = false;
        slot8GGpohodil = false;
        slot9GGpohodil = false;
        slot1Vragpohodil = false;
        slot2Vragpohodil = false;
        slot3Vragpohodil = false;
        slot4Vragpohodil = false;
        slot5Vragpohodil = false;
        slot6Vragpohodil = false;
        slot7Vragpohodil = false;
        slot8Vragpohodil = false;
        slot9Vragpohodil = false;
        slot1GGbloch.SetActive(false);
        slot2GGbloch.SetActive(false);
        slot3GGbloch.SetActive(false);
        slot4GGbloch.SetActive(false);
        slot5GGbloch.SetActive(false);
        slot6GGbloch.SetActive(false);
        slot7GGbloch.SetActive(false);
        slot8GGbloch.SetActive(false);
        slot9GGbloch.SetActive(false);
        slot1Vragbloch.SetActive(false);
        slot2Vragbloch.SetActive(false);
        slot3Vragbloch.SetActive(false);
        slot4Vragbloch.SetActive(false);
        slot5Vragbloch.SetActive(false);
        slot6Vragbloch.SetActive(false);
        slot7Vragbloch.SetActive(false);
        slot8Vragbloch.SetActive(false);
        slot9Vragbloch.SetActive(false);
        hoddamag.SetActive(false);
        hoddamag2.SetActive(false);
        slot1GGdamag.SetActive(false);
        slot2GGdamag.SetActive(false);
        slot3GGdamag.SetActive(false);
        slot4GGdamag.SetActive(false);
        slot5GGdamag.SetActive(false);
        slot6GGdamag.SetActive(false);
        slot7GGdamag.SetActive(false);
        slot8GGdamag.SetActive(false);
        slot9GGdamag.SetActive(false);
        slot1Vragdamag.SetActive(false);
        slot2Vragdamag.SetActive(false);
        slot3Vragdamag.SetActive(false);
        slot4Vragdamag.SetActive(false);
        slot5Vragdamag.SetActive(false);
        slot6Vragdamag.SetActive(false);
        slot7Vragdamag.SetActive(false);
        slot8Vragdamag.SetActive(false);
        slot9Vragdamag.SetActive(false);
        hodtoxins.SetActive(false);
        hodtoxins2.SetActive(false);
        slot1GGtoxins.SetActive(false);
        slot2GGtoxins.SetActive(false);
        slot3GGtoxins.SetActive(false);
        slot4GGtoxins.SetActive(false);
        slot5GGtoxins.SetActive(false);
        slot6GGtoxins.SetActive(false);
        slot7GGtoxins.SetActive(false);
        slot8GGtoxins.SetActive(false);
        slot9GGtoxins.SetActive(false);
        slot1Vragtoxins.SetActive(false);
        slot2Vragtoxins.SetActive(false);
        slot3Vragtoxins.SetActive(false);
        slot4Vragtoxins.SetActive(false);
        slot5Vragtoxins.SetActive(false);
        slot6Vragtoxins.SetActive(false);
        slot7Vragtoxins.SetActive(false);
        slot8Vragtoxins.SetActive(false);
        slot9Vragtoxins.SetActive(false);
        timerHoda = 0;
        hodhilli.SetActive(false);
        hodhilli2.SetActive(false);
        slot1GGhilli.SetActive(false);
        slot2GGhilli.SetActive(false);
        slot3GGhilli.SetActive(false);
        slot4GGhilli.SetActive(false);
        slot5GGhilli.SetActive(false);
        slot6GGhilli.SetActive(false);
        slot7GGhilli.SetActive(false);
        slot8GGhilli.SetActive(false);
        slot9GGhilli.SetActive(false);
        slot1Vraghilli.SetActive(false);
        slot2Vraghilli.SetActive(false);
        slot3Vraghilli.SetActive(false);
        slot4Vraghilli.SetActive(false);
        slot5Vraghilli.SetActive(false);
        slot6Vraghilli.SetActive(false);
        slot7Vraghilli.SetActive(false);
        slot8Vraghilli.SetActive(false);
        slot9Vraghilli.SetActive(false);

        udar.SetActive(false);
        udar3.SetActive(false);
        udar2.SetActive(false);
        udarus.SetActive(false);
        udarus3.SetActive(false);
        udarus2.SetActive(false);

        scaleChange = new Vector3(0.1f, 0.1f, 0f);
        sizeNormie = new Vector3(1f, 1f, 0f);
        sizeSmol = new Vector3(0.3f, 0.3f, 0f);
        sizeverySmol = new Vector3(0f, 0f, 0f);

        sizeBig = new Vector3(1.7f, 1.7f, 0f);

        udaruskrug.SetActive(true);
        udarusklaw.SetActive(false);
        udarus2krug.SetActive(true);
        udarus2klaw.SetActive(false);
        udarus3krug.SetActive(true);
        udarus3klaw.SetActive(false);
        foreach (Transform child in hodBlok.transform)
        {
            child.gameObject.GetComponent<Image>().color = transpcolor;
        }
        foreach (Transform child in hodBlok2.transform)
        {
            child.gameObject.GetComponent<Image>().color = transpcolor;
        }
        foreach (Transform child in hodantiBlok.transform)
        {
            child.gameObject.GetComponent<Image>().color = transpcolor;
            child.gameObject.transform.localScale = new Vector3(0f, 0f, 0f);
        }
        foreach (Transform child in hodantiBlok2.transform)
        {
            child.gameObject.GetComponent<Image>().color = transpcolor;
            child.gameObject.transform.localScale = new Vector3(0f, 0f, 0f);
        }
    }


    void Update()
    {
        if (playingMode == true)
        {
            if (animation_bol) // режим проверки движения
            {
                if (leveler.animateo == 2)
                {
                    // если вообще ничего нет
                    if (udar.activeSelf == false && udar2.activeSelf == false && udar3.activeSelf == false && udarus.activeSelf == false && udarus2.activeSelf == false && udarus3.activeSelf == false)
                    {
                        chitalkaBattle();
                    }
                    else
                    {
                        // это атаки, движение + вращение
                        if (udarus.activeSelf == true)
                        {
                            
                            if (udarusklaw.activeSelf == false && Vector3.Distance(udarusklaw.transform.position, chitalkaTarget1.transform.position) > 10f) // раскрутка
                            {
                                if (udaruskrug.activeSelf == true)
                                {
                                    udaruskrug.transform.localEulerAngles -= new Vector3(0f, 0f, 450f);
                                    udaruskrug.transform.localScale = Vector3.Lerp(udaruskrug.transform.localScale, sizeBig, 0.25f);
                                }
                                if (udaruskrug.transform.localScale.x > 1.6f)
                                {
                                    udaruskrug.SetActive(false);
                                    udaruskrug.transform.position = chitalkaTarget1.transform.position;
                                    // поки влияет на ось зет udarusklaw.transform.rotation = Quaternion.FromToRotation(udarusklaw.transform.right, chitalkaTarget1.transform.position - udarusklaw.transform.position);
                                    udarusklaw.SetActive(true);
                                }
                            }
                            else // закрутка
                            {
                                udarusklaw.transform.position = Vector2.MoveTowards(udarusklaw.transform.position, chitalkaTarget1.transform.position, 70f);
                                if (Vector3.Distance(udarusklaw.transform.position, chitalkaTarget1.transform.position) < 10f)
                                {
                                    udarusklaw.SetActive(false);
                                    udaruskrug.SetActive(true);
                                    udaruskrug.transform.localEulerAngles -= new Vector3(0f, 0f, 450f);
                                    udaruskrug.transform.localScale = Vector3.Lerp(udaruskrug.transform.localScale, sizeverySmol, 0.3f);
                                }

                            }
                            // потом идентичный кружок прокрутится на мишени и уменьшится, и тогда конец анимации?


                        }
                        if (udarus2.activeSelf == true)
                        {
                            if (udarus2klaw.activeSelf == false && Vector3.Distance(udarus2klaw.transform.position, chitalkaTarget2.transform.position) > 10f) // раскрутка
                            {
                                if (udarus2krug.activeSelf == true)
                                {
                                    udarus2krug.transform.localEulerAngles -= new Vector3(0f, 0f, 450f);
                                    udarus2krug.transform.localScale = Vector3.Lerp(udarus2krug.transform.localScale, sizeBig, 0.25f);
                                }
                                if (udarus2krug.transform.localScale.x > 1.6f)
                                {
                                    udarus2krug.SetActive(false);
                                    udarus2krug.transform.position = chitalkaTarget2.transform.position;
                                    // поки влияет на ось зет udarus2klaw.transform.rotation = Quaternion.FromToRotation(udarus2klaw.transform.right, chitalkaTarget1.transform.position - udarus2klaw.transform.position);
                                    udarus2klaw.SetActive(true);
                                }
                            }
                            else // закрутка
                            {
                                udarus2klaw.transform.position = Vector2.MoveTowards(udarus2klaw.transform.position, chitalkaTarget2.transform.position, 70f);
                                if (Vector3.Distance(udarus2klaw.transform.position, chitalkaTarget2.transform.position) < 10f)
                                {
                                    udarus2klaw.SetActive(false);
                                    udarus2krug.SetActive(true);
                                    udarus2krug.transform.localEulerAngles -= new Vector3(0f, 0f, 450f);
                                    udarus2krug.transform.localScale = Vector3.Lerp(udarus2krug.transform.localScale, sizeverySmol, 0.3f);
                                }

                            }
                        }
                        if (udarus3.activeSelf == true)
                        {
                            if (udarus3klaw.activeSelf == false && Vector3.Distance(udarus3klaw.transform.position, chitalkaTarget3.transform.position) > 10f) // раскрутка
                            {
                                if (udarus3krug.activeSelf == true)
                                {
                                    udarus3krug.transform.localEulerAngles -= new Vector3(0f, 0f, 450f);
                                    udarus3krug.transform.localScale = Vector3.Lerp(udarus3krug.transform.localScale, sizeBig, 0.25f);
                                }
                                if (udarus3krug.transform.localScale.x > 1.6f)
                                {
                                    udarus3krug.SetActive(false);
                                    udarus3krug.transform.position = chitalkaTarget3.transform.position;
                                    // поки влияет на ось зет udarus3klaw.transform.rotation = Quaternion.FromToRotation(udarus3klaw.transform.right, chitalkaTarget1.transform.position - udarus3klaw.transform.position);
                                    udarus3klaw.SetActive(true);
                                }
                            }
                            else // закрутка
                            {
                                udarus3klaw.transform.position = Vector2.MoveTowards(udarus3klaw.transform.position, chitalkaTarget3.transform.position, 70f);
                                if (Vector3.Distance(udarus3klaw.transform.position, chitalkaTarget3.transform.position) < 10f)
                                {
                                    udarus3klaw.SetActive(false);
                                    udarus3krug.SetActive(true);
                                    udarus3krug.transform.localEulerAngles -= new Vector3(0f, 0f, 450f);
                                    udarus3krug.transform.localScale = Vector3.Lerp(udarus3krug.transform.localScale, sizeverySmol, 0.3f);
                                }

                            }
                        }



                        // это только хиллы, чёрные для обоих сторон, просто движение
                        if (udar.activeSelf == true)
                        {

                            udar.transform.position = Vector2.MoveTowards(udar.transform.position, chitalkaTarget1.transform.position, 25f); // двигается к первой мишени
                            if (Vector3.Distance(udar.transform.position, chitalkaTarget1.transform.position) < 100f) // если до мишени немного, приходит в норму
                            {
                                udar.transform.localScale = Vector3.Lerp(udar.transform.localScale, sizeNormie, 0.3f);
                            }
                            else // уменьшается
                            {
                                udar.transform.localScale = Vector3.Lerp(udar.transform.localScale, sizeSmol, 0.3f);
                            }

                        }
                        if (udar2.activeSelf == true)
                        {
                            udar2.transform.position = Vector2.MoveTowards(udar2.transform.position, chitalkaTarget2.transform.position, 25f); // двигается к первой мишени
                            if (Vector3.Distance(udar2.transform.position, chitalkaTarget2.transform.position) < 100f) // если до мишени немного, приходит в норму
                            {
                                udar2.transform.localScale = Vector3.Lerp(udar2.transform.localScale, sizeNormie, 0.3f);
                            }
                            else // уменьшается
                            {
                                udar2.transform.localScale = Vector3.Lerp(udar2.transform.localScale, sizeSmol, 0.3f);
                            }
                        }
                        if (udar3.activeSelf == true)
                        {
                            udar3.transform.position = Vector2.MoveTowards(udar3.transform.position, chitalkaTarget3.transform.position, 25f); // двигается к первой мишени
                            if (Vector3.Distance(udar3.transform.position, chitalkaTarget3.transform.position) < 100f) // если до мишени немного, приходит в норму
                            {
                                udar3.transform.localScale = Vector3.Lerp(udar3.transform.localScale, sizeNormie, 0.3f);
                            }
                            else // уменьшается
                            {
                                udar3.transform.localScale = Vector3.Lerp(udar3.transform.localScale, sizeSmol, 0.3f);
                            }
                        }



                        // это отключение движения
                        if (udarus.activeSelf == true && udaruskrug.transform.localScale.x < 0.2f && Vector3.Distance(udarusklaw.transform.position, chitalkaTarget1.transform.position) < 10f && udarus2.activeSelf == false && udarus3.activeSelf == false)
                        {
                            udarus.transform.localScale = sizeNormie;
                            udarus.SetActive(false);
                            udaruskrug.SetActive(true);
                            udarusklaw.SetActive(false);
                            udaruskrug.transform.localScale = sizeverySmol;
                            udarusklaw.transform.localPosition = new Vector3(0f, 0f, 0f);
                            udaruskrug.transform.localPosition = new Vector3(0f, 0f, 0f);
                            udarus2.transform.localScale = sizeNormie;
                            udarus2.SetActive(false);
                            udarus2krug.SetActive(true);
                            udarus2klaw.SetActive(false);
                            udarus2krug.transform.localScale = sizeverySmol;
                            udarus2klaw.transform.localPosition = new Vector3(0f, 0f, 0f);
                            udarus2krug.transform.localPosition = new Vector3(0f, 0f, 0f);
                            udarus3.transform.localScale = sizeNormie;
                            udarus3.SetActive(false);
                            udarus3krug.SetActive(true);
                            udarus3klaw.SetActive(false);
                            udarus3krug.transform.localScale = sizeverySmol;
                            udarus3klaw.transform.localPosition = new Vector3(0f, 0f, 0f);
                            udarus3krug.transform.localPosition = new Vector3(0f, 0f, 0f);
                            // проверяем, не осталось ли ударусов
                            if (udar.activeSelf == false && udar2.activeSelf == false && udar3.activeSelf == false)
                            {
                                chitalkaBattle();
                            }
                        }
                        // если два хилла двигается
                        if (udarus.activeSelf == true && udarus2.activeSelf == true && udaruskrug.transform.localScale.x < 0.2f && Vector3.Distance(udarusklaw.transform.position, chitalkaTarget1.transform.position) < 10f && udarus2krug.transform.localScale.x < 0.2f && Vector3.Distance(udarus2klaw.transform.position, chitalkaTarget2.transform.position) < 10f && udarus3.activeSelf == false)
                        {
                            udarus.transform.localScale = sizeNormie;
                            udarus.SetActive(false);
                            udarus2.SetActive(false);
                            udaruskrug.SetActive(true);
                            udarusklaw.SetActive(false);
                            udaruskrug.transform.localScale = sizeverySmol;
                            udarusklaw.transform.localPosition = new Vector3(0f, 0f, 0f);
                            udaruskrug.transform.localPosition = new Vector3(0f, 0f, 0f);
                            udarus2.transform.localScale = sizeNormie;
                            udarus2.SetActive(false);
                            udarus2krug.SetActive(true);
                            udarus2klaw.SetActive(false);
                            udarus2krug.transform.localScale = sizeverySmol;
                            udarus2klaw.transform.localPosition = new Vector3(0f, 0f, 0f);
                            udarus2krug.transform.localPosition = new Vector3(0f, 0f, 0f);
                            udarus3.transform.localScale = sizeNormie;
                            udarus3.SetActive(false);
                            udarus3krug.SetActive(true);
                            udarus3klaw.SetActive(false);
                            udarus3krug.transform.localScale = sizeverySmol;
                            udarus3klaw.transform.localPosition = new Vector3(0f, 0f, 0f);
                            udarus3krug.transform.localPosition = new Vector3(0f, 0f, 0f);
                            if (udar.activeSelf == false && udar2.activeSelf == false && udar3.activeSelf == false)
                            {
                                chitalkaBattle();
                            }
                        }
                        // если все хиллы двигаются
                        if (udarus.activeSelf == true && udarus2.activeSelf == true && udarus3.activeSelf == true && udaruskrug.transform.localScale.x < 0.2f && Vector3.Distance(udarusklaw.transform.position, chitalkaTarget1.transform.position) < 10f && udarus2krug.transform.localScale.x < 0.2f && Vector3.Distance(udarus2klaw.transform.position, chitalkaTarget2.transform.position) < 10f && udarus3krug.transform.localScale.x < 0.2f && Vector3.Distance(udarus3klaw.transform.position, chitalkaTarget3.transform.position) < 10f)
                        {
                            udarus.transform.localScale = sizeNormie;
                            udarus.SetActive(false);
                            udarus2.SetActive(false);
                            udarus3.SetActive(false);
                            udaruskrug.SetActive(true);
                            udarusklaw.SetActive(false);
                            udaruskrug.transform.localScale = sizeverySmol;
                            udarusklaw.transform.localPosition = new Vector3(0f, 0f, 0f);
                            udaruskrug.transform.localPosition = new Vector3(0f, 0f, 0f);
                            udarus2.transform.localScale = sizeNormie;
                            udarus2.SetActive(false);
                            udarus2krug.SetActive(true);
                            udarus2klaw.SetActive(false);
                            udarus2krug.transform.localScale = sizeverySmol;
                            udarus2klaw.transform.localPosition = new Vector3(0f, 0f, 0f);
                            udarus2krug.transform.localPosition = new Vector3(0f, 0f, 0f);
                            udarus3.transform.localScale = sizeNormie;
                            udarus3.SetActive(false);
                            udarus3krug.SetActive(true);
                            udarus3klaw.SetActive(false);
                            udarus3krug.transform.localScale = sizeverySmol;
                            udarus3klaw.transform.localPosition = new Vector3(0f, 0f, 0f);
                            udarus3krug.transform.localPosition = new Vector3(0f, 0f, 0f);
                            if (udar.activeSelf == false && udar2.activeSelf == false && udar3.activeSelf == false)
                            {
                                chitalkaBattle();
                            }
                        }

                        // если только один хилл двигается
                        if (udar.activeSelf == true && Vector3.Distance(udar.transform.position, chitalkaTarget1.transform.position) < 10f && udar2.activeSelf == false && udar3.activeSelf == false)
                        {
                            udar.transform.localScale = sizeNormie;
                            udar.SetActive(false);
                            // проверяем, не осталось ли ударусов
                            if (udarus.activeSelf == false && udarus2.activeSelf == false && udarus3.activeSelf == false)
                            {
                                chitalkaBattle();
                            }
                            hilloid = true;
                        }
                        // если два хилла двигается
                        if (udar.activeSelf == true && udar2.activeSelf == true && Vector3.Distance(udar.transform.position, chitalkaTarget1.transform.position) < 10f && Vector3.Distance(udar2.transform.position, chitalkaTarget2.transform.position) < 10f && udar3.activeSelf == false)
                        {
                            udar.transform.localScale = sizeNormie;
                            udar.SetActive(false);
                            udar2.SetActive(false);
                            if (udarus.activeSelf == false && udarus2.activeSelf == false && udarus3.activeSelf == false)
                            {
                                chitalkaBattle();
                            }
                            hilloid = true;
                        }
                        // если все хиллы двигаются
                        if (udar.activeSelf == true && udar2.activeSelf == true && udar3.activeSelf == true && Vector3.Distance(udar.transform.position, chitalkaTarget1.transform.position) < 10f && Vector3.Distance(udar2.transform.position, chitalkaTarget2.transform.position) < 10f && Vector3.Distance(udar3.transform.position, chitalkaTarget3.transform.position) < 10f)
                        {
                            udar.transform.localScale = sizeNormie;
                            udar.SetActive(false);
                            udar2.SetActive(false);
                            udar3.SetActive(false);
                            if (udarus.activeSelf == false && udarus2.activeSelf == false && udarus3.activeSelf == false)
                            {
                                chitalkaBattle();
                            }
                            hilloid = true;
                        }
                        if (hilloid)
                        {
                            hilloid = false;
                            hill.Play(0);
                        }
                    }
                }

            }

            if (hpustanovleny == false && playEnded.resultMode == false)
            {

                skreader.SlotZapolnitel(); // лишний раз проверяем заполненность
                // bloksstart.Play(0);
                shkalaUzhasaGG = 0;
                shkalaUzhasaVraga = 0;
                slot1GGpohodil = false;
                slot2GGpohodil = false;
                slot3GGpohodil = false;
                slot4GGpohodil = false;
                slot5GGpohodil = false;
                slot6GGpohodil = false;
                slot7GGpohodil = false;
                slot8GGpohodil = false;
                slot9GGpohodil = false;
                slot1Vragpohodil = false;
                slot2Vragpohodil = false;
                slot3Vragpohodil = false;
                slot4Vragpohodil = false;
                slot5Vragpohodil = false;
                slot6Vragpohodil = false;
                slot7Vragpohodil = false;
                slot8Vragpohodil = false;
                slot9Vragpohodil = false;

                otrava1 = 0;
                otrava2 = 0;
                otrava3 = 0;
                otrava4 = 0;
                otrava5 = 0;
                otrava6 = 0;
                otrava7 = 0;
                otrava8 = 0;
                otrava9 = 0;
                otrava10 = 0;
                otrava11 = 0;
                otrava12 = 0;
                otrava13 = 0;
                otrava14 = 0;
                otrava15 = 0;
                otrava16 = 0;
                otrava17 = 0;
                otrava18 = 0;

                // здесь читаются хп выставленных слотов до начала месива
                if (skreader.slot1skill != 0)
                {
                    slotsgg.slot1Hp = 1;
                    fortheus1 = skreader.slot1skill;
                }
                else
                {
                    slotsgg.slot1Hp = 0;
                    fortheus1 = 0f;
                }
                if (skreader.slot2skill != 0)
                {
                    slotsgg.slot2Hp = 1;
                    fortheus2 = skreader.slot2skill;
                }
                else
                {
                    slotsgg.slot2Hp = 0;
                    fortheus2 = 0f;
                }
                if (skreader.slot3skill != 0)
                {
                    slotsgg.slot3Hp = 1;
                    fortheus3 = skreader.slot3skill;
                }
                else
                {
                    slotsgg.slot3Hp = 0;
                    fortheus3 = 0f;
                }
                if (skreader.slot4skill != 0)
                {
                    slotsgg.slot4Hp = 1;
                    fortheus4 = skreader.slot4skill;
                }
                else
                {
                    slotsgg.slot4Hp = 0;
                    fortheus4 = 0f;
                }
                if (skreader.slot5skill != 0)
                {
                    slotsgg.slot5Hp = 1;
                    fortheus5 = skreader.slot5skill;
                }
                else
                {
                    slotsgg.slot5Hp = 0;
                    fortheus5 = 0f;
                }
                if (skreader.slot6skill != 0)
                {
                    slotsgg.slot6Hp = 1;
                    fortheus6 = skreader.slot6skill;
                }
                else
                {
                    slotsgg.slot6Hp = 0;
                    fortheus6 = 0f;
                }
                if (skreader.slot7skill != 0)
                {
                    slotsgg.slot7Hp = 1;
                    fortheus7 = skreader.slot7skill;
                }
                else
                {
                    slotsgg.slot7Hp = 0;
                    fortheus7 = 0f;
                }
                if (skreader.slot8skill != 0)
                {
                    slotsgg.slot8Hp = 1;
                    fortheus8 = skreader.slot8skill;
                }
                else
                {
                    slotsgg.slot8Hp = 0;
                    fortheus8 = 0f;
                }
                if (skreader.slot9skill != 0)
                {
                    slotsgg.slot9Hp = 1;
                    fortheus9 = skreader.slot9skill;
                }
                else
                {
                    slotsgg.slot9Hp = 0;
                    fortheus9 = skreader.slot9skill;
                }
                if (skreader.slot1skillVraga != 0)
                {
                    slotsmerman.slo1Hp = 1;
                    if (enemyspawner.fishbiom)
                    {
                        slotsmerman.slo1Hp = 2;
                    }
                }
                else
                {
                    slotsmerman.slo1Hp = 0;
                }
                if (skreader.slot2skillVraga != 0)
                {
                    slotsmerman.slo2Hp = 1;
                    if (enemyspawner.fishbiom)
                    {
                        slotsmerman.slo2Hp = 2;
                    }
                }
                else
                {
                    slotsmerman.slo2Hp = 0;
                }
                if (skreader.slot3skillVraga != 0)
                {
                    slotsmerman.slo3Hp = 1;
                    if (enemyspawner.fishbiom)
                    {
                        slotsmerman.slo3Hp = 2;
                    }
                }
                else
                {
                    slotsmerman.slo3Hp = 0;
                }
                if (skreader.slot4skillVraga != 0)
                {
                    slotsmerman.slo4Hp = 1;
                    if (enemyspawner.fishbiom)
                    {
                        slotsmerman.slo4Hp = 2;
                    }
                }
                else
                {
                    slotsmerman.slo4Hp = 0;
                }
                if (skreader.slot5skillVraga != 0)
                {
                    slotsmerman.slo5Hp = 1;
                    if (enemyspawner.fishbiom)
                    {
                        slotsmerman.slo5Hp = 2;
                    }
                }
                else
                {
                    slotsmerman.slo5Hp = 0;
                }
                if (skreader.slot6skillVraga != 0)
                {
                    slotsmerman.slo6Hp = 1;
                    if (enemyspawner.fishbiom)
                    {
                        slotsmerman.slo6Hp = 2;
                    }
                }
                else
                {
                    slotsmerman.slo6Hp = 0;
                }
                if (skreader.slot7skillVraga != 0)
                {
                    slotsmerman.slo7Hp = 1;
                    if (enemyspawner.fishbiom)
                    {
                        slotsmerman.slo7Hp = 2;
                    }
                }
                else
                {
                    slotsmerman.slo7Hp = 0;
                }
                if (skreader.slot8skillVraga != 0)
                {
                    slotsmerman.slo8Hp = 1;
                    if (enemyspawner.fishbiom)
                    {
                        slotsmerman.slo8Hp = 2;
                    }
                }
                else
                {
                    slotsmerman.slo8Hp = 0;
                }
                if (skreader.slot9skillVraga != 0)
                {
                    slotsmerman.slo9Hp = 1;
                    if (enemyspawner.fishbiom)
                    {
                        slotsmerman.slo9Hp = 2;
                    }
                }
                else
                {
                    slotsmerman.slo9Hp = 0;
                }
                sravnslot1gg = slotsgg.slot1Hp;
                sravnslot2gg = slotsgg.slot2Hp;
                sravnslot3gg = slotsgg.slot3Hp;
                sravnslot4gg = slotsgg.slot4Hp;
                sravnslot5gg = slotsgg.slot5Hp;
                sravnslot6gg = slotsgg.slot6Hp;
                sravnslot7gg = slotsgg.slot7Hp;
                sravnslot8gg = slotsgg.slot8Hp;
                sravnslot9gg = slotsgg.slot9Hp;
                sravnslot1vraga = slotsmerman.slo1Hp;
                sravnslot2vraga = slotsmerman.slo2Hp;
                sravnslot3vraga = slotsmerman.slo3Hp;
                sravnslot4vraga = slotsmerman.slo4Hp;
                sravnslot5vraga = slotsmerman.slo5Hp;
                sravnslot6vraga = slotsmerman.slo6Hp;
                sravnslot7vraga = slotsmerman.slo7Hp;
                sravnslot8vraga = slotsmerman.slo8Hp;
                sravnslot9vraga = slotsmerman.slo9Hp;



                // Здесь опеределяется, кто первый ходит. 1 - гг, 2 - враг
                if (gens.pDopEnergia > 2)
                {
                    pervohod = 1;
                }
                else if (gens.pDopEnergia < 2)
                {
                    pervohod = 2;
                }
                else
                {
                    pervohod = Random.Range(1, 3);
                }

                // здесь снимаются блоки врага, чтоб было видно навыки
                mermenreader.speshlblok1.SetActive(false);
                mermenreader.speshlblok2.SetActive(false);
                mermenreader.speshlblok3.SetActive(false);
                mermenreader.speshlblok4.SetActive(false);
                mermenreader.speshlblok5.SetActive(false);
                mermenreader.speshlblok6.SetActive(false);
                mermenreader.speshlblok7.SetActive(false);
                mermenreader.speshlblok8.SetActive(false);
                mermenreader.speshlblok9.SetActive(false);
                slotsmerman.slo1blocked.SetActive(false);
                slotsmerman.slo2blocked.SetActive(false);
                slotsmerman.slo3blocked.SetActive(false);
                slotsmerman.slo4blocked.SetActive(false);
                slotsmerman.slo5blocked.SetActive(false);
                slotsmerman.slo6blocked.SetActive(false);
                slotsmerman.slo7blocked.SetActive(false);
                slotsmerman.slo8blocked.SetActive(false);
                slotsmerman.slo9blocked.SetActive(false);
                slot1GGdamag.SetActive(false);
                slot2GGdamag.SetActive(false);
                slot3GGdamag.SetActive(false);
                slot4GGdamag.SetActive(false);
                slot5GGdamag.SetActive(false);
                slot6GGdamag.SetActive(false);
                slot7GGdamag.SetActive(false);
                slot8GGdamag.SetActive(false);
                slot9GGdamag.SetActive(false);
                slot1Vragdamag.SetActive(false);
                slot2Vragdamag.SetActive(false);
                slot3Vragdamag.SetActive(false);
                slot4Vragdamag.SetActive(false);
                slot5Vragdamag.SetActive(false);
                slot6Vragdamag.SetActive(false);
                slot7Vragdamag.SetActive(false);
                slot8Vragdamag.SetActive(false);
                slot9Vragdamag.SetActive(false);
                slot1GGhilli.SetActive(false);
                slot2GGhilli.SetActive(false);
                slot3GGhilli.SetActive(false);
                slot4GGhilli.SetActive(false);
                slot5GGhilli.SetActive(false);
                slot6GGhilli.SetActive(false);
                slot7GGhilli.SetActive(false);
                slot8GGhilli.SetActive(false);
                slot9GGhilli.SetActive(false);
                slot1Vraghilli.SetActive(false);
                slot2Vraghilli.SetActive(false);
                slot3Vraghilli.SetActive(false);
                slot4Vraghilli.SetActive(false);
                slot5Vraghilli.SetActive(false);
                slot6Vraghilli.SetActive(false);
                slot7Vraghilli.SetActive(false);
                slot8Vraghilli.SetActive(false);
                slot9Vraghilli.SetActive(false);
                slot1GGshield.SetActive(false);
                slot2GGshield.SetActive(false);
                slot3GGshield.SetActive(false);
                slot4GGshield.SetActive(false);
                slot5GGshield.SetActive(false);
                slot6GGshield.SetActive(false);
                slot7GGshield.SetActive(false);
                slot8GGshield.SetActive(false);
                slot9GGshield.SetActive(false);
                slot1Vragshield.SetActive(false);
                slot2Vragshield.SetActive(false);
                slot3Vragshield.SetActive(false);
                slot4Vragshield.SetActive(false);
                slot5Vragshield.SetActive(false);
                slot6Vragshield.SetActive(false);
                slot7Vragshield.SetActive(false);
                slot8Vragshield.SetActive(false);
                slot9Vragshield.SetActive(false);
                hoddamag.SetActive(true);
                hoddamag2.SetActive(true);
                hodhilli.SetActive(true);
                hodhilli2.SetActive(true);
                hodtoxins.SetActive(true);
                hodtoxins2.SetActive(true);
                hodantiBlok.SetActive(true);
                hodantiBlok2.SetActive(true);
                // здесь читаются блоки, потом антиблоки, их мишени

                chitalkaBlokov();
                hpustanovleny = true;
                if (enemyspawner.fishbiom)
                {
                    chitalkaBattle();
                    hodSvet2.SetActive(true);
                    slot1Vragsvet.SetActive(true);
                    slot2Vragsvet.SetActive(true);
                    slot3Vragsvet.SetActive(true);
                    slot4Vragsvet.SetActive(true);
                    slot5Vragsvet.SetActive(true);
                    slot6Vragsvet.SetActive(true);
                    slot7Vragsvet.SetActive(true);
                    slot8Vragsvet.SetActive(true);
                    slot9Vragsvet.SetActive(true);
                }
                else
                {
                    obnuliator(); // чистка ходов перед боем
                }
                timerHoda = 2f;
            }

            // эта штука отсчитывает продолжительность хода
            if (timerHoda < 1f)
            {
                timerHoda -= Time.deltaTime;
            }
            if (timerHoda > 1.5f)
            {
                timerHoda -= Time.deltaTime;
            }
            else if(timerHoda > 1f)
            {
                timerHoda = 1f;
            }


            // здесь проигрывается бой !!!зависимо от последовательности слотов!!!
            if (timerHoda == 1 && (slot1GGpohodil == false || slot1Vragpohodil == false)) // 1 слот обоих персов
            {
                
                timerHoda -= 0.1f; // это читается только раз
                if ((pervohod == 1 && slot1GGpohodil == false) || (slot1Vragpohodil == true && slot1GGpohodil == false))
                {
                    obnuliator();
                    slot1GGsvet.SetActive(true);
                    
                    udarus.transform.eulerAngles = new Vector3(0f, 0f, 180f);
                    
                    udarus2.transform.eulerAngles = new Vector3(0f, 0f, 180f);
                    
                    udarus3.transform.eulerAngles = new Vector3(0f, 0f, 180f);
                    if (mermenreader.slot1zablokirovan == false && slotsgg.slot1Hp != 0f) // если слот1незаблокирован и там не мертвый навык
                    {
                        chitalkaTarget1 = skreader.slot1target1;
                        chitalkaTarget2 = skreader.slot1target2;
                        chitalkaTarget3 = skreader.slot1target3;
                        playingSkill = skreader.slot1skill;
                        // пока что удар - универсальный

                        // если не чисто блок или антиблок
                        if (playingSkill != 4 && playingSkill != 5 && playingSkill != 9 && playingSkill != 12 && playingSkill != 15 && playingSkill != 19 && playingSkill != 24 && playingSkill != 27 && playingSkill != 29 && playingSkill != 37 && playingSkill != 38 && playingSkill != 39)
                        {
                            // если хиллы
                            if(playingSkill == 6 || playingSkill == 7 || playingSkill == 8 || playingSkill == 10 || playingSkill == 11 || playingSkill == 18 || playingSkill == 25 || playingSkill == 26 || playingSkill == 35 || playingSkill == 36 || playingSkill == 42)
                            {
                                if (chitalkaTarget1 != null)
                                {
                                    udar.transform.position = slot1GGsvet.transform.position;
                                    udar.SetActive(true);
                                }
                                if (chitalkaTarget2 != null)
                                {
                                    udar2.transform.position = slot1GGsvet.transform.position;
                                    udar2.SetActive(true);
                                }
                                if (chitalkaTarget3 != null)
                                {
                                    udar3.transform.position = slot1GGsvet.transform.position;
                                    udar3.SetActive(true);
                                }

                            }
                            // если атаки
                            if(playingSkill == 1 || playingSkill == 2 || playingSkill == 3 || playingSkill == 13 || playingSkill == 14 || playingSkill == 16 || playingSkill == 17 || playingSkill == 21 || playingSkill == 22 || playingSkill == 23 || playingSkill == 30 || playingSkill == 32 || playingSkill == 33 || playingSkill == 34 || playingSkill == 40 || playingSkill == 43 || playingSkill == 31 || playingSkill == 28)
                            {
                                
                                if (chitalkaTarget1 != null)
                                {
                                    udarus.transform.position = slot1GGsvet.transform.position;
                                    udarus.SetActive(true);
                                    attak.Play(0);
                                }
                                if (chitalkaTarget2 != null)
                                {
                                    udarus2.transform.position = slot1GGsvet.transform.position;
                                    udarus2.SetActive(true);
                                }
                                if (chitalkaTarget3 != null)
                                {
                                    udarus3.transform.position = slot1GGsvet.transform.position;
                                    udarus3.SetActive(true);
                                }

                            }
                        }
                    }
                    else // если заблокирован, цели = нулл
                    {
                        chitalkaTarget1 = null;
                        chitalkaTarget2 = null;
                        chitalkaTarget3 = null;
                        playingSkill = 0;
                        timerHoda = 0.1f;
                    }
                    animation_bol = true;



                }
                else if (pervohod == 2 || (slot1GGpohodil == true && slot1Vragpohodil == false))
                {
                    obnuliator();
                    slot1Vragsvet.SetActive(true);

                    udarus.transform.eulerAngles = new Vector3(0f, 0f, 0f);

                    udarus2.transform.eulerAngles = new Vector3(0f, 0f, 0f);

                    udarus3.transform.eulerAngles = new Vector3(0f, 0f, 0f);
                    if (mermenreader.slot1zablokVraga == false && slotsmerman.slo1Hp != 0f) // если слот1незаблокирован и там не мертвый навык
                    {
                        chitalkaTarget1 = skreader.slot1targetVr1;
                        chitalkaTarget2 = skreader.slot1targetVr2;
                        chitalkaTarget3 = skreader.slot1targetVr3;
                        playingSkill = skreader.slot1skillVraga;
                        // если не чисто блок или антиблок
                        if (playingSkill != 4 && playingSkill != 5 && playingSkill != 9 && playingSkill != 12 && playingSkill != 15 && playingSkill != 19 && playingSkill != 24 && playingSkill != 27 && playingSkill != 29 && playingSkill != 37 && playingSkill != 38 && playingSkill != 39)
                        {
                            if (playingSkill == 6 || playingSkill == 7 || playingSkill == 8 || playingSkill == 10 || playingSkill == 11 || playingSkill == 18 || playingSkill == 25 || playingSkill == 26 || playingSkill == 35 || playingSkill == 36 || playingSkill == 42)
                            {
                                if (chitalkaTarget1 != null)
                                {
                                    udar.transform.position = slot1Vragsvet.transform.position;
                                    udar.SetActive(true);
                                }
                                if (chitalkaTarget2 != null)
                                {
                                    udar2.transform.position = slot1Vragsvet.transform.position;
                                    udar2.SetActive(true);
                                }
                                if (chitalkaTarget3 != null)
                                {
                                    udar3.transform.position = slot1Vragsvet.transform.position;
                                    udar3.SetActive(true);
                                }
                            }
                            if (playingSkill == 1 || playingSkill == 2 || playingSkill == 3 || playingSkill == 13 || playingSkill == 14 || playingSkill == 16 || playingSkill == 17 || playingSkill == 21 || playingSkill == 22 || playingSkill == 23 || playingSkill == 30 || playingSkill == 32 || playingSkill == 33 || playingSkill == 34 || playingSkill == 40 || playingSkill == 43 || playingSkill == 31 || playingSkill == 28)
                            {
                                
                                if (chitalkaTarget1 != null)
                                {
                                    udarus.transform.position = slot1Vragsvet.transform.position;
                                    udarus.SetActive(true);
                                    attak.Play(0);
                                }
                                if (chitalkaTarget2 != null)
                                {
                                    udarus2.transform.position = slot1Vragsvet.transform.position;
                                    udarus2.SetActive(true);
                                }
                                if (chitalkaTarget3 != null)
                                {
                                    udarus3.transform.position = slot1Vragsvet.transform.position;
                                    udarus3.SetActive(true);
                                }
                            }
                        }
                    }
                    else // если заблокирован, цели = нулл
                    {
                        chitalkaTarget1 = null;
                        chitalkaTarget2 = null;
                        chitalkaTarget3 = null;
                        playingSkill = 0;
                        timerHoda = 0.1f;
                    }

                    animation_bol = true;
                }
            }


            if (timerHoda < 0 && slot1GGsvet.activeSelf == true && animation_bol == false)
            {
                toxinsCheker();
                slot1GGpohodil = true;
                timerHoda = 1.7f;
            }
            else if (timerHoda < 0 && slot1Vragsvet.activeSelf == true && animation_bol == false)
            {
                toxinsCheker();
                slot1Vragpohodil = true;
                timerHoda = 1.7f;
            }

            if (timerHoda == 1 && slot1GGpohodil == true && slot1Vragpohodil == true && (slot2GGpohodil == false || slot2Vragpohodil == false))
            {
                timerHoda -= 0.1f; // это читается только раз
                if ((pervohod == 1 && slot2GGpohodil == false) || (slot2Vragpohodil == true && slot2GGpohodil == false))
                {
                    obnuliator();
                    slot2GGsvet.SetActive(true);

                    udarus.transform.eulerAngles = new Vector3(0f, 0f, 180f);

                    udarus2.transform.eulerAngles = new Vector3(0f, 0f, 180f);

                    udarus3.transform.eulerAngles = new Vector3(0f, 0f, 180f);
                    if (mermenreader.slot2zablokirovan == false && slotsgg.slot2Hp != 0f)
                    {
                        chitalkaTarget1 = skreader.slot2target1;
                        chitalkaTarget2 = skreader.slot2target2;
                        chitalkaTarget3 = skreader.slot2target3;
                        playingSkill = skreader.slot2skill;
                        // если не чисто блок или антиблок
                        if (playingSkill != 4 && playingSkill != 5 && playingSkill != 9 && playingSkill != 12 && playingSkill != 15 && playingSkill != 19 && playingSkill != 24 && playingSkill != 27 && playingSkill != 29 && playingSkill != 37 && playingSkill != 38 && playingSkill != 39)
                        {
                            if (playingSkill == 6 || playingSkill == 7 || playingSkill == 8 || playingSkill == 10 || playingSkill == 11 || playingSkill == 18 || playingSkill == 25 || playingSkill == 26 || playingSkill == 35 || playingSkill == 36 || playingSkill == 42)
                            {
                                if (chitalkaTarget1 != null)
                                {
                                    udar.transform.position = slot2GGsvet.transform.position;
                                    udar.SetActive(true);
                                }
                                if (chitalkaTarget2 != null)
                                {
                                    udar2.transform.position = slot2GGsvet.transform.position;
                                    udar2.SetActive(true);
                                }
                                if (chitalkaTarget3 != null)
                                {
                                    udar3.transform.position = slot2GGsvet.transform.position;
                                    udar3.SetActive(true);
                                }
                            }
                            if (playingSkill == 1 || playingSkill == 2 || playingSkill == 3 || playingSkill == 13 || playingSkill == 14 || playingSkill == 16 || playingSkill == 17 || playingSkill == 21 || playingSkill == 22 || playingSkill == 23 || playingSkill == 30 || playingSkill == 32 || playingSkill == 33 || playingSkill == 34 || playingSkill == 40 || playingSkill == 43 || playingSkill == 31 || playingSkill == 28)
                            {
                                
                                if (chitalkaTarget1 != null)
                                {
                                    udarus.transform.position = slot2GGsvet.transform.position;
                                    udarus.SetActive(true);
                                    attak.Play(0);
                                }
                                if (chitalkaTarget2 != null)
                                {
                                    udarus2.transform.position = slot2GGsvet.transform.position;
                                    udarus2.SetActive(true);
                                }
                                if (chitalkaTarget3 != null)
                                {
                                    udarus3.transform.position = slot2GGsvet.transform.position;
                                    udarus3.SetActive(true);
                                }
                            }

                        }
                    }
                    else // если заблокирован, цели = нулл
                    {
                        chitalkaTarget1 = null;
                        chitalkaTarget2 = null;
                        chitalkaTarget3 = null;
                        playingSkill = 0;
                        timerHoda = 0.1f;
                    }
                    // увеличиваем активный слот, его мишень уменьшаем(?)

                    animation_bol = true;
                }
                else if (pervohod == 2 || (slot2GGpohodil == true && slot2Vragpohodil == false))
                {
                    obnuliator();
                    slot2Vragsvet.SetActive(true);

                    udarus.transform.eulerAngles = new Vector3(0f, 0f, 0f);

                    udarus2.transform.eulerAngles = new Vector3(0f, 0f, 0f);

                    udarus3.transform.eulerAngles = new Vector3(0f, 0f, 0f);
                    if (mermenreader.slot2zablokVraga == false && slotsmerman.slo2Hp != 0f)
                    {
                        chitalkaTarget1 = skreader.slot2targetVr1;
                        chitalkaTarget2 = skreader.slot2targetVr2;
                        chitalkaTarget3 = skreader.slot2targetVr3;
                        playingSkill = skreader.slot2skillVraga;
                        // если не чисто блок или антиблок
                        if (playingSkill != 4 && playingSkill != 5 && playingSkill != 9 && playingSkill != 12 && playingSkill != 15 && playingSkill != 19 && playingSkill != 24 && playingSkill != 27 && playingSkill != 29 && playingSkill != 37 && playingSkill != 38 && playingSkill != 39)
                        {
                            if (playingSkill == 6 || playingSkill == 7 || playingSkill == 8 || playingSkill == 10 || playingSkill == 11 || playingSkill == 18 || playingSkill == 25 || playingSkill == 26 || playingSkill == 35 || playingSkill == 36 || playingSkill == 42)
                            {
                                if (chitalkaTarget1 != null)
                                {
                                    udar.transform.position = slot2Vragsvet.transform.position;
                                    udar.SetActive(true);
                                }
                                if (chitalkaTarget2 != null)
                                {
                                    udar2.transform.position = slot2Vragsvet.transform.position;
                                    udar2.SetActive(true);
                                }
                                if (chitalkaTarget3 != null)
                                {
                                    udar3.transform.position = slot2Vragsvet.transform.position;
                                    udar3.SetActive(true);
                                }
                            }
                            if (playingSkill == 1 || playingSkill == 2 || playingSkill == 3 || playingSkill == 13 || playingSkill == 14 || playingSkill == 16 || playingSkill == 17 || playingSkill == 21 || playingSkill == 22 || playingSkill == 23 || playingSkill == 30 || playingSkill == 32 || playingSkill == 33 || playingSkill == 34 || playingSkill == 40 || playingSkill == 43 || playingSkill == 31 || playingSkill == 28)
                            {
                                
                                if (chitalkaTarget1 != null)
                                {
                                    udarus.transform.position = slot2Vragsvet.transform.position;
                                    udarus.SetActive(true);
                                    attak.Play(0);
                                }
                                if (chitalkaTarget2 != null)
                                {
                                    udarus2.transform.position = slot2Vragsvet.transform.position;
                                    udarus2.SetActive(true);
                                }
                                if (chitalkaTarget3 != null)
                                {
                                    udarus3.transform.position = slot2Vragsvet.transform.position;
                                    udarus3.SetActive(true);
                                }
                            }

                        }
                    }
                    else // если заблокирован, цели = нулл
                    {
                        chitalkaTarget1 = null;
                        chitalkaTarget2 = null;
                        chitalkaTarget3 = null;
                        playingSkill = 0;
                        timerHoda = 0.1f;
                    }

                    animation_bol = true;
                }
            }

            if (timerHoda < 0 && slot2GGsvet.activeSelf == true && animation_bol == false)
            {
                
                toxinsCheker();
                slot2GGpohodil = true;
                timerHoda = 1.7f;
            }
            else if (timerHoda < 0 && slot2Vragsvet.activeSelf == true && animation_bol == false)
            {
                
                toxinsCheker();
                slot2Vragpohodil = true;
                timerHoda = 1.7f;
            }

            if (timerHoda == 1 && slot2GGpohodil == true && slot2Vragpohodil == true && (slot3GGpohodil == false || slot3Vragpohodil == false))
            {
                timerHoda -= 0.1f; // это читается только раз
                if ((pervohod == 1 && slot3GGpohodil == false) || (slot3Vragpohodil == true && slot3GGpohodil == false))
                {
                    obnuliator();
                    slot3GGsvet.SetActive(true);

                    udarus.transform.eulerAngles = new Vector3(0f, 0f, 180f);

                    udarus2.transform.eulerAngles = new Vector3(0f, 0f, 180f);

                    udarus3.transform.eulerAngles = new Vector3(0f, 0f, 180f);
                    if (mermenreader.slot3zablokirovan == false && slotsgg.slot3Hp != 0f)
                    {
                        chitalkaTarget1 = skreader.slot3target1;
                        chitalkaTarget2 = skreader.slot3target2;
                        chitalkaTarget3 = skreader.slot3target3;
                        playingSkill = skreader.slot3skill;
                        // если не чисто блок или антиблок
                        if (playingSkill != 4 && playingSkill != 5 && playingSkill != 9 && playingSkill != 12 && playingSkill != 15 && playingSkill != 19 && playingSkill != 24 && playingSkill != 27 && playingSkill != 29 && playingSkill != 37 && playingSkill != 38 && playingSkill != 39)
                        {
                            if (playingSkill == 6 || playingSkill == 7 || playingSkill == 8 || playingSkill == 10 || playingSkill == 11 || playingSkill == 18 || playingSkill == 25 || playingSkill == 26 || playingSkill == 35 || playingSkill == 36 || playingSkill == 42)
                            {
                                if (chitalkaTarget1 != null)
                                {
                                    udar.transform.position = slot3GGsvet.transform.position;
                                    udar.SetActive(true);
                                }
                                if (chitalkaTarget2 != null)
                                {
                                    udar2.transform.position = slot3GGsvet.transform.position;
                                    udar2.SetActive(true);
                                }
                                if (chitalkaTarget3 != null)
                                {
                                    udar3.transform.position = slot3GGsvet.transform.position;
                                    udar3.SetActive(true);
                                }
                            }
                            if (playingSkill == 1 || playingSkill == 2 || playingSkill == 3 || playingSkill == 13 || playingSkill == 14 || playingSkill == 16 || playingSkill == 17 || playingSkill == 21 || playingSkill == 22 || playingSkill == 23 || playingSkill == 30 || playingSkill == 32 || playingSkill == 33 || playingSkill == 34 || playingSkill == 40 || playingSkill == 43 || playingSkill == 31 || playingSkill == 28)
                            {
                                
                                if (chitalkaTarget1 != null)
                                {
                                    udarus.transform.position = slot3GGsvet.transform.position;
                                    udarus.SetActive(true);
                                    attak.Play(0);
                                }
                                if (chitalkaTarget2 != null)
                                {
                                    udarus2.transform.position = slot3GGsvet.transform.position;
                                    udarus2.SetActive(true);
                                }
                                if (chitalkaTarget3 != null)
                                {
                                    udarus3.transform.position = slot3GGsvet.transform.position;
                                    udarus3.SetActive(true);
                                }
                            }

                        }
                    }
                    else // если заблокирован, цели = нулл
                    {
                        chitalkaTarget1 = null;
                        chitalkaTarget2 = null;
                        chitalkaTarget3 = null;
                        playingSkill = 0;
                        timerHoda = 0.1f;
                    }

                    animation_bol = true;
                }
                else if (pervohod == 2 || (slot3GGpohodil == true && slot3Vragpohodil == false))
                {
                    obnuliator();
                    slot3Vragsvet.SetActive(true);

                    udarus.transform.eulerAngles = new Vector3(0f, 0f, 0f);

                    udarus2.transform.eulerAngles = new Vector3(0f, 0f, 0f);

                    udarus3.transform.eulerAngles = new Vector3(0f, 0f, 0f);
                    if (mermenreader.slot3zablokVraga == false && slotsmerman.slo3Hp != 0f)
                    {
                        chitalkaTarget1 = skreader.slot3targetVr1;
                        chitalkaTarget2 = skreader.slot3targetVr2;
                        chitalkaTarget3 = skreader.slot3targetVr3;
                        playingSkill = skreader.slot3skillVraga;
                        // если не чисто блок или антиблок
                        if (playingSkill != 4 && playingSkill != 5 && playingSkill != 9 && playingSkill != 12 && playingSkill != 15 && playingSkill != 19 && playingSkill != 24 && playingSkill != 27 && playingSkill != 29 && playingSkill != 37 && playingSkill != 38 && playingSkill != 39)
                        {
                            if (playingSkill == 6 || playingSkill == 7 || playingSkill == 8 || playingSkill == 10 || playingSkill == 11 || playingSkill == 18 || playingSkill == 25 || playingSkill == 26 || playingSkill == 35 || playingSkill == 36 || playingSkill == 42)
                            {

                                if (chitalkaTarget1 != null)
                                {
                                    udar.transform.position = slot3Vragsvet.transform.position;
                                    udar.SetActive(true);
                                }
                                if (chitalkaTarget2 != null)
                                {
                                    udar2.transform.position = slot3Vragsvet.transform.position;
                                    udar2.SetActive(true);
                                }
                                if (chitalkaTarget3 != null)
                                {
                                    udar3.transform.position = slot3Vragsvet.transform.position;
                                    udar3.SetActive(true);
                                }
                            }
                            if (playingSkill == 1 || playingSkill == 2 || playingSkill == 3 || playingSkill == 13 || playingSkill == 14 || playingSkill == 16 || playingSkill == 17 || playingSkill == 21 || playingSkill == 22 || playingSkill == 23 || playingSkill == 30 || playingSkill == 32 || playingSkill == 33 || playingSkill == 34 || playingSkill == 40 || playingSkill == 43 || playingSkill == 31 || playingSkill == 28)
                            {
                                
                                if (chitalkaTarget1 != null)
                                {
                                    udarus.transform.position = slot3Vragsvet.transform.position;
                                    udarus.SetActive(true);
                                    attak.Play(0);
                                }
                                if (chitalkaTarget2 != null)
                                {
                                    udarus2.transform.position = slot3Vragsvet.transform.position;
                                    udarus2.SetActive(true);
                                }
                                if (chitalkaTarget3 != null)
                                {
                                    udarus3.transform.position = slot3Vragsvet.transform.position;
                                    udarus3.SetActive(true);
                                }
                            }
                        }
                    }
                    else // если заблокирован, цели = нулл
                    {
                        chitalkaTarget1 = null;
                        chitalkaTarget2 = null;
                        chitalkaTarget3 = null;
                        playingSkill = 0;
                        timerHoda = 0.1f;
                    }

                    animation_bol = true;
                }
            }

            if (timerHoda < 0 && slot3GGsvet.activeSelf == true && animation_bol == false)
            {
                toxinsCheker();
                slot3GGpohodil = true;
                timerHoda = 1.7f;
            }
            else if (timerHoda < 0 && slot3Vragsvet.activeSelf == true && animation_bol == false)
            {
                toxinsCheker();
                slot3Vragpohodil = true;
                timerHoda = 1.7f;
            }

            if (timerHoda == 1 && slot3GGpohodil == true && slot3Vragpohodil == true && (slot4GGpohodil == false || slot4Vragpohodil == false))
            {
                timerHoda -= 0.1f; // это читается только раз
                if ((pervohod == 1 && slot4GGpohodil == false) || (slot4Vragpohodil == true && slot4GGpohodil == false))
                {
                    obnuliator();
                    slot4GGsvet.SetActive(true);

                    udarus.transform.eulerAngles = new Vector3(0f, 0f, 180f);

                    udarus2.transform.eulerAngles = new Vector3(0f, 0f, 180f);

                    udarus3.transform.eulerAngles = new Vector3(0f, 0f, 180f);
                    if (mermenreader.slot4zablokirovan == false && slotsgg.slot4Hp != 0f)
                    {
                        chitalkaTarget1 = skreader.slot4target1;
                        chitalkaTarget2 = skreader.slot4target2;
                        chitalkaTarget3 = skreader.slot4target3;
                        playingSkill = skreader.slot4skill;
                        // если не чисто блок или антиблок
                        if (playingSkill != 4 && playingSkill != 5 && playingSkill != 9 && playingSkill != 12 && playingSkill != 15 && playingSkill != 19 && playingSkill != 24 && playingSkill != 27 && playingSkill != 29 && playingSkill != 37 && playingSkill != 38 && playingSkill != 39)
                        {
                            if (playingSkill == 6 || playingSkill == 7 || playingSkill == 8 || playingSkill == 10 || playingSkill == 11 || playingSkill == 18 || playingSkill == 25 || playingSkill == 26 || playingSkill == 35 || playingSkill == 36 || playingSkill == 42)
                            {
                                if (chitalkaTarget1 != null)
                                {
                                    udar.transform.position = slot4GGsvet.transform.position;
                                    udar.SetActive(true);
                                }
                                if (chitalkaTarget2 != null)
                                {
                                    udar2.transform.position = slot4GGsvet.transform.position;
                                    udar2.SetActive(true);
                                }
                                if (chitalkaTarget3 != null)
                                {
                                    udar3.transform.position = slot4GGsvet.transform.position;
                                    udar3.SetActive(true);
                                }
                            }
                            if (playingSkill == 1 || playingSkill == 2 || playingSkill == 3 || playingSkill == 13 || playingSkill == 14 || playingSkill == 16 || playingSkill == 17 || playingSkill == 21 || playingSkill == 22 || playingSkill == 23 || playingSkill == 30 || playingSkill == 32 || playingSkill == 33 || playingSkill == 34 || playingSkill == 40 || playingSkill == 43 || playingSkill == 31 || playingSkill == 28)
                            {
                                
                                if (chitalkaTarget1 != null)
                                {
                                    udarus.transform.position = slot4GGsvet.transform.position;
                                    udarus.SetActive(true);
                                    attak.Play(0);
                                }
                                if (chitalkaTarget2 != null)
                                {
                                    udarus2.transform.position = slot4GGsvet.transform.position;
                                    udarus2.SetActive(true);
                                }
                                if (chitalkaTarget3 != null)
                                {
                                    udarus3.transform.position = slot4GGsvet.transform.position;
                                    udarus3.SetActive(true);
                                }
                            }
                        }
                    }
                    else // если заблокирован, цели = нулл
                    {
                        chitalkaTarget1 = null;
                        chitalkaTarget2 = null;
                        chitalkaTarget3 = null;
                        playingSkill = 0;
                        timerHoda = 0.1f;
                    }

                    animation_bol = true;
                }
                else if (pervohod == 2 || (slot4GGpohodil == true && slot4Vragpohodil == false))
                {
                    obnuliator();
                    slot4Vragsvet.SetActive(true);

                    udarus.transform.eulerAngles = new Vector3(0f, 0f, 0f);

                    udarus2.transform.eulerAngles = new Vector3(0f, 0f, 0f);

                    udarus3.transform.eulerAngles = new Vector3(0f, 0f, 0f);
                    if (mermenreader.slot4zablokVraga == false && slotsmerman.slo4Hp != 0f)
                    {
                        chitalkaTarget1 = skreader.slot4targetVr1;
                        chitalkaTarget2 = skreader.slot4targetVr2;
                        chitalkaTarget3 = skreader.slot4targetVr3;
                        playingSkill = skreader.slot4skillVraga;
                        // если не чисто блок или антиблок
                        if (playingSkill != 4 && playingSkill != 5 && playingSkill != 9 && playingSkill != 12 && playingSkill != 15 && playingSkill != 19 && playingSkill != 24 && playingSkill != 27 && playingSkill != 29 && playingSkill != 37 && playingSkill != 38 && playingSkill != 39)
                        {
                            if (playingSkill == 6 || playingSkill == 7 || playingSkill == 8 || playingSkill == 10 || playingSkill == 11 || playingSkill == 18 || playingSkill == 25 || playingSkill == 26 || playingSkill == 35 || playingSkill == 36 || playingSkill == 42)
                            {
                                if (chitalkaTarget1 != null)
                                {
                                    udar.transform.position = slot4Vragsvet.transform.position;
                                    udar.SetActive(true);
                                }
                                if (chitalkaTarget2 != null)
                                {
                                    udar2.transform.position = slot4Vragsvet.transform.position;
                                    udar2.SetActive(true);
                                }
                                if (chitalkaTarget3 != null)
                                {
                                    udar3.transform.position = slot4Vragsvet.transform.position;
                                    udar3.SetActive(true);
                                }
                            }
                            if (playingSkill == 1 || playingSkill == 2 || playingSkill == 3 || playingSkill == 13 || playingSkill == 14 || playingSkill == 16 || playingSkill == 17 || playingSkill == 21 || playingSkill == 22 || playingSkill == 23 || playingSkill == 30 || playingSkill == 32 || playingSkill == 33 || playingSkill == 34 || playingSkill == 40 || playingSkill == 43 || playingSkill == 31 || playingSkill == 28)
                            {
                                
                                if (chitalkaTarget1 != null)
                                {
                                    udarus.transform.position = slot4Vragsvet.transform.position;
                                    udarus.SetActive(true);
                                    attak.Play(0);
                                }
                                if (chitalkaTarget2 != null)
                                {
                                    udarus2.transform.position = slot4Vragsvet.transform.position;
                                    udarus2.SetActive(true);
                                }
                                if (chitalkaTarget3 != null)
                                {
                                    udarus3.transform.position = slot4Vragsvet.transform.position;
                                    udarus3.SetActive(true);
                                }
                            }
                        }
                    }
                    else // если заблокирован, цели = нулл
                    {
                        chitalkaTarget1 = null;
                        chitalkaTarget2 = null;
                        chitalkaTarget3 = null;
                        playingSkill = 0;
                        timerHoda = 0.1f;
                    }

                    animation_bol = true;
                }
            }

            if (timerHoda < 0 && slot4GGsvet.activeSelf == true && animation_bol == false)
            {
               // slot1Vragtoxins.SetActive(false);
                toxinsCheker();
                slot4GGpohodil = true;
                timerHoda = 1.7f;
            }
            else if (timerHoda < 0 && slot4Vragsvet.activeSelf == true && animation_bol == false)
            {
               // slot1GGtoxins.SetActive(false);
                toxinsCheker();
                slot4Vragpohodil = true;
                timerHoda = 1.7f;
            }
            if (timerHoda == 1 && slot4GGpohodil == true && slot4Vragpohodil == true && (slot5GGpohodil == false || slot5Vragpohodil == false))
            {
                timerHoda -= 0.1f; // это читается только раз
                if ((pervohod == 1 && slot5GGpohodil == false) || (slot5Vragpohodil == true && slot5GGpohodil == false))
                {
                    obnuliator();
                    slot5GGsvet.SetActive(true);

                    udarus.transform.eulerAngles = new Vector3(0f, 0f, 180f);

                    udarus2.transform.eulerAngles = new Vector3(0f, 0f, 180f);

                    udarus3.transform.eulerAngles = new Vector3(0f, 0f, 180f);
                    if (mermenreader.slot5zablokirovan == false && slotsgg.slot5Hp != 0f)
                    {
                        chitalkaTarget1 = skreader.slot5target1;
                        chitalkaTarget2 = skreader.slot5target2;
                        chitalkaTarget3 = skreader.slot5target3;
                        playingSkill = skreader.slot5skill;
                        // если не чисто блок или антиблок
                        if (playingSkill != 4 && playingSkill != 5 && playingSkill != 9 && playingSkill != 12 && playingSkill != 15 && playingSkill != 19 && playingSkill != 24 && playingSkill != 27 && playingSkill != 29 && playingSkill != 37 && playingSkill != 38 && playingSkill != 39)
                        {
                            if (playingSkill == 6 || playingSkill == 7 || playingSkill == 8 || playingSkill == 10 || playingSkill == 11 || playingSkill == 18 || playingSkill == 25 || playingSkill == 26 || playingSkill == 35 || playingSkill == 36 || playingSkill == 42)
                            {
                                if (chitalkaTarget1 != null)
                                {
                                    udar.transform.position = slot5GGsvet.transform.position;
                                    udar.SetActive(true);
                                }
                                if (chitalkaTarget2 != null)
                                {
                                    udar2.transform.position = slot5GGsvet.transform.position;
                                    udar2.SetActive(true);
                                }
                                if (chitalkaTarget3 != null)
                                {
                                    udar3.transform.position = slot5GGsvet.transform.position;
                                    udar3.SetActive(true);
                                }
                            }
                            if (playingSkill == 1 || playingSkill == 2 || playingSkill == 3 || playingSkill == 13 || playingSkill == 14 || playingSkill == 16 || playingSkill == 17 || playingSkill == 21 || playingSkill == 22 || playingSkill == 23 || playingSkill == 30 || playingSkill == 32 || playingSkill == 33 || playingSkill == 34 || playingSkill == 40 || playingSkill == 43 || playingSkill == 31 || playingSkill == 28)
                            {
                                
                                if (chitalkaTarget1 != null)
                                {
                                    udarus.transform.position = slot5GGsvet.transform.position;
                                    udarus.SetActive(true);
                                    attak.Play(0);
                                }
                                if (chitalkaTarget2 != null)
                                {
                                    udarus2.transform.position = slot5GGsvet.transform.position;
                                    udarus2.SetActive(true);
                                }
                                if (chitalkaTarget3 != null)
                                {
                                    udarus3.transform.position = slot5GGsvet.transform.position;
                                    udarus3.SetActive(true);
                                }
                            }
                        }
                    }
                    else // если заблокирован, цели = нулл
                    {
                        chitalkaTarget1 = null;
                        chitalkaTarget2 = null;
                        chitalkaTarget3 = null;
                        playingSkill = 0;
                        timerHoda = 0.1f;
                    }

                    animation_bol = true;
                }
                else if (pervohod == 2 || (slot5GGpohodil == true && slot5Vragpohodil == false))
                {
                    obnuliator();
                    slot5Vragsvet.SetActive(true);

                    udarus.transform.eulerAngles = new Vector3(0f, 0f, 0f);

                    udarus2.transform.eulerAngles = new Vector3(0f, 0f, 0f);

                    udarus3.transform.eulerAngles = new Vector3(0f, 0f, 0f);
                    if (mermenreader.slot5zablokVraga == false && slotsmerman.slo5Hp != 0f)
                    {
                        chitalkaTarget1 = skreader.slot5targetVr1;
                        chitalkaTarget2 = skreader.slot5targetVr2;
                        chitalkaTarget3 = skreader.slot5targetVr3;
                        playingSkill = skreader.slot5skillVraga;
                        // если не чисто блок или антиблок
                        if (playingSkill != 4 && playingSkill != 5 && playingSkill != 9 && playingSkill != 12 && playingSkill != 15 && playingSkill != 19 && playingSkill != 24 && playingSkill != 27 && playingSkill != 29 && playingSkill != 37 && playingSkill != 38 && playingSkill != 39)
                        {
                            if (playingSkill == 6 || playingSkill == 7 || playingSkill == 8 || playingSkill == 10 || playingSkill == 11 || playingSkill == 18 || playingSkill == 25 || playingSkill == 26 || playingSkill == 35 || playingSkill == 36 || playingSkill == 42)
                            {
                                if (chitalkaTarget1 != null)
                                {
                                    udar.transform.position = slot5Vragsvet.transform.position;
                                    udar.SetActive(true);
                                }
                                if (chitalkaTarget2 != null)
                                {
                                    udar2.transform.position = slot5Vragsvet.transform.position;
                                    udar2.SetActive(true);
                                }
                                if (chitalkaTarget3 != null)
                                {
                                    udar3.transform.position = slot5Vragsvet.transform.position;
                                    udar3.SetActive(true);
                                }
                            }
                            if (playingSkill == 1 || playingSkill == 2 || playingSkill == 3 || playingSkill == 13 || playingSkill == 14 || playingSkill == 16 || playingSkill == 17 || playingSkill == 21 || playingSkill == 22 || playingSkill == 23 || playingSkill == 30 || playingSkill == 32 || playingSkill == 33 || playingSkill == 34 || playingSkill == 40 || playingSkill == 43 || playingSkill == 31 || playingSkill == 28)
                            {
                               
                                if (chitalkaTarget1 != null)
                                {
                                    udarus.transform.position = slot5Vragsvet.transform.position;
                                    udarus.SetActive(true);
                                    attak.Play(0);
                                }
                                if (chitalkaTarget2 != null)
                                {
                                    udarus2.transform.position = slot5Vragsvet.transform.position;
                                    udarus2.SetActive(true);
                                }
                                if (chitalkaTarget3 != null)
                                {
                                    udarus3.transform.position = slot5Vragsvet.transform.position;
                                    udarus3.SetActive(true);
                                }
                            }
                        }
                    }
                    else // если заблокирован, цели = нулл
                    {
                        chitalkaTarget1 = null;
                        chitalkaTarget2 = null;
                        chitalkaTarget3 = null;
                        playingSkill = 0;
                        timerHoda = 0.1f;
                    }

                    animation_bol = true;
                }
            }

            if (timerHoda < 0 && slot5GGsvet.activeSelf == true && animation_bol == false)
            {
                //slot2Vragtoxins.SetActive(false);
                toxinsCheker();
                slot5GGpohodil = true;
                timerHoda = 1.7f;
            }
            else if (timerHoda < 0 && slot5Vragsvet.activeSelf == true && animation_bol == false)
            {
                //slot2GGtoxins.SetActive(false);
                toxinsCheker();
                slot5Vragpohodil = true;
                timerHoda = 1.7f;
            }
            if (timerHoda == 1 && slot5GGpohodil == true && slot5Vragpohodil == true && (slot6GGpohodil == false || slot6Vragpohodil == false))
            {
                timerHoda -= 0.1f; // это читается только раз
                if ((pervohod == 1 && slot6GGpohodil == false) || (slot6Vragpohodil == true && slot6GGpohodil == false))
                {
                    obnuliator();
                    slot6GGsvet.SetActive(true);

                    udarus.transform.eulerAngles = new Vector3(0f, 0f, 180f);

                    udarus2.transform.eulerAngles = new Vector3(0f, 0f, 180f);

                    udarus3.transform.eulerAngles = new Vector3(0f, 0f, 180f);
                    if (mermenreader.slot6zablokirovan == false && slotsgg.slot6Hp != 0f)
                    {
                        chitalkaTarget1 = skreader.slot6target1;
                        chitalkaTarget2 = skreader.slot6target2;
                        chitalkaTarget3 = skreader.slot6target3;
                        playingSkill = skreader.slot6skill;
                        // если не чисто блок или антиблок
                        if (playingSkill != 4 && playingSkill != 5 && playingSkill != 9 && playingSkill != 12 && playingSkill != 15 && playingSkill != 19 && playingSkill != 24 && playingSkill != 27 && playingSkill != 29 && playingSkill != 37 && playingSkill != 38 && playingSkill != 39)
                        {
                            if (playingSkill == 6 || playingSkill == 7 || playingSkill == 8 || playingSkill == 10 || playingSkill == 11 || playingSkill == 18 || playingSkill == 25 || playingSkill == 26 || playingSkill == 35 || playingSkill == 36 || playingSkill == 42)
                            {
                                if (chitalkaTarget1 != null)
                                {
                                    udar.transform.position = slot6GGsvet.transform.position;
                                    udar.SetActive(true);
                                }
                                if (chitalkaTarget2 != null)
                                {
                                    udar2.transform.position = slot6GGsvet.transform.position;
                                    udar2.SetActive(true);
                                }
                                if (chitalkaTarget3 != null)
                                {
                                    udar3.transform.position = slot6GGsvet.transform.position;
                                    udar3.SetActive(true);
                                }
                            }
                            if (playingSkill == 1 || playingSkill == 2 || playingSkill == 3 || playingSkill == 13 || playingSkill == 14 || playingSkill == 16 || playingSkill == 17 || playingSkill == 21 || playingSkill == 22 || playingSkill == 23 || playingSkill == 30 || playingSkill == 32 || playingSkill == 33 || playingSkill == 34 || playingSkill == 40 || playingSkill == 43 || playingSkill == 31 || playingSkill == 28)
                            {
                                
                                if (chitalkaTarget1 != null)
                                {
                                    udarus.transform.position = slot6GGsvet.transform.position;
                                    udarus.SetActive(true);
                                    attak.Play(0);
                                }
                                if (chitalkaTarget2 != null)
                                {
                                    udarus2.transform.position = slot6GGsvet.transform.position;
                                    udarus2.SetActive(true);
                                }
                                if (chitalkaTarget3 != null)
                                {
                                    udarus3.transform.position = slot6GGsvet.transform.position;
                                    udarus3.SetActive(true);
                                }
                            }
                        }
                    }
                    else // если заблокирован, цели = нулл
                    {
                        chitalkaTarget1 = null;
                        chitalkaTarget2 = null;
                        chitalkaTarget3 = null;
                        playingSkill = 0;
                        timerHoda = 0.1f;
                    }

                    animation_bol = true;
                }
                else if (pervohod == 2 || (slot6GGpohodil == true && slot6Vragpohodil == false))
                {
                    obnuliator();
                    slot6Vragsvet.SetActive(true);

                    udarus.transform.eulerAngles = new Vector3(0f, 0f, 0f);

                    udarus2.transform.eulerAngles = new Vector3(0f, 0f, 0f);

                    udarus3.transform.eulerAngles = new Vector3(0f, 0f, 0f);
                    if (mermenreader.slot6zablokVraga == false && slotsmerman.slo6Hp != 0f)
                    {
                        chitalkaTarget1 = skreader.slot6targetVr1;
                        chitalkaTarget2 = skreader.slot6targetVr2;
                        chitalkaTarget3 = skreader.slot6targetVr3;
                        playingSkill = skreader.slot6skillVraga;
                        // если не чисто блок или антиблок
                        if (playingSkill != 4 && playingSkill != 5 && playingSkill != 9 && playingSkill != 12 && playingSkill != 15 && playingSkill != 19 && playingSkill != 24 && playingSkill != 27 && playingSkill != 29 && playingSkill != 37 && playingSkill != 38 && playingSkill != 39)
                        {
                            if (playingSkill == 6 || playingSkill == 7 || playingSkill == 8 || playingSkill == 10 || playingSkill == 11 || playingSkill == 18 || playingSkill == 25 || playingSkill == 26 || playingSkill == 35 || playingSkill == 36 || playingSkill == 42)
                            {
                                if (chitalkaTarget1 != null)
                                {
                                    udar.transform.position = slot6Vragsvet.transform.position;
                                    udar.SetActive(true);
                                }
                                if (chitalkaTarget2 != null)
                                {
                                    udar2.transform.position = slot6Vragsvet.transform.position;
                                    udar2.SetActive(true);
                                }
                                if (chitalkaTarget3 != null)
                                {
                                    udar3.transform.position = slot6Vragsvet.transform.position;
                                    udar3.SetActive(true);
                                }
                            }
                            if (playingSkill == 1 || playingSkill == 2 || playingSkill == 3 || playingSkill == 13 || playingSkill == 14 || playingSkill == 16 || playingSkill == 17 || playingSkill == 21 || playingSkill == 22 || playingSkill == 23 || playingSkill == 30 || playingSkill == 32 || playingSkill == 33 || playingSkill == 34 || playingSkill == 40 || playingSkill == 43 || playingSkill == 31 || playingSkill == 28)
                            {
                                
                                if (chitalkaTarget1 != null)
                                {
                                    udarus.transform.position = slot6Vragsvet.transform.position;
                                    udarus.SetActive(true);
                                    attak.Play(0);
                                }
                                if (chitalkaTarget2 != null)
                                {
                                    udarus2.transform.position = slot6Vragsvet.transform.position;
                                    udarus2.SetActive(true);
                                }
                                if (chitalkaTarget3 != null)
                                {
                                    udarus3.transform.position = slot6Vragsvet.transform.position;
                                    udarus3.SetActive(true);
                                }
                            }
                        }
                    }
                    else // если заблокирован, цели = нулл
                    {
                        chitalkaTarget1 = null;
                        chitalkaTarget2 = null;
                        chitalkaTarget3 = null;
                        playingSkill = 0;
                        timerHoda = 0.1f;
                    }

                    animation_bol = true;
                }
            }

            if (timerHoda < 0 && slot6GGsvet.activeSelf == true && animation_bol == false)
            {
                //slot3Vragtoxins.SetActive(false);
                toxinsCheker();
                slot6GGpohodil = true;
                timerHoda = 1.7f;
            }
            else if (timerHoda < 0 && slot6Vragsvet.activeSelf == true && animation_bol == false)
            {
                //slot3GGtoxins.SetActive(false);
                toxinsCheker();
                slot6Vragpohodil = true;
                timerHoda = 1.7f;
            }
            if (timerHoda == 1 && slot6GGpohodil == true && slot6Vragpohodil == true && (slot7GGpohodil == false || slot7Vragpohodil == false))
            {
                timerHoda -= 0.1f; // это читается только раз
                if ((pervohod == 1 && slot7GGpohodil == false) || (slot7Vragpohodil == true && slot7GGpohodil == false))
                {
                    obnuliator();
                    slot7GGsvet.SetActive(true);

                    udarus.transform.eulerAngles = new Vector3(0f, 0f, 180f);

                    udarus2.transform.eulerAngles = new Vector3(0f, 0f, 180f);

                    udarus3.transform.eulerAngles = new Vector3(0f, 0f, 180f);
                    if (mermenreader.slot7zablokirovan == false && slotsgg.slot7Hp != 0f)
                    {
                        chitalkaTarget1 = skreader.slot7target1;
                        chitalkaTarget2 = skreader.slot7target2;
                        chitalkaTarget3 = skreader.slot7target3;
                        playingSkill = skreader.slot7skill;
                        // если не чисто блок или антиблок
                        if (playingSkill != 4 && playingSkill != 5 && playingSkill != 9 && playingSkill != 12 && playingSkill != 15 && playingSkill != 19 && playingSkill != 24 && playingSkill != 27 && playingSkill != 29 && playingSkill != 37 && playingSkill != 38 && playingSkill != 39)
                        {
                            if (playingSkill == 6 || playingSkill == 7 || playingSkill == 8 || playingSkill == 10 || playingSkill == 11 || playingSkill == 18 || playingSkill == 25 || playingSkill == 26 || playingSkill == 35 || playingSkill == 36 || playingSkill == 42)
                            {
                                if (chitalkaTarget1 != null)
                                {
                                    udar.transform.position = slot7GGsvet.transform.position;
                                    udar.SetActive(true);
                                }
                                if (chitalkaTarget2 != null)
                                {
                                    udar2.transform.position = slot7GGsvet.transform.position;
                                    udar2.SetActive(true);
                                }
                                if (chitalkaTarget3 != null)
                                {
                                    udar3.transform.position = slot7GGsvet.transform.position;
                                    udar3.SetActive(true);
                                }
                            }
                            if (playingSkill == 1 || playingSkill == 2 || playingSkill == 3 || playingSkill == 13 || playingSkill == 14 || playingSkill == 16 || playingSkill == 17 || playingSkill == 21 || playingSkill == 22 || playingSkill == 23 || playingSkill == 30 || playingSkill == 32 || playingSkill == 33 || playingSkill == 34 || playingSkill == 40 || playingSkill == 43 || playingSkill == 31 || playingSkill == 28)
                            {
                                
                                if (chitalkaTarget1 != null)
                                {
                                    udarus.transform.position = slot7GGsvet.transform.position;
                                    udarus.SetActive(true);
                                    attak.Play(0);
                                }
                                if (chitalkaTarget2 != null)
                                {
                                    udarus2.transform.position = slot7GGsvet.transform.position;
                                    udarus2.SetActive(true);
                                }
                                if (chitalkaTarget3 != null)
                                {
                                    udarus3.transform.position = slot7GGsvet.transform.position;
                                    udarus3.SetActive(true);
                                }
                            }
                        }
                    }
                    else // если заблокирован, цели = нулл
                    {
                        chitalkaTarget1 = null;
                        chitalkaTarget2 = null;
                        chitalkaTarget3 = null;
                        playingSkill = 0;
                        timerHoda = 0.1f;
                    }
                    animation_bol = true;
                }
                else if (pervohod == 2 || (slot7GGpohodil == true && slot7Vragpohodil == false))
                {
                    obnuliator();
                    slot7Vragsvet.SetActive(true);

                    udarus.transform.eulerAngles = new Vector3(0f, 0f, 0f);

                    udarus2.transform.eulerAngles = new Vector3(0f, 0f, 0f);

                    udarus3.transform.eulerAngles = new Vector3(0f, 0f, 0f);
                    if (mermenreader.slot7zablokVraga == false && slotsmerman.slo7Hp != 0f)
                    {
                        chitalkaTarget1 = skreader.slot7targetVr1;
                        chitalkaTarget2 = skreader.slot7targetVr2;
                        chitalkaTarget3 = skreader.slot7targetVr3;
                        playingSkill = skreader.slot7skillVraga;
                        // если не чисто блок или антиблок
                        if (playingSkill != 4 && playingSkill != 5 && playingSkill != 9 && playingSkill != 12 && playingSkill != 15 && playingSkill != 19 && playingSkill != 24 && playingSkill != 27 && playingSkill != 29 && playingSkill != 37 && playingSkill != 38 && playingSkill != 39)
                        {
                            if (playingSkill == 6 || playingSkill == 7 || playingSkill == 8 || playingSkill == 10 || playingSkill == 11 || playingSkill == 18 || playingSkill == 25 || playingSkill == 26 || playingSkill == 35 || playingSkill == 36 || playingSkill == 42)
                            {
                                if (chitalkaTarget1 != null)
                                {
                                    udar.transform.position = slot7Vragsvet.transform.position;
                                    udar.SetActive(true);
                                }
                                if (chitalkaTarget2 != null)
                                {
                                    udar2.transform.position = slot7Vragsvet.transform.position;
                                    udar2.SetActive(true);
                                }
                                if (chitalkaTarget3 != null)
                                {
                                    udar3.transform.position = slot7Vragsvet.transform.position;
                                    udar3.SetActive(true);
                                }
                            }
                            if (playingSkill == 1 || playingSkill == 2 || playingSkill == 3 || playingSkill == 13 || playingSkill == 14 || playingSkill == 16 || playingSkill == 17 || playingSkill == 21 || playingSkill == 22 || playingSkill == 23 || playingSkill == 30 || playingSkill == 32 || playingSkill == 33 || playingSkill == 34 || playingSkill == 40 || playingSkill == 43 || playingSkill == 31 || playingSkill == 28)
                            {
                                
                                if (chitalkaTarget1 != null)
                                {
                                    udarus.transform.position = slot7Vragsvet.transform.position;
                                    udarus.SetActive(true);
                                    attak.Play(0);
                                }
                                if (chitalkaTarget2 != null)
                                {
                                    udarus2.transform.position = slot7Vragsvet.transform.position;
                                    udarus2.SetActive(true);
                                }
                                if (chitalkaTarget3 != null)
                                {
                                    udarus3.transform.position = slot7Vragsvet.transform.position;
                                    udarus3.SetActive(true);
                                }
                            }
                        }
                    }
                    else // если заблокирован, цели = нулл
                    {
                        chitalkaTarget1 = null;
                        chitalkaTarget2 = null;
                        chitalkaTarget3 = null;
                        playingSkill = 0;
                        timerHoda = 0.1f;
                    }

                    animation_bol = true;
                }
            }

            if (timerHoda < 0 && slot7GGsvet.activeSelf == true && animation_bol == false)
            {
                //slot4Vragtoxins.SetActive(false);
                toxinsCheker();
                slot7GGpohodil = true;
                timerHoda = 1.7f;
            }
            else if (timerHoda < 0 && slot7Vragsvet.activeSelf == true && animation_bol == false)
            {
                //slot4GGtoxins.SetActive(false);
                toxinsCheker();
                slot7Vragpohodil = true;
                timerHoda = 1.7f;
            }
            if (timerHoda == 1 && slot7GGpohodil == true && slot7Vragpohodil == true && (slot8GGpohodil == false || slot8Vragpohodil == false))
            {
                timerHoda -= 0.1f; // это читается только раз
                if ((pervohod == 1 && slot8GGpohodil == false) || (slot8Vragpohodil == true && slot8GGpohodil == false))
                {
                    obnuliator();
                    slot8GGsvet.SetActive(true);

                    udarus.transform.eulerAngles = new Vector3(0f, 0f, 180f);

                    udarus2.transform.eulerAngles = new Vector3(0f, 0f, 180f);

                    udarus3.transform.eulerAngles = new Vector3(0f, 0f, 180f);
                    if (mermenreader.slot8zablokirovan == false && slotsgg.slot8Hp != 0f)
                    {
                        chitalkaTarget1 = skreader.slot8target1;
                        chitalkaTarget2 = skreader.slot8target2;
                        chitalkaTarget3 = skreader.slot8target3;
                        playingSkill = skreader.slot8skill;
                        // если не чисто блок или антиблок
                        if (playingSkill != 4 && playingSkill != 5 && playingSkill != 9 && playingSkill != 12 && playingSkill != 15 && playingSkill != 19 && playingSkill != 24 && playingSkill != 27 && playingSkill != 29 && playingSkill != 37 && playingSkill != 38 && playingSkill != 39)
                        {
                            if (playingSkill == 6 || playingSkill == 7 || playingSkill == 8 || playingSkill == 10 || playingSkill == 11 || playingSkill == 18 || playingSkill == 25 || playingSkill == 26 || playingSkill == 35 || playingSkill == 36 || playingSkill == 42)
                            {
                                if (chitalkaTarget1 != null)
                                {
                                    udar.transform.position = slot8GGsvet.transform.position;
                                    udar.SetActive(true);
                                }
                                if (chitalkaTarget2 != null)
                                {
                                    udar2.transform.position = slot8GGsvet.transform.position;
                                    udar2.SetActive(true);
                                }
                                if (chitalkaTarget3 != null)
                                {
                                    udar3.transform.position = slot8GGsvet.transform.position;
                                    udar3.SetActive(true);
                                }
                            }
                            if (playingSkill == 1 || playingSkill == 2 || playingSkill == 3 || playingSkill == 13 || playingSkill == 14 || playingSkill == 16 || playingSkill == 17 || playingSkill == 21 || playingSkill == 22 || playingSkill == 23 || playingSkill == 30 || playingSkill == 32 || playingSkill == 33 || playingSkill == 34 || playingSkill == 40 || playingSkill == 43 || playingSkill == 31 || playingSkill == 28)
                            {
                                
                                if (chitalkaTarget1 != null)
                                {
                                    udarus.transform.position = slot8GGsvet.transform.position;
                                    udarus.SetActive(true);
                                    attak.Play(0);
                                }
                                if (chitalkaTarget2 != null)
                                {
                                    udarus2.transform.position = slot8GGsvet.transform.position;
                                    udarus2.SetActive(true);
                                }
                                if (chitalkaTarget3 != null)
                                {
                                    udarus3.transform.position = slot8GGsvet.transform.position;
                                    udarus3.SetActive(true);
                                }
                            }
                        }
                    }
                    else // если заблокирован, цели = нулл
                    {
                        chitalkaTarget1 = null;
                        chitalkaTarget2 = null;
                        chitalkaTarget3 = null;
                        playingSkill = 0;
                        timerHoda = 0.1f;
                    }


                    animation_bol = true;
                }
                else if (pervohod == 2 || (slot8GGpohodil == true && slot8Vragpohodil == false))
                {
                    obnuliator();
                    slot8Vragsvet.SetActive(true);

                    udarus.transform.eulerAngles = new Vector3(0f, 0f, 0f);

                    udarus2.transform.eulerAngles = new Vector3(0f, 0f, 0f);

                    udarus3.transform.eulerAngles = new Vector3(0f, 0f, 0f);
                    if (mermenreader.slot8zablokVraga == false && slotsmerman.slo8Hp != 0f)
                    {
                        chitalkaTarget1 = skreader.slot8targetVr1;
                        chitalkaTarget2 = skreader.slot8targetVr2;
                        chitalkaTarget3 = skreader.slot8targetVr3;
                        playingSkill = skreader.slot8skillVraga;
                        // если не чисто блок или антиблок
                        if (playingSkill != 4 && playingSkill != 5 && playingSkill != 9 && playingSkill != 12 && playingSkill != 15 && playingSkill != 19 && playingSkill != 24 && playingSkill != 27 && playingSkill != 29 && playingSkill != 37 && playingSkill != 38 && playingSkill != 39)
                        {
                            if (playingSkill == 6 || playingSkill == 7 || playingSkill == 8 || playingSkill == 10 || playingSkill == 11 || playingSkill == 18 || playingSkill == 25 || playingSkill == 26 || playingSkill == 35 || playingSkill == 36 || playingSkill == 42)
                            {
                                if (chitalkaTarget1 != null)
                                {
                                    udar.transform.position = slot8Vragsvet.transform.position;
                                    udar.SetActive(true);
                                }
                                if (chitalkaTarget2 != null)
                                {
                                    udar2.transform.position = slot8Vragsvet.transform.position;
                                    udar2.SetActive(true);
                                }
                                if (chitalkaTarget3 != null)
                                {
                                    udar3.transform.position = slot8Vragsvet.transform.position;
                                    udar3.SetActive(true);
                                }
                            }
                            if (playingSkill == 1 || playingSkill == 2 || playingSkill == 3 || playingSkill == 13 || playingSkill == 14 || playingSkill == 16 || playingSkill == 17 || playingSkill == 21 || playingSkill == 22 || playingSkill == 23 || playingSkill == 30 || playingSkill == 32 || playingSkill == 33 || playingSkill == 34 || playingSkill == 40 || playingSkill == 43 || playingSkill == 31 || playingSkill == 28)
                            {
                                
                                if (chitalkaTarget1 != null)
                                {
                                    udarus.transform.position = slot8Vragsvet.transform.position;
                                    udarus.SetActive(true);
                                    attak.Play(0);
                                }
                                if (chitalkaTarget2 != null)
                                {
                                    udarus2.transform.position = slot8Vragsvet.transform.position;
                                    udarus2.SetActive(true);
                                }
                                if (chitalkaTarget3 != null)
                                {
                                    udarus3.transform.position = slot8Vragsvet.transform.position;
                                    udarus3.SetActive(true);
                                }
                            }
                        }
                    }
                    else // если заблокирован, цели = нулл
                    {
                        chitalkaTarget1 = null;
                        chitalkaTarget2 = null;
                        chitalkaTarget3 = null;
                        playingSkill = 0;
                        timerHoda = 0.1f;
                    }

                    animation_bol = true;
                }
            }

            if (timerHoda < 0 && slot8GGsvet.activeSelf == true && animation_bol == false)
            {
                //slot5Vragtoxins.SetActive(false);
                toxinsCheker();
                slot8GGpohodil = true;
                timerHoda = 1.7f;
            }
            else if (timerHoda < 0 && slot8Vragsvet.activeSelf == true && animation_bol == false)
            {
                //slot5GGtoxins.SetActive(false);
                toxinsCheker();
                slot8Vragpohodil = true;
                timerHoda = 1.7f;
            }
            if (timerHoda == 1 && slot8GGpohodil == true && slot8Vragpohodil == true && (slot9GGpohodil == false || slot9Vragpohodil == false))
            {
                timerHoda -= 0.1f; // это читается только раз
                if ((pervohod == 1 && slot9GGpohodil == false) || (slot9Vragpohodil == true && slot9GGpohodil == false))
                {
                    obnuliator();
                    slot9GGsvet.SetActive(true);

                    udarus.transform.eulerAngles = new Vector3(0f, 0f, 180f);

                    udarus2.transform.eulerAngles = new Vector3(0f, 0f, 180f);

                    udarus3.transform.eulerAngles = new Vector3(0f, 0f, 180f);
                    if (mermenreader.slot9zablokirovan == false && slotsgg.slot9Hp != 0f)
                    {
                        chitalkaTarget1 = skreader.slot9target1;
                        chitalkaTarget2 = skreader.slot9target2;
                        chitalkaTarget3 = skreader.slot9target3;
                        playingSkill = skreader.slot9skill;
                        // если не чисто блок или антиблок
                        if (playingSkill != 4 && playingSkill != 5 && playingSkill != 9 && playingSkill != 12 && playingSkill != 15 && playingSkill != 19 && playingSkill != 24 && playingSkill != 27 && playingSkill != 29 && playingSkill != 37 && playingSkill != 38 && playingSkill != 39)
                        {
                            if (playingSkill == 6 || playingSkill == 7 || playingSkill == 8 || playingSkill == 10 || playingSkill == 11 || playingSkill == 18 || playingSkill == 25 || playingSkill == 26 || playingSkill == 35 || playingSkill == 36 || playingSkill == 42)
                            {
                                if (chitalkaTarget1 != null)
                                {
                                    udar.transform.position = slot9GGsvet.transform.position;
                                    udar.SetActive(true);
                                }
                                if (chitalkaTarget2 != null)
                                {
                                    udar2.transform.position = slot9GGsvet.transform.position;
                                    udar2.SetActive(true);
                                }
                                if (chitalkaTarget3 != null)
                                {
                                    udar3.transform.position = slot9GGsvet.transform.position;
                                    udar3.SetActive(true);
                                }
                            }
                            if (playingSkill == 1 || playingSkill == 2 || playingSkill == 3 || playingSkill == 13 || playingSkill == 14 || playingSkill == 16 || playingSkill == 17 || playingSkill == 21 || playingSkill == 22 || playingSkill == 23 || playingSkill == 30 || playingSkill == 32 || playingSkill == 33 || playingSkill == 34 || playingSkill == 40 || playingSkill == 43 || playingSkill == 31 || playingSkill == 28)
                            {
                                
                                if (chitalkaTarget1 != null)
                                {
                                    udarus.transform.position = slot9GGsvet.transform.position;
                                    udarus.SetActive(true);
                                    attak.Play(0);
                                }
                                if (chitalkaTarget2 != null)
                                {
                                    udarus2.transform.position = slot9GGsvet.transform.position;
                                    udarus2.SetActive(true);
                                }
                                if (chitalkaTarget3 != null)
                                {
                                    udarus3.transform.position = slot9GGsvet.transform.position;
                                    udarus3.SetActive(true);
                                }
                            }
                        }
                    }
                    else // если заблокирован, цели = нулл
                    {
                        chitalkaTarget1 = null;
                        chitalkaTarget2 = null;
                        chitalkaTarget3 = null;
                        playingSkill = 0;
                        timerHoda = 0.1f;
                    }
                    animation_bol = true;
                }
                else if (pervohod == 2 || (slot9GGpohodil == true && slot9Vragpohodil == false))
                {
                    obnuliator();
                    slot9Vragsvet.SetActive(true);

                    udarus.transform.eulerAngles = new Vector3(0f, 0f, 0f);

                    udarus2.transform.eulerAngles = new Vector3(0f, 0f, 0f);

                    udarus3.transform.eulerAngles = new Vector3(0f, 0f, 0f);
                    if (mermenreader.slot9zablokVraga == false && slotsmerman.slo9Hp != 0f)
                    {
                        chitalkaTarget1 = skreader.slot9targetVr1;
                        chitalkaTarget2 = skreader.slot9targetVr2;
                        chitalkaTarget3 = skreader.slot9targetVr3;
                        playingSkill = skreader.slot9skillVraga;
                        // если не чисто блок или антиблок
                        if (playingSkill != 4 && playingSkill != 5 && playingSkill != 9 && playingSkill != 12 && playingSkill != 15 && playingSkill != 19 && playingSkill != 24 && playingSkill != 27 && playingSkill != 29 && playingSkill != 37 && playingSkill != 38 && playingSkill != 39)
                        {
                            if (playingSkill == 6 || playingSkill == 7 || playingSkill == 8 || playingSkill == 10 || playingSkill == 11 || playingSkill == 18 || playingSkill == 25 || playingSkill == 26 || playingSkill == 35 || playingSkill == 36 || playingSkill == 42)
                            {
                                if (chitalkaTarget1 != null)
                                {
                                    udar.transform.position = slot9Vragsvet.transform.position;
                                    udar.SetActive(true);
                                }
                                if (chitalkaTarget2 != null)
                                {
                                    udar2.transform.position = slot9Vragsvet.transform.position;
                                    udar2.SetActive(true);
                                }
                                if (chitalkaTarget3 != null)
                                {
                                    udar3.transform.position = slot9Vragsvet.transform.position;
                                    udar3.SetActive(true);
                                }
                            }
                            if (playingSkill == 1 || playingSkill == 2 || playingSkill == 3 || playingSkill == 13 || playingSkill == 14 || playingSkill == 16 || playingSkill == 17 || playingSkill == 21 || playingSkill == 22 || playingSkill == 23 || playingSkill == 30 || playingSkill == 32 || playingSkill == 33 || playingSkill == 34 || playingSkill == 40 || playingSkill == 43 || playingSkill == 31 || playingSkill == 28)
                            {
                               
                                if (chitalkaTarget1 != null)
                                {
                                    udarus.transform.position = slot9Vragsvet.transform.position;
                                    udarus.SetActive(true);
                                    attak.Play(0);
                                }
                                if (chitalkaTarget2 != null)
                                {
                                    udarus2.transform.position = slot9Vragsvet.transform.position;
                                    udarus2.SetActive(true);
                                }
                                if (chitalkaTarget3 != null)
                                {
                                    udarus3.transform.position = slot9Vragsvet.transform.position;
                                    udarus3.SetActive(true);
                                }
                            }
                        }
                    }
                    else // если заблокирован, цели = нулл
                    {
                        chitalkaTarget1 = null;
                        chitalkaTarget2 = null;
                        chitalkaTarget3 = null;
                        playingSkill = 0;
                        timerHoda = 0.1f;
                    }
                    animation_bol = true;
                }
            }

            if (timerHoda < 0 && slot9GGsvet.activeSelf == true && animation_bol == false)
            {
                toxinsCheker();
                slot9GGpohodil = true;
                timerHoda = 1.7f;
            }
            else if (timerHoda < 0 && slot9Vragsvet.activeSelf == true && animation_bol == false)
            {
                toxinsCheker();
                slot9Vragpohodil = true;
                timerHoda = 1.7f;
            }








            // После прочтения 9 слота вызывается результат
            if (slot9GGpohodil == true && slot9Vragpohodil == true)
            {
               // slot7Vragtoxins.SetActive(false);
               // slot7GGtoxins.SetActive(false);
               // slot8Vragtoxins.SetActive(false);
              //  slot8GGtoxins.SetActive(false);
              //  slot9Vragtoxins.SetActive(false);
               // slot9GGtoxins.SetActive(false);
                obnuliator();
                playEnded.resultMode = true;
                hpustanovleny = false;
            }
        }
    }



    public void toxinsCheker()
    {


        if (slot1GGtoxins.activeSelf == true && slotsgg.slot1Hp > 0 && otrava1 < 13)
        {
            slotsgg.slot1Hp -= 1f;
        }
        if (slot2GGtoxins.activeSelf == true && slotsgg.slot2Hp > 0 && otrava2 < 13)
        {
            slotsgg.slot2Hp -= 1f;
        }
        if (slot3GGtoxins.activeSelf == true && slotsgg.slot3Hp > 0 && otrava3 < 13)
        {
            slotsgg.slot3Hp -= 1f;
        }
        if (slot4GGtoxins.activeSelf == true && slotsgg.slot4Hp > 0 && otrava4 < 13)
        {
            slotsgg.slot4Hp -= 1f;
        }
        if (slot5GGtoxins.activeSelf == true && slotsgg.slot5Hp > 0 && otrava5 < 13)
        {
            slotsgg.slot5Hp -= 1f;

        }
        if (slot6GGtoxins.activeSelf == true && slotsgg.slot6Hp > 0 && otrava6 < 13)
        {
            slotsgg.slot6Hp -= 1f;

        }
        if (slot7GGtoxins.activeSelf == true && slotsgg.slot7Hp > 0 && otrava7 < 13)
        {
            slotsgg.slot7Hp -= 1f;

        }
        if (slot8GGtoxins.activeSelf == true && slotsgg.slot8Hp > 0 && otrava8 < 13)
        {
            slotsgg.slot8Hp -= 1f;

        }
        if (slot9GGtoxins.activeSelf == true && slotsgg.slot9Hp > 0 && otrava9 < 13)
        {
            slotsgg.slot9Hp -= 1f;

        }
        if (slot1Vragtoxins.activeSelf == true && slotsmerman.slo1Hp > 0 && otrava10 < 13)
        {
            slotsmerman.slo1Hp -= 1f;

        }
        if (slot2Vragtoxins.activeSelf == true && slotsmerman.slo2Hp > 0 && otrava11 < 13)
        {
            slotsmerman.slo2Hp -= 1f;

        }
        if (slot3Vragtoxins.activeSelf == true && slotsmerman.slo3Hp > 0 && otrava12 < 13)
        {
            slotsmerman.slo3Hp -= 1f;

        }
        if (slot4Vragtoxins.activeSelf == true && slotsmerman.slo4Hp > 0 && otrava13 < 13)
        {
            slotsmerman.slo4Hp -= 1f;

        }
        if (slot5Vragtoxins.activeSelf == true && slotsmerman.slo5Hp > 0 && otrava14 < 13)
        {
            slotsmerman.slo5Hp -= 1f;

        }
        if (slot6Vragtoxins.activeSelf == true && slotsmerman.slo6Hp > 0 && otrava15 < 13)
        {
            slotsmerman.slo6Hp -= 1f;

        }
        if (slot7Vragtoxins.activeSelf == true && slotsmerman.slo7Hp > 0 && otrava16 < 13)
        {
            slotsmerman.slo7Hp -= 1f;

        }
        if (slot8Vragtoxins.activeSelf == true && slotsmerman.slo8Hp > 0 && otrava17 < 13)
        {
            slotsmerman.slo8Hp -= 1f;

        }
        if (slot9Vragtoxins.activeSelf == true && slotsmerman.slo9Hp > 0 && otrava18 < 13)
        {
            slotsmerman.slo9Hp -= 1f;

        }

        otrava1 += 1;
        otrava2 += 1;
        otrava3 += 1;
        otrava4 += 1;
        otrava5 += 1;
        otrava6 += 1;
        otrava7 += 1;
        otrava8 += 1;
        otrava9 += 1;
        otrava10 += 1;
        otrava11 += 1;
        otrava12 += 1;
        otrava13 += 1;
        otrava14 += 1;
        otrava15 += 1;
        otrava16 += 1;
        otrava17 += 1;
        otrava18 += 1;



        if (otrava1 >= 13)
        {
            slot1GGtoxins.SetActive(false);
            otrava1 = 0;
        }
        if (otrava2 >= 13)
        {
            slot2GGtoxins.SetActive(false);
            otrava2 = 0;
        }
        if (otrava3 >= 13)
        {
            slot3GGtoxins.SetActive(false);
            otrava3 = 0;
        }
        if (otrava4 >= 13)
        {
            slot4GGtoxins.SetActive(false);
            otrava4 = 0;
        }
        if (otrava5 >= 13)
        {
            slot5GGtoxins.SetActive(false);
            otrava5 = 0;
        }
        if (otrava6 >= 13)
        {
            slot6GGtoxins.SetActive(false);
            otrava6 = 0;
        }
        if (otrava7 >= 13)
        {
            slot7GGtoxins.SetActive(false);
            otrava7 = 0;
        }
        if (otrava8 >= 13)
        {
            slot8GGtoxins.SetActive(false);
            otrava8 = 0;
        }
        if (otrava9 >= 13)
        {
            slot9GGtoxins.SetActive(false);
            otrava9 = 0;
        }
        if (otrava10 >= 13)
        {
            slot1Vragtoxins.SetActive(false);
            otrava10 = 0;
        }
        if (otrava11 >= 13)
        {
            slot2Vragtoxins.SetActive(false);
            otrava11 = 0;
        }
        if (otrava12 >= 13)
        {
            slot3Vragtoxins.SetActive(false);
            otrava12 = 0;
        }
        if (otrava13 >= 13)
        {
            slot4Vragtoxins.SetActive(false);
            otrava13 = 0;
        }
        if (otrava14 >= 13)
        {
            slot5Vragtoxins.SetActive(false);
            otrava14 = 0;
        }
        if (otrava15 >= 13)
        {
            slot6Vragtoxins.SetActive(false);
            otrava15 = 0;
        }
        if (otrava16 >= 13)
        {
            slot7Vragtoxins.SetActive(false);
            otrava16 = 0;
        }
        if (otrava17 >= 13)
        {
            slot8Vragtoxins.SetActive(false);
            otrava17 = 0;
        }
        if (otrava18 >= 13)
        {
            slot9Vragtoxins.SetActive(false);
            otrava18 = 0;
        }
    }

    public void chitalkaBattle()
    {

        if (playingSkill == 21)
        {
            // хилл
            if (chitalkaTarget1 == skreader.slotGG1 && skreader.slot1skill != 0)
            {

                if (skreader.slot1skill != 20)
                {
                    slotsgg.slot1Hp += 1f;
                }
            }
            if (chitalkaTarget1 == skreader.slotGG2 && skreader.slot2skill != 0)
            {
                slotsgg.slot2Hp += 1f;
            }
            if (chitalkaTarget1 == skreader.slotGG3 && skreader.slot3skill != 0)
            {

                if (skreader.slot3skill != 20)
                {
                    slotsgg.slot3Hp += 1f;
                }
            }
            if (chitalkaTarget1 == skreader.slotGG4 && skreader.slot4skill != 0)
            {
                if (skreader.slot4skill != 41)
                {
                    slotsgg.slot4Hp += 1f;
                }
            }

            if (chitalkaTarget1 == skreader.slotGG5 && skreader.slot5skill != 0)
            {
                slotsgg.slot5Hp += 1f;
            }

            if (chitalkaTarget1 == skreader.slotGG6 && skreader.slot6skill != 0)
            {

                if (skreader.slot6skill != 20 && skreader.slot6skill != 41)
                {
                    slotsgg.slot6Hp += 1f;
                }
            }

            if (chitalkaTarget1 == skreader.slotGG7 && skreader.slot7skill != 0)
            {
                if (skreader.slot7skill != 41)
                {
                    slotsgg.slot7Hp += 1f;
                }
            }

            if (chitalkaTarget1 == skreader.slotGG8 && skreader.slot8skill != 0)
            {
                if (skreader.slot8skill != 41)
                {
                    slotsgg.slot8Hp += 1f;
                }
            }

            if (chitalkaTarget1 == skreader.slotGG9 && skreader.slot9skill != 0)
            {
                if (skreader.slot9skill != 41)
                {
                    slotsgg.slot9Hp += 1f;
                }
            }

            if (chitalkaTarget1 == skreader.slotVraga1 && skreader.slot1skillVraga != 0)
            {
                if (skreader.slot1skillVraga != 20)
                {
                    slotsmerman.slo1Hp += 1f;
                }
            }

            if (chitalkaTarget1 == skreader.slotVraga2 && skreader.slot2skillVraga != 0)
            {
                slotsmerman.slo2Hp += 1f;
            }

            if (chitalkaTarget1 == skreader.slotVraga3 && skreader.slot3skillVraga != 0)
            {
                if (skreader.slot3skillVraga != 20)
                {
                    slotsmerman.slo3Hp += 1f;
                }
            }

            if (chitalkaTarget1 == skreader.slotVraga4 && skreader.slot4skillVraga != 0)
            {
                if (skreader.slot4skillVraga != 41)
                {
                    slotsmerman.slo4Hp += 1f;
                }
            }

            if (chitalkaTarget1 == skreader.slotVraga5 && skreader.slot5skillVraga != 0)
            {
                slotsmerman.slo5Hp += 1f;
            }

            if (chitalkaTarget1 == skreader.slotVraga6 && skreader.slot6skillVraga != 0)
            {
                if (skreader.slot6skillVraga != 20 && skreader.slot6skillVraga != 41)
                {
                    slotsmerman.slo6Hp += 1f;
                }
            }

            if (chitalkaTarget1 == skreader.slotVraga7 && skreader.slot7skillVraga != 0)
            {
                if (skreader.slot7skillVraga != 41)
                {
                    slotsmerman.slo7Hp += 1f;
                }
            }

            if (chitalkaTarget1 == skreader.slotVraga8 && skreader.slot8skillVraga != 0)
            {
                if (skreader.slot8skillVraga != 41)
                {
                    slotsmerman.slo8Hp += 1f;
                }
            }

            if (chitalkaTarget1 == skreader.slotVraga9 && skreader.slot9skillVraga != 0)
            {
                if (skreader.slot9skillVraga != 41)
                {
                    slotsmerman.slo9Hp += 1f;
                }
            }

            // атака потом, реакции ловушек
            if (chitalkaTarget2 == skreader.slotGG1 && skreader.slot1skill != 0)
            {
                lovushkaProverka();
                slotsgg.slot1Hp -= 1f;
            }
            if (chitalkaTarget2 == skreader.slotGG2 && skreader.slot2skill != 0)
            {
                lovushkaProverka();
                slotsgg.slot2Hp -= 1f;
            }
            if (chitalkaTarget2 == skreader.slotGG3 && skreader.slot3skill != 0)
            {
                lovushkaProverka();
                slotsgg.slot3Hp -= 1f;
            }
            if (chitalkaTarget2 == skreader.slotGG4 && skreader.slot4skill != 0)
            {
                lovushkaProverka();
                slotsgg.slot4Hp -= 1f;
            }
 
            if (chitalkaTarget2 == skreader.slotGG5 && skreader.slot5skill != 0)
            {
                lovushkaProverka();
                slotsgg.slot5Hp -= 1f;
            }
 
            if (chitalkaTarget2 == skreader.slotGG6 && skreader.slot6skill != 0)
            {
                lovushkaProverka();
                slotsgg.slot6Hp -= 1f;
            }

            if (chitalkaTarget2 == skreader.slotGG7 && skreader.slot7skill != 0)
            {
                lovushkaProverka();
                slotsgg.slot7Hp -= 1f;
            }

            if (chitalkaTarget2 == skreader.slotGG8 && skreader.slot8skill != 0)
            {
                lovushkaProverka();
                slotsgg.slot8Hp -= 1f;
            }
 
            if (chitalkaTarget2 == skreader.slotGG9 && skreader.slot9skill != 0)
            {
                lovushkaProverka();
                slotsgg.slot9Hp -= 1f;
            }

            if (chitalkaTarget2 == skreader.slotVraga1 && skreader.slot1skillVraga != 0)
            {
                lovushkaProverka();
                slotsmerman.slo1Hp -= 1f;
            }
 
            if (chitalkaTarget2 == skreader.slotVraga2 && skreader.slot2skillVraga != 0)
            {
                lovushkaProverka();
                slotsmerman.slo2Hp -= 1f;
            }

            if (chitalkaTarget2 == skreader.slotVraga3 && skreader.slot3skillVraga != 0)
            {
                lovushkaProverka();
                slotsmerman.slo3Hp -= 1f;
            }

            if (chitalkaTarget2 == skreader.slotVraga4 && skreader.slot4skillVraga != 0)
            {
                lovushkaProverka();
                slotsmerman.slo4Hp -= 1f;
            }
 
            if (chitalkaTarget2 == skreader.slotVraga5 && skreader.slot5skillVraga != 0)
            {
                lovushkaProverka();
                slotsmerman.slo5Hp -= 1f;
            }
  
            if (chitalkaTarget2 == skreader.slotVraga6 && skreader.slot6skillVraga != 0)
            {
                lovushkaProverka();
                slotsmerman.slo6Hp -= 1f;
            }
 
            if (chitalkaTarget2 == skreader.slotVraga7 && skreader.slot7skillVraga != 0)
            {
                lovushkaProverka();
                slotsmerman.slo7Hp -= 1f;
            }
 
            if (chitalkaTarget2 == skreader.slotVraga8 && skreader.slot8skillVraga != 0)
            {
                lovushkaProverka();
                slotsmerman.slo8Hp -= 1f;
            }
 
            if (chitalkaTarget2 == skreader.slotVraga9 && skreader.slot9skillVraga != 0)
            {
                lovushkaProverka();
                slotsmerman.slo9Hp -= 1f;
            }



        }
        else if (playingSkill == 1 || playingSkill == 2 || playingSkill == 3 || playingSkill == 13 || playingSkill == 14 || playingSkill == 16 || playingSkill == 17 || playingSkill == 22 || playingSkill == 23 || playingSkill == 30 || playingSkill == 32 || playingSkill == 33 || playingSkill == 34 || playingSkill == 40 || playingSkill == 43 || playingSkill == 28 || playingSkill == 31) // навык 1 или любая атака?
        {
            // если мишень - слот гг
            if (chitalkaTarget1 == skreader.slotGG1 && skreader.slot1skill != 0)
            {
                lovushkaProverka();
                slotsgg.slot1Hp -= 1f;
                if(playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot1GGtoxins.SetActive(true);
                    otrava1 = 0;
                }
            }
            if (chitalkaTarget2 == skreader.slotGG1 && skreader.slot1skill != 0)
            {
                lovushkaProverka();
                slotsgg.slot1Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot1GGtoxins.SetActive(true);
                    otrava1 = 0;
                }
            }
            if (chitalkaTarget3 == skreader.slotGG1 && skreader.slot1skill != 0)
            {
                lovushkaProverka();
                slotsgg.slot1Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot1GGtoxins.SetActive(true);
                    otrava1 = 0;
                }
            }
            if (chitalkaTarget1 == skreader.slotGG2 && skreader.slot2skill != 0)
            {
                lovushkaProverka();
                slotsgg.slot2Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot2GGtoxins.SetActive(true);
                    otrava2 = 0;
                }
            }
            if (chitalkaTarget2 == skreader.slotGG2 && skreader.slot2skill != 0)
            {
                lovushkaProverka();
                slotsgg.slot2Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot2GGtoxins.SetActive(true);
                    otrava2 = 0;
                }
            }
            if (chitalkaTarget3 == skreader.slotGG2 && skreader.slot2skill != 0)
            {
                lovushkaProverka();
                slotsgg.slot2Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot2GGtoxins.SetActive(true);
                    otrava2 = 0;
                }
            }
            if (chitalkaTarget1 == skreader.slotGG3 && skreader.slot3skill != 0)
            {
                lovushkaProverka();
                slotsgg.slot3Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot3GGtoxins.SetActive(true);
                    otrava3 = 0;
                }
            }
            if (chitalkaTarget2 == skreader.slotGG3 && skreader.slot3skill != 0)
            {
                lovushkaProverka();
                slotsgg.slot3Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot3GGtoxins.SetActive(true);
                    otrava3 = 0;
                }
            }
            if (chitalkaTarget3 == skreader.slotGG3 && skreader.slot3skill != 0)
            {
                lovushkaProverka();
                slotsgg.slot3Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot3GGtoxins.SetActive(true);
                    otrava3 = 0;
                }
            }
            if (chitalkaTarget1 == skreader.slotGG4 && skreader.slot4skill != 0)
            {
                lovushkaProverka();
                slotsgg.slot4Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot4GGtoxins.SetActive(true);
                    otrava4 = 0;
                }
            }
            if (chitalkaTarget2 == skreader.slotGG4 && skreader.slot4skill != 0)
            {
                lovushkaProverka();
                slotsgg.slot4Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot4GGtoxins.SetActive(true);
                    otrava4 = 0;
                }
            }
            if (chitalkaTarget3 == skreader.slotGG4 && skreader.slot4skill != 0)
            {
                lovushkaProverka();
                slotsgg.slot4Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot4GGtoxins.SetActive(true);
                    otrava4 = 0;
                }
            }
            if (chitalkaTarget1 == skreader.slotGG5 && skreader.slot5skill != 0)
            {
                lovushkaProverka();
                slotsgg.slot5Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot5GGtoxins.SetActive(true);
                    otrava5 = 0;
                }
            }
            if (chitalkaTarget2 == skreader.slotGG5 && skreader.slot5skill != 0)
            {
                lovushkaProverka();
                slotsgg.slot5Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot5GGtoxins.SetActive(true);
                    otrava5 = 0;
                }
            }
            if (chitalkaTarget3 == skreader.slotGG5 && skreader.slot5skill != 0)
            {
                lovushkaProverka();
                slotsgg.slot5Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot5GGtoxins.SetActive(true);
                    otrava5 = 0;
                }
            }
            if (chitalkaTarget1 == skreader.slotGG6 && skreader.slot6skill != 0)
            {
                lovushkaProverka();
                slotsgg.slot6Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot6GGtoxins.SetActive(true);
                    otrava6 = 0;
                }
            }
            if (chitalkaTarget2 == skreader.slotGG6 && skreader.slot6skill != 0)
            {
                lovushkaProverka();
                slotsgg.slot6Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot6GGtoxins.SetActive(true);
                    otrava6 = 0;
                }
            }
            if (chitalkaTarget3 == skreader.slotGG6 && skreader.slot6skill != 0)
            {
                lovushkaProverka();
                slotsgg.slot6Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot6GGtoxins.SetActive(true);
                    otrava6 = 0;
                }
            }
            if (chitalkaTarget1 == skreader.slotGG7 && skreader.slot7skill != 0)
            {
                lovushkaProverka();
                slotsgg.slot7Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot7GGtoxins.SetActive(true);
                    otrava7 = 0;
                }
            }
            if (chitalkaTarget2 == skreader.slotGG7 && skreader.slot7skill != 0)
            {
                lovushkaProverka();
                slotsgg.slot7Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot7GGtoxins.SetActive(true);
                    otrava7 = 0;
                }
            }
            if (chitalkaTarget3 == skreader.slotGG7 && skreader.slot7skill != 0)
            {
                lovushkaProverka();
                slotsgg.slot7Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot7GGtoxins.SetActive(true);
                    otrava7 = 0;
                }
            }
            if (chitalkaTarget1 == skreader.slotGG8 && skreader.slot8skill != 0)
            {
                lovushkaProverka();
                slotsgg.slot8Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot8GGtoxins.SetActive(true);
                    otrava8 = 0;
                }
            }
            if (chitalkaTarget2 == skreader.slotGG8 && skreader.slot8skill != 0)
            {
                lovushkaProverka();
                slotsgg.slot8Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot8GGtoxins.SetActive(true);
                    otrava8 = 0;
                }
            }
            if (chitalkaTarget3 == skreader.slotGG8 && skreader.slot8skill != 0)
            {
                lovushkaProverka();
                slotsgg.slot8Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot8GGtoxins.SetActive(true);
                    otrava8 = 0;
                }
            }
            if (chitalkaTarget1 == skreader.slotGG9 && skreader.slot9skill != 0)
            {
                lovushkaProverka();
                slotsgg.slot9Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot9GGtoxins.SetActive(true);
                    otrava9 = 0;
                }
            }
            if (chitalkaTarget2 == skreader.slotGG9 && skreader.slot9skill != 0)
            {
                lovushkaProverka();
                slotsgg.slot9Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot9GGtoxins.SetActive(true);
                    otrava9 = 0;
                }
            }
            if (chitalkaTarget3 == skreader.slotGG9 && skreader.slot9skill != 0)
            {
                lovushkaProverka();
                slotsgg.slot9Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot9GGtoxins.SetActive(true);
                    otrava9 = 0;
                }
            }
            // если мишень - слот врага
            if (chitalkaTarget1 == skreader.slotVraga1 && skreader.slot1skillVraga != 0)
            {
                lovushkaProverka();
                slotsmerman.slo1Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot1Vragtoxins.SetActive(true);
                    otrava10 = 0;
                }
            }
            if (chitalkaTarget2 == skreader.slotVraga1 && skreader.slot1skillVraga != 0)
            {
                lovushkaProverka();
                slotsmerman.slo1Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot1Vragtoxins.SetActive(true);
                    otrava10 = 0;
                }
            }
            if (chitalkaTarget3 == skreader.slotVraga1 && skreader.slot1skillVraga != 0)
            {
                lovushkaProverka();
                slotsmerman.slo1Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot1Vragtoxins.SetActive(true);
                    otrava10 = 0;
                }
            }
            if (chitalkaTarget1 == skreader.slotVraga2 && skreader.slot2skillVraga != 0)
            {
                lovushkaProverka();
                slotsmerman.slo2Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot2Vragtoxins.SetActive(true);
                    otrava11 = 0;
                }
            }
            if (chitalkaTarget2 == skreader.slotVraga2 && skreader.slot2skillVraga != 0)
            {
                lovushkaProverka();
                slotsmerman.slo2Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot2Vragtoxins.SetActive(true);
                    otrava11 = 0;
                }
            }
            if (chitalkaTarget3 == skreader.slotVraga2 && skreader.slot2skillVraga != 0)
            {
                lovushkaProverka();
                slotsmerman.slo2Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot2Vragtoxins.SetActive(true);
                    otrava11 = 0;
                }
            }
            if (chitalkaTarget1 == skreader.slotVraga3 && skreader.slot3skillVraga != 0)
            {
                lovushkaProverka();
                slotsmerman.slo3Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot3Vragtoxins.SetActive(true);
                    otrava12 = 0;
                }
            }
            if (chitalkaTarget2 == skreader.slotVraga3 && skreader.slot3skillVraga != 0)
            {
                lovushkaProverka();
                slotsmerman.slo3Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot3Vragtoxins.SetActive(true);
                    otrava12 = 0;
                }
            }
            if (chitalkaTarget3 == skreader.slotVraga3 && skreader.slot3skillVraga != 0)
            {
                lovushkaProverka();
                slotsmerman.slo3Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot3Vragtoxins.SetActive(true);
                    otrava12 = 0;
                }
            }
            if (chitalkaTarget1 == skreader.slotVraga4 && skreader.slot4skillVraga != 0)
            {
                lovushkaProverka();
                slotsmerman.slo4Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot4Vragtoxins.SetActive(true);
                    otrava13 = 0;
                }
            }
            if (chitalkaTarget2 == skreader.slotVraga4 && skreader.slot4skillVraga != 0)
            {
                lovushkaProverka();
                slotsmerman.slo4Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot4Vragtoxins.SetActive(true);
                    otrava13 = 0;
                }
            }
            if (chitalkaTarget3 == skreader.slotVraga4 && skreader.slot4skillVraga != 0)
            {
                lovushkaProverka();
                slotsmerman.slo4Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot4Vragtoxins.SetActive(true);
                    otrava13 = 0;
                }
            }
            if (chitalkaTarget1 == skreader.slotVraga5 && skreader.slot5skillVraga != 0)
            {
                lovushkaProverka();
                slotsmerman.slo5Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot5Vragtoxins.SetActive(true);
                    otrava14 = 0;
                }
            }
            if (chitalkaTarget2 == skreader.slotVraga5 && skreader.slot5skillVraga != 0)
            {
                lovushkaProverka();
                slotsmerman.slo5Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot5Vragtoxins.SetActive(true);
                    otrava14 = 0;
                }
            }
            if (chitalkaTarget3 == skreader.slotVraga5 && skreader.slot5skillVraga != 0)
            {
                lovushkaProverka();
                slotsmerman.slo5Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot5Vragtoxins.SetActive(true);
                    otrava14 = 0;
                }
            }
            if (chitalkaTarget1 == skreader.slotVraga6 && skreader.slot6skillVraga != 0)
            {
                lovushkaProverka();
                slotsmerman.slo6Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot6Vragtoxins.SetActive(true);
                    otrava15 = 0;
                }
            }
            if (chitalkaTarget2 == skreader.slotVraga6 && skreader.slot6skillVraga != 0)
            {
                lovushkaProverka();
                slotsmerman.slo6Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot6Vragtoxins.SetActive(true);
                    otrava15 = 0;
                }
            }
            if (chitalkaTarget3 == skreader.slotVraga6 && skreader.slot6skillVraga != 0)
            {
                lovushkaProverka();
                slotsmerman.slo6Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot6Vragtoxins.SetActive(true);
                    otrava15 = 0;
                }
            }
            if (chitalkaTarget1 == skreader.slotVraga7 && skreader.slot7skillVraga != 0)
            {
                lovushkaProverka();
                slotsmerman.slo7Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot7Vragtoxins.SetActive(true);
                    otrava16 = 0;
                }
            }
            if (chitalkaTarget2 == skreader.slotVraga7 && skreader.slot7skillVraga != 0)
            {
                lovushkaProverka();
                slotsmerman.slo7Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot7Vragtoxins.SetActive(true);
                    otrava16 = 0;
                }
            }
            if (chitalkaTarget3 == skreader.slotVraga7 && skreader.slot7skillVraga != 0)
            {
                lovushkaProverka();
                slotsmerman.slo7Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot7Vragtoxins.SetActive(true);
                    otrava16 = 0;
                }
            }
            if (chitalkaTarget1 == skreader.slotVraga8 && skreader.slot8skillVraga != 0)
            {
                lovushkaProverka();
                slotsmerman.slo8Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot8Vragtoxins.SetActive(true);
                    otrava17 = 0;
                }
            }
            if (chitalkaTarget2 == skreader.slotVraga8 && skreader.slot8skillVraga != 0)
            {
                lovushkaProverka();
                slotsmerman.slo8Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot8Vragtoxins.SetActive(true);
                    otrava17 = 0;
                }
            }
            if (chitalkaTarget3 == skreader.slotVraga8 && skreader.slot8skillVraga != 0)
            {
                lovushkaProverka();
                slotsmerman.slo8Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot8Vragtoxins.SetActive(true);
                    otrava17 = 0;
                }
            }
            if (chitalkaTarget1 == skreader.slotVraga9 && skreader.slot9skillVraga != 0)
            {
                lovushkaProverka();
                slotsmerman.slo9Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot9Vragtoxins.SetActive(true);
                    otrava18 = 0;
                }
            }
            if (chitalkaTarget2 == skreader.slotVraga9 && skreader.slot9skillVraga != 0)
            {
                lovushkaProverka();
                slotsmerman.slo9Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot9Vragtoxins.SetActive(true);
                    otrava18 = 0;
                }
            }
            if (chitalkaTarget3 == skreader.slotVraga9 && skreader.slot9skillVraga != 0)
            {
                lovushkaProverka();
                slotsmerman.slo9Hp -= 1f;
                if (playingSkill == 28 || playingSkill == 31) // если отрава
                {
                    slot9Vragtoxins.SetActive(true);
                    otrava18 = 0;
                }
            }
        }
        else if (playingSkill == 6 || playingSkill == 7 || playingSkill == 8 || playingSkill == 10 || playingSkill == 11 || playingSkill == 18 || playingSkill == 25 || playingSkill == 26 || playingSkill == 35 || playingSkill == 36 || playingSkill == 42) // любое исцеление
        {
            // если мишень - слот гг и он не пустой
            if (chitalkaTarget1 == skreader.slotGG1 && skreader.slot1skill != 0)
            {
                lovushkaProverka();
                if (skreader.slot1skill != 20)
                {
                    slotsgg.slot1Hp += 1f;
                }
            }
            if (chitalkaTarget2 == skreader.slotGG1 && skreader.slot1skill != 0)
            {
                lovushkaProverka();
                if (skreader.slot1skill != 20)
                {
                    slotsgg.slot1Hp += 1f;
                }
            }
            if (chitalkaTarget3 == skreader.slotGG1 && skreader.slot1skill != 0)
            {
                lovushkaProverka();
                if (skreader.slot1skill != 20)
                {
                    slotsgg.slot1Hp += 1f;
                }
            }
            if (chitalkaTarget1 == skreader.slotGG2 && skreader.slot2skill != 0)
            {
                lovushkaProverka();
                slotsgg.slot2Hp += 1f;
            }
            if (chitalkaTarget2 == skreader.slotGG2 && skreader.slot2skill != 0)
            {
                lovushkaProverka();
                slotsgg.slot2Hp += 1f;
            }
            if (chitalkaTarget3 == skreader.slotGG2 && skreader.slot2skill != 0)
            {
                lovushkaProverka();
                slotsgg.slot2Hp += 1f;
            }
            if (chitalkaTarget1 == skreader.slotGG3 && skreader.slot3skill != 0)
            {
                lovushkaProverka();
                if (skreader.slot3skill != 20)
                {
                    slotsgg.slot3Hp += 1f;
                }
            }
            if (chitalkaTarget2 == skreader.slotGG3 && skreader.slot3skill != 0)
            {
                lovushkaProverka();
                if (skreader.slot3skill != 20)
                {
                    slotsgg.slot3Hp += 1f;
                }
            }
            if (chitalkaTarget3 == skreader.slotGG3 && skreader.slot3skill != 0)
            {
                lovushkaProverka();
                if (skreader.slot3skill != 20)
                {
                    slotsgg.slot3Hp += 1f;
                }
            }
            if (chitalkaTarget1 == skreader.slotGG4 && skreader.slot4skill != 0)
            {
                lovushkaProverka();
                if (skreader.slot4skill != 41)
                {
                    slotsgg.slot4Hp += 1f;
                }
            }
            if (chitalkaTarget2 == skreader.slotGG4 && skreader.slot4skill != 0)
            {
                lovushkaProverka();
                if (skreader.slot4skill != 41)
                {
                    slotsgg.slot4Hp += 1f;
                }
            }
            if (chitalkaTarget3 == skreader.slotGG4 && skreader.slot4skill != 0)
            {
                lovushkaProverka();
                if (skreader.slot4skill != 41)
                {
                    slotsgg.slot4Hp += 1f;
                }
            }
            if (chitalkaTarget1 == skreader.slotGG5 && skreader.slot5skill != 0)
            {
                lovushkaProverka();
                slotsgg.slot5Hp += 1f;
            }
            if (chitalkaTarget2 == skreader.slotGG5 && skreader.slot5skill != 0)
            {
                lovushkaProverka();
                slotsgg.slot5Hp += 1f;
            }
            if (chitalkaTarget3 == skreader.slotGG5 && skreader.slot5skill != 0)
            {
                lovushkaProverka();
                slotsgg.slot5Hp += 1f;
            }
            if (chitalkaTarget1 == skreader.slotGG6 && skreader.slot6skill != 0)
            {
                lovushkaProverka();
                if (skreader.slot6skill != 20 && skreader.slot6skill != 41)
                {
                    slotsgg.slot6Hp += 1f;
                }
            }
            if (chitalkaTarget2 == skreader.slotGG6 && skreader.slot6skill != 0)
            {
                lovushkaProverka();
                if (skreader.slot6skill != 20 && skreader.slot6skill != 41)
                {
                    slotsgg.slot6Hp += 1f;
                }
            }
            if (chitalkaTarget3 == skreader.slotGG6 && skreader.slot6skill != 0)
            {
                lovushkaProverka();
                if (skreader.slot6skill != 20 && skreader.slot6skill != 41)
                {
                    slotsgg.slot6Hp += 1f;
                }
            }
            if (chitalkaTarget1 == skreader.slotGG7 && skreader.slot7skill != 0)
            {
                lovushkaProverka();
                if (skreader.slot7skill != 41)
                {
                    slotsgg.slot7Hp += 1f;
                }
            }
            if (chitalkaTarget2 == skreader.slotGG7 && skreader.slot7skill != 0)
            {
                lovushkaProverka();
                if (skreader.slot7skill != 41)
                {
                    slotsgg.slot7Hp += 1f;
                }
            }
            if (chitalkaTarget3 == skreader.slotGG7 && skreader.slot7skill != 0)
            {
                lovushkaProverka();
                if (skreader.slot7skill != 41)
                {
                    slotsgg.slot7Hp += 1f;
                }
            }
            if (chitalkaTarget1 == skreader.slotGG8 && skreader.slot8skill != 0)
            {
                lovushkaProverka();
                if (skreader.slot8skill != 41)
                {
                    slotsgg.slot8Hp += 1f;
                }
            }
            if (chitalkaTarget2 == skreader.slotGG8 && skreader.slot8skill != 0)
            {
                lovushkaProverka();
                if (skreader.slot8skill != 41)
                {
                    slotsgg.slot8Hp += 1f;
                }
            }
            if (chitalkaTarget3 == skreader.slotGG8 && skreader.slot8skill != 0)
            {
                lovushkaProverka();
                if (skreader.slot8skill != 41)
                {
                    slotsgg.slot8Hp += 1f;
                }
            }
            if (chitalkaTarget1 == skreader.slotGG9 && skreader.slot9skill != 0)
            {
                lovushkaProverka();
                if (skreader.slot9skill != 41)
                {
                    slotsgg.slot9Hp += 1f;
                }
            }
            if (chitalkaTarget2 == skreader.slotGG9 && skreader.slot9skill != 0)
            {
                lovushkaProverka();
                if (skreader.slot9skill != 41)
                {
                    slotsgg.slot9Hp += 1f;
                }
            }
            if (chitalkaTarget3 == skreader.slotGG9 && skreader.slot9skill != 0)
            {
                lovushkaProverka();
                if (skreader.slot9skill != 41)
                {
                    slotsgg.slot9Hp += 1f;
                }
            }
            // если мишень - слот врага
            if (chitalkaTarget1 == skreader.slotVraga1 && skreader.slot1skillVraga != 0)
            {
                lovushkaProverka();
                if (skreader.slot1skillVraga != 20)
                {
                    slotsmerman.slo1Hp += 1f;
                }
            }
            if (chitalkaTarget2 == skreader.slotVraga1 && skreader.slot1skillVraga != 0)
            {
                lovushkaProverka();
                if (skreader.slot1skillVraga != 20)
                {
                    slotsmerman.slo1Hp += 1f;
                }
            }
            if (chitalkaTarget3 == skreader.slotVraga1 && skreader.slot1skillVraga != 0)
            {
                lovushkaProverka();
                if (skreader.slot1skillVraga != 20)
                {
                    slotsmerman.slo1Hp += 1f;
                }
            }
            if (chitalkaTarget1 == skreader.slotVraga2 && skreader.slot2skillVraga != 0)
            {
                lovushkaProverka();
                slotsmerman.slo2Hp += 1f;
            }
            if (chitalkaTarget2 == skreader.slotVraga2 && skreader.slot2skillVraga != 0)
            {
                lovushkaProverka();
                slotsmerman.slo2Hp += 1f;
            }
            if (chitalkaTarget3 == skreader.slotVraga2 && skreader.slot2skillVraga != 0)
            {
                lovushkaProverka();
                slotsmerman.slo2Hp += 1f;
            }
            if (chitalkaTarget1 == skreader.slotVraga3 && skreader.slot3skillVraga != 0)
            {
                lovushkaProverka();
                if (skreader.slot3skillVraga != 20)
                {
                    slotsmerman.slo3Hp += 1f;
                }
            }
            if (chitalkaTarget2 == skreader.slotVraga3 && skreader.slot3skillVraga != 0)
            {
                lovushkaProverka();
                if (skreader.slot3skillVraga != 20)
                {
                    slotsmerman.slo3Hp += 1f;
                }
            }
            if (chitalkaTarget3 == skreader.slotVraga3 && skreader.slot3skillVraga != 0)
            {
                lovushkaProverka();
                if (skreader.slot3skillVraga != 20)
                {
                    slotsmerman.slo3Hp += 1f;
                }
            }
            if (chitalkaTarget1 == skreader.slotVraga4 && skreader.slot4skillVraga != 0)
            {
                lovushkaProverka();
                if (skreader.slot4skillVraga != 41)
                {
                    slotsmerman.slo4Hp += 1f;
                }
            }
            if (chitalkaTarget2 == skreader.slotVraga4 && skreader.slot4skillVraga != 0)
            {
                lovushkaProverka();
                if (skreader.slot4skillVraga != 41)
                {
                    slotsmerman.slo4Hp += 1f;
                }
            }
            if (chitalkaTarget3 == skreader.slotVraga4 && skreader.slot4skillVraga != 0)
            {
                lovushkaProverka();
                if (skreader.slot4skillVraga != 41)
                {
                    slotsmerman.slo4Hp += 1f;
                }
            }
            if (chitalkaTarget1 == skreader.slotVraga5 && skreader.slot5skillVraga != 0)
            {
                lovushkaProverka();
                slotsmerman.slo5Hp += 1f;
            }
            if (chitalkaTarget2 == skreader.slotVraga5 && skreader.slot5skillVraga != 0)
            {
                lovushkaProverka();
                slotsmerman.slo5Hp += 1f;
            }
            if (chitalkaTarget3 == skreader.slotVraga5 && skreader.slot5skillVraga != 0)
            {
                lovushkaProverka();
                slotsmerman.slo5Hp += 1f;
            }
            if (chitalkaTarget1 == skreader.slotVraga6 && skreader.slot6skillVraga != 0)
            {
                lovushkaProverka();
                if (skreader.slot6skillVraga != 20 && skreader.slot6skillVraga != 41)
                {
                    slotsmerman.slo6Hp += 1f;
                }
            }
            if (chitalkaTarget2 == skreader.slotVraga6 && skreader.slot6skillVraga != 0)
            {
                lovushkaProverka();
                if (skreader.slot6skillVraga != 20 && skreader.slot6skillVraga != 41)
                {
                    slotsmerman.slo6Hp += 1f;
                }
            }
            if (chitalkaTarget3 == skreader.slotVraga6 && skreader.slot6skillVraga != 0)
            {
                lovushkaProverka();
                if (skreader.slot6skillVraga != 20 && skreader.slot6skillVraga != 41)
                {
                    slotsmerman.slo6Hp += 1f;
                }
            }
            if (chitalkaTarget1 == skreader.slotVraga7 && skreader.slot7skillVraga != 0)
            {
                lovushkaProverka();
                if (skreader.slot7skillVraga != 41)
                {
                    slotsmerman.slo7Hp += 1f;
                }
            }
            if (chitalkaTarget2 == skreader.slotVraga7 && skreader.slot7skillVraga != 0)
            {
                lovushkaProverka();
                if (skreader.slot7skillVraga != 41)
                {
                    slotsmerman.slo7Hp += 1f;
                }
            }
            if (chitalkaTarget3 == skreader.slotVraga7 && skreader.slot7skillVraga != 0)
            {
                lovushkaProverka();
                if (skreader.slot7skillVraga != 41)
                {
                    slotsmerman.slo7Hp += 1f;
                }
            }
            if (chitalkaTarget1 == skreader.slotVraga8 && skreader.slot8skillVraga != 0)
            {
                lovushkaProverka();
                if (skreader.slot8skillVraga != 41)
                {
                    slotsmerman.slo8Hp += 1f;
                }
            }
            if (chitalkaTarget2 == skreader.slotVraga8 && skreader.slot8skillVraga != 0)
            {
                lovushkaProverka();
                if (skreader.slot8skillVraga != 41)
                {
                    slotsmerman.slo8Hp += 1f;
                }
            }
            if (chitalkaTarget3 == skreader.slotVraga8 && skreader.slot8skillVraga != 0)
            {
                lovushkaProverka();
                if (skreader.slot8skillVraga != 41)
                {
                    slotsmerman.slo8Hp += 1f;
                }
            }
            if (chitalkaTarget1 == skreader.slotVraga9 && skreader.slot9skillVraga != 0)
            {
                lovushkaProverka();
                if (skreader.slot9skillVraga != 41)
                {
                    slotsmerman.slo9Hp += 1f;
                }
            }
            if (chitalkaTarget2 == skreader.slotVraga9 && skreader.slot9skillVraga != 0)
            {
                lovushkaProverka();
                if (skreader.slot9skillVraga != 41)
                {
                    slotsmerman.slo9Hp += 1f;
                }
            }
            if (chitalkaTarget3 == skreader.slotVraga9 && skreader.slot9skillVraga != 0)
            {
                lovushkaProverka();
                if (skreader.slot9skillVraga != 41)
                {
                    slotsmerman.slo9Hp += 1f;
                }
            }
        }
        else // если блок или антиблок
        {
            timerHoda = 0.1f;
        }

        // если есть отрицательные значения, возвращаем их в ноль
        if(slotsgg.slot1Hp <= 0)
        {
            slotsgg.slot1Hp = 0;
        }
        if (slotsgg.slot2Hp <= 0)
        {
            slotsgg.slot2Hp = 0;
        }
        if (slotsgg.slot3Hp <= 0)
        {
            slotsgg.slot3Hp = 0;
        }
        if (slotsgg.slot4Hp <= 0)
        {
            slotsgg.slot4Hp = 0;
        }
        if (slotsgg.slot5Hp <= 0)
        {
            slotsgg.slot5Hp = 0;
        }
        if (slotsgg.slot6Hp <= 0)
        {
            slotsgg.slot6Hp = 0;
        }
        if (slotsgg.slot7Hp <= 0)
        {
            slotsgg.slot7Hp = 0;
        }
        if (slotsgg.slot8Hp <= 0)
        {
            slotsgg.slot8Hp = 0;
        }
        if (slotsgg.slot9Hp <= 0)
        {
            slotsgg.slot9Hp = 0;
        }
        if (slotsmerman.slo1Hp <= 0)
        {
            slotsmerman.slo1Hp = 0;
        }
        if (slotsmerman.slo2Hp <= 0)
        {
            slotsmerman.slo2Hp = 0;
        }
        if (slotsmerman.slo3Hp <= 0)
        {
            slotsmerman.slo3Hp = 0;
        }
        if (slotsmerman.slo4Hp <= 0)
        {
            slotsmerman.slo4Hp = 0;
        }
        if (slotsmerman.slo5Hp <= 0)
        {
            slotsmerman.slo5Hp = 0;
        }
        if (slotsmerman.slo6Hp <= 0)
        {
            slotsmerman.slo6Hp = 0;
        }
        if (slotsmerman.slo7Hp <= 0)
        {
            slotsmerman.slo7Hp = 0;
        }
        if (slotsmerman.slo8Hp <= 0)
        {
            slotsmerman.slo8Hp = 0;
        }
        if (slotsmerman.slo9Hp <= 0)
        {
            slotsmerman.slo9Hp = 0;
        }

        // если есть значения больше 1, добавляем показатель хилла. если = 1, он снимается
        if (slotsgg.slot1Hp <= 1)
        {
            slot1GGhilli.SetActive(false);
        }
        if (slotsgg.slot2Hp <= 1)
        {
            slot2GGhilli.SetActive(false);
        }
        if (slotsgg.slot3Hp <= 1)
        {
            slot3GGhilli.SetActive(false);
        }
        if (slotsgg.slot4Hp <= 1)
        {
            slot4GGhilli.SetActive(false);
        }
        if (slotsgg.slot5Hp <= 1)
        {
            slot5GGhilli.SetActive(false);
        }
        if (slotsgg.slot6Hp <= 1)
        {
            slot6GGhilli.SetActive(false);
        }
        if (slotsgg.slot7Hp <= 1)
        {
            slot7GGhilli.SetActive(false);
        }
        if (slotsgg.slot8Hp <= 1)
        {
            slot8GGhilli.SetActive(false);
        }
        if (slotsgg.slot9Hp <= 1)
        {
            slot9GGhilli.SetActive(false);
        }
        if (slotsmerman.slo1Hp <= 1)
        {
            slot1Vraghilli.SetActive(false);
        }
        if (slotsmerman.slo2Hp <= 1)
        {
            slot2Vraghilli.SetActive(false);
        }
        if (slotsmerman.slo3Hp <= 1)
        {
            slot3Vraghilli.SetActive(false);
        }
        if (slotsmerman.slo4Hp <= 1)
        {
            slot4Vraghilli.SetActive(false);
        }
        if (slotsmerman.slo5Hp <= 1)
        {
            slot5Vraghilli.SetActive(false);
        }
        if (slotsmerman.slo6Hp <= 1)
        {
            slot6Vraghilli.SetActive(false);
        }
        if (slotsmerman.slo7Hp <= 1)
        {
            slot7Vraghilli.SetActive(false);
        }
        if (slotsmerman.slo8Hp <= 1)
        {
            slot8Vraghilli.SetActive(false);
        }
        if (slotsmerman.slo9Hp <= 1)
        {
            slot9Vraghilli.SetActive(false);
        }
        if (slotsgg.slot1Hp > 1)
        {
            slot1GGhilli.SetActive(true);
            slotsgg.slot1Hp = 2;
        }
        if (slotsgg.slot2Hp > 1)
        {
            slot2GGhilli.SetActive(true);
            slotsgg.slot2Hp = 2;
        }
        if (slotsgg.slot3Hp > 1)
        {
            slot3GGhilli.SetActive(true);
            slotsgg.slot3Hp = 2;
        }
        if (slotsgg.slot4Hp > 1)
        {
            slot4GGhilli.SetActive(true);
            slotsgg.slot4Hp = 2;
        }
        if (slotsgg.slot5Hp > 1)
        {
            slot5GGhilli.SetActive(true);
            slotsgg.slot5Hp = 2;
        }
        if (slotsgg.slot6Hp > 1)
        {
            slot6GGhilli.SetActive(true);
            slotsgg.slot6Hp = 2;
        }
        if (slotsgg.slot7Hp > 1)
        {
            slot7GGhilli.SetActive(true);
            slotsgg.slot7Hp = 2;
        }
        if (slotsgg.slot8Hp > 1)
        {
            slot8GGhilli.SetActive(true);
            slotsgg.slot8Hp = 2;
        }
        if (slotsgg.slot9Hp > 1)
        {
            slot9GGhilli.SetActive(true);
            slotsgg.slot9Hp = 2;
        }
        if (slotsmerman.slo1Hp > 1)
        {
            slot1Vraghilli.SetActive(true);
            slotsmerman.slo1Hp = 2;
        }
        if (slotsmerman.slo2Hp > 1)
        {
            slot2Vraghilli.SetActive(true);
            slotsmerman.slo2Hp = 2;
        }
        if (slotsmerman.slo3Hp > 1)
        {
            slot3Vraghilli.SetActive(true);
            slotsmerman.slo3Hp = 2;
        }
        if (slotsmerman.slo4Hp > 1)
        {
            slot4Vraghilli.SetActive(true);
            slotsmerman.slo4Hp = 2;
        }
        if (slotsmerman.slo5Hp > 1)
        {
            slot5Vraghilli.SetActive(true);
            slotsmerman.slo5Hp = 2;
        }
        if (slotsmerman.slo6Hp > 1)
        {
            slot6Vraghilli.SetActive(true);
            slotsmerman.slo6Hp = 2;
        }
        if (slotsmerman.slo7Hp > 1)
        {
            slot7Vraghilli.SetActive(true);
            slotsmerman.slo7Hp = 2;
        }
        if (slotsmerman.slo8Hp > 1)
        {
            slot8Vraghilli.SetActive(true);
            slotsmerman.slo8Hp = 2;
        }
        if (slotsmerman.slo9Hp > 1)
        {
            slot9Vraghilli.SetActive(true);
            slotsmerman.slo9Hp = 2;
        }


        // после каждого хода обновляем хп, если что-то изменилось в минус, то шкала ужаса поднимается, повреждённый навык перекрывается спрайтом/меняет цвет и становится 0
        if (sravnslot1gg != slotsgg.slot1Hp) // если в слоте 1 чето изменилось
        {
            if (sravnslot1gg > slotsgg.slot1Hp && slotsgg.slot1Hp == 0) // если навык был, но его вынесли
            {
                shkalaUzhasaGG += 1; // шкала ужаса поднялась
                slot1GGdamag.SetActive(true); 
            }
            else if (sravnslot1gg <= 0 && slotsgg.slot1Hp > 0) // если существующий навык был воскрешён
            {
                shkalaUzhasaGG -= 1;
            }
        }
        

        if (slotsgg.slot1Hp > 0) // если навык жив
        {
            slot1GGdamag.SetActive(false);
        }
        if (sravnslot2gg != slotsgg.slot2Hp) // если в слоте 1 чето изменилось
        {
            if (sravnslot2gg > slotsgg.slot2Hp && slotsgg.slot2Hp == 0) // если навык был, но его вынесли
            {
                shkalaUzhasaGG += 1; // шкала ужаса поднялась
                slot2GGdamag.SetActive(true);
            }
            else if (sravnslot2gg <= 0 && slotsgg.slot2Hp > 0)
            {
                shkalaUzhasaGG -= 1;
            }
        }
        if (slotsgg.slot2Hp > 0) // если навык жив
        {
            slot2GGdamag.SetActive(false);
        }
        if (sravnslot3gg != slotsgg.slot3Hp) // если в слоте 1 чето изменилось
        {
            if (sravnslot3gg > slotsgg.slot3Hp && slotsgg.slot3Hp == 0) // если навык был, но его вынесли
            {
                shkalaUzhasaGG += 1; // шкала ужаса поднялась
                slot3GGdamag.SetActive(true);
            }
            else if (sravnslot3gg <= 0 && slotsgg.slot3Hp > 0)
            {
                shkalaUzhasaGG -= 1;
            }
        }
        if (slotsgg.slot3Hp > 0) // если навык жив
        {
            slot3GGdamag.SetActive(false);
        }
        if (sravnslot4gg != slotsgg.slot4Hp) // если в слоте 1 чето изменилось
        {
            if (sravnslot4gg > slotsgg.slot4Hp && slotsgg.slot4Hp == 0) // если навык был, но его вынесли
            {
                shkalaUzhasaGG += 1; // шкала ужаса поднялась
                slot4GGdamag.SetActive(true);
            }
            else if (sravnslot4gg <= 0 && slotsgg.slot4Hp > 0)
            {
                shkalaUzhasaGG -= 1;
            }
        }
        if (slotsgg.slot4Hp > 0) // если навык жив
        {
            slot4GGdamag.SetActive(false);
        }
        if (sravnslot5gg != slotsgg.slot5Hp) // если в слоте 1 чето изменилось
        {
            if (sravnslot5gg > slotsgg.slot5Hp && slotsgg.slot5Hp == 0) // если навык был, но его вынесли
            {
                shkalaUzhasaGG += 1; // шкала ужаса поднялась
                slot5GGdamag.SetActive(true);
            }
            else if (sravnslot5gg <= 0 && slotsgg.slot5Hp > 0)
            {
                shkalaUzhasaGG -= 1;
            }
        }
        if (slotsgg.slot5Hp > 0) // если навык жив
        {
            slot5GGdamag.SetActive(false);
        }
        if (sravnslot6gg != slotsgg.slot6Hp) // если в слоте 1 чето изменилось
        {
            if (sravnslot6gg > slotsgg.slot6Hp && slotsgg.slot6Hp == 0) // если навык был, но его вынесли
            {
                shkalaUzhasaGG += 1; // шкала ужаса поднялась
                slot6GGdamag.SetActive(true);
            }
            else if (sravnslot6gg <= 0 && slotsgg.slot6Hp > 0)
            {
                shkalaUzhasaGG -= 1;
            }
        }
        if (slotsgg.slot6Hp > 0) // если навык жив
        {
            slot6GGdamag.SetActive(false);
        }
        if (sravnslot7gg != slotsgg.slot7Hp) // если в слоте 1 чето изменилось
        {
            if (sravnslot7gg > slotsgg.slot7Hp && slotsgg.slot7Hp == 0) // если навык был, но его вынесли
            {
                shkalaUzhasaGG += 1; // шкала ужаса поднялась
                slot7GGdamag.SetActive(true);
            }
            else if (sravnslot7gg <= 0 && slotsgg.slot7Hp > 0)
            {
                shkalaUzhasaGG -= 1;
            }
        }
        if (slotsgg.slot7Hp > 0) // если навык жив
        {
            slot7GGdamag.SetActive(false);
        }
        if (sravnslot8gg != slotsgg.slot8Hp) // если в слоте 1 чето изменилось
        {
            if (sravnslot8gg > slotsgg.slot8Hp && slotsgg.slot8Hp == 0) // если навык был, но его вынесли
            {
                shkalaUzhasaGG += 1; // шкала ужаса поднялась
                slot8GGdamag.SetActive(true);
            }
            else if (sravnslot8gg <= 0 && slotsgg.slot8Hp > 0)
            {
                shkalaUzhasaGG -= 1;
            }
        }
        if (slotsgg.slot8Hp > 0) // если навык жив
        {
            slot8GGdamag.SetActive(false);
        }
        if (sravnslot9gg != slotsgg.slot9Hp) // если в слоте 1 чето изменилось
        {
            if (sravnslot9gg > slotsgg.slot9Hp && slotsgg.slot9Hp == 0) // если навык был, но его вынесли
            {
                shkalaUzhasaGG += 1; // шкала ужаса поднялась
                slot9GGdamag.SetActive(true);
            }
            else if (sravnslot9gg <= 0 && slotsgg.slot9Hp > 0)
            {
                shkalaUzhasaGG -= 1;
            }
        }
        if (slotsgg.slot9Hp > 0) // если навык жив
        {
            slot9GGdamag.SetActive(false);
        }
        if (sravnslot1vraga != slotsmerman.slo1Hp)
        {
            if (sravnslot1vraga > slotsmerman.slo1Hp && slotsmerman.slo1Hp == 0)
            {
                shkalaUzhasaVraga += 1;
                slot1Vragdamag.SetActive(true);
            }
            else if (sravnslot1vraga <= 0 && slotsmerman.slo1Hp > 0)
            {
                shkalaUzhasaVraga -= 1;
            }
        }
        if (slotsmerman.slo1Hp > 0) // если навык жив
        {
            slot1Vragdamag.SetActive(false);
        }
        if (sravnslot2vraga != slotsmerman.slo2Hp)
        {
            if (sravnslot2vraga > slotsmerman.slo2Hp && slotsmerman.slo2Hp == 0)
            {
                shkalaUzhasaVraga += 1;
                slot2Vragdamag.SetActive(true);
            }
            else if (sravnslot2vraga <= 0 && slotsmerman.slo2Hp > 0)
            {
                shkalaUzhasaVraga -= 1;
            }
        }
        if (slotsmerman.slo2Hp > 0) // если навык жив
        {
            slot2Vragdamag.SetActive(false);
        }
        if (sravnslot3vraga != slotsmerman.slo3Hp)
        {
            if (sravnslot3vraga > slotsmerman.slo3Hp && slotsmerman.slo3Hp == 0)
            {
                shkalaUzhasaVraga += 1;
                slot3Vragdamag.SetActive(true);
            }
            else if (sravnslot3vraga <= 0 && slotsmerman.slo3Hp > 0)
            {
                shkalaUzhasaVraga -= 1;
            }
        }
        if (slotsmerman.slo3Hp > 0) // если навык жив
        {
            slot3Vragdamag.SetActive(false);
        }
        if (sravnslot4vraga != slotsmerman.slo4Hp)
        {
            if (sravnslot4vraga > slotsmerman.slo4Hp && slotsmerman.slo4Hp == 0)
            {
                shkalaUzhasaVraga += 1;
                slot4Vragdamag.SetActive(true);
            }
            else if (sravnslot4vraga <= 0 && slotsmerman.slo4Hp > 0)
            {
                shkalaUzhasaVraga -= 1;
            }
        }
        if (slotsmerman.slo4Hp > 0) // если навык жив
        {
            slot4Vragdamag.SetActive(false);
        }
        if (sravnslot5vraga != slotsmerman.slo5Hp)
        {
            if (sravnslot5vraga > slotsmerman.slo5Hp && slotsmerman.slo5Hp == 0)
            {
                shkalaUzhasaVraga += 1;
                slot5Vragdamag.SetActive(true);
            }
            else if (sravnslot5vraga <= 0 && slotsmerman.slo5Hp > 0)
            {
                shkalaUzhasaVraga -= 1;
            }
        }
        if (slotsmerman.slo5Hp > 0) // если навык жив
        {
            slot5Vragdamag.SetActive(false);
        }
        if (sravnslot6vraga != slotsmerman.slo6Hp)
        {
            if (sravnslot6vraga > slotsmerman.slo6Hp && slotsmerman.slo6Hp == 0)
            {
                shkalaUzhasaVraga += 1;
                slot6Vragdamag.SetActive(true);
            }
            else if (sravnslot6vraga <= 0 && slotsmerman.slo6Hp > 0)
            {
                shkalaUzhasaVraga -= 1;
            }
        }
        if (slotsmerman.slo6Hp > 0) // если навык жив
        {
            slot6Vragdamag.SetActive(false);
        }
        if (sravnslot7vraga != slotsmerman.slo7Hp)
        {
            if (sravnslot7vraga > slotsmerman.slo7Hp && slotsmerman.slo7Hp == 0)
            {
                shkalaUzhasaVraga += 1;
                slot7Vragdamag.SetActive(true);
            }
            else if (sravnslot7vraga <= 0 && slotsmerman.slo7Hp > 0)
            {
                shkalaUzhasaVraga -= 1;
            }
        }
        if (slotsmerman.slo7Hp > 0) // если навык жив
        {
            slot7Vragdamag.SetActive(false);
        }
        if (sravnslot8vraga != slotsmerman.slo8Hp)
        {
            if (sravnslot8vraga > slotsmerman.slo8Hp && slotsmerman.slo8Hp == 0)
            {
                shkalaUzhasaVraga += 1;
                slot8Vragdamag.SetActive(true);
            }
            else if (sravnslot8vraga <= 0 && slotsmerman.slo8Hp > 0)
            {
                shkalaUzhasaVraga -= 1;
            }
        }
        if (slotsmerman.slo8Hp > 0) // если навык жив
        {
            slot8Vragdamag.SetActive(false);
        }
        if (sravnslot9vraga != slotsmerman.slo9Hp)
        {
            if (sravnslot9vraga > slotsmerman.slo9Hp && slotsmerman.slo9Hp == 0)
            {
                shkalaUzhasaVraga += 1;
                slot9Vragdamag.SetActive(true);
            }
            else if (sravnslot9vraga <= 0 && slotsmerman.slo9Hp > 0)
            {
                shkalaUzhasaVraga -= 1;
            }
        }
        if (slotsmerman.slo9Hp > 0) // если навык жив
        {
            slot9Vragdamag.SetActive(false);
        }

        // уничтожаются анимации
        // udar.SetActive(false);
       // udar2.SetActive(false);
       // udar3.SetActive(false);

        // ход закончен, заново устанавливаем сравнительные хп
        sravnslot1gg = slotsgg.slot1Hp;
        sravnslot2gg = slotsgg.slot2Hp;
        sravnslot3gg = slotsgg.slot3Hp;
        sravnslot4gg = slotsgg.slot4Hp;
        sravnslot5gg = slotsgg.slot5Hp;
        sravnslot6gg = slotsgg.slot6Hp;
        sravnslot7gg = slotsgg.slot7Hp;
        sravnslot8gg = slotsgg.slot8Hp;
        sravnslot9gg = slotsgg.slot9Hp;
        sravnslot1vraga = slotsmerman.slo1Hp;
        sravnslot2vraga = slotsmerman.slo2Hp;
        sravnslot3vraga = slotsmerman.slo3Hp;
        sravnslot4vraga = slotsmerman.slo4Hp;
        sravnslot5vraga = slotsmerman.slo5Hp;
        sravnslot6vraga = slotsmerman.slo6Hp;
        sravnslot7vraga = slotsmerman.slo7Hp;
        sravnslot8vraga = slotsmerman.slo8Hp;
        sravnslot9vraga = slotsmerman.slo9Hp;

        if(playingSkill == 22) // одноразовые навыки тут отмечаются
        {
            skreader.skil22used = true;
            skills.slotList.Remove(skills.slotKolonka22);
        }
        if (playingSkill == 30) // одноразовые навыки тут отмечаются
        {
            skreader.skil30used = true;
            skills.slotList.Remove(skills.slotKolonka30);
        }
        if (playingSkill == 32) // одноразовые навыки тут отмечаются
        {
            skreader.skil32used = true;
            skills.slotList.Remove(skills.slotKolonka32);
        }

        chitalkaBlokov(); // после хода проверяются блоки
        animation_bol = false; // ход закончился
    }

    public void obnuliator()
    {
        slot1GGsvet.SetActive(false);
        slot2GGsvet.SetActive(false);
        slot3GGsvet.SetActive(false);
        slot4GGsvet.SetActive(false);
        slot5GGsvet.SetActive(false);
        slot6GGsvet.SetActive(false);
        slot7GGsvet.SetActive(false);
        slot8GGsvet.SetActive(false);
        slot9GGsvet.SetActive(false);
        slot1Vragsvet.SetActive(false);
        slot2Vragsvet.SetActive(false);
        slot3Vragsvet.SetActive(false);
        slot4Vragsvet.SetActive(false);
        slot5Vragsvet.SetActive(false);
        slot6Vragsvet.SetActive(false);
        slot7Vragsvet.SetActive(false);
        slot8Vragsvet.SetActive(false);
        slot9Vragsvet.SetActive(false);
        hodSvet.SetActive(true);
        hodSvet2.SetActive(true);

    }


    // чтение + отображение в конце
    public void chitalkaBlokov()
    {
        mermenreader.slot1zablokVraga = false;
        mermenreader.slot2zablokVraga = false;
        mermenreader.slot3zablokVraga = false;
        mermenreader.slot4zablokVraga = false;
        mermenreader.slot5zablokVraga = false;
        mermenreader.slot6zablokVraga = false;
        mermenreader.slot7zablokVraga = false;
        mermenreader.slot8zablokVraga = false;
        mermenreader.slot9zablokVraga = false;
        mermenreader.slot1zablokirovan = false;
        mermenreader.slot2zablokirovan = false;
        mermenreader.slot3zablokirovan = false;
        mermenreader.slot4zablokirovan = false;
        mermenreader.slot5zablokirovan = false;
        mermenreader.slot6zablokirovan = false;
        mermenreader.slot7zablokirovan = false;
        mermenreader.slot8zablokirovan = false;
        mermenreader.slot9zablokirovan = false;



        // блоки врага
        if (skreader.slot1skillVraga == 4 && slotsmerman.slo1Hp > 0) // навык 4
        {
            mermenreader.slot1zablokirovan = true;
        }
        else if (skreader.slot2skillVraga == 4 && slotsmerman.slo2Hp > 0)
        {
            mermenreader.slot2zablokirovan = true;
        }
        else if (skreader.slot3skillVraga == 4 && slotsmerman.slo3Hp > 0)
        {
            mermenreader.slot3zablokirovan = true;
        }
        if (skreader.slot7skillVraga == 9 && slotsmerman.slo7Hp > 0) // навык 9
        {
            mermenreader.slot7zablokirovan = true;
        }
        else if (skreader.slot8skillVraga == 9 && slotsmerman.slo8Hp > 0)
        {
            mermenreader.slot8zablokirovan = true;
        }
        else if (skreader.slot9skillVraga == 9 && slotsmerman.slo9Hp > 0)
        {
            mermenreader.slot9zablokirovan = true;
        }
        if (skreader.slot4skillVraga == 15 && slotsmerman.slo4Hp > 0) // навык 15
        {
            mermenreader.slot4zablokirovan = true;
        }
        else if (skreader.slot5skillVraga == 15 && slotsmerman.slo5Hp > 0)
        {
            mermenreader.slot5zablokirovan = true;
        }
        else if (skreader.slot6skillVraga == 15 && slotsmerman.slo6Hp > 0)
        {
            mermenreader.slot6zablokirovan = true;
        }

        if (skreader.slot4skillVraga == 19 && slotsmerman.slo4Hp > 0) // навык 19
        {
            if (skreader.slot4targetVr1 == skreader.slotGG1)
            {
                mermenreader.slot1zablokirovan = true;
            }
            else if (skreader.slot4targetVr1 == skreader.slotGG4)
            {
                mermenreader.slot4zablokirovan = true;
            }
            else if (skreader.slot4targetVr1 == skreader.slotGG7)
            {
                mermenreader.slot7zablokirovan = true;
            }
        }
        else if (skreader.slot5skillVraga == 19 && slotsmerman.slo5Hp > 0)
        {
            if (skreader.slot5targetVr1 == skreader.slotGG2)
            {
                mermenreader.slot2zablokirovan = true;
            }
            else if (skreader.slot5targetVr1 == skreader.slotGG5)
            {
                mermenreader.slot5zablokirovan = true;
            }
            else if (skreader.slot5targetVr1 == skreader.slotGG8)
            {
                mermenreader.slot8zablokirovan = true;
            }
        }
        else if (skreader.slot6skillVraga == 19 && slotsmerman.slo6Hp > 0)
        {
            if (skreader.slot6targetVr1 == skreader.slotGG3)
            {
                mermenreader.slot3zablokirovan = true;
            }
            else if (skreader.slot6targetVr1 == skreader.slotGG6)
            {
                mermenreader.slot6zablokirovan = true;
            }
            else if (skreader.slot6targetVr1 == skreader.slotGG9)
            {
                mermenreader.slot9zablokirovan = true;
            }
        }
        if (skreader.slot2skillVraga == 22 && slotsmerman.slo2Hp > 0) // навык 22
        {
            mermenreader.slot2zablokirovan = true;
        }
        else if (skreader.slot5skillVraga == 22 && slotsmerman.slo5Hp > 0)
        {
            mermenreader.slot5zablokirovan = true;
        }
        else if (skreader.slot7skillVraga == 22 && slotsmerman.slo7Hp > 0)
        {
            mermenreader.slot7zablokirovan = true;
        }
        else if (skreader.slot8skillVraga == 22 && slotsmerman.slo8Hp > 0)
        {
            mermenreader.slot8zablokirovan = true;
        }
        else if (skreader.slot9skillVraga == 22 && slotsmerman.slo9Hp > 0)
        {
            mermenreader.slot9zablokirovan = true;
        }
        if (skreader.slot8skillVraga == 24 && slotsmerman.slo8Hp > 0) // навык 24
        {
            mermenreader.slot2zablokirovan = true;
            mermenreader.slot5zablokirovan = true;
            mermenreader.slot8zablokirovan = true;
        }
        if (skreader.slot1skillVraga == 27 && slotsmerman.slo1Hp > 0) // навык 27
        {
            if (skreader.slot1targetVr1 == skreader.slotGG1 || skreader.slot1targetVr2 == skreader.slotGG1)
            {
                mermenreader.slot1zablokirovan = true;
            }
            if (skreader.slot1targetVr1 == skreader.slotGG4 || skreader.slot1targetVr2 == skreader.slotGG4)
            {
                mermenreader.slot4zablokirovan = true;
            }
            if (skreader.slot1targetVr1 == skreader.slotGG7 || skreader.slot1targetVr2 == skreader.slotGG7)
            {
                mermenreader.slot7zablokirovan = true;
            }
        }
        else if (skreader.slot3skillVraga == 27 && slotsmerman.slo3Hp > 0)
        {
            if (skreader.slot3targetVr1 == skreader.slotGG3 || skreader.slot3targetVr2 == skreader.slotGG3)
            {
                mermenreader.slot3zablokirovan = true;
            }
            if (skreader.slot3targetVr1 == skreader.slotGG6 || skreader.slot3targetVr2 == skreader.slotGG6)
            {
                mermenreader.slot6zablokirovan = true;
            }
            if (skreader.slot3targetVr1 == skreader.slotGG9 || skreader.slot3targetVr2 == skreader.slotGG9)
            {
                mermenreader.slot9zablokirovan = true;
            }
        }
        else if (skreader.slot7skillVraga == 27 && slotsmerman.slo7Hp > 0)
        {
            if (skreader.slot7targetVr1 == skreader.slotGG1 || skreader.slot7targetVr2 == skreader.slotGG1)
            {
                mermenreader.slot1zablokirovan = true;
            }
            if (skreader.slot7targetVr1 == skreader.slotGG4 || skreader.slot7targetVr2 == skreader.slotGG4)
            {
                mermenreader.slot4zablokirovan = true;
            }
            if (skreader.slot7targetVr1 == skreader.slotGG7 || skreader.slot7targetVr2 == skreader.slotGG7)
            {
                mermenreader.slot7zablokirovan = true;
            }
        }
        else if (skreader.slot9skillVraga == 27 && slotsmerman.slo9Hp > 0)
        {
            if (skreader.slot9targetVr1 == skreader.slotGG3 || skreader.slot9targetVr2 == skreader.slotGG3)
            {
                mermenreader.slot3zablokirovan = true;
            }
            if (skreader.slot9targetVr1 == skreader.slotGG6 || skreader.slot9targetVr2 == skreader.slotGG6)
            {
                mermenreader.slot6zablokirovan = true;
            }
            if (skreader.slot9targetVr1 == skreader.slotGG9 || skreader.slot9targetVr2 == skreader.slotGG9)
            {
                mermenreader.slot9zablokirovan = true;
            }
        }
        if (skreader.slot5skillVraga == 37 && slotsmerman.slo5Hp > 0) // навык 37
        {
            if (skreader.slot5targetVr1 == skreader.slotGG1 || skreader.slot5targetVr2 == skreader.slotGG1 || skreader.slot5targetVr3 == skreader.slotGG1)
            {
                mermenreader.slot1zablokirovan = true;
            }
            if (skreader.slot5targetVr1 == skreader.slotGG2 || skreader.slot5targetVr2 == skreader.slotGG2 || skreader.slot5targetVr3 == skreader.slotGG2)
            {
                mermenreader.slot2zablokirovan = true;
            }
            if (skreader.slot5targetVr1 == skreader.slotGG3 || skreader.slot5targetVr2 == skreader.slotGG3 || skreader.slot5targetVr3 == skreader.slotGG3)
            {
                mermenreader.slot3zablokirovan = true;
            }
            if (skreader.slot5targetVr1 == skreader.slotGG4 || skreader.slot5targetVr2 == skreader.slotGG4 || skreader.slot5targetVr3 == skreader.slotGG4)
            {
                mermenreader.slot4zablokirovan = true;
            }
            if (skreader.slot5targetVr1 == skreader.slotGG5 || skreader.slot5targetVr2 == skreader.slotGG5 || skreader.slot5targetVr3 == skreader.slotGG5)
            {
                mermenreader.slot5zablokirovan = true;
            }
            if (skreader.slot5targetVr1 == skreader.slotGG6 || skreader.slot5targetVr2 == skreader.slotGG6 || skreader.slot5targetVr3 == skreader.slotGG6)
            {
                mermenreader.slot6zablokirovan = true;
            }
            if (skreader.slot5targetVr1 == skreader.slotGG7 || skreader.slot5targetVr2 == skreader.slotGG7 || skreader.slot5targetVr3 == skreader.slotGG7)
            {
                mermenreader.slot7zablokirovan = true;
            }
            if (skreader.slot5targetVr1 == skreader.slotGG8 || skreader.slot5targetVr2 == skreader.slotGG8 || skreader.slot5targetVr3 == skreader.slotGG8)
            {
                mermenreader.slot8zablokirovan = true;
            }
            if (skreader.slot5targetVr1 == skreader.slotGG9 || skreader.slot5targetVr2 == skreader.slotGG9 || skreader.slot5targetVr3 == skreader.slotGG9)
            {
                mermenreader.slot9zablokirovan = true;
            }
        }
        else if (skreader.slot7skillVraga == 37 && slotsmerman.slo7Hp > 0)
        {
            if (skreader.slot7targetVr1 == skreader.slotGG1 || skreader.slot7targetVr2 == skreader.slotGG1 || skreader.slot7targetVr3 == skreader.slotGG1)
            {
                mermenreader.slot1zablokirovan = true;
            }
            if (skreader.slot7targetVr1 == skreader.slotGG2 || skreader.slot7targetVr2 == skreader.slotGG2 || skreader.slot7targetVr3 == skreader.slotGG2)
            {
                mermenreader.slot2zablokirovan = true;
            }
            if (skreader.slot7targetVr1 == skreader.slotGG3 || skreader.slot7targetVr2 == skreader.slotGG3 || skreader.slot7targetVr3 == skreader.slotGG3)
            {
                mermenreader.slot3zablokirovan = true;
            }
            if (skreader.slot7targetVr1 == skreader.slotGG4 || skreader.slot7targetVr2 == skreader.slotGG4 || skreader.slot7targetVr3 == skreader.slotGG4)
            {
                mermenreader.slot4zablokirovan = true;
            }
            if (skreader.slot7targetVr1 == skreader.slotGG5 || skreader.slot7targetVr2 == skreader.slotGG5 || skreader.slot7targetVr3 == skreader.slotGG5)
            {
                mermenreader.slot5zablokirovan = true;
            }
            if (skreader.slot7targetVr1 == skreader.slotGG6 || skreader.slot7targetVr2 == skreader.slotGG6 || skreader.slot7targetVr3 == skreader.slotGG6)
            {
                mermenreader.slot6zablokirovan = true;
            }
            if (skreader.slot7targetVr1 == skreader.slotGG7 || skreader.slot7targetVr2 == skreader.slotGG7 || skreader.slot7targetVr3 == skreader.slotGG7)
            {
                mermenreader.slot7zablokirovan = true;
            }
            if (skreader.slot7targetVr1 == skreader.slotGG8 || skreader.slot7targetVr2 == skreader.slotGG8 || skreader.slot7targetVr3 == skreader.slotGG8)
            {
                mermenreader.slot8zablokirovan = true;
            }
            if (skreader.slot7targetVr1 == skreader.slotGG9 || skreader.slot7targetVr2 == skreader.slotGG9 || skreader.slot7targetVr3 == skreader.slotGG9)
            {
                mermenreader.slot9zablokirovan = true;
            }
        }
        else if (skreader.slot8skillVraga == 37 && slotsmerman.slo8Hp > 0)
        {
            if (skreader.slot8targetVr1 == skreader.slotGG1 || skreader.slot8targetVr2 == skreader.slotGG1 || skreader.slot8targetVr3 == skreader.slotGG1)
            {
                mermenreader.slot1zablokirovan = true;
            }
            if (skreader.slot8targetVr1 == skreader.slotGG2 || skreader.slot8targetVr2 == skreader.slotGG2 || skreader.slot8targetVr3 == skreader.slotGG2)
            {
                mermenreader.slot2zablokirovan = true;
            }
            if (skreader.slot8targetVr1 == skreader.slotGG3 || skreader.slot8targetVr2 == skreader.slotGG3 || skreader.slot8targetVr3 == skreader.slotGG3)
            {
                mermenreader.slot3zablokirovan = true;
            }
            if (skreader.slot8targetVr1 == skreader.slotGG4 || skreader.slot8targetVr2 == skreader.slotGG4 || skreader.slot8targetVr3 == skreader.slotGG4)
            {
                mermenreader.slot4zablokirovan = true;
            }
            if (skreader.slot8targetVr1 == skreader.slotGG5 || skreader.slot8targetVr2 == skreader.slotGG5 || skreader.slot8targetVr3 == skreader.slotGG5)
            {
                mermenreader.slot5zablokirovan = true;
            }
            if (skreader.slot8targetVr1 == skreader.slotGG6 || skreader.slot8targetVr2 == skreader.slotGG6 || skreader.slot8targetVr3 == skreader.slotGG6)
            {
                mermenreader.slot6zablokirovan = true;
            }
            if (skreader.slot8targetVr1 == skreader.slotGG7 || skreader.slot8targetVr2 == skreader.slotGG7 || skreader.slot8targetVr3 == skreader.slotGG7)
            {
                mermenreader.slot7zablokirovan = true;
            }
            if (skreader.slot8targetVr1 == skreader.slotGG8 || skreader.slot8targetVr2 == skreader.slotGG8 || skreader.slot8targetVr3 == skreader.slotGG8)
            {
                mermenreader.slot8zablokirovan = true;
            }
            if (skreader.slot8targetVr1 == skreader.slotGG9 || skreader.slot8targetVr2 == skreader.slotGG9 || skreader.slot8targetVr3 == skreader.slotGG9)
            {
                mermenreader.slot9zablokirovan = true;
            }
        }
        else if (skreader.slot9skillVraga == 37 && slotsmerman.slo9Hp > 0)
        {
            if (skreader.slot9targetVr1 == skreader.slotGG1 || skreader.slot9targetVr2 == skreader.slotGG1 || skreader.slot9targetVr3 == skreader.slotGG1)
            {
                mermenreader.slot1zablokirovan = true;
            }
            if (skreader.slot9targetVr1 == skreader.slotGG2 || skreader.slot9targetVr2 == skreader.slotGG2 || skreader.slot9targetVr3 == skreader.slotGG2)
            {
                mermenreader.slot2zablokirovan = true;
            }
            if (skreader.slot9targetVr1 == skreader.slotGG3 || skreader.slot9targetVr2 == skreader.slotGG3 || skreader.slot9targetVr3 == skreader.slotGG3)
            {
                mermenreader.slot3zablokirovan = true;
            }
            if (skreader.slot9targetVr1 == skreader.slotGG4 || skreader.slot9targetVr2 == skreader.slotGG4 || skreader.slot9targetVr3 == skreader.slotGG4)
            {
                mermenreader.slot4zablokirovan = true;
            }
            if (skreader.slot9targetVr1 == skreader.slotGG5 || skreader.slot9targetVr2 == skreader.slotGG5 || skreader.slot9targetVr3 == skreader.slotGG5)
            {
                mermenreader.slot5zablokirovan = true;
            }
            if (skreader.slot9targetVr1 == skreader.slotGG6 || skreader.slot9targetVr2 == skreader.slotGG6 || skreader.slot9targetVr3 == skreader.slotGG6)
            {
                mermenreader.slot6zablokirovan = true;
            }
            if (skreader.slot9targetVr1 == skreader.slotGG7 || skreader.slot9targetVr2 == skreader.slotGG7 || skreader.slot9targetVr3 == skreader.slotGG7)
            {
                mermenreader.slot7zablokirovan = true;
            }
            if (skreader.slot9targetVr1 == skreader.slotGG8 || skreader.slot9targetVr2 == skreader.slotGG8 || skreader.slot9targetVr3 == skreader.slotGG8)
            {
                mermenreader.slot8zablokirovan = true;
            }
            if (skreader.slot9targetVr1 == skreader.slotGG9 || skreader.slot9targetVr2 == skreader.slotGG9 || skreader.slot9targetVr3 == skreader.slotGG9)
            {
                mermenreader.slot9zablokirovan = true;
            }
        }
        if (skreader.slot1skillVraga == 38 && slotsmerman.slo1Hp > 0) // 38 блок врага
        {
            if (skreader.slot1targetVr1 == skreader.slotGG1 || skreader.slot1targetVr2 == skreader.slotGG1 || skreader.slot1targetVr3 == skreader.slotGG1)
            {
                mermenreader.slot1zablokirovan = true;
            }
            if (skreader.slot1targetVr1 == skreader.slotGG4 || skreader.slot1targetVr2 == skreader.slotGG4 || skreader.slot1targetVr3 == skreader.slotGG4)
            {
                mermenreader.slot4zablokirovan = true;
            }
            if (skreader.slot1targetVr1 == skreader.slotGG7 || skreader.slot1targetVr2 == skreader.slotGG7 || skreader.slot1targetVr3 == skreader.slotGG7)
            {
                mermenreader.slot7zablokirovan = true;
            }
        }
        else if (skreader.slot4skillVraga == 38 && slotsmerman.slo4Hp > 0)
        {
            if (skreader.slot4targetVr1 == skreader.slotGG1 || skreader.slot4targetVr2 == skreader.slotGG1 || skreader.slot4targetVr3 == skreader.slotGG1)
            {
                mermenreader.slot1zablokirovan = true;
            }
            if (skreader.slot4targetVr1 == skreader.slotGG4 || skreader.slot4targetVr2 == skreader.slotGG4 || skreader.slot4targetVr3 == skreader.slotGG4)
            {
                mermenreader.slot4zablokirovan = true;
            }
            if (skreader.slot4targetVr1 == skreader.slotGG7 || skreader.slot4targetVr2 == skreader.slotGG7 || skreader.slot4targetVr3 == skreader.slotGG7)
            {
                mermenreader.slot7zablokirovan = true;
            }
        }
        else if (skreader.slot7skillVraga == 38 && slotsmerman.slo7Hp > 0)
        {
            if (skreader.slot7targetVr1 == skreader.slotGG1 || skreader.slot7targetVr2 == skreader.slotGG1 || skreader.slot7targetVr3 == skreader.slotGG1)
            {
                mermenreader.slot1zablokirovan = true;
            }
            if (skreader.slot7targetVr1 == skreader.slotGG4 || skreader.slot7targetVr2 == skreader.slotGG4 || skreader.slot7targetVr3 == skreader.slotGG4)
            {
                mermenreader.slot4zablokirovan = true;
            }
            if (skreader.slot7targetVr1 == skreader.slotGG7 || skreader.slot7targetVr2 == skreader.slotGG7 || skreader.slot7targetVr3 == skreader.slotGG7)
            {
                mermenreader.slot7zablokirovan = true;
            }
        }
        else if (skreader.slot2skillVraga == 38 && slotsmerman.slo2Hp > 0) // 38 блок врага
        {
            if (skreader.slot2targetVr1 == skreader.slotGG2 || skreader.slot2targetVr2 == skreader.slotGG2 || skreader.slot2targetVr3 == skreader.slotGG2)
            {
                mermenreader.slot2zablokirovan = true;
            }
            if (skreader.slot2targetVr1 == skreader.slotGG5 || skreader.slot2targetVr2 == skreader.slotGG5 || skreader.slot2targetVr3 == skreader.slotGG5)
            {
                mermenreader.slot5zablokirovan = true;
            }
            if (skreader.slot2targetVr1 == skreader.slotGG8 || skreader.slot2targetVr2 == skreader.slotGG8 || skreader.slot2targetVr3 == skreader.slotGG8)
            {
                mermenreader.slot8zablokirovan = true;
            }
        }
        else if (skreader.slot5skillVraga == 38 && slotsmerman.slo5Hp > 0)
        {
            if (skreader.slot5targetVr1 == skreader.slotGG2 || skreader.slot5targetVr2 == skreader.slotGG2 || skreader.slot5targetVr3 == skreader.slotGG2)
            {
                mermenreader.slot2zablokirovan = true;
            }
            if (skreader.slot5targetVr1 == skreader.slotGG5 || skreader.slot5targetVr2 == skreader.slotGG5 || skreader.slot5targetVr3 == skreader.slotGG5)
            {
                mermenreader.slot5zablokirovan = true;
            }
            if (skreader.slot5targetVr1 == skreader.slotGG8 || skreader.slot5targetVr2 == skreader.slotGG8 || skreader.slot5targetVr3 == skreader.slotGG8)
            {
                mermenreader.slot8zablokirovan = true;
            }
        }
        else if (skreader.slot8skillVraga == 38 && slotsmerman.slo8Hp > 0)
        {
            if (skreader.slot8targetVr1 == skreader.slotGG2 || skreader.slot8targetVr2 == skreader.slotGG2 || skreader.slot8targetVr3 == skreader.slotGG2)
            {
                mermenreader.slot2zablokirovan = true;
            }
            if (skreader.slot8targetVr1 == skreader.slotGG5 || skreader.slot8targetVr2 == skreader.slotGG5 || skreader.slot8targetVr3 == skreader.slotGG5)
            {
                mermenreader.slot5zablokirovan = true;
            }
            if (skreader.slot8targetVr1 == skreader.slotGG8 || skreader.slot8targetVr2 == skreader.slotGG8 || skreader.slot8targetVr3 == skreader.slotGG8)
            {
                mermenreader.slot8zablokirovan = true;
            }
        }
        else if (skreader.slot3skillVraga == 38 && slotsmerman.slo3Hp > 0) // 38 блок врага
        {
            if (skreader.slot3targetVr1 == skreader.slotGG3 || skreader.slot3targetVr2 == skreader.slotGG3 || skreader.slot3targetVr3 == skreader.slotGG3)
            {
                mermenreader.slot3zablokirovan = true;
            }
            if (skreader.slot3targetVr1 == skreader.slotGG6 || skreader.slot3targetVr2 == skreader.slotGG6 || skreader.slot3targetVr3 == skreader.slotGG6)
            {
                mermenreader.slot6zablokirovan = true;
            }
            if (skreader.slot3targetVr1 == skreader.slotGG9 || skreader.slot3targetVr2 == skreader.slotGG9 || skreader.slot3targetVr3 == skreader.slotGG9)
            {
                mermenreader.slot9zablokirovan = true;
            }
        }
        else if (skreader.slot6skillVraga == 38 && slotsmerman.slo6Hp > 0)
        {
            if (skreader.slot6targetVr1 == skreader.slotGG3 || skreader.slot6targetVr2 == skreader.slotGG3 || skreader.slot6targetVr3 == skreader.slotGG3)
            {
                mermenreader.slot3zablokirovan = true;
            }
            if (skreader.slot6targetVr1 == skreader.slotGG6 || skreader.slot6targetVr2 == skreader.slotGG6 || skreader.slot6targetVr3 == skreader.slotGG6)
            {
                mermenreader.slot6zablokirovan = true;
            }
            if (skreader.slot6targetVr1 == skreader.slotGG9 || skreader.slot6targetVr2 == skreader.slotGG9 || skreader.slot6targetVr3 == skreader.slotGG9)
            {
                mermenreader.slot9zablokirovan = true;
            }
        }
        else if (skreader.slot9skillVraga == 38 && slotsmerman.slo9Hp > 0)
        {
            if (skreader.slot9targetVr1 == skreader.slotGG3 || skreader.slot9targetVr2 == skreader.slotGG3 || skreader.slot9targetVr3 == skreader.slotGG3)
            {
                mermenreader.slot3zablokirovan = true;
            }
            if (skreader.slot9targetVr1 == skreader.slotGG6 || skreader.slot9targetVr2 == skreader.slotGG6 || skreader.slot9targetVr3 == skreader.slotGG6)
            {
                mermenreader.slot6zablokirovan = true;
            }
            if (skreader.slot9targetVr1 == skreader.slotGG9 || skreader.slot9targetVr2 == skreader.slotGG9 || skreader.slot9targetVr3 == skreader.slotGG9)
            {
                mermenreader.slot9zablokirovan = true;
            }
        }
        if (skreader.slot2skillVraga == 42 && slotsmerman.slo2Hp > 0) // навык 42
        {
            mermenreader.slot2zablokirovan = true;
        }
        else if (skreader.slot5skillVraga == 42 && slotsmerman.slo5Hp > 0)
        {
            mermenreader.slot5zablokirovan = true;
        }
        else if (skreader.slot6skillVraga == 42 && slotsmerman.slo6Hp > 0)
        {
            mermenreader.slot6zablokirovan = true;
        }
        else if (skreader.slot8skillVraga == 42 && slotsmerman.slo8Hp > 0)
        {
            mermenreader.slot8zablokirovan = true;
        }

        if (skreader.slot1skillVraga == 43 && slotsmerman.slo1Hp > 0) // навык 43
        {
            mermenreader.slot1zablokirovan = true;
        }
        else if (skreader.slot2skillVraga == 43 && slotsmerman.slo2Hp > 0)
        {
            mermenreader.slot2zablokirovan = true;
        }
        else if (skreader.slot3skillVraga == 43 && slotsmerman.slo3Hp > 0)
        {
            mermenreader.slot3zablokirovan = true;
        }
        else if (skreader.slot4skillVraga == 43 && slotsmerman.slo4Hp > 0)
        {
            mermenreader.slot4zablokirovan = true;
        }




        // блоки гг
        if (skreader.slot1skill == 4 && slotsgg.slot1Hp > 0) // навык 4
        {
            mermenreader.slot1zablokVraga = true;
        }
        else if (skreader.slot2skill == 4 && slotsgg.slot2Hp > 0)
        {
            mermenreader.slot2zablokVraga = true;
        }
        else if (skreader.slot3skill == 4 && slotsgg.slot3Hp > 0)
        {
            mermenreader.slot3zablokVraga = true;
        }
        if (skreader.slot7skill == 9 && slotsgg.slot7Hp > 0) // навык 9
        {
            mermenreader.slot7zablokVraga = true;
        }
        else if (skreader.slot8skill == 9 && slotsgg.slot8Hp > 0)
        {
            mermenreader.slot8zablokVraga = true;
        }
        else if (skreader.slot9skill == 9 && slotsgg.slot9Hp > 0)
        {
            mermenreader.slot9zablokVraga = true;
        }
        if (skreader.slot4skill == 15 && slotsgg.slot4Hp > 0) // навык 15
        {
            mermenreader.slot4zablokVraga = true;
        }
        else if (skreader.slot5skill == 15 && slotsgg.slot5Hp > 0)
        {
            mermenreader.slot5zablokVraga = true;
        }
        else if (skreader.slot6skill == 15 && slotsgg.slot6Hp > 0)
        {
            mermenreader.slot6zablokVraga = true;
        }
        if (skreader.slot4skill == 19 && slotsgg.slot4Hp > 0) // навык 19
        {
            if (skreader.slot4target1 == skreader.slotVraga1)
            {
                mermenreader.slot1zablokVraga = true;
            }
            else if (skreader.slot4target1 == skreader.slotVraga4)
            {
                mermenreader.slot4zablokVraga = true;
            }
            else if (skreader.slot4target1 == skreader.slotVraga7)
            {
                mermenreader.slot7zablokVraga = true;
            }
        }
        else if (skreader.slot5skill == 19 && slotsgg.slot5Hp > 0)
        {
            if (skreader.slot5target1 == skreader.slotVraga2)
            {
                mermenreader.slot2zablokVraga = true;
            }
            else if (skreader.slot5target1 == skreader.slotVraga5)
            {
                mermenreader.slot5zablokVraga = true;
            }
            else if (skreader.slot5target1 == skreader.slotVraga8)
            {
                mermenreader.slot8zablokVraga = true;
            }
        }
        else if (skreader.slot6skill == 19 && slotsgg.slot6Hp > 0)
        {
            if (skreader.slot6target1 == skreader.slotVraga3)
            {
                mermenreader.slot3zablokVraga = true;
            }
            else if (skreader.slot6target1 == skreader.slotVraga6)
            {
                mermenreader.slot6zablokVraga = true;
            }
            else if (skreader.slot6target1 == skreader.slotVraga9)
            {
                mermenreader.slot9zablokVraga = true;
            }
        }
        if (skreader.slot2skill == 22 && slotsgg.slot2Hp > 0) // навык 22
        {
            mermenreader.slot2zablokVraga = true;
        }
        else if (skreader.slot5skill == 22 && slotsgg.slot5Hp > 0)
        {
            mermenreader.slot5zablokVraga = true;
        }
        else if (skreader.slot7skill == 22 && slotsgg.slot7Hp > 0)
        {
            mermenreader.slot7zablokVraga = true;
        }
        else if (skreader.slot8skill == 22 && slotsgg.slot8Hp > 0)
        {
            mermenreader.slot8zablokVraga = true;
        }
        else if (skreader.slot9skill == 22 && slotsgg.slot9Hp > 0)
        {
            mermenreader.slot9zablokVraga = true;
        }
        if (skreader.slot8skill == 24 && slotsgg.slot8Hp > 0) // навык 24
        {
            mermenreader.slot2zablokVraga = true;
            mermenreader.slot5zablokVraga = true;
            mermenreader.slot8zablokVraga = true;
        }
        if (skreader.slot1skill == 27 && slotsgg.slot1Hp > 0) // навык 27
        {
            if (skreader.slot1target1 == skreader.slotVraga1 || skreader.slot1target2 == skreader.slotVraga1)
            {
                mermenreader.slot1zablokVraga = true;
            }
            if (skreader.slot1target1 == skreader.slotVraga4 || skreader.slot1target2 == skreader.slotVraga4)
            {
                mermenreader.slot4zablokVraga = true;
            }
            if (skreader.slot1target1 == skreader.slotVraga7 || skreader.slot1target2 == skreader.slotVraga7)
            {
                mermenreader.slot7zablokVraga = true;
            }
        }
        else if (skreader.slot3skill == 27 && slotsgg.slot3Hp > 0)
        {
            if (skreader.slot3target1 == skreader.slotVraga3 || skreader.slot3target2 == skreader.slotVraga3)
            {
                mermenreader.slot3zablokVraga = true;
            }
            if (skreader.slot3target1 == skreader.slotVraga6 || skreader.slot3target2 == skreader.slotVraga6)
            {
                mermenreader.slot6zablokVraga = true;
            }
            if (skreader.slot3target1 == skreader.slotVraga9 || skreader.slot3target2 == skreader.slotVraga9)
            {
                mermenreader.slot9zablokVraga = true;
            }
        }
        else if (skreader.slot7skill == 27 && slotsgg.slot7Hp > 0)
        {
            if (skreader.slot7target1 == skreader.slotVraga1 || skreader.slot7target2 == skreader.slotVraga1)
            {
                mermenreader.slot1zablokVraga = true;
            }
            if (skreader.slot7target1 == skreader.slotVraga4 || skreader.slot7target2 == skreader.slotVraga4)
            {
                mermenreader.slot4zablokVraga = true;
            }
            if (skreader.slot7target1 == skreader.slotVraga7 || skreader.slot7target2 == skreader.slotVraga7)
            {
                mermenreader.slot7zablokVraga = true;
            }
        }
        else if (skreader.slot9skill == 27 && slotsgg.slot9Hp > 0)
        {
            if (skreader.slot9target1 == skreader.slotVraga3 || skreader.slot9target2 == skreader.slotVraga3)
            {
                mermenreader.slot3zablokVraga = true;
            }
            if (skreader.slot9target1 == skreader.slotVraga6 || skreader.slot9target2 == skreader.slotVraga6)
            {
                mermenreader.slot6zablokVraga = true;
            }
            if (skreader.slot9target1 == skreader.slotVraga9 || skreader.slot9target2 == skreader.slotVraga9)
            {
                mermenreader.slot9zablokVraga = true;
            }
        }
        if (skreader.slot5skill == 37 && slotsgg.slot5Hp > 0) // навык 37
        {
            if (skreader.slot5target1 == skreader.slotVraga1 || skreader.slot5target2 == skreader.slotVraga1 || skreader.slot5target3 == skreader.slotVraga1)
            {
                mermenreader.slot1zablokVraga = true;
            }
            if (skreader.slot5target1 == skreader.slotVraga2 || skreader.slot5target2 == skreader.slotVraga2 || skreader.slot5target3 == skreader.slotVraga2)
            {
                mermenreader.slot2zablokVraga = true;
            }
            if (skreader.slot5target1 == skreader.slotVraga3 || skreader.slot5target2 == skreader.slotVraga3 || skreader.slot5target3 == skreader.slotVraga3)
            {
                mermenreader.slot3zablokVraga = true;
            }
            if (skreader.slot5target1 == skreader.slotVraga4 || skreader.slot5target2 == skreader.slotVraga4 || skreader.slot5target3 == skreader.slotVraga4)
            {
                mermenreader.slot4zablokVraga = true;
            }
            if (skreader.slot5target1 == skreader.slotVraga5 || skreader.slot5target2 == skreader.slotVraga5 || skreader.slot5target3 == skreader.slotVraga5)
            {
                mermenreader.slot5zablokVraga = true;
            }
            if (skreader.slot5target1 == skreader.slotVraga6 || skreader.slot5target2 == skreader.slotVraga6 || skreader.slot5target3 == skreader.slotVraga6)
            {
                mermenreader.slot6zablokVraga = true;
            }
            if (skreader.slot5target1 == skreader.slotVraga7 || skreader.slot5target2 == skreader.slotVraga7 || skreader.slot5target3 == skreader.slotVraga7)
            {
                mermenreader.slot7zablokVraga = true;
            }
            if (skreader.slot5target1 == skreader.slotVraga8 || skreader.slot5target2 == skreader.slotVraga8 || skreader.slot5target3 == skreader.slotVraga8)
            {
                mermenreader.slot8zablokVraga = true;
            }
            if (skreader.slot5target1 == skreader.slotVraga9 || skreader.slot5target2 == skreader.slotVraga9 || skreader.slot5target3 == skreader.slotVraga9)
            {
                mermenreader.slot9zablokVraga = true;
            }
        }
        else if (skreader.slot7skill == 37 && slotsgg.slot7Hp > 0)
        {
            if (skreader.slot7target1 == skreader.slotVraga1 || skreader.slot7target2 == skreader.slotVraga1 || skreader.slot7target3 == skreader.slotVraga1)
            {
                mermenreader.slot1zablokVraga = true;
            }
            if (skreader.slot7target1 == skreader.slotVraga2 || skreader.slot7target2 == skreader.slotVraga2 || skreader.slot7target3 == skreader.slotVraga2)
            {
                mermenreader.slot2zablokVraga = true;
            }
            if (skreader.slot7target1 == skreader.slotVraga3 || skreader.slot7target2 == skreader.slotVraga3 || skreader.slot7target3 == skreader.slotVraga3)
            {
                mermenreader.slot3zablokVraga = true;
            }
            if (skreader.slot7target1 == skreader.slotVraga4 || skreader.slot7target2 == skreader.slotVraga4 || skreader.slot7target3 == skreader.slotVraga4)
            {
                mermenreader.slot4zablokVraga = true;
            }
            if (skreader.slot7target1 == skreader.slotVraga5 || skreader.slot7target2 == skreader.slotVraga5 || skreader.slot7target3 == skreader.slotVraga5)
            {
                mermenreader.slot5zablokVraga = true;
            }
            if (skreader.slot7target1 == skreader.slotVraga6 || skreader.slot7target2 == skreader.slotVraga6 || skreader.slot7target3 == skreader.slotVraga6)
            {
                mermenreader.slot6zablokVraga = true;
            }
            if (skreader.slot7target1 == skreader.slotVraga7 || skreader.slot7target2 == skreader.slotVraga7 || skreader.slot7target3 == skreader.slotVraga7)
            {
                mermenreader.slot7zablokVraga = true;
            }
            if (skreader.slot7target1 == skreader.slotVraga8 || skreader.slot7target2 == skreader.slotVraga8 || skreader.slot7target3 == skreader.slotVraga8)
            {
                mermenreader.slot8zablokVraga = true;
            }
            if (skreader.slot7target1 == skreader.slotVraga9 || skreader.slot7target2 == skreader.slotVraga9 || skreader.slot7target3 == skreader.slotVraga9)
            {
                mermenreader.slot9zablokVraga = true;
            }
        }
        else if (skreader.slot8skill == 37 && slotsgg.slot8Hp > 0)
        {
            if (skreader.slot8target1 == skreader.slotVraga1 || skreader.slot8target2 == skreader.slotVraga1 || skreader.slot8target3 == skreader.slotVraga1)
            {
                mermenreader.slot1zablokVraga = true;
            }
            if (skreader.slot8target1 == skreader.slotVraga2 || skreader.slot8target2 == skreader.slotVraga2 || skreader.slot8target3 == skreader.slotVraga2)
            {
                mermenreader.slot2zablokVraga = true;
            }
            if (skreader.slot8target1 == skreader.slotVraga3 || skreader.slot8target2 == skreader.slotVraga3 || skreader.slot8target3 == skreader.slotVraga3)
            {
                mermenreader.slot3zablokVraga = true;
            }
            if (skreader.slot8target1 == skreader.slotVraga4 || skreader.slot8target2 == skreader.slotVraga4 || skreader.slot8target3 == skreader.slotVraga4)
            {
                mermenreader.slot4zablokVraga = true;
            }
            if (skreader.slot8target1 == skreader.slotVraga5 || skreader.slot8target2 == skreader.slotVraga5 || skreader.slot8target3 == skreader.slotVraga5)
            {
                mermenreader.slot5zablokVraga = true;
            }
            if (skreader.slot8target1 == skreader.slotVraga6 || skreader.slot8target2 == skreader.slotVraga6 || skreader.slot8target3 == skreader.slotVraga6)
            {
                mermenreader.slot6zablokVraga = true;
            }
            if (skreader.slot8target1 == skreader.slotVraga7 || skreader.slot8target2 == skreader.slotVraga7 || skreader.slot8target3 == skreader.slotVraga7)
            {
                mermenreader.slot7zablokVraga = true;
            }
            if (skreader.slot8target1 == skreader.slotVraga8 || skreader.slot8target2 == skreader.slotVraga8 || skreader.slot8target3 == skreader.slotVraga8)
            {
                mermenreader.slot8zablokVraga = true;
            }
            if (skreader.slot8target1 == skreader.slotVraga9 || skreader.slot8target2 == skreader.slotVraga9 || skreader.slot8target3 == skreader.slotVraga9)
            {
                mermenreader.slot9zablokVraga = true;
            }
        }
        else if (skreader.slot9skill == 37 && slotsgg.slot9Hp > 0)
        {
            if (skreader.slot9target1 == skreader.slotVraga1 || skreader.slot9target2 == skreader.slotVraga1 || skreader.slot9target3 == skreader.slotVraga1)
            {
                mermenreader.slot1zablokVraga = true;
            }
            if (skreader.slot9target1 == skreader.slotVraga2 || skreader.slot9target2 == skreader.slotVraga2 || skreader.slot9target3 == skreader.slotVraga2)
            {
                mermenreader.slot2zablokVraga = true;
            }
            if (skreader.slot9target1 == skreader.slotVraga3 || skreader.slot9target2 == skreader.slotVraga3 || skreader.slot9target3 == skreader.slotVraga3)
            {
                mermenreader.slot3zablokVraga = true;
            }
            if (skreader.slot9target1 == skreader.slotVraga4 || skreader.slot9target2 == skreader.slotVraga4 || skreader.slot9target3 == skreader.slotVraga4)
            {
                mermenreader.slot4zablokVraga = true;
            }
            if (skreader.slot9target1 == skreader.slotVraga5 || skreader.slot9target2 == skreader.slotVraga5 || skreader.slot9target3 == skreader.slotVraga5)
            {
                mermenreader.slot5zablokVraga = true;
            }
            if (skreader.slot9target1 == skreader.slotVraga6 || skreader.slot9target2 == skreader.slotVraga6 || skreader.slot9target3 == skreader.slotVraga6)
            {
                mermenreader.slot6zablokVraga = true;
            }
            if (skreader.slot9target1 == skreader.slotVraga7 || skreader.slot9target2 == skreader.slotVraga7 || skreader.slot9target3 == skreader.slotVraga7)
            {
                mermenreader.slot7zablokVraga = true;
            }
            if (skreader.slot9target1 == skreader.slotVraga8 || skreader.slot9target2 == skreader.slotVraga8 || skreader.slot9target3 == skreader.slotVraga8)
            {
                mermenreader.slot8zablokVraga = true;
            }
            if (skreader.slot9target1 == skreader.slotVraga9 || skreader.slot9target2 == skreader.slotVraga9 || skreader.slot9target3 == skreader.slotVraga9)
            {
                mermenreader.slot9zablokVraga = true;
            }
        }
        if (skreader.slot1skill == 38 && slotsgg.slot1Hp > 0) // 38 блок врага
        {
            if (skreader.slot1target1 == skreader.slotVraga1 || skreader.slot1target2 == skreader.slotVraga1 || skreader.slot1target3 == skreader.slotVraga1)
            {
                mermenreader.slot1zablokVraga = true;
            }
            if (skreader.slot1target1 == skreader.slotVraga4 || skreader.slot1target2 == skreader.slotVraga4 || skreader.slot1target3 == skreader.slotVraga4)
            {
                mermenreader.slot4zablokVraga = true;
            }
            if (skreader.slot1target1 == skreader.slotVraga7 || skreader.slot1target2 == skreader.slotVraga7 || skreader.slot1target3 == skreader.slotVraga7)
            {
                mermenreader.slot7zablokVraga = true;
            }
        }
        else if (skreader.slot4skill == 38 && slotsgg.slot4Hp > 0)
        {
            if (skreader.slot4target1 == skreader.slotVraga1 || skreader.slot4target2 == skreader.slotVraga1 || skreader.slot4target3 == skreader.slotVraga1)
            {
                mermenreader.slot1zablokVraga = true;
            }
            if (skreader.slot4target1 == skreader.slotVraga4 || skreader.slot4target2 == skreader.slotVraga4 || skreader.slot4target3 == skreader.slotVraga4)
            {
                mermenreader.slot4zablokVraga = true;
            }
            if (skreader.slot4target1 == skreader.slotVraga7 || skreader.slot4target2 == skreader.slotVraga7 || skreader.slot4target3 == skreader.slotVraga7)
            {
                mermenreader.slot7zablokVraga = true;
            }
        }
        else if (skreader.slot7skill == 38 && slotsgg.slot7Hp > 0)
        {
            if (skreader.slot7target1 == skreader.slotVraga1 || skreader.slot7target2 == skreader.slotVraga1 || skreader.slot7target3 == skreader.slotVraga1)
            {
                mermenreader.slot1zablokVraga = true;
            }
            if (skreader.slot7target1 == skreader.slotVraga4 || skreader.slot7target2 == skreader.slotVraga4 || skreader.slot7target3 == skreader.slotVraga4)
            {
                mermenreader.slot4zablokVraga = true;
            }
            if (skreader.slot7target1 == skreader.slotVraga7 || skreader.slot7target2 == skreader.slotVraga7 || skreader.slot7target3 == skreader.slotVraga7)
            {
                mermenreader.slot7zablokVraga = true;
            }
        }
        else if (skreader.slot2skill == 38 && slotsgg.slot2Hp > 0) // 38 блок врага
        {
            if (skreader.slot2target1 == skreader.slotVraga2 || skreader.slot2target2 == skreader.slotVraga2 || skreader.slot2target3 == skreader.slotVraga2)
            {
                mermenreader.slot2zablokVraga = true;
            }
            if (skreader.slot2target1 == skreader.slotVraga5 || skreader.slot2target2 == skreader.slotVraga5 || skreader.slot2target3 == skreader.slotVraga5)
            {
                mermenreader.slot5zablokVraga = true;
            }
            if (skreader.slot2target1 == skreader.slotVraga8 || skreader.slot2target2 == skreader.slotVraga8 || skreader.slot2target3 == skreader.slotVraga8)
            {
                mermenreader.slot8zablokVraga = true;
            }
        }
        else if (skreader.slot5skill == 38 && slotsgg.slot5Hp > 0)
        {
            if (skreader.slot5target1 == skreader.slotVraga2 || skreader.slot5target2 == skreader.slotVraga2 || skreader.slot5target3 == skreader.slotVraga2)
            {
                mermenreader.slot2zablokVraga = true;
            }
            if (skreader.slot5target1 == skreader.slotVraga5 || skreader.slot5target2 == skreader.slotVraga5 || skreader.slot5target3 == skreader.slotVraga5)
            {
                mermenreader.slot5zablokVraga = true;
            }
            if (skreader.slot5target1 == skreader.slotVraga8 || skreader.slot5target2 == skreader.slotVraga8 || skreader.slot5target3 == skreader.slotVraga8)
            {
                mermenreader.slot8zablokVraga = true;
            }
        }
        else if (skreader.slot8skill == 38 && slotsgg.slot8Hp > 0)
        {
            if (skreader.slot8target1 == skreader.slotVraga2 || skreader.slot8target2 == skreader.slotVraga2 || skreader.slot8target3 == skreader.slotVraga2)
            {
                mermenreader.slot2zablokVraga = true;
            }
            if (skreader.slot8target1 == skreader.slotVraga5 || skreader.slot8target2 == skreader.slotVraga5 || skreader.slot8target3 == skreader.slotVraga5)
            {
                mermenreader.slot5zablokVraga = true;
            }
            if (skreader.slot8target1 == skreader.slotVraga8 || skreader.slot8target2 == skreader.slotVraga8 || skreader.slot8target3 == skreader.slotVraga8)
            {
                mermenreader.slot8zablokVraga = true;
            }
        }
        else if (skreader.slot3skill == 38 && slotsgg.slot3Hp > 0) // 38 блок врага
        {
            if (skreader.slot3target1 == skreader.slotVraga3 || skreader.slot3target2 == skreader.slotVraga3 || skreader.slot3target3 == skreader.slotVraga3)
            {
                mermenreader.slot3zablokVraga = true;
            }
            if (skreader.slot3target1 == skreader.slotVraga6 || skreader.slot3target2 == skreader.slotVraga6 || skreader.slot3target3 == skreader.slotVraga6)
            {
                mermenreader.slot6zablokVraga = true;
            }
            if (skreader.slot3target1 == skreader.slotVraga9 || skreader.slot3target2 == skreader.slotVraga9 || skreader.slot3target3 == skreader.slotVraga9)
            {
                mermenreader.slot9zablokVraga = true;
            }
        }
        else if (skreader.slot6skill == 38 && slotsgg.slot6Hp > 0)
        {
            if (skreader.slot6target1 == skreader.slotVraga3 || skreader.slot6target2 == skreader.slotVraga3 || skreader.slot6target3 == skreader.slotVraga3)
            {
                mermenreader.slot3zablokVraga = true;
            }
            if (skreader.slot6target1 == skreader.slotVraga6 || skreader.slot6target2 == skreader.slotVraga6 || skreader.slot6target3 == skreader.slotVraga6)
            {
                mermenreader.slot6zablokVraga = true;
            }
            if (skreader.slot6target1 == skreader.slotVraga9 || skreader.slot6target2 == skreader.slotVraga9 || skreader.slot6target3 == skreader.slotVraga9)
            {
                mermenreader.slot9zablokVraga = true;
            }
        }
        else if (skreader.slot9skill == 38 && slotsgg.slot9Hp > 0)
        {
            if (skreader.slot9target1 == skreader.slotVraga3 || skreader.slot9target2 == skreader.slotVraga3 || skreader.slot9target3 == skreader.slotVraga3)
            {
                mermenreader.slot3zablokVraga = true;
            }
            if (skreader.slot9target1 == skreader.slotVraga6 || skreader.slot9target2 == skreader.slotVraga6 || skreader.slot9target3 == skreader.slotVraga6)
            {
                mermenreader.slot6zablokVraga = true;
            }
            if (skreader.slot9target1 == skreader.slotVraga9 || skreader.slot9target2 == skreader.slotVraga9 || skreader.slot9target3 == skreader.slotVraga9)
            {
                mermenreader.slot9zablokVraga = true;
            }
        }
        if (skreader.slot2skill == 42 && slotsgg.slot2Hp > 0) // навык 42
        {
            mermenreader.slot2zablokVraga = true;
        }
        else if (skreader.slot5skill == 42 && slotsgg.slot5Hp > 0)
        {
            mermenreader.slot5zablokVraga = true;
        }
        else if (skreader.slot6skill == 42 && slotsgg.slot6Hp > 0)
        {
            mermenreader.slot6zablokVraga = true;
        }
        else if (skreader.slot8skill == 42 && slotsgg.slot8Hp > 0)
        {
            mermenreader.slot8zablokVraga = true;
        }

        if (skreader.slot1skill == 43 && slotsgg.slot1Hp > 0) // навык 43
        {
            mermenreader.slot1zablokVraga = true;
        }
        else if (skreader.slot2skill == 43 && slotsgg.slot2Hp > 0)
        {
            mermenreader.slot2zablokVraga = true;
        }
        else if (skreader.slot3skill == 43 && slotsgg.slot3Hp > 0)
        {
            mermenreader.slot3zablokVraga = true;
        }
        else if (skreader.slot4skill == 43 && slotsgg.slot4Hp > 0)
        {
            mermenreader.slot4zablokVraga = true;
        }


        // антиблоки врага
        if (skreader.slot4skillVraga == 5 && slotsmerman.slo4Hp > 0) // 5 навык
        {
            if(skreader.slot4targetVr1 == skreader.slotVraga1)
            {
                mermenreader.slot1zablokVraga = false;
                slot1Vragshield.SetActive(true);
            }

            else if(skreader.slot4targetVr1 == skreader.slotVraga2)
            {
                mermenreader.slot2zablokVraga = false;
                slot2Vragshield.SetActive(true);
            }
            else if (skreader.slot4targetVr1 == skreader.slotVraga3)
            {
                mermenreader.slot3zablokVraga = false;
                slot3Vragshield.SetActive(true);
            }
        }
        else if (skreader.slot5skillVraga == 5 && slotsmerman.slo5Hp > 0) // 5 навык
        {
            if (skreader.slot5targetVr1 == skreader.slotVraga1)
            {
                mermenreader.slot1zablokVraga = false;
                slot1Vragshield.SetActive(true);
            }

            else if (skreader.slot5targetVr1 == skreader.slotVraga2)
            {
                mermenreader.slot2zablokVraga = false;
                slot2Vragshield.SetActive(true);
            }
            else if (skreader.slot5targetVr1 == skreader.slotVraga3)
            {
                mermenreader.slot3zablokVraga = false;
                slot3Vragshield.SetActive(true);
            }
            else if (skreader.slot5targetVr1 == skreader.slotVraga4)
            {
                mermenreader.slot4zablokVraga = false;
                slot4Vragshield.SetActive(true);
            }
        }
        else if (skreader.slot6skillVraga == 5 && slotsmerman.slo6Hp > 0) // 5 навык
        {
            if (skreader.slot6targetVr1 == skreader.slotVraga1)
            {
                mermenreader.slot1zablokVraga = false;
                slot1Vragshield.SetActive(true);
            }

            else if (skreader.slot6targetVr1 == skreader.slotVraga2)
            {
                mermenreader.slot2zablokVraga = false;
                slot2Vragshield.SetActive(true);
            }
            else if (skreader.slot6targetVr1 == skreader.slotVraga3)
            {
                mermenreader.slot3zablokVraga = false;
                slot3Vragshield.SetActive(true);
            }
            else if (skreader.slot6targetVr1 == skreader.slotVraga4)
            {
                mermenreader.slot4zablokVraga = false;
                slot4Vragshield.SetActive(true);
            }
            else if (skreader.slot6targetVr1 == skreader.slotVraga5)
            {
                mermenreader.slot5zablokVraga = false;
                slot5Vragshield.SetActive(true);
            }
        }
        if (skreader.slot4skillVraga == 12 && slotsmerman.slo4Hp > 0) // 12 навык
        {
            if (skreader.slot4targetVr1 == skreader.slotVraga5)
            {
                mermenreader.slot5zablokVraga = false;
                slot5Vragshield.SetActive(true);
            }

            else if (skreader.slot4targetVr1 == skreader.slotVraga6)
            {
                mermenreader.slot6zablokVraga = false;
                slot6Vragshield.SetActive(true);
            }
            else if (skreader.slot4targetVr1 == skreader.slotVraga7)
            {
                mermenreader.slot7zablokVraga = false;
                slot7Vragshield.SetActive(true);
            }
            else if (skreader.slot4targetVr1 == skreader.slotVraga8)
            {
                mermenreader.slot8zablokVraga = false;
                slot8Vragshield.SetActive(true);
            }
            else if (skreader.slot4targetVr1 == skreader.slotVraga9)
            {
                mermenreader.slot9zablokVraga = false;
                slot9Vragshield.SetActive(true);
            }
        }
        else if (skreader.slot5skillVraga == 12 && slotsmerman.slo5Hp > 0)
        {
            if (skreader.slot5targetVr1 == skreader.slotVraga6)
            {
                mermenreader.slot6zablokVraga = false;
                slot6Vragshield.SetActive(true);
            }

            else if (skreader.slot5targetVr1 == skreader.slotVraga7)
            {
                mermenreader.slot7zablokVraga = false;
                slot7Vragshield.SetActive(true);
            }
            else if (skreader.slot5targetVr1 == skreader.slotVraga8)
            {
                mermenreader.slot8zablokVraga = false;
                slot8Vragshield.SetActive(true);
            }
            else if (skreader.slot5targetVr1 == skreader.slotVraga9)
            {
                mermenreader.slot9zablokVraga = false;
                slot9Vragshield.SetActive(true);
            }
        }
        else if (skreader.slot6skillVraga == 12 && slotsmerman.slo6Hp > 0)
        {
            if (skreader.slot6targetVr1 == skreader.slotVraga7)
            {
                mermenreader.slot7zablokVraga = false;
                slot7Vragshield.SetActive(true);
            }

            else if (skreader.slot6targetVr1 == skreader.slotVraga8)
            {
                mermenreader.slot8zablokVraga = false;
                slot8Vragshield.SetActive(true);
            }
            else if (skreader.slot6targetVr1 == skreader.slotVraga9)
            {
                mermenreader.slot9zablokVraga = false;
                slot9Vragshield.SetActive(true);
            }
        }

        if (skreader.slot4skillVraga == 29 && slotsmerman.slo4Hp > 0) // 29 навык
        {
            mermenreader.slot7zablokVraga = false;
            mermenreader.slot8zablokVraga = false;
            mermenreader.slot9zablokVraga = false;
            slot7Vragshield.SetActive(true);
            slot8Vragshield.SetActive(true);
            slot9Vragshield.SetActive(true);
        }
        else if (skreader.slot6skillVraga == 29 && slotsmerman.slo6Hp > 0)
        {
            mermenreader.slot7zablokVraga = false;
            mermenreader.slot8zablokVraga = false;
            mermenreader.slot9zablokVraga = false;
            slot7Vragshield.SetActive(true);
            slot8Vragshield.SetActive(true);
            slot9Vragshield.SetActive(true);
        }
        if (skreader.slot5skillVraga == 39 && slotsmerman.slo5Hp > 0)
        {
            if (skreader.slot5targetVr1 == skreader.slotVraga1 || skreader.slot5targetVr2 == skreader.slotVraga1 || skreader.slot5targetVr3 == skreader.slotVraga1)
            {
                mermenreader.slot1zablokVraga = false;
                slot1Vragshield.SetActive(true);
            }
            if (skreader.slot5targetVr1 == skreader.slotVraga2 || skreader.slot5targetVr2 == skreader.slotVraga2 || skreader.slot5targetVr3 == skreader.slotVraga2)
            {
                mermenreader.slot2zablokVraga = false;
                slot2Vragshield.SetActive(true);
            }
            if (skreader.slot5targetVr1 == skreader.slotVraga3 || skreader.slot5targetVr2 == skreader.slotVraga3 || skreader.slot5targetVr3 == skreader.slotVraga3)
            {
                mermenreader.slot3zablokVraga = false;
                slot3Vragshield.SetActive(true);
            }
            if (skreader.slot5targetVr1 == skreader.slotVraga4 || skreader.slot5targetVr2 == skreader.slotVraga4 || skreader.slot5targetVr3 == skreader.slotVraga4)
            {
                mermenreader.slot4zablokVraga = false;
                slot4Vragshield.SetActive(true);
            }
            if (skreader.slot5targetVr1 == skreader.slotVraga5 || skreader.slot5targetVr2 == skreader.slotVraga5 || skreader.slot5targetVr3 == skreader.slotVraga5)
            {
                mermenreader.slot5zablokVraga = false;
                slot5Vragshield.SetActive(true);
            }
            if (skreader.slot5targetVr1 == skreader.slotVraga6 || skreader.slot5targetVr2 == skreader.slotVraga6 || skreader.slot5targetVr3 == skreader.slotVraga6)
            {
                mermenreader.slot6zablokVraga = false;
                slot6Vragshield.SetActive(true);
            }
            if (skreader.slot5targetVr1 == skreader.slotVraga7 || skreader.slot5targetVr2 == skreader.slotVraga7 || skreader.slot5targetVr3 == skreader.slotVraga7)
            {
                mermenreader.slot7zablokVraga = false;
                slot7Vragshield.SetActive(true);
            }
            if (skreader.slot5targetVr1 == skreader.slotVraga8 || skreader.slot5targetVr2 == skreader.slotVraga8 || skreader.slot5targetVr3 == skreader.slotVraga8)
            {
                mermenreader.slot8zablokVraga = false;
                slot8Vragshield.SetActive(true);
            }
            if (skreader.slot5targetVr1 == skreader.slotVraga9 || skreader.slot5targetVr2 == skreader.slotVraga9 || skreader.slot5targetVr3 == skreader.slotVraga9)
            {
                mermenreader.slot9zablokVraga = false;
                slot9Vragshield.SetActive(true);
            }
        }
        else if (skreader.slot7skillVraga == 39 && slotsmerman.slo7Hp > 0)
        {
            if (skreader.slot7targetVr1 == skreader.slotVraga4 || skreader.slot7targetVr2 == skreader.slotVraga4 || skreader.slot7targetVr3 == skreader.slotVraga4)
            {
                mermenreader.slot4zablokVraga = false;
                slot4Vragshield.SetActive(true);
            }
            if (skreader.slot7targetVr1 == skreader.slotVraga5 || skreader.slot7targetVr2 == skreader.slotVraga5 || skreader.slot7targetVr3 == skreader.slotVraga5)
            {
                mermenreader.slot5zablokVraga = false;
                slot5Vragshield.SetActive(true);
            }
            if (skreader.slot7targetVr1 == skreader.slotVraga8 || skreader.slot7targetVr2 == skreader.slotVraga8 || skreader.slot7targetVr3 == skreader.slotVraga8)
            {
                mermenreader.slot8zablokVraga = false;
                slot8Vragshield.SetActive(true);
            }
        }
        else if (skreader.slot8skillVraga == 39 && slotsmerman.slo8Hp > 0)
        {

            if (skreader.slot8targetVr1 == skreader.slotVraga4 || skreader.slot8targetVr2 == skreader.slotVraga4 || skreader.slot8targetVr3 == skreader.slotVraga4)
            {
                mermenreader.slot4zablokVraga = false;
                slot4Vragshield.SetActive(true);
            }
            if (skreader.slot8targetVr1 == skreader.slotVraga5 || skreader.slot8targetVr2 == skreader.slotVraga5 || skreader.slot8targetVr3 == skreader.slotVraga5)
            {
                mermenreader.slot5zablokVraga = false;
                slot5Vragshield.SetActive(true);
            }
            if (skreader.slot8targetVr1 == skreader.slotVraga6 || skreader.slot8targetVr2 == skreader.slotVraga6 || skreader.slot8targetVr3 == skreader.slotVraga6)
            {
                mermenreader.slot6zablokVraga = false;
                slot6Vragshield.SetActive(true);
            }
            if (skreader.slot8targetVr1 == skreader.slotVraga7 || skreader.slot8targetVr2 == skreader.slotVraga7 || skreader.slot8targetVr3 == skreader.slotVraga7)
            {
                mermenreader.slot7zablokVraga = false;
                slot7Vragshield.SetActive(true);
            }
            if (skreader.slot8targetVr1 == skreader.slotVraga9 || skreader.slot8targetVr2 == skreader.slotVraga9 || skreader.slot8targetVr3 == skreader.slotVraga9)
            {
                mermenreader.slot9zablokVraga = false;
                slot9Vragshield.SetActive(true);
            }
        }
        else if (skreader.slot9skillVraga == 39 && slotsmerman.slo9Hp > 0)
        {

            if (skreader.slot9targetVr1 == skreader.slotVraga5 || skreader.slot9targetVr2 == skreader.slotVraga5 || skreader.slot9targetVr3 == skreader.slotVraga5)
            {
                mermenreader.slot5zablokVraga = false;
                slot5Vragshield.SetActive(true);
            }
            if (skreader.slot9targetVr1 == skreader.slotVraga6 || skreader.slot9targetVr2 == skreader.slotVraga6 || skreader.slot9targetVr3 == skreader.slotVraga6)
            {
                mermenreader.slot6zablokVraga = false;
                slot6Vragshield.SetActive(true);
            }
            if (skreader.slot9targetVr1 == skreader.slotVraga8 || skreader.slot9targetVr2 == skreader.slotVraga8 || skreader.slot9targetVr3 == skreader.slotVraga8)
            {
                mermenreader.slot8zablokVraga = false;
                slot8Vragshield.SetActive(true);
            }
        }




        // антиблоки гг
        if (skreader.slot4skill == 5 && slotsgg.slot4Hp > 0) // 5 навык
        {
            if (skreader.slot4target1 == skreader.slotGG1)
            {
                mermenreader.slot1zablokirovan = false;
                slot1GGshield.SetActive(true);
            }

            else if (skreader.slot4target1 == skreader.slotGG2)
            {
                mermenreader.slot2zablokirovan = false;
                slot2GGshield.SetActive(true);
            }
            else if (skreader.slot4target1 == skreader.slotGG3)
            {
                mermenreader.slot3zablokirovan = false;
                slot3GGshield.SetActive(true);
            }
        }
        else if (skreader.slot5skill == 5 && slotsgg.slot5Hp > 0) // 5 навык
        {
            if (skreader.slot5target1 == skreader.slotGG1)
            {
                mermenreader.slot1zablokirovan = false;
                slot1GGshield.SetActive(true);
            }

            else if (skreader.slot5target1 == skreader.slotGG2)
            {
                mermenreader.slot2zablokirovan = false;
                slot2GGshield.SetActive(true);
            }
            else if (skreader.slot5target1 == skreader.slotGG3)
            {
                mermenreader.slot3zablokirovan = false;
                slot3GGshield.SetActive(true);
            }
            else if (skreader.slot5target1 == skreader.slotGG4)
            {
                mermenreader.slot4zablokirovan = false;
                slot4GGshield.SetActive(true);
            }
        }
        else if (skreader.slot6skill == 5 && slotsgg.slot6Hp > 0) // 5 навык
        {
            if (skreader.slot6target1 == skreader.slotGG1)
            {
                mermenreader.slot1zablokirovan = false;
                slot1GGshield.SetActive(true);
            }

            else if (skreader.slot6target1 == skreader.slotGG2)
            {
                mermenreader.slot2zablokirovan = false;
                slot2GGshield.SetActive(true);
            }
            else if (skreader.slot6target1 == skreader.slotGG3)
            {
                mermenreader.slot3zablokirovan = false;
                slot3GGshield.SetActive(true);
            }
            else if (skreader.slot6target1 == skreader.slotGG4)
            {
                mermenreader.slot4zablokirovan = false;
                slot4GGshield.SetActive(true);
            }
            else if (skreader.slot6target1 == skreader.slotGG5)
            {
                mermenreader.slot5zablokirovan = false;
                slot5GGshield.SetActive(true);
            }
        }
        if (skreader.slot4skill == 12 && slotsgg.slot4Hp > 0)
        {
            if (skreader.slot4target1 == skreader.slotGG5)
            {
                mermenreader.slot5zablokirovan = false;
                slot5GGshield.SetActive(true);
            }

            else if (skreader.slot4target1 == skreader.slotGG6)
            {
                mermenreader.slot6zablokirovan = false;
                slot6GGshield.SetActive(true);
            }
            else if (skreader.slot4target1 == skreader.slotGG7)
            {
                mermenreader.slot7zablokirovan = false;
                slot7GGshield.SetActive(true);
            }
            else if (skreader.slot4target1 == skreader.slotGG8)
            {
                mermenreader.slot8zablokirovan = false;
                slot8GGshield.SetActive(true);
            }
            else if (skreader.slot4target1 == skreader.slotGG9)
            {
                mermenreader.slot9zablokirovan = false;
                slot9GGshield.SetActive(true);
            }
        }
        else if (skreader.slot5skill == 12 && slotsgg.slot5Hp > 0)
        {
            if (skreader.slot5target1 == skreader.slotGG6)
            {
                mermenreader.slot6zablokirovan = false;
                slot6GGshield.SetActive(true);
            }

            else if (skreader.slot5target1 == skreader.slotGG7)
            {
                mermenreader.slot7zablokirovan = false;
                slot7GGshield.SetActive(true);
            }
            else if (skreader.slot5target1 == skreader.slotGG8)
            {
                mermenreader.slot8zablokirovan = false;
                slot8GGshield.SetActive(true);
            }
            else if (skreader.slot5target1 == skreader.slotGG9)
            {
                mermenreader.slot9zablokirovan = false;
                slot9GGshield.SetActive(true);
            }
        }
        else if (skreader.slot6skill == 12 && slotsgg.slot6Hp > 0)
        {
            if (skreader.slot6target1 == skreader.slotGG7)
            {
                mermenreader.slot7zablokirovan = false;
                slot7GGshield.SetActive(true);
            }

            else if (skreader.slot6target1 == skreader.slotGG8)
            {
                mermenreader.slot8zablokirovan = false;
                slot8GGshield.SetActive(true);
            }
            else if (skreader.slot6target1 == skreader.slotGG9)
            {
                mermenreader.slot9zablokirovan = false;
                slot9GGshield.SetActive(true);
            }
        }
        if (skreader.slot4skill == 29 && slotsgg.slot4Hp > 0) // 29 навык
        {
            mermenreader.slot7zablokirovan = false;
            mermenreader.slot8zablokirovan = false;
            mermenreader.slot9zablokirovan = false;
            slot7GGshield.SetActive(true);
            slot8GGshield.SetActive(true);
            slot9GGshield.SetActive(true);

        }
        else if (skreader.slot6skill == 29 && slotsgg.slot6Hp > 0)
        {
            mermenreader.slot7zablokirovan = false;
            mermenreader.slot8zablokirovan = false;
            mermenreader.slot9zablokirovan = false;
            slot7GGshield.SetActive(true);
            slot8GGshield.SetActive(true);
            slot9GGshield.SetActive(true);
        }
        if (skreader.slot5skill == 39 && slotsgg.slot5Hp > 0)
        {
            if (skreader.slot5target1 == skreader.slotGG1 || skreader.slot5target2 == skreader.slotGG1 || skreader.slot5target3 == skreader.slotGG1)
            {
                mermenreader.slot1zablokirovan = false;
                slot1GGshield.SetActive(true);
            }
            if (skreader.slot5target1 == skreader.slotGG2 || skreader.slot5target2 == skreader.slotGG2 || skreader.slot5target3 == skreader.slotGG2)
            {
                mermenreader.slot2zablokirovan = false;
                slot2GGshield.SetActive(true);
            }
            if (skreader.slot5target1 == skreader.slotGG3 || skreader.slot5target2 == skreader.slotGG3 || skreader.slot5target3 == skreader.slotGG3)
            {
                mermenreader.slot3zablokirovan = false;
                slot3GGshield.SetActive(true);
            }
            if (skreader.slot5target1 == skreader.slotGG4 || skreader.slot5target2 == skreader.slotGG4 || skreader.slot5target3 == skreader.slotGG4)
            {
                mermenreader.slot4zablokirovan = false;
                slot4GGshield.SetActive(true);
            }
            if (skreader.slot5target1 == skreader.slotGG5 || skreader.slot5target2 == skreader.slotGG5 || skreader.slot5target3 == skreader.slotGG5)
            {
                mermenreader.slot5zablokirovan = false;
                slot5GGshield.SetActive(true);
            }
            if (skreader.slot5target1 == skreader.slotGG6 || skreader.slot5target2 == skreader.slotGG6 || skreader.slot5target3 == skreader.slotGG6)
            {
                mermenreader.slot6zablokirovan = false;
                slot6GGshield.SetActive(true);
            }
            if (skreader.slot5target1 == skreader.slotGG7 || skreader.slot5target2 == skreader.slotGG7 || skreader.slot5target3 == skreader.slotGG7)
            {
                mermenreader.slot7zablokirovan = false;
                slot7GGshield.SetActive(true);
            }
            if (skreader.slot5target1 == skreader.slotGG8 || skreader.slot5target2 == skreader.slotGG8 || skreader.slot5target3 == skreader.slotGG8)
            {
                mermenreader.slot8zablokirovan = false;
                slot8GGshield.SetActive(true);
            }
            if (skreader.slot5target1 == skreader.slotGG9 || skreader.slot5target2 == skreader.slotGG9 || skreader.slot5target3 == skreader.slotGG9)
            {
                mermenreader.slot9zablokirovan = false;
                slot9GGshield.SetActive(true);
            }
        }
        else if (skreader.slot7skill == 39 && slotsgg.slot7Hp > 0)
        {
            if (skreader.slot7target1 == skreader.slotGG4 || skreader.slot7target2 == skreader.slotGG4 || skreader.slot7target3 == skreader.slotGG4)
            {
                mermenreader.slot4zablokirovan = false;
                slot4GGshield.SetActive(true);
            }
            if (skreader.slot7target1 == skreader.slotGG5 || skreader.slot7target2 == skreader.slotGG5 || skreader.slot7target3 == skreader.slotGG5)
            {
                mermenreader.slot5zablokirovan = false;
                slot5GGshield.SetActive(true);
            }
            if (skreader.slot7target1 == skreader.slotGG8 || skreader.slot7target2 == skreader.slotGG8 || skreader.slot7target3 == skreader.slotGG8)
            {
                mermenreader.slot8zablokirovan = false;
                slot8GGshield.SetActive(true);
            }
        }
        else if (skreader.slot8skill == 39 && slotsgg.slot8Hp > 0)
        {

            if (skreader.slot8target1 == skreader.slotGG4 || skreader.slot8target2 == skreader.slotGG4 || skreader.slot8target3 == skreader.slotGG4)
            {
                mermenreader.slot4zablokirovan = false;
                slot4GGshield.SetActive(true);
            }
            if (skreader.slot8target1 == skreader.slotGG5 || skreader.slot8target2 == skreader.slotGG5 || skreader.slot8target3 == skreader.slotGG5)
            {
                mermenreader.slot5zablokirovan = false;
                slot5GGshield.SetActive(true);
            }
            if (skreader.slot8target1 == skreader.slotGG6 || skreader.slot8target2 == skreader.slotGG6 || skreader.slot8target3 == skreader.slotGG6)
            {
                mermenreader.slot6zablokirovan = false;
                slot6GGshield.SetActive(true);
            }
            if (skreader.slot8target1 == skreader.slotGG7 || skreader.slot8target2 == skreader.slotGG7 || skreader.slot8target3 == skreader.slotGG7)
            {
                mermenreader.slot7zablokirovan = false;
                slot7GGshield.SetActive(true);
            }
            if (skreader.slot8target1 == skreader.slotGG9 || skreader.slot8target2 == skreader.slotGG9 || skreader.slot8target3 == skreader.slotGG9)
            {
                mermenreader.slot9zablokirovan = false;
                slot9GGshield.SetActive(true);
            }
        }
        else if (skreader.slot9skill == 39 && slotsgg.slot9Hp > 0)
        {

            if (skreader.slot9target1 == skreader.slotGG5 || skreader.slot9target2 == skreader.slotGG5 || skreader.slot9target3 == skreader.slotGG5)
            {
                mermenreader.slot5zablokirovan = false;
                slot5GGshield.SetActive(true);
            }
            if (skreader.slot9target1 == skreader.slotGG6 || skreader.slot9target2 == skreader.slotGG6 || skreader.slot9target3 == skreader.slotGG6)
            {
                mermenreader.slot6zablokirovan = false;
                slot6GGshield.SetActive(true);
            }
            if (skreader.slot9target1 == skreader.slotGG8 || skreader.slot9target2 == skreader.slotGG8 || skreader.slot9target3 == skreader.slotGG8)
            {
                mermenreader.slot8zablokirovan = false;
                slot8GGshield.SetActive(true);
            }
        }
        // снимает оставшиеся блоки с неуязвимых слотов
        if (mermenreader.slot1zablokirovan && (skreader.slot1skill == 22 || skreader.slot1skill == 42 || skreader.slot1skill == 43))
        {
            mermenreader.slot1zablokirovan = false;
        }
        if (mermenreader.slot2zablokirovan && (skreader.slot2skill == 22 || skreader.slot2skill == 42 || skreader.slot2skill == 43))
        {
            mermenreader.slot2zablokirovan = false;
        }
        if (mermenreader.slot3zablokirovan && (skreader.slot3skill == 22 || skreader.slot3skill == 42 || skreader.slot3skill == 43))
        {
            mermenreader.slot3zablokirovan = false;
        }
        if (mermenreader.slot4zablokirovan && (skreader.slot4skill == 22 || skreader.slot4skill == 42 || skreader.slot4skill == 43))
        {
            mermenreader.slot4zablokirovan = false;
        }
        if (mermenreader.slot5zablokirovan && (skreader.slot5skill == 22 || skreader.slot5skill == 42 || skreader.slot5skill == 43))
        {
            mermenreader.slot5zablokirovan = false;
        }
        if (mermenreader.slot6zablokirovan && (skreader.slot6skill == 22 || skreader.slot6skill == 42 || skreader.slot6skill == 43))
        {
            mermenreader.slot6zablokirovan = false;
        }
        if (mermenreader.slot7zablokirovan && (skreader.slot7skill == 22 || skreader.slot7skill == 42 || skreader.slot7skill == 43))
        {
            mermenreader.slot7zablokirovan = false;
        }
        if (mermenreader.slot8zablokirovan && (skreader.slot8skill == 22 || skreader.slot8skill == 42 || skreader.slot8skill == 43))
        {
            mermenreader.slot8zablokirovan = false;
        }
        if (mermenreader.slot9zablokirovan && (skreader.slot9skill == 22 || skreader.slot9skill == 42 || skreader.slot9skill == 43))
        {
            mermenreader.slot9zablokirovan = false;
        }
        if (mermenreader.slot1zablokVraga && (skreader.slot1skillVraga == 22 || skreader.slot1skillVraga == 42 || skreader.slot1skillVraga == 43))
        {
            mermenreader.slot1zablokVraga = false;
        }
        if (mermenreader.slot2zablokVraga && (skreader.slot2skillVraga == 22 || skreader.slot2skillVraga == 42 || skreader.slot2skillVraga == 43))
        {
            mermenreader.slot2zablokVraga = false;
        }
        if (mermenreader.slot3zablokVraga && (skreader.slot3skillVraga == 22 || skreader.slot3skillVraga == 42 || skreader.slot3skillVraga == 43))
        {
            mermenreader.slot3zablokVraga = false;
        }
        if (mermenreader.slot4zablokVraga && (skreader.slot4skillVraga == 22 || skreader.slot4skillVraga == 42 || skreader.slot4skillVraga == 43))
        {
            mermenreader.slot4zablokVraga = false;
        }
        if (mermenreader.slot5zablokVraga && (skreader.slot5skillVraga == 22 || skreader.slot5skillVraga == 42 || skreader.slot5skillVraga == 43))
        {
            mermenreader.slot5zablokVraga = false;
        }
        if (mermenreader.slot6zablokVraga && (skreader.slot6skillVraga == 22 || skreader.slot6skillVraga == 42 || skreader.slot6skillVraga == 43))
        {
            mermenreader.slot6zablokVraga = false;
        }
        if (mermenreader.slot7zablokVraga && (skreader.slot7skillVraga == 22 || skreader.slot7skillVraga == 42 || skreader.slot7skillVraga == 43))
        {
            mermenreader.slot7zablokVraga = false;
        }
        if (mermenreader.slot8zablokVraga && (skreader.slot8skillVraga == 22 || skreader.slot8skillVraga == 42 || skreader.slot8skillVraga == 43))
        {
            mermenreader.slot8zablokVraga = false;
        }
        if (mermenreader.slot9zablokVraga && (skreader.slot9skillVraga == 22 || skreader.slot9skillVraga == 42 || skreader.slot9skillVraga == 43))
        {
            mermenreader.slot9zablokVraga = false;
        }


        // отображение
        slot1GGbloch.SetActive(false);
        slot2GGbloch.SetActive(false);
        slot3GGbloch.SetActive(false);
        slot4GGbloch.SetActive(false);
        slot5GGbloch.SetActive(false);
        slot6GGbloch.SetActive(false);
        slot7GGbloch.SetActive(false);
        slot8GGbloch.SetActive(false);
        slot9GGbloch.SetActive(false);
        slot1Vragbloch.SetActive(false);
        slot2Vragbloch.SetActive(false);
        slot3Vragbloch.SetActive(false);
        slot4Vragbloch.SetActive(false);
        slot5Vragbloch.SetActive(false);
        slot6Vragbloch.SetActive(false);
        slot7Vragbloch.SetActive(false);
        slot8Vragbloch.SetActive(false);
        slot9Vragbloch.SetActive(false);
        mermenreader.blokderzhalka.SetActive(true);
        mermenreader.blokderzhalka1.SetActive(true);
        mermenreader.blokderzhalka2.SetActive(true);

        if (mermenreader.slot1zablokirovan == true && skreader.slot1skill != 4 && skreader.slot1skill != 9 && skreader.slot1skill != 15 && skreader.slot1skill != 19 && skreader.slot1skill != 24 && skreader.slot1skill != 27 && skreader.slot1skill != 37 && skreader.slot1skill != 38 && skreader.slot1skill != 5 && skreader.slot1skill != 12 && skreader.slot1skill != 29 && skreader.slot1skill != 39)
        {
            slot1GGbloch.SetActive(true);
        }
        if (mermenreader.slot2zablokirovan == true && skreader.slot2skill != 4 && skreader.slot2skill != 9 && skreader.slot2skill != 15 && skreader.slot2skill != 19 && skreader.slot2skill != 24 && skreader.slot2skill != 27 && skreader.slot2skill != 37 && skreader.slot2skill != 38 && skreader.slot2skill != 5 && skreader.slot2skill != 12 && skreader.slot2skill != 29 && skreader.slot2skill != 39)
        {
            slot2GGbloch.SetActive(true);
        }
        if (mermenreader.slot3zablokirovan == true && skreader.slot3skill != 4 && skreader.slot3skill != 9 && skreader.slot3skill != 15 && skreader.slot3skill != 19 && skreader.slot3skill != 24 && skreader.slot3skill != 27 && skreader.slot3skill != 37 && skreader.slot3skill != 38 && skreader.slot3skill != 5 && skreader.slot3skill != 12 && skreader.slot3skill != 29 && skreader.slot3skill != 39)
        {
            slot3GGbloch.SetActive(true);
        }
        if (mermenreader.slot4zablokirovan == true && skreader.slot4skill != 4 && skreader.slot4skill != 9 && skreader.slot4skill != 15 && skreader.slot4skill != 19 && skreader.slot4skill != 24 && skreader.slot4skill != 27 && skreader.slot4skill != 37 && skreader.slot4skill != 38 && skreader.slot4skill != 5 && skreader.slot4skill != 12 && skreader.slot4skill != 29 && skreader.slot4skill != 39)
        {
            slot4GGbloch.SetActive(true);
        }
        if (mermenreader.slot5zablokirovan == true && skreader.slot5skill != 4 && skreader.slot5skill != 9 && skreader.slot5skill != 15 && skreader.slot5skill != 19 && skreader.slot5skill != 24 && skreader.slot5skill != 27 && skreader.slot5skill != 37 && skreader.slot5skill != 38 && skreader.slot5skill != 5 && skreader.slot5skill != 12 && skreader.slot5skill != 29 && skreader.slot5skill != 39)
        {
            slot5GGbloch.SetActive(true);
        }
        if (mermenreader.slot6zablokirovan == true && skreader.slot6skill != 4 && skreader.slot6skill != 9 && skreader.slot6skill != 15 && skreader.slot6skill != 19 && skreader.slot6skill != 24 && skreader.slot6skill != 27 && skreader.slot6skill != 37 && skreader.slot6skill != 38 && skreader.slot6skill != 5 && skreader.slot6skill != 12 && skreader.slot6skill != 29 && skreader.slot6skill != 39)
        {
            slot6GGbloch.SetActive(true);
        }
        if (mermenreader.slot7zablokirovan == true && skreader.slot7skill != 4 && skreader.slot7skill != 9 && skreader.slot7skill != 15 && skreader.slot7skill != 19 && skreader.slot7skill != 24 && skreader.slot7skill != 27 && skreader.slot7skill != 37 && skreader.slot7skill != 38 && skreader.slot7skill != 5 && skreader.slot7skill != 12 && skreader.slot7skill != 29 && skreader.slot7skill != 39)
        {
            slot7GGbloch.SetActive(true);
        }
        if (mermenreader.slot8zablokirovan == true && skreader.slot8skill != 4 && skreader.slot8skill != 9 && skreader.slot8skill != 15 && skreader.slot8skill != 19 && skreader.slot8skill != 24 && skreader.slot8skill != 27 && skreader.slot8skill != 37 && skreader.slot8skill != 38 && skreader.slot8skill != 5 && skreader.slot8skill != 12 && skreader.slot8skill != 29 && skreader.slot8skill != 39)
        {
            slot8GGbloch.SetActive(true);
        }
        if (mermenreader.slot9zablokirovan == true && skreader.slot9skill != 4 && skreader.slot9skill != 9 && skreader.slot9skill != 15 && skreader.slot9skill != 19 && skreader.slot9skill != 24 && skreader.slot9skill != 27 && skreader.slot9skill != 37 && skreader.slot9skill != 38 && skreader.slot9skill != 5 && skreader.slot9skill != 12 && skreader.slot9skill != 29 && skreader.slot9skill != 39)
        {
            slot9GGbloch.SetActive(true);
        }
        if (mermenreader.slot1zablokVraga == true && skreader.slot1skillVraga != 4 && skreader.slot1skillVraga != 9 && skreader.slot1skillVraga != 15 && skreader.slot1skillVraga != 19 && skreader.slot1skillVraga != 24 && skreader.slot1skillVraga != 27 && skreader.slot1skillVraga != 37 && skreader.slot1skillVraga != 38 && skreader.slot1skillVraga != 5 && skreader.slot1skillVraga != 12 && skreader.slot1skillVraga != 29 && skreader.slot1skillVraga != 39)
        {
            slot1Vragbloch.SetActive(true);
        }
        if (mermenreader.slot2zablokVraga == true && skreader.slot2skillVraga != 4 && skreader.slot2skillVraga != 9 && skreader.slot2skillVraga != 15 && skreader.slot2skillVraga != 19 && skreader.slot2skillVraga != 24 && skreader.slot2skillVraga != 27 && skreader.slot2skillVraga != 37 && skreader.slot2skillVraga != 38 && skreader.slot2skillVraga != 5 && skreader.slot2skillVraga != 12 && skreader.slot2skillVraga != 29 && skreader.slot2skillVraga != 39)
        {
            slot2Vragbloch.SetActive(true);
        }
        if (mermenreader.slot3zablokVraga == true && skreader.slot3skillVraga != 4 && skreader.slot3skillVraga != 9 && skreader.slot3skillVraga != 15 && skreader.slot3skillVraga != 19 && skreader.slot3skillVraga != 24 && skreader.slot3skillVraga != 27 && skreader.slot3skillVraga != 37 && skreader.slot3skillVraga != 38 && skreader.slot3skillVraga != 5 && skreader.slot3skillVraga != 12 && skreader.slot3skillVraga != 29 && skreader.slot3skillVraga != 39)
        {
            slot3Vragbloch.SetActive(true);
        }
        if (mermenreader.slot4zablokVraga == true && skreader.slot4skillVraga != 4 && skreader.slot4skillVraga != 9 && skreader.slot4skillVraga != 15 && skreader.slot4skillVraga != 19 && skreader.slot4skillVraga != 24 && skreader.slot4skillVraga != 27 && skreader.slot4skillVraga != 37 && skreader.slot4skillVraga != 38 && skreader.slot4skillVraga != 5 && skreader.slot4skillVraga != 12 && skreader.slot4skillVraga != 29 && skreader.slot4skillVraga != 39)
        {
            slot4Vragbloch.SetActive(true);
        }
        if (mermenreader.slot5zablokVraga == true && skreader.slot5skillVraga != 4 && skreader.slot5skillVraga != 9 && skreader.slot5skillVraga != 15 && skreader.slot5skillVraga != 19 && skreader.slot5skillVraga != 24 && skreader.slot5skillVraga != 27 && skreader.slot5skillVraga != 37 && skreader.slot5skillVraga != 38 && skreader.slot5skillVraga != 5 && skreader.slot5skillVraga != 12 && skreader.slot5skillVraga != 29 && skreader.slot5skillVraga != 39)
        {
            slot5Vragbloch.SetActive(true);
        }
        if (mermenreader.slot6zablokVraga == true && skreader.slot6skillVraga != 4 && skreader.slot6skillVraga != 9 && skreader.slot6skillVraga != 15 && skreader.slot6skillVraga != 19 && skreader.slot6skillVraga != 24 && skreader.slot6skillVraga != 27 && skreader.slot6skillVraga != 37 && skreader.slot6skillVraga != 38 && skreader.slot6skillVraga != 5 && skreader.slot6skillVraga != 12 && skreader.slot6skillVraga != 29 && skreader.slot6skillVraga != 39)
        {
            slot6Vragbloch.SetActive(true);
        }
        if (mermenreader.slot7zablokVraga == true && skreader.slot7skillVraga != 4 && skreader.slot7skillVraga != 9 && skreader.slot7skillVraga != 15 && skreader.slot7skillVraga != 19 && skreader.slot7skillVraga != 24 && skreader.slot7skillVraga != 27 && skreader.slot7skillVraga != 37 && skreader.slot7skillVraga != 38 && skreader.slot7skillVraga != 5 && skreader.slot7skillVraga != 12 && skreader.slot7skillVraga != 29 && skreader.slot7skillVraga != 39)
        {
            slot7Vragbloch.SetActive(true);
        }
        if (mermenreader.slot8zablokVraga == true && skreader.slot8skillVraga != 4 && skreader.slot8skillVraga != 9 && skreader.slot8skillVraga != 15 && skreader.slot8skillVraga != 19 && skreader.slot8skillVraga != 24 && skreader.slot8skillVraga != 27 && skreader.slot8skillVraga != 37 && skreader.slot8skillVraga != 38 && skreader.slot8skillVraga != 5 && skreader.slot8skillVraga != 12 && skreader.slot8skillVraga != 29 && skreader.slot8skillVraga != 39)
        {
            slot8Vragbloch.SetActive(true);
        }
        if (mermenreader.slot9zablokVraga == true && skreader.slot9skillVraga != 4 && skreader.slot9skillVraga != 9 && skreader.slot9skillVraga != 15 && skreader.slot9skillVraga != 19 && skreader.slot9skillVraga != 24 && skreader.slot9skillVraga != 27 && skreader.slot9skillVraga != 37 && skreader.slot9skillVraga != 38 && skreader.slot9skillVraga != 5 && skreader.slot9skillVraga != 12 && skreader.slot9skillVraga != 29 && skreader.slot9skillVraga != 39)
        {
            slot9Vragbloch.SetActive(true);
        }
    }


    public void lovushkaProverka()
    {
        if (chitalkaTarget1 == skreader.slotGG1 || chitalkaTarget2 == skreader.slotGG1 || chitalkaTarget3 == skreader.slotGG1) // если мишень - 1 слот гг
        {
            if (skreader.slot1skill == 20 && slotsgg.slot1Hp > 0f) // если там стоит ловушка (несработавшая, с хп!)
            {
                lovushka.Play(0);
                slotsgg.slot1Hp = 0f; // самоуничтожение ловушки
                if (slot1GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot1Hp = 0f;
                }
                else if (slot1Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo1Hp = 0f;
                }
                else if (slot2GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot2Hp = 0f;
                }
                else if (slot2Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo2Hp = 0f;
                }
                else if (slot3GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot3Hp = 0f;
                }
                else if (slot3Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo3Hp = 0f;
                }
                else if (slot4GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot4Hp = 0f;
                }
                else if (slot4Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo4Hp = 0f;
                }
                else if (slot5GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot5Hp = 0f;
                }
                else if (slot5Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo5Hp = 0f;
                }
                else if (slot6GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot6Hp = 0f;
                }
                else if (slot6Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo6Hp = 0f;
                }
                else if (slot7GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot7Hp = 0f;
                }
                else if (slot7Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo7Hp = 0f;
                }
                else if (slot8GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot8Hp = 0f;
                }
                else if (slot8Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo8Hp = 0f;
                }
                else if (slot9GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot9Hp = 0f;
                }
                else if (slot9Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo9Hp = 0f;
                }

            }
        }
        if (chitalkaTarget1 == skreader.slotGG3 || chitalkaTarget2 == skreader.slotGG3 || chitalkaTarget3 == skreader.slotGG3) // если мишень - 3 слот гг
        {
            if (skreader.slot3skill == 20 && slotsgg.slot3Hp > 0f) // если там стоит ловушка (несработавшая, с хп!)
            {
                lovushka.Play(0);
                slotsgg.slot3Hp = 0f; // самоуничтожение ловушки
                if (slot1GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot1Hp = 0f;
                }
                else if (slot1Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo1Hp = 0f;
                }
                else if (slot2GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot2Hp = 0f;
                }
                else if (slot2Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo2Hp = 0f;
                }
                else if (slot3GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot3Hp = 0f;
                }
                else if (slot3Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo3Hp = 0f;
                }
                else if (slot4GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot4Hp = 0f;
                }
                else if (slot4Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo4Hp = 0f;
                }
                else if (slot5GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot5Hp = 0f;
                }
                else if (slot5Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo5Hp = 0f;
                }
                else if (slot6GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot6Hp = 0f;
                }
                else if (slot6Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo6Hp = 0f;
                }
                else if (slot7GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot7Hp = 0f;
                }
                else if (slot7Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo7Hp = 0f;
                }
                else if (slot8GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot8Hp = 0f;
                }
                else if (slot8Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo8Hp = 0f;
                }
                else if (slot9GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot9Hp = 0f;
                }
                else if (slot9Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo9Hp = 0f;
                }

            }
        }
        if (chitalkaTarget1 == skreader.slotGG4 || chitalkaTarget2 == skreader.slotGG4 || chitalkaTarget3 == skreader.slotGG4) // если мишень - 1 слот гг
        {
            if (skreader.slot4skill == 41 && slotsgg.slot4Hp > 0f) // если там стоит ловушка (несработавшая, с хп!)
            {
                lovushka.Play(0);
                slotsgg.slot4Hp = 0f; // самоуничтожение ловушки
                if (slot1GGsvet.activeSelf == true)
                {
                    slotsgg.slot1Hp = 0f;
                    slotsgg.slot4Hp = 0f;
                    slotsgg.slot7Hp = 0f;
                }
                else if (slot1Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo1Hp = 0f;
                    slotsmerman.slo4Hp = 0f;
                    slotsmerman.slo7Hp = 0f;
                }
                else if (slot2GGsvet.activeSelf == true)
                {
                    slotsgg.slot2Hp = 0f;
                    slotsgg.slot5Hp = 0f;
                    slotsgg.slot8Hp = 0f;
                }
                else if (slot2Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo2Hp = 0f;
                    slotsmerman.slo5Hp = 0f;
                    slotsmerman.slo8Hp = 0f;
                }
                else if (slot3GGsvet.activeSelf == true)
                {
                    slotsgg.slot3Hp = 0f;
                    slotsgg.slot6Hp = 0f;
                    slotsgg.slot9Hp = 0f;
                }
                else if (slot3Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo3Hp = 0f;
                    slotsmerman.slo6Hp = 0f;
                    slotsmerman.slo9Hp = 0f;
                }
                else if (slot4GGsvet.activeSelf == true)
                {
                    slotsgg.slot1Hp = 0f;
                    slotsgg.slot4Hp = 0f;
                    slotsgg.slot7Hp = 0f;
                }
                else if (slot4Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo1Hp = 0f;
                    slotsmerman.slo4Hp = 0f;
                    slotsmerman.slo7Hp = 0f;
                }
                else if (slot5GGsvet.activeSelf == true)
                {
                    slotsgg.slot2Hp = 0f;
                    slotsgg.slot5Hp = 0f;
                    slotsgg.slot8Hp = 0f;
                }
                else if (slot5Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo2Hp = 0f;
                    slotsmerman.slo5Hp = 0f;
                    slotsmerman.slo8Hp = 0f;
                }
                else if (slot6GGsvet.activeSelf == true)
                {
                    slotsgg.slot3Hp = 0f;
                    slotsgg.slot6Hp = 0f;
                    slotsgg.slot9Hp = 0f;
                }
                else if (slot6Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo3Hp = 0f;
                    slotsmerman.slo6Hp = 0f;
                    slotsmerman.slo9Hp = 0f;
                }
                else if (slot7GGsvet.activeSelf == true)
                {
                    slotsgg.slot1Hp = 0f;
                    slotsgg.slot4Hp = 0f;
                    slotsgg.slot7Hp = 0f;
                }
                else if (slot7Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo1Hp = 0f;
                    slotsmerman.slo4Hp = 0f;
                    slotsmerman.slo7Hp = 0f;
                }
                else if (slot8GGsvet.activeSelf == true)
                {
                    slotsgg.slot2Hp = 0f;
                    slotsgg.slot5Hp = 0f;
                    slotsgg.slot8Hp = 0f;
                }
                else if (slot8Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo2Hp = 0f;
                    slotsmerman.slo5Hp = 0f;
                    slotsmerman.slo8Hp = 0f;
                }
                else if (slot9GGsvet.activeSelf == true)
                {
                    slotsgg.slot3Hp = 0f;
                    slotsgg.slot6Hp = 0f;
                    slotsgg.slot9Hp = 0f;
                }
                else if (slot9Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo3Hp = 0f;
                    slotsmerman.slo6Hp = 0f;
                    slotsmerman.slo9Hp = 0f;
                }

            }
        }
        if (chitalkaTarget1 == skreader.slotGG6 || chitalkaTarget2 == skreader.slotGG6 || chitalkaTarget3 == skreader.slotGG6) // если мишень - 6 слот гг
        {
            if (skreader.slot6skill == 20 && slotsgg.slot6Hp > 0f) // если там стоит ловушка (несработавшая, с хп!)
            {
                lovushka.Play(0);
                slotsgg.slot6Hp = 0f; // самоуничтожение ловушки
                if (slot1GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot1Hp = 0f;
                }
                else if (slot1Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo1Hp = 0f;
                }
                else if (slot2GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot2Hp = 0f;
                }
                else if (slot2Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo2Hp = 0f;
                }
                else if (slot3GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot3Hp = 0f;
                }
                else if (slot3Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo3Hp = 0f;
                }
                else if (slot4GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot4Hp = 0f;
                }
                else if (slot4Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo4Hp = 0f;
                }
                else if (slot5GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot5Hp = 0f;
                }
                else if (slot5Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo5Hp = 0f;
                }
                else if (slot6GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot6Hp = 0f;
                }
                else if (slot6Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo6Hp = 0f;
                }
                else if (slot7GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot7Hp = 0f;
                }
                else if (slot7Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo7Hp = 0f;
                }
                else if (slot8GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot8Hp = 0f;
                }
                else if (slot8Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo8Hp = 0f;
                }
                else if (slot9GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot9Hp = 0f;
                }
                else if (slot9Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo9Hp = 0f;
                }

            }
            else if (skreader.slot6skill == 41 && slotsgg.slot6Hp > 0f) // если там стоит ловушка (несработавшая, с хп!)
            {
                lovushka.Play(0);
                slotsgg.slot6Hp = 0f; // самоуничтожение ловушки
                if (slot1GGsvet.activeSelf == true)
                {
                    slotsgg.slot1Hp = 0f;
                    slotsgg.slot4Hp = 0f;
                    slotsgg.slot7Hp = 0f;
                }
                else if (slot1Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo1Hp = 0f;
                    slotsmerman.slo4Hp = 0f;
                    slotsmerman.slo7Hp = 0f;
                }
                else if (slot2GGsvet.activeSelf == true)
                {
                    slotsgg.slot2Hp = 0f;
                    slotsgg.slot5Hp = 0f;
                    slotsgg.slot8Hp = 0f;
                }
                else if (slot2Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo2Hp = 0f;
                    slotsmerman.slo5Hp = 0f;
                    slotsmerman.slo8Hp = 0f;
                }
                else if (slot3GGsvet.activeSelf == true)
                {
                    slotsgg.slot3Hp = 0f;
                    slotsgg.slot6Hp = 0f;
                    slotsgg.slot9Hp = 0f;
                }
                else if (slot3Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo3Hp = 0f;
                    slotsmerman.slo6Hp = 0f;
                    slotsmerman.slo9Hp = 0f;
                }
                else if (slot4GGsvet.activeSelf == true)
                {
                    slotsgg.slot1Hp = 0f;
                    slotsgg.slot4Hp = 0f;
                    slotsgg.slot7Hp = 0f;
                }
                else if (slot4Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo1Hp = 0f;
                    slotsmerman.slo4Hp = 0f;
                    slotsmerman.slo7Hp = 0f;
                }
                else if (slot5GGsvet.activeSelf == true)
                {
                    slotsgg.slot2Hp = 0f;
                    slotsgg.slot5Hp = 0f;
                    slotsgg.slot8Hp = 0f;
                }
                else if (slot5Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo2Hp = 0f;
                    slotsmerman.slo5Hp = 0f;
                    slotsmerman.slo8Hp = 0f;
                }
                else if (slot6GGsvet.activeSelf == true)
                {
                    slotsgg.slot3Hp = 0f;
                    slotsgg.slot6Hp = 0f;
                    slotsgg.slot9Hp = 0f;
                }
                else if (slot6Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo3Hp = 0f;
                    slotsmerman.slo6Hp = 0f;
                    slotsmerman.slo9Hp = 0f;
                }
                else if (slot7GGsvet.activeSelf == true)
                {
                    slotsgg.slot1Hp = 0f;
                    slotsgg.slot4Hp = 0f;
                    slotsgg.slot7Hp = 0f;
                }
                else if (slot7Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo1Hp = 0f;
                    slotsmerman.slo4Hp = 0f;
                    slotsmerman.slo7Hp = 0f;
                }
                else if (slot8GGsvet.activeSelf == true)
                {
                    slotsgg.slot2Hp = 0f;
                    slotsgg.slot5Hp = 0f;
                    slotsgg.slot8Hp = 0f;
                }
                else if (slot8Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo2Hp = 0f;
                    slotsmerman.slo5Hp = 0f;
                    slotsmerman.slo8Hp = 0f;
                }
                else if (slot9GGsvet.activeSelf == true)
                {
                    slotsgg.slot3Hp = 0f;
                    slotsgg.slot6Hp = 0f;
                    slotsgg.slot9Hp = 0f;
                }
                else if (slot9Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo3Hp = 0f;
                    slotsmerman.slo6Hp = 0f;
                    slotsmerman.slo9Hp = 0f;
                }

            }
        }
        if (chitalkaTarget1 == skreader.slotGG7 || chitalkaTarget2 == skreader.slotGG7 || chitalkaTarget3 == skreader.slotGG7) // если мишень - 1 слот гг
        {
            if (skreader.slot7skill == 41 && slotsgg.slot7Hp > 0f) // если там стоит ловушка (несработавшая, с хп!)
            {
                lovushka.Play(0);
                slotsgg.slot7Hp = 0f; // самоуничтожение ловушки
                if (slot1GGsvet.activeSelf == true)
                {
                    slotsgg.slot1Hp = 0f;
                    slotsgg.slot4Hp = 0f;
                    slotsgg.slot7Hp = 0f;
                }
                else if (slot1Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo1Hp = 0f;
                    slotsmerman.slo4Hp = 0f;
                    slotsmerman.slo7Hp = 0f;
                }
                else if (slot2GGsvet.activeSelf == true)
                {
                    slotsgg.slot2Hp = 0f;
                    slotsgg.slot5Hp = 0f;
                    slotsgg.slot8Hp = 0f;
                }
                else if (slot2Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo2Hp = 0f;
                    slotsmerman.slo5Hp = 0f;
                    slotsmerman.slo8Hp = 0f;
                }
                else if (slot3GGsvet.activeSelf == true)
                {
                    slotsgg.slot3Hp = 0f;
                    slotsgg.slot6Hp = 0f;
                    slotsgg.slot9Hp = 0f;
                }
                else if (slot3Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo3Hp = 0f;
                    slotsmerman.slo6Hp = 0f;
                    slotsmerman.slo9Hp = 0f;
                }
                else if (slot4GGsvet.activeSelf == true)
                {
                    slotsgg.slot1Hp = 0f;
                    slotsgg.slot4Hp = 0f;
                    slotsgg.slot7Hp = 0f;
                }
                else if (slot4Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo1Hp = 0f;
                    slotsmerman.slo4Hp = 0f;
                    slotsmerman.slo7Hp = 0f;
                }
                else if (slot5GGsvet.activeSelf == true)
                {
                    slotsgg.slot2Hp = 0f;
                    slotsgg.slot5Hp = 0f;
                    slotsgg.slot8Hp = 0f;
                }
                else if (slot5Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo2Hp = 0f;
                    slotsmerman.slo5Hp = 0f;
                    slotsmerman.slo8Hp = 0f;
                }
                else if (slot6GGsvet.activeSelf == true)
                {
                    slotsgg.slot3Hp = 0f;
                    slotsgg.slot6Hp = 0f;
                    slotsgg.slot9Hp = 0f;
                }
                else if (slot6Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo3Hp = 0f;
                    slotsmerman.slo6Hp = 0f;
                    slotsmerman.slo9Hp = 0f;
                }
                else if (slot7GGsvet.activeSelf == true)
                {
                    slotsgg.slot1Hp = 0f;
                    slotsgg.slot4Hp = 0f;
                    slotsgg.slot7Hp = 0f;
                }
                else if (slot7Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo1Hp = 0f;
                    slotsmerman.slo4Hp = 0f;
                    slotsmerman.slo7Hp = 0f;
                }
                else if (slot8GGsvet.activeSelf == true)
                {
                    slotsgg.slot2Hp = 0f;
                    slotsgg.slot5Hp = 0f;
                    slotsgg.slot8Hp = 0f;
                }
                else if (slot8Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo2Hp = 0f;
                    slotsmerman.slo5Hp = 0f;
                    slotsmerman.slo8Hp = 0f;
                }
                else if (slot9GGsvet.activeSelf == true)
                {
                    slotsgg.slot3Hp = 0f;
                    slotsgg.slot6Hp = 0f;
                    slotsgg.slot9Hp = 0f;
                }
                else if (slot9Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo3Hp = 0f;
                    slotsmerman.slo6Hp = 0f;
                    slotsmerman.slo9Hp = 0f;
                }

            }
        }
        if (chitalkaTarget1 == skreader.slotGG8 || chitalkaTarget2 == skreader.slotGG8 || chitalkaTarget3 == skreader.slotGG8) // если мишень - 1 слот гг
        {
            if (skreader.slot8skill == 41 && slotsgg.slot8Hp > 0f) // если там стоит ловушка (несработавшая, с хп!)
            {
                lovushka.Play(0);
                slotsgg.slot8Hp = 0f; // самоуничтожение ловушки
                if (slot1GGsvet.activeSelf == true)
                {
                    slotsgg.slot1Hp = 0f;
                    slotsgg.slot4Hp = 0f;
                    slotsgg.slot7Hp = 0f;
                }
                else if (slot1Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo1Hp = 0f;
                    slotsmerman.slo4Hp = 0f;
                    slotsmerman.slo7Hp = 0f;
                }
                else if (slot2GGsvet.activeSelf == true)
                {
                    slotsgg.slot2Hp = 0f;
                    slotsgg.slot5Hp = 0f;
                    slotsgg.slot8Hp = 0f;
                }
                else if (slot2Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo2Hp = 0f;
                    slotsmerman.slo5Hp = 0f;
                    slotsmerman.slo8Hp = 0f;
                }
                else if (slot3GGsvet.activeSelf == true)
                {
                    slotsgg.slot3Hp = 0f;
                    slotsgg.slot6Hp = 0f;
                    slotsgg.slot9Hp = 0f;
                }
                else if (slot3Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo3Hp = 0f;
                    slotsmerman.slo6Hp = 0f;
                    slotsmerman.slo9Hp = 0f;
                }
                else if (slot4GGsvet.activeSelf == true)
                {
                    slotsgg.slot1Hp = 0f;
                    slotsgg.slot4Hp = 0f;
                    slotsgg.slot7Hp = 0f;
                }
                else if (slot4Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo1Hp = 0f;
                    slotsmerman.slo4Hp = 0f;
                    slotsmerman.slo7Hp = 0f;
                }
                else if (slot5GGsvet.activeSelf == true)
                {
                    slotsgg.slot2Hp = 0f;
                    slotsgg.slot5Hp = 0f;
                    slotsgg.slot8Hp = 0f;
                }
                else if (slot5Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo2Hp = 0f;
                    slotsmerman.slo5Hp = 0f;
                    slotsmerman.slo8Hp = 0f;
                }
                else if (slot6GGsvet.activeSelf == true)
                {
                    slotsgg.slot3Hp = 0f;
                    slotsgg.slot6Hp = 0f;
                    slotsgg.slot9Hp = 0f;
                }
                else if (slot6Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo3Hp = 0f;
                    slotsmerman.slo6Hp = 0f;
                    slotsmerman.slo9Hp = 0f;
                }
                else if (slot7GGsvet.activeSelf == true)
                {
                    slotsgg.slot1Hp = 0f;
                    slotsgg.slot4Hp = 0f;
                    slotsgg.slot7Hp = 0f;
                }
                else if (slot7Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo1Hp = 0f;
                    slotsmerman.slo4Hp = 0f;
                    slotsmerman.slo7Hp = 0f;
                }
                else if (slot8GGsvet.activeSelf == true)
                {
                    slotsgg.slot2Hp = 0f;
                    slotsgg.slot5Hp = 0f;
                    slotsgg.slot8Hp = 0f;
                }
                else if (slot8Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo2Hp = 0f;
                    slotsmerman.slo5Hp = 0f;
                    slotsmerman.slo8Hp = 0f;
                }
                else if (slot9GGsvet.activeSelf == true)
                {
                    slotsgg.slot3Hp = 0f;
                    slotsgg.slot6Hp = 0f;
                    slotsgg.slot9Hp = 0f;
                }
                else if (slot9Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo3Hp = 0f;
                    slotsmerman.slo6Hp = 0f;
                    slotsmerman.slo9Hp = 0f;
                }

            }
        }
        if (chitalkaTarget1 == skreader.slotGG9 || chitalkaTarget2 == skreader.slotGG9 || chitalkaTarget3 == skreader.slotGG9) // если мишень - 1 слот гг
        {
            if (skreader.slot9skill == 41 && slotsgg.slot9Hp > 0f) // если там стоит ловушка (несработавшая, с хп!)
            {
                lovushka.Play(0);
                slotsgg.slot9Hp = 0f; // самоуничтожение ловушки
                if (slot1GGsvet.activeSelf == true)
                {
                    slotsgg.slot1Hp = 0f;
                    slotsgg.slot4Hp = 0f;
                    slotsgg.slot7Hp = 0f;
                }
                else if (slot1Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo1Hp = 0f;
                    slotsmerman.slo4Hp = 0f;
                    slotsmerman.slo7Hp = 0f;
                }
                else if (slot2GGsvet.activeSelf == true)
                {
                    slotsgg.slot2Hp = 0f;
                    slotsgg.slot5Hp = 0f;
                    slotsgg.slot8Hp = 0f;
                }
                else if (slot2Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo2Hp = 0f;
                    slotsmerman.slo5Hp = 0f;
                    slotsmerman.slo8Hp = 0f;
                }
                else if (slot3GGsvet.activeSelf == true)
                {
                    slotsgg.slot3Hp = 0f;
                    slotsgg.slot6Hp = 0f;
                    slotsgg.slot9Hp = 0f;
                }
                else if (slot3Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo3Hp = 0f;
                    slotsmerman.slo6Hp = 0f;
                    slotsmerman.slo9Hp = 0f;
                }
                else if (slot4GGsvet.activeSelf == true)
                {
                    slotsgg.slot1Hp = 0f;
                    slotsgg.slot4Hp = 0f;
                    slotsgg.slot7Hp = 0f;
                }
                else if (slot4Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo1Hp = 0f;
                    slotsmerman.slo4Hp = 0f;
                    slotsmerman.slo7Hp = 0f;
                }
                else if (slot5GGsvet.activeSelf == true)
                {
                    slotsgg.slot2Hp = 0f;
                    slotsgg.slot5Hp = 0f;
                    slotsgg.slot8Hp = 0f;
                }
                else if (slot5Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo2Hp = 0f;
                    slotsmerman.slo5Hp = 0f;
                    slotsmerman.slo8Hp = 0f;
                }
                else if (slot6GGsvet.activeSelf == true)
                {
                    slotsgg.slot3Hp = 0f;
                    slotsgg.slot6Hp = 0f;
                    slotsgg.slot9Hp = 0f;
                }
                else if (slot6Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo3Hp = 0f;
                    slotsmerman.slo6Hp = 0f;
                    slotsmerman.slo9Hp = 0f;
                }
                else if (slot7GGsvet.activeSelf == true)
                {
                    slotsgg.slot1Hp = 0f;
                    slotsgg.slot4Hp = 0f;
                    slotsgg.slot7Hp = 0f;
                }
                else if (slot7Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo1Hp = 0f;
                    slotsmerman.slo4Hp = 0f;
                    slotsmerman.slo7Hp = 0f;
                }
                else if (slot8GGsvet.activeSelf == true)
                {
                    slotsgg.slot2Hp = 0f;
                    slotsgg.slot5Hp = 0f;
                    slotsgg.slot8Hp = 0f;
                }
                else if (slot8Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo2Hp = 0f;
                    slotsmerman.slo5Hp = 0f;
                    slotsmerman.slo8Hp = 0f;
                }
                else if (slot9GGsvet.activeSelf == true)
                {
                    slotsgg.slot3Hp = 0f;
                    slotsgg.slot6Hp = 0f;
                    slotsgg.slot9Hp = 0f;
                }
                else if (slot9Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo3Hp = 0f;
                    slotsmerman.slo6Hp = 0f;
                    slotsmerman.slo9Hp = 0f;
                }

            }
        }



        if (chitalkaTarget1 == skreader.slotVraga1 || chitalkaTarget2 == skreader.slotVraga1 || chitalkaTarget3 == skreader.slotVraga1) // если мишень - 1 слот гг
        {
            if (skreader.slot1skillVraga == 20 && slotsmerman.slo1Hp > 0f) // если там стоит ловушка (несработавшая, с хп!)
            {
                lovushka.Play(0);
                slotsmerman.slo1Hp = 0f; // самоуничтожение ловушки
                if (slot1GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot1Hp = 0f;
                }
                else if (slot1Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo1Hp = 0f;
                }
                else if (slot2GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot2Hp = 0f;
                }
                else if (slot2Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo2Hp = 0f;
                }
                else if (slot3GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot3Hp = 0f;
                }
                else if (slot3Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo3Hp = 0f;
                }
                else if (slot4GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot4Hp = 0f;
                }
                else if (slot4Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo4Hp = 0f;
                }
                else if (slot5GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot5Hp = 0f;
                }
                else if (slot5Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo5Hp = 0f;
                }
                else if (slot6GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot6Hp = 0f;
                }
                else if (slot6Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo6Hp = 0f;
                }
                else if (slot7GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot7Hp = 0f;
                }
                else if (slot7Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo7Hp = 0f;
                }
                else if (slot8GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot8Hp = 0f;
                }
                else if (slot8Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo8Hp = 0f;
                }
                else if (slot9GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot9Hp = 0f;
                }
                else if (slot9Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo9Hp = 0f;
                }

            }
        }
        if (chitalkaTarget1 == skreader.slotVraga3 || chitalkaTarget2 == skreader.slotVraga3 || chitalkaTarget3 == skreader.slotVraga3) // если мишень - 1 слот гг
        {
            if (skreader.slot3skillVraga == 20 && slotsmerman.slo3Hp > 0f) // если там стоит ловушка (несработавшая, с хп!)
            {
                lovushka.Play(0);
                slotsmerman.slo3Hp = 0f; // самоуничтожение ловушки
                if (slot1GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot1Hp = 0f;
                }
                else if (slot1Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo1Hp = 0f;
                }
                else if (slot2GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot2Hp = 0f;
                }
                else if (slot2Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo2Hp = 0f;
                }
                else if (slot3GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot3Hp = 0f;
                }
                else if (slot3Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo3Hp = 0f;
                }
                else if (slot4GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot4Hp = 0f;
                }
                else if (slot4Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo4Hp = 0f;
                }
                else if (slot5GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot5Hp = 0f;
                }
                else if (slot5Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo5Hp = 0f;
                }
                else if (slot6GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot6Hp = 0f;
                }
                else if (slot6Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo6Hp = 0f;
                }
                else if (slot7GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot7Hp = 0f;
                }
                else if (slot7Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo7Hp = 0f;
                }
                else if (slot8GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot8Hp = 0f;
                }
                else if (slot8Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo8Hp = 0f;
                }
                else if (slot9GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot9Hp = 0f;
                }
                else if (slot9Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo9Hp = 0f;
                }

            }
        }
        if (chitalkaTarget1 == skreader.slotVraga4 || chitalkaTarget2 == skreader.slotVraga4 || chitalkaTarget3 == skreader.slotVraga4) // если мишень - 1 слот гг
        {
            if (skreader.slot4skillVraga == 41 && slotsmerman.slo4Hp > 0f) // если там стоит ловушка (несработавшая, с хп!)
            {
                lovushka.Play(0);
                slotsmerman.slo4Hp = 0f; // самоуничтожение ловушки
                if (slot1GGsvet.activeSelf == true)
                {
                    slotsgg.slot1Hp = 0f;
                    slotsgg.slot4Hp = 0f;
                    slotsgg.slot7Hp = 0f;
                }
                else if (slot1Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo1Hp = 0f;
                    slotsmerman.slo4Hp = 0f;
                    slotsmerman.slo7Hp = 0f;
                }
                else if (slot2GGsvet.activeSelf == true)
                {
                    slotsgg.slot2Hp = 0f;
                    slotsgg.slot5Hp = 0f;
                    slotsgg.slot8Hp = 0f;
                }
                else if (slot2Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo2Hp = 0f;
                    slotsmerman.slo5Hp = 0f;
                    slotsmerman.slo8Hp = 0f;
                }
                else if (slot3GGsvet.activeSelf == true)
                {
                    slotsgg.slot3Hp = 0f;
                    slotsgg.slot6Hp = 0f;
                    slotsgg.slot9Hp = 0f;
                }
                else if (slot3Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo3Hp = 0f;
                    slotsmerman.slo6Hp = 0f;
                    slotsmerman.slo9Hp = 0f;
                }
                else if (slot4GGsvet.activeSelf == true)
                {
                    slotsgg.slot1Hp = 0f;
                    slotsgg.slot4Hp = 0f;
                    slotsgg.slot7Hp = 0f;
                }
                else if (slot4Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo1Hp = 0f;
                    slotsmerman.slo4Hp = 0f;
                    slotsmerman.slo7Hp = 0f;
                }
                else if (slot5GGsvet.activeSelf == true)
                {
                    slotsgg.slot2Hp = 0f;
                    slotsgg.slot5Hp = 0f;
                    slotsgg.slot8Hp = 0f;
                }
                else if (slot5Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo2Hp = 0f;
                    slotsmerman.slo5Hp = 0f;
                    slotsmerman.slo8Hp = 0f;
                }
                else if (slot6GGsvet.activeSelf == true)
                {
                    slotsgg.slot3Hp = 0f;
                    slotsgg.slot6Hp = 0f;
                    slotsgg.slot9Hp = 0f;
                }
                else if (slot6Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo3Hp = 0f;
                    slotsmerman.slo6Hp = 0f;
                    slotsmerman.slo9Hp = 0f;
                }
                else if (slot7GGsvet.activeSelf == true)
                {
                    slotsgg.slot1Hp = 0f;
                    slotsgg.slot4Hp = 0f;
                    slotsgg.slot7Hp = 0f;
                }
                else if (slot7Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo1Hp = 0f;
                    slotsmerman.slo4Hp = 0f;
                    slotsmerman.slo7Hp = 0f;
                }
                else if (slot8GGsvet.activeSelf == true)
                {
                    slotsgg.slot2Hp = 0f;
                    slotsgg.slot5Hp = 0f;
                    slotsgg.slot8Hp = 0f;
                }
                else if (slot8Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo2Hp = 0f;
                    slotsmerman.slo5Hp = 0f;
                    slotsmerman.slo8Hp = 0f;
                }
                else if (slot9GGsvet.activeSelf == true)
                {
                    slotsgg.slot3Hp = 0f;
                    slotsgg.slot6Hp = 0f;
                    slotsgg.slot9Hp = 0f;
                }
                else if (slot9Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo3Hp = 0f;
                    slotsmerman.slo6Hp = 0f;
                    slotsmerman.slo9Hp = 0f;
                }

            }
        }
        if (chitalkaTarget1 == skreader.slotVraga6 || chitalkaTarget2 == skreader.slotVraga6 || chitalkaTarget3 == skreader.slotVraga6) // если мишень - 1 слот гг
        {
            if (skreader.slot6skillVraga == 20 && slotsmerman.slo6Hp > 0f) // если там стоит ловушка (несработавшая, с хп!)
            {
                lovushka.Play(0);
                slotsmerman.slo6Hp = 0f; // самоуничтожение ловушки
                if (slot1GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot1Hp = 0f;
                }
                else if (slot1Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo1Hp = 0f;
                }
                else if (slot2GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot2Hp = 0f;
                }
                else if (slot2Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo2Hp = 0f;
                }
                else if (slot3GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot3Hp = 0f;
                }
                else if (slot3Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo3Hp = 0f;
                }
                else if (slot4GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot4Hp = 0f;
                }
                else if (slot4Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo4Hp = 0f;
                }
                else if (slot5GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot5Hp = 0f;
                }
                else if (slot5Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo5Hp = 0f;
                }
                else if (slot6GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot6Hp = 0f;
                }
                else if (slot6Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo6Hp = 0f;
                }
                else if (slot7GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot7Hp = 0f;
                }
                else if (slot7Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo7Hp = 0f;
                }
                else if (slot8GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot8Hp = 0f;
                }
                else if (slot8Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo8Hp = 0f;
                }
                else if (slot9GGsvet.activeSelf == true) // уничтожение задевшего
                {
                    slotsgg.slot9Hp = 0f;
                }
                else if (slot9Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo9Hp = 0f;
                }

            }
            else if (skreader.slot6skillVraga == 41 && slotsmerman.slo6Hp > 0f) // если там стоит ловушка (несработавшая, с хп!)
            {
                lovushka.Play(0);
                slotsmerman.slo6Hp = 0f; // самоуничтожение ловушки
                if (slot1GGsvet.activeSelf == true)
                {
                    slotsgg.slot1Hp = 0f;
                    slotsgg.slot4Hp = 0f;
                    slotsgg.slot7Hp = 0f;
                }
                else if (slot1Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo1Hp = 0f;
                    slotsmerman.slo4Hp = 0f;
                    slotsmerman.slo7Hp = 0f;
                }
                else if (slot2GGsvet.activeSelf == true)
                {
                    slotsgg.slot2Hp = 0f;
                    slotsgg.slot5Hp = 0f;
                    slotsgg.slot8Hp = 0f;
                }
                else if (slot2Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo2Hp = 0f;
                    slotsmerman.slo5Hp = 0f;
                    slotsmerman.slo8Hp = 0f;
                }
                else if (slot3GGsvet.activeSelf == true)
                {
                    slotsgg.slot3Hp = 0f;
                    slotsgg.slot6Hp = 0f;
                    slotsgg.slot9Hp = 0f;
                }
                else if (slot3Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo3Hp = 0f;
                    slotsmerman.slo6Hp = 0f;
                    slotsmerman.slo9Hp = 0f;
                }
                else if (slot4GGsvet.activeSelf == true)
                {
                    slotsgg.slot1Hp = 0f;
                    slotsgg.slot4Hp = 0f;
                    slotsgg.slot7Hp = 0f;
                }
                else if (slot4Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo1Hp = 0f;
                    slotsmerman.slo4Hp = 0f;
                    slotsmerman.slo7Hp = 0f;
                }
                else if (slot5GGsvet.activeSelf == true)
                {
                    slotsgg.slot2Hp = 0f;
                    slotsgg.slot5Hp = 0f;
                    slotsgg.slot8Hp = 0f;
                }
                else if (slot5Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo2Hp = 0f;
                    slotsmerman.slo5Hp = 0f;
                    slotsmerman.slo8Hp = 0f;
                }
                else if (slot6GGsvet.activeSelf == true)
                {
                    slotsgg.slot3Hp = 0f;
                    slotsgg.slot6Hp = 0f;
                    slotsgg.slot9Hp = 0f;
                }
                else if (slot6Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo3Hp = 0f;
                    slotsmerman.slo6Hp = 0f;
                    slotsmerman.slo9Hp = 0f;
                }
                else if (slot7GGsvet.activeSelf == true)
                {
                    slotsgg.slot1Hp = 0f;
                    slotsgg.slot4Hp = 0f;
                    slotsgg.slot7Hp = 0f;
                }
                else if (slot7Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo1Hp = 0f;
                    slotsmerman.slo4Hp = 0f;
                    slotsmerman.slo7Hp = 0f;
                }
                else if (slot8GGsvet.activeSelf == true)
                {
                    slotsgg.slot2Hp = 0f;
                    slotsgg.slot5Hp = 0f;
                    slotsgg.slot8Hp = 0f;
                }
                else if (slot8Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo2Hp = 0f;
                    slotsmerman.slo5Hp = 0f;
                    slotsmerman.slo8Hp = 0f;
                }
                else if (slot9GGsvet.activeSelf == true)
                {
                    slotsgg.slot3Hp = 0f;
                    slotsgg.slot6Hp = 0f;
                    slotsgg.slot9Hp = 0f;
                }
                else if (slot9Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo3Hp = 0f;
                    slotsmerman.slo6Hp = 0f;
                    slotsmerman.slo9Hp = 0f;
                }

            }
        }
        if (chitalkaTarget1 == skreader.slotVraga7 || chitalkaTarget2 == skreader.slotVraga7 || chitalkaTarget3 == skreader.slotVraga7) // если мишень - 1 слот гг
        {
            if (skreader.slot7skillVraga == 41 && slotsmerman.slo7Hp > 0f) // если там стоит ловушка (несработавшая, с хп!)
            {
                lovushka.Play(0);
                slotsmerman.slo7Hp = 0f; // самоуничтожение ловушки
                if (slot1GGsvet.activeSelf == true)
                {
                    slotsgg.slot1Hp = 0f;
                    slotsgg.slot4Hp = 0f;
                    slotsgg.slot7Hp = 0f;
                }
                else if (slot1Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo1Hp = 0f;
                    slotsmerman.slo4Hp = 0f;
                    slotsmerman.slo7Hp = 0f;
                }
                else if (slot2GGsvet.activeSelf == true)
                {
                    slotsgg.slot2Hp = 0f;
                    slotsgg.slot5Hp = 0f;
                    slotsgg.slot8Hp = 0f;
                }
                else if (slot2Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo2Hp = 0f;
                    slotsmerman.slo5Hp = 0f;
                    slotsmerman.slo8Hp = 0f;
                }
                else if (slot3GGsvet.activeSelf == true)
                {
                    slotsgg.slot3Hp = 0f;
                    slotsgg.slot6Hp = 0f;
                    slotsgg.slot9Hp = 0f;
                }
                else if (slot3Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo3Hp = 0f;
                    slotsmerman.slo6Hp = 0f;
                    slotsmerman.slo9Hp = 0f;
                }
                else if (slot4GGsvet.activeSelf == true)
                {
                    slotsgg.slot1Hp = 0f;
                    slotsgg.slot4Hp = 0f;
                    slotsgg.slot7Hp = 0f;
                }
                else if (slot4Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo1Hp = 0f;
                    slotsmerman.slo4Hp = 0f;
                    slotsmerman.slo7Hp = 0f;
                }
                else if (slot5GGsvet.activeSelf == true)
                {
                    slotsgg.slot2Hp = 0f;
                    slotsgg.slot5Hp = 0f;
                    slotsgg.slot8Hp = 0f;
                }
                else if (slot5Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo2Hp = 0f;
                    slotsmerman.slo5Hp = 0f;
                    slotsmerman.slo8Hp = 0f;
                }
                else if (slot6GGsvet.activeSelf == true)
                {
                    slotsgg.slot3Hp = 0f;
                    slotsgg.slot6Hp = 0f;
                    slotsgg.slot9Hp = 0f;
                }
                else if (slot6Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo3Hp = 0f;
                    slotsmerman.slo6Hp = 0f;
                    slotsmerman.slo9Hp = 0f;
                }
                else if (slot7GGsvet.activeSelf == true)
                {
                    slotsgg.slot1Hp = 0f;
                    slotsgg.slot4Hp = 0f;
                    slotsgg.slot7Hp = 0f;
                }
                else if (slot7Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo1Hp = 0f;
                    slotsmerman.slo4Hp = 0f;
                    slotsmerman.slo7Hp = 0f;
                }
                else if (slot8GGsvet.activeSelf == true)
                {
                    slotsgg.slot2Hp = 0f;
                    slotsgg.slot5Hp = 0f;
                    slotsgg.slot8Hp = 0f;
                }
                else if (slot8Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo2Hp = 0f;
                    slotsmerman.slo5Hp = 0f;
                    slotsmerman.slo8Hp = 0f;
                }
                else if (slot9GGsvet.activeSelf == true)
                {
                    slotsgg.slot3Hp = 0f;
                    slotsgg.slot6Hp = 0f;
                    slotsgg.slot9Hp = 0f;
                }
                else if (slot9Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo3Hp = 0f;
                    slotsmerman.slo6Hp = 0f;
                    slotsmerman.slo9Hp = 0f;
                }

            }
        }
        if (chitalkaTarget1 == skreader.slotVraga8 || chitalkaTarget2 == skreader.slotVraga8 || chitalkaTarget3 == skreader.slotVraga8) // если мишень - 1 слот гг
        {
            if (skreader.slot8skillVraga == 41 && slotsmerman.slo8Hp > 0f) // если там стоит ловушка (несработавшая, с хп!)
            {
                lovushka.Play(0);
                slotsmerman.slo8Hp = 0f; // самоуничтожение ловушки
                if (slot1GGsvet.activeSelf == true)
                {
                    slotsgg.slot1Hp = 0f;
                    slotsgg.slot4Hp = 0f;
                    slotsgg.slot7Hp = 0f;
                }
                else if (slot1Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo1Hp = 0f;
                    slotsmerman.slo4Hp = 0f;
                    slotsmerman.slo7Hp = 0f;
                }
                else if (slot2GGsvet.activeSelf == true)
                {
                    slotsgg.slot2Hp = 0f;
                    slotsgg.slot5Hp = 0f;
                    slotsgg.slot8Hp = 0f;
                }
                else if (slot2Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo2Hp = 0f;
                    slotsmerman.slo5Hp = 0f;
                    slotsmerman.slo8Hp = 0f;
                }
                else if (slot3GGsvet.activeSelf == true)
                {
                    slotsgg.slot3Hp = 0f;
                    slotsgg.slot6Hp = 0f;
                    slotsgg.slot9Hp = 0f;
                }
                else if (slot3Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo3Hp = 0f;
                    slotsmerman.slo6Hp = 0f;
                    slotsmerman.slo9Hp = 0f;
                }
                else if (slot4GGsvet.activeSelf == true)
                {
                    slotsgg.slot1Hp = 0f;
                    slotsgg.slot4Hp = 0f;
                    slotsgg.slot7Hp = 0f;
                }
                else if (slot4Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo1Hp = 0f;
                    slotsmerman.slo4Hp = 0f;
                    slotsmerman.slo7Hp = 0f;
                }
                else if (slot5GGsvet.activeSelf == true)
                {
                    slotsgg.slot2Hp = 0f;
                    slotsgg.slot5Hp = 0f;
                    slotsgg.slot8Hp = 0f;
                }
                else if (slot5Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo2Hp = 0f;
                    slotsmerman.slo5Hp = 0f;
                    slotsmerman.slo8Hp = 0f;
                }
                else if (slot6GGsvet.activeSelf == true)
                {
                    slotsgg.slot3Hp = 0f;
                    slotsgg.slot6Hp = 0f;
                    slotsgg.slot9Hp = 0f;
                }
                else if (slot6Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo3Hp = 0f;
                    slotsmerman.slo6Hp = 0f;
                    slotsmerman.slo9Hp = 0f;
                }
                else if (slot7GGsvet.activeSelf == true)
                {
                    slotsgg.slot1Hp = 0f;
                    slotsgg.slot4Hp = 0f;
                    slotsgg.slot7Hp = 0f;
                }
                else if (slot7Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo1Hp = 0f;
                    slotsmerman.slo4Hp = 0f;
                    slotsmerman.slo7Hp = 0f;
                }
                else if (slot8GGsvet.activeSelf == true)
                {
                    slotsgg.slot2Hp = 0f;
                    slotsgg.slot5Hp = 0f;
                    slotsgg.slot8Hp = 0f;
                }
                else if (slot8Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo2Hp = 0f;
                    slotsmerman.slo5Hp = 0f;
                    slotsmerman.slo8Hp = 0f;
                }
                else if (slot9GGsvet.activeSelf == true)
                {
                    slotsgg.slot3Hp = 0f;
                    slotsgg.slot6Hp = 0f;
                    slotsgg.slot9Hp = 0f;
                }
                else if (slot9Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo3Hp = 0f;
                    slotsmerman.slo6Hp = 0f;
                    slotsmerman.slo9Hp = 0f;
                }

            }
        }
        if (chitalkaTarget1 == skreader.slotVraga9 || chitalkaTarget2 == skreader.slotVraga9 || chitalkaTarget3 == skreader.slotVraga9) // если мишень - 1 слот гг
        {
            if (skreader.slot9skillVraga == 41 && slotsmerman.slo9Hp > 0f) // если там стоит ловушка (несработавшая, с хп!)
            {
                lovushka.Play(0);
                slotsmerman.slo9Hp = 0f; // самоуничтожение ловушки
                if (slot1GGsvet.activeSelf == true)
                {
                    slotsgg.slot1Hp = 0f;
                    slotsgg.slot4Hp = 0f;
                    slotsgg.slot7Hp = 0f;
                }
                else if (slot1Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo1Hp = 0f;
                    slotsmerman.slo4Hp = 0f;
                    slotsmerman.slo7Hp = 0f;
                }
                else if (slot2GGsvet.activeSelf == true)
                {
                    slotsgg.slot2Hp = 0f;
                    slotsgg.slot5Hp = 0f;
                    slotsgg.slot8Hp = 0f;
                }
                else if (slot2Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo2Hp = 0f;
                    slotsmerman.slo5Hp = 0f;
                    slotsmerman.slo8Hp = 0f;
                }
                else if (slot3GGsvet.activeSelf == true)
                {
                    slotsgg.slot3Hp = 0f;
                    slotsgg.slot6Hp = 0f;
                    slotsgg.slot9Hp = 0f;
                }
                else if (slot3Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo3Hp = 0f;
                    slotsmerman.slo6Hp = 0f;
                    slotsmerman.slo9Hp = 0f;
                }
                else if (slot4GGsvet.activeSelf == true)
                {
                    slotsgg.slot1Hp = 0f;
                    slotsgg.slot4Hp = 0f;
                    slotsgg.slot7Hp = 0f;
                }
                else if (slot4Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo1Hp = 0f;
                    slotsmerman.slo4Hp = 0f;
                    slotsmerman.slo7Hp = 0f;
                }
                else if (slot5GGsvet.activeSelf == true)
                {
                    slotsgg.slot2Hp = 0f;
                    slotsgg.slot5Hp = 0f;
                    slotsgg.slot8Hp = 0f;
                }
                else if (slot5Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo2Hp = 0f;
                    slotsmerman.slo5Hp = 0f;
                    slotsmerman.slo8Hp = 0f;
                }
                else if (slot6GGsvet.activeSelf == true)
                {
                    slotsgg.slot3Hp = 0f;
                    slotsgg.slot6Hp = 0f;
                    slotsgg.slot9Hp = 0f;
                }
                else if (slot6Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo3Hp = 0f;
                    slotsmerman.slo6Hp = 0f;
                    slotsmerman.slo9Hp = 0f;
                }
                else if (slot7GGsvet.activeSelf == true)
                {
                    slotsgg.slot1Hp = 0f;
                    slotsgg.slot4Hp = 0f;
                    slotsgg.slot7Hp = 0f;
                }
                else if (slot7Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo1Hp = 0f;
                    slotsmerman.slo4Hp = 0f;
                    slotsmerman.slo7Hp = 0f;
                }
                else if (slot8GGsvet.activeSelf == true)
                {
                    slotsgg.slot2Hp = 0f;
                    slotsgg.slot5Hp = 0f;
                    slotsgg.slot8Hp = 0f;
                }
                else if (slot8Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo2Hp = 0f;
                    slotsmerman.slo5Hp = 0f;
                    slotsmerman.slo8Hp = 0f;
                }
                else if (slot9GGsvet.activeSelf == true)
                {
                    slotsgg.slot3Hp = 0f;
                    slotsgg.slot6Hp = 0f;
                    slotsgg.slot9Hp = 0f;
                }
                else if (slot9Vragsvet.activeSelf == true)
                {
                    slotsmerman.slo3Hp = 0f;
                    slotsmerman.slo6Hp = 0f;
                    slotsmerman.slo9Hp = 0f;
                }

            }
        }




    }


}
