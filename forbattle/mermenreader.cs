using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class mermenreader : MonoBehaviour
{
    public Levels leveler;
    public SliderController slidor;
    public PlayerController playir;
    public battlefinal final;
    public DistanceToCheckpoint distancePoints;
    public EnemySpawnerB1 enemySpawner;
    public BattleScreen battleModeVisibility;
    public Slo1 slotsEnemy;
    public skillsreader skreader;
    public SkillsController skills;
    public battleplayer batol;

    public GameObject trueblok1;
    public GameObject trueblok2;
    public GameObject trueblok3;
    public GameObject trueblok4;
    public GameObject trueblok5;
    public GameObject trueblok6;
    public GameObject trueblok7;
    public GameObject trueblok8;
    public GameObject trueblok9;

    public GameObject blokderzhalka;
    public GameObject blokderzhalka1;
    public GameObject blokderzhalka2;

    // флоат для каждого мермена для плеер префсов (0-1)
    public GameObject skilloiddot1;
    public GameObject skilloiddot2;
    public GameObject skilloiddot3;

    // булы одноразового чтения
    [SerializeField] private bool readalready1;
    [SerializeField] private bool readalready2;
    [SerializeField] private bool readalready3;
    [SerializeField] private bool readalready4;
    [SerializeField] private bool readalready5;
    [SerializeField] private bool readalready6;
    [SerializeField] private bool readalready7;
    [SerializeField] private bool readalready8;
    [SerializeField] private bool readalready9;

    // сами скиллы врага для чтения
    public GameObject skil1Vraga;
    public GameObject skil2Vraga;
    public GameObject skil3Vraga;
    public GameObject skil4Vraga;
    public GameObject skil5Vraga;
    public GameObject skil6Vraga;
    public GameObject skil7Vraga;
    public GameObject skil8Vraga;
    public GameObject skil9Vraga;
    public GameObject skil10Vraga;
    public GameObject skil11Vraga;
    public GameObject skil12Vraga;
    public GameObject skil13Vraga;
    public GameObject skil14Vraga;
    public GameObject skil15Vraga;
    public GameObject skil16Vraga;
    public GameObject skil17Vraga;
    public GameObject skil18Vraga;
    public GameObject skil19Vraga;
    public GameObject skil20Vraga;
    public GameObject skil21Vraga;
    public GameObject skil22Vraga;
    public GameObject skil23Vraga;
    public GameObject skil24Vraga;
    public GameObject skil25Vraga;
    public GameObject skil26Vraga;
    public GameObject skil27Vraga;
    public GameObject skil28Vraga;
    public GameObject skil29Vraga;
    public GameObject skil30Vraga;
    public GameObject skil31Vraga;
    public GameObject skil32Vraga;
    public GameObject skil33Vraga;
    public GameObject skil34Vraga;
    public GameObject skil35Vraga;
    public GameObject skil36Vraga;
    public GameObject skil37Vraga;
    public GameObject skil38Vraga;
    public GameObject skil39Vraga;
    public GameObject skil40Vraga;
    public GameObject skil41Vraga;
    public GameObject skil42Vraga;
    public GameObject skil43Vraga;

    public GameObject skil29VragaShadow;
    public GameObject skil33VragaShadow;

    public GameObject[] skills1place; // - скиллы, которые могут спавниться на первом слоте
    public GameObject[] skills2place;
    public GameObject[] skills3place;
    public GameObject[] skills4place;
    public GameObject[] skills5place;
    public GameObject[] skills6place;
    public GameObject[] skills7place;
    public GameObject[] skills8place;
    public GameObject[] skills9place;
    [SerializeField] private int prefabIndexin1place; // - даёт значение для выбора префаба из списка (изначально список мал, потом появляются повторы)
    [SerializeField] private int prefabIndexin2place;
    [SerializeField] private int prefabIndexin3place;
    [SerializeField] private int prefabIndexin4place;
    [SerializeField] private int prefabIndexin5place;
    [SerializeField] private int prefabIndexin6place;
    [SerializeField] private int prefabIndexin7place;
    [SerializeField] private int prefabIndexin8place;
    [SerializeField] private int prefabIndexin9place;
    public int urovenVl; // с каждым уровнем растет на 1, увеличивая вероятность спавна навыка (максимум 10?)
    public int depthVl; // с каждым уровнем растет на 1, увеличивая вероятность спавна навыка (максимум 10?)
    public bool justonceRead;
    // блок над навыком врага
    public GameObject speshlblok1;
    public GameObject speshlblok2;
    public GameObject speshlblok3;
    public GameObject speshlblok4;
    public GameObject speshlblok5;
    public GameObject speshlblok6;
    public GameObject speshlblok7;
    public GameObject speshlblok8;
    public GameObject speshlblok9;

    // для блоков и антиблоков
    public bool slot1zablokVraga;
    public bool slot2zablokVraga;
    public bool slot3zablokVraga;
    public bool slot4zablokVraga;
    public bool slot5zablokVraga;
    public bool slot6zablokVraga;
    public bool slot7zablokVraga;
    public bool slot8zablokVraga;
    public bool slot9zablokVraga;
    public bool slot1zablokirovan;
    public bool slot2zablokirovan;
    public bool slot3zablokirovan;
    public bool slot4zablokirovan;
    public bool slot5zablokirovan;
    public bool slot6zablokirovan;
    public bool slot7zablokirovan;
    public bool slot8zablokirovan;
    public bool slot9zablokirovan;

    void Start()
    {
        blokderzhalka.SetActive(false);
        blokderzhalka1.SetActive(false);
        blokderzhalka2.SetActive(false);
        slot1zablokVraga = false;
        slot2zablokVraga = false;
        slot3zablokVraga = false;
        slot4zablokVraga = false;
        slot5zablokVraga = false;
        slot6zablokVraga = false;
        slot7zablokVraga = false;
        slot8zablokVraga = false;
        slot9zablokVraga = false;
        slot1zablokirovan = false;
        slot2zablokirovan = false;
        slot3zablokirovan = false;
        slot4zablokirovan = false;
        slot5zablokirovan = false;
        slot6zablokirovan = false;
        slot7zablokirovan = false;
        slot8zablokirovan = false;
        slot9zablokirovan = false;
        readalready1 = false;
        readalready2 = false;
        readalready3 = false;
        readalready4 = false;
        readalready5 = false;
        readalready6 = false;
        readalready7 = false;
        readalready8 = false;
        readalready9 = false;
        urovenVl = 0; // сюда повлиять из левелера
        depthVl = 0;
        skillNuller();
        speshlblok1.SetActive(false);
        speshlblok2.SetActive(false);
        speshlblok3.SetActive(false);
        speshlblok4.SetActive(false);
        speshlblok5.SetActive(false);
        speshlblok6.SetActive(false);
        speshlblok7.SetActive(false);
        speshlblok8.SetActive(false);
        speshlblok9.SetActive(false);
    }

    void Update()
    {
        // тут еще был && Input.touchCount > 0
        if (readalready9 == true && justonceRead == false)
        {   // включаются дополнительные блоки
            justonceRead = true;
            if (distancePoints.distance <= 12070) // на последнем биоме блоков нет
            {
                if (slotsEnemy.slo1.transform.childCount > 0 && slotsEnemy.slo1blocked.activeSelf == true)
                {
                    speshlblok1.SetActive(true);
                }
                if (slotsEnemy.slo2.transform.childCount > 0 && slotsEnemy.slo2blocked.activeSelf == true)
                {
                    speshlblok2.SetActive(true);
                }
                if (slotsEnemy.slo3.transform.childCount > 0 && slotsEnemy.slo3blocked.activeSelf == true)
                {
                    speshlblok3.SetActive(true);
                }
                if (slotsEnemy.slo4.transform.childCount > 0 && slotsEnemy.slo4blocked.activeSelf == true)
                {
                    speshlblok4.SetActive(true);
                }
                if (slotsEnemy.slo5.transform.childCount > 0 && slotsEnemy.slo5blocked.activeSelf == true)
                {
                    speshlblok5.SetActive(true);
                }
                if (slotsEnemy.slo6.transform.childCount > 0 && slotsEnemy.slo6blocked.activeSelf == true)
                {
                    speshlblok6.SetActive(true);
                }
                if (slotsEnemy.slo7.transform.childCount > 0 && slotsEnemy.slo7blocked.activeSelf == true)
                {
                    speshlblok7.SetActive(true);
                }
                if (slotsEnemy.slo8.transform.childCount > 0 && slotsEnemy.slo8blocked.activeSelf == true)
                {
                    speshlblok8.SetActive(true);
                }
                if (slotsEnemy.slo9.transform.childCount > 0 && slotsEnemy.slo9blocked.activeSelf == true)
                {
                    speshlblok9.SetActive(true);
                }
            }
        }

        // тапф с описаниями
        if (readalready9 == true && skills.skillsBack.activeSelf == true && enemySpawner.bNemin == false) // если мы только что всё прочитали
        {
            // тут ещё читаются и включаются все описания, находятся подсветки (если не блок!!)
            if (enemySpawner.bNemin == false && distancePoints.distance <= 12070) // у немина это блокируется, а на последнем биоме этого нет
            {
                if (slotsEnemy.slo1.transform.childCount > 0 && slotsEnemy.slo1blocked.activeSelf == false && skreader.slot1skillVraga != 0)
                {
                    slotsEnemy.slo1.transform.GetChild(0).transform.GetChild(1).gameObject.SetActive(true);
                }
                if (slotsEnemy.slo2.transform.childCount > 0 && slotsEnemy.slo2blocked.activeSelf == false && skreader.slot2skillVraga != 0)
                {
                    slotsEnemy.slo2.transform.GetChild(0).transform.GetChild(1).gameObject.SetActive(true);
                }
                if (slotsEnemy.slo3.transform.childCount > 0 && slotsEnemy.slo3blocked.activeSelf == false && skreader.slot3skillVraga != 0)
                {
                    slotsEnemy.slo3.transform.GetChild(0).transform.GetChild(1).gameObject.SetActive(true);
                }
                if (slotsEnemy.slo4.transform.childCount > 0 && slotsEnemy.slo4blocked.activeSelf == false && skreader.slot4skillVraga != 0)
                {
                    slotsEnemy.slo4.transform.GetChild(0).transform.GetChild(1).gameObject.SetActive(true);
                }
                if (slotsEnemy.slo5.transform.childCount > 0 && slotsEnemy.slo5blocked.activeSelf == false && skreader.slot5skillVraga != 0)
                {
                    slotsEnemy.slo5.transform.GetChild(0).transform.GetChild(1).gameObject.SetActive(true);
                }
                if (slotsEnemy.slo6.transform.childCount > 0 && slotsEnemy.slo6blocked.activeSelf == false && skreader.slot6skillVraga != 0)
                {
                    slotsEnemy.slo6.transform.GetChild(0).transform.GetChild(1).gameObject.SetActive(true);
                }
                if (slotsEnemy.slo7.transform.childCount > 0 && slotsEnemy.slo7blocked.activeSelf == false && skreader.slot7skillVraga != 0)
                {
                    slotsEnemy.slo7.transform.GetChild(0).transform.GetChild(1).gameObject.SetActive(true);
                }
                if (slotsEnemy.slo8.transform.childCount > 0 && slotsEnemy.slo8blocked.activeSelf == false && skreader.slot8skillVraga != 0)
                {
                    slotsEnemy.slo8.transform.GetChild(0).transform.GetChild(1).gameObject.SetActive(true);
                }
                if (slotsEnemy.slo9.transform.childCount > 0 && slotsEnemy.slo9blocked.activeSelf == false && skreader.slot9skillVraga != 0)
                {
                    slotsEnemy.slo9.transform.GetChild(0).transform.GetChild(1).gameObject.SetActive(true);
                }
            }

        }
        if (readalready9 == true && skills.skillsBack.activeSelf == true && Input.touchCount > 0)
        { 
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            if (touch.phase == TouchPhase.Began && skreader.mishenHolder.activeSelf == false)
            {
                skreader.stopMishenCaller();
                skreader.MishenOff();
                // если тапнули блокер, то откл мишени
                if (trueblok1.GetComponent<Collider2D>().bounds.Contains(touch.position) || trueblok2.GetComponent<Collider2D>().bounds.Contains(touch.position) || trueblok3.GetComponent<Collider2D>().bounds.Contains(touch.position) || trueblok4.GetComponent<Collider2D>().bounds.Contains(touch.position) || trueblok5.GetComponent<Collider2D>().bounds.Contains(touch.position) || trueblok6.GetComponent<Collider2D>().bounds.Contains(touch.position) || trueblok7.GetComponent<Collider2D>().bounds.Contains(touch.position) || trueblok8.GetComponent<Collider2D>().bounds.Contains(touch.position) || trueblok9.GetComponent<Collider2D>().bounds.Contains(touch.position))
                {
                    skreader.mishenHolderFals.SetActive(false);
                    skreader.mishenHolderVragaFals.SetActive(false);
                }
                if (enemySpawner.bNemin == false && distancePoints.distance <= 12070) // у немина это блокируется, а на последнем биоме этого нет
                {
                    // если скилл 1 тапнули
                    if (skil1Vraga != null && skil1Vraga.GetComponent<Collider2D>().bounds.Contains(touch.position)) // и если не блок!!
                    {

                        // вкл подсветку
                        if (skreader.mishenHolderFals.activeSelf == true)
                        {
                            skil1Vraga.transform.GetChild(0).gameObject.SetActive(true);
                        }
                        // вкл мишени, при отпускании всё пропадает


                        if (skreader.slot1skillVraga == 1) // если этот навык на позиции 1 и блок не стоит
                        {
                            skreader.slot1falsMish.SetActive(true);
                        }
                        else if (skreader.slot2skillVraga == 1)
                        {
                            skreader.slot2falsMish.SetActive(true);
                        }
                        else if (skreader.slot3skillVraga == 1)
                        {
                            skreader.slot3falsMish.SetActive(true);
                        }
                        else if (skreader.slot5skillVraga == 1)
                        {
                            skreader.slot2falsMish.SetActive(true);
                        }
                    }
                    // если скилл 2 тапнули
                    else if (skil2Vraga != null && skil2Vraga.GetComponent<Collider2D>().bounds.Contains(touch.position)) // и если не блок!!
                    {
                        // вкл подсветку
                        if (skreader.mishenHolderFals.activeSelf == true)
                        {
                            skil2Vraga.transform.GetChild(0).gameObject.SetActive(true);
                        }
                        // вкл мишени, при отпускании всё пропадает
                        if (skreader.slot1skillVraga == 2)
                        {
                            skreader.slot4falsMish.SetActive(true);
                        }
                        else if (skreader.slot2skillVraga == 2)
                        {
                            skreader.slot5falsMish.SetActive(true);
                        }
                        else if (skreader.slot3skillVraga == 2)
                        {
                            skreader.slot6falsMish.SetActive(true);
                        }
                        else if (skreader.slot5skillVraga == 2)
                        {
                            skreader.slot5falsMish.SetActive(true);
                        }
                    }
                    // если скилл 3
                    else if (skil3Vraga != null && skil3Vraga.GetComponent<Collider2D>().bounds.Contains(touch.position)) // и если не блок!!
                    {
                        // вкл подсветку
                        if (skreader.mishenHolderFals.activeSelf == true)
                        {
                            skil3Vraga.transform.GetChild(0).gameObject.SetActive(true);
                        }
                        // вкл мишени, при отпускании всё пропадает
                        if (skreader.slot1skillVraga == 3)
                        {
                            skreader.slot7falsMish.SetActive(true);
                        }
                        else if (skreader.slot2skillVraga == 3)
                        {
                            skreader.slot8falsMish.SetActive(true);
                        }
                        else if (skreader.slot3skillVraga == 3)
                        {
                            skreader.slot9falsMish.SetActive(true);
                        }
                        else if (skreader.slot5skillVraga == 3)
                        {
                            skreader.slot8falsMish.SetActive(true);
                        }
                    }
                    // если скилл 4
                    else if (skil4Vraga != null && skil4Vraga.GetComponent<Collider2D>().bounds.Contains(touch.position)) // и если не блок!!
                    {
                        // вкл подсветку
                        if (skreader.mishenHolderFals.activeSelf == true)
                        {
                            skil4Vraga.transform.GetChild(0).gameObject.SetActive(true);
                        }
                        // вкл мишени, при отпускании всё пропадает
                        if (skreader.slot1skillVraga == 4)
                        {
                            skreader.slot1falsMish.SetActive(true);
                        }
                        else if (skreader.slot2skillVraga == 4)
                        {
                            skreader.slot2falsMish.SetActive(true);
                        }
                        else if (skreader.slot3skillVraga == 4)
                        {
                            skreader.slot3falsMish.SetActive(true);
                        }
                    }
                    // если скилл 5
                    else if (skil5Vraga != null && skil5Vraga.GetComponent<Collider2D>().bounds.Contains(touch.position)) // и если не блок!!
                    {
                        // вкл подсветку
                        if (skreader.mishenHolderFals.activeSelf == true)
                        {
                            skil5Vraga.transform.GetChild(0).gameObject.SetActive(true);
                        }
                        // вкл мишени, при отпускании всё пропадает
                        if (skreader.slot4skillVraga == 5)
                        {
                            skreader.slot1falsMishVraga.SetActive(true);
                            skreader.slot2falsMishVraga.SetActive(true);
                            skreader.slot3falsMishVraga.SetActive(true);
                        }
                        else if (skreader.slot5skillVraga == 5)
                        {
                            skreader.slot1falsMishVraga.SetActive(true);
                            skreader.slot2falsMishVraga.SetActive(true);
                            skreader.slot3falsMishVraga.SetActive(true);
                            skreader.slot4falsMishVraga.SetActive(true);
                        }
                        else if (skreader.slot6skillVraga == 5)
                        {
                            skreader.slot1falsMishVraga.SetActive(true);
                            skreader.slot2falsMishVraga.SetActive(true);
                            skreader.slot3falsMishVraga.SetActive(true);
                            skreader.slot4falsMishVraga.SetActive(true);
                            skreader.slot5falsMishVraga.SetActive(true);
                        }
                    }
                    // если скилл 6
                    else if (skil6Vraga != null && skil6Vraga.GetComponent<Collider2D>().bounds.Contains(touch.position)) // и если не блок!!
                    {
                        // вкл подсветку
                        if (skreader.mishenHolderFals.activeSelf == true)
                        {
                            skil6Vraga.transform.GetChild(0).gameObject.SetActive(true);
                        }
                        // вкл мишени, при отпускании всё пропадает
                        if (skreader.slot4skillVraga == 6)
                        {
                            skreader.slot1falsMishVraga.SetActive(true);
                        }
                        else if (skreader.slot6skillVraga == 6)
                        {
                            skreader.slot3falsMishVraga.SetActive(true);
                        }
                        else if (skreader.slot7skillVraga == 6)
                        {
                            skreader.slot4falsMishVraga.SetActive(true);
                        }
                        else if (skreader.slot8skillVraga == 6)
                        {
                            skreader.slot5falsMishVraga.SetActive(true);
                        }
                        else if (skreader.slot9skillVraga == 6)
                        {
                            skreader.slot6falsMishVraga.SetActive(true);
                        }
                    }
                    // если скилл 7
                    else if (skil7Vraga != null && skil7Vraga.GetComponent<Collider2D>().bounds.Contains(touch.position)) // и если не блок!!
                    {
                        // вкл подсветку
                        if (skreader.mishenHolderFals.activeSelf == true)
                        {
                            skil7Vraga.transform.GetChild(0).gameObject.SetActive(true);
                        }
                        // вкл мишени, при отпускании всё пропадает
                        if (skreader.slot4skillVraga == 7)
                        {
                            skreader.slot1falsMishVraga.SetActive(true);
                        }
                        else if (skreader.slot6skillVraga == 7)
                        {
                            skreader.slot3falsMishVraga.SetActive(true);
                        }
                        else if (skreader.slot7skillVraga == 7)
                        {
                            skreader.slot4falsMishVraga.SetActive(true);
                        }
                        else if (skreader.slot8skillVraga == 7)
                        {
                            skreader.slot5falsMishVraga.SetActive(true);
                        }
                        else if (skreader.slot9skillVraga == 7)
                        {
                            skreader.slot6falsMishVraga.SetActive(true);
                        }
                    }
                    // если скилл 8
                    else if (skil8Vraga != null && skil8Vraga.GetComponent<Collider2D>().bounds.Contains(touch.position)) // и если не блок!!
                    {
                        // вкл подсветку
                        if (skreader.mishenHolderFals.activeSelf == true)
                        {
                            skil8Vraga.transform.GetChild(0).gameObject.SetActive(true);
                        }
                        // вкл мишени, при отпускании всё пропадает
                        if (skreader.slot4skillVraga == 8)
                        {
                            skreader.slot1falsMishVraga.SetActive(true);
                        }
                        else if (skreader.slot6skillVraga == 8)
                        {
                            skreader.slot3falsMishVraga.SetActive(true);
                        }
                        else if (skreader.slot7skillVraga == 8)
                        {
                            skreader.slot4falsMishVraga.SetActive(true);
                        }
                        else if (skreader.slot8skillVraga == 8)
                        {
                            skreader.slot5falsMishVraga.SetActive(true);
                        }
                        else if (skreader.slot9skillVraga == 8)
                        {
                            skreader.slot6falsMishVraga.SetActive(true);
                        }
                    }
                    // если скилл 9
                    else if (skil9Vraga != null && skil9Vraga.GetComponent<Collider2D>().bounds.Contains(touch.position)) // и если не блок!!
                    {
                        // вкл подсветку
                        if (skreader.mishenHolderFals.activeSelf == true)
                        {
                            skil9Vraga.transform.GetChild(0).gameObject.SetActive(true);
                        }
                        // вкл мишени, при отпускании всё пропадает
                        if (skreader.slot7skillVraga == 9)
                        {
                            skreader.slot7falsMish.SetActive(true);
                        }
                        else if (skreader.slot8skillVraga == 9)
                        {
                            skreader.slot8falsMish.SetActive(true);
                        }
                        else if (skreader.slot9skillVraga == 9)
                        {
                            skreader.slot9falsMish.SetActive(true);
                        }
                    }
                    // скилл 10
                    else if (skil10Vraga != null && skil10Vraga.GetComponent<Collider2D>().bounds.Contains(touch.position))
                    {
                        if (skreader.mishenHolderFals.activeSelf == true)
                        {
                            skil10Vraga.transform.GetChild(0).gameObject.SetActive(true);
                        }
                        if (skreader.slot2skillVraga == 10)
                        {
                            skreader.slot5falsMishVraga.SetActive(true);
                            skreader.slot8falsMishVraga.SetActive(true);
                        }
                        else if (skreader.slot4skillVraga == 10)
                        {
                            skreader.slot7falsMishVraga.SetActive(true);
                        }
                        else if (skreader.slot6skillVraga == 10)
                        {
                            skreader.slot9falsMishVraga.SetActive(true);
                        }

                    }
                    // скилл 11
                    else if (skil11Vraga != null && skil11Vraga.GetComponent<Collider2D>().bounds.Contains(touch.position))
                    {
                        if (skreader.mishenHolderFals.activeSelf == true)
                        {
                            skil11Vraga.transform.GetChild(0).gameObject.SetActive(true);
                        }
                        if (skreader.slot1skillVraga == 11)
                        {
                            skreader.slot4falsMishVraga.SetActive(true);
                            skreader.slot7falsMishVraga.SetActive(true);
                        }
                        else if (skreader.slot3skillVraga == 11)
                        {
                            skreader.slot6falsMishVraga.SetActive(true);
                            skreader.slot9falsMishVraga.SetActive(true);
                        }
                        else if (skreader.slot5skillVraga == 11)
                        {
                            skreader.slot8falsMishVraga.SetActive(true);
                        }

                    }
                    else if (skil12Vraga != null && skil12Vraga.GetComponent<Collider2D>().bounds.Contains(touch.position)) // и если не блок!!
                    {
                        // вкл подсветку
                        if (skreader.mishenHolderFals.activeSelf == true)
                        {
                            skil12Vraga.transform.GetChild(0).gameObject.SetActive(true);
                        }
                        // вкл мишени, при отпускании всё пропадает
                        if (skreader.slot4skillVraga == 12)
                        {
                            skreader.slot5falsMishVraga.SetActive(true);
                            skreader.slot6falsMishVraga.SetActive(true);
                            skreader.slot7falsMishVraga.SetActive(true);
                            skreader.slot8falsMishVraga.SetActive(true);
                            skreader.slot9falsMishVraga.SetActive(true);
                        }
                        else if (skreader.slot5skillVraga == 12)
                        {
                            skreader.slot6falsMishVraga.SetActive(true);
                            skreader.slot7falsMishVraga.SetActive(true);
                            skreader.slot8falsMishVraga.SetActive(true);
                            skreader.slot9falsMishVraga.SetActive(true);
                        }
                        else if (skreader.slot6skillVraga == 12)
                        {
                            skreader.slot7falsMishVraga.SetActive(true);
                            skreader.slot8falsMishVraga.SetActive(true);
                            skreader.slot9falsMishVraga.SetActive(true);
                        }
                    }
                    else if (skil13Vraga != null && skil13Vraga.GetComponent<Collider2D>().bounds.Contains(touch.position)) // и если не блок!!
                    {
                        // вкл подсветку
                        if (skreader.mishenHolderFals.activeSelf == true)
                        {
                            skil13Vraga.transform.GetChild(0).gameObject.SetActive(true);
                        }
                        // вкл мишени, при отпускании всё пропадает
                        if (skreader.slot4skillVraga == 13)
                        {
                            skreader.slot1falsMish.SetActive(true);
                            skreader.slot4falsMish.SetActive(true);
                            skreader.slot7falsMish.SetActive(true);
                        }
                        else if (skreader.slot6skillVraga == 13)
                        {
                            skreader.slot3falsMish.SetActive(true);
                            skreader.slot6falsMish.SetActive(true);
                            skreader.slot9falsMish.SetActive(true);
                        }
                    }
                    else if (skil14Vraga != null && skil14Vraga.GetComponent<Collider2D>().bounds.Contains(touch.position)) // и если не блок!!
                    {
                        // вкл подсветку
                        if (skreader.mishenHolderFals.activeSelf == true)
                        {
                            skil14Vraga.transform.GetChild(0).gameObject.SetActive(true);
                        }
                        // вкл мишени, при отпускании всё пропадает
                        if (skreader.slot7skillVraga == 14)
                        {
                            skreader.slot1falsMish.SetActive(true);
                            skreader.slot4falsMish.SetActive(true);
                            skreader.slot7falsMish.SetActive(true);
                        }
                        else if (skreader.slot9skillVraga == 14)
                        {
                            skreader.slot3falsMish.SetActive(true);
                            skreader.slot6falsMish.SetActive(true);
                            skreader.slot9falsMish.SetActive(true);
                        }
                    }
                    else if (skil15Vraga != null && skil15Vraga.GetComponent<Collider2D>().bounds.Contains(touch.position)) // и если не блок!!
                    {
                        // вкл подсветку
                        if (skreader.mishenHolderFals.activeSelf == true)
                        {
                            skil15Vraga.transform.GetChild(0).gameObject.SetActive(true);
                        }
                        // вкл мишени, при отпускании всё пропадает
                        if (skreader.slot5skillVraga == 15)
                        {
                            skreader.slot5falsMish.SetActive(true);
                        }
                        else if (skreader.slot6skillVraga == 15)
                        {
                            skreader.slot6falsMish.SetActive(true);
                        }
                        else if (skreader.slot4skillVraga == 15)
                        {
                            skreader.slot4falsMish.SetActive(true);
                        }
                    }
                    else if (skil16Vraga != null && skil16Vraga.GetComponent<Collider2D>().bounds.Contains(touch.position)) // и если не блок!!
                    {
                        // вкл подсветку
                        if (skreader.mishenHolderFals.activeSelf == true)
                        {
                            skil16Vraga.transform.GetChild(0).gameObject.SetActive(true);
                        }
                        // вкл мишени, при отпускании всё пропадает
                        if (skreader.slot7skillVraga == 16)
                        {
                            skreader.slot7falsMish.SetActive(true);
                            skreader.slot8falsMish.SetActive(true);
                            skreader.slot4falsMish.SetActive(true);
                        }
                        else if (skreader.slot8skillVraga == 16)
                        {
                            skreader.slot8falsMish.SetActive(true);
                            skreader.slot5falsMish.SetActive(true);
                            skreader.slot7falsMish.SetActive(true);
                            skreader.slot9falsMish.SetActive(true);
                        }
                        else if (skreader.slot9skillVraga == 16)
                        {
                            skreader.slot9falsMish.SetActive(true);
                            skreader.slot6falsMish.SetActive(true);
                            skreader.slot8falsMish.SetActive(true);
                        }
                    }
                    else if (skil17Vraga != null && skil17Vraga.GetComponent<Collider2D>().bounds.Contains(touch.position)) // и если не блок!!
                    {
                        // вкл подсветку
                        if (skreader.mishenHolderFals.activeSelf == true)
                        {
                            skil17Vraga.transform.GetChild(0).gameObject.SetActive(true);
                        }
                        // вкл мишени, при отпускании всё пропадает
                        if (skreader.slot1skillVraga == 17)
                        {
                            skreader.slot1falsMish.SetActive(true);
                            skreader.slot2falsMish.SetActive(true);
                            skreader.slot4falsMish.SetActive(true);
                        }
                        else if (skreader.slot2skillVraga == 17)
                        {
                            skreader.slot2falsMish.SetActive(true);
                            skreader.slot1falsMish.SetActive(true);
                            skreader.slot3falsMish.SetActive(true);
                            skreader.slot5falsMish.SetActive(true);
                        }
                        else if (skreader.slot3skillVraga == 17)
                        {
                            skreader.slot3falsMish.SetActive(true);
                            skreader.slot6falsMish.SetActive(true);
                            skreader.slot2falsMish.SetActive(true);
                        }
                    }
                    else if (skil18Vraga != null && skil18Vraga.GetComponent<Collider2D>().bounds.Contains(touch.position)) // и если не блок!!
                    {
                        // вкл подсветку
                        if (skreader.mishenHolderFals.activeSelf == true)
                        {
                            skil18Vraga.transform.GetChild(0).gameObject.SetActive(true);
                        }
                        // вкл мишени, при отпускании всё пропадает
                        if (skreader.slot1skillVraga == 18)
                        {
                            skreader.slot1falsMishVraga.SetActive(true);
                            skreader.slot4falsMishVraga.SetActive(true);
                        }
                        else if (skreader.slot2skillVraga == 18)
                        {
                            skreader.slot2falsMishVraga.SetActive(true);
                            skreader.slot5falsMishVraga.SetActive(true);
                        }
                        else if (skreader.slot3skillVraga == 18)
                        {
                            skreader.slot3falsMishVraga.SetActive(true);
                            skreader.slot6falsMishVraga.SetActive(true);
                        }
                    }
                    else if (skil19Vraga != null && skil19Vraga.GetComponent<Collider2D>().bounds.Contains(touch.position)) // и если не блок!!
                    {
                        // вкл подсветку
                        if (skreader.mishenHolderFals.activeSelf == true)
                        {
                            skil19Vraga.transform.GetChild(0).gameObject.SetActive(true);
                        }
                        // вкл мишени, при отпускании всё пропадает
                        if (skreader.slot4skillVraga == 19)
                        {
                            skreader.slot1falsMish.SetActive(true);
                            skreader.slot7falsMish.SetActive(true);
                            skreader.slot4falsMish.SetActive(true);
                        }
                        else if (skreader.slot5skillVraga == 19)
                        {
                            skreader.slot2falsMish.SetActive(true);
                            skreader.slot8falsMish.SetActive(true);
                            skreader.slot5falsMish.SetActive(true);
                        }
                        else if (skreader.slot6skillVraga == 19)
                        {
                            skreader.slot3falsMish.SetActive(true);
                            skreader.slot6falsMish.SetActive(true);
                            skreader.slot9falsMish.SetActive(true);
                        }
                    }
                    else if (skil20Vraga != null && skil20Vraga.GetComponent<Collider2D>().bounds.Contains(touch.position)) // и если не блок!!
                    {
                        // вкл подсветку
                        if (skreader.mishenHolderFals.activeSelf == true)
                        {
                            skil20Vraga.transform.GetChild(0).gameObject.SetActive(true);
                        }
                    }
                    else if (skil21Vraga != null && skil21Vraga.GetComponent<Collider2D>().bounds.Contains(touch.position)) // и если не блок!!
                    {
                        // вкл подсветку
                        if (skreader.mishenHolderFals.activeSelf == true)
                        {
                            skil21Vraga.transform.GetChild(0).gameObject.SetActive(true);
                        }
                        if (skreader.slot1skillVraga == 21)
                        {
                            skreader.slot1falsMish.SetActive(true);
                            skreader.slot1falsMishVraga.SetActive(true);
                        }
                        else if (skreader.slot2skillVraga == 21)
                        {
                            skreader.slot2falsMish.SetActive(true);
                            skreader.slot2falsMishVraga.SetActive(true);
                        }
                        else if (skreader.slot3skillVraga == 21)
                        {
                            skreader.slot3falsMish.SetActive(true);
                            skreader.slot3falsMishVraga.SetActive(true);
                        }
                        else if (skreader.slot4skillVraga == 21)
                        {
                            skreader.slot4falsMish.SetActive(true);
                            skreader.slot4falsMishVraga.SetActive(true);
                        }
                        else if (skreader.slot6skillVraga == 21)
                        {
                            skreader.slot6falsMish.SetActive(true);
                            skreader.slot6falsMishVraga.SetActive(true);
                        }
                        else if (skreader.slot7skillVraga == 21)
                        {
                            skreader.slot7falsMish.SetActive(true);
                            skreader.slot7falsMishVraga.SetActive(true);
                        }
                        else if (skreader.slot9skillVraga == 21)
                        {
                            skreader.slot9falsMish.SetActive(true);
                            skreader.slot9falsMishVraga.SetActive(true);
                        }
                    }
                    else if (skil22Vraga != null && skil22Vraga.GetComponent<Collider2D>().bounds.Contains(touch.position)) // и если не блок!!
                    {
                        // вкл подсветку
                        if (skreader.mishenHolderFals.activeSelf == true)
                        {
                            skil22Vraga.transform.GetChild(0).gameObject.SetActive(true);
                        }
                        if (skreader.slot2skillVraga == 22)
                        {
                            skreader.slot2falsMish.SetActive(true);
                        }
                        else if (skreader.slot5skillVraga == 22)
                        {
                            skreader.slot5falsMish.SetActive(true);
                        }
                        else if (skreader.slot7skillVraga == 22)
                        {
                            skreader.slot7falsMish.SetActive(true);
                        }
                        else if (skreader.slot8skillVraga == 22)
                        {
                            skreader.slot8falsMish.SetActive(true);
                        }
                        else if (skreader.slot9skillVraga == 22)
                        {
                            skreader.slot9falsMish.SetActive(true);
                        }
                    }
                    else if (skil23Vraga != null && skil23Vraga.GetComponent<Collider2D>().bounds.Contains(touch.position)) // и если не блок!!
                    {
                        // вкл подсветку
                        if (skreader.mishenHolderFals.activeSelf == true)
                        {
                            skil23Vraga.transform.GetChild(0).gameObject.SetActive(true);
                        }
                        skreader.slot7falsMish.SetActive(true);
                        skreader.slot8falsMish.SetActive(true);
                        skreader.slot9falsMish.SetActive(true);
                    }
                    else if (skil24Vraga != null && skil24Vraga.GetComponent<Collider2D>().bounds.Contains(touch.position)) // и если не блок!!
                    {
                        // вкл подсветку
                        if (skreader.mishenHolderFals.activeSelf == true)
                        {
                            skil24Vraga.transform.GetChild(0).gameObject.SetActive(true);
                        }
                        skreader.slot2falsMish.SetActive(true);
                        skreader.slot8falsMish.SetActive(true);
                        skreader.slot5falsMish.SetActive(true);
                    }
                    else if (skil25Vraga != null && skil25Vraga.GetComponent<Collider2D>().bounds.Contains(touch.position)) // и если не блок!!
                    {
                        // вкл подсветку
                        if (skreader.mishenHolderFals.activeSelf == true)
                        {
                            skil25Vraga.transform.GetChild(0).gameObject.SetActive(true);
                        }
                        skreader.slot1falsMishVraga.SetActive(true);
                        skreader.slot3falsMishVraga.SetActive(true);
                        skreader.slot7falsMishVraga.SetActive(true);
                        skreader.slot9falsMishVraga.SetActive(true);
                    }
                    else if (skil26Vraga != null && skil26Vraga.GetComponent<Collider2D>().bounds.Contains(touch.position)) // и если не блок!!
                    {
                        // вкл подсветку
                        if (skreader.mishenHolderFals.activeSelf == true)
                        {
                            skil26Vraga.transform.GetChild(0).gameObject.SetActive(true);
                        }
                        skreader.slot2falsMishVraga.SetActive(true);
                        skreader.slot4falsMishVraga.SetActive(true);
                        skreader.slot6falsMishVraga.SetActive(true);
                        skreader.slot8falsMishVraga.SetActive(true);
                    }
                    else if (skil27Vraga != null && skil27Vraga.GetComponent<Collider2D>().bounds.Contains(touch.position)) // и если не блок!!
                    {
                        // вкл подсветку
                        if (skreader.mishenHolderFals.activeSelf == true)
                        {
                            skil27Vraga.transform.GetChild(0).gameObject.SetActive(true);
                        }
                        if (skreader.slot1skillVraga == 27)
                        {
                            skreader.slot1falsMish.SetActive(true);
                            skreader.slot4falsMish.SetActive(true);
                            skreader.slot7falsMish.SetActive(true);
                        }
                        else if (skreader.slot3skillVraga == 27)
                        {
                            skreader.slot3falsMish.SetActive(true);
                            skreader.slot6falsMish.SetActive(true);
                            skreader.slot9falsMish.SetActive(true);
                        }
                        else if (skreader.slot7skillVraga == 27)
                        {
                            skreader.slot1falsMish.SetActive(true);
                            skreader.slot4falsMish.SetActive(true);
                            skreader.slot7falsMish.SetActive(true);
                        }
                        else if (skreader.slot9skillVraga == 27)
                        {
                            skreader.slot3falsMish.SetActive(true);
                            skreader.slot6falsMish.SetActive(true);
                            skreader.slot9falsMish.SetActive(true);
                        }
                    }
                    else if (skil28Vraga != null && skil28Vraga.GetComponent<Collider2D>().bounds.Contains(touch.position)) // и если не блок!!
                    {
                        // вкл подсветку
                        if (skreader.mishenHolderFals.activeSelf == true)
                        {
                            skil28Vraga.transform.GetChild(0).gameObject.SetActive(true);
                        }
                        if (skreader.slot1skillVraga == 28)
                        {
                            skreader.slot1falsMish.SetActive(true);
                        }
                        else if (skreader.slot2skillVraga == 28)
                        {
                            skreader.slot2falsMish.SetActive(true);
                        }
                        else if (skreader.slot3skillVraga == 28)
                        {
                            skreader.slot3falsMish.SetActive(true);
                        }
                        else if (skreader.slot4skillVraga == 28)
                        {
                            skreader.slot4falsMish.SetActive(true);
                        }
                        else if (skreader.slot5skillVraga == 28)
                        {
                            skreader.slot5falsMish.SetActive(true);
                        }
                        else if (skreader.slot6skillVraga == 28)
                        {
                            skreader.slot6falsMish.SetActive(true);
                        }
                    }
                    else if (skil29Vraga != null && skil29Vraga.GetComponent<Collider2D>().bounds.Contains(touch.position)) // и если не блок!!
                    {
                        // вкл подсветку
                        if (skreader.mishenHolderFals.activeSelf == true)
                        {
                            skil29Vraga.transform.GetChild(0).gameObject.SetActive(true);
                        }
                        if (skreader.slot4skillVraga == 29)
                        {
                            skreader.slot7falsMishVraga.SetActive(true);
                            skreader.slot8falsMishVraga.SetActive(true);
                            skreader.slot9falsMishVraga.SetActive(true);
                        }
                        else if (skreader.slot2skillVraga == 29)
                        {
                            skreader.slot7falsMishVraga.SetActive(true);
                            skreader.slot8falsMishVraga.SetActive(true);
                            skreader.slot9falsMishVraga.SetActive(true);
                        }
                    }
                    else if (skil30Vraga != null && skil30Vraga.GetComponent<Collider2D>().bounds.Contains(touch.position)) // и если не блок!!
                    {
                        // вкл подсветку
                        if (skreader.mishenHolderFals.activeSelf == true)
                        {
                            skil30Vraga.transform.GetChild(0).gameObject.SetActive(true);
                        }
                        if (skreader.slot4skillVraga == 30)
                        {
                            skreader.slot1falsMish.SetActive(true);
                            skreader.slot4falsMish.SetActive(true);
                            skreader.slot7falsMish.SetActive(true);
                        }
                        else if (skreader.slot5skillVraga == 30)
                        {
                            skreader.slot2falsMish.SetActive(true);
                            skreader.slot5falsMish.SetActive(true);
                            skreader.slot8falsMish.SetActive(true);
                        }
                        else if (skreader.slot6skillVraga == 30)
                        {
                            skreader.slot3falsMish.SetActive(true);
                            skreader.slot6falsMish.SetActive(true);
                            skreader.slot9falsMish.SetActive(true);
                        }
                    }
                    else if (skil31Vraga != null && skil31Vraga.GetComponent<Collider2D>().bounds.Contains(touch.position)) // и если не блок!!
                    {
                        // вкл подсветку
                        if (skreader.mishenHolderFals.activeSelf == true)
                        {
                            skil31Vraga.transform.GetChild(0).gameObject.SetActive(true);
                        }
                        if (skreader.slot7skillVraga == 31)
                        {
                            skreader.slot1falsMish.SetActive(true);
                            skreader.slot4falsMish.SetActive(true);
                            skreader.slot7falsMish.SetActive(true);
                        }
                        else if (skreader.slot8skillVraga == 31)
                        {
                            skreader.slot2falsMish.SetActive(true);
                            skreader.slot5falsMish.SetActive(true);
                            skreader.slot8falsMish.SetActive(true);
                        }
                        else if (skreader.slot9skillVraga == 31)
                        {
                            skreader.slot3falsMish.SetActive(true);
                            skreader.slot6falsMish.SetActive(true);
                            skreader.slot9falsMish.SetActive(true);
                        }
                    }
                    else if (skil32Vraga != null && skil32Vraga.GetComponent<Collider2D>().bounds.Contains(touch.position)) // и если не блок!!
                    {
                        // вкл подсветку
                        if (skreader.mishenHolderFals.activeSelf == true)
                        {
                            skil32Vraga.transform.GetChild(0).gameObject.SetActive(true);
                        }
                        skreader.slot1falsMish.SetActive(true);
                        skreader.slot2falsMish.SetActive(true);
                        skreader.slot3falsMish.SetActive(true);
                        skreader.slot4falsMish.SetActive(true);
                        skreader.slot5falsMish.SetActive(true);
                        skreader.slot6falsMish.SetActive(true);
                        skreader.slot7falsMish.SetActive(true);
                        skreader.slot8falsMish.SetActive(true);
                        skreader.slot9falsMish.SetActive(true);
                    }
                    else if (skil33Vraga != null && skil33Vraga.GetComponent<Collider2D>().bounds.Contains(touch.position)) // и если не блок!!
                    {
                        // вкл подсветку
                        if (skreader.mishenHolderFals.activeSelf == true)
                        {
                            skil33Vraga.transform.GetChild(0).gameObject.SetActive(true);
                        }
                        skreader.slot1falsMish.SetActive(true);
                        skreader.slot2falsMish.SetActive(true);
                        skreader.slot3falsMish.SetActive(true);
                        skreader.slot4falsMish.SetActive(true);
                        skreader.slot5falsMish.SetActive(true);
                        skreader.slot6falsMish.SetActive(true);
                        skreader.slot7falsMish.SetActive(true);
                        skreader.slot8falsMish.SetActive(true);
                        skreader.slot9falsMish.SetActive(true);
                    }
                    else if (skil34Vraga != null && skil34Vraga.GetComponent<Collider2D>().bounds.Contains(touch.position)) // и если не блок!!
                    {
                        // вкл подсветку
                        if (skreader.mishenHolderFals.activeSelf == true)
                        {
                            skil34Vraga.transform.GetChild(0).gameObject.SetActive(true);
                        }
                        skreader.slot1falsMish.SetActive(true);
                        skreader.slot2falsMish.SetActive(true);
                        skreader.slot3falsMish.SetActive(true);
                        skreader.slot4falsMish.SetActive(true);
                        skreader.slot5falsMish.SetActive(true);
                        skreader.slot6falsMish.SetActive(true);
                        skreader.slot7falsMish.SetActive(true);
                        skreader.slot8falsMish.SetActive(true);
                        skreader.slot9falsMish.SetActive(true);
                    }
                    else if (skil35Vraga != null && skil35Vraga.GetComponent<Collider2D>().bounds.Contains(touch.position)) // и если не блок!!
                    {
                        // вкл подсветку
                        if (skreader.mishenHolderFals.activeSelf == true)
                        {
                            skil35Vraga.transform.GetChild(0).gameObject.SetActive(true);
                        }
                        if (skreader.slot1skillVraga == 35)
                        {
                            skreader.slot2falsMishVraga.SetActive(true);
                            skreader.slot4falsMishVraga.SetActive(true);
                            skreader.slot5falsMishVraga.SetActive(true);
                        }
                        else if (skreader.slot2skillVraga == 35)
                        {
                            skreader.slot1falsMishVraga.SetActive(true);
                            skreader.slot3falsMishVraga.SetActive(true);
                            skreader.slot6falsMishVraga.SetActive(true);
                            skreader.slot5falsMishVraga.SetActive(true);
                            skreader.slot4falsMishVraga.SetActive(true);
                        }
                        else if (skreader.slot3skillVraga == 35)
                        {
                            skreader.slot2falsMishVraga.SetActive(true);
                            skreader.slot5falsMishVraga.SetActive(true);
                            skreader.slot6falsMishVraga.SetActive(true);
                        }
                    }
                    else if (skil36Vraga != null && skil36Vraga.GetComponent<Collider2D>().bounds.Contains(touch.position)) // и если не блок!!
                    {
                        // вкл подсветку
                        if (skreader.mishenHolderFals.activeSelf == true)
                        {
                            skil36Vraga.transform.GetChild(0).gameObject.SetActive(true);
                        }
                        if (skreader.slot2skillVraga == 36)
                        {
                            skreader.slot1falsMishVraga.SetActive(true);
                            skreader.slot2falsMishVraga.SetActive(true);
                            skreader.slot3falsMishVraga.SetActive(true);
                        }
                        if (skreader.slot5skillVraga == 36)
                        {
                            skreader.slot6falsMishVraga.SetActive(true);
                            skreader.slot5falsMishVraga.SetActive(true);
                            skreader.slot4falsMishVraga.SetActive(true);
                        }
                        if (skreader.slot8skillVraga == 36)
                        {
                            skreader.slot7falsMishVraga.SetActive(true);
                            skreader.slot8falsMishVraga.SetActive(true);
                            skreader.slot9falsMishVraga.SetActive(true);
                        }
                    }
                    else if (skil37Vraga != null && skil37Vraga.GetComponent<Collider2D>().bounds.Contains(touch.position)) // и если не блок!!
                    {
                        // вкл подсветку
                        if (skreader.mishenHolderFals.activeSelf == true)
                        {
                            skil37Vraga.transform.GetChild(0).gameObject.SetActive(true);
                        }
                        skreader.slot1falsMish.SetActive(true);
                        skreader.slot2falsMish.SetActive(true);
                        skreader.slot3falsMish.SetActive(true);
                        skreader.slot4falsMish.SetActive(true);
                        skreader.slot5falsMish.SetActive(true);
                        skreader.slot6falsMish.SetActive(true);
                        skreader.slot7falsMish.SetActive(true);
                        skreader.slot8falsMish.SetActive(true);
                        skreader.slot9falsMish.SetActive(true);
                    }
                    else if (skil38Vraga != null && skil38Vraga.GetComponent<Collider2D>().bounds.Contains(touch.position)) // и если не блок!!
                    {
                        // вкл подсветку
                        if (skreader.mishenHolderFals.activeSelf == true)
                        {
                            skil38Vraga.transform.GetChild(0).gameObject.SetActive(true);
                        }
                        if (skreader.slot1skillVraga == 38 || skreader.slot4skillVraga == 38 || skreader.slot7skillVraga == 38)
                        {
                            skreader.slot1falsMish.SetActive(true);
                            skreader.slot4falsMish.SetActive(true);
                            skreader.slot7falsMish.SetActive(true);
                        }
                        else if (skreader.slot2skillVraga == 38 || skreader.slot5skillVraga == 38 || skreader.slot8skillVraga == 38)
                        {
                            skreader.slot2falsMish.SetActive(true);
                            skreader.slot5falsMish.SetActive(true);
                            skreader.slot8falsMish.SetActive(true);
                        }
                        else if (skreader.slot3skillVraga == 38 || skreader.slot6skillVraga == 38 || skreader.slot9skillVraga == 38)
                        {
                            skreader.slot3falsMish.SetActive(true);
                            skreader.slot6falsMish.SetActive(true);
                            skreader.slot9falsMish.SetActive(true);
                        }
                    }
                    else if (skil39Vraga != null && skil39Vraga.GetComponent<Collider2D>().bounds.Contains(touch.position)) // и если не блок!!
                    {
                        // вкл подсветку
                        if (skreader.mishenHolderFals.activeSelf == true)
                        {
                            skil39Vraga.transform.GetChild(0).gameObject.SetActive(true);
                        }
                        if (skreader.slot5skillVraga == 39)
                        {
                            skreader.slot1falsMishVraga.SetActive(true);
                            skreader.slot2falsMishVraga.SetActive(true);
                            skreader.slot3falsMishVraga.SetActive(true);
                            skreader.slot4falsMishVraga.SetActive(true);
                            skreader.slot6falsMishVraga.SetActive(true);
                            skreader.slot7falsMishVraga.SetActive(true);
                            skreader.slot8falsMishVraga.SetActive(true);
                            skreader.slot9falsMishVraga.SetActive(true);
                        }
                        else if (skreader.slot7skillVraga == 39)
                        {
                            skreader.slot4falsMishVraga.SetActive(true);
                            skreader.slot5falsMishVraga.SetActive(true);
                            skreader.slot8falsMishVraga.SetActive(true);
                        }
                        else if (skreader.slot8skillVraga == 39)
                        {
                            skreader.slot4falsMishVraga.SetActive(true);
                            skreader.slot5falsMishVraga.SetActive(true);
                            skreader.slot7falsMishVraga.SetActive(true);
                            skreader.slot6falsMishVraga.SetActive(true);
                            skreader.slot9falsMishVraga.SetActive(true);
                        }
                        else if (skreader.slot9skillVraga == 39)
                        {
                            skreader.slot5falsMishVraga.SetActive(true);
                            skreader.slot6falsMishVraga.SetActive(true);
                            skreader.slot8falsMishVraga.SetActive(true);
                        }
                    }
                    else if (skil40Vraga != null && skil40Vraga.GetComponent<Collider2D>().bounds.Contains(touch.position)) // и если не блок!!
                    {
                        // вкл подсветку
                        if (skreader.mishenHolderFals.activeSelf == true)
                        {
                            skil40Vraga.transform.GetChild(0).gameObject.SetActive(true);
                        }
                        skreader.slot1falsMish.SetActive(true);
                        skreader.slot2falsMish.SetActive(true);
                        skreader.slot3falsMish.SetActive(true);
                        skreader.slot4falsMish.SetActive(true);
                        skreader.slot5falsMish.SetActive(true);
                        skreader.slot6falsMish.SetActive(true);
                        skreader.slot7falsMish.SetActive(true);
                        skreader.slot8falsMish.SetActive(true);
                        skreader.slot9falsMish.SetActive(true);
                    }
                    else if (skil41Vraga != null && skil41Vraga.GetComponent<Collider2D>().bounds.Contains(touch.position)) // и если не блок!!
                    {
                        // вкл подсветку
                        if (skreader.mishenHolderFals.activeSelf == true)
                        {
                            skil41Vraga.transform.GetChild(0).gameObject.SetActive(true);
                        }
                    }
                    else if (skil42Vraga != null && skil42Vraga.GetComponent<Collider2D>().bounds.Contains(touch.position)) // и если не блок!!
                    {
                        // вкл подсветку
                        if (skreader.mishenHolderFals.activeSelf == true)
                        {
                            skil42Vraga.transform.GetChild(0).gameObject.SetActive(true);
                        }
                        if (skreader.slot2skillVraga == 42)
                        {
                            skreader.slot1falsMishVraga.SetActive(true);
                            skreader.slot2falsMish.SetActive(true);
                        }
                        else if (skreader.slot5skillVraga == 42)
                        {
                            skreader.slot4falsMishVraga.SetActive(true);
                            skreader.slot5falsMish.SetActive(true);
                        }
                        else if (skreader.slot6skillVraga == 42)
                        {
                            skreader.slot5falsMishVraga.SetActive(true);
                            skreader.slot6falsMish.SetActive(true);
                        }
                        else if (skreader.slot8skillVraga == 42)
                        {
                            skreader.slot7falsMishVraga.SetActive(true);
                            skreader.slot8falsMish.SetActive(true);
                        }
                    }
                    else if (skil43Vraga != null && skil43Vraga.GetComponent<Collider2D>().bounds.Contains(touch.position)) // и если не блок!!
                    {
                        // вкл подсветку
                        if (skreader.mishenHolderFals.activeSelf == true)
                        {
                            skil43Vraga.transform.GetChild(0).gameObject.SetActive(true);
                        }
                        if (skreader.slot1skillVraga == 43)
                        {
                            skreader.slot1falsMish.SetActive(true);
                        }
                        else if (skreader.slot2skillVraga == 43)
                        {
                            skreader.slot2falsMish.SetActive(true);
                        }
                        else if (skreader.slot3skillVraga == 43)
                        {
                            skreader.slot3falsMish.SetActive(true);
                        }
                        else if (skreader.slot4skillVraga == 43)
                        {
                            skreader.slot4falsMish.SetActive(true);
                        }
                    }
                }








            }
            // если фаза закончилась, все мишени слетают, подсветки тоже
            else if (touch.phase == TouchPhase.Ended)
            {
                skreader.mishenHolderFals.SetActive(true);
                skreader.mishenHolderVragaFals.SetActive(true);
                skreader.slot1falsMish.SetActive(false);
                skreader.slot2falsMish.SetActive(false);
                skreader.slot3falsMish.SetActive(false);
                skreader.slot4falsMish.SetActive(false);
                skreader.slot5falsMish.SetActive(false);
                skreader.slot6falsMish.SetActive(false);
                skreader.slot7falsMish.SetActive(false);
                skreader.slot8falsMish.SetActive(false);
                skreader.slot9falsMish.SetActive(false);
                skreader.slot1falsMishVraga.SetActive(false);
                skreader.slot2falsMishVraga.SetActive(false);
                skreader.slot3falsMishVraga.SetActive(false);
                skreader.slot4falsMishVraga.SetActive(false);
                skreader.slot5falsMishVraga.SetActive(false);
                skreader.slot6falsMishVraga.SetActive(false);
                skreader.slot7falsMishVraga.SetActive(false);
                skreader.slot8falsMishVraga.SetActive(false);
                skreader.slot9falsMishVraga.SetActive(false);
                otkluchPodsvetok();
            }
        }
        // если все то же, но без скиллзбэк, описания и подсветки исчезают


        if (battleModeVisibility.mermanChitaetsya == true)
        {
            if (readalready1 == false && (enemySpawner.dot1 || enemySpawner.dot2 || enemySpawner.dot3)) // если первая точка финала
            {
                // если пустой - 12, если уязвимый - 5
                if (enemySpawner.dot1)
                {
                    skreader.slot2skillVraga = 5;
                    skreader.slot4skillVraga = 5;
                    skreader.slot6skillVraga = 5;
                    skreader.slot8skillVraga = 5;
                    skreader.slot1skillVraga = 12;
                    skreader.slot3skillVraga = 12;
                    skreader.slot5skillVraga = 12;
                    skreader.slot7skillVraga = 12;
                    skreader.slot9skillVraga = 12;
                }
                else if (enemySpawner.dot2)
                {
                    skreader.slot2skillVraga = 5;
                    skreader.slot6skillVraga = 5;
                    skreader.slot8skillVraga = 5;
                    skreader.slot4skillVraga = 12;
                    skreader.slot1skillVraga = 12;
                    skreader.slot3skillVraga = 12;
                    skreader.slot5skillVraga = 12;
                    skreader.slot7skillVraga = 12;
                    skreader.slot9skillVraga = 12;
                }
                else if (enemySpawner.dot3)
                {
                    skreader.slot1skillVraga = 5;
                    skreader.slot3skillVraga = 5;
                    skreader.slot5skillVraga = 5;
                    skreader.slot2skillVraga = 5;
                    skreader.slot8skillVraga = 5;
                    skreader.slot4skillVraga = 12;
                    skreader.slot6skillVraga = 12;
                    skreader.slot7skillVraga = 12;
                    skreader.slot9skillVraga = 12;
                }

                // очистка
                foreach (Transform child in slotsEnemy.slo1.transform)
                {
                    Destroy(child.gameObject);
                }
                foreach (Transform child in slotsEnemy.slo2.transform)
                {
                    Destroy(child.gameObject);
                }
                foreach (Transform child in slotsEnemy.slo3.transform)
                {
                    Destroy(child.gameObject);
                }
                foreach (Transform child in slotsEnemy.slo4.transform)
                {
                    Destroy(child.gameObject);
                }
                foreach (Transform child in slotsEnemy.slo5.transform)
                {
                    Destroy(child.gameObject);
                }
                foreach (Transform child in slotsEnemy.slo6.transform)
                {
                    Destroy(child.gameObject);
                }
                foreach (Transform child in slotsEnemy.slo7.transform)
                {
                    Destroy(child.gameObject);
                }
                foreach (Transform child in slotsEnemy.slo8.transform)
                {
                    Destroy(child.gameObject);
                }
                foreach (Transform child in slotsEnemy.slo9.transform)
                {
                    Destroy(child.gameObject);
                }
                // спавн одинаковых
                if (enemySpawner.dot1)
                {
                    Instantiate(skilloiddot1, slotsEnemy.slo1.transform.position, Quaternion.identity, slotsEnemy.slo1.transform);
                    Instantiate(skilloiddot1, slotsEnemy.slo2.transform.position, Quaternion.identity, slotsEnemy.slo2.transform);
                    Instantiate(skilloiddot1, slotsEnemy.slo3.transform.position, Quaternion.identity, slotsEnemy.slo3.transform);
                    Instantiate(skilloiddot1, slotsEnemy.slo4.transform.position, Quaternion.identity, slotsEnemy.slo4.transform);
                    Instantiate(skilloiddot1, slotsEnemy.slo5.transform.position, Quaternion.identity, slotsEnemy.slo5.transform);
                    Instantiate(skilloiddot1, slotsEnemy.slo6.transform.position, Quaternion.identity, slotsEnemy.slo6.transform);
                    Instantiate(skilloiddot1, slotsEnemy.slo7.transform.position, Quaternion.identity, slotsEnemy.slo7.transform);
                    Instantiate(skilloiddot1, slotsEnemy.slo8.transform.position, Quaternion.identity, slotsEnemy.slo8.transform);
                    Instantiate(skilloiddot1, slotsEnemy.slo9.transform.position, Quaternion.identity, slotsEnemy.slo9.transform);
                }
                else if (enemySpawner.dot2)
                {
                    Instantiate(skilloiddot2, slotsEnemy.slo1.transform.position, Quaternion.identity, slotsEnemy.slo1.transform);
                    Instantiate(skilloiddot2, slotsEnemy.slo2.transform.position, Quaternion.identity, slotsEnemy.slo2.transform);
                    Instantiate(skilloiddot2, slotsEnemy.slo3.transform.position, Quaternion.identity, slotsEnemy.slo3.transform);
                    Instantiate(skilloiddot2, slotsEnemy.slo4.transform.position, Quaternion.identity, slotsEnemy.slo4.transform);
                    Instantiate(skilloiddot2, slotsEnemy.slo5.transform.position, Quaternion.identity, slotsEnemy.slo5.transform);
                    Instantiate(skilloiddot2, slotsEnemy.slo6.transform.position, Quaternion.identity, slotsEnemy.slo6.transform);
                    Instantiate(skilloiddot2, slotsEnemy.slo7.transform.position, Quaternion.identity, slotsEnemy.slo7.transform);
                    Instantiate(skilloiddot2, slotsEnemy.slo8.transform.position, Quaternion.identity, slotsEnemy.slo8.transform);
                    Instantiate(skilloiddot2, slotsEnemy.slo9.transform.position, Quaternion.identity, slotsEnemy.slo9.transform);
                }
                else if (enemySpawner.dot3)
                {
                    Instantiate(skilloiddot3, slotsEnemy.slo1.transform.position, Quaternion.identity, slotsEnemy.slo1.transform);
                    Instantiate(skilloiddot3, slotsEnemy.slo2.transform.position, Quaternion.identity, slotsEnemy.slo2.transform);
                    Instantiate(skilloiddot3, slotsEnemy.slo3.transform.position, Quaternion.identity, slotsEnemy.slo3.transform);
                    Instantiate(skilloiddot3, slotsEnemy.slo4.transform.position, Quaternion.identity, slotsEnemy.slo4.transform);
                    Instantiate(skilloiddot3, slotsEnemy.slo5.transform.position, Quaternion.identity, slotsEnemy.slo5.transform);
                    Instantiate(skilloiddot3, slotsEnemy.slo6.transform.position, Quaternion.identity, slotsEnemy.slo6.transform);
                    Instantiate(skilloiddot3, slotsEnemy.slo7.transform.position, Quaternion.identity, slotsEnemy.slo7.transform);
                    Instantiate(skilloiddot3, slotsEnemy.slo8.transform.position, Quaternion.identity, slotsEnemy.slo8.transform);
                    Instantiate(skilloiddot3, slotsEnemy.slo9.transform.position, Quaternion.identity, slotsEnemy.slo9.transform);
                }
                skreader.slot1targetVr1 = null;
                skreader.slot1targetVr2 = null;
                skreader.slot1targetVr3 = null;
                skreader.slot2targetVr1 = null;
                skreader.slot2targetVr2 = null;
                skreader.slot2targetVr3 = null;
                skreader.slot3targetVr1 = null;
                skreader.slot3targetVr2 = null;
                skreader.slot3targetVr3 = null;
                skreader.slot4targetVr1 = null;
                skreader.slot4targetVr2 = null;
                skreader.slot4targetVr3 = null;
                skreader.slot5targetVr1 = null;
                skreader.slot5targetVr2 = null;
                skreader.slot5targetVr3 = null;
                skreader.slot6targetVr1 = null;
                skreader.slot6targetVr2 = null;
                skreader.slot6targetVr3 = null;
                skreader.slot7targetVr1 = null;
                skreader.slot7targetVr2 = null;
                skreader.slot7targetVr3 = null;
                skreader.slot8targetVr1 = null;
                skreader.slot8targetVr2 = null;
                skreader.slot8targetVr3 = null;
                skreader.slot9targetVr1 = null;
                skreader.slot9targetVr2 = null;
                skreader.slot9targetVr3 = null;

                // всё прочитано сразу же
                readalready1 = true;
                readalready2 = true;
                readalready3 = true;
                readalready4 = true;
                readalready5 = true;
                readalready6 = true;
                readalready7 = true;
                readalready8 = true;
                readalready9 = true;
                justonceRead = false;
            }


            // 1 слот
            if (readalready1 == false)
            {

                // зависимо от глубины

                if (distancePoints.distance < 5500) // биом 1
                {
                    prefabIndexin1place = Random.Range(0, 5);
                }
                else if (distancePoints.distance >= 5500 && distancePoints.distance < 6500)
                {
                    prefabIndexin1place = Random.Range(0, 10);
                }
                else if (distancePoints.distance >= 6500 && distancePoints.distance < 10500)
                {
                    prefabIndexin1place = Random.Range(5, 15);
                }
                else if (distancePoints.distance > 10500)
                {
                    prefabIndexin1place = Random.Range(5, 16); // максимальный диапазон
                }
                // тут генерация еще раз зависимо от специфичного мермена

                if (enemySpawner.bMarius == true) // 1 слот - что-то обязательно, в остальных пусто
                {
                    prefabIndexin1place = Random.Range(0, 15); // любая клетка всего диапазона
                }
                else if (enemySpawner.bTheus) 
                {
                    switch (batol.fortheus1)
                    {
                        case 0: // значение навыка
                            prefabIndexin1place = 100;
                            break;
                        case 1:
                            prefabIndexin1place = 0;
                            break;
                        case 2:
                            prefabIndexin1place = 1;
                            break;
                        case 3:
                            prefabIndexin1place = 2;
                            break;
                        case 4:
                            prefabIndexin1place = 3;
                            break;
                        case 11:
                            prefabIndexin1place = 4;
                            break;
                        case 17:
                            prefabIndexin1place = 5;
                            break;
                        case 18:
                            prefabIndexin1place = 6;
                            break;
                        case 20:
                            prefabIndexin1place = 7;
                            break;
                        case 21:
                            prefabIndexin1place = 8;
                            break;
                        case 27:
                            prefabIndexin1place = 9;
                            break;
                        case 28:
                            prefabIndexin1place = 10;
                            break;
                        case 33:
                            prefabIndexin1place = 11;
                            break;
                        case 35:
                            prefabIndexin1place = 12;
                            break;
                        case 38:
                            prefabIndexin1place = 13;
                            break;
                        case 40:
                            prefabIndexin1place = 14;
                            break;
                        case 43:
                            prefabIndexin1place = 15;
                            break;

                    }
                }
                else if (enemySpawner.bPareed == true)
                {
                    prefabIndexin1place = Random.Range(0, 15);
                }
                // тут теуза нет, у него 1 навык свой

                // тут читается соответствие скилла и рандомного префаба в списке
                foreach (Transform child in slotsEnemy.slo1.transform)
                {
                    Destroy(child.gameObject);
                }
                skreader.slot1targetVr1 = null;
                skreader.slot1targetVr2 = null;
                skreader.slot1targetVr3 = null;
                switch (prefabIndexin1place)
                {
                    case 0:
                        skreader.slot1skillVraga = 1;
                        skil1Vraga = Instantiate(skills1place[prefabIndexin1place], slotsEnemy.slo1.transform.position, Quaternion.identity, slotsEnemy.slo1.transform) as GameObject; // спавн
                        skreader.slot1targetVr1 = skreader.slotGG1;
                        skreader.slot1targetVr2 = null;
                        skreader.slot1targetVr3 = null;
                        break;
                    case 1:
                        skreader.slot1skillVraga = 2;
                        skil2Vraga = Instantiate(skills1place[prefabIndexin1place], slotsEnemy.slo1.transform.position, Quaternion.identity, slotsEnemy.slo1.transform) as GameObject; // спавн
                        skreader.slot1targetVr1 = skreader.slotGG4;
                        skreader.slot1targetVr2 = null;
                        skreader.slot1targetVr3 = null;
                        break;
                    case 2:
                        skreader.slot1skillVraga = 3;
                        skil3Vraga = Instantiate(skills1place[prefabIndexin1place], slotsEnemy.slo1.transform.position, Quaternion.identity, slotsEnemy.slo1.transform) as GameObject; // спавн
                        skreader.slot1targetVr1 = skreader.slotGG7;
                        skreader.slot1targetVr2 = null;
                        skreader.slot1targetVr3 = null;
                        break;
                    case 3:
                        skreader.slot1skillVraga = 4;
                        skil4Vraga = Instantiate(skills1place[prefabIndexin1place], slotsEnemy.slo1.transform.position, Quaternion.identity, slotsEnemy.slo1.transform) as GameObject; // спавн
                        skreader.slot1targetVr1 = skreader.slotGG1;
                        skreader.slot1targetVr2 = null;
                        skreader.slot1targetVr3 = null;
                        break;
                    case 4:
                        skreader.slot1skillVraga = 11;
                        skil11Vraga = Instantiate(skills1place[prefabIndexin1place], slotsEnemy.slo1.transform.position, Quaternion.identity, slotsEnemy.slo1.transform) as GameObject; // спавн
                        skreader.slot1targetVr1 = skreader.slotVraga4;
                        skreader.slot1targetVr2 = skreader.slotVraga7;
                        skreader.slot1targetVr3 = null;
                        break;
                    case 5:
                        skreader.slot1skillVraga = 17;
                        skil17Vraga = Instantiate(skills1place[prefabIndexin1place], slotsEnemy.slo1.transform.position, Quaternion.identity, slotsEnemy.slo1.transform) as GameObject; // спавн
                        skreader.slot1targetVr1 = skreader.slotGG1;
                        switch (Random.Range(0, 2))
                        {
                            case 1:
                                skreader.slot1targetVr2 = skreader.slotGG2;
                                break;
                            default:
                                skreader.slot1targetVr2 = skreader.slotGG4;
                                break;
                        }
                        skreader.slot1targetVr3 = null;
                        break;
                    case 6:
                        skreader.slot1skillVraga = 18;
                        skil18Vraga = Instantiate(skills1place[prefabIndexin1place], slotsEnemy.slo1.transform.position, Quaternion.identity, slotsEnemy.slo1.transform) as GameObject; // спавн
                        skreader.slot1targetVr1 = skreader.slotVraga1;
                        skreader.slot1targetVr2 = skreader.slotVraga4;
                        skreader.slot1targetVr3 = null;
                        break;
                    case 7:
                        skreader.slot1skillVraga = 20;
                        skil20Vraga = Instantiate(skills1place[prefabIndexin1place], slotsEnemy.slo1.transform.position, Quaternion.identity, slotsEnemy.slo1.transform) as GameObject; // спавн
                        skreader.slot1targetVr1 = null;
                        skreader.slot1targetVr2 = null;
                        skreader.slot1targetVr3 = null;
                        break;
                    case 8:
                        skreader.slot1skillVraga = 21;
                        skil21Vraga = Instantiate(skills1place[prefabIndexin1place], slotsEnemy.slo1.transform.position, Quaternion.identity, slotsEnemy.slo1.transform) as GameObject; // спавн
                        skreader.slot1targetVr1 = skreader.slotVraga1;
                        skreader.slot1targetVr2 = skreader.slotGG1;
                        skreader.slot1targetVr3 = null;
                        break;
                    case 9:
                        skreader.slot1skillVraga = 27;
                        skil27Vraga = Instantiate(skills1place[prefabIndexin1place], slotsEnemy.slo1.transform.position, Quaternion.identity, slotsEnemy.slo1.transform) as GameObject; // спавн

                        skreader.slot1targetVr1 = skreader.slotGG4;
                        switch (Random.Range(0, 2))
                        {
                            case 1:
                                skreader.slot1targetVr2 = skreader.slotGG1;
                                break;
                            default:
                                skreader.slot1targetVr2 = skreader.slotGG7;
                                break;
                        }
                        skreader.slot1targetVr3 = null;
                        break;
                    case 10:
                        skreader.slot1skillVraga = 28;
                        skil28Vraga = Instantiate(skills1place[prefabIndexin1place], slotsEnemy.slo1.transform.position, Quaternion.identity, slotsEnemy.slo1.transform) as GameObject; // спавн
                        skreader.slot1targetVr1 = skreader.slotGG1;
                        skreader.slot1targetVr2 = null;
                        skreader.slot1targetVr3 = null;
                        break;
                    case 11:
                        skreader.slot1skillVraga = 33;
                        skil33Vraga = Instantiate(skills1place[prefabIndexin1place], slotsEnemy.slo1.transform.position, Quaternion.identity, slotsEnemy.slo1.transform) as GameObject; // спавн
                        switch (Random.Range(0, 5))
                        {
                            case 1:
                                skreader.slot1targetVr1 = skreader.slotGG1;
                                break;
                            case 2:
                                skreader.slot1targetVr1 = skreader.slotGG2;
                                break;
                            case 3:
                                skreader.slot1targetVr1 = skreader.slotGG3;
                                break;
                            case 4:
                                skreader.slot1targetVr1 = skreader.slotGG4;
                                break;
                            default:
                                skreader.slot1targetVr1 = skreader.slotGG5;
                                break;
                        }
                        switch (Random.Range(0, 4))
                        {
                            case 1:
                                skreader.slot1targetVr2 = skreader.slotGG6;
                                break;
                            case 2:
                                skreader.slot1targetVr2 = skreader.slotGG7;
                                break;
                            case 3:
                                skreader.slot1targetVr2 = skreader.slotGG8;
                                break;
                            default:
                                skreader.slot1targetVr2 = skreader.slotGG9;
                                break;
                        }
                        skreader.slot1targetVr3 = null;
                        break;
                    case 12:
                        skreader.slot1skillVraga = 35;
                        skil35Vraga = Instantiate(skills1place[prefabIndexin1place], slotsEnemy.slo1.transform.position, Quaternion.identity, slotsEnemy.slo1.transform) as GameObject; // спавн
                        skreader.slot1targetVr1 = skreader.slotVraga2;
                        skreader.slot1targetVr2 = skreader.slotVraga4;
                        skreader.slot1targetVr3 = skreader.slotVraga5;
                        break;
                    case 13:
                        skreader.slot1skillVraga = 38;
                        skil38Vraga = Instantiate(skills1place[prefabIndexin1place], slotsEnemy.slo1.transform.position, Quaternion.identity, slotsEnemy.slo1.transform) as GameObject; // спавн
                        switch (Random.Range(0, 3))
                        {
                            case 1:
                                skreader.slot1targetVr1 = skreader.slotGG1;
                                break;
                            case 2:
                                skreader.slot1targetVr1 = skreader.slotGG4;
                                break;
                            default:
                                skreader.slot1targetVr1 = skreader.slotGG7;
                                break;
                        }
                        skreader.slot1targetVr2 = null;
                        skreader.slot1targetVr3 = null;
                        break;
                    case 14:
                        skreader.slot1skillVraga = 40;
                        skil40Vraga = Instantiate(skills1place[prefabIndexin1place], slotsEnemy.slo1.transform.position, Quaternion.identity, slotsEnemy.slo1.transform) as GameObject; // спавн
                        switch (Random.Range(0, 5))
                        {
                            case 1:
                                skreader.slot1targetVr1 = skreader.slotGG1;
                                break;
                            case 2:
                                skreader.slot1targetVr1 = skreader.slotGG2;
                                break;
                            case 3:
                                skreader.slot1targetVr1 = skreader.slotGG3;
                                break;
                            case 4:
                                skreader.slot1targetVr1 = skreader.slotGG4;
                                break;
                            default:
                                skreader.slot1targetVr1 = skreader.slotGG5;
                                break;
                        }
                        switch (Random.Range(0, 4))
                        {
                            case 1:
                                skreader.slot1targetVr2 = skreader.slotGG6;
                                break;
                            case 2:
                                skreader.slot1targetVr2 = skreader.slotGG7;
                                break;
                            case 3:
                                skreader.slot1targetVr2 = skreader.slotGG8;
                                break;
                            default:
                                skreader.slot1targetVr2 = skreader.slotGG9;
                                break;
                        }
                        skreader.slot1targetVr3 = null;
                        break;
                    case 15:
                        skreader.slot1skillVraga = 43;
                        skil43Vraga = Instantiate(skills1place[prefabIndexin1place], slotsEnemy.slo1.transform.position, Quaternion.identity, slotsEnemy.slo1.transform) as GameObject; // спавн
                        skreader.slot1targetVr1 = skreader.slotGG1;
                        skreader.slot1targetVr2 = null;
                        skreader.slot1targetVr3 = null;
                        break;

                    default: // промах
                        skreader.slot1skillVraga = 0;
                        skreader.slot1targetVr1 = null;
                        skreader.slot1targetVr2 = null;
                        skreader.slot1targetVr3 = null;
                        readalready1 = true;
                        break;
                }
                if (enemySpawner.bPareed == true && (skreader.slot1skillVraga == 1 || skreader.slot1skillVraga == 2 || skreader.slot1skillVraga == 3 || skreader.slot1skillVraga == 13 || skreader.slot1skillVraga == 14 || skreader.slot1skillVraga == 16 || skreader.slot1skillVraga == 17 || skreader.slot1skillVraga == 21 || skreader.slot1skillVraga == 22 || skreader.slot1skillVraga == 23 || skreader.slot1skillVraga == 30 || skreader.slot1skillVraga == 32 || skreader.slot1skillVraga == 33 || skreader.slot1skillVraga == 34 || skreader.slot1skillVraga == 40 || skreader.slot1skillVraga == 43))
                {
                    readalready1 = true;
                }
                else if (enemySpawner.bPareed != true)
                {
                    readalready1 = true;
                }
            }

            // 2 слот
            if (readalready1 && readalready2 == false)
            {
                // зависимо от глубины
                if (distancePoints.distance < 5500) // биом 1
                {
                    prefabIndexin2place = Random.Range(0, 5);
                }
                else if (distancePoints.distance >= 5500 && distancePoints.distance < 6500)
                {
                    prefabIndexin2place = Random.Range(0, 10);
                }
                else if (distancePoints.distance >= 6500 && distancePoints.distance < 10500)
                {
                    prefabIndexin2place = Random.Range(5, 15);
                }
                else if (distancePoints.distance > 10500)
                {
                    prefabIndexin2place = Random.Range(5, 17); // максимальный диапазон
                }

                if (enemySpawner.bMarius == true)
                {
                    prefabIndexin2place = 100; // пусто
                }
                else if (enemySpawner.bPareed == true)
                {
                    prefabIndexin2place = Random.Range(0, 16);
                }
                else if (enemySpawner.bTheus == true) // копия формации гг
                {
                    // это читает навык гг в 2 слоте, подбирается для диапазона ниже
                    switch (batol.fortheus2)
                    {
                        case 0: // значение навыка
                            prefabIndexin2place = 100;
                            break;
                        case 1:
                            prefabIndexin2place = 0;
                            break;
                        case 2:
                            prefabIndexin2place = 1;
                            break;
                        case 3:
                            prefabIndexin2place = 2;
                            break;
                        case 4:
                            prefabIndexin2place = 3;
                            break;
                        case 10:
                            prefabIndexin2place = 4;
                            break;
                        case 17:
                            prefabIndexin2place = 5;
                            break;
                        case 18:
                            prefabIndexin2place = 6;
                            break;
                        case 21:
                            prefabIndexin2place = 7;
                            break;
                        case 22:
                            prefabIndexin2place = 8;
                            break;
                        case 28:
                            prefabIndexin2place = 9;
                            break;
                        case 33:
                            prefabIndexin2place = 10;
                            break;
                        case 35:
                            prefabIndexin2place = 11;
                            break;
                        case 36:
                            prefabIndexin2place = 12;
                            break;
                        case 38:
                            prefabIndexin2place = 13;
                            break;
                        case 40:
                            prefabIndexin2place = 14;
                            break;
                        case 42:
                            prefabIndexin2place = 15;
                            break;
                        case 43:
                            prefabIndexin2place = 16;
                            break;

                    }
                }

                foreach (Transform child in slotsEnemy.slo2.transform)
                {
                    Destroy(child.gameObject);
                }
                skreader.slot2targetVr1 = null;
                skreader.slot2targetVr2 = null;
                skreader.slot2targetVr3 = null;
                switch (prefabIndexin2place)
                {
                    case 0:
                        skreader.slot2skillVraga = 1;
                        if (skil1Vraga == null) // если 1 скилл не был до этого
                        {
                            skil1Vraga = Instantiate(skills2place[prefabIndexin2place], slotsEnemy.slo2.transform.position, Quaternion.identity, slotsEnemy.slo2.transform) as GameObject;
                        }
                        skreader.slot2targetVr1 = skreader.slotGG2;
                        skreader.slot2targetVr2 = null;
                        skreader.slot2targetVr3 = null;
                        break;
                    case 1:
                        skreader.slot2skillVraga = 2;
                        if (skil2Vraga == null)
                        {
                            skil2Vraga = Instantiate(skills2place[prefabIndexin2place], slotsEnemy.slo2.transform.position, Quaternion.identity, slotsEnemy.slo2.transform) as GameObject;
                        }
                        skreader.slot2targetVr1 = skreader.slotGG5;
                        skreader.slot2targetVr2 = null;
                        skreader.slot2targetVr3 = null;
                        break;
                    case 2:
                        skreader.slot2skillVraga = 3;
                        if (skil3Vraga == null)
                        {
                            skil3Vraga = Instantiate(skills2place[prefabIndexin2place], slotsEnemy.slo2.transform.position, Quaternion.identity, slotsEnemy.slo2.transform) as GameObject;
                        }
                        skreader.slot2targetVr1 = skreader.slotGG8;
                        skreader.slot2targetVr2 = null;
                        skreader.slot2targetVr3 = null;
                        break;
                    case 3:
                        skreader.slot2skillVraga = 4;
                        if (skil4Vraga == null)
                        {
                            skil4Vraga = Instantiate(skills2place[prefabIndexin2place], slotsEnemy.slo2.transform.position, Quaternion.identity, slotsEnemy.slo2.transform) as GameObject;
                        }
                        skreader.slot2targetVr1 = skreader.slotGG2;
                        skreader.slot2targetVr2 = null;
                        skreader.slot2targetVr3 = null;
                        break;
                    case 4:
                        skreader.slot2skillVraga = 10;
                        if (skil10Vraga == null)
                        {
                            skil10Vraga = Instantiate(skills2place[prefabIndexin2place], slotsEnemy.slo2.transform.position, Quaternion.identity, slotsEnemy.slo2.transform) as GameObject;
                        }
                        skreader.slot2targetVr1 = skreader.slotVraga5;
                        skreader.slot2targetVr2 = skreader.slotVraga8;
                        skreader.slot2targetVr3 = null;
                        break;
                    case 5:
                        skreader.slot2skillVraga = 17;
                        if (skil17Vraga == null)
                        {
                            skil17Vraga = Instantiate(skills2place[prefabIndexin2place], slotsEnemy.slo2.transform.position, Quaternion.identity, slotsEnemy.slo2.transform) as GameObject;
                        }
                        skreader.slot2targetVr1 = skreader.slotGG2;
                        switch (Random.Range(0, 2))
                        {
                            case 1:
                                skreader.slot2targetVr2 = skreader.slotGG1;
                                break;
                            default:
                                skreader.slot2targetVr2 = skreader.slotGG4;
                                break;
                        }
                        skreader.slot2targetVr3 = null;
                        break;
                    case 6:
                        skreader.slot2skillVraga = 18;
                        if (skil18Vraga == null)
                        {
                            skil18Vraga = Instantiate(skills2place[prefabIndexin2place], slotsEnemy.slo2.transform.position, Quaternion.identity, slotsEnemy.slo2.transform) as GameObject;
                        }
                        skreader.slot2targetVr1 = skreader.slotVraga2;
                        skreader.slot2targetVr2 = skreader.slotVraga5;
                        skreader.slot2targetVr3 = null;
                        break;
                    case 7:
                        skreader.slot2skillVraga = 21;
                        if (skil21Vraga == null)
                        {
                            skil21Vraga = Instantiate(skills2place[prefabIndexin2place], slotsEnemy.slo2.transform.position, Quaternion.identity, slotsEnemy.slo2.transform) as GameObject;
                        }
                        skreader.slot2targetVr1 = skreader.slotVraga2;
                        skreader.slot2targetVr2 = skreader.slotGG2;
                        skreader.slot2targetVr3 = null;
                        break;
                    case 8:
                        skreader.slot2skillVraga = 22;
                        if (skil22Vraga == null)
                        {
                            skil22Vraga = Instantiate(skills2place[prefabIndexin2place], slotsEnemy.slo2.transform.position, Quaternion.identity, slotsEnemy.slo2.transform) as GameObject;
                        }
                        skreader.slot2targetVr1 = skreader.slotGG2;
                        skreader.slot2targetVr2 = null;
                        skreader.slot2targetVr3 = null;
                        break;
                    case 9:
                        skreader.slot2skillVraga = 28;
                        if (skil28Vraga == null)
                        {
                            skil28Vraga = Instantiate(skills2place[prefabIndexin2place], slotsEnemy.slo2.transform.position, Quaternion.identity, slotsEnemy.slo2.transform) as GameObject;
                        }
                        skreader.slot2targetVr1 = skreader.slotGG2;
                        skreader.slot2targetVr2 = null;
                        skreader.slot2targetVr3 = null;
                        break;
                    case 10:
                        skreader.slot2skillVraga = 33;
                        if (skil33Vraga == null)
                        {
                            skil33Vraga = Instantiate(skills2place[prefabIndexin2place], slotsEnemy.slo2.transform.position, Quaternion.identity, slotsEnemy.slo2.transform) as GameObject;
                        }
                        switch (Random.Range(0, 5))
                        {
                            case 1:
                                skreader.slot2targetVr1 = skreader.slotGG1;
                                break;
                            case 2:
                                skreader.slot2targetVr1 = skreader.slotGG2;
                                break;
                            case 3:
                                skreader.slot2targetVr1 = skreader.slotGG3;
                                break;
                            case 4:
                                skreader.slot2targetVr1 = skreader.slotGG4;
                                break;
                            default:
                                skreader.slot2targetVr1 = skreader.slotGG5;
                                break;
                        }
                        switch (Random.Range(0, 4))
                        {
                            case 1:
                                skreader.slot2targetVr2 = skreader.slotGG6;
                                break;
                            case 2:
                                skreader.slot2targetVr2 = skreader.slotGG7;
                                break;
                            case 3:
                                skreader.slot2targetVr2 = skreader.slotGG8;
                                break;
                            default:
                                skreader.slot2targetVr2 = skreader.slotGG9;
                                break;
                        }
                        skreader.slot2targetVr3 = null;
                        break;
                    case 11:
                        skreader.slot2skillVraga = 35;
                        if (skil35Vraga == null)
                        {
                            skil35Vraga = Instantiate(skills2place[prefabIndexin2place], slotsEnemy.slo2.transform.position, Quaternion.identity, slotsEnemy.slo2.transform) as GameObject;
                        }
                        switch (Random.Range(0, 2))
                        {
                            case 1:
                                skreader.slot2targetVr1 = skreader.slotVraga1;
                                break;
                            default:
                                skreader.slot2targetVr1 = skreader.slotVraga3;
                                break;
                        }
                        switch (Random.Range(0, 2))
                        {
                            case 1:
                                skreader.slot2targetVr2 = skreader.slotVraga4;
                                break;
                            default:
                                skreader.slot2targetVr2 = skreader.slotVraga5;
                                break;
                        }
                        skreader.slot2targetVr3 = skreader.slotVraga6;
                        break;
                    case 12:
                        skreader.slot2skillVraga = 36;
                        if (skil36Vraga == null)
                        {
                            skil36Vraga = Instantiate(skills2place[prefabIndexin2place], slotsEnemy.slo2.transform.position, Quaternion.identity, slotsEnemy.slo2.transform) as GameObject;
                        }
                        skreader.slot2targetVr1 = skreader.slotVraga1;
                        skreader.slot2targetVr2 = skreader.slotVraga2;
                        skreader.slot2targetVr3 = skreader.slotVraga3;
                        break;
                    case 13:
                        skreader.slot2skillVraga = 38;
                        if (skil38Vraga == null)
                        {
                            skil38Vraga = Instantiate(skills2place[prefabIndexin2place], slotsEnemy.slo2.transform.position, Quaternion.identity, slotsEnemy.slo2.transform) as GameObject;
                        }
                        switch (Random.Range(0, 3))
                        {
                            case 1:
                                skreader.slot2targetVr1 = skreader.slotGG2;
                                break;
                            case 2:
                                skreader.slot2targetVr1 = skreader.slotGG5;
                                break;
                            default:
                                skreader.slot2targetVr1 = skreader.slotGG8;
                                break;
                        }
                        skreader.slot2targetVr2 = null;
                        skreader.slot2targetVr3 = null;
                        break;
                    case 14:
                        skreader.slot2skillVraga = 40;
                        if (skil40Vraga == null)
                        {
                            skil40Vraga = Instantiate(skills2place[prefabIndexin2place], slotsEnemy.slo2.transform.position, Quaternion.identity, slotsEnemy.slo2.transform) as GameObject;
                        }
                        switch (Random.Range(0, 5))
                        {
                            case 1:
                                skreader.slot2targetVr1 = skreader.slotGG1;
                                break;
                            case 2:
                                skreader.slot2targetVr1 = skreader.slotGG2;
                                break;
                            case 3:
                                skreader.slot2targetVr1 = skreader.slotGG3;
                                break;
                            case 4:
                                skreader.slot2targetVr1 = skreader.slotGG4;
                                break;
                            default:
                                skreader.slot2targetVr1 = skreader.slotGG5;
                                break;
                        }
                        switch (Random.Range(0, 4))
                        {
                            case 1:
                                skreader.slot2targetVr2 = skreader.slotGG6;
                                break;
                            case 2:
                                skreader.slot2targetVr2 = skreader.slotGG7;
                                break;
                            case 3:
                                skreader.slot2targetVr2 = skreader.slotGG8;
                                break;
                            default:
                                skreader.slot2targetVr2 = skreader.slotGG9;
                                break;
                        }
                        skreader.slot2targetVr3 = null;
                        break;
                    case 15:
                        skreader.slot2skillVraga = 42;
                        if (skil42Vraga == null)
                        {
                            skil42Vraga = Instantiate(skills2place[prefabIndexin2place], slotsEnemy.slo2.transform.position, Quaternion.identity, slotsEnemy.slo2.transform) as GameObject;
                        }
                        skreader.slot2targetVr1 = skreader.slotVraga1;
                        skreader.slot2targetVr2 = null;
                        skreader.slot2targetVr3 = null;
                        break;
                    case 16:
                        skreader.slot2skillVraga = 43;
                        if (skil43Vraga == null)
                        {
                            skil43Vraga = Instantiate(skills2place[prefabIndexin2place], slotsEnemy.slo2.transform.position, Quaternion.identity, slotsEnemy.slo2.transform) as GameObject;
                        }
                        skreader.slot2targetVr1 = skreader.slotGG2;
                        skreader.slot2targetVr2 = null;
                        skreader.slot2targetVr3 = null;
                        break;
                    default: // промах
                        skreader.slot2skillVraga = 0;
                        skreader.slot2targetVr1 = null;
                        skreader.slot2targetVr2 = null;
                        skreader.slot2targetVr3 = null;
                        readalready2 = true;
                        break;
                }
                if (enemySpawner.bPareed == true && (skreader.slot2skillVraga == 1 || skreader.slot2skillVraga == 2 || skreader.slot2skillVraga == 3 || skreader.slot2skillVraga == 13 || skreader.slot2skillVraga == 14 || skreader.slot2skillVraga == 16 || skreader.slot2skillVraga == 17 || skreader.slot2skillVraga == 21 || skreader.slot2skillVraga == 22 || skreader.slot2skillVraga == 23 || skreader.slot2skillVraga == 30 || skreader.slot2skillVraga == 32 || skreader.slot2skillVraga == 33 || skreader.slot2skillVraga == 34 || skreader.slot2skillVraga == 40 || skreader.slot2skillVraga == 43))
                {
                    if (skreader.slot2skillVraga != skreader.slot1skillVraga)
                    {
                        readalready2 = true;
                    }
                }
                else if (enemySpawner.bPareed != true)
                {
                    if (skreader.slot2skillVraga != skreader.slot1skillVraga)
                    {
                        readalready2 = true;
                    }
                }
            }
            // 3 слот
            if (readalready2 && readalready3 == false)
            {
                if (distancePoints.distance < 5500)
                {
                    prefabIndexin3place = Random.Range(0, 5);
                }
                else if (distancePoints.distance >= 5500 && distancePoints.distance < 6500)
                {
                    prefabIndexin3place = Random.Range(0, 10);
                }
                else if (distancePoints.distance >= 6500 && distancePoints.distance < 10500)
                {
                    prefabIndexin3place = Random.Range(5, 15);
                }
                else if (distancePoints.distance > 10500)
                {
                    prefabIndexin3place = Random.Range(5, 16);
                }

                if (enemySpawner.bMarius == true)
                {
                    prefabIndexin3place = 100;
                }
                else if (enemySpawner.bPareed == true)
                {
                    prefabIndexin3place = Random.Range(0, 15);
                }
                else if (enemySpawner.bSciph == true || enemySpawner.bTkhar == true) 
                {
                    if(skreader.slot1skillVraga != 20 && skreader.slot2skillVraga != 20)
                    {
                        prefabIndexin3place = 7;
                    }
                }
                else if (enemySpawner.bTheus == true)
                {
                    switch (batol.fortheus3)
                    {
                        case 0: // значение навыка
                            prefabIndexin3place = 100;
                            break;
                        case 1:
                            prefabIndexin3place = 0;
                            break;
                        case 2:
                            prefabIndexin3place = 1;
                            break;
                        case 3:
                            prefabIndexin3place = 2;
                            break;
                        case 4:
                            prefabIndexin3place = 3;
                            break;
                        case 11:
                            prefabIndexin3place = 4;
                            break;
                        case 17:
                            prefabIndexin3place = 5;
                            break;
                        case 18:
                            prefabIndexin3place = 6;
                            break;
                        case 20:
                            prefabIndexin3place = 7;
                            break;
                        case 21:
                            prefabIndexin3place = 8;
                            break;
                        case 27:
                            prefabIndexin3place = 9;
                            break;
                        case 33:
                            prefabIndexin3place = 10;
                            break;
                        case 35:
                            prefabIndexin3place = 11;
                            break;
                        case 38:
                            prefabIndexin3place = 12;
                            break;
                        case 40:
                            prefabIndexin3place = 13;
                            break;
                        case 43:
                            prefabIndexin3place = 14;
                            break;
                    }
                }


                foreach (Transform child in slotsEnemy.slo3.transform)
                {
                    Destroy(child.gameObject);
                }
                skreader.slot3targetVr1 = null;
                skreader.slot3targetVr2 = null;
                skreader.slot3targetVr3 = null;
                switch (prefabIndexin3place)
                {
                    case 0:
                        skreader.slot3skillVraga = 1;
                        if (skil1Vraga == null)
                        {
                            skil1Vraga = Instantiate(skills3place[prefabIndexin3place], slotsEnemy.slo3.transform.position, Quaternion.identity, slotsEnemy.slo3.transform) as GameObject; // спавн
                        }
                        skreader.slot3targetVr1 = skreader.slotGG3;
                        skreader.slot3targetVr2 = null;
                        skreader.slot3targetVr3 = null;
                        break;
                    case 1:
                        skreader.slot3skillVraga = 2;
                        if (skil2Vraga == null)
                        {
                            skil2Vraga = Instantiate(skills3place[prefabIndexin3place], slotsEnemy.slo3.transform.position, Quaternion.identity, slotsEnemy.slo3.transform) as GameObject; // спавн
                        }
                        skreader.slot3targetVr1 = skreader.slotGG6;
                        skreader.slot3targetVr2 = null;
                        skreader.slot3targetVr3 = null;
                        break;
                    case 2:
                        skreader.slot3skillVraga = 3;
                        if (skil3Vraga == null)
                        {
                            skil3Vraga = Instantiate(skills3place[prefabIndexin3place], slotsEnemy.slo3.transform.position, Quaternion.identity, slotsEnemy.slo3.transform) as GameObject; // спавн
                        }
                        skreader.slot3targetVr1 = skreader.slotGG9;
                        skreader.slot3targetVr2 = null;
                        skreader.slot3targetVr3 = null;
                        break;
                    case 3:
                        skreader.slot3skillVraga = 4;
                        if (skil4Vraga == null)
                        {
                            skil4Vraga = Instantiate(skills3place[prefabIndexin3place], slotsEnemy.slo3.transform.position, Quaternion.identity, slotsEnemy.slo3.transform) as GameObject; // спавн
                        }
                        skreader.slot3targetVr1 = skreader.slotGG3;
                        skreader.slot3targetVr2 = null;
                        skreader.slot3targetVr3 = null;
                        break;
                    case 4:
                        skreader.slot3skillVraga = 11;
                        if (skil11Vraga == null)
                        {
                            skil11Vraga = Instantiate(skills3place[prefabIndexin3place], slotsEnemy.slo3.transform.position, Quaternion.identity, slotsEnemy.slo3.transform) as GameObject; // спавн
                        }
                        skreader.slot3targetVr1 = skreader.slotVraga6;
                        skreader.slot3targetVr2 = skreader.slotVraga9;
                        skreader.slot3targetVr3 = null;
                        break;
                    case 5:
                        skreader.slot3skillVraga = 17;
                        if (skil17Vraga == null)
                        {
                            skil17Vraga = Instantiate(skills3place[prefabIndexin3place], slotsEnemy.slo3.transform.position, Quaternion.identity, slotsEnemy.slo3.transform) as GameObject; // спавн
                        }
                        skreader.slot3targetVr1 = skreader.slotGG3;
                        switch (Random.Range(0, 2))
                        {
                            case 1:
                                skreader.slot3targetVr2 = skreader.slotGG2;
                                break;
                            default:
                                skreader.slot3targetVr2 = skreader.slotGG6;
                                break;
                        }
                        skreader.slot3targetVr3 = null;
                        break;
                    case 6:
                        skreader.slot3skillVraga = 18;
                        if (skil18Vraga == null)
                        {
                            skil18Vraga = Instantiate(skills3place[prefabIndexin3place], slotsEnemy.slo3.transform.position, Quaternion.identity, slotsEnemy.slo3.transform) as GameObject; // спавн
                        }
                        skreader.slot3targetVr1 = skreader.slotVraga3;
                        skreader.slot3targetVr2 = skreader.slotVraga6;
                        skreader.slot3targetVr3 = null;
                        break;
                    case 7:
                        skreader.slot3skillVraga = 20;
                        if (skil20Vraga == null)
                        {
                            skil20Vraga = Instantiate(skills3place[prefabIndexin3place], slotsEnemy.slo3.transform.position, Quaternion.identity, slotsEnemy.slo3.transform) as GameObject; // спавн
                        }
                        skreader.slot3targetVr1 = null;
                        skreader.slot3targetVr2 = null;
                        skreader.slot3targetVr3 = null;
                        break;
                    case 8:
                        skreader.slot3skillVraga = 21;
                        if (skil21Vraga == null)
                        {
                            skil21Vraga = Instantiate(skills3place[prefabIndexin3place], slotsEnemy.slo3.transform.position, Quaternion.identity, slotsEnemy.slo3.transform) as GameObject; // спавн
                        }
                        skreader.slot3targetVr1 = skreader.slotVraga3;
                        skreader.slot3targetVr2 = skreader.slotGG3;
                        skreader.slot3targetVr3 = null;
                        break;
                    case 9:
                        skreader.slot3skillVraga = 27;
                        if (skil27Vraga == null)
                        {
                            skil27Vraga = Instantiate(skills3place[prefabIndexin3place], slotsEnemy.slo3.transform.position, Quaternion.identity, slotsEnemy.slo3.transform) as GameObject; // спавн
                        }
                        skreader.slot3targetVr1 = skreader.slotGG6;
                        switch (Random.Range(0, 2))
                        {
                            case 1:
                                skreader.slot3targetVr2 = skreader.slotGG3;
                                break;
                            default:
                                skreader.slot3targetVr2 = skreader.slotGG9;
                                break;
                        }
                        skreader.slot3targetVr3 = null;
                        break;
                    // это плавники
                    case 10:
                        skreader.slot3skillVraga = 33;
                        if (skil33Vraga == null)
                        {
                            skil33Vraga = Instantiate(skills3place[prefabIndexin3place], slotsEnemy.slo3.transform.position, Quaternion.identity, slotsEnemy.slo3.transform) as GameObject; // спавн
                        }
                        switch (Random.Range(0, 5))
                        {
                            case 1:
                                skreader.slot3targetVr1 = skreader.slotGG1;
                                break;
                            case 2:
                                skreader.slot3targetVr1 = skreader.slotGG2;
                                break;
                            case 3:
                                skreader.slot3targetVr1 = skreader.slotGG3;
                                break;
                            case 4:
                                skreader.slot3targetVr1 = skreader.slotGG4;
                                break;
                            default:
                                skreader.slot3targetVr1 = skreader.slotGG5;
                                break;
                        }
                        switch (Random.Range(0, 4))
                        {
                            case 1:
                                skreader.slot3targetVr2 = skreader.slotGG6;
                                break;
                            case 2:
                                skreader.slot3targetVr2 = skreader.slotGG7;
                                break;
                            case 3:
                                skreader.slot3targetVr2 = skreader.slotGG8;
                                break;
                            default:
                                skreader.slot3targetVr2 = skreader.slotGG9;
                                break;
                        }
                        skreader.slot3targetVr3 = null;
                        break;
                    case 11:
                        skreader.slot3skillVraga = 35;
                        if (skil35Vraga == null)
                        {
                            skil35Vraga = Instantiate(skills3place[prefabIndexin3place], slotsEnemy.slo3.transform.position, Quaternion.identity, slotsEnemy.slo3.transform) as GameObject; // спавн
                        }
                        skreader.slot3targetVr1 = skreader.slotVraga2;
                        skreader.slot3targetVr2 = skreader.slotVraga6;
                        skreader.slot3targetVr3 = skreader.slotVraga5;
                        break;
                    case 12:
                        skreader.slot3skillVraga = 38;
                        if (skil38Vraga == null)
                        {
                            skil38Vraga = Instantiate(skills3place[prefabIndexin3place], slotsEnemy.slo3.transform.position, Quaternion.identity, slotsEnemy.slo3.transform) as GameObject; // спавн
                        }
                        switch (Random.Range(0, 3))
                        {
                            case 1:
                                skreader.slot3targetVr1 = skreader.slotGG3;
                                break;
                            case 2:
                                skreader.slot3targetVr1 = skreader.slotGG6;
                                break;
                            default:
                                skreader.slot3targetVr1 = skreader.slotGG9;
                                break;
                        }
                        skreader.slot3targetVr2 = null;
                        skreader.slot3targetVr3 = null;
                        break;
                    case 13:
                        skreader.slot3skillVraga = 40;
                        if (skil40Vraga == null)
                        {
                            skil40Vraga = Instantiate(skills3place[prefabIndexin3place], slotsEnemy.slo3.transform.position, Quaternion.identity, slotsEnemy.slo3.transform) as GameObject; // спавн
                        }
                        switch (Random.Range(0, 5))
                        {
                            case 1:
                                skreader.slot3targetVr1 = skreader.slotGG1;
                                break;
                            case 2:
                                skreader.slot3targetVr1 = skreader.slotGG2;
                                break;
                            case 3:
                                skreader.slot3targetVr1 = skreader.slotGG3;
                                break;
                            case 4:
                                skreader.slot3targetVr1 = skreader.slotGG4;
                                break;
                            default:
                                skreader.slot3targetVr1 = skreader.slotGG5;
                                break;
                        }
                        switch (Random.Range(0, 4))
                        {
                            case 1:
                                skreader.slot3targetVr2 = skreader.slotGG6;
                                break;
                            case 2:
                                skreader.slot3targetVr2 = skreader.slotGG7;
                                break;
                            case 3:
                                skreader.slot3targetVr2 = skreader.slotGG8;
                                break;
                            default:
                                skreader.slot3targetVr2 = skreader.slotGG9;
                                break;
                        }
                        skreader.slot3targetVr3 = null;
                        break;
                    case 14:
                        skreader.slot3skillVraga = 43;
                        if (skil43Vraga == null)
                        {
                            skil43Vraga = Instantiate(skills3place[prefabIndexin3place], slotsEnemy.slo3.transform.position, Quaternion.identity, slotsEnemy.slo3.transform) as GameObject; // спавн
                        }
                        skreader.slot3targetVr1 = skreader.slotGG3;
                        skreader.slot3targetVr2 = null;
                        skreader.slot3targetVr3 = null;
                        break;
                    default: // промах
                        skreader.slot3skillVraga = 0;
                        readalready3 = true;
                        skreader.slot3targetVr1 = null;
                        skreader.slot3targetVr2 = null;
                        skreader.slot3targetVr3 = null;
                        break;
                }
                if (enemySpawner.bPareed == true && (skreader.slot3skillVraga == 1 || skreader.slot3skillVraga == 2 || skreader.slot3skillVraga == 3 || skreader.slot3skillVraga == 13 || skreader.slot3skillVraga == 14 || skreader.slot3skillVraga == 16 || skreader.slot3skillVraga == 17 || skreader.slot3skillVraga == 21 || skreader.slot3skillVraga == 22 || skreader.slot3skillVraga == 23 || skreader.slot3skillVraga == 30 || skreader.slot3skillVraga == 32 || skreader.slot3skillVraga == 33 || skreader.slot3skillVraga == 34 || skreader.slot3skillVraga == 40 || skreader.slot3skillVraga == 43))
                {
                    if (skreader.slot3skillVraga != skreader.slot2skillVraga && skreader.slot3skillVraga != skreader.slot1skillVraga)
                    {
                        readalready3 = true;
                    }
                }
                else if (enemySpawner.bPareed != true)
                {
                    if (skreader.slot3skillVraga != skreader.slot2skillVraga && skreader.slot3skillVraga != skreader.slot1skillVraga)
                    {
                        readalready3 = true;
                    }
                }
            }
            // 4 слот
            if (readalready3 && readalready4 == false)
            {
                if (distancePoints.distance < 5500) // биом 1
                {
                    prefabIndexin4place = Random.Range(0, 5);
                }
                else if (distancePoints.distance >= 5500 && distancePoints.distance < 6500)
                {
                    prefabIndexin4place = Random.Range(0, 10);
                }
                else if (distancePoints.distance >= 6500 && distancePoints.distance < 10500)
                {
                    prefabIndexin4place = Random.Range(5, 15);
                }
                else if (distancePoints.distance > 10500)
                {
                    prefabIndexin4place = Random.Range(5, 18); // максимальный диапазон
                }

                if (enemySpawner.bMarius == true || enemySpawner.bGren || enemySpawner.bRago)
                {
                    prefabIndexin4place = 100;
                }
                else if (enemySpawner.bPareed == true)
                {
                    prefabIndexin4place = Random.Range(0, 17);
                }
                else if (enemySpawner.bTheus == true)
                {
                    switch (batol.fortheus4)
                    {
                        case 0: // значение навыка
                            prefabIndexin4place = 100;
                            break;
                        case 5:
                            prefabIndexin4place = 0;
                            break;
                        case 6:
                            prefabIndexin4place = 1;
                            break;
                        case 7:
                            prefabIndexin4place = 2;
                            break;
                        case 8:
                            prefabIndexin4place = 3;
                            break;
                        case 10:
                            prefabIndexin4place = 4;
                            break;
                        case 12:
                            prefabIndexin4place = 5;
                            break;
                        case 13:
                            prefabIndexin4place = 6;
                            break;
                        case 15:
                            prefabIndexin4place = 7;
                            break;
                        case 19:
                            prefabIndexin4place = 8;
                            break;
                        case 21:
                            prefabIndexin4place = 9;
                            break;
                        case 28:
                            prefabIndexin4place = 10;
                            break;
                        case 29:
                            prefabIndexin4place = 11;
                            break;
                        case 30:
                            prefabIndexin4place = 12;
                            break;
                        case 34:
                            prefabIndexin4place = 13;
                            break;
                        case 38:
                            prefabIndexin4place = 14;
                            break;
                        case 40:
                            prefabIndexin4place = 14;
                            break;
                        case 41:
                            prefabIndexin4place = 14;
                            break;
                        case 43:
                            prefabIndexin4place = 14;
                            break;
                    }
                }


                foreach (Transform child in slotsEnemy.slo4.transform)
                {
                    Destroy(child.gameObject);
                }
                skreader.slot4targetVr1 = null;
                skreader.slot4targetVr2 = null;
                skreader.slot4targetVr3 = null;
                switch (prefabIndexin4place)
                {
                    case 0:
                        skreader.slot4skillVraga = 5;
                        if (skil5Vraga == null)
                        {
                            skil5Vraga = Instantiate(skills4place[prefabIndexin4place], slotsEnemy.slo4.transform.position, Quaternion.identity, slotsEnemy.slo4.transform) as GameObject; // спавн
                        }
                        // тут рандомится цель
                        int targettt = Random.Range(1, 3);
                        switch (targettt)
                        {
                            case 1:
                                skreader.slot4targetVr1 = skreader.slotVraga1;
                                break;
                            case 2:
                                skreader.slot4targetVr1 = skreader.slotVraga2;
                                break;
                            case 3:
                                skreader.slot4targetVr1 = skreader.slotVraga3;
                                break;
                        }
                        skreader.slot4targetVr2 = null;
                        skreader.slot4targetVr3 = null;
                        break;
                    case 1:
                        skreader.slot4skillVraga = 6;
                        if (skil6Vraga == null)
                        {
                            skil6Vraga = Instantiate(skills4place[prefabIndexin4place], slotsEnemy.slo4.transform.position, Quaternion.identity, slotsEnemy.slo4.transform) as GameObject; // спавн
                        }
                        skreader.slot4targetVr1 = skreader.slotVraga1;
                        skreader.slot4targetVr2 = null;
                        skreader.slot4targetVr3 = null;
                        break;
                    case 2:
                        skreader.slot4skillVraga = 7;
                        if (skil7Vraga == null)
                        {
                            skil7Vraga = Instantiate(skills4place[prefabIndexin4place], slotsEnemy.slo4.transform.position, Quaternion.identity, slotsEnemy.slo4.transform) as GameObject; // спавн
                        }
                        skreader.slot4targetVr1 = skreader.slotVraga1;
                        skreader.slot4targetVr2 = null;
                        skreader.slot4targetVr3 = null;
                        break;
                    case 3:
                        skreader.slot4skillVraga = 8;
                        if (skil8Vraga == null)
                        {
                            skil8Vraga = Instantiate(skills4place[prefabIndexin4place], slotsEnemy.slo4.transform.position, Quaternion.identity, slotsEnemy.slo4.transform) as GameObject; // спавн
                        }
                        skreader.slot4targetVr1 = skreader.slotVraga1;
                        skreader.slot4targetVr2 = null;
                        skreader.slot4targetVr3 = null;
                        break;
                    case 4:
                        skreader.slot4skillVraga = 10;
                        if (skil10Vraga == null)
                        {
                            skil10Vraga = Instantiate(skills4place[prefabIndexin4place], slotsEnemy.slo4.transform.position, Quaternion.identity, slotsEnemy.slo4.transform) as GameObject; // спавн
                        }
                        skreader.slot4targetVr1 = skreader.slotVraga7;
                        skreader.slot4targetVr2 = null;
                        skreader.slot4targetVr3 = null;
                        break;
                    case 5:
                        skreader.slot4skillVraga = 12;
                        if (skil12Vraga == null)
                        {
                            skil12Vraga = Instantiate(skills4place[prefabIndexin4place], slotsEnemy.slo4.transform.position, Quaternion.identity, slotsEnemy.slo4.transform) as GameObject; // спавн
                        }
                        switch (Random.Range(0, 5))
                        {
                            case 1:
                                skreader.slot4targetVr1 = skreader.slotVraga5;
                                break;
                            case 2:
                                skreader.slot4targetVr1 = skreader.slotVraga6;
                                break;
                            case 3:
                                skreader.slot4targetVr1 = skreader.slotVraga7;
                                break;
                            case 4:
                                skreader.slot4targetVr1 = skreader.slotVraga8;
                                break;
                            default:
                                skreader.slot4targetVr1 = skreader.slotVraga9;
                                break;
                        }
                        skreader.slot4targetVr2 = null;
                        skreader.slot4targetVr3 = null;
                        break;
                    case 6:
                        skreader.slot4skillVraga = 13;
                        if (skil13Vraga == null)
                        {
                            skil13Vraga = Instantiate(skills4place[prefabIndexin4place], slotsEnemy.slo4.transform.position, Quaternion.identity, slotsEnemy.slo4.transform) as GameObject; // спавн
                        }
                        switch (Random.Range(0, 3))
                        {
                            case 1:
                                skreader.slot4targetVr1 = skreader.slotGG1;
                                break;
                            case 2:
                                skreader.slot4targetVr1 = skreader.slotGG4;
                                break;
                            default:
                                skreader.slot4targetVr1 = skreader.slotGG7;
                                break;
                        }
                        skreader.slot4targetVr2 = null;
                        skreader.slot4targetVr3 = null;
                        break;
                    case 7:
                        skreader.slot4skillVraga = 15;
                        if (skil15Vraga == null)
                        {
                            skil15Vraga = Instantiate(skills4place[prefabIndexin4place], slotsEnemy.slo4.transform.position, Quaternion.identity, slotsEnemy.slo4.transform) as GameObject; // спавн
                        }
                        skreader.slot4targetVr1 = skreader.slotGG4;
                        skreader.slot4targetVr2 = null;
                        skreader.slot4targetVr3 = null;
                        break;
                    case 8:
                        skreader.slot4skillVraga = 19;
                        if (skil19Vraga == null)
                        {
                            skil19Vraga = Instantiate(skills4place[prefabIndexin4place], slotsEnemy.slo4.transform.position, Quaternion.identity, slotsEnemy.slo4.transform) as GameObject; // спавн
                        }
                        switch (Random.Range(0, 3))
                        {
                            case 1:
                                skreader.slot4targetVr1 = skreader.slotGG1;
                                break;
                            case 2:
                                skreader.slot4targetVr1 = skreader.slotGG4;
                                break;
                            default:
                                skreader.slot4targetVr1 = skreader.slotGG7;
                                break;
                        }
                        skreader.slot4targetVr2 = null;
                        skreader.slot4targetVr3 = null;
                        break;
                    case 9:
                        skreader.slot4skillVraga = 21;
                        if (skil21Vraga == null)
                        {
                            skil21Vraga = Instantiate(skills4place[prefabIndexin4place], slotsEnemy.slo4.transform.position, Quaternion.identity, slotsEnemy.slo4.transform) as GameObject; // спавн
                        }
                        skreader.slot4targetVr1 = skreader.slotVraga4;
                        skreader.slot4targetVr2 = skreader.slotGG4;
                        skreader.slot4targetVr3 = null;
                        break;
                    case 10:
                        skreader.slot4skillVraga = 28;
                        if (skil28Vraga == null)
                        {
                            skil28Vraga = Instantiate(skills4place[prefabIndexin4place], slotsEnemy.slo4.transform.position, Quaternion.identity, slotsEnemy.slo4.transform) as GameObject; // спавн
                        }
                        skreader.slot4targetVr1 = skreader.slotGG4;
                        skreader.slot4targetVr2 = null;
                        skreader.slot4targetVr3 = null;
                        break;
                    case 11:
                        skreader.slot4skillVraga = 29;
                        if (skil29Vraga == null)
                        {
                            skil29Vraga = Instantiate(skills4place[prefabIndexin4place], slotsEnemy.slo4.transform.position, Quaternion.identity, slotsEnemy.slo4.transform) as GameObject; // спавн
                        }
                        skreader.slot4targetVr1 = skreader.slotVraga7;
                        skreader.slot4targetVr2 = skreader.slotVraga8;
                        skreader.slot4targetVr3 = skreader.slotVraga9;
                        break;
                    case 12:
                        skreader.slot4skillVraga = 30;
                        if (skil30Vraga == null)
                        {
                            skil30Vraga = Instantiate(skills4place[prefabIndexin4place], slotsEnemy.slo4.transform.position, Quaternion.identity, slotsEnemy.slo4.transform) as GameObject; // спавн
                        }
                        skreader.slot4targetVr1 = skreader.slotGG7;
                        skreader.slot4targetVr2 = skreader.slotGG1;
                        skreader.slot4targetVr3 = skreader.slotGG4;
                        break;
                    case 13:
                        skreader.slot4skillVraga = 34;
                        if (skil34Vraga == null)
                        {
                            skil34Vraga = Instantiate(skills4place[prefabIndexin4place], slotsEnemy.slo4.transform.position, Quaternion.identity, slotsEnemy.slo4.transform) as GameObject; // спавн
                        }
                        switch (Random.Range(0, 3))
                        {
                            case 1:
                                skreader.slot4targetVr1 = skreader.slotGG1;
                                skreader.slot4targetVr2 = skreader.slotGG2;
                                skreader.slot4targetVr3 = skreader.slotGG3;
                                break;
                            case 2:
                                skreader.slot4targetVr1 = skreader.slotGG4;
                                skreader.slot4targetVr2 = skreader.slotGG5;
                                skreader.slot4targetVr3 = skreader.slotGG6;
                                break;
                            default:
                                skreader.slot4targetVr1 = skreader.slotGG7;
                                skreader.slot4targetVr2 = skreader.slotGG8;
                                skreader.slot4targetVr3 = skreader.slotGG9;
                                break;
                        }

                        break;
                    case 14:
                        skreader.slot4skillVraga = 38;
                        if (skil38Vraga == null)
                        {
                            skil38Vraga = Instantiate(skills4place[prefabIndexin4place], slotsEnemy.slo4.transform.position, Quaternion.identity, slotsEnemy.slo4.transform) as GameObject; // спавн
                        }
                        switch (Random.Range(0, 3))
                        {
                            case 1:
                                skreader.slot4targetVr1 = skreader.slotGG1;
                                break;
                            case 2:
                                skreader.slot4targetVr1 = skreader.slotGG4;
                                break;
                            default:
                                skreader.slot4targetVr1 = skreader.slotGG7;
                                break;
                        }
                        skreader.slot4targetVr2 = null;
                        skreader.slot4targetVr3 = null;
                        break;
                    case 15:
                        skreader.slot4skillVraga = 40;
                        if (skil40Vraga == null)
                        {
                            skil40Vraga = Instantiate(skills4place[prefabIndexin4place], slotsEnemy.slo4.transform.position, Quaternion.identity, slotsEnemy.slo4.transform) as GameObject; // спавн
                        }
                        switch (Random.Range(0, 5))
                        {
                            case 1:
                                skreader.slot4targetVr1 = skreader.slotGG1;
                                break;
                            case 2:
                                skreader.slot4targetVr1 = skreader.slotGG2;
                                break;
                            case 3:
                                skreader.slot4targetVr1 = skreader.slotGG3;
                                break;
                            case 4:
                                skreader.slot4targetVr1 = skreader.slotGG4;
                                break;
                            default:
                                skreader.slot4targetVr1 = skreader.slotGG5;
                                break;
                        }
                        switch (Random.Range(0, 4))
                        {
                            case 1:
                                skreader.slot4targetVr2 = skreader.slotGG6;
                                break;
                            case 2:
                                skreader.slot4targetVr2 = skreader.slotGG7;
                                break;
                            case 3:
                                skreader.slot4targetVr2 = skreader.slotGG8;
                                break;
                            default:
                                skreader.slot4targetVr2 = skreader.slotGG9;
                                break;
                        }
                        skreader.slot4targetVr3 = null;
                        break;
                    case 16:
                        skreader.slot4skillVraga = 41;
                        if (skil41Vraga == null)
                        {
                            skil41Vraga = Instantiate(skills4place[prefabIndexin4place], slotsEnemy.slo4.transform.position, Quaternion.identity, slotsEnemy.slo4.transform) as GameObject; // спавн
                        }
                        skreader.slot4targetVr1 = null;
                        skreader.slot4targetVr2 = null;
                        skreader.slot4targetVr3 = null;
                        break;
                    case 17:
                        skreader.slot4skillVraga = 43;
                        if (skil43Vraga == null)
                        {
                            skil43Vraga = Instantiate(skills4place[prefabIndexin4place], slotsEnemy.slo4.transform.position, Quaternion.identity, slotsEnemy.slo4.transform) as GameObject; // спавн
                        }
                        skreader.slot4targetVr1 = skreader.slotGG4;
                        skreader.slot4targetVr2 = null;
                        skreader.slot4targetVr3 = null;
                        break;
                    default: // промах
                        skreader.slot4skillVraga = 0;
                        readalready4 = true;
                        skreader.slot4targetVr1 = null;
                        skreader.slot4targetVr2 = null;
                        skreader.slot4targetVr3 = null;
                        break;
                }
                if (skreader.slot4skillVraga != skreader.slot1skillVraga && skreader.slot4skillVraga != skreader.slot2skillVraga && skreader.slot4skillVraga != skreader.slot3skillVraga)
                {
                    readalready4 = true;
                }

            }
            // 5 слот
            if (readalready4 && readalready5 == false)
            {
                if (distancePoints.distance < 5500) // биом 1
                {
                    prefabIndexin5place = Random.Range(0, 5);
                }
                else if (distancePoints.distance >= 5500 && distancePoints.distance < 6500)
                {
                    prefabIndexin5place = Random.Range(0, 10);
                }
                else if (distancePoints.distance >= 6500 && distancePoints.distance < 10500)
                {
                    prefabIndexin5place = Random.Range(5, 15);
                }
                else if (distancePoints.distance > 10500)
                {
                    prefabIndexin5place = Random.Range(5, 20); // максимальный диапазон
                }
                if (enemySpawner.bMarius == true || enemySpawner.bBent || enemySpawner.bKridei || enemySpawner.bRago)
                {
                    prefabIndexin5place = 100;
                }
                else if (enemySpawner.bPareed == true)
                {
                    prefabIndexin5place = Random.Range(0, 19);
                }
                else if (enemySpawner.bSciph == true || enemySpawner.bTkhar == true)
                {
                    if (skreader.slot2skillVraga != 28 && skreader.slot1skillVraga != 28 && skreader.slot3skillVraga != 28 && skreader.slot4skillVraga != 28)
                    {
                        prefabIndexin5place = 11;
                    }
                }
                else if (enemySpawner.bTheus == true)
                {
                    switch (batol.fortheus5)
                    {
                        case 0: // значение навыка
                            prefabIndexin5place = 100;
                            break;
                        case 1:
                            prefabIndexin5place = 0;
                            break;
                        case 2:
                            prefabIndexin5place = 1;
                            break;
                        case 3:
                            prefabIndexin5place = 2;
                            break;
                        case 5:
                            prefabIndexin5place = 3;
                            break;
                        case 11:
                            prefabIndexin5place = 4;
                            break;
                        case 12:
                            prefabIndexin5place = 5;
                            break;
                        case 15:
                            prefabIndexin5place = 6;
                            break;
                        case 19:
                            prefabIndexin5place = 7;
                            break;
                        case 22:
                            prefabIndexin5place = 8;
                            break;
                        case 25:
                            prefabIndexin5place = 9;
                            break;
                        case 26:
                            prefabIndexin5place = 10;
                            break;
                        case 28:
                            prefabIndexin5place = 11;
                            break;
                        case 30:
                            prefabIndexin5place = 12;
                            break;
                        case 34:
                            prefabIndexin5place = 13;
                            break;
                        case 36:
                            prefabIndexin5place = 14;
                            break;
                        case 37:
                            prefabIndexin5place = 15;
                            break;
                        case 38:
                            prefabIndexin5place = 16;
                            break;
                        case 39:
                            prefabIndexin5place = 17;
                            break;
                        case 40:
                            prefabIndexin5place = 18;
                            break;
                        case 42:
                            prefabIndexin5place = 19;
                            break;
                    }
                }
                foreach (Transform child in slotsEnemy.slo5.transform)
                {
                    Destroy(child.gameObject);
                }
                skreader.slot5targetVr1 = null;
                skreader.slot5targetVr2 = null;
                skreader.slot5targetVr3 = null;
                switch (prefabIndexin5place)
                {
                    case 0:
                        skreader.slot5skillVraga = 1;
                        if (skil1Vraga == null)
                        {
                            skil1Vraga = Instantiate(skills5place[prefabIndexin5place], slotsEnemy.slo5.transform.position, Quaternion.identity, slotsEnemy.slo5.transform) as GameObject; // спавн
                        }
                        skreader.slot5targetVr1 = skreader.slotGG2;
                        skreader.slot5targetVr2 = null;
                        skreader.slot5targetVr3 = null;
                        break;
                    case 1:
                        skreader.slot5skillVraga = 2;
                        if (skil2Vraga == null)
                        {
                            skil2Vraga = Instantiate(skills5place[prefabIndexin5place], slotsEnemy.slo5.transform.position, Quaternion.identity, slotsEnemy.slo5.transform) as GameObject; // спавн
                        }
                        skreader.slot5targetVr1 = skreader.slotGG5;
                        skreader.slot5targetVr2 = null;
                        skreader.slot5targetVr3 = null;
                        break;
                    case 2:
                        skreader.slot5skillVraga = 3;
                        if (skil3Vraga == null)
                        {
                            skil3Vraga = Instantiate(skills5place[prefabIndexin5place], slotsEnemy.slo5.transform.position, Quaternion.identity, slotsEnemy.slo5.transform) as GameObject; // спавн
                        }
                        skreader.slot5targetVr1 = skreader.slotGG8;
                        skreader.slot5targetVr2 = null;
                        skreader.slot5targetVr3 = null;
                        break;
                    case 3:
                        skreader.slot5skillVraga = 5;
                        if (skil5Vraga == null)
                        {
                            skil5Vraga = Instantiate(skills5place[prefabIndexin5place], slotsEnemy.slo5.transform.position, Quaternion.identity, slotsEnemy.slo5.transform) as GameObject; // спавн
                        }
                        // тут рандомится цель
                        int targettt = Random.Range(1, 4);
                        switch (targettt)
                        {
                            case 1:
                                skreader.slot5targetVr1 = skreader.slotVraga1;
                                break;
                            case 2:
                                skreader.slot5targetVr1 = skreader.slotVraga2;
                                break;
                            case 3:
                                skreader.slot5targetVr1 = skreader.slotVraga3;
                                break;
                            case 4:
                                skreader.slot5targetVr1 = skreader.slotVraga4;
                                break;
                        }
                        skreader.slot5targetVr2 = null;
                        skreader.slot5targetVr3 = null;
                        break;
                    case 4:
                        skreader.slot5skillVraga = 11;
                        if (skil11Vraga == null)
                        {
                            skil11Vraga = Instantiate(skills5place[prefabIndexin5place], slotsEnemy.slo5.transform.position, Quaternion.identity, slotsEnemy.slo5.transform) as GameObject; // спавн
                        }
                        skreader.slot5targetVr1 = skreader.slotVraga8;
                        skreader.slot5targetVr2 = null;
                        skreader.slot5targetVr3 = null;
                        break;
                    case 5:
                        skreader.slot5skillVraga = 12;
                        if (skil12Vraga == null)
                        {
                            skil12Vraga = Instantiate(skills5place[prefabIndexin5place], slotsEnemy.slo5.transform.position, Quaternion.identity, slotsEnemy.slo5.transform) as GameObject; // спавн
                        }
                        switch (Random.Range(0, 4))
                        {
                            case 1:
                                skreader.slot5targetVr1 = skreader.slotVraga8;
                                break;
                            case 2:
                                skreader.slot5targetVr1 = skreader.slotVraga6;
                                break;
                            case 3:
                                skreader.slot5targetVr1 = skreader.slotVraga7;
                                break;
                            default:
                                skreader.slot5targetVr1 = skreader.slotVraga9;
                                break;
                        }
                        skreader.slot5targetVr2 = null;
                        skreader.slot5targetVr3 = null;
                        break;
                    case 6:
                        skreader.slot5skillVraga = 15;
                        if (skil15Vraga == null)
                        {
                            skil15Vraga = Instantiate(skills5place[prefabIndexin5place], slotsEnemy.slo5.transform.position, Quaternion.identity, slotsEnemy.slo5.transform) as GameObject; // спавн
                        }
                        skreader.slot5targetVr1 = skreader.slotGG5;
                        skreader.slot5targetVr2 = null;
                        skreader.slot5targetVr3 = null;
                        break;
                    case 7:
                        skreader.slot5skillVraga = 19;
                        if (skil19Vraga == null)
                        {
                            skil19Vraga = Instantiate(skills5place[prefabIndexin5place], slotsEnemy.slo5.transform.position, Quaternion.identity, slotsEnemy.slo5.transform) as GameObject; // спавн
                        }
                        switch (Random.Range(0, 3))
                        {
                            case 1:
                                skreader.slot5targetVr1 = skreader.slotGG2;
                                break;
                            case 2:
                                skreader.slot5targetVr1 = skreader.slotGG5;
                                break;
                            default:
                                skreader.slot5targetVr1 = skreader.slotGG8;
                                break;
                        }
                        skreader.slot5targetVr2 = null;
                        skreader.slot5targetVr3 = null;
                        break;
                    case 8:
                        skreader.slot5skillVraga = 22;
                        if (skil22Vraga == null)
                        {
                            skil22Vraga = Instantiate(skills5place[prefabIndexin5place], slotsEnemy.slo5.transform.position, Quaternion.identity, slotsEnemy.slo5.transform) as GameObject; // спавн
                        }
                        skreader.slot5targetVr1 = skreader.slotGG5;
                        skreader.slot5targetVr2 = null;
                        skreader.slot5targetVr3 = null;
                        break;
                    case 9:
                        skreader.slot5skillVraga = 25;
                        if (skil25Vraga == null)
                        {
                            skil25Vraga = Instantiate(skills5place[prefabIndexin5place], slotsEnemy.slo5.transform.position, Quaternion.identity, slotsEnemy.slo5.transform) as GameObject; // спавн
                        }
                        switch (Random.Range(0, 4))
                        {
                            case 1:
                                skreader.slot5targetVr1 = skreader.slotVraga1;
                                break;
                            case 2:
                                skreader.slot5targetVr1 = skreader.slotVraga3;
                                break;
                            case 3:
                                skreader.slot5targetVr1 = skreader.slotVraga7;
                                break;
                            default:
                                skreader.slot5targetVr1 = skreader.slotVraga9;
                                break;
                        }
                        skreader.slot5targetVr2 = null;
                        skreader.slot5targetVr3 = null;
                        break;
                    case 10:
                        skreader.slot5skillVraga = 26;
                        if (skil26Vraga == null)
                        {
                            skil26Vraga = Instantiate(skills5place[prefabIndexin5place], slotsEnemy.slo5.transform.position, Quaternion.identity, slotsEnemy.slo5.transform) as GameObject; // спавн
                        }
                        switch (Random.Range(0, 4))
                        {
                            case 1:
                                skreader.slot5targetVr1 = skreader.slotVraga2;
                                break;
                            case 2:
                                skreader.slot5targetVr1 = skreader.slotVraga4;
                                break;
                            case 3:
                                skreader.slot5targetVr1 = skreader.slotVraga6;
                                break;
                            default:
                                skreader.slot5targetVr1 = skreader.slotVraga8;
                                break;
                        }
                        skreader.slot5targetVr2 = null;
                        skreader.slot5targetVr3 = null;
                        break;
                    case 11:
                        skreader.slot5skillVraga = 28;
                        if (skil28Vraga == null)
                        {
                            skil28Vraga = Instantiate(skills5place[prefabIndexin5place], slotsEnemy.slo5.transform.position, Quaternion.identity, slotsEnemy.slo5.transform) as GameObject; // спавн
                        }
                        skreader.slot5targetVr1 = skreader.slotGG5;
                        skreader.slot5targetVr2 = null;
                        skreader.slot5targetVr3 = null;
                        break;
                    case 12:
                        skreader.slot5skillVraga = 30;
                        if (skil30Vraga == null)
                        {
                            skil30Vraga = Instantiate(skills5place[prefabIndexin5place], slotsEnemy.slo5.transform.position, Quaternion.identity, slotsEnemy.slo5.transform) as GameObject; // спавн
                        }
                        skreader.slot5targetVr1 = skreader.slotGG2;
                        skreader.slot5targetVr2 = skreader.slotGG5;
                        skreader.slot5targetVr3 = skreader.slotGG8;
                        break;
                    case 13:
                        skreader.slot5skillVraga = 34;
                        if (skil34Vraga == null)
                        {
                            skil34Vraga = Instantiate(skills5place[prefabIndexin5place], slotsEnemy.slo5.transform.position, Quaternion.identity, slotsEnemy.slo5.transform) as GameObject; // спавн
                        }
                        switch (Random.Range(0, 3))
                        {
                            case 1:
                                skreader.slot5targetVr1 = skreader.slotGG1;
                                skreader.slot5targetVr2 = skreader.slotGG2;
                                skreader.slot5targetVr3 = skreader.slotGG3;
                                break;
                            case 2:
                                skreader.slot5targetVr1 = skreader.slotGG4;
                                skreader.slot5targetVr2 = skreader.slotGG5;
                                skreader.slot5targetVr3 = skreader.slotGG6;
                                break;
                            default:
                                skreader.slot5targetVr1 = skreader.slotGG7;
                                skreader.slot5targetVr2 = skreader.slotGG8;
                                skreader.slot5targetVr3 = skreader.slotGG9;
                                break;
                        }
                        break;
                    case 14:
                        skreader.slot5skillVraga = 36;
                        if (skil36Vraga == null)
                        {
                            skil36Vraga = Instantiate(skills5place[prefabIndexin5place], slotsEnemy.slo5.transform.position, Quaternion.identity, slotsEnemy.slo5.transform) as GameObject; // спавн
                        }
                        skreader.slot5targetVr1 = skreader.slotVraga4;
                        skreader.slot5targetVr2 = skreader.slotVraga5;
                        skreader.slot5targetVr3 = skreader.slotVraga6;
                        break;
                    case 15:
                        skreader.slot5skillVraga = 37;
                        if (skil37Vraga == null)
                        {
                            skil37Vraga = Instantiate(skills5place[prefabIndexin5place], slotsEnemy.slo5.transform.position, Quaternion.identity, slotsEnemy.slo5.transform) as GameObject; // спавн
                        }
                        switch (Random.Range(0, 3))
                        {
                            case 1:
                                skreader.slot5targetVr1 = skreader.slotGG1;
                                break;
                            case 2:
                                skreader.slot5targetVr1 = skreader.slotGG2;
                                break;
                            default:
                                skreader.slot5targetVr1 = skreader.slotGG3;
                                break;
                        }
                        switch (Random.Range(0, 3))
                        {
                            case 1:
                                skreader.slot5targetVr2 = skreader.slotGG4;
                                break;
                            case 2:
                                skreader.slot5targetVr2 = skreader.slotGG5;
                                break;
                            default:
                                skreader.slot5targetVr2 = skreader.slotGG6;
                                break;
                        }
                        switch (Random.Range(0, 3))
                        {
                            case 1:
                                skreader.slot5targetVr3 = skreader.slotGG7;
                                break;
                            case 2:
                                skreader.slot5targetVr3 = skreader.slotGG8;
                                break;
                            default:
                                skreader.slot5targetVr3 = skreader.slotGG9;
                                break;
                        }
                        break;
                    case 16:
                        skreader.slot5skillVraga = 38;
                        if (skil38Vraga == null)
                        {
                            skil38Vraga = Instantiate(skills5place[prefabIndexin5place], slotsEnemy.slo5.transform.position, Quaternion.identity, slotsEnemy.slo5.transform) as GameObject; // спавн
                        }
                        switch (Random.Range(0, 3))
                        {
                            case 1:
                                skreader.slot5targetVr1 = skreader.slotGG2;
                                break;
                            case 2:
                                skreader.slot5targetVr1 = skreader.slotGG5;
                                break;
                            default:
                                skreader.slot5targetVr1 = skreader.slotGG8;
                                break;
                        }
                        skreader.slot5targetVr2 = null;
                        skreader.slot5targetVr3 = null;
                        break;
                    case 17:
                        skreader.slot5skillVraga = 39;
                        if (skil39Vraga == null)
                        {
                            skil39Vraga = Instantiate(skills5place[prefabIndexin5place], slotsEnemy.slo5.transform.position, Quaternion.identity, slotsEnemy.slo5.transform) as GameObject; // спавн
                        }
                        switch (Random.Range(0, 4))
                        {
                            case 1:
                                skreader.slot5targetVr1 = skreader.slotVraga1;
                                break;
                            case 2:
                                skreader.slot5targetVr1 = skreader.slotVraga2;
                                break;
                            case 3:
                                skreader.slot5targetVr1 = skreader.slotVraga3;
                                break;
                            default:
                                skreader.slot5targetVr1 = skreader.slotVraga4;
                                break;
                        }
                        switch (Random.Range(0, 4))
                        {
                            case 1:
                                skreader.slot5targetVr2 = skreader.slotVraga6;
                                break;
                            case 2:
                                skreader.slot5targetVr2 = skreader.slotVraga7;
                                break;
                            case 3:
                                skreader.slot5targetVr2 = skreader.slotVraga8;
                                break;
                            default:
                                skreader.slot5targetVr2 = skreader.slotVraga9;
                                break;
                        }
                        skreader.slot5targetVr3 = null;
                        break;
                    case 18:
                        skreader.slot5skillVraga = 40;
                        if (skil40Vraga == null)
                        {
                            skil40Vraga = Instantiate(skills5place[prefabIndexin5place], slotsEnemy.slo5.transform.position, Quaternion.identity, slotsEnemy.slo5.transform) as GameObject; // спавн
                        }
                        switch (Random.Range(0, 5))
                        {
                            case 1:
                                skreader.slot5targetVr1 = skreader.slotGG1;
                                break;
                            case 2:
                                skreader.slot5targetVr1 = skreader.slotGG2;
                                break;
                            case 3:
                                skreader.slot5targetVr1 = skreader.slotGG3;
                                break;
                            case 4:
                                skreader.slot5targetVr1 = skreader.slotGG4;
                                break;
                            default:
                                skreader.slot5targetVr1 = skreader.slotGG5;
                                break;
                        }
                        switch (Random.Range(0, 4))
                        {
                            case 1:
                                skreader.slot5targetVr2 = skreader.slotGG6;
                                break;
                            case 2:
                                skreader.slot5targetVr2 = skreader.slotGG7;
                                break;
                            case 3:
                                skreader.slot5targetVr2 = skreader.slotGG8;
                                break;
                            default:
                                skreader.slot5targetVr2 = skreader.slotGG9;
                                break;
                        }
                        skreader.slot5targetVr3 = null;
                        break;
                    case 19:
                        skreader.slot5skillVraga = 42;
                        if (skil42Vraga == null)
                        {
                            skil42Vraga = Instantiate(skills5place[prefabIndexin5place], slotsEnemy.slo5.transform.position, Quaternion.identity, slotsEnemy.slo5.transform) as GameObject; // спавн
                        }
                        skreader.slot5targetVr1 = skreader.slotVraga4;
                        skreader.slot5targetVr2 = null;
                        skreader.slot5targetVr3 = null;
                        break;


                    default: // промах
                        skreader.slot5skillVraga = 0;
                        readalready5 = true;
                        skreader.slot5targetVr1 = null;
                        skreader.slot5targetVr2 = null;
                        skreader.slot5targetVr3 = null;
                        break;
                }
                if (skreader.slot5skillVraga != skreader.slot1skillVraga && skreader.slot5skillVraga != skreader.slot2skillVraga && skreader.slot5skillVraga != skreader.slot3skillVraga && skreader.slot5skillVraga != skreader.slot4skillVraga)
                {
                    readalready5 = true;
                }

            }
            // 6 слот
            if (readalready5 && readalready6 == false)
            {


                if (skil29Vraga == null) // если плавники не заблочили эту клетушку, спавним нормально
                {
                    if (distancePoints.distance < 5500) // биом 1
                    {
                        prefabIndexin6place = Random.Range(0, 5);
                    }
                    else if (distancePoints.distance >= 5500 && distancePoints.distance < 6500)
                    {
                        prefabIndexin6place = Random.Range(0, 10);
                    }
                    else if (distancePoints.distance >= 6500 && distancePoints.distance < 10500)
                    {
                        prefabIndexin6place = Random.Range(5, 15);
                    }
                    else if (distancePoints.distance > 10500)
                    {
                        prefabIndexin6place = Random.Range(5, 19); // максимальный диапазон
                    }

                    if (enemySpawner.bMarius == true || enemySpawner.bGren || enemySpawner.bKridei || enemySpawner.bRago)
                    {
                        prefabIndexin6place = 100;
                    }
                    else if (enemySpawner.bPareed == true)
                    {
                        prefabIndexin6place = Random.Range(0, 18);
                    }
                    else if (enemySpawner.bTheus == true)
                    {
                        switch (batol.fortheus6)
                        {
                            case 0: // значение навыка
                                prefabIndexin6place = 100;
                                break;
                            case 5:
                                prefabIndexin6place = 0;
                                break;
                            case 6:
                                prefabIndexin6place = 1;
                                break;
                            case 7:
                                prefabIndexin6place = 2;
                                break;
                            case 8:
                                prefabIndexin6place = 3;
                                break;
                            case 10:
                                prefabIndexin6place = 4;
                                break;
                            case 12:
                                prefabIndexin6place = 5;
                                break;
                            case 13:
                                prefabIndexin6place = 6;
                                break;
                            case 15:
                                prefabIndexin6place = 7;
                                break;
                            case 19:
                                prefabIndexin6place = 8;
                                break;
                            case 20:
                                prefabIndexin6place = 9;
                                break;
                            case 21:
                                prefabIndexin6place = 10;
                                break;
                            case 28:
                                prefabIndexin6place = 11;
                                break;
                            case 30:
                                prefabIndexin6place = 13;
                                break;
                            case 34:
                                prefabIndexin6place = 14;
                                break;
                            case 38:
                                prefabIndexin6place = 15;
                                break;
                            case 40:
                                prefabIndexin6place = 16;
                                break;
                            case 41:
                                prefabIndexin6place = 17;
                                break;
                            case 42:
                                prefabIndexin6place = 18;
                                break;
                        }
                    }

                }
                else // спавним блочик
                {
                    prefabIndexin6place = 12;
                }




                foreach (Transform child in slotsEnemy.slo6.transform)
                {
                    Destroy(child.gameObject);
                }
                skreader.slot6targetVr1 = null;
                skreader.slot6targetVr2 = null;
                skreader.slot6targetVr3 = null;
                switch (prefabIndexin6place)
                {
                    case 0:
                        skreader.slot6skillVraga = 5;
                        if (skil5Vraga == null)
                        {
                            skil5Vraga = Instantiate(skills6place[prefabIndexin6place], slotsEnemy.slo6.transform.position, Quaternion.identity, slotsEnemy.slo6.transform) as GameObject; // спавн
                        }
                        // тут рандомится цель
                        int targettt = Random.Range(1, 5);
                        switch (targettt)
                        {
                            case 1:
                                skreader.slot6targetVr1 = skreader.slotVraga1;
                                break;
                            case 2:
                                skreader.slot6targetVr1 = skreader.slotVraga2;
                                break;
                            case 3:
                                skreader.slot6targetVr1 = skreader.slotVraga3;
                                break;
                            case 4:
                                skreader.slot6targetVr1 = skreader.slotVraga4;
                                break;
                            case 5:
                                skreader.slot6targetVr1 = skreader.slotVraga5;
                                break;
                        }
                        skreader.slot6targetVr2 = null;
                        skreader.slot6targetVr3 = null;
                        break;
                    case 1:
                        skreader.slot6skillVraga = 6;
                        if (skil6Vraga == null)
                        {
                            skil6Vraga = Instantiate(skills6place[prefabIndexin6place], slotsEnemy.slo6.transform.position, Quaternion.identity, slotsEnemy.slo6.transform) as GameObject; // спавн
                        }
                        skreader.slot6targetVr1 = skreader.slotVraga3;
                        skreader.slot6targetVr2 = null;
                        skreader.slot6targetVr3 = null;
                        break;
                    case 2:
                        skreader.slot6skillVraga = 7;
                        if (skil7Vraga == null)
                        {
                            skil7Vraga = Instantiate(skills6place[prefabIndexin6place], slotsEnemy.slo6.transform.position, Quaternion.identity, slotsEnemy.slo6.transform) as GameObject; // спавн
                        }
                        skreader.slot6targetVr1 = skreader.slotVraga3;
                        skreader.slot6targetVr2 = null;
                        skreader.slot6targetVr3 = null;
                        break;
                    case 3:
                        skreader.slot6skillVraga = 8;
                        if (skil8Vraga == null)
                        {
                            skil8Vraga = Instantiate(skills6place[prefabIndexin6place], slotsEnemy.slo6.transform.position, Quaternion.identity, slotsEnemy.slo6.transform) as GameObject; // спавн
                        }
                        skreader.slot6targetVr1 = skreader.slotVraga3;
                        skreader.slot6targetVr2 = null;
                        skreader.slot6targetVr3 = null;
                        break;
                    case 4:
                        skreader.slot6skillVraga = 10;
                        if (skil10Vraga == null)
                        {
                            skil10Vraga = Instantiate(skills6place[prefabIndexin6place], slotsEnemy.slo6.transform.position, Quaternion.identity, slotsEnemy.slo6.transform) as GameObject; // спавн
                        }
                        skreader.slot6targetVr1 = skreader.slotVraga9;
                        skreader.slot6targetVr2 = null;
                        skreader.slot6targetVr3 = null;
                        break;
                    case 5:
                        skreader.slot6skillVraga = 12;
                        if (skil12Vraga == null)
                        {
                            skil12Vraga = Instantiate(skills6place[prefabIndexin6place], slotsEnemy.slo6.transform.position, Quaternion.identity, slotsEnemy.slo6.transform) as GameObject; // спавн
                        }
                        switch (Random.Range(0, 4))
                        {
                            case 1:
                                skreader.slot6targetVr1 = skreader.slotVraga8;
                                break;
                            case 2:
                                skreader.slot6targetVr1 = skreader.slotVraga6;
                                break;
                            case 3:
                                skreader.slot6targetVr1 = skreader.slotVraga7;
                                break;
                            default:
                                skreader.slot6targetVr1 = skreader.slotVraga9;
                                break;
                        }
                        skreader.slot6targetVr2 = null;
                        skreader.slot6targetVr3 = null;
                        break;
                    case 6:
                        skreader.slot6skillVraga = 13;
                        if (skil13Vraga == null)
                        {
                            skil13Vraga = Instantiate(skills6place[prefabIndexin6place], slotsEnemy.slo6.transform.position, Quaternion.identity, slotsEnemy.slo6.transform) as GameObject; // спавн
                        }
                        switch (Random.Range(0, 3))
                        {
                            case 1:
                                skreader.slot6targetVr1 = skreader.slotGG3;
                                break;
                            case 2:
                                skreader.slot6targetVr1 = skreader.slotGG6;
                                break;
                            default:
                                skreader.slot6targetVr1 = skreader.slotGG9;
                                break;
                        }
                        skreader.slot6targetVr2 = null;
                        skreader.slot6targetVr3 = null;
                        break;
                    case 7:
                        skreader.slot6skillVraga = 15;
                        if (skil15Vraga == null)
                        {
                            skil15Vraga = Instantiate(skills6place[prefabIndexin6place], slotsEnemy.slo6.transform.position, Quaternion.identity, slotsEnemy.slo6.transform) as GameObject; // спавн
                        }
                        skreader.slot6targetVr1 = skreader.slotGG6;
                        skreader.slot6targetVr2 = null;
                        skreader.slot6targetVr3 = null;
                        break;
                    case 8:
                        skreader.slot6skillVraga = 19;
                        if (skil19Vraga == null)
                        {
                            skil19Vraga = Instantiate(skills6place[prefabIndexin6place], slotsEnemy.slo6.transform.position, Quaternion.identity, slotsEnemy.slo6.transform) as GameObject; // спавн
                        }
                        switch (Random.Range(0, 3))
                        {
                            case 1:
                                skreader.slot6targetVr1 = skreader.slotGG3;
                                break;
                            case 2:
                                skreader.slot6targetVr1 = skreader.slotGG6;
                                break;
                            default:
                                skreader.slot6targetVr1 = skreader.slotGG9;
                                break;
                        }
                        skreader.slot6targetVr2 = null;
                        skreader.slot6targetVr3 = null;
                        break;
                    case 9:
                        skreader.slot6skillVraga = 20;
                        if (skil20Vraga == null)
                        {
                            skil20Vraga = Instantiate(skills6place[prefabIndexin6place], slotsEnemy.slo6.transform.position, Quaternion.identity, slotsEnemy.slo6.transform) as GameObject; // спавн
                        }
                        skreader.slot6targetVr1 = null;
                        skreader.slot6targetVr2 = null;
                        skreader.slot6targetVr3 = null;
                        break;
                    case 10:
                        skreader.slot6skillVraga = 21;
                        if (skil21Vraga == null)
                        {
                            skil21Vraga = Instantiate(skills6place[prefabIndexin6place], slotsEnemy.slo6.transform.position, Quaternion.identity, slotsEnemy.slo6.transform) as GameObject; // спавн
                        }
                        skreader.slot6targetVr1 = skreader.slotVraga6;
                        skreader.slot6targetVr2 = skreader.slotGG6;
                        skreader.slot6targetVr3 = null;
                        break;
                    case 11:
                        skreader.slot6skillVraga = 28;
                        if (skil28Vraga == null)
                        {
                            skil28Vraga = Instantiate(skills6place[prefabIndexin6place], slotsEnemy.slo6.transform.position, Quaternion.identity, slotsEnemy.slo6.transform) as GameObject; // спавн
                        }
                        skreader.slot6targetVr1 = skreader.slotGG6;
                        skreader.slot6targetVr2 = null;
                        skreader.slot6targetVr3 = null;
                        break;
                    case 12:
                        if (skil29Vraga != null) // если этот скилл уже был заспавнен на 4 слот
                        {
                            skreader.slot6skillVraga = 0;
                            foreach (Transform child in slotsEnemy.slo6.transform)
                            {
                                Destroy(child.gameObject);
                            }
                            Instantiate(skil29VragaShadow, slotsEnemy.slo6.transform.position, Quaternion.identity, slotsEnemy.slo6.transform); // спавн
                            skreader.slot6targetVr1 = null;
                            skreader.slot6targetVr2 = null;
                            skreader.slot6targetVr3 = null;
                        }
                        else if (skil29Vraga == null) // если он сейчас спавнится впервые
                        {
                            skreader.slot6skillVraga = 29;
                            skil29Vraga = Instantiate(skills6place[prefabIndexin6place], slotsEnemy.slo6.transform.position, Quaternion.identity, slotsEnemy.slo6.transform) as GameObject; // спавн
                            skreader.slot6targetVr1 = skreader.slotVraga7;
                            skreader.slot6targetVr2 = skreader.slotVraga8;
                            skreader.slot6targetVr3 = skreader.slotVraga9;
                            // чистит 4 слот
                            skreader.slot4skillVraga = 0;
                            skreader.slot4targetVr1 = null;
                            skreader.slot4targetVr2 = null;
                            skreader.slot4targetVr3 = null;
                            foreach (Transform child in slotsEnemy.slo4.transform)
                            {
                                Destroy(child.gameObject);
                            }
                            Instantiate(skil29VragaShadow, slotsEnemy.slo4.transform.position, Quaternion.identity, slotsEnemy.slo4.transform); // спавн
                        }
                        break;
                    case 13:
                        skreader.slot6skillVraga = 30;
                        if (skil30Vraga == null)
                        {
                            skil30Vraga = Instantiate(skills6place[prefabIndexin6place], slotsEnemy.slo6.transform.position, Quaternion.identity, slotsEnemy.slo6.transform) as GameObject; // спавн
                        }
                        skreader.slot6targetVr1 = skreader.slotGG3;
                        skreader.slot6targetVr2 = skreader.slotGG6;
                        skreader.slot6targetVr3 = skreader.slotGG9;
                        break;
                    case 14:
                        skreader.slot6skillVraga = 34;
                        if (skil34Vraga == null)
                        {
                            skil34Vraga = Instantiate(skills6place[prefabIndexin6place], slotsEnemy.slo6.transform.position, Quaternion.identity, slotsEnemy.slo6.transform) as GameObject; // спавн
                        }
                        switch (Random.Range(0, 3))
                        {
                            case 1:
                                skreader.slot6targetVr1 = skreader.slotGG1;
                                skreader.slot6targetVr2 = skreader.slotGG2;
                                skreader.slot6targetVr3 = skreader.slotGG3;
                                break;
                            case 2:
                                skreader.slot6targetVr1 = skreader.slotGG4;
                                skreader.slot6targetVr2 = skreader.slotGG5;
                                skreader.slot6targetVr3 = skreader.slotGG6;
                                break;
                            default:
                                skreader.slot6targetVr1 = skreader.slotGG7;
                                skreader.slot6targetVr2 = skreader.slotGG8;
                                skreader.slot6targetVr3 = skreader.slotGG9;
                                break;
                        }
                        break;
                    case 15:
                        skreader.slot6skillVraga = 38;
                        if (skil38Vraga == null)
                        {
                            skil38Vraga = Instantiate(skills6place[prefabIndexin6place], slotsEnemy.slo6.transform.position, Quaternion.identity, slotsEnemy.slo6.transform) as GameObject; // спавн
                        }
                        switch (Random.Range(0, 3))
                        {
                            case 1:
                                skreader.slot6targetVr1 = skreader.slotGG3;
                                break;
                            case 2:
                                skreader.slot6targetVr1 = skreader.slotGG6;
                                break;
                            default:
                                skreader.slot6targetVr1 = skreader.slotGG9;
                                break;
                        }
                        skreader.slot6targetVr2 = null;
                        skreader.slot6targetVr3 = null;
                        break;
                    case 16:
                        skreader.slot6skillVraga = 40;
                        if (skil40Vraga == null)
                        {
                            skil40Vraga = Instantiate(skills6place[prefabIndexin6place], slotsEnemy.slo6.transform.position, Quaternion.identity, slotsEnemy.slo6.transform) as GameObject; // спавн
                        }
                        switch (Random.Range(0, 5))
                        {
                            case 1:
                                skreader.slot6targetVr1 = skreader.slotGG1;
                                break;
                            case 2:
                                skreader.slot6targetVr1 = skreader.slotGG2;
                                break;
                            case 3:
                                skreader.slot6targetVr1 = skreader.slotGG3;
                                break;
                            case 4:
                                skreader.slot6targetVr1 = skreader.slotGG4;
                                break;
                            default:
                                skreader.slot6targetVr1 = skreader.slotGG5;
                                break;
                        }
                        switch (Random.Range(0, 4))
                        {
                            case 1:
                                skreader.slot6targetVr2 = skreader.slotGG6;
                                break;
                            case 2:
                                skreader.slot6targetVr2 = skreader.slotGG7;
                                break;
                            case 3:
                                skreader.slot6targetVr2 = skreader.slotGG8;
                                break;
                            default:
                                skreader.slot6targetVr2 = skreader.slotGG9;
                                break;
                        }
                        skreader.slot6targetVr3 = null;
                        break;
                    case 17:
                        skreader.slot6skillVraga = 41;
                        if (skil41Vraga == null)
                        {
                            skil41Vraga = Instantiate(skills6place[prefabIndexin6place], slotsEnemy.slo6.transform.position, Quaternion.identity, slotsEnemy.slo6.transform) as GameObject; // спавн
                        }
                        skreader.slot6targetVr1 = null;
                        skreader.slot6targetVr2 = null;
                        skreader.slot6targetVr3 = null;
                        break;
                    case 18:
                        skreader.slot6skillVraga = 42;
                        if (skil42Vraga == null)
                        {
                            skil42Vraga = Instantiate(skills6place[prefabIndexin6place], slotsEnemy.slo6.transform.position, Quaternion.identity, slotsEnemy.slo6.transform) as GameObject; // спавн
                        }
                        skreader.slot6targetVr1 = skreader.slotVraga5;
                        skreader.slot6targetVr2 = null;
                        skreader.slot6targetVr3 = null;
                        break;
                    default: // промах
                        skreader.slot6skillVraga = 0;
                        skreader.slot6targetVr1 = null;
                        skreader.slot6targetVr2 = null;
                        skreader.slot6targetVr3 = null;
                        readalready6 = true;
                        break;
                }
                
                if (skreader.slot6skillVraga != skreader.slot1skillVraga && skreader.slot6skillVraga != skreader.slot2skillVraga && skreader.slot6skillVraga != skreader.slot3skillVraga && skreader.slot6skillVraga != skreader.slot4skillVraga && skreader.slot6skillVraga != skreader.slot5skillVraga)
                {
                    readalready6 = true;
                }
                else if (skreader.slot6skillVraga == 0 && skreader.slot4skillVraga == 29) // даёт поблажку 0 на случай частички плавников
                {
                    readalready6 = true;
                }
            }
            // 7 слот
            if (readalready6 && readalready7 == false)
            {


                if (skreader.slot1skillVraga == 33) // спавним блочик
                {
                    prefabIndexin7place = 10;
                }
                else // если плавники не заблочили эту клетушку, спавним нормально
                {
                    if (distancePoints.distance < 5500) // биом 1
                    {
                        if (enemySpawner.bCirrat || enemySpawner.bNemin || enemySpawner.bAliss || enemySpawner.bPhiu || enemySpawner.bPhobel || enemySpawner.bPaster || enemySpawner.bPopmp || enemySpawner.bTopel || enemySpawner.bHeeth || enemySpawner.bPhanos || enemySpawner.bTheus || enemySpawner.bZem || enemySpawner.bAsce || enemySpawner.bKhirond || enemySpawner.bNerrelid) // если неагрессивный
                        {
                            prefabIndexin7place = Random.Range(-3, 5);
                        }
                        else
                        {
                            prefabIndexin7place = Random.Range(0, 5);
                        }
                    }
                    else if (distancePoints.distance >= 5500 && distancePoints.distance < 6500)
                    {
                        prefabIndexin7place = Random.Range(0, 10);
                    }
                    else if (distancePoints.distance >= 6500 && distancePoints.distance < 10500)
                    {
                        prefabIndexin7place = Random.Range(5, 15);
                    }
                    else if (distancePoints.distance > 10500)
                    {
                        prefabIndexin7place = Random.Range(5, 17); // максимальный диапазон
                    }

                    if (enemySpawner.bMarius == true)
                    {
                        prefabIndexin7place = 100;
                    }
                    else if (enemySpawner.bPareed == true)
                    {
                        prefabIndexin7place = Random.Range(1, 16);
                    }
                    else if (enemySpawner.bTheus == true)
                    {
                        switch (batol.fortheus7)
                        {
                            case 0: // значение навыка
                                prefabIndexin7place = 100;
                                break;
                            case 6:
                                prefabIndexin7place = 0;
                                break;
                            case 7:
                                prefabIndexin7place = 1;
                                break;
                            case 8:
                                prefabIndexin7place = 2;
                                break;
                            case 9:
                                prefabIndexin7place = 3;
                                break;
                            case 14:
                                prefabIndexin7place = 4;
                                break;
                            case 16:
                                prefabIndexin7place = 5;
                                break;
                            case 21:
                                prefabIndexin7place = 6;
                                break;
                            case 22:
                                prefabIndexin7place = 7;
                                break;
                            case 27:
                                prefabIndexin7place = 8;
                                break;
                            case 31:
                                prefabIndexin7place = 9;
                                break;
                            case 34:
                                prefabIndexin7place = 11;
                                break;
                            case 37:
                                prefabIndexin7place = 12;
                                break;
                            case 38:
                                prefabIndexin7place = 13;
                                break;
                            case 39:
                                prefabIndexin7place = 14;
                                break;
                            case 40:
                                prefabIndexin7place = 15;
                                break;
                            case 41:
                                prefabIndexin7place = 16;
                                break;
                        }
                    }


                }

                foreach (Transform child in slotsEnemy.slo7.transform)
                {
                    Destroy(child.gameObject);
                }
                skreader.slot7targetVr1 = null;
                skreader.slot7targetVr2 = null;
                skreader.slot7targetVr3 = null;
                switch (prefabIndexin7place)
                {
                    case 0:
                        skreader.slot7skillVraga = 6;
                        if (skil6Vraga == null)
                        {
                            skil6Vraga = Instantiate(skills7place[prefabIndexin7place], slotsEnemy.slo7.transform.position, Quaternion.identity, slotsEnemy.slo7.transform) as GameObject; // спавн
                        }
                        skreader.slot7targetVr1 = skreader.slotVraga4;
                        skreader.slot7targetVr2 = null;
                        skreader.slot7targetVr3 = null;
                        break;
                    case 1:
                        skreader.slot7skillVraga = 7;
                        if (skil7Vraga == null)
                        {
                            skil7Vraga = Instantiate(skills7place[prefabIndexin7place], slotsEnemy.slo7.transform.position, Quaternion.identity, slotsEnemy.slo7.transform) as GameObject; // спавн
                        }
                        skreader.slot7targetVr1 = skreader.slotVraga4;
                        skreader.slot7targetVr2 = null;
                        skreader.slot7targetVr3 = null;
                        break;
                    case 2:
                        skreader.slot7skillVraga = 8;
                        if (skil8Vraga == null)
                        {
                            skil8Vraga = Instantiate(skills7place[prefabIndexin7place], slotsEnemy.slo7.transform.position, Quaternion.identity, slotsEnemy.slo7.transform) as GameObject; // спавн
                        }
                        skreader.slot7targetVr1 = skreader.slotVraga4;
                        skreader.slot7targetVr2 = null;
                        skreader.slot7targetVr3 = null;
                        break;
                    case 3:
                        skreader.slot7skillVraga = 9;
                        if (skil9Vraga == null)
                        {
                            skil9Vraga = Instantiate(skills7place[prefabIndexin7place], slotsEnemy.slo7.transform.position, Quaternion.identity, slotsEnemy.slo7.transform) as GameObject; // спавн
                        }
                        skreader.slot7targetVr1 = skreader.slotGG7;
                        skreader.slot7targetVr2 = null;
                        skreader.slot7targetVr3 = null;
                        break;
                    case 4:
                        skreader.slot7skillVraga = 14;
                        if (skil14Vraga == null)
                        {
                            skil14Vraga = Instantiate(skills7place[prefabIndexin7place], slotsEnemy.slo7.transform.position, Quaternion.identity, slotsEnemy.slo7.transform) as GameObject; // спавн
                        }
                        switch (Random.Range(0, 3))
                        {
                            case 1:
                                skreader.slot7targetVr1 = skreader.slotGG1;
                                break;
                            case 2:
                                skreader.slot7targetVr1 = skreader.slotGG4;
                                break;
                            default:
                                skreader.slot7targetVr1 = skreader.slotGG7;
                                break;
                        }
                        skreader.slot7targetVr2 = null;
                        skreader.slot7targetVr3 = null;
                        break;
                    case 5:
                        skreader.slot7skillVraga = 16;
                        if (skil16Vraga == null)
                        {
                            skil16Vraga = Instantiate(skills7place[prefabIndexin7place], slotsEnemy.slo7.transform.position, Quaternion.identity, slotsEnemy.slo7.transform) as GameObject; // спавн
                        }
                        skreader.slot7targetVr1 = skreader.slotGG7;
                        switch (Random.Range(0, 2))
                        {
                            case 1:
                                skreader.slot7targetVr2 = skreader.slotGG8;
                                break;
                            default:
                                skreader.slot7targetVr2 = skreader.slotGG4;
                                break;
                        }
                        skreader.slot7targetVr3 = null;
                        break;
                    case 6:
                        skreader.slot7skillVraga = 21;
                        if (skil21Vraga == null)
                        {
                            skil21Vraga = Instantiate(skills7place[prefabIndexin7place], slotsEnemy.slo7.transform.position, Quaternion.identity, slotsEnemy.slo7.transform) as GameObject; // спавн
                        }
                        skreader.slot7targetVr1 = skreader.slotVraga7;
                        skreader.slot7targetVr2 = skreader.slotGG7;
                        skreader.slot7targetVr3 = null;
                        break;
                    case 7:
                        skreader.slot7skillVraga = 22;
                        if (skil22Vraga == null)
                        {
                            skil22Vraga = Instantiate(skills7place[prefabIndexin7place], slotsEnemy.slo7.transform.position, Quaternion.identity, slotsEnemy.slo7.transform) as GameObject; // спавн
                        }
                        skreader.slot7targetVr1 = skreader.slotGG7;
                        skreader.slot7targetVr2 = null;
                        skreader.slot7targetVr3 = null;
                        break;
                    case 8:
                        skreader.slot7skillVraga = 27;
                        if (skil27Vraga == null)
                        {
                            skil27Vraga = Instantiate(skills7place[prefabIndexin7place], slotsEnemy.slo7.transform.position, Quaternion.identity, slotsEnemy.slo7.transform) as GameObject; // спавн
                        }
                        skreader.slot7targetVr1 = skreader.slotGG4;
                        switch (Random.Range(0, 2))
                        {
                            case 1:
                                skreader.slot7targetVr2 = skreader.slotGG1;
                                break;
                            default:
                                skreader.slot7targetVr2 = skreader.slotGG7;
                                break;
                        }
                        skreader.slot7targetVr3 = null;
                        break;
                    case 9:
                        skreader.slot7skillVraga = 31;
                        if (skil31Vraga == null)
                        {
                            skil31Vraga = Instantiate(skills7place[prefabIndexin7place], slotsEnemy.slo7.transform.position, Quaternion.identity, slotsEnemy.slo7.transform) as GameObject; // спавн
                        }
                        switch (Random.Range(0, 3))
                        {
                            case 1:
                                skreader.slot7targetVr1 = skreader.slotGG1;
                                break;
                            case 2:
                                skreader.slot7targetVr1 = skreader.slotGG4;
                                break;
                            default:
                                skreader.slot7targetVr1 = skreader.slotGG7;
                                break;
                        }
                        skreader.slot7targetVr2 = null;
                        skreader.slot7targetVr3 = null;
                        break;
                    case 10:
                        if (skreader.slot1skillVraga == 33) // если этот скилл уже был заспавнен на 1 слот
                        {
                            skreader.slot7skillVraga = 0;
                            foreach (Transform child in slotsEnemy.slo7.transform)
                            {
                                Destroy(child.gameObject);
                            }
                            Instantiate(skil33VragaShadow, slotsEnemy.slo7.transform.position, Quaternion.identity, slotsEnemy.slo7.transform); // спавн
                            skreader.slot7targetVr1 = null;
                            skreader.slot7targetVr2 = null;
                            skreader.slot7targetVr3 = null;
                        }
                        else
                        {
                            skreader.slot7skillVraga = 33;
                            skil33Vraga = Instantiate(skills7place[prefabIndexin7place], slotsEnemy.slo7.transform.position, Quaternion.identity, slotsEnemy.slo7.transform) as GameObject; // спавн
                            switch (Random.Range(0, 5))
                            {
                                case 1:
                                    skreader.slot7targetVr1 = skreader.slotGG1;
                                    break;
                                case 2:
                                    skreader.slot7targetVr1 = skreader.slotGG2;
                                    break;
                                case 3:
                                    skreader.slot7targetVr1 = skreader.slotGG3;
                                    break;
                                case 4:
                                    skreader.slot7targetVr1 = skreader.slotGG4;
                                    break;
                                default:
                                    skreader.slot7targetVr1 = skreader.slotGG5;
                                    break;
                            }
                            switch (Random.Range(0, 4))
                            {
                                case 1:
                                    skreader.slot7targetVr2 = skreader.slotGG6;
                                    break;
                                case 2:
                                    skreader.slot7targetVr2 = skreader.slotGG7;
                                    break;
                                case 3:
                                    skreader.slot7targetVr2 = skreader.slotGG8;
                                    break;
                                default:
                                    skreader.slot7targetVr2 = skreader.slotGG9;
                                    break;
                            }
                            skreader.slot7targetVr3 = null;
                            // чистит 1 слот
                            skreader.slot1skillVraga = 0;
                            skreader.slot1targetVr1 = null;
                            skreader.slot1targetVr2 = null;
                            skreader.slot1targetVr3 = null;
                            foreach (Transform child in slotsEnemy.slo1.transform)
                            {
                                Destroy(child.gameObject);
                            }
                            Instantiate(skil33VragaShadow, slotsEnemy.slo1.transform.position, Quaternion.identity, slotsEnemy.slo1.transform); // спавн
                        }
                        break;
                    case 11:
                        skreader.slot7skillVraga = 34;
                        if (skil34Vraga == null)
                        {
                            skil34Vraga = Instantiate(skills7place[prefabIndexin7place], slotsEnemy.slo7.transform.position, Quaternion.identity, slotsEnemy.slo7.transform) as GameObject; // спавн
                        }
                        switch (Random.Range(0, 3))
                        {
                            case 1:
                                skreader.slot7targetVr1 = skreader.slotGG1;
                                skreader.slot7targetVr2 = skreader.slotGG2;
                                skreader.slot7targetVr3 = skreader.slotGG3;
                                break;
                            case 2:
                                skreader.slot7targetVr1 = skreader.slotGG4;
                                skreader.slot7targetVr2 = skreader.slotGG5;
                                skreader.slot7targetVr3 = skreader.slotGG6;
                                break;
                            default:
                                skreader.slot7targetVr1 = skreader.slotGG7;
                                skreader.slot7targetVr2 = skreader.slotGG8;
                                skreader.slot7targetVr3 = skreader.slotGG9;
                                break;
                        }
                        break;
                    case 12:
                        skreader.slot7skillVraga = 37;
                        if (skil37Vraga == null)
                        {
                            skil37Vraga = Instantiate(skills7place[prefabIndexin7place], slotsEnemy.slo7.transform.position, Quaternion.identity, slotsEnemy.slo7.transform) as GameObject; // спавн
                        }
                        switch (Random.Range(0, 3))
                        {
                            case 1:
                                skreader.slot7targetVr1 = skreader.slotGG1;
                                break;
                            case 2:
                                skreader.slot7targetVr1 = skreader.slotGG2;
                                break;
                            default:
                                skreader.slot7targetVr1 = skreader.slotGG3;
                                break;
                        }
                        switch (Random.Range(0, 3))
                        {
                            case 1:
                                skreader.slot7targetVr2 = skreader.slotGG4;
                                break;
                            case 2:
                                skreader.slot7targetVr2 = skreader.slotGG5;
                                break;
                            default:
                                skreader.slot7targetVr2 = skreader.slotGG6;
                                break;
                        }
                        switch (Random.Range(0, 3))
                        {
                            case 1:
                                skreader.slot7targetVr3 = skreader.slotGG7;
                                break;
                            case 2:
                                skreader.slot7targetVr3 = skreader.slotGG8;
                                break;
                            default:
                                skreader.slot7targetVr3 = skreader.slotGG9;
                                break;
                        }
                        break;
                    case 13:
                        skreader.slot7skillVraga = 38;
                        if (skil38Vraga == null)
                        {
                            skil38Vraga = Instantiate(skills7place[prefabIndexin7place], slotsEnemy.slo7.transform.position, Quaternion.identity, slotsEnemy.slo7.transform) as GameObject; // спавн
                        }
                        switch (Random.Range(0, 3))
                        {
                            case 1:
                                skreader.slot7targetVr1 = skreader.slotGG1;
                                break;
                            case 2:
                                skreader.slot7targetVr1 = skreader.slotGG4;
                                break;
                            default:
                                skreader.slot7targetVr1 = skreader.slotGG7;
                                break;
                        }
                        skreader.slot7targetVr2 = null;
                        skreader.slot7targetVr3 = null;
                        break;
                    case 14:
                        skreader.slot7skillVraga = 39;
                        if (skil39Vraga == null)
                        {
                            skil39Vraga = Instantiate(skills7place[prefabIndexin7place], slotsEnemy.slo7.transform.position, Quaternion.identity, slotsEnemy.slo7.transform) as GameObject; // спавн
                        }
                        switch (Random.Range(0, 2))
                        {
                            case 1:
                                skreader.slot7targetVr1 = skreader.slotVraga4;
                                break;
                            default:
                                skreader.slot7targetVr1 = skreader.slotVraga5;
                                break;
                        }
                        skreader.slot7targetVr2 = skreader.slotVraga8;
                        skreader.slot7targetVr3 = null;
                        break;
                    case 15:
                        skreader.slot7skillVraga = 40;
                        if (skil40Vraga == null)
                        {
                            skil40Vraga = Instantiate(skills7place[prefabIndexin7place], slotsEnemy.slo7.transform.position, Quaternion.identity, slotsEnemy.slo7.transform) as GameObject; // спавн
                        }
                        switch (Random.Range(0, 5))
                        {
                            case 1:
                                skreader.slot7targetVr1 = skreader.slotGG1;
                                break;
                            case 2:
                                skreader.slot7targetVr1 = skreader.slotGG2;
                                break;
                            case 3:
                                skreader.slot7targetVr1 = skreader.slotGG3;
                                break;
                            case 4:
                                skreader.slot7targetVr1 = skreader.slotGG4;
                                break;
                            default:
                                skreader.slot7targetVr1 = skreader.slotGG5;
                                break;
                        }
                        switch (Random.Range(0, 4))
                        {
                            case 1:
                                skreader.slot7targetVr2 = skreader.slotGG6;
                                break;
                            case 2:
                                skreader.slot7targetVr2 = skreader.slotGG7;
                                break;
                            case 3:
                                skreader.slot7targetVr2 = skreader.slotGG8;
                                break;
                            default:
                                skreader.slot7targetVr2 = skreader.slotGG9;
                                break;
                        }
                        skreader.slot7targetVr3 = null;
                        break;
                    case 16:
                        skreader.slot7skillVraga = 41;
                        if (skil41Vraga == null)
                        {
                            skil41Vraga = Instantiate(skills7place[prefabIndexin7place], slotsEnemy.slo7.transform.position, Quaternion.identity, slotsEnemy.slo7.transform) as GameObject; // спавн
                        }
                        skreader.slot7targetVr1 = null;
                        skreader.slot7targetVr2 = null;
                        skreader.slot7targetVr3 = null;
                        break;
                    default: // промах
                        skreader.slot7targetVr1 = null;
                        skreader.slot7targetVr2 = null;
                        skreader.slot7targetVr3 = null;
                        skreader.slot7skillVraga = 0;
                        readalready7 = true;
                        break;
                }
                if (skreader.slot7skillVraga != skreader.slot1skillVraga && skreader.slot7skillVraga != skreader.slot2skillVraga && skreader.slot7skillVraga != skreader.slot3skillVraga && skreader.slot7skillVraga != skreader.slot4skillVraga && skreader.slot7skillVraga != skreader.slot5skillVraga && skreader.slot7skillVraga != skreader.slot6skillVraga)
                {
                    readalready7 = true;
                }
                else if (skreader.slot7skillVraga == 0 && skreader.slot1skillVraga == 33) // даёт поблажку 0 на случай частички плавников
                {
                    readalready7 = true;
                }
                else if (skreader.slot7skillVraga == 33)
                {
                    foreach (Transform child in slotsEnemy.slo1.transform)
                    {
                        Destroy(child.gameObject);
                    }
                }
            }
            // 8 слот

            if (readalready7 && readalready8 == false)
            {
                if (skreader.slot2skillVraga == 33) // спавним блочик
                {
                    prefabIndexin8place = 10;
                }
                else // если плавники не заблочили эту клетушку, спавним нормально
                {
                    if (distancePoints.distance < 5500) // биом 1
                    {
                        if (enemySpawner.bCirrat || enemySpawner.bNemin || enemySpawner.bAliss || enemySpawner.bPhiu || enemySpawner.bPhobel || enemySpawner.bPaster || enemySpawner.bPopmp || enemySpawner.bTopel || enemySpawner.bHeeth || enemySpawner.bPhanos || enemySpawner.bTheus || enemySpawner.bZem || enemySpawner.bAsce || enemySpawner.bKhirond || enemySpawner.bNerrelid) // если неагрессивный
                        {
                            prefabIndexin8place = Random.Range(-3, 5);
                        }
                        else
                        {
                            prefabIndexin8place = Random.Range(0, 5);
                        }
                    }
                    else if (distancePoints.distance >= 5500 && distancePoints.distance < 6500)
                    {
                        prefabIndexin8place = Random.Range(0, 10);
                    }
                    else if (distancePoints.distance >= 6500 && distancePoints.distance < 10500)
                    {
                        prefabIndexin8place = Random.Range(5, 15);
                    }
                    else if (distancePoints.distance > 10500)
                    {
                        prefabIndexin8place = Random.Range(5, 18); // максимальный диапазон
                    }

                    if (enemySpawner.bMarius == true)
                    {
                        prefabIndexin8place = 100;
                    }
                    else if (enemySpawner.bPareed == true)
                    {
                        prefabIndexin8place = Random.Range(0, 17);
                    }
                    else if (enemySpawner.bSciph == true || enemySpawner.bTkhar == true)
                    {
                        if (skreader.slot6skillVraga != 41 && skreader.slot1skillVraga != 41 && skreader.slot2skillVraga != 41 && skreader.slot3skillVraga != 41 && skreader.slot4skillVraga != 41 && skreader.slot5skillVraga != 41 && skreader.slot7skillVraga != 41)
                        {
                            prefabIndexin8place = 16;
                        }
                    }
                    else if (enemySpawner.bTheus == true)
                    {
                        switch (batol.fortheus8)
                        {
                            case 0: // значение навыка
                                prefabIndexin8place = 100;
                                break;
                            case 6:
                                prefabIndexin8place = 0;
                                break;
                            case 7:
                                prefabIndexin8place = 1;
                                break;
                            case 8:
                                prefabIndexin8place = 2;
                                break;
                            case 9:
                                prefabIndexin8place = 3;
                                break;
                            case 16:
                                prefabIndexin8place = 4;
                                break;
                            case 22:
                                prefabIndexin8place = 5;
                                break;
                            case 23:
                                prefabIndexin8place = 6;
                                break;
                            case 24:
                                prefabIndexin8place = 7;
                                break;
                            case 31:
                                prefabIndexin8place = 8;
                                break;
                            case 32:
                                prefabIndexin8place = 9;
                                break;
                            case 36:
                                prefabIndexin8place = 11;
                                break;
                            case 37:
                                prefabIndexin8place = 12;
                                break;
                            case 38:
                                prefabIndexin8place = 13;
                                break;
                            case 39:
                                prefabIndexin8place = 14;
                                break;
                            case 40:
                                prefabIndexin8place = 15;
                                break;
                            case 41:
                                prefabIndexin8place = 16;
                                break;
                            case 42:
                                prefabIndexin8place = 17;
                                break;
                        }
                    }

                }

                foreach (Transform child in slotsEnemy.slo8.transform)
                {
                    Destroy(child.gameObject);
                }
                skreader.slot8targetVr1 = null;
                skreader.slot8targetVr2 = null;
                skreader.slot8targetVr3 = null;
                switch (prefabIndexin8place)
                {
                    case 0:
                        skreader.slot8skillVraga = 6;
                        if (skil6Vraga == null)
                        {
                            skil6Vraga = Instantiate(skills8place[prefabIndexin8place], slotsEnemy.slo8.transform.position, Quaternion.identity, slotsEnemy.slo8.transform) as GameObject; // спавн
                        }
                        skreader.slot8targetVr1 = skreader.slotVraga5;
                        skreader.slot8targetVr2 = null;
                        skreader.slot8targetVr3 = null;
                        break;
                    case 1:
                        skreader.slot8skillVraga = 7;
                        if (skil7Vraga == null)
                        {
                            skil7Vraga = Instantiate(skills8place[prefabIndexin8place], slotsEnemy.slo8.transform.position, Quaternion.identity, slotsEnemy.slo8.transform) as GameObject; // спавн
                        }
                        skreader.slot8targetVr1 = skreader.slotVraga5;
                        skreader.slot8targetVr2 = null;
                        skreader.slot8targetVr3 = null;
                        break;
                    case 2:
                        skreader.slot8skillVraga = 8;
                        if (skil8Vraga == null)
                        {
                            skil8Vraga = Instantiate(skills8place[prefabIndexin8place], slotsEnemy.slo8.transform.position, Quaternion.identity, slotsEnemy.slo8.transform) as GameObject; // спавн
                        }
                        skreader.slot8targetVr1 = skreader.slotVraga5;
                        skreader.slot8targetVr2 = null;
                        skreader.slot8targetVr3 = null;
                        break;
                    case 3:
                        skreader.slot8skillVraga = 9;
                        if (skil9Vraga == null)
                        {
                            skil9Vraga = Instantiate(skills8place[prefabIndexin8place], slotsEnemy.slo8.transform.position, Quaternion.identity, slotsEnemy.slo8.transform) as GameObject; // спавн
                        }
                        skreader.slot8targetVr1 = skreader.slotGG8;
                        skreader.slot8targetVr2 = null;
                        skreader.slot8targetVr3 = null;
                        break;
                    case 4:
                        skreader.slot8skillVraga = 16;
                        if (skil16Vraga == null)
                        {
                            skil16Vraga = Instantiate(skills8place[prefabIndexin8place], slotsEnemy.slo8.transform.position, Quaternion.identity, slotsEnemy.slo8.transform) as GameObject; // спавн
                        }
                        skreader.slot8targetVr1 = skreader.slotGG8;
                        switch (Random.Range(0, 3))
                        {
                            case 1:
                                skreader.slot8targetVr2 = skreader.slotGG5;
                                break;
                            case 2:
                                skreader.slot8targetVr2 = skreader.slotGG7;
                                break;
                            default:
                                skreader.slot8targetVr2 = skreader.slotGG9;
                                break;
                        }
                        skreader.slot8targetVr3 = null;
                        break;
                    case 5:
                        skreader.slot8skillVraga = 22;
                        if (skil22Vraga == null)
                        {
                            skil22Vraga = Instantiate(skills8place[prefabIndexin8place], slotsEnemy.slo8.transform.position, Quaternion.identity, slotsEnemy.slo8.transform) as GameObject; // спавн
                        }
                        skreader.slot8targetVr1 = skreader.slotGG8;
                        skreader.slot8targetVr2 = null;
                        skreader.slot8targetVr3 = null;
                        break;
                    case 6:
                        skreader.slot8skillVraga = 23;
                        if (skil23Vraga == null)
                        {
                            skil23Vraga = Instantiate(skills8place[prefabIndexin8place], slotsEnemy.slo8.transform.position, Quaternion.identity, slotsEnemy.slo8.transform) as GameObject; // спавн
                        }
                        skreader.slot8targetVr1 = skreader.slotGG7;
                        skreader.slot8targetVr2 = skreader.slotGG8;
                        skreader.slot8targetVr3 = skreader.slotGG9;
                        break;
                    case 7:
                        skreader.slot8skillVraga = 24;
                        if (skil24Vraga == null)
                        {
                            skil24Vraga = Instantiate(skills8place[prefabIndexin8place], slotsEnemy.slo8.transform.position, Quaternion.identity, slotsEnemy.slo8.transform) as GameObject; // спавн
                        }
                        skreader.slot8targetVr1 = skreader.slotGG2;
                        skreader.slot8targetVr2 = skreader.slotGG5;
                        skreader.slot8targetVr3 = skreader.slotGG8;
                        break;
                    case 8:
                        skreader.slot8skillVraga = 31;
                        if (skil31Vraga == null)
                        {
                            skil31Vraga = Instantiate(skills8place[prefabIndexin8place], slotsEnemy.slo8.transform.position, Quaternion.identity, slotsEnemy.slo8.transform) as GameObject; // спавн
                        }
                        switch (Random.Range(0, 3))
                        {
                            case 1:
                                skreader.slot8targetVr1 = skreader.slotGG2;
                                break;
                            case 2:
                                skreader.slot8targetVr1 = skreader.slotGG5;
                                break;
                            default:
                                skreader.slot8targetVr1 = skreader.slotGG8;
                                break;
                        }
                        skreader.slot8targetVr2 = null;
                        skreader.slot8targetVr3 = null;
                        break;
                    case 9:
                        skreader.slot8skillVraga = 32;
                        if (skil32Vraga == null)
                        {
                            skil32Vraga = Instantiate(skills8place[prefabIndexin8place], slotsEnemy.slo8.transform.position, Quaternion.identity, slotsEnemy.slo8.transform) as GameObject; // спавн
                        }
                        switch (Random.Range(0, 3))
                        {
                            case 1:
                                skreader.slot8targetVr1 = skreader.slotGG1;
                                break;
                            case 2:
                                skreader.slot8targetVr1 = skreader.slotGG2;
                                break;
                            default:
                                skreader.slot8targetVr1 = skreader.slotGG3;
                                break;
                        }
                        switch (Random.Range(0, 3))
                        {
                            case 1:
                                skreader.slot8targetVr2 = skreader.slotGG4;
                                break;
                            case 2:
                                skreader.slot8targetVr2 = skreader.slotGG5;
                                break;
                            default:
                                skreader.slot8targetVr2 = skreader.slotGG6;
                                break;
                        }
                        switch (Random.Range(0, 3))
                        {
                            case 1:
                                skreader.slot8targetVr3 = skreader.slotGG7;
                                break;
                            case 2:
                                skreader.slot8targetVr3 = skreader.slotGG8;
                                break;
                            default:
                                skreader.slot8targetVr3 = skreader.slotGG9;
                                break;
                        }
                        break;
                    case 10:
                        if (skreader.slot2skillVraga == 33) // если этот скилл уже был заспавнен на 2 слот
                        {
                            skreader.slot8skillVraga = 0;
                            foreach (Transform child in slotsEnemy.slo8.transform)
                            {
                                Destroy(child.gameObject);
                            }
                            Instantiate(skil33VragaShadow, slotsEnemy.slo8.transform.position, Quaternion.identity, slotsEnemy.slo8.transform); // спавн
                            skreader.slot8targetVr1 = null;
                            skreader.slot8targetVr2 = null;
                            skreader.slot8targetVr3 = null;
                        }
                        else
                        {
                            skreader.slot8skillVraga = 33;
                            skil33Vraga = Instantiate(skills8place[prefabIndexin8place], slotsEnemy.slo8.transform.position, Quaternion.identity, slotsEnemy.slo8.transform) as GameObject; // спавн
                            switch (Random.Range(0, 5))
                            {
                                case 1:
                                    skreader.slot8targetVr1 = skreader.slotGG1;
                                    break;
                                case 2:
                                    skreader.slot8targetVr1 = skreader.slotGG2;
                                    break;
                                case 3:
                                    skreader.slot8targetVr1 = skreader.slotGG3;
                                    break;
                                case 4:
                                    skreader.slot8targetVr1 = skreader.slotGG4;
                                    break;
                                default:
                                    skreader.slot8targetVr1 = skreader.slotGG5;
                                    break;
                            }
                            switch (Random.Range(0, 4))
                            {
                                case 1:
                                    skreader.slot8targetVr2 = skreader.slotGG6;
                                    break;
                                case 2:
                                    skreader.slot8targetVr2 = skreader.slotGG7;
                                    break;
                                case 3:
                                    skreader.slot8targetVr2 = skreader.slotGG8;
                                    break;
                                default:
                                    skreader.slot8targetVr2 = skreader.slotGG9;
                                    break;
                            }
                            skreader.slot8targetVr3 = null;
                            // чистит 2 слот
                            skreader.slot2skillVraga = 0;
                            skreader.slot2targetVr1 = null;
                            skreader.slot2targetVr2 = null;
                            skreader.slot2targetVr3 = null;
                            foreach (Transform child in slotsEnemy.slo2.transform)
                            {
                                Destroy(child.gameObject);
                            }
                            Instantiate(skil33VragaShadow, slotsEnemy.slo2.transform.position, Quaternion.identity, slotsEnemy.slo2.transform); // спавн
                        }
                        break;
                    case 11:
                        skreader.slot8skillVraga = 36;
                        if (skil36Vraga == null)
                        {
                            skil36Vraga = Instantiate(skills8place[prefabIndexin8place], slotsEnemy.slo8.transform.position, Quaternion.identity, slotsEnemy.slo8.transform) as GameObject; // спавн
                        }
                        skreader.slot8targetVr1 = skreader.slotVraga7;
                        skreader.slot8targetVr2 = skreader.slotVraga8;
                        skreader.slot8targetVr3 = skreader.slotVraga9;
                        break;
                    case 12:
                        skreader.slot8skillVraga = 37;
                        if (skil37Vraga == null)
                        {
                            skil37Vraga = Instantiate(skills8place[prefabIndexin8place], slotsEnemy.slo8.transform.position, Quaternion.identity, slotsEnemy.slo8.transform) as GameObject; // спавн
                        }
                        switch (Random.Range(0, 3))
                        {
                            case 1:
                                skreader.slot8targetVr1 = skreader.slotGG1;
                                break;
                            case 2:
                                skreader.slot8targetVr1 = skreader.slotGG2;
                                break;
                            default:
                                skreader.slot8targetVr1 = skreader.slotGG3;
                                break;
                        }
                        switch (Random.Range(0, 3))
                        {
                            case 1:
                                skreader.slot8targetVr2 = skreader.slotGG4;
                                break;
                            case 2:
                                skreader.slot8targetVr2 = skreader.slotGG5;
                                break;
                            default:
                                skreader.slot8targetVr2 = skreader.slotGG6;
                                break;
                        }
                        switch (Random.Range(0, 3))
                        {
                            case 1:
                                skreader.slot8targetVr3 = skreader.slotGG7;
                                break;
                            case 2:
                                skreader.slot8targetVr3 = skreader.slotGG8;
                                break;
                            default:
                                skreader.slot8targetVr3 = skreader.slotGG9;
                                break;
                        }
                        break;
                    case 13:
                        skreader.slot8skillVraga = 38;
                        if (skil38Vraga == null)
                        {
                            skil38Vraga = Instantiate(skills8place[prefabIndexin8place], slotsEnemy.slo8.transform.position, Quaternion.identity, slotsEnemy.slo8.transform) as GameObject; // спавн
                        }
                        switch (Random.Range(0, 3))
                        {
                            case 1:
                                skreader.slot8targetVr1 = skreader.slotGG2;
                                break;
                            case 2:
                                skreader.slot8targetVr1 = skreader.slotGG5;
                                break;
                            default:
                                skreader.slot8targetVr1 = skreader.slotGG8;
                                break;
                        }
                        skreader.slot8targetVr2 = null;
                        skreader.slot8targetVr3 = null;
                        break;
                    case 14:
                        skreader.slot8skillVraga = 39;
                        if (skil39Vraga == null)
                        {
                            skil39Vraga = Instantiate(skills8place[prefabIndexin8place], slotsEnemy.slo8.transform.position, Quaternion.identity, slotsEnemy.slo8.transform) as GameObject; // спавн
                        }
                        switch (Random.Range(0, 3))
                        {
                            case 1:
                                skreader.slot8targetVr1 = skreader.slotVraga4;
                                break;
                            case 2:
                                skreader.slot8targetVr1 = skreader.slotVraga5;
                                break;
                            default:
                                skreader.slot8targetVr1 = skreader.slotVraga6;
                                break;
                        }
                        switch (Random.Range(0, 2))
                        {
                            case 1:
                                skreader.slot8targetVr2 = skreader.slotVraga7;
                                break;
                            default:
                                skreader.slot8targetVr2 = skreader.slotVraga9;
                                break;
                        }
                        skreader.slot8targetVr3 = null;
                        break;
                    case 15:
                        skreader.slot8skillVraga = 40;
                        if (skil40Vraga == null)
                        {
                            skil40Vraga = Instantiate(skills8place[prefabIndexin8place], slotsEnemy.slo8.transform.position, Quaternion.identity, slotsEnemy.slo8.transform) as GameObject; // спавн
                        }
                        switch (Random.Range(0, 5))
                        {
                            case 1:
                                skreader.slot8targetVr1 = skreader.slotGG1;
                                break;
                            case 2:
                                skreader.slot8targetVr1 = skreader.slotGG2;
                                break;
                            case 3:
                                skreader.slot8targetVr1 = skreader.slotGG3;
                                break;
                            case 4:
                                skreader.slot8targetVr1 = skreader.slotGG4;
                                break;
                            default:
                                skreader.slot8targetVr1 = skreader.slotGG5;
                                break;
                        }
                        switch (Random.Range(0, 4))
                        {
                            case 1:
                                skreader.slot8targetVr2 = skreader.slotGG6;
                                break;
                            case 2:
                                skreader.slot8targetVr2 = skreader.slotGG7;
                                break;
                            case 3:
                                skreader.slot8targetVr2 = skreader.slotGG8;
                                break;
                            default:
                                skreader.slot8targetVr2 = skreader.slotGG9;
                                break;
                        }
                        skreader.slot8targetVr3 = null;
                        break;
                    case 16:
                        skreader.slot8skillVraga = 41;
                        if (skil41Vraga == null)
                        {
                            skil41Vraga = Instantiate(skills8place[prefabIndexin8place], slotsEnemy.slo8.transform.position, Quaternion.identity, slotsEnemy.slo8.transform) as GameObject; // спавн
                        }
                        skreader.slot8targetVr1 = null;
                        skreader.slot8targetVr2 = null;
                        skreader.slot8targetVr3 = null;
                        break;
                    case 17:
                        skreader.slot8skillVraga = 42;
                        if (skil42Vraga == null)
                        {
                            skil42Vraga = Instantiate(skills8place[prefabIndexin8place], slotsEnemy.slo8.transform.position, Quaternion.identity, slotsEnemy.slo8.transform) as GameObject; // спавн
                        }
                        skreader.slot8targetVr1 = skreader.slotVraga7;
                        skreader.slot8targetVr2 = null;
                        skreader.slot8targetVr3 = null;
                        break;


                    default: // промах
                        skreader.slot8skillVraga = 0;
                        readalready8 = true;
                        skreader.slot8targetVr1 = null;
                        skreader.slot8targetVr2 = null;
                        skreader.slot8targetVr3 = null;
                        break;
                }
 
                if (skreader.slot8skillVraga != skreader.slot1skillVraga && skreader.slot8skillVraga != skreader.slot2skillVraga && skreader.slot8skillVraga != skreader.slot3skillVraga && skreader.slot8skillVraga != skreader.slot4skillVraga && skreader.slot8skillVraga != skreader.slot5skillVraga && skreader.slot8skillVraga != skreader.slot6skillVraga && skreader.slot8skillVraga != skreader.slot7skillVraga)
                {
                    readalready8 = true;
                }
                else if (skreader.slot8skillVraga == 0 && skreader.slot2skillVraga == 33) // даёт поблажку 0 на случай частички плавников
                {
                    readalready8 = true;
                }
                else if (skreader.slot8skillVraga == 33)
                {
                    foreach (Transform child in slotsEnemy.slo2.transform)
                    {
                        Destroy(child.gameObject);
                    }
                }
            }
            // 9 слот
            if (readalready8 && readalready9 == false)
            {
                if (skreader.slot3skillVraga == 33) // спавним блочик
                {
                    prefabIndexin9place = 10;
                }
                else // если плавники не заблочили эту клетушку, спавним нормально
                {
                    if (distancePoints.distance < 5500) // биом 1
                    {
                        if (enemySpawner.bCirrat || enemySpawner.bNemin || enemySpawner.bAliss || enemySpawner.bPhiu || enemySpawner.bPhobel || enemySpawner.bPaster || enemySpawner.bPopmp || enemySpawner.bTopel || enemySpawner.bHeeth || enemySpawner.bPhanos || enemySpawner.bTheus || enemySpawner.bZem || enemySpawner.bAsce || enemySpawner.bKhirond || enemySpawner.bNerrelid) // если неагрессивный
                        {
                            prefabIndexin9place = Random.Range(-3, 5);
                        }
                        else
                        {
                            prefabIndexin9place = Random.Range(0, 5);
                        }
                    }
                    else if (distancePoints.distance >= 5500 && distancePoints.distance < 6500)
                    {
                        prefabIndexin9place = Random.Range(0, 10);
                    }
                    else if (distancePoints.distance >= 6500 && distancePoints.distance < 10500)
                    {
                        prefabIndexin9place = Random.Range(5, 15);
                    }
                    else if (distancePoints.distance > 10500)
                    {
                        prefabIndexin9place = Random.Range(5, 17); // максимальный диапазон
                    }

                    if (enemySpawner.bMarius == true)
                    {
                        prefabIndexin9place = 100;
                    }
                    else if (enemySpawner.bPareed == true)
                    {
                        prefabIndexin9place = Random.Range(0, 16);
                    }
                    else if (enemySpawner.bSciph == true || enemySpawner.bTkhar == true)
                    {
                        if (skreader.slot7skillVraga != 31 && skreader.slot1skillVraga != 31 && skreader.slot2skillVraga != 31 && skreader.slot3skillVraga != 31 && skreader.slot4skillVraga != 31 && skreader.slot5skillVraga != 31 && skreader.slot6skillVraga != 31 && skreader.slot8skillVraga != 31)
                        {
                            prefabIndexin9place = 9;
                        }
                    }
                    else if (enemySpawner.bTheus == true)
                    {
                        switch (batol.fortheus9)
                        {
                            case 0: // значение навыка
                                prefabIndexin9place = 100;
                                break;
                            case 6:
                                prefabIndexin9place = 0;
                                break;
                            case 7:
                                prefabIndexin9place = 1;
                                break;
                            case 8:
                                prefabIndexin9place = 2;
                                break;
                            case 9:
                                prefabIndexin9place = 3;
                                break;
                            case 14:
                                prefabIndexin9place = 4;
                                break;
                            case 16:
                                prefabIndexin9place = 5;
                                break;
                            case 21:
                                prefabIndexin9place = 6;
                                break;
                            case 22:
                                prefabIndexin9place = 7;
                                break;
                            case 27:
                                prefabIndexin9place = 8;
                                break;
                            case 31:
                                prefabIndexin9place = 9;
                                break;
                            case 34:
                                prefabIndexin9place = 11;
                                break;
                            case 37:
                                prefabIndexin9place = 12;
                                break;
                            case 38:
                                prefabIndexin9place = 13;
                                break;
                            case 39:
                                prefabIndexin9place = 14;
                                break;
                            case 40:
                                prefabIndexin9place = 15;
                                break;
                            case 41:
                                prefabIndexin9place = 16;
                                break;

                        }
                    }

                }

                foreach (Transform child in slotsEnemy.slo9.transform)
                {
                    Destroy(child.gameObject);
                }
                skreader.slot9targetVr1 = null;
                skreader.slot9targetVr2 = null;
                skreader.slot9targetVr3 = null;
                switch (prefabIndexin9place)
                {
                    case 0:
                        skreader.slot9skillVraga = 6;
                        if (skil6Vraga == null)
                        {
                            skil6Vraga = Instantiate(skills9place[prefabIndexin9place], slotsEnemy.slo9.transform.position, Quaternion.identity, slotsEnemy.slo9.transform) as GameObject; // спавн
                        }
                        skreader.slot9targetVr1 = skreader.slotVraga6;
                        skreader.slot9targetVr2 = null;
                        skreader.slot9targetVr3 = null;
                        break;
                    case 1:
                        skreader.slot9skillVraga = 7;
                        if (skil7Vraga == null)
                        {
                            skil7Vraga = Instantiate(skills9place[prefabIndexin9place], slotsEnemy.slo9.transform.position, Quaternion.identity, slotsEnemy.slo9.transform) as GameObject; // спавн
                        }
                        skreader.slot9targetVr1 = skreader.slotVraga6;
                        skreader.slot9targetVr2 = null;
                        skreader.slot9targetVr3 = null;
                        break;
                    case 2:
                        skreader.slot9skillVraga = 8;
                        if (skil8Vraga == null)
                        {
                            skil8Vraga = Instantiate(skills9place[prefabIndexin9place], slotsEnemy.slo9.transform.position, Quaternion.identity, slotsEnemy.slo9.transform) as GameObject; // спавн
                        }
                        skreader.slot9targetVr1 = skreader.slotVraga6;
                        skreader.slot9targetVr2 = null;
                        skreader.slot9targetVr3 = null;
                        break;

                    case 3:
                        skreader.slot9skillVraga = 9;
                        if (skil9Vraga == null)
                        {
                            skil9Vraga = Instantiate(skills9place[prefabIndexin9place], slotsEnemy.slo9.transform.position, Quaternion.identity, slotsEnemy.slo9.transform) as GameObject; // спавн
                        }
                        skreader.slot9targetVr1 = skreader.slotGG9;
                        skreader.slot9targetVr2 = null;
                        skreader.slot9targetVr3 = null;
                        break;
                    case 4:
                        skreader.slot9skillVraga = 14;
                        if (skil14Vraga == null)
                        {
                            skil14Vraga = Instantiate(skills9place[prefabIndexin9place], slotsEnemy.slo9.transform.position, Quaternion.identity, slotsEnemy.slo9.transform) as GameObject; // спавн
                        }
                        switch (Random.Range(0, 3))
                        {
                            case 1:
                                skreader.slot9targetVr1 = skreader.slotGG3;
                                break;
                            case 2:
                                skreader.slot9targetVr1 = skreader.slotGG6;
                                break;
                            default:
                                skreader.slot9targetVr1 = skreader.slotGG9;
                                break;
                        }
                        skreader.slot9targetVr2 = null;
                        skreader.slot9targetVr3 = null;
                        break;
                    case 5:
                        skreader.slot9skillVraga = 16;
                        if (skil16Vraga == null)
                        {
                            skil16Vraga = Instantiate(skills9place[prefabIndexin9place], slotsEnemy.slo9.transform.position, Quaternion.identity, slotsEnemy.slo9.transform) as GameObject; // спавн
                        }
                        skreader.slot9targetVr1 = skreader.slotGG9;
                        switch (Random.Range(0, 2))
                        {
                            case 1:
                                skreader.slot9targetVr2 = skreader.slotGG6;
                                break;
                            default:
                                skreader.slot9targetVr2 = skreader.slotGG8;
                                break;
                        }
                        skreader.slot9targetVr3 = null;
                        break;
                    case 6:
                        skreader.slot9skillVraga = 21;
                        if (skil21Vraga == null)
                        {
                            skil21Vraga = Instantiate(skills9place[prefabIndexin9place], slotsEnemy.slo9.transform.position, Quaternion.identity, slotsEnemy.slo9.transform) as GameObject; // спавн
                        }
                        skreader.slot9targetVr1 = skreader.slotVraga9;
                        skreader.slot9targetVr2 = skreader.slotGG9;
                        skreader.slot9targetVr3 = null;
                        break;
                    case 7:
                        skreader.slot9skillVraga = 22;
                        if (skil22Vraga == null)
                        {
                            skil22Vraga = Instantiate(skills9place[prefabIndexin9place], slotsEnemy.slo9.transform.position, Quaternion.identity, slotsEnemy.slo9.transform) as GameObject; // спавн
                        }
                        skreader.slot9targetVr1 = skreader.slotGG9;
                        skreader.slot9targetVr2 = null;
                        skreader.slot9targetVr3 = null;
                        break;
                    case 8:
                        skreader.slot9skillVraga = 27;
                        if (skil27Vraga == null)
                        {
                            skil27Vraga = Instantiate(skills9place[prefabIndexin9place], slotsEnemy.slo9.transform.position, Quaternion.identity, slotsEnemy.slo9.transform) as GameObject; // спавн
                        }
                        skreader.slot9targetVr1 = skreader.slotGG6;
                        switch (Random.Range(0, 2))
                        {
                            case 1:
                                skreader.slot9targetVr2 = skreader.slotGG3;
                                break;
                            default:
                                skreader.slot9targetVr2 = skreader.slotGG9;
                                break;
                        }
                        skreader.slot9targetVr3 = null;
                        break;
                    case 9:
                        skreader.slot9skillVraga = 31;
                        if (skil31Vraga == null)
                        {
                            skil31Vraga = Instantiate(skills9place[prefabIndexin9place], slotsEnemy.slo9.transform.position, Quaternion.identity, slotsEnemy.slo9.transform) as GameObject; // спавн
                        }
                        switch (Random.Range(0, 3))
                        {
                            case 1:
                                skreader.slot9targetVr1 = skreader.slotGG3;
                                break;
                            case 2:
                                skreader.slot9targetVr1 = skreader.slotGG6;
                                break;
                            default:
                                skreader.slot9targetVr1 = skreader.slotGG9;
                                break;
                        }
                        skreader.slot9targetVr2 = null;
                        skreader.slot9targetVr3 = null;
                        break;
                    case 10:
                        if (skreader.slot3skillVraga == 33) // если этот скилл уже был заспавнен на 2 слот
                        {
                            skreader.slot9skillVraga = 0;
                            foreach (Transform child in slotsEnemy.slo9.transform)
                            {
                                Destroy(child.gameObject);
                            }
                            Instantiate(skil33VragaShadow, slotsEnemy.slo9.transform.position, Quaternion.identity, slotsEnemy.slo9.transform); // спавн
                            skreader.slot9targetVr1 = null;
                            skreader.slot9targetVr2 = null;
                            skreader.slot9targetVr3 = null;
                        }
                        else
                        {
                            skreader.slot9skillVraga = 33;
                            skil33Vraga = Instantiate(skills9place[prefabIndexin9place], slotsEnemy.slo9.transform.position, Quaternion.identity, slotsEnemy.slo9.transform) as GameObject; // спавн
                            switch (Random.Range(0, 5))
                            {
                                case 1:
                                    skreader.slot9targetVr1 = skreader.slotGG1;
                                    break;
                                case 2:
                                    skreader.slot9targetVr1 = skreader.slotGG2;
                                    break;
                                case 3:
                                    skreader.slot9targetVr1 = skreader.slotGG3;
                                    break;
                                case 4:
                                    skreader.slot9targetVr1 = skreader.slotGG4;
                                    break;
                                default:
                                    skreader.slot9targetVr1 = skreader.slotGG5;
                                    break;
                            }
                            switch (Random.Range(0, 4))
                            {
                                case 1:
                                    skreader.slot9targetVr2 = skreader.slotGG6;
                                    break;
                                case 2:
                                    skreader.slot9targetVr2 = skreader.slotGG7;
                                    break;
                                case 3:
                                    skreader.slot9targetVr2 = skreader.slotGG8;
                                    break;
                                default:
                                    skreader.slot9targetVr2 = skreader.slotGG9;
                                    break;
                            }
                            skreader.slot9targetVr3 = null;
                            // чистит 3 слот
                            skreader.slot3skillVraga = 0;
                            skreader.slot3targetVr1 = null;
                            skreader.slot3targetVr2 = null;
                            skreader.slot3targetVr3 = null;
                            foreach (Transform child in slotsEnemy.slo3.transform)
                            {
                                Destroy(child.gameObject);
                            }
                            Instantiate(skil33VragaShadow, slotsEnemy.slo3.transform.position, Quaternion.identity, slotsEnemy.slo3.transform); // спавн
                        }
                        break;

                    case 11:
                        skreader.slot9skillVraga = 34;
                        if (skil34Vraga == null)
                        {
                            skil34Vraga = Instantiate(skills9place[prefabIndexin9place], slotsEnemy.slo9.transform.position, Quaternion.identity, slotsEnemy.slo9.transform) as GameObject; // спавн
                        }
                        switch (Random.Range(0, 3))
                        {
                            case 1:
                                skreader.slot9targetVr1 = skreader.slotGG1;
                                skreader.slot9targetVr2 = skreader.slotGG2;
                                skreader.slot9targetVr3 = skreader.slotGG3;
                                break;
                            case 2:
                                skreader.slot9targetVr1 = skreader.slotGG4;
                                skreader.slot9targetVr2 = skreader.slotGG5;
                                skreader.slot9targetVr3 = skreader.slotGG6;
                                break;
                            default:
                                skreader.slot9targetVr1 = skreader.slotGG7;
                                skreader.slot9targetVr2 = skreader.slotGG8;
                                skreader.slot9targetVr3 = skreader.slotGG9;
                                break;
                        }
                        break;
                    case 12:
                        skreader.slot9skillVraga = 37;
                        if (skil37Vraga == null)
                        {
                            skil37Vraga = Instantiate(skills9place[prefabIndexin9place], slotsEnemy.slo9.transform.position, Quaternion.identity, slotsEnemy.slo9.transform) as GameObject; // спавн
                        }
                        switch (Random.Range(0, 3))
                        {
                            case 1:
                                skreader.slot9targetVr1 = skreader.slotGG1;
                                break;
                            case 2:
                                skreader.slot9targetVr1 = skreader.slotGG2;
                                break;
                            default:
                                skreader.slot9targetVr1 = skreader.slotGG3;
                                break;
                        }
                        switch (Random.Range(0, 3))
                        {
                            case 1:
                                skreader.slot9targetVr2 = skreader.slotGG4;
                                break;
                            case 2:
                                skreader.slot9targetVr2 = skreader.slotGG5;
                                break;
                            default:
                                skreader.slot9targetVr2 = skreader.slotGG6;
                                break;
                        }
                        switch (Random.Range(0, 3))
                        {
                            case 1:
                                skreader.slot9targetVr3 = skreader.slotGG7;
                                break;
                            case 2:
                                skreader.slot9targetVr3 = skreader.slotGG8;
                                break;
                            default:
                                skreader.slot9targetVr3 = skreader.slotGG9;
                                break;
                        }
                        break;
                    case 13:
                        skreader.slot9skillVraga = 38;
                        if (skil38Vraga == null)
                        {
                            skil38Vraga = Instantiate(skills9place[prefabIndexin9place], slotsEnemy.slo9.transform.position, Quaternion.identity, slotsEnemy.slo9.transform) as GameObject; // спавн
                        }
                        switch (Random.Range(0, 3))
                        {
                            case 1:
                                skreader.slot9targetVr1 = skreader.slotGG3;
                                break;
                            case 2:
                                skreader.slot9targetVr1 = skreader.slotGG6;
                                break;
                            default:
                                skreader.slot9targetVr1 = skreader.slotGG9;
                                break;
                        }
                        skreader.slot9targetVr2 = null;
                        skreader.slot9targetVr3 = null;
                        break;
                    case 14:
                        skreader.slot9skillVraga = 39;
                        if (skil39Vraga == null)
                        {
                            skil39Vraga = Instantiate(skills9place[prefabIndexin9place], slotsEnemy.slo9.transform.position, Quaternion.identity, slotsEnemy.slo9.transform) as GameObject; // спавн
                        }
                        switch (Random.Range(0, 2))
                        {
                            case 1:
                                skreader.slot9targetVr1 = skreader.slotVraga5;
                                break;
                            default:
                                skreader.slot9targetVr1 = skreader.slotVraga6;
                                break;
                        }
                        skreader.slot9targetVr2 = skreader.slotVraga8;
                        skreader.slot9targetVr3 = null;
                        break;
                    case 15:
                        skreader.slot9skillVraga = 40;
                        if (skil40Vraga == null)
                        {
                            skil40Vraga = Instantiate(skills9place[prefabIndexin9place], slotsEnemy.slo9.transform.position, Quaternion.identity, slotsEnemy.slo9.transform) as GameObject; // спавн
                        }
                        switch (Random.Range(0, 5))
                        {
                            case 1:
                                skreader.slot9targetVr1 = skreader.slotGG1;
                                break;
                            case 2:
                                skreader.slot9targetVr1 = skreader.slotGG2;
                                break;
                            case 3:
                                skreader.slot9targetVr1 = skreader.slotGG3;
                                break;
                            case 4:
                                skreader.slot9targetVr1 = skreader.slotGG4;
                                break;
                            default:
                                skreader.slot9targetVr1 = skreader.slotGG5;
                                break;
                        }
                        switch (Random.Range(0, 4))
                        {
                            case 1:
                                skreader.slot9targetVr2 = skreader.slotGG6;
                                break;
                            case 2:
                                skreader.slot9targetVr2 = skreader.slotGG7;
                                break;
                            case 3:
                                skreader.slot9targetVr2 = skreader.slotGG8;
                                break;
                            default:
                                skreader.slot9targetVr2 = skreader.slotGG9;
                                break;
                        }
                        skreader.slot9targetVr3 = null;
                        break;
                    case 16:
                        skreader.slot9skillVraga = 41;
                        if (skil41Vraga == null)
                        {
                            skil41Vraga = Instantiate(skills9place[prefabIndexin9place], slotsEnemy.slo9.transform.position, Quaternion.identity, slotsEnemy.slo9.transform) as GameObject; // спавн
                        }
                        skreader.slot9targetVr1 = null;
                        skreader.slot9targetVr2 = null;
                        skreader.slot9targetVr3 = null;
                        break;
                    default: // промах
                        skreader.slot9skillVraga = 0;
                        readalready9 = true;
                        justonceRead = false;
                        skreader.slot9targetVr1 = null;
                        skreader.slot9targetVr2 = null;
                        skreader.slot9targetVr3 = null;
                        break;
                }
                if (skreader.slot9skillVraga != skreader.slot1skillVraga && skreader.slot9skillVraga != skreader.slot2skillVraga && skreader.slot9skillVraga != skreader.slot3skillVraga && skreader.slot9skillVraga != skreader.slot4skillVraga && skreader.slot9skillVraga != skreader.slot5skillVraga && skreader.slot9skillVraga != skreader.slot6skillVraga && skreader.slot9skillVraga != skreader.slot7skillVraga && skreader.slot9skillVraga != skreader.slot8skillVraga)
                {
                    readalready9 = true;
                    justonceRead = false;
                }
                else if(skreader.slot9skillVraga == 0 && skreader.slot3skillVraga == 33) // даёт поблажку 0 на случай частички плавников
                {
                    readalready9 = true;
                    justonceRead = false;
                }
                // если будет респавниться двойной навык, который повлиял на другой слот, созданный слотик уничтожится
                else if (skreader.slot9skillVraga == 33)
                {
                    foreach (Transform child in slotsEnemy.slo3.transform)
                    {
                        Destroy(child.gameObject);
                    }
                }
            }

        }

    }

    public void skipEnemy()
    {
        // из слайдера
        slidor.nachislenie();

        playir.howmanyinteractions += 1;
        foreach (Transform child in batol.hodBlok.transform)
        {
            child.gameObject.GetComponent<Image>().color = batol.transpcolor;
        }
        foreach (Transform child in batol.hodBlok2.transform)
        {
            child.gameObject.GetComponent<Image>().color = batol.transpcolor;
        }
        foreach (Transform child in batol.hodantiBlok.transform)
        {
            child.gameObject.GetComponent<Image>().color = batol.transpcolor;
            child.gameObject.transform.localScale = new Vector3(0f, 0f, 0f);
        }
        foreach (Transform child in batol.hodantiBlok2.transform)
        {
            child.gameObject.GetComponent<Image>().color = batol.transpcolor;
            child.gameObject.transform.localScale = new Vector3(0f, 0f, 0f);
        }
        batol.hodantiBlok.SetActive(false);
        batol.hodantiBlok2.SetActive(false);
        batol.slot1GGshield.SetActive(false);
        batol.slot2GGshield.SetActive(false);
        batol.slot3GGshield.SetActive(false);
        batol.slot4GGshield.SetActive(false);
        batol.slot5GGshield.SetActive(false);
        batol.slot6GGshield.SetActive(false);
        batol.slot7GGshield.SetActive(false);
        batol.slot8GGshield.SetActive(false);
        batol.slot9GGshield.SetActive(false);
        batol.slot1Vragshield.SetActive(false);
        batol.slot2Vragshield.SetActive(false);
        batol.slot3Vragshield.SetActive(false);
        batol.slot4Vragshield.SetActive(false);
        batol.slot5Vragshield.SetActive(false);
        batol.slot6Vragshield.SetActive(false);
        batol.slot7Vragshield.SetActive(false);
        batol.slot8Vragshield.SetActive(false);
        batol.slot9Vragshield.SetActive(false);
        batol.hoddamag.SetActive(false);
        batol.hoddamag2.SetActive(false);
        batol.hodhilli.SetActive(false);
        batol.hodhilli2.SetActive(false);
        batol.hodtoxins.SetActive(false);
        batol.hodtoxins2.SetActive(false);
        batol.hodSvet.SetActive(false);
        batol.hodSvet2.SetActive(false);
        blokderzhalka.SetActive(false);
        blokderzhalka1.SetActive(false);
        blokderzhalka2.SetActive(false);
        batol.slot1GGtoxins.SetActive(false);
        batol.slot2GGtoxins.SetActive(false);
        batol.slot3GGtoxins.SetActive(false);
        batol.slot4GGtoxins.SetActive(false);
        batol.slot5GGtoxins.SetActive(false);
        batol.slot6GGtoxins.SetActive(false);
        batol.slot7GGtoxins.SetActive(false);
        batol.slot8GGtoxins.SetActive(false);
        batol.slot9GGtoxins.SetActive(false);
        batol.slot1Vragtoxins.SetActive(false);
        batol.slot2Vragtoxins.SetActive(false);
        batol.slot3Vragtoxins.SetActive(false);
        batol.slot4Vragtoxins.SetActive(false);
        batol.slot5Vragtoxins.SetActive(false);
        batol.slot6Vragtoxins.SetActive(false);
        batol.slot7Vragtoxins.SetActive(false);
        batol.slot8Vragtoxins.SetActive(false);
        batol.slot9Vragtoxins.SetActive(false);
        batol.otrava1 = 0;
        batol.otrava2 = 0;
        batol.otrava3 = 0;
        batol.otrava4 = 0;
        batol.otrava5 = 0;
        batol.otrava6 = 0;
        batol.otrava7 = 0;
        batol.otrava8 = 0;
        batol.otrava9 = 0;
        batol.otrava10 = 0;
        batol.otrava11 = 0;
        batol.otrava12 = 0;
        batol.otrava13 = 0;
        batol.otrava14 = 0;
        batol.otrava15 = 0;
        batol.otrava16 = 0;
        batol.otrava17 = 0;
        batol.otrava18 = 0;
        batol.slot1GGbloch.SetActive(false);
        batol.slot2GGbloch.SetActive(false);
        batol.slot3GGbloch.SetActive(false);
        batol.slot4GGbloch.SetActive(false);
        batol.slot5GGbloch.SetActive(false);
        batol.slot6GGbloch.SetActive(false);
        batol.slot7GGbloch.SetActive(false);
        batol.slot8GGbloch.SetActive(false);
        batol.slot9GGbloch.SetActive(false);
        batol.slot1Vragbloch.SetActive(false);
        batol.slot2Vragbloch.SetActive(false);
        batol.slot3Vragbloch.SetActive(false);
        batol.slot4Vragbloch.SetActive(false);
        batol.slot5Vragbloch.SetActive(false);
        batol.slot6Vragbloch.SetActive(false);
        batol.slot7Vragbloch.SetActive(false);
        batol.slot8Vragbloch.SetActive(false);
        batol.slot9Vragbloch.SetActive(false);
        slot1zablokVraga = false;
        slot2zablokVraga = false;
        slot3zablokVraga = false;
        slot4zablokVraga = false;
        slot5zablokVraga = false;
        slot6zablokVraga = false;
        slot7zablokVraga = false;
        slot8zablokVraga = false;
        slot9zablokVraga = false;
        slot1zablokirovan = false;
        slot2zablokirovan = false;
        slot3zablokirovan = false;
        slot4zablokirovan = false;
        slot5zablokirovan = false;
        slot6zablokirovan = false;
        slot7zablokirovan = false;
        slot8zablokirovan = false;
        slot9zablokirovan = false;
        // это отключение после асце
        slotsEnemy.slo1blocked.SetActive(false);
        slotsEnemy.slo2blocked.SetActive(false);
        slotsEnemy.slo3blocked.SetActive(false);
        slotsEnemy.slo4blocked.SetActive(false);
        slotsEnemy.slo5blocked.SetActive(false);
        slotsEnemy.slo6blocked.SetActive(false);
        slotsEnemy.slo7blocked.SetActive(false);
        slotsEnemy.slo8blocked.SetActive(false);
        slotsEnemy.slo9blocked.SetActive(false);
        skreader.slot1targetVr1 = null;
        skreader.slot1targetVr2 = null;
        skreader.slot1targetVr3 = null;
        skreader.slot2targetVr1 = null;
        skreader.slot2targetVr2 = null;
        skreader.slot2targetVr3 = null;
        skreader.slot3targetVr1 = null;
        skreader.slot3targetVr2 = null;
        skreader.slot3targetVr3 = null;
        skreader.slot4targetVr1 = null;
        skreader.slot4targetVr2 = null;
        skreader.slot4targetVr3 = null;
        skreader.slot5targetVr1 = null;
        skreader.slot5targetVr2 = null;
        skreader.slot5targetVr3 = null;
        skreader.slot6targetVr1 = null;
        skreader.slot6targetVr2 = null;
        skreader.slot6targetVr3 = null;
        skreader.slot7targetVr1 = null;
        skreader.slot7targetVr2 = null;
        skreader.slot7targetVr3 = null;
        skreader.slot8targetVr1 = null;
        skreader.slot8targetVr2 = null;
        skreader.slot8targetVr3 = null;
        skreader.slot9targetVr1 = null;
        skreader.slot9targetVr2 = null;
        skreader.slot9targetVr3 = null;
        battleModeVisibility.mermanChitaetsya = false;
        readalready1 = false;
        readalready2 = false;
        readalready3 = false;
        readalready4 = false;
        readalready5 = false;
        readalready6 = false;
        readalready7 = false;
        readalready8 = false;
        readalready9 = false;
        speshlblok1.SetActive(false);
        speshlblok2.SetActive(false);
        speshlblok3.SetActive(false);
        speshlblok4.SetActive(false);
        speshlblok5.SetActive(false);
        speshlblok6.SetActive(false);
        speshlblok7.SetActive(false);
        speshlblok8.SetActive(false);
        speshlblok9.SetActive(false);
        foreach (Transform child in slotsEnemy.slo1.transform)
        {
            Destroy(child.gameObject);
        }
        foreach (Transform child in slotsEnemy.slo2.transform)
        {
            Destroy(child.gameObject);
        }
        foreach (Transform child in slotsEnemy.slo3.transform)
        {
            Destroy(child.gameObject);
        }
        foreach (Transform child in slotsEnemy.slo4.transform)
        {
            Destroy(child.gameObject);
        }
        foreach (Transform child in slotsEnemy.slo5.transform)
        {
            Destroy(child.gameObject);
        }
        foreach (Transform child in slotsEnemy.slo6.transform)
        {
            Destroy(child.gameObject);
        }
        foreach (Transform child in slotsEnemy.slo7.transform)
        {
            Destroy(child.gameObject);
        }
        foreach (Transform child in slotsEnemy.slo8.transform)
        {
            Destroy(child.gameObject);
        }
        foreach (Transform child in slotsEnemy.slo9.transform)
        {
            Destroy(child.gameObject);
        }
        skillNuller();

        // сгенерированные награды обнуляются
        battleModeVisibility.randomObilia = 0;
        battleModeVisibility.mermaidPlace1 = 0;
        
        battleModeVisibility.mermaidPlace2 = 0;
        battleModeVisibility.newMermaids = 0;
        battleModeVisibility.randomIkornyy = 0;

        // все булы мерменов убираются
        if (final.deathmode == false)
        {
            enemySpawner.bAliss = false;
            enemySpawner.bAsce = false;
            enemySpawner.bAbbet = false;
            enemySpawner.bBabil = false;
            enemySpawner.bBatiz = false;
            enemySpawner.bBent = false;
            enemySpawner.bCirrat = false;
            enemySpawner.bCellisee = false;
            enemySpawner.bDemos = false;
            enemySpawner.bEchin = false;
            enemySpawner.bEkhir = false;
            enemySpawner.bGalan = false;
            enemySpawner.bGolor = false;
            enemySpawner.bGren = false;
            enemySpawner.bHadee = false;
            enemySpawner.bHeeth = false;
            enemySpawner.bHio = false;
            enemySpawner.bKhirond = false;
            enemySpawner.bKoryph = false;
            enemySpawner.bKridei = false;
            enemySpawner.bLat = false;
            enemySpawner.bLihet = false;
            enemySpawner.bMarius = false;
            enemySpawner.bMikt = false;
            enemySpawner.bNemin = false;
            enemySpawner.bNerrelid = false;
            enemySpawner.bNophor = false;
            enemySpawner.bPareed = false;
            enemySpawner.bPaster = false;
            enemySpawner.bPhanos = false;
            enemySpawner.bPharn = false;
            enemySpawner.bPhiu = false;
            enemySpawner.bPhobel = false;
            enemySpawner.bPlog = false;
            enemySpawner.bPopmp = false;
            enemySpawner.bProkt = false;
            enemySpawner.bRago = false;
            enemySpawner.bRoid = false;
            enemySpawner.bSactin = false;
            enemySpawner.bSciph = false;
            enemySpawner.bSothet = false;
            enemySpawner.bThanaid = false;
            enemySpawner.bThemum = false;
            enemySpawner.bTheus = false;
            enemySpawner.bTkhar = false;
            enemySpawner.bTopel = false;
            enemySpawner.bTyphlon = false;
            enemySpawner.bZem = false;
        }
    }

    public void otkluchPodsvetok()
    {
        if (slotsEnemy.slo1.transform.childCount > 0 && skreader.slot1skillVraga != 0)
        {
            slotsEnemy.slo1.transform.GetChild(0).transform.GetChild(0).gameObject.SetActive(false);
        }
        if (slotsEnemy.slo2.transform.childCount > 0 && skreader.slot2skillVraga != 0)
        {
            slotsEnemy.slo2.transform.GetChild(0).transform.GetChild(0).gameObject.SetActive(false);
        }
        if (slotsEnemy.slo3.transform.childCount > 0 && skreader.slot3skillVraga != 0)
        {
            slotsEnemy.slo3.transform.GetChild(0).transform.GetChild(0).gameObject.SetActive(false);
        }
        if (slotsEnemy.slo4.transform.childCount > 0 && skreader.slot4skillVraga != 0)
        {
            slotsEnemy.slo4.transform.GetChild(0).transform.GetChild(0).gameObject.SetActive(false);
        }
        if (slotsEnemy.slo5.transform.childCount > 0 && skreader.slot5skillVraga != 0)
        {
            slotsEnemy.slo5.transform.GetChild(0).transform.GetChild(0).gameObject.SetActive(false);
        }
        if (slotsEnemy.slo6.transform.childCount > 0 && skreader.slot6skillVraga != 0)
        {
            slotsEnemy.slo6.transform.GetChild(0).transform.GetChild(0).gameObject.SetActive(false);
        }
        if (slotsEnemy.slo7.transform.childCount > 0 && skreader.slot7skillVraga != 0)
        {
            slotsEnemy.slo7.transform.GetChild(0).transform.GetChild(0).gameObject.SetActive(false);
        }
        if (slotsEnemy.slo8.transform.childCount > 0 && skreader.slot8skillVraga != 0)
        {
            slotsEnemy.slo8.transform.GetChild(0).transform.GetChild(0).gameObject.SetActive(false);
        }
        if (slotsEnemy.slo9.transform.childCount > 0 && skreader.slot9skillVraga != 0)
        {
            slotsEnemy.slo9.transform.GetChild(0).transform.GetChild(0).gameObject.SetActive(false);
        }
    }

    public void skillNuller()
    {
        skil1Vraga = null;
        skil2Vraga = null;
        skil3Vraga = null;
        skil4Vraga = null;
        skil5Vraga = null;
        skil6Vraga = null;
        skil7Vraga = null;
        skil8Vraga = null;
        skil9Vraga = null;
    }
}
