using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skillsreader : MonoBehaviour
{
    public SkillsController skills;
    public Levels forLevel;
    public Slot1 slots;
    public Slo1 slotsEnemy;
    public BattleScreen battleModeVisibility;
    public IkraIndicator ikorka;
    public MermaidController mermaids;

    public AudioSource slotzaniat;
    public AudioSource slotzaniat2;
    public bool zvukbudet;

    public bool skil30used;
    public bool skil32used;
    public bool skil22used;

    public GameObject colonka1;
    public GameObject colonka2;
    public GameObject colonka3;
    public GameObject colonka4;
    public GameObject colonka5;
    public GameObject colonka6;
    public GameObject colonka8;
    public GameObject colonka9;
    public GameObject colonka10;
    public GameObject colonka11;
    public GameObject colonka12;
    public GameObject colonka13;
    public GameObject colonka14;
    public GameObject colonka15;
    public GameObject colonka16;
    public GameObject colonka17;
    public GameObject colonka18;
    public GameObject colonka19;
    public GameObject colonka20;
    public GameObject colonka21;
    public GameObject colonka22;
    public GameObject colonka23;
    public GameObject colonka24;
    public GameObject colonka25;
    public GameObject colonka26;
    public GameObject colonka27;
    public GameObject colonka28;
    public GameObject colonka29;
    public GameObject colonka30;
    public GameObject colonka31;
    public GameObject colonka32;
    public GameObject colonka33;
    public GameObject colonka34;
    public GameObject colonka35;
    public GameObject colonka36;
    public GameObject colonka37;
    public GameObject colonka38;
    public GameObject colonka39;
    public GameObject colonka40;
    public GameObject colonka41;
    public GameObject colonka42;
    public GameObject colonka43;

    public GameObject podsvetTrigger1;
    public GameObject podsvetTrigger2;
    public GameObject podsvetTrigger3;
    public GameObject podsvetTrigger4;
    public GameObject podsvetTrigger5;
    public GameObject podsvetTrigger6;
    public GameObject podsvetTrigger7;
    public GameObject podsvetTrigger8;
    public GameObject podsvetTrigger9;
    public GameObject podsvetTrigger1Connected;
    public GameObject podsvetTrigger2Connected;
    public GameObject podsvetTrigger3Connected;
    public GameObject podsvetTrigger4Connected;
    public GameObject podsvetTrigger5Connected;
    public GameObject podsvetTrigger6Connected;
    public GameObject podsvetTrigger7Connected;
    public GameObject podsvetTrigger8Connected;
    public GameObject podsvetTrigger9Connected;
    // сами слоты объекты
    public GameObject slotVraga1;
    public GameObject slotVraga2;
    public GameObject slotVraga3;
    public GameObject slotVraga4;
    public GameObject slotVraga5;
    public GameObject slotVraga6;
    public GameObject slotVraga7;
    public GameObject slotVraga8;
    public GameObject slotVraga9;
    public GameObject slotGG1;
    public GameObject slotGG2;
    public GameObject slotGG3;
    public GameObject slotGG4;
    public GameObject slotGG5;
    public GameObject slotGG6;
    public GameObject slotGG7;
    public GameObject slotGG8;
    public GameObject slotGG9;
    public GameObject mishendemonVraga1;
    public GameObject mishendemonVraga2;
    public GameObject mishendemonVraga3;
    public GameObject mishendemonVraga4;
    public GameObject mishendemonVraga5;
    public GameObject mishendemonVraga6;
    public GameObject mishendemonVraga7;
    public GameObject mishendemonVraga8;
    public GameObject mishendemonVraga9;
    public GameObject mishendemonGG1;
    public GameObject mishendemonGG2;
    public GameObject mishendemonGG3;
    public GameObject mishendemonGG4;
    public GameObject mishendemonGG5;
    public GameObject mishendemonGG6;
    public GameObject mishendemonGG7;
    public GameObject mishendemonGG8;
    public GameObject mishendemonGG9;
    public GameObject additionBack;
    public GameObject additionBackVraga;
    // публик геймобъекты для присваиваемых навыков врага

    public GameObject colonascolliderami;
    public GameObject movedSkill;

    // Слоты гг и слоты врага (будут читать навыки по их номерам)
    public float slot1skill;
    public float slot2skill;
    public float slot3skill;
    public float slot4skill;
    public float slot5skill;
    public float slot6skill;
    public float slot7skill;
    public float slot8skill;
    public float slot9skill;
    public float slot1skillVraga;
    public float slot2skillVraga;
    public float slot3skillVraga;
    public float slot4skillVraga;
    public float slot5skillVraga;
    public float slot6skillVraga;
    public float slot7skillVraga;
    public float slot8skillVraga;
    public float slot9skillVraga;
    public float slot1skillCompare;
    public float slot2skillCompare;
    public float slot3skillCompare;
    public float slot4skillCompare;
    public float slot5skillCompare;
    public float slot6skillCompare;
    public float slot7skillCompare;
    public float slot8skillCompare;
    public float slot9skillCompare;

    // Мишени слотов гг, предположительно, максимум их по 3
    // Из них мы будем брать хп, булы блоков и так далее
    public GameObject slot1target1;
    public GameObject slot1target2;
    public GameObject slot1target3;
    public GameObject slot2target1;
    public GameObject slot2target2;
    public GameObject slot2target3;
    public GameObject slot3target1;
    public GameObject slot3target2;
    public GameObject slot3target3;
    public GameObject slot4target1;
    public GameObject slot4target2;
    public GameObject slot4target3;
    public GameObject slot5target1;
    public GameObject slot5target2;
    public GameObject slot5target3;
    public GameObject slot6target1;
    public GameObject slot6target2;
    public GameObject slot6target3;
    public GameObject slot7target1;
    public GameObject slot7target2;
    public GameObject slot7target3;
    public GameObject slot8target1;
    public GameObject slot8target2;
    public GameObject slot8target3;
    public GameObject slot9target1;
    public GameObject slot9target2;
    public GameObject slot9target3;

    // Мишени слотов врага, предположительно, максимум их по 3
    public GameObject slot1targetVr1;
    public GameObject slot1targetVr2;
    public GameObject slot1targetVr3;
    public GameObject slot2targetVr1;
    public GameObject slot2targetVr2;
    public GameObject slot2targetVr3;
    public GameObject slot3targetVr1;
    public GameObject slot3targetVr2;
    public GameObject slot3targetVr3;
    public GameObject slot4targetVr1;
    public GameObject slot4targetVr2;
    public GameObject slot4targetVr3;
    public GameObject slot5targetVr1;
    public GameObject slot5targetVr2;
    public GameObject slot5targetVr3;
    public GameObject slot6targetVr1;
    public GameObject slot6targetVr2;
    public GameObject slot6targetVr3;
    public GameObject slot7targetVr1;
    public GameObject slot7targetVr2;
    public GameObject slot7targetVr3;
    public GameObject slot8targetVr1;
    public GameObject slot8targetVr2;
    public GameObject slot8targetVr3;
    public GameObject slot9targetVr1;
    public GameObject slot9targetVr2;
    public GameObject slot9targetVr3;

    public GameObject mishenHolder;
    public GameObject mishenHolderVraga;
    // доступные мишени
    public GameObject slot1mish;
    public GameObject slot2mish;
    public GameObject slot3mish;
    public GameObject slot4mish;
    public GameObject slot5mish;
    public GameObject slot6mish;
    public GameObject slot7mish;
    public GameObject slot8mish;
    public GameObject slot9mish;
    public GameObject slot1mishVraga;
    public GameObject slot2mishVraga;
    public GameObject slot3mishVraga;
    public GameObject slot4mishVraga;
    public GameObject slot5mishVraga;
    public GameObject slot6mishVraga;
    public GameObject slot7mishVraga;
    public GameObject slot8mishVraga;
    public GameObject slot9mishVraga;
    // их коллайдеры
    public Collider2D slot1mishulala;
    public Collider2D slot2mishulala;
    public Collider2D slot3mishulala;
    public Collider2D slot4mishulala;
    public Collider2D slot5mishulala;
    public Collider2D slot6mishulala;
    public Collider2D slot7mishulala;
    public Collider2D slot8mishulala;
    public Collider2D slot9mishulala;
    public Collider2D slot1mishVragaulala;
    public Collider2D slot2mishVragaulala;
    public Collider2D slot3mishVragaulala;
    public Collider2D slot4mishVragaulala;
    public Collider2D slot5mishVragaulala;
    public Collider2D slot6mishVragaulala;
    public Collider2D slot7mishVragaulala;
    public Collider2D slot8mishVragaulala;
    public Collider2D slot9mishVragaulala;
    // фейковые мишени для демонстрации
    public GameObject mishenHolderFals;
    public GameObject mishenHolderVragaFals;
    public GameObject slot1falsMish;
    public GameObject slot2falsMish;
    public GameObject slot3falsMish;
    public GameObject slot4falsMish;
    public GameObject slot5falsMish;
    public GameObject slot6falsMish;
    public GameObject slot7falsMish;
    public GameObject slot8falsMish;
    public GameObject slot9falsMish;
    public GameObject slot1falsMishVraga;
    public GameObject slot2falsMishVraga;
    public GameObject slot3falsMishVraga;
    public GameObject slot4falsMishVraga;
    public GameObject slot5falsMishVraga;
    public GameObject slot6falsMishVraga;
    public GameObject slot7falsMishVraga;
    public GameObject slot8falsMishVraga;
    public GameObject slot9falsMishVraga;
    // выбранные мишени
    public GameObject slot1mishfull;
    public GameObject slot2mishfull;
    public GameObject slot3mishfull;
    public GameObject slot4mishfull;
    public GameObject slot5mishfull;
    public GameObject slot6mishfull;
    public GameObject slot7mishfull;
    public GameObject slot8mishfull;
    public GameObject slot9mishfull;
    public GameObject slot1mishVragafull;
    public GameObject slot2mishVragafull;
    public GameObject slot3mishVragafull;
    public GameObject slot4mishVragafull;
    public GameObject slot5mishVragafull;
    public GameObject slot6mishVragafull;
    public GameObject slot7mishVragafull;
    public GameObject slot8mishVragafull;
    public GameObject slot9mishVragafull;

    public GameObject vybrMishen; // передатчик
    private bool doneOnce = true;

    public Transform parentPole;
    public Transform parentPolepromezhutok1;
    public Transform parentPolepromezhutok2;
    public Transform ParentofparentPole;
    public Transform parentofParentofparentPole;

    public GameObject specialChildforBack;
    public GameObject specialtarget1;
    public GameObject specialtarget2;
    public GameObject specialtarget3;

    // для прочтения мишеней
    private bool thispartisread;
    private bool thispartisread1;
    private bool thispartisread2;
    private bool thispartisread3;
    private bool thispartisread4;
    private bool thispartisread5;
    private bool thispartisread6;
    private bool thispartisread7;
    private bool thispartisread8;
    private bool thispartisread9;
    private bool thispartisread10;
    private bool thispartisread11;
    private bool thispartisread12;
    private bool thispartisread13;
    private bool thispartisread14;
    private bool thispartisread15;
    private bool thispartisread16;
    private bool thispartisread17;
    private bool thispartisread18;
    private bool thispartisread19;
    private bool thispartisread20;
    private bool thispartisread21;
    private bool thispartisread26;
    private bool thispartisread27;
    private bool thispartisread28;
    private bool thispartisread29;
    private bool thispartisread30;
    private bool thispartisread31;
    private bool thispartisread32;
    private bool thispartisread33;
    private bool thispartisread34;
    private bool thispartisread35;
    private bool thispartisread36;
    private bool thispartisread37;
    private bool thispartisread38;
    private bool thispartisread39;
    private bool thispartisread40;
    private bool thispartisread41;
    private bool thispartisread42;
    private bool thispartisread44;
    private bool thispartisread45;
    private bool thispartisread46;
    private bool thispartisread47;
    private bool thispartisread48;
    private bool thispartisread49;
    private bool thispartisread50;
    private bool thispartisread51;
    private bool thispartisread52;
    private bool thispartisread53;
    private bool thispartisread54;
    private bool thispartisread55;
    private bool thispartisread56;
    private bool thispartisread57;
    private bool thispartisread58;
    private bool thispartisread59;
    private bool thispartisread60;
    private bool thispartisread61;
    private bool thispartisread62;
    private bool thispartisread63;
    private bool thispartisread64;
    private bool thispartisread65;
    private bool thispartisread66;
    private bool thispartisread67;
    private bool thispartisread68;
    private bool thispartisread69;
    private bool thispartisread70;
    private bool thispartisread71;
    private bool thispartisread72;
    private bool thispartisread73;
    private bool thispartisread74;
    private bool thispartisread75;
    private bool thispartisread76;
    private bool thispartisread77;
    private bool thispartisread78;
    private bool thispartisread79;
    private bool thispartisread80;
    private bool thispartisread81;
    private bool thispartisread82;
    private bool thispartisread83;
    private bool thispartisread84;
    private bool thispartisread85;
    private bool thispartisread86;
    private bool thispartisread87;
    private bool thispartisread88;
    private bool thispartisread89;
    private bool thispartisread90;
    private bool thispartisread91;
    private bool thispartisread92;
    private bool thispartisread93;
    private bool thispartisread94;
    private bool thispartisread95;
    private bool thispartisread96;
    private bool thispartisread97;
    private bool thispartisread98;
    private bool thispartisread99;
    private bool thispartisread100;
    private bool thispartisread101;
    private bool thispartisread102;
    private bool thispartisread103;
    private bool thispartisread104;
    private bool thispartisread105;
    private bool thispartisread106;
    private bool thispartisread107;
    private bool thispartisread108;
    private bool thispartisread109;
    private bool thispartisread110;
    private bool thispartisread111;
    private bool thispartisread112;
    private bool thispartisread113;
    private bool thispartisread114;
    private bool thispartisread115;
    private bool thispartisread116;
    private bool thispartisread117;
    private bool thispartisread118;
    private bool thispartisread119;
    private bool thispartisread120;
    private bool thispartisread121;
    private bool thispartisread122;
    private bool thispartisread123;
    private bool thispartisread124;
    private bool thispartisread125;
    private bool thispartisread126;
    private bool thispartisread127;
    private bool thispartisread128;
    private bool thispartisread129;
    private bool thispartisread130;
    private bool thispartisread131;
    private bool thispartisread132;
    private bool thispartisread133;
    private bool thispartisread134;
    private bool thispartisread135;
    private bool thispartisread136;
    private bool thispartisread137;
    private bool thispartisread138;
    private bool thispartisread139;
    private bool thispartisread140;
    private bool thispartisread141;
    private bool thispartisread142;
    private bool thispartisread143;
    private bool thispartisread144;
    private bool thispartisread145;
    private bool thispartisread146;
    private bool thispartisread147;
    private bool thispartisread148;
    private bool thispartisread149;
    private bool thispartisread150;
    private bool thispartisread151;
    private bool thispartisread152;
    private bool thispartisread153;
    private bool thispartisread154;
    private bool thispartisread155;


    public GameObject genus1;
    public GameObject genus2;
    public GameObject genus3;

    // списки ниже продолжаются
    public GameObject skBlok1;
    public GameObject skBlok2;
    public GameObject skBlok3;
    public GameObject skBlok4;
    public GameObject skBlok5;
    public GameObject skBlok6;
    public GameObject skBlok8;
    public GameObject skBlok9;
    public GameObject skBlok10;
    public GameObject skBlok11;
    public GameObject skBlok12;
    public GameObject skBlok13;
    public GameObject skBlok14;
    public GameObject skBlok15;
    public GameObject skBlok16;
    public GameObject skBlok17;
    public GameObject skBlok18;
    public GameObject skBlok19;
    public GameObject skBlok20;
    public GameObject skBlok21;
    public GameObject skBlok22;
    public GameObject skBlok23;
    public GameObject skBlok24;
    public GameObject skBlok25;
    public GameObject skBlok26;
    public GameObject skBlok27;
    public GameObject skBlok28;
    public GameObject skBlok29;
    public GameObject skBlok30;
    public GameObject skBlok31;
    public GameObject skBlok32;
    public GameObject skBlok33;
    public GameObject skBlok34;
    public GameObject skBlok35;
    public GameObject skBlok36;
    public GameObject skBlok37;
    public GameObject skBlok38;
    public GameObject skBlok39;
    public GameObject skBlok40;
    public GameObject skBlok41;
    public GameObject skBlok42;
    public GameObject skBlok43;

    public GameObject skil1;
    public GameObject skil2;
    public GameObject skil3;
    public GameObject skil4;
    public GameObject skil5;
    public GameObject skil6;
    public GameObject skil8;
    public GameObject skil9;
    public GameObject skil10;
    public GameObject skil11;
    public GameObject skil12;
    public GameObject skil13;
    public GameObject skil14;
    public GameObject skil15;
    public GameObject skil16;
    public GameObject skil17;
    public GameObject skil18;
    public GameObject skil19;
    public GameObject skil20;
    public GameObject skil21;
    public GameObject skil22;
    public GameObject skil23;
    public GameObject skil24;
    public GameObject skil25;
    public GameObject skil26;
    public GameObject skil27;
    public GameObject skil28;
    public GameObject skil29;
    public GameObject skil30;
    public GameObject skil31;
    public GameObject skil32;
    public GameObject skil33;
    public GameObject skil34;
    public GameObject skil35;
    public GameObject skil36;
    public GameObject skil37;
    public GameObject skil38;
    public GameObject skil39;
    public GameObject skil40;
    public GameObject skil41;
    public GameObject skil42;
    public GameObject skil43;
    public GameObject skil29sosok;
    public GameObject skil33sosok;

    // коллайдеры
    public Collider2D skil1coll;
    public Collider2D skil2coll;
    public Collider2D skil3coll;
    public Collider2D skil4coll;
    public Collider2D skil5coll;
    public Collider2D skil6coll;
    public Collider2D skil8coll;
    public Collider2D skil9coll;
    public Collider2D skil10coll;
    public Collider2D skil11coll;
    public Collider2D skil12coll;
    public Collider2D skil13coll;
    public Collider2D skil14coll;
    public Collider2D skil15coll;
    public Collider2D skil16coll;
    public Collider2D skil17coll;
    public Collider2D skil18coll;
    public Collider2D skil19coll;
    public Collider2D skil20coll;
    public Collider2D skil21coll;
    public Collider2D skil22coll;
    public Collider2D skil23coll;
    public Collider2D skil24coll;
    public Collider2D skil25coll;
    public Collider2D skil26coll;
    public Collider2D skil27coll;
    public Collider2D skil28coll;
    public Collider2D skil29coll;
    public Collider2D skil30coll;
    public Collider2D skil31coll;
    public Collider2D skil32coll;
    public Collider2D skil33coll;
    public Collider2D skil34coll;
    public Collider2D skil35coll;
    public Collider2D skil36coll;
    public Collider2D skil37coll;
    public Collider2D skil38coll;
    public Collider2D skil39coll;
    public Collider2D skil40coll;
    public Collider2D skil41coll;
    public Collider2D skil42coll;
    public Collider2D skil43coll;

    private float poriadoksmeni;
    private float poriadoksmenith;
    private float poriadoksme;
    private float poriadok;
    private float poriad;
    private float pori;

    void Start()
    {
        slot1falsMish.SetActive(false);
        slot2falsMish.SetActive(false);
        slot3falsMish.SetActive(false);
        slot4falsMish.SetActive(false);
        slot5falsMish.SetActive(false);
        slot6falsMish.SetActive(false);
        slot7falsMish.SetActive(false);
        slot8falsMish.SetActive(false);
        slot9falsMish.SetActive(false);
        slot1falsMishVraga.SetActive(false);
        slot2falsMishVraga.SetActive(false);
        slot3falsMishVraga.SetActive(false);
        slot4falsMishVraga.SetActive(false);
        slot5falsMishVraga.SetActive(false);
        slot6falsMishVraga.SetActive(false);
        slot7falsMishVraga.SetActive(false);
        slot8falsMishVraga.SetActive(false);
        slot9falsMishVraga.SetActive(false);
        mishendemonVraga1.SetActive(false);
        mishendemonVraga2.SetActive(false);
        mishendemonVraga3.SetActive(false);
        mishendemonVraga4.SetActive(false);
        mishendemonVraga5.SetActive(false);
        mishendemonVraga6.SetActive(false);
        mishendemonVraga7.SetActive(false);
        mishendemonVraga8.SetActive(false);
        mishendemonVraga9.SetActive(false);
        mishendemonGG1.SetActive(false);
        mishendemonGG2.SetActive(false);
        mishendemonGG3.SetActive(false);
        mishendemonGG4.SetActive(false);
        mishendemonGG5.SetActive(false);
        mishendemonGG6.SetActive(false);
        mishendemonGG7.SetActive(false);
        mishendemonGG8.SetActive(false);
        mishendemonGG9.SetActive(false);
        additionBack.SetActive(false);
        additionBackVraga.SetActive(false);
        specialChildforBack.SetActive(false);
        mishenHolder.SetActive(false);
        mishenHolderVraga.SetActive(false);
        mishenHolderFals.SetActive(true);
        mishenHolderVragaFals.SetActive(true);

        // доступные мишени
        slot1mish.SetActive(false);
        slot2mish.SetActive(false);
        slot3mish.SetActive(false);
        slot4mish.SetActive(false);
        slot5mish.SetActive(false);
        slot6mish.SetActive(false);
        slot7mish.SetActive(false);
        slot8mish.SetActive(false);
        slot9mish.SetActive(false);
        slot1mishVraga.SetActive(false);
        slot2mishVraga.SetActive(false);
        slot3mishVraga.SetActive(false);
        slot4mishVraga.SetActive(false);
        slot5mishVraga.SetActive(false);
        slot6mishVraga.SetActive(false);
        slot7mishVraga.SetActive(false);
        slot8mishVraga.SetActive(false);
        slot9mishVraga.SetActive(false);
        // выбранные мишени
        slot1mishfull.SetActive(false);
        slot2mishfull.SetActive(false);
        slot3mishfull.SetActive(false);
        slot4mishfull.SetActive(false);
        slot5mishfull.SetActive(false);
        slot6mishfull.SetActive(false);
        slot7mishfull.SetActive(false);
        slot8mishfull.SetActive(false);
        slot9mishfull.SetActive(false);
        slot1mishVragafull.SetActive(false);
        slot2mishVragafull.SetActive(false);
        slot3mishVragafull.SetActive(false);
        slot4mishVragafull.SetActive(false);
        slot5mishVragafull.SetActive(false);
        slot6mishVragafull.SetActive(false);
        slot7mishVragafull.SetActive(false);
        slot8mishVragafull.SetActive(false);
        slot9mishVragafull.SetActive(false);
        podsvetTrigger1.SetActive(false);
        podsvetTrigger2.SetActive(false);
        podsvetTrigger3.SetActive(false);
        podsvetTrigger4.SetActive(false);
        podsvetTrigger5.SetActive(false);
        podsvetTrigger6.SetActive(false);
        podsvetTrigger7.SetActive(false);
        podsvetTrigger8.SetActive(false);
        podsvetTrigger9.SetActive(false);
        podsvetTrigger1Connected.SetActive(false);
        podsvetTrigger2Connected.SetActive(false);
        podsvetTrigger3Connected.SetActive(false);
        podsvetTrigger4Connected.SetActive(false);
        podsvetTrigger5Connected.SetActive(false);
        podsvetTrigger6Connected.SetActive(false);
        podsvetTrigger7Connected.SetActive(false);
        podsvetTrigger8Connected.SetActive(false);
        podsvetTrigger9Connected.SetActive(false);
        podsvetTrigger1Connected.transform.localEulerAngles = new Vector3(0f, 0f, Random.Range(0f, 360f));
        podsvetTrigger2Connected.transform.localEulerAngles = new Vector3(0f, 0f, Random.Range(0f, 360f));
        podsvetTrigger3Connected.transform.localEulerAngles = new Vector3(0f, 0f, Random.Range(0f, 360f));
        podsvetTrigger4Connected.transform.localEulerAngles = new Vector3(0f, 0f, Random.Range(0f, 360f));
        podsvetTrigger5Connected.transform.localEulerAngles = new Vector3(0f, 0f, Random.Range(0f, 360f));
        podsvetTrigger6Connected.transform.localEulerAngles = new Vector3(0f, 0f, Random.Range(0f, 360f));
        podsvetTrigger7Connected.transform.localEulerAngles = new Vector3(0f, 0f, Random.Range(0f, 360f));
        podsvetTrigger8Connected.transform.localEulerAngles = new Vector3(0f, 0f, Random.Range(0f, 360f));
        podsvetTrigger9Connected.transform.localEulerAngles = new Vector3(0f, 0f, Random.Range(0f, 360f));
    }

    void Update()
    {

        if (skills.skillsBack.activeSelf == false && battleModeVisibility.battleMode == true) // если скиллы отключены, то и описания и подсветки тоже для каждого скилла
        {
            Otkluchalka();
        }

        if (skills.skillsBack.activeSelf == true) // если мы работаем с навыками
        {

            Cheker();
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
                if (touch.phase == TouchPhase.Began && mishenHolder.activeSelf == true)
                {
                    // если тап внутри коллайдера мишени, то реакция. если нет, то этот режим выключается
                    if (slot1mishulala.bounds.Contains(touch.position))
                    {
                        zvukbudet = true;
                        // тут будет реакция см. войд тап
                        vybrMishen = slotGG1;
                    }
                    else if (slot2mishulala.bounds.Contains(touch.position))
                    {
                        zvukbudet = true;
                        // тут будет реакция см. войд тап
                        vybrMishen = slotGG2;
                    }
                    else if (slot3mishulala.bounds.Contains(touch.position))
                    {
                        zvukbudet = true;
                        // тут будет реакция см. войд тап
                        vybrMishen = slotGG3;
                    }
                    else if (slot4mishulala.bounds.Contains(touch.position))
                    {
                        zvukbudet = true;
                        // тут будет реакция см. войд тап
                        vybrMishen = slotGG4;
                    }
                    else if (slot5mishulala.bounds.Contains(touch.position))
                    {
                        zvukbudet = true;
                        // тут будет реакция см. войд тап
                        vybrMishen = slotGG5;
                    }
                    else if (slot6mishulala.bounds.Contains(touch.position))
                    {
                        zvukbudet = true;
                        // тут будет реакция см. войд тап
                        vybrMishen = slotGG6;
                    }
                    else if (slot7mishulala.bounds.Contains(touch.position))
                    {
                        zvukbudet = true;
                        // тут будет реакция см. войд тап
                        vybrMishen = slotGG7;
                    }
                    else if (slot8mishulala.bounds.Contains(touch.position))
                    {
                        zvukbudet = true;
                        // тут будет реакция см. войд тап
                        vybrMishen = slotGG8;
                    }
                    else if (slot9mishulala.bounds.Contains(touch.position))
                    {
                        zvukbudet = true;
                        // тут будет реакция см. войд тап
                        vybrMishen = slotGG9;
                    }
                    
                    else if (slot1mishVragaulala.bounds.Contains(touch.position))
                    {
                        zvukbudet = true;
                        // тут будет реакция см. войд тап
                        vybrMishen = slotVraga1;
                    }
                    else if (slot2mishVragaulala.bounds.Contains(touch.position))
                    {
                        zvukbudet = true;
                        // тут будет реакция см. войд тап
                        vybrMishen = slotVraga2;
                    }
                    else if (slot3mishVragaulala.bounds.Contains(touch.position))
                    {
                        zvukbudet = true;
                        // тут будет реакция см. войд тап
                        vybrMishen = slotVraga3;
                    }
                    else if (slot4mishVragaulala.bounds.Contains(touch.position))
                    {
                        zvukbudet = true;
                        // тут будет реакция см. войд тап
                        vybrMishen = slotVraga4;
                    }
                    else if (slot5mishVragaulala.bounds.Contains(touch.position))
                    {
                        zvukbudet = true;
                        // тут будет реакция см. войд тап
                        vybrMishen = slotVraga5;
                    }
                    else if (slot6mishVragaulala.bounds.Contains(touch.position))
                    {
                        zvukbudet = true;
                        // тут будет реакция см. войд тап
                        vybrMishen = slotVraga6;
                    }
                    else if (slot7mishVragaulala.bounds.Contains(touch.position))
                    {
                        zvukbudet = true;
                        // тут будет реакция см. войд тап
                        vybrMishen = slotVraga7;
                    }
                    else if (slot8mishVragaulala.bounds.Contains(touch.position))
                    {
                        zvukbudet = true;
                        // тут будет реакция см. войд тап
                        vybrMishen = slotVraga8;
                    }
                    else if (slot9mishVragaulala.bounds.Contains(touch.position))
                    {
                        zvukbudet = true;
                        // тут будет реакция см. войд тап
                        vybrMishen = slotVraga9;
                    }
                    else
                    {
                        zvukbudet = false;
                        vybrMishen = null;
                        movedSkill = null;
                        MishenOff();
                    }


                }
                if (touch.phase == TouchPhase.Began && mishenHolder.activeSelf == false) // если игрок тапает экран не в режиме мишеней
                {
                    CancelInvoke("MishenCaller");
                    doneOnce = true;
                    // чтоб касался по имени?
                    if (skil1coll.bounds.Contains(touch.position)) // если начали в сердце определённого навыка
                    {
                        specialtarget1 = null;
                        specialtarget2 = null;
                        specialtarget3 = null;
                        // + включение триггеров
                        podsvetTrigger1.SetActive(true);
                        podsvetTrigger2.SetActive(true);
                        podsvetTrigger3.SetActive(true);
                        podsvetTrigger5.SetActive(true);
                        podsvetTrigger1Connected.SetActive(true);
                        podsvetTrigger2Connected.SetActive(true);
                        podsvetTrigger3Connected.SetActive(true);
                        if (slots.slot5blocked.activeSelf == false)
                        {
                            podsvetTrigger5Connected.SetActive(true);
                        }
                        // читаем его
                        movedSkill = skil1;
                        slot1falsMishVraga.SetActive(true);
                        slot2falsMishVraga.SetActive(true);
                        slot3falsMishVraga.SetActive(true);
                        if (skBlok1.activeSelf == true)
                        {
                            // спавнит гены этого навыка

                            if (forLevel.languager == 0)
                            {
                                skills.nazvanieSkilla.text = "Silent threat \n Master a skill?";
                            }
                            else if (forLevel.languager == 1)
                            {
                                skills.nazvanieSkilla.text = "Немая угроза \n Освоить навык?";
                            }
                            else if (forLevel.languager == 2)
                            {
                                skills.nazvanieSkilla.text = "Німа загроза \n Освоїти вміння?";
                            }
                            skills.priceIkraSkill = 1f; // устанавливает цену
                            skills.Ikrun.SetActive(true); // вкл спайт икры
                            skills.skillPrice.text = skills.priceIkraSkill.ToString("F0"); // показывает цену
                            if (ikorka.ikra >= skills.priceIkraSkill) // если икры меньше, чем цена, галочка не спавнится. больше - спавнится
                            {
                                skills.yesPlease.SetActive(true);
                            }
                            else
                            {
                                skills.yesPlease.SetActive(false);
                            }
                            skills.megaBlock.SetActive(true);
                            skills.phonDescr.SetActive(true);
                            skills.priceIcons.SetActive(true);
                        }

                    }
                    else if (skil2coll.bounds.Contains(touch.position))
                    {
                        // если не наш (в зоне полей), откроется вражеский экран
                        specialtarget1 = null;
                        specialtarget2 = null;
                        specialtarget3 = null;
                        // + включение триггеров
                        podsvetTrigger1.SetActive(true);
                        podsvetTrigger2.SetActive(true);
                        podsvetTrigger3.SetActive(true);
                        podsvetTrigger5.SetActive(true);
                        podsvetTrigger1Connected.SetActive(true);
                        podsvetTrigger2Connected.SetActive(true);
                        podsvetTrigger3Connected.SetActive(true);
                        if (slots.slot5blocked.activeSelf == false)
                        {
                            podsvetTrigger5Connected.SetActive(true);
                        }

                        // читаем его
                        movedSkill = skil2;
                        slot4falsMishVraga.SetActive(true);
                        slot5falsMishVraga.SetActive(true);
                        slot6falsMishVraga.SetActive(true);
                        if (skBlok2.activeSelf == true)
                        {
                            // спавнит гены этого навыка
                            if (forLevel.languager == 0)
                            {
                                skills.nazvanieSkilla.text = "Aiming to hit \n Master a skill?";
                            }
                            else if (forLevel.languager == 1)
                            {
                                skills.nazvanieSkilla.text = "Замахивание для удара \n Освоить навык?";
                            }
                            else if (forLevel.languager == 2)
                            {
                                skills.nazvanieSkilla.text = "Замах для удару \n Освоїти вміння?";
                            }
                            skills.priceIkraSkill = 1f;
                            skills.Ikrun.SetActive(true);
                            skills.skillPrice.text = skills.priceIkraSkill.ToString("F0");
                            if (ikorka.ikra >= skills.priceIkraSkill)
                            {
                                skills.yesPlease.SetActive(true);
                            }
                            else
                            {
                                skills.yesPlease.SetActive(false);
                            }
                            skills.megaBlock.SetActive(true);
                            skills.phonDescr.SetActive(true);
                            skills.priceIcons.SetActive(true);
                        }
                    }
                    else if (skil3coll.bounds.Contains(touch.position))
                    {
                        specialtarget1 = null;
                        specialtarget2 = null;
                        specialtarget3 = null;
                        // + включение триггеров
                        podsvetTrigger1.SetActive(true);
                        podsvetTrigger2.SetActive(true);
                        podsvetTrigger3.SetActive(true);
                        podsvetTrigger5.SetActive(true);
                        podsvetTrigger1Connected.SetActive(true);
                        podsvetTrigger2Connected.SetActive(true);
                        podsvetTrigger3Connected.SetActive(true);
                        if (slots.slot5blocked.activeSelf == false)
                        {
                            podsvetTrigger5Connected.SetActive(true);
                        }
                        // читаем его
                        movedSkill = skil3;
                        slot7falsMishVraga.SetActive(true);
                        slot8falsMishVraga.SetActive(true);
                        slot9falsMishVraga.SetActive(true);
                        if (skBlok3.activeSelf == true)
                        {
                            // спавнит гены этого навыка
                            if (forLevel.languager == 0)
                            {
                                skills.nazvanieSkilla.text = "Flick \n Master a skill?";
                            }
                            else if (forLevel.languager == 1)
                            {
                                skills.nazvanieSkilla.text = "Резкое движение \n Освоить навык?";
                            }
                            else if (forLevel.languager == 2)
                            {
                                skills.nazvanieSkilla.text = "Різкий рух \n Освоїти вміння?";
                            }
                            skills.priceIkraSkill = 1f;
                            skills.Ikrun.SetActive(true);
                            skills.skillPrice.text = skills.priceIkraSkill.ToString("F0");
                            if (ikorka.ikra >= skills.priceIkraSkill)
                            {
                                skills.yesPlease.SetActive(true);
                            }
                            else
                            {
                                skills.yesPlease.SetActive(false);
                            }
                            skills.megaBlock.SetActive(true);
                            skills.phonDescr.SetActive(true);
                            skills.priceIcons.SetActive(true);
                        }
                    }
                    else if (skil4coll.bounds.Contains(touch.position))
                    {
                        specialtarget1 = null;
                        specialtarget2 = null;
                        specialtarget3 = null;
                        // + включение триггеров
                        podsvetTrigger1.SetActive(true);
                        podsvetTrigger2.SetActive(true);
                        podsvetTrigger3.SetActive(true);
                        podsvetTrigger1Connected.SetActive(true);
                        podsvetTrigger2Connected.SetActive(true);
                        podsvetTrigger3Connected.SetActive(true);
                        // читаем его
                        movedSkill = skil4;
                        slot1falsMishVraga.SetActive(true);
                        slot2falsMishVraga.SetActive(true);
                        slot3falsMishVraga.SetActive(true);
                        if (skBlok4.activeSelf == true)
                        {
                            // спавнит гены этого навыка
                            if (forLevel.languager == 0)
                            {
                                skills.nazvanieSkilla.text = "Distraction bait \n Master a skill?";
                            }
                            else if (forLevel.languager == 1)
                            {
                                skills.nazvanieSkilla.text = "Отвлечение прикормом \n Освоить навык?";
                            }
                            else if (forLevel.languager == 2)
                            {
                                skills.nazvanieSkilla.text = "Відволікання прикормом \n Освоїти вміння?";
                            }
                            skills.priceIkraSkill = 1f;
                            skills.Ikrun.SetActive(true);
                            skills.skillPrice.text = skills.priceIkraSkill.ToString("F0");
                            if (ikorka.ikra >= skills.priceIkraSkill)
                            {
                                skills.yesPlease.SetActive(true);
                            }
                            else
                            {
                                skills.yesPlease.SetActive(false);
                            }
                            skills.megaBlock.SetActive(true);
                            skills.phonDescr.SetActive(true);
                            skills.priceIcons.SetActive(true);
                        }
                    }
                    else if (skil5coll.bounds.Contains(touch.position))
                    {
                        specialtarget1 = null;
                        specialtarget2 = null;
                        specialtarget3 = null;
                        // + включение триггеров
                        podsvetTrigger4.SetActive(true);
                        podsvetTrigger5.SetActive(true);
                        podsvetTrigger6.SetActive(true);
                        if (slots.slot4blocked.activeSelf == false)
                        {
                            podsvetTrigger4Connected.SetActive(true);
                        }
                        if (slots.slot5blocked.activeSelf == false)
                        {
                            podsvetTrigger5Connected.SetActive(true);
                        }
                        if (slots.slot6blocked.activeSelf == false)
                        {
                            podsvetTrigger6Connected.SetActive(true);
                        }
                        // читаем его
                        movedSkill = skil5;
                        slot1falsMish.SetActive(true);
                        slot2falsMish.SetActive(true);
                        slot3falsMish.SetActive(true);
                        slot4falsMish.SetActive(true);
                        slot5falsMish.SetActive(true);
                        if (skBlok5.activeSelf == true)
                        {
                            // спавнит гены этого навыка
                            if (forLevel.languager == 0)
                            {
                                skills.nazvanieSkilla.text = "Vigilance \n Master a skill?";
                            }
                            else if (forLevel.languager == 1)
                            {
                                skills.nazvanieSkilla.text = "Бдительность \n Освоить навык?";
                            }
                            else if (forLevel.languager == 2)
                            {
                                skills.nazvanieSkilla.text = "Пильність \n Освоїти вміння?";
                            }

                            skills.priceIkraSkill = 2f;
                            skills.Ikrun.SetActive(true);
                            skills.skillPrice.text = skills.priceIkraSkill.ToString("F0");
                            if (ikorka.ikra >= skills.priceIkraSkill)
                            {
                                skills.yesPlease.SetActive(true);
                            }
                            else
                            {
                                skills.yesPlease.SetActive(false);
                            }
                            skills.megaBlock.SetActive(true);
                            skills.phonDescr.SetActive(true);
                            skills.priceIcons.SetActive(true);
                        }
                    }
                    else if (skil6coll.bounds.Contains(touch.position))
                    {
                        specialtarget1 = null;
                        specialtarget2 = null;
                        specialtarget3 = null;

                        // + включение триггеров
                        podsvetTrigger4.SetActive(true);
                        podsvetTrigger6.SetActive(true);
                        podsvetTrigger7.SetActive(true);
                        podsvetTrigger8.SetActive(true);
                        podsvetTrigger9.SetActive(true);
                        if (slots.slot4blocked.activeSelf == false)
                        {
                            podsvetTrigger4Connected.SetActive(true);
                        }
                        if (slots.slot6blocked.activeSelf == false)
                        {
                            podsvetTrigger6Connected.SetActive(true);
                        }
                        if (slots.slot7blocked.activeSelf == false)
                        {
                            podsvetTrigger7Connected.SetActive(true);
                        }
                        if (slots.slot8blocked.activeSelf == false)
                        {
                            podsvetTrigger8Connected.SetActive(true);
                        }
                        if (slots.slot9blocked.activeSelf == false)
                        {
                            podsvetTrigger9Connected.SetActive(true);
                        }

                        // читаем его
                        movedSkill = skil6;

                        slot1falsMish.SetActive(true);
                        slot3falsMish.SetActive(true);
                        slot4falsMish.SetActive(true);
                        slot5falsMish.SetActive(true);
                        slot6falsMish.SetActive(true);
                        if (skBlok6.activeSelf == true)
                        {
                            // спавнит гены этого навыка
                            if (forLevel.languager == 0)
                            {
                                skills.nazvanieSkilla.text = "A breath of calm \n Master a skill?";
                            }
                            else if (forLevel.languager == 1)
                            {
                                skills.nazvanieSkilla.text = "Глоток успокоения \n Освоить навык?";
                            }
                            else if (forLevel.languager == 2)
                            {
                                skills.nazvanieSkilla.text = "Ковток для заспокоєння \n Освоїти вміння?";
                            }
                            skills.priceIkraSkill = 2f;
                            skills.Ikrun.SetActive(true);
                            skills.skillPrice.text = skills.priceIkraSkill.ToString("F0");
                            if (ikorka.ikra >= skills.priceIkraSkill)
                            {
                                skills.yesPlease.SetActive(true);
                            }
                            else
                            {
                                skills.yesPlease.SetActive(false);
                            }
                            skills.megaBlock.SetActive(true);
                            skills.phonDescr.SetActive(true);
                            skills.priceIcons.SetActive(true);
                        }

                    }

                    else if (skil8coll.bounds.Contains(touch.position))
                    {
                        specialtarget1 = null;
                        specialtarget2 = null;
                        specialtarget3 = null;
                        // + включение триггеров
                        podsvetTrigger4.SetActive(true);
                        podsvetTrigger6.SetActive(true);
                        podsvetTrigger7.SetActive(true);
                        podsvetTrigger8.SetActive(true);
                        podsvetTrigger9.SetActive(true);
                        if (slots.slot4blocked.activeSelf == false)
                        {
                            podsvetTrigger4Connected.SetActive(true);
                        }
                        if (slots.slot6blocked.activeSelf == false)
                        {
                            podsvetTrigger6Connected.SetActive(true);
                        }
                        if (slots.slot7blocked.activeSelf == false)
                        {
                            podsvetTrigger7Connected.SetActive(true);
                        }
                        if (slots.slot8blocked.activeSelf == false)
                        {
                            podsvetTrigger8Connected.SetActive(true);
                        }
                        if (slots.slot9blocked.activeSelf == false)
                        {
                            podsvetTrigger9Connected.SetActive(true);
                        }
                        // читаем его
                        movedSkill = skil8;

                        slot1falsMish.SetActive(true);
                        slot3falsMish.SetActive(true);
                        slot4falsMish.SetActive(true);
                        slot5falsMish.SetActive(true);
                        slot6falsMish.SetActive(true);
                        if (skBlok8.activeSelf == true)
                        {
                            // спавнит гены этого навыка
                            if (forLevel.languager == 0)
                            {
                                skills.nazvanieSkilla.text = "Dream of life \n Master a skill?";
                            }
                            else if (forLevel.languager == 1)
                            {
                                skills.nazvanieSkilla.text = "Мечта о жизни \n Освоить навык?";
                            }
                            else if (forLevel.languager == 2)
                            {
                                skills.nazvanieSkilla.text = "Мрія про життя \n Освоїти вміння?";
                            }
                            skills.priceIkraSkill = 2f;
                            skills.Ikrun.SetActive(true);
                            skills.skillPrice.text = skills.priceIkraSkill.ToString("F0");
                            if (ikorka.ikra >= skills.priceIkraSkill)
                            {
                                skills.yesPlease.SetActive(true);
                            }
                            else
                            {
                                skills.yesPlease.SetActive(false);
                            }
                            skills.megaBlock.SetActive(true);
                            skills.phonDescr.SetActive(true);
                            skills.priceIcons.SetActive(true);
                        }
                    }
                    else if (skil9coll.bounds.Contains(touch.position))
                    {
                        specialtarget1 = null;
                        specialtarget2 = null;
                        specialtarget3 = null;
                        // + включение триггеров
                        podsvetTrigger7.SetActive(true);
                        podsvetTrigger8.SetActive(true);
                        podsvetTrigger9.SetActive(true);
                        if (slots.slot7blocked.activeSelf == false)
                        {
                            podsvetTrigger7Connected.SetActive(true);
                        }
                        if (slots.slot8blocked.activeSelf == false)
                        {
                            podsvetTrigger8Connected.SetActive(true);
                        }
                        if (slots.slot9blocked.activeSelf == false)
                        {
                            podsvetTrigger9Connected.SetActive(true);
                        }
                        // читаем его
                        movedSkill = skil9;
                        slot7falsMishVraga.SetActive(true);
                        slot8falsMishVraga.SetActive(true);
                        slot9falsMishVraga.SetActive(true);
                        if (skBlok9.activeSelf == true)
                        {
                            // спавнит гены этого навыка
                            if (forLevel.languager == 0)
                            {
                                skills.nazvanieSkilla.text = "Hypnotic dance \n Master a skill?";
                            }
                            else if (forLevel.languager == 1)
                            {
                                skills.nazvanieSkilla.text = "Гипнотический танец \n Освоить навык?";
                            }
                            else if (forLevel.languager == 2)
                            {
                                skills.nazvanieSkilla.text = "Гіпнотичний танець \n Освоїти вміння?";
                            }
                            skills.priceIkraSkill = 1f;
                            skills.Ikrun.SetActive(true);
                            skills.skillPrice.text = skills.priceIkraSkill.ToString("F0");
                            if (ikorka.ikra >= skills.priceIkraSkill)
                            {
                                skills.yesPlease.SetActive(true);
                            }
                            else
                            {
                                skills.yesPlease.SetActive(false);
                            }
                            skills.megaBlock.SetActive(true);
                            skills.phonDescr.SetActive(true);
                            skills.priceIcons.SetActive(true);
                        }
                    }


                    else if (skil10 != null && skil10coll.bounds.Contains(touch.position))
                    {
                        specialtarget1 = null;
                        specialtarget2 = null;
                        specialtarget3 = null;
                        // + включение триггеров
                        podsvetTrigger2.SetActive(true);
                        podsvetTrigger4.SetActive(true);
                        podsvetTrigger6.SetActive(true);
                        if (slots.slot2blocked.activeSelf == false)
                        {
                            podsvetTrigger2Connected.SetActive(true);
                        }
                        if (slots.slot4blocked.activeSelf == false)
                        {
                            podsvetTrigger4Connected.SetActive(true);
                        }
                        if (slots.slot6blocked.activeSelf == false)
                        {
                            podsvetTrigger6Connected.SetActive(true);
                        }
                        // читаем его
                        movedSkill = skil10;
                        slot9falsMish.SetActive(true);
                        slot5falsMish.SetActive(true);
                        slot8falsMish.SetActive(true);
                        slot7falsMish.SetActive(true);
                        if (skBlok10.activeSelf == true)
                        {
                            // спавнит гены этого навыка
                            // Instantiate(mermaids.RedPigment, genus1.transform.position, Quaternion.identity, genus1.transform);


                            if (forLevel.languager == 0)
                            {
                                skills.nazvanieSkilla.text = "Competence in anatomy \n Master a skill?";
                            }
                            else if (forLevel.languager == 1)
                            {
                                skills.nazvanieSkilla.text = "Знание анатомии \n Освоить навык?";
                            }
                            else if (forLevel.languager == 2)
                            {
                                skills.nazvanieSkilla.text = "Знання анатомії \n Освоїти вміння?";
                            }
                            skills.priceIkraSkill = 2f;
                            skills.Ikrun.SetActive(true);
                            skills.skillPrice.text = skills.priceIkraSkill.ToString("F0");
                            if (ikorka.ikra >= skills.priceIkraSkill)
                            {
                                skills.yesPlease.SetActive(true);
                            }
                            else
                            {
                                skills.yesPlease.SetActive(false);
                            }
                            skills.megaBlock.SetActive(true);
                            skills.phonDescr.SetActive(true);
                            skills.priceIcons.SetActive(true);
                        }
                    }
                    else if (skil11 != null && skil11coll.bounds.Contains(touch.position))
                    {
                        specialtarget1 = null;
                        specialtarget2 = null;
                        specialtarget3 = null;
                        // + включение триггеров
                        podsvetTrigger1.SetActive(true);
                        podsvetTrigger3.SetActive(true);
                        podsvetTrigger5.SetActive(true);
                        if (slots.slot1blocked.activeSelf == false)
                        {
                            podsvetTrigger1Connected.SetActive(true);
                        }
                        if (slots.slot3blocked.activeSelf == false)
                        {
                            podsvetTrigger3Connected.SetActive(true);
                        }
                        if (slots.slot5blocked.activeSelf == false)
                        {
                            podsvetTrigger5Connected.SetActive(true);
                        }
                        // читаем его
                        movedSkill = skil11;
                        slot6falsMish.SetActive(true);
                        slot9falsMish.SetActive(true);
                        slot4falsMish.SetActive(true);
                        slot7falsMish.SetActive(true);
                        slot8falsMish.SetActive(true);
                        if (skBlok11.activeSelf == true)
                        {
                            // спавнит гены этого навыка
                            // Instantiate(mermaids.RedPigment, genus1.transform.position, Quaternion.identity, genus1.transform);


                            if (forLevel.languager == 0)
                            {
                                skills.nazvanieSkilla.text = "Comprehensive recovery \n Master a skill?";
                            }
                            else if (forLevel.languager == 1)
                            {
                                skills.nazvanieSkilla.text = "Полное восстановление \n Освоить навык?";
                            }
                            else if (forLevel.languager == 2)
                            {
                                skills.nazvanieSkilla.text = "Комплексне відновлення \n Освоїти вміння?";
                            }
                            skills.priceIkraSkill = 2f;
                            skills.Ikrun.SetActive(true);
                            skills.skillPrice.text = skills.priceIkraSkill.ToString("F0");
                            if (ikorka.ikra >= skills.priceIkraSkill)
                            {
                                skills.yesPlease.SetActive(true);
                            }
                            else
                            {
                                skills.yesPlease.SetActive(false);
                            }
                            skills.megaBlock.SetActive(true);
                            skills.phonDescr.SetActive(true);
                            skills.priceIcons.SetActive(true);
                        }
                    }
                    else if (skil12 != null && skil12coll.bounds.Contains(touch.position))
                    {
                        specialtarget1 = null;
                        specialtarget2 = null;
                        specialtarget3 = null;
                        // + включение триггеров
                        podsvetTrigger4.SetActive(true);
                        podsvetTrigger5.SetActive(true);
                        podsvetTrigger6.SetActive(true);
                        if (slots.slot4blocked.activeSelf == false)
                        {
                            podsvetTrigger4Connected.SetActive(true);
                        }
                        if (slots.slot5blocked.activeSelf == false)
                        {
                            podsvetTrigger5Connected.SetActive(true);
                        }
                        if (slots.slot6blocked.activeSelf == false)
                        {
                            podsvetTrigger6Connected.SetActive(true);
                        }
                        // читаем его
                        movedSkill = skil12;
                        slot5falsMish.SetActive(true);
                        slot6falsMish.SetActive(true);
                        slot7falsMish.SetActive(true);
                        slot8falsMish.SetActive(true);
                        slot9falsMish.SetActive(true);
                        if (skBlok12.activeSelf == true)
                        {
                            // спавнит гены этого навыка
                            // Instantiate(mermaids.Prozrachnost, genus1.transform.position, Quaternion.identity, genus1.transform);
                            if (forLevel.languager == 0)
                            {
                                skills.nazvanieSkilla.text = "Invisibility \n Master a skill?";
                            }
                            else if (forLevel.languager == 1)
                            {
                                skills.nazvanieSkilla.text = "Невидимость \n Освоить навык?";
                            }
                            else if (forLevel.languager == 2)
                            {
                                skills.nazvanieSkilla.text = "Невидимість \n Освоїти вміння?";
                            }

                            skills.priceIkraSkill = 2f;
                            skills.Ikrun.SetActive(true);
                            skills.skillPrice.text = skills.priceIkraSkill.ToString("F0");
                            if (ikorka.ikra >= skills.priceIkraSkill)
                            {
                                skills.yesPlease.SetActive(true);
                            }
                            else
                            {
                                skills.yesPlease.SetActive(false);
                            }
                            skills.megaBlock.SetActive(true);
                            skills.phonDescr.SetActive(true);
                            skills.priceIcons.SetActive(true);
                        }
                    }
                    else if (skil13 != null && skil13coll.bounds.Contains(touch.position))
                    {
                        specialtarget1 = null;
                        specialtarget2 = null;
                        specialtarget3 = null;
                        // + включение триггеров
                        podsvetTrigger4.SetActive(true);
                        podsvetTrigger6.SetActive(true);
                        if (slots.slot4blocked.activeSelf == false)
                        {
                            podsvetTrigger4Connected.SetActive(true);
                        }
                        if (slots.slot6blocked.activeSelf == false)
                        {
                            podsvetTrigger6Connected.SetActive(true);
                        }
                        // читаем его
                        movedSkill = skil13;
                        slot1falsMishVraga.SetActive(true);
                        slot4falsMishVraga.SetActive(true);
                        slot7falsMishVraga.SetActive(true);
                        slot3falsMishVraga.SetActive(true);
                        slot6falsMishVraga.SetActive(true);
                        slot9falsMishVraga.SetActive(true);
                        if (skBlok13.activeSelf == true)
                        {
                            // спавнит гены этого навыка
                            // Instantiate(mermaids.ChernyyPigment, genus1.transform.position, Quaternion.identity, genus1.transform);
                            if (forLevel.languager == 0)
                            {
                                skills.nazvanieSkilla.text = "A weak point detection \n Master a skill?";
                            }
                            else if (forLevel.languager == 1)
                            {
                                skills.nazvanieSkilla.text = "Поиск слабого места \n Освоить навык?";
                            }
                            else if (forLevel.languager == 2)
                            {
                                skills.nazvanieSkilla.text = "Пошук слабкого місця \n Освоїти вміння?";
                            }

                            skills.priceIkraSkill = 1f;
                            skills.Ikrun.SetActive(true);
                            skills.skillPrice.text = skills.priceIkraSkill.ToString("F0");
                            if (ikorka.ikra >= skills.priceIkraSkill)
                            {
                                skills.yesPlease.SetActive(true);
                            }
                            else
                            {
                                skills.yesPlease.SetActive(false);
                            }
                            skills.megaBlock.SetActive(true);
                            skills.phonDescr.SetActive(true);
                            skills.priceIcons.SetActive(true);
                        }
                    }
                    else if (skil14 != null && skil14coll.bounds.Contains(touch.position))
                    {
                        specialtarget1 = null;
                        specialtarget2 = null;
                        specialtarget3 = null;
                        // + включение триггеров
                        podsvetTrigger7.SetActive(true);
                        podsvetTrigger9.SetActive(true);
                        if (slots.slot7blocked.activeSelf == false)
                        {
                            podsvetTrigger7Connected.SetActive(true);
                        }
                        if (slots.slot9blocked.activeSelf == false)
                        {
                            podsvetTrigger9Connected.SetActive(true);
                        }
                        // читаем его
                        movedSkill = skil14;
                        slot1falsMishVraga.SetActive(true);
                        slot4falsMishVraga.SetActive(true);
                        slot7falsMishVraga.SetActive(true);
                        slot3falsMishVraga.SetActive(true);
                        slot6falsMishVraga.SetActive(true);
                        slot9falsMishVraga.SetActive(true);
                        if (skBlok14.activeSelf == true)
                        {
                            // спавнит гены этого навыка
                            // Instantiate(mermaids.ChernyyPigment, genus1.transform.position, Quaternion.identity, genus1.transform);
                            if (forLevel.languager == 0)
                            {
                                skills.nazvanieSkilla.text = "Merging with darkness \n Master a skill?";
                            }
                            else if (forLevel.languager == 1)
                            {
                                skills.nazvanieSkilla.text = "Слияние с тьмой \n Освоить навык?";
                            }
                            else if (forLevel.languager == 2)
                            {
                                skills.nazvanieSkilla.text = "Злиття з пітьмою \n Освоїти вміння?";
                            }

                            skills.priceIkraSkill = 1f;
                            skills.Ikrun.SetActive(true);
                            skills.skillPrice.text = skills.priceIkraSkill.ToString("F0");
                            if (ikorka.ikra >= skills.priceIkraSkill)
                            {
                                skills.yesPlease.SetActive(true);
                            }
                            else
                            {
                                skills.yesPlease.SetActive(false);
                            }
                            skills.megaBlock.SetActive(true);
                            skills.phonDescr.SetActive(true);
                            skills.priceIcons.SetActive(true);
                        }
                    }
                    else if (skil15 != null && skil15coll.bounds.Contains(touch.position))
                    {
                        specialtarget1 = null;
                        specialtarget2 = null;
                        specialtarget3 = null;
                        // + включение триггеров
                        podsvetTrigger4.SetActive(true);
                        podsvetTrigger5.SetActive(true);
                        podsvetTrigger6.SetActive(true);
                        if (slots.slot4blocked.activeSelf == false)
                        {
                            podsvetTrigger4Connected.SetActive(true);
                        }
                        if (slots.slot5blocked.activeSelf == false)
                        {
                            podsvetTrigger5Connected.SetActive(true);
                        }
                        if (slots.slot6blocked.activeSelf == false)
                        {
                            podsvetTrigger6Connected.SetActive(true);
                        }
                        // читаем его
                        movedSkill = skil15;
                        slot4falsMishVraga.SetActive(true);
                        slot5falsMishVraga.SetActive(true);
                        slot6falsMishVraga.SetActive(true);
                        if (skBlok15.activeSelf == true)
                        {
                            // спавнит гены этого навыка
                            // Instantiate(mermaids.Luminiscencia, genus1.transform.position, Quaternion.identity, genus1.transform);
                            if (forLevel.languager == 0)
                            {
                                skills.nazvanieSkilla.text = "Blinding camouflage \n Master a skill?";
                            }
                            else if (forLevel.languager == 1)
                            {
                                skills.nazvanieSkilla.text = "Ослепляющий камуфляж \n Освоить навык?";
                            }
                            else if (forLevel.languager == 2)
                            {
                                skills.nazvanieSkilla.text = "Сліпучий камуфляж \n Освоїти вміння?";
                            }

                            skills.priceIkraSkill = 1f;
                            skills.Ikrun.SetActive(true);
                            skills.skillPrice.text = skills.priceIkraSkill.ToString("F0");
                            if (ikorka.ikra >= skills.priceIkraSkill)
                            {
                                skills.yesPlease.SetActive(true);
                            }
                            else
                            {
                                skills.yesPlease.SetActive(false);
                            }
                            skills.megaBlock.SetActive(true);
                            skills.phonDescr.SetActive(true);
                            skills.priceIcons.SetActive(true);
                        }
                    }
                    else if (skil16 != null && skil16coll.bounds.Contains(touch.position))
                    {
                        specialtarget1 = null;
                        specialtarget2 = null;
                        specialtarget3 = null;
                        // + включение триггеров
                        podsvetTrigger7.SetActive(true);
                        podsvetTrigger8.SetActive(true);
                        podsvetTrigger9.SetActive(true);
                        if (slots.slot7blocked.activeSelf == false)
                        {
                            podsvetTrigger7Connected.SetActive(true);
                        }
                        if (slots.slot8blocked.activeSelf == false)
                        {
                            podsvetTrigger8Connected.SetActive(true);
                        }
                        if (slots.slot9blocked.activeSelf == false)
                        {
                            podsvetTrigger9Connected.SetActive(true);
                        }
                        // читаем его
                        movedSkill = skil16;
                        slot7falsMishVraga.SetActive(true);
                        slot8falsMishVraga.SetActive(true);
                        slot9falsMishVraga.SetActive(true);
                        slot4falsMishVraga.SetActive(true);
                        slot5falsMishVraga.SetActive(true);
                        slot6falsMishVraga.SetActive(true);
                        if (skBlok16.activeSelf == true)
                        {
                            // спавнит гены этого навыка
                            // Instantiate(mermaids.Cirri, genus1.transform.position, Quaternion.identity, genus1.transform);
                            if (forLevel.languager == 0)
                            {
                                skills.nazvanieSkilla.text = "Puncture \n Master a skill?";
                            }
                            else if (forLevel.languager == 1)
                            {
                                skills.nazvanieSkilla.text = "Укол \n Освоить навык?";
                            }
                            else if (forLevel.languager == 2)
                            {
                                skills.nazvanieSkilla.text = "Укол \n Освоїти вміння?";
                            }

                            skills.priceIkraSkill = 4f;
                            skills.Ikrun.SetActive(true);
                            skills.skillPrice.text = skills.priceIkraSkill.ToString("F0");
                            if (ikorka.ikra >= skills.priceIkraSkill)
                            {
                                skills.yesPlease.SetActive(true);
                            }
                            else
                            {
                                skills.yesPlease.SetActive(false);
                            }
                            skills.megaBlock.SetActive(true);
                            skills.phonDescr.SetActive(true);
                            skills.priceIcons.SetActive(true);
                        }
                    }
                    else if (skil17 != null && skil17coll.bounds.Contains(touch.position))
                    {
                        specialtarget1 = null;
                        specialtarget2 = null;
                        specialtarget3 = null;
                        // + включение триггеров
                        podsvetTrigger1.SetActive(true);
                        podsvetTrigger2.SetActive(true);
                        podsvetTrigger3.SetActive(true);
                        if (slots.slot1blocked.activeSelf == false)
                        {
                            podsvetTrigger1Connected.SetActive(true);
                        }
                        if (slots.slot2blocked.activeSelf == false)
                        {
                            podsvetTrigger2Connected.SetActive(true);
                        }
                        if (slots.slot3blocked.activeSelf == false)
                        {
                            podsvetTrigger3Connected.SetActive(true);
                        }
                        // читаем его
                        movedSkill = skil17;
                        slot1falsMishVraga.SetActive(true);
                        slot2falsMishVraga.SetActive(true);
                        slot3falsMishVraga.SetActive(true);
                        slot4falsMishVraga.SetActive(true);
                        slot5falsMishVraga.SetActive(true);
                        slot6falsMishVraga.SetActive(true);
                        if (skBlok17.activeSelf == true)
                        {
                            // спавнит гены этого навыка
                            // Instantiate(mermaids.Pedicellariy, genus1.transform.position, Quaternion.identity, genus1.transform);
                            if (forLevel.languager == 0)
                            {
                                skills.nazvanieSkilla.text = "Pinch \n Master a skill?";
                            }
                            else if (forLevel.languager == 1)
                            {
                                skills.nazvanieSkilla.text = "Щипок \n Освоить навык?";
                            }
                            else if (forLevel.languager == 2)
                            {
                                skills.nazvanieSkilla.text = "Щипок \n Освоїти вміння?";
                            }

                            skills.priceIkraSkill = 4f;
                            skills.Ikrun.SetActive(true);
                            skills.skillPrice.text = skills.priceIkraSkill.ToString("F0");
                            if (ikorka.ikra >= skills.priceIkraSkill)
                            {
                                skills.yesPlease.SetActive(true);
                            }
                            else
                            {
                                skills.yesPlease.SetActive(false);
                            }
                            skills.megaBlock.SetActive(true);
                            skills.phonDescr.SetActive(true);
                            skills.priceIcons.SetActive(true);
                        }
                    }
                    else if (skil18 != null && skil18coll.bounds.Contains(touch.position))
                    {
                        specialtarget1 = null;
                        specialtarget2 = null;
                        specialtarget3 = null;
                        // + включение триггеров
                        podsvetTrigger1.SetActive(true);
                        podsvetTrigger2.SetActive(true);
                        podsvetTrigger3.SetActive(true);
                        if (slots.slot1blocked.activeSelf == false)
                        {
                            podsvetTrigger1Connected.SetActive(true);
                        }
                        if (slots.slot2blocked.activeSelf == false)
                        {
                            podsvetTrigger2Connected.SetActive(true);
                        }
                        if (slots.slot3blocked.activeSelf == false)
                        {
                            podsvetTrigger3Connected.SetActive(true);
                        }
                        // читаем его
                        movedSkill = skil18;
                        slot1falsMish.SetActive(true);
                        slot2falsMish.SetActive(true);
                        slot3falsMish.SetActive(true);
                        slot4falsMish.SetActive(true);
                        slot5falsMish.SetActive(true);
                        slot6falsMish.SetActive(true);
                        if (skBlok18.activeSelf == true)
                        {
                            // спавнит гены этого навыка
                            // Instantiate(mermaids.Pedicellariy, genus1.transform.position, Quaternion.identity, genus1.transform);
                            if (forLevel.languager == 0)
                            {
                                skills.nazvanieSkilla.text = "Bacteria cleansing \n Master a skill?";
                            }
                            else if (forLevel.languager == 1)
                            {
                                skills.nazvanieSkilla.text = "Очищение от бактерий \n Освоить навык?";
                            }
                            else if (forLevel.languager == 2)
                            {
                                skills.nazvanieSkilla.text = "Очищення від бактерій \n Освоїти вміння?";
                            }

                            skills.priceIkraSkill = 3f;
                            skills.Ikrun.SetActive(true);
                            skills.skillPrice.text = skills.priceIkraSkill.ToString("F0");
                            if (ikorka.ikra >= skills.priceIkraSkill)
                            {
                                skills.yesPlease.SetActive(true);
                            }
                            else
                            {
                                skills.yesPlease.SetActive(false);
                            }
                            skills.megaBlock.SetActive(true);
                            skills.phonDescr.SetActive(true);
                            skills.priceIcons.SetActive(true);
                        }
                    }
                    else if (skil19 != null && skil19coll.bounds.Contains(touch.position))
                    {
                        specialtarget1 = null;
                        specialtarget2 = null;
                        specialtarget3 = null;
                        // + включение триггеров
                        podsvetTrigger4.SetActive(true);
                        podsvetTrigger5.SetActive(true);
                        podsvetTrigger6.SetActive(true);
                        if (slots.slot4blocked.activeSelf == false)
                        {
                            podsvetTrigger4Connected.SetActive(true);
                        }
                        if (slots.slot5blocked.activeSelf == false)
                        {
                            podsvetTrigger5Connected.SetActive(true);
                        }
                        if (slots.slot6blocked.activeSelf == false)
                        {
                            podsvetTrigger6Connected.SetActive(true);
                        }
                        // читаем его
                        movedSkill = skil19;
                        slot1falsMishVraga.SetActive(true);
                        slot2falsMishVraga.SetActive(true);
                        slot3falsMishVraga.SetActive(true);
                        slot4falsMishVraga.SetActive(true);
                        slot5falsMishVraga.SetActive(true);
                        slot6falsMishVraga.SetActive(true);
                        slot7falsMishVraga.SetActive(true);
                        slot8falsMishVraga.SetActive(true);
                        slot9falsMishVraga.SetActive(true);
                        if (skBlok19.activeSelf == true)
                        {
                            // спавнит гены этого навыка
                            // Instantiate(mermaids.Prisosky, genus1.transform.position, Quaternion.identity, genus1.transform);
                            if (forLevel.languager == 0)
                            {
                                skills.nazvanieSkilla.text = "Tentacle tenacity \n Master a skill?";
                            }
                            else if (forLevel.languager == 1)
                            {
                                skills.nazvanieSkilla.text = "Цепкость щупалец \n Освоить навык?";
                            }
                            else if (forLevel.languager == 2)
                            {
                                skills.nazvanieSkilla.text = "Чіпкість щупалець \n Освоїти вміння?";
                            }

                            skills.priceIkraSkill = 3f;
                            skills.Ikrun.SetActive(true);
                            skills.skillPrice.text = skills.priceIkraSkill.ToString("F0");
                            if (ikorka.ikra >= skills.priceIkraSkill)
                            {
                                skills.yesPlease.SetActive(true);
                            }
                            else
                            {
                                skills.yesPlease.SetActive(false);
                            }
                            skills.megaBlock.SetActive(true);
                            skills.phonDescr.SetActive(true);
                            skills.priceIcons.SetActive(true);
                        }
                    }
                    else if (skil20 != null && skil20coll.bounds.Contains(touch.position))
                    {
                        specialtarget1 = null;
                        specialtarget2 = null;
                        specialtarget3 = null;
                        // + включение триггеров
                        podsvetTrigger1.SetActive(true);
                        podsvetTrigger3.SetActive(true);
                        podsvetTrigger6.SetActive(true);
                        if (slots.slot1blocked.activeSelf == false)
                        {
                            podsvetTrigger1Connected.SetActive(true);
                        }
                        if (slots.slot3blocked.activeSelf == false)
                        {
                            podsvetTrigger3Connected.SetActive(true);
                        }
                        if (slots.slot6blocked.activeSelf == false)
                        {
                            podsvetTrigger6Connected.SetActive(true);
                        }
                        // читаем его
                        movedSkill = skil20;
                        slot1falsMish.SetActive(true);
                        slot6falsMish.SetActive(true);
                        slot3falsMish.SetActive(true);
                        slot1falsMishVraga.SetActive(true);
                        slot2falsMishVraga.SetActive(true);
                        slot3falsMishVraga.SetActive(true);
                        slot4falsMishVraga.SetActive(true);
                        slot5falsMishVraga.SetActive(true);
                        slot6falsMishVraga.SetActive(true);
                        slot7falsMishVraga.SetActive(true);
                        slot8falsMishVraga.SetActive(true);
                        slot9falsMishVraga.SetActive(true);
                        if (skBlok20.activeSelf == true)
                        {
                            // спавнит гены этого навыка
                            // Instantiate(mermaids.Regeneration, genus1.transform.position, Quaternion.identity, genus1.transform);
                            if (forLevel.languager == 0)
                            {
                                skills.nazvanieSkilla.text = "Autotomy \n Master a skill?";
                            }
                            else if (forLevel.languager == 1)
                            {
                                skills.nazvanieSkilla.text = "Автотомия \n Освоить навык?";
                            }
                            else if (forLevel.languager == 2)
                            {
                                skills.nazvanieSkilla.text = "Автотомія \n Освоїти вміння?";
                            }

                            skills.priceIkraSkill = 3f;
                            skills.Ikrun.SetActive(true);
                            skills.skillPrice.text = skills.priceIkraSkill.ToString("F0");
                            if (ikorka.ikra >= skills.priceIkraSkill)
                            {
                                skills.yesPlease.SetActive(true);
                            }
                            else
                            {
                                skills.yesPlease.SetActive(false);
                            }
                            skills.megaBlock.SetActive(true);
                            skills.phonDescr.SetActive(true);
                            skills.priceIcons.SetActive(true);
                        }
                    }
                    else if (skil21 != null && skil21coll.bounds.Contains(touch.position))
                    {
                        specialtarget1 = null;
                        specialtarget2 = null;
                        specialtarget3 = null;
                        // + включение триггеров
                        podsvetTrigger1.SetActive(true);
                        podsvetTrigger2.SetActive(true);
                        podsvetTrigger3.SetActive(true);
                        podsvetTrigger4.SetActive(true);
                        podsvetTrigger6.SetActive(true);
                        podsvetTrigger7.SetActive(true);
                        podsvetTrigger9.SetActive(true);
                        if (slots.slot1blocked.activeSelf == false)
                        {
                            podsvetTrigger1Connected.SetActive(true);
                        }
                        if (slots.slot2blocked.activeSelf == false)
                        {
                            podsvetTrigger2Connected.SetActive(true);
                        }
                        if (slots.slot3blocked.activeSelf == false)
                        {
                            podsvetTrigger3Connected.SetActive(true);
                        }
                        if (slots.slot4blocked.activeSelf == false)
                        {
                            podsvetTrigger4Connected.SetActive(true);
                        }
                        if (slots.slot6blocked.activeSelf == false)
                        {
                            podsvetTrigger6Connected.SetActive(true);
                        }
                        if (slots.slot7blocked.activeSelf == false)
                        {
                            podsvetTrigger7Connected.SetActive(true);
                        }
                        if (slots.slot9blocked.activeSelf == false)
                        {
                            podsvetTrigger9Connected.SetActive(true);
                        }
                        // читаем его
                        movedSkill = skil21;
                        slot1falsMish.SetActive(true);
                        slot2falsMish.SetActive(true);
                        slot3falsMish.SetActive(true);
                        slot4falsMish.SetActive(true);
                        slot6falsMish.SetActive(true);
                        slot7falsMish.SetActive(true);
                        slot9falsMish.SetActive(true);
                        slot1falsMishVraga.SetActive(true);
                        slot2falsMishVraga.SetActive(true);
                        slot3falsMishVraga.SetActive(true);
                        slot4falsMishVraga.SetActive(true);
                        slot6falsMishVraga.SetActive(true);
                        slot7falsMishVraga.SetActive(true);
                        slot9falsMishVraga.SetActive(true);
                        if (skBlok21.activeSelf == true)
                        {
                            // спавнит гены этого навыка
                            // Instantiate(mermaids.Zuby, genus1.transform.position, Quaternion.identity, genus1.transform);
                            if (forLevel.languager == 0)
                            {
                                skills.nazvanieSkilla.text = "Bite \n Master a skill?";
                            }
                            else if (forLevel.languager == 1)
                            {
                                skills.nazvanieSkilla.text = "Укус \n Освоить навык?";
                            }
                            else if (forLevel.languager == 2)
                            {
                                skills.nazvanieSkilla.text = "Укус \n Освоїти вміння?";
                            }

                            skills.priceIkraSkill = 5f;
                            skills.Ikrun.SetActive(true);
                            skills.skillPrice.text = skills.priceIkraSkill.ToString("F0");
                            if (ikorka.ikra >= skills.priceIkraSkill)
                            {
                                skills.yesPlease.SetActive(true);
                            }
                            else
                            {
                                skills.yesPlease.SetActive(false);
                            }
                            skills.megaBlock.SetActive(true);
                            skills.phonDescr.SetActive(true);
                            skills.priceIcons.SetActive(true);
                        }
                    }
                    else if (skil22 != null && skil22coll.bounds.Contains(touch.position))
                    {
                        specialtarget1 = null;
                        specialtarget2 = null;
                        specialtarget3 = null;
                        // + включение триггеров
                        podsvetTrigger2.SetActive(true);
                        podsvetTrigger5.SetActive(true);
                        podsvetTrigger7.SetActive(true);
                        podsvetTrigger8.SetActive(true);
                        podsvetTrigger9.SetActive(true);
                        if (slots.slot2blocked.activeSelf == false)
                        {
                            podsvetTrigger2Connected.SetActive(true);
                        }
                        if (slots.slot5blocked.activeSelf == false)
                        {
                            podsvetTrigger5Connected.SetActive(true);
                        }
                        if (slots.slot7blocked.activeSelf == false)
                        {
                            podsvetTrigger7Connected.SetActive(true);
                        }
                        if (slots.slot8blocked.activeSelf == false)
                        {
                            podsvetTrigger8Connected.SetActive(true);
                        }
                        if (slots.slot9blocked.activeSelf == false)
                        {
                            podsvetTrigger9Connected.SetActive(true);
                        }
                        // читаем его
                        movedSkill = skil22;
                        slot2falsMishVraga.SetActive(true);
                        slot5falsMishVraga.SetActive(true);
                        slot7falsMishVraga.SetActive(true);
                        slot8falsMishVraga.SetActive(true);
                        slot9falsMishVraga.SetActive(true);
                        if (skBlok22.activeSelf == true)
                        {
                            // спавнит гены этого навыка
                            // Instantiate(mermaids.Evisceration, genus1.transform.position, Quaternion.identity, genus1.transform);
                            if (forLevel.languager == 0)
                            {
                                skills.nazvanieSkilla.text = "Thanatosis \n Master a skill?";
                            }
                            else if (forLevel.languager == 1)
                            {
                                skills.nazvanieSkilla.text = "Танатоз \n Освоить навык?";
                            }
                            else if (forLevel.languager == 2)
                            {
                                skills.nazvanieSkilla.text = "Танатоз \n Освоїти вміння?";
                            }

                            skills.priceIkraSkill = 3f;
                            skills.Ikrun.SetActive(true);
                            skills.skillPrice.text = skills.priceIkraSkill.ToString("F0");
                            if (ikorka.ikra >= skills.priceIkraSkill)
                            {
                                skills.yesPlease.SetActive(true);
                            }
                            else
                            {
                                skills.yesPlease.SetActive(false);
                            }
                            skills.megaBlock.SetActive(true);
                            skills.phonDescr.SetActive(true);
                            skills.priceIcons.SetActive(true);
                        }
                    }
                    else if (skil23 != null && skil23coll.bounds.Contains(touch.position))
                    {
                        specialtarget1 = null;
                        specialtarget2 = null;
                        specialtarget3 = null;
                        // + включение триггеров
                        podsvetTrigger8.SetActive(true);
                        if (slots.slot8blocked.activeSelf == false)
                        {
                            podsvetTrigger8Connected.SetActive(true);
                        }
                        // читаем его
                        movedSkill = skil23;
                        slot7falsMishVraga.SetActive(true);
                        slot8falsMishVraga.SetActive(true);
                        slot9falsMishVraga.SetActive(true);
                        if (skBlok23.activeSelf == true)
                        {
                            // спавнит гены этого навыка
                            // Instantiate(mermaids.ChernMeshok, genus1.transform.position, Quaternion.identity, genus1.transform);
                            if (forLevel.languager == 0)
                            {
                                skills.nazvanieSkilla.text = "Ink cloud \n Master a skill?";
                            }
                            else if (forLevel.languager == 1)
                            {
                                skills.nazvanieSkilla.text = "Чернильное облако \n Освоить навык?";
                            }
                            else if (forLevel.languager == 2)
                            {
                                skills.nazvanieSkilla.text = "Чорнильна хмара \n Освоїти вміння?";
                            }

                            skills.priceIkraSkill = 4f;
                            skills.Ikrun.SetActive(true);
                            skills.skillPrice.text = skills.priceIkraSkill.ToString("F0");
                            if (ikorka.ikra >= skills.priceIkraSkill)
                            {
                                skills.yesPlease.SetActive(true);
                            }
                            else
                            {
                                skills.yesPlease.SetActive(false);
                            }
                            skills.megaBlock.SetActive(true);
                            skills.phonDescr.SetActive(true);
                            skills.priceIcons.SetActive(true);
                        }
                    }
                    else if (skil24 != null && skil24coll.bounds.Contains(touch.position))
                    {
                        specialtarget1 = null;
                        specialtarget2 = null;
                        specialtarget3 = null;
                        // + включение триггеров
                        podsvetTrigger8.SetActive(true);
                        if (slots.slot8blocked.activeSelf == false)
                        {
                            podsvetTrigger8Connected.SetActive(true);
                        }
                        // читаем его
                        movedSkill = skil24;
                        slot2falsMishVraga.SetActive(true);
                        slot5falsMishVraga.SetActive(true);
                        slot8falsMishVraga.SetActive(true);
                        if (skBlok24.activeSelf == true)
                        {
                            // спавнит гены этого навыка
                            // Instantiate(mermaids.ChernMeshok, genus1.transform.position, Quaternion.identity, genus1.transform);
                            if (forLevel.languager == 0)
                            {
                                skills.nazvanieSkilla.text = "Ink jet \n Master a skill?";
                            }
                            else if (forLevel.languager == 1)
                            {
                                skills.nazvanieSkilla.text = "Чернильная струя \n Освоить навык?";
                            }
                            else if (forLevel.languager == 2)
                            {
                                skills.nazvanieSkilla.text = "Чорнильний струмінь \n Освоїти вміння?";
                            }

                            skills.priceIkraSkill = 4f;
                            skills.Ikrun.SetActive(true);
                            skills.skillPrice.text = skills.priceIkraSkill.ToString("F0");
                            if (ikorka.ikra >= skills.priceIkraSkill)
                            {
                                skills.yesPlease.SetActive(true);
                            }
                            else
                            {
                                skills.yesPlease.SetActive(false);
                            }
                            skills.megaBlock.SetActive(true);
                            skills.phonDescr.SetActive(true);
                            skills.priceIcons.SetActive(true);
                        }
                    }
                    else if (skil25 != null && skil25coll.bounds.Contains(touch.position))
                    {
                        specialtarget1 = null;
                        specialtarget2 = null;
                        specialtarget3 = null;
                        // + включение триггеров
                        podsvetTrigger5.SetActive(true);
                        if (slots.slot5blocked.activeSelf == false)
                        {
                            podsvetTrigger5Connected.SetActive(true);
                        }
                        // читаем его
                        movedSkill = skil25;
                        slot1falsMish.SetActive(true);
                        slot3falsMish.SetActive(true);
                        slot7falsMish.SetActive(true);
                        slot9falsMish.SetActive(true);
                        if (skBlok25.activeSelf == true)
                        {
                            // спавнит гены этого навыка
                            // Instantiate(mermaids.Cuvierovi, genus1.transform.position, Quaternion.identity, genus1.transform);
                            if (forLevel.languager == 0)
                            {
                                skills.nazvanieSkilla.text = "Improvised bandage \n Master a skill?";
                            }
                            else if (forLevel.languager == 1)
                            {
                                skills.nazvanieSkilla.text = "Импровизированный бинт \n Освоить навык?";
                            }
                            else if (forLevel.languager == 2)
                            {
                                skills.nazvanieSkilla.text = "Імпровізований бинт \n Освоїти вміння?";
                            }

                            skills.priceIkraSkill = 4f;
                            skills.Ikrun.SetActive(true);
                            skills.skillPrice.text = skills.priceIkraSkill.ToString("F0");
                            if (ikorka.ikra >= skills.priceIkraSkill)
                            {
                                skills.yesPlease.SetActive(true);
                            }
                            else
                            {
                                skills.yesPlease.SetActive(false);
                            }
                            skills.megaBlock.SetActive(true);
                            skills.phonDescr.SetActive(true);
                            skills.priceIcons.SetActive(true);
                        }
                    }
                    else if (skil26 != null && skil26coll.bounds.Contains(touch.position))
                    {
                        specialtarget1 = null;
                        specialtarget2 = null;
                        specialtarget3 = null;
                        // + включение триггеров
                        podsvetTrigger5.SetActive(true);
                        if (slots.slot5blocked.activeSelf == false)
                        {
                            podsvetTrigger5Connected.SetActive(true);
                        }
                        // читаем его
                        movedSkill = skil26;
                        slot2falsMish.SetActive(true);
                        slot4falsMish.SetActive(true);
                        slot6falsMish.SetActive(true);
                        slot8falsMish.SetActive(true);
                        if (skBlok26.activeSelf == true)
                        {
                            // спавнит гены этого навыка
                            // Instantiate(mermaids.Cuvierovi, genus1.transform.position, Quaternion.identity, genus1.transform);
                            if (forLevel.languager == 0)
                            {
                                skills.nazvanieSkilla.text = "Improvised bandage \n Master a skill?";
                            }
                            else if (forLevel.languager == 1)
                            {
                                skills.nazvanieSkilla.text = "Импровизированный бинт \n Освоить навык?";
                            }
                            else if (forLevel.languager == 2)
                            {
                                skills.nazvanieSkilla.text = "Імпровізований бинт \n Освоїти вміння?";
                            }

                            skills.priceIkraSkill = 4f;
                            skills.Ikrun.SetActive(true);
                            skills.skillPrice.text = skills.priceIkraSkill.ToString("F0");
                            if (ikorka.ikra >= skills.priceIkraSkill)
                            {
                                skills.yesPlease.SetActive(true);
                            }
                            else
                            {
                                skills.yesPlease.SetActive(false);
                            }
                            skills.megaBlock.SetActive(true);
                            skills.phonDescr.SetActive(true);
                            skills.priceIcons.SetActive(true);
                        }
                    }
                    else if (skil27 != null && skil27coll.bounds.Contains(touch.position))
                    {
                        specialtarget1 = null;
                        specialtarget2 = null;
                        specialtarget3 = null;
                        // + включение триггеров
                        podsvetTrigger1.SetActive(true);
                        podsvetTrigger3.SetActive(true);
                        podsvetTrigger7.SetActive(true);
                        podsvetTrigger9.SetActive(true);
                        if (slots.slot1blocked.activeSelf == false)
                        {
                            podsvetTrigger1Connected.SetActive(true);
                        }
                        if (slots.slot3blocked.activeSelf == false)
                        {
                            podsvetTrigger3Connected.SetActive(true);
                        }
                        if (slots.slot7blocked.activeSelf == false)
                        {
                            podsvetTrigger7Connected.SetActive(true);
                        }
                        if (slots.slot9blocked.activeSelf == false)
                        {
                            podsvetTrigger9Connected.SetActive(true);
                        }
                        // читаем его
                        movedSkill = skil27;
                        slot1falsMishVraga.SetActive(true);
                        slot4falsMishVraga.SetActive(true);
                        slot7falsMishVraga.SetActive(true);
                        slot3falsMishVraga.SetActive(true);
                        slot6falsMishVraga.SetActive(true);
                        slot9falsMishVraga.SetActive(true);
                        if (skBlok27.activeSelf == true)
                        {
                            // спавнит гены этого навыка
                            // Instantiate(mermaids.Colloblasty, genus1.transform.position, Quaternion.identity, genus1.transform);
                            if (forLevel.languager == 0)
                            {
                                skills.nazvanieSkilla.text = "Sticky touch \n Master a skill?";
                            }
                            else if (forLevel.languager == 1)
                            {
                                skills.nazvanieSkilla.text = "Липкое касание \n Освоить навык?";
                            }
                            else if (forLevel.languager == 2)
                            {
                                skills.nazvanieSkilla.text = "Липкий дотик \n Освоїти вміння?";
                            }

                            skills.priceIkraSkill = 4f;
                            skills.Ikrun.SetActive(true);
                            skills.skillPrice.text = skills.priceIkraSkill.ToString("F0");
                            if (ikorka.ikra >= skills.priceIkraSkill)
                            {
                                skills.yesPlease.SetActive(true);
                            }
                            else
                            {
                                skills.yesPlease.SetActive(false);
                            }
                            skills.megaBlock.SetActive(true);
                            skills.phonDescr.SetActive(true);
                            skills.priceIcons.SetActive(true);
                        }
                    }
                    else if (skil28 != null && skil28coll.bounds.Contains(touch.position))
                    {
                        specialtarget1 = null;
                        specialtarget2 = null;
                        specialtarget3 = null;
                        // + включение триггеров
                        podsvetTrigger1.SetActive(true);
                        podsvetTrigger2.SetActive(true);
                        podsvetTrigger3.SetActive(true);
                        podsvetTrigger4.SetActive(true);
                        podsvetTrigger5.SetActive(true);
                        podsvetTrigger6.SetActive(true);
                        if (slots.slot1blocked.activeSelf == false)
                        {
                            podsvetTrigger1Connected.SetActive(true);
                        }
                        if (slots.slot2blocked.activeSelf == false)
                        {
                            podsvetTrigger2Connected.SetActive(true);
                        }
                        if (slots.slot3blocked.activeSelf == false)
                        {
                            podsvetTrigger3Connected.SetActive(true);
                        }
                        if (slots.slot4blocked.activeSelf == false)
                        {
                            podsvetTrigger4Connected.SetActive(true);
                        }
                        if (slots.slot5blocked.activeSelf == false)
                        {
                            podsvetTrigger5Connected.SetActive(true);
                        }
                        if (slots.slot6blocked.activeSelf == false)
                        {
                            podsvetTrigger6Connected.SetActive(true);
                        }
                        // читаем его
                        movedSkill = skil28;
                        slot1falsMishVraga.SetActive(true);
                        slot2falsMishVraga.SetActive(true);
                        slot3falsMishVraga.SetActive(true);
                        slot4falsMishVraga.SetActive(true);
                        slot5falsMishVraga.SetActive(true);
                        slot6falsMishVraga.SetActive(true);
                        if (skBlok28.activeSelf == true)
                        {
                            // спавнит гены этого навыка
                            // Instantiate(mermaids.Toxiny, genus1.transform.position, Quaternion.identity, genus1.transform);
                            if (forLevel.languager == 0)
                            {
                                skills.nazvanieSkilla.text = "Poison touch \n Master a skill?";
                            }
                            else if (forLevel.languager == 1)
                            {
                                skills.nazvanieSkilla.text = "Ядовитое касание \n Освоить навык?";
                            }
                            else if (forLevel.languager == 2)
                            {
                                skills.nazvanieSkilla.text = "Отруйний дотик \n Освоїти вміння?";
                            }

                            skills.priceIkraSkill = 5f;
                            skills.Ikrun.SetActive(true);
                            skills.skillPrice.text = skills.priceIkraSkill.ToString("F0");
                            if (ikorka.ikra >= skills.priceIkraSkill)
                            {
                                skills.yesPlease.SetActive(true);
                            }
                            else
                            {
                                skills.yesPlease.SetActive(false);
                            }
                            skills.megaBlock.SetActive(true);
                            skills.phonDescr.SetActive(true);
                            skills.priceIcons.SetActive(true);
                        }
                    }
                    else if (skil29 != null && skil29coll.bounds.Contains(touch.position))
                    {
                        specialtarget1 = null;
                        specialtarget2 = null;
                        specialtarget3 = null;
                        // + включение триггеров
                        podsvetTrigger4.SetActive(true);
                        podsvetTrigger6.SetActive(true);
                        if (slots.slot4blocked.activeSelf == false)
                        {
                            podsvetTrigger4Connected.SetActive(true);
                        }
                        if (slots.slot6blocked.activeSelf == false)
                        {
                            podsvetTrigger6Connected.SetActive(true);
                        }

                        // читаем его
                        movedSkill = skil29;
                        slot7falsMish.SetActive(true);
                        slot8falsMish.SetActive(true);
                        slot9falsMish.SetActive(true);
                        if (skBlok29.activeSelf == true)
                        {
                            // спавнит гены этого навыка
                            // Instantiate(mermaids.Plavniki, genus1.transform.position, Quaternion.identity, genus1.transform);
                            if (forLevel.languager == 0)
                            {
                                skills.nazvanieSkilla.text = "Silt coating \n Master a skill?";
                            }
                            else if (forLevel.languager == 1)
                            {
                                skills.nazvanieSkilla.text = "Обмазывание илом \n Освоить навык?";
                            }
                            else if (forLevel.languager == 2)
                            {
                                skills.nazvanieSkilla.text = "Обмазування мулом \n Освоїти вміння?";
                            }

                            skills.priceIkraSkill = 3f;
                            skills.Ikrun.SetActive(true);
                            skills.skillPrice.text = skills.priceIkraSkill.ToString("F0");
                            if (ikorka.ikra >= skills.priceIkraSkill)
                            {
                                skills.yesPlease.SetActive(true);
                            }
                            else
                            {
                                skills.yesPlease.SetActive(false);
                            }
                            skills.megaBlock.SetActive(true);
                            skills.phonDescr.SetActive(true);
                            skills.priceIcons.SetActive(true);
                        }
                    }
                    else if (skil30 != null && skil30coll.bounds.Contains(touch.position))
                    {
                        specialtarget1 = null;
                        specialtarget2 = null;
                        specialtarget3 = null;
                        // + включение триггеров
                        podsvetTrigger4.SetActive(true);
                        podsvetTrigger5.SetActive(true);
                        podsvetTrigger6.SetActive(true);
                        if (slots.slot4blocked.activeSelf == false)
                        {
                            podsvetTrigger4Connected.SetActive(true);
                        }
                        if (slots.slot5blocked.activeSelf == false)
                        {
                            podsvetTrigger5Connected.SetActive(true);
                        }
                        if (slots.slot6blocked.activeSelf == false)
                        {
                            podsvetTrigger6Connected.SetActive(true);
                        }
                        // читаем его
                        movedSkill = skil30;
                        slot1falsMishVraga.SetActive(true);
                        slot2falsMishVraga.SetActive(true);
                        slot3falsMishVraga.SetActive(true);
                        slot4falsMishVraga.SetActive(true);
                        slot5falsMishVraga.SetActive(true);
                        slot6falsMishVraga.SetActive(true);
                        slot7falsMishVraga.SetActive(true);
                        slot8falsMishVraga.SetActive(true);
                        slot9falsMishVraga.SetActive(true);
                        if (skBlok30.activeSelf == true)
                        {
                            // спавнит гены этого навыка
                            // Instantiate(mermaids.Zuby, genus1.transform.position, Quaternion.identity, genus1.transform);
                            // Instantiate(mermaids.Evisceration, genus2.transform.position, Quaternion.identity, genus2.transform);
                            if (forLevel.languager == 0)
                            {
                                skills.nazvanieSkilla.text = "Jaw ejection \n Master a skill?";
                            }
                            else if (forLevel.languager == 1)
                            {
                                skills.nazvanieSkilla.text = "Выброс челюсти \n Освоить навык?";
                            }
                            else if (forLevel.languager == 2)
                            {
                                skills.nazvanieSkilla.text = "Викид щелепи \n Освоїти вміння?";
                            }

                            skills.priceIkraSkill = 4f;
                            skills.Ikrun.SetActive(true);
                            skills.skillPrice.text = skills.priceIkraSkill.ToString("F0");
                            if (ikorka.ikra >= skills.priceIkraSkill)
                            {
                                skills.yesPlease.SetActive(true);
                            }
                            else
                            {
                                skills.yesPlease.SetActive(false);
                            }
                            skills.megaBlock.SetActive(true);
                            skills.phonDescr.SetActive(true);
                            skills.priceIcons.SetActive(true);
                        }
                    }
                    else if (skil31 != null && skil31coll.bounds.Contains(touch.position))
                    {
                        specialtarget1 = null;
                        specialtarget2 = null;
                        specialtarget3 = null;
                        // + включение триггеров
                        podsvetTrigger7.SetActive(true);
                        podsvetTrigger8.SetActive(true);
                        podsvetTrigger9.SetActive(true);
                        if (slots.slot7blocked.activeSelf == false)
                        {
                            podsvetTrigger7Connected.SetActive(true);
                        }
                        if (slots.slot8blocked.activeSelf == false)
                        {
                            podsvetTrigger8Connected.SetActive(true);
                        }
                        if (slots.slot9blocked.activeSelf == false)
                        {
                            podsvetTrigger9Connected.SetActive(true);
                        }
                        // читаем его
                        movedSkill = skil31;
                        slot1falsMishVraga.SetActive(true);
                        slot2falsMishVraga.SetActive(true);
                        slot3falsMishVraga.SetActive(true);
                        slot4falsMishVraga.SetActive(true);
                        slot5falsMishVraga.SetActive(true);
                        slot6falsMishVraga.SetActive(true);
                        slot7falsMishVraga.SetActive(true);
                        slot8falsMishVraga.SetActive(true);
                        slot9falsMishVraga.SetActive(true);
                        if (skBlok31.activeSelf == true)
                        {
                            // спавнит гены этого навыка
                            // Instantiate(mermaids.Zuby, genus1.transform.position, Quaternion.identity, genus1.transform);
                            // Instantiate(mermaids.Toxiny, genus2.transform.position, Quaternion.identity, genus2.transform);
                            if (forLevel.languager == 0)
                            {
                                skills.nazvanieSkilla.text = "Poison bite \n Master a skill?";
                            }
                            else if (forLevel.languager == 1)
                            {
                                skills.nazvanieSkilla.text = "Отравляющий укус \n Освоить навык?";
                            }
                            else if (forLevel.languager == 2)
                            {
                                skills.nazvanieSkilla.text = "Отруйний укус \n Освоїти вміння?";
                            }

                            skills.priceIkraSkill = 5f;
                            skills.Ikrun.SetActive(true);
                            skills.skillPrice.text = skills.priceIkraSkill.ToString("F0");
                            if (ikorka.ikra >= skills.priceIkraSkill)
                            {
                                skills.yesPlease.SetActive(true);
                            }
                            else
                            {
                                skills.yesPlease.SetActive(false);
                            }
                            skills.megaBlock.SetActive(true);
                            skills.phonDescr.SetActive(true);
                            skills.priceIcons.SetActive(true);
                        }
                    }
                    else if (skil32 != null && skil32coll.bounds.Contains(touch.position))
                    {
                        specialtarget1 = null;
                        specialtarget2 = null;
                        specialtarget3 = null;
                        // + включение триггеров
                        podsvetTrigger8.SetActive(true);
                        if (slots.slot8blocked.activeSelf == false)
                        {
                            podsvetTrigger8Connected.SetActive(true);
                        }
                        // читаем его
                        movedSkill = skil32;
                        slot1falsMishVraga.SetActive(true);
                        slot2falsMishVraga.SetActive(true);
                        slot3falsMishVraga.SetActive(true);
                        slot4falsMishVraga.SetActive(true);
                        slot5falsMishVraga.SetActive(true);
                        slot6falsMishVraga.SetActive(true);
                        slot7falsMishVraga.SetActive(true);
                        slot8falsMishVraga.SetActive(true);
                        slot9falsMishVraga.SetActive(true);
                        if (skBlok32.activeSelf == true)
                        {
                            // спавнит гены этого навыка
                            // Instantiate(mermaids.Mechanoreceptor, genus1.transform.position, Quaternion.identity, genus1.transform);
                            // Instantiate(mermaids.Evisceration, genus2.transform.position, Quaternion.identity, genus2.transform);
                            if (forLevel.languager == 0)
                            {
                                skills.nazvanieSkilla.text = "Eerie shouting \n Master a skill?";
                            }
                            else if (forLevel.languager == 1)
                            {
                                skills.nazvanieSkilla.text = "Жуткое окрикивание \n Освоить навык?";
                            }
                            else if (forLevel.languager == 2)
                            {
                                skills.nazvanieSkilla.text = "Моторошне окрикування \n Освоїти вміння?";
                            }

                            skills.priceIkraSkill = 4f;
                            skills.Ikrun.SetActive(true);
                            skills.skillPrice.text = skills.priceIkraSkill.ToString("F0");
                            if (ikorka.ikra >= skills.priceIkraSkill)
                            {
                                skills.yesPlease.SetActive(true);
                            }
                            else
                            {
                                skills.yesPlease.SetActive(false);
                            }
                            skills.megaBlock.SetActive(true);
                            skills.phonDescr.SetActive(true);
                            skills.priceIcons.SetActive(true);
                        }
                    }
                    else if (skil33 != null && skil33coll.bounds.Contains(touch.position))
                    {
                        specialtarget1 = null;
                        specialtarget2 = null;
                        specialtarget3 = null;
                        // + включение триггеров
                        podsvetTrigger1.SetActive(true);
                        podsvetTrigger2.SetActive(true);
                        podsvetTrigger3.SetActive(true);
                        podsvetTrigger7.SetActive(true);
                        podsvetTrigger8.SetActive(true);
                        podsvetTrigger9.SetActive(true);
                        if (slots.slot1blocked.activeSelf == false)
                        {
                            podsvetTrigger1Connected.SetActive(true);
                        }
                        if (slots.slot7blocked.activeSelf == false)
                        {
                            podsvetTrigger7Connected.SetActive(true);
                        }
                        if (slots.slot2blocked.activeSelf == false)
                        {
                            podsvetTrigger2Connected.SetActive(true);
                        }
                        if (slots.slot8blocked.activeSelf == false)
                        {
                            podsvetTrigger8Connected.SetActive(true);
                        }
                        if (slots.slot3blocked.activeSelf == false)
                        {
                            podsvetTrigger3Connected.SetActive(true);
                        }
                        if (slots.slot9blocked.activeSelf == false)
                        {
                            podsvetTrigger9Connected.SetActive(true);
                        }
                        // читаем его
                        movedSkill = skil33;
                        slot1falsMishVraga.SetActive(true);
                        slot2falsMishVraga.SetActive(true);
                        slot3falsMishVraga.SetActive(true);
                        slot4falsMishVraga.SetActive(true);
                        slot5falsMishVraga.SetActive(true);
                        slot6falsMishVraga.SetActive(true);
                        slot7falsMishVraga.SetActive(true);
                        slot8falsMishVraga.SetActive(true);
                        slot9falsMishVraga.SetActive(true);
                        if (skBlok33.activeSelf == true)
                        {
                            // спавнит гены этого навыка
                            // Instantiate(mermaids.Gigantizm, genus1.transform.position, Quaternion.identity, genus1.transform);
                            // Instantiate(mermaids.Plavniki, genus2.transform.position, Quaternion.identity, genus2.transform);
                            if (forLevel.languager == 0)
                            {
                                skills.nazvanieSkilla.text = "Body bloat \n Master a skill?";
                            }
                            else if (forLevel.languager == 1)
                            {
                                skills.nazvanieSkilla.text = "Раздувание тела \n Освоить навык?";
                            }
                            else if (forLevel.languager == 2)
                            {
                                skills.nazvanieSkilla.text = "Роздування тіла \n Освоїти вміння?";
                            }

                            skills.priceIkraSkill = 5f;
                            skills.Ikrun.SetActive(true);
                            skills.skillPrice.text = skills.priceIkraSkill.ToString("F0");
                            if (ikorka.ikra >= skills.priceIkraSkill)
                            {
                                skills.yesPlease.SetActive(true);
                            }
                            else
                            {
                                skills.yesPlease.SetActive(false);
                            }
                            skills.megaBlock.SetActive(true);
                            skills.phonDescr.SetActive(true);
                            skills.priceIcons.SetActive(true);
                        }
                    }
                    else if (skil34 != null && skil34coll.bounds.Contains(touch.position))
                    {
                        specialtarget1 = null;
                        specialtarget2 = null;
                        specialtarget3 = null;
                        // + включение триггеров
                        podsvetTrigger4.SetActive(true);
                        podsvetTrigger5.SetActive(true);
                        podsvetTrigger6.SetActive(true);
                        podsvetTrigger7.SetActive(true);
                        podsvetTrigger9.SetActive(true);
                        if (slots.slot4blocked.activeSelf == false)
                        {
                            podsvetTrigger4Connected.SetActive(true);
                        }
                        if (slots.slot5blocked.activeSelf == false)
                        {
                            podsvetTrigger5Connected.SetActive(true);
                        }
                        if (slots.slot6blocked.activeSelf == false)
                        {
                            podsvetTrigger6Connected.SetActive(true);
                        }
                        if (slots.slot7blocked.activeSelf == false)
                        {
                            podsvetTrigger7Connected.SetActive(true);
                        }
                        if (slots.slot9blocked.activeSelf == false)
                        {
                            podsvetTrigger9Connected.SetActive(true);
                        }
                        // читаем его
                        movedSkill = skil34;
                        slot1falsMishVraga.SetActive(true);
                        slot2falsMishVraga.SetActive(true);
                        slot3falsMishVraga.SetActive(true);
                        slot4falsMishVraga.SetActive(true);
                        slot5falsMishVraga.SetActive(true);
                        slot6falsMishVraga.SetActive(true);
                        slot7falsMishVraga.SetActive(true);
                        slot8falsMishVraga.SetActive(true);
                        slot9falsMishVraga.SetActive(true);
                        if (skBlok34.activeSelf == true)
                        {
                            // спавнит гены этого навыка
                            // Instantiate(mermaids.Colloblasty, genus1.transform.position, Quaternion.identity, genus1.transform);
                            // Instantiate(mermaids.Cuvierovi, genus2.transform.position, Quaternion.identity, genus2.transform);
                            if (forLevel.languager == 0)
                            {
                                skills.nazvanieSkilla.text = "Improvised lasso \n Master a skill?";
                            }
                            else if (forLevel.languager == 1)
                            {
                                skills.nazvanieSkilla.text = "Импровизированное лассо \n Освоить навык?";
                            }
                            else if (forLevel.languager == 2)
                            {
                                skills.nazvanieSkilla.text = "Імпровізоване ласо \n Освоїти вміння?";
                            }

                            skills.priceIkraSkill = 5f;
                            skills.Ikrun.SetActive(true);
                            skills.skillPrice.text = skills.priceIkraSkill.ToString("F0");
                            if (ikorka.ikra >= skills.priceIkraSkill)
                            {
                                skills.yesPlease.SetActive(true);
                            }
                            else
                            {
                                skills.yesPlease.SetActive(false);
                            }
                            skills.megaBlock.SetActive(true);
                            skills.phonDescr.SetActive(true);
                            skills.priceIcons.SetActive(true);
                        }
                    }
                    else if (skil35 != null && skil35coll.bounds.Contains(touch.position))
                    {
                        specialtarget1 = null;
                        specialtarget2 = null;
                        specialtarget3 = null;
                        // + включение триггеров
                        podsvetTrigger1.SetActive(true);
                        podsvetTrigger2.SetActive(true);
                        podsvetTrigger3.SetActive(true);
                        if (slots.slot1blocked.activeSelf == false)
                        {
                            podsvetTrigger1Connected.SetActive(true);
                        }
                        if (slots.slot2blocked.activeSelf == false)
                        {
                            podsvetTrigger2Connected.SetActive(true);
                        }
                        if (slots.slot3blocked.activeSelf == false)
                        {
                            podsvetTrigger3Connected.SetActive(true);
                        }
                        // читаем его
                        movedSkill = skil35;
                        slot1falsMish.SetActive(true);
                        slot2falsMish.SetActive(true);
                        slot3falsMish.SetActive(true);
                        slot4falsMish.SetActive(true);
                        slot5falsMish.SetActive(true);
                        slot6falsMish.SetActive(true);
                        if (skBlok35.activeSelf == true)
                        {
                            // спавнит гены этого навыка
                            // Instantiate(mermaids.Colloblasty, genus1.transform.position, Quaternion.identity, genus1.transform);
                            // Instantiate(mermaids.Immunitet, genus2.transform.position, Quaternion.identity, genus2.transform);
                            if (forLevel.languager == 0)
                            {
                                skills.nazvanieSkilla.text = "Wound healing \n Master a skill?";
                            }
                            else if (forLevel.languager == 1)
                            {
                                skills.nazvanieSkilla.text = "Заклеивание ран \n Освоить навык?";
                            }
                            else if (forLevel.languager == 2)
                            {
                                skills.nazvanieSkilla.text = "Заклеювання ран \n Освоїти вміння?";
                            }

                            skills.priceIkraSkill = 5f;
                            skills.Ikrun.SetActive(true);
                            skills.skillPrice.text = skills.priceIkraSkill.ToString("F0");
                            if (ikorka.ikra >= skills.priceIkraSkill)
                            {
                                skills.yesPlease.SetActive(true);
                            }
                            else
                            {
                                skills.yesPlease.SetActive(false);
                            }
                            skills.megaBlock.SetActive(true);
                            skills.phonDescr.SetActive(true);
                            skills.priceIcons.SetActive(true);
                        }
                    }
                    else if (skil36 != null && skil36coll.bounds.Contains(touch.position))
                    {
                        specialtarget1 = null;
                        specialtarget2 = null;
                        specialtarget3 = null;
                        // + включение триггеров
                        podsvetTrigger2.SetActive(true);
                        podsvetTrigger5.SetActive(true);
                        podsvetTrigger8.SetActive(true);
                        if (slots.slot2blocked.activeSelf == false)
                        {
                            podsvetTrigger2Connected.SetActive(true);
                        }
                        if (slots.slot5blocked.activeSelf == false)
                        {
                            podsvetTrigger5Connected.SetActive(true);
                        }
                        if (slots.slot8blocked.activeSelf == false)
                        {
                            podsvetTrigger8Connected.SetActive(true);
                        }
                        // читаем его
                        movedSkill = skil36;
                        slot1falsMish.SetActive(true);
                        slot2falsMish.SetActive(true);
                        slot3falsMish.SetActive(true);
                        slot4falsMish.SetActive(true);
                        slot5falsMish.SetActive(true);
                        slot6falsMish.SetActive(true);
                        slot7falsMish.SetActive(true);
                        slot8falsMish.SetActive(true);
                        slot9falsMish.SetActive(true);
                        if (skBlok36.activeSelf == true)
                        {
                            // спавнит гены этого навыка
                            // Instantiate(mermaids.RedPigment, genus1.transform.position, Quaternion.identity, genus1.transform);
                            // Instantiate(mermaids.Immunitet, genus2.transform.position, Quaternion.identity, genus2.transform);
                            if (forLevel.languager == 0)
                            {
                                skills.nazvanieSkilla.text = "The secret of longevity \n Master a skill?";
                            }
                            else if (forLevel.languager == 1)
                            {
                                skills.nazvanieSkilla.text = "Секрет долгожительства \n Освоить навык?";
                            }
                            else if (forLevel.languager == 2)
                            {
                                skills.nazvanieSkilla.text = "Секрет довголіття \n Освоїти вміння?";
                            }

                            skills.priceIkraSkill = 5f;
                            skills.Ikrun.SetActive(true);
                            skills.skillPrice.text = skills.priceIkraSkill.ToString("F0");
                            if (ikorka.ikra >= skills.priceIkraSkill)
                            {
                                skills.yesPlease.SetActive(true);
                            }
                            else
                            {
                                skills.yesPlease.SetActive(false);
                            }
                            skills.megaBlock.SetActive(true);
                            skills.phonDescr.SetActive(true);
                            skills.priceIcons.SetActive(true);
                        }
                    }
                    else if (skil37 != null && skil37coll.bounds.Contains(touch.position))
                    {
                        specialtarget1 = null;
                        specialtarget2 = null;
                        specialtarget3 = null;
                        // + включение триггеров
                        podsvetTrigger5.SetActive(true);
                        podsvetTrigger7.SetActive(true);
                        podsvetTrigger8.SetActive(true);
                        podsvetTrigger9.SetActive(true);
                        if (slots.slot5blocked.activeSelf == false)
                        {
                            podsvetTrigger5Connected.SetActive(true);
                        }
                        if (slots.slot7blocked.activeSelf == false)
                        {
                            podsvetTrigger7Connected.SetActive(true);
                        }
                        if (slots.slot8blocked.activeSelf == false)
                        {
                            podsvetTrigger8Connected.SetActive(true);
                        }
                        if (slots.slot9blocked.activeSelf == false)
                        {
                            podsvetTrigger9Connected.SetActive(true);
                        }
                        // читаем его
                        movedSkill = skil37;
                        slot1falsMishVraga.SetActive(true);
                        slot2falsMishVraga.SetActive(true);
                        slot3falsMishVraga.SetActive(true);
                        slot4falsMishVraga.SetActive(true);
                        slot5falsMishVraga.SetActive(true);
                        slot6falsMishVraga.SetActive(true);
                        slot7falsMishVraga.SetActive(true);
                        slot8falsMishVraga.SetActive(true);
                        slot9falsMishVraga.SetActive(true);
                        if (skBlok37.activeSelf == true)
                        {
                            // спавнит гены этого навыка
                            // Instantiate(mermaids.Pheromones, genus1.transform.position, Quaternion.identity, genus1.transform);
                            // Instantiate(mermaids.Luminiscencia, genus2.transform.position, Quaternion.identity, genus2.transform);
                            if (forLevel.languager == 0)
                            {
                                skills.nazvanieSkilla.text = "Distracting dance \n Master a skill?";
                            }
                            else if (forLevel.languager == 1)
                            {
                                skills.nazvanieSkilla.text = "Отвлекающий танец \n Освоить навык?";
                            }
                            else if (forLevel.languager == 2)
                            {
                                skills.nazvanieSkilla.text = "Відволікаючий танець \n Освоїти вміння?";
                            }

                            skills.priceIkraSkill = 4f;
                            skills.Ikrun.SetActive(true);
                            skills.skillPrice.text = skills.priceIkraSkill.ToString("F0");
                            if (ikorka.ikra >= skills.priceIkraSkill)
                            {
                                skills.yesPlease.SetActive(true);
                            }
                            else
                            {
                                skills.yesPlease.SetActive(false);
                            }
                            skills.megaBlock.SetActive(true);
                            skills.phonDescr.SetActive(true);
                            skills.priceIcons.SetActive(true);
                        }
                    }
                    else if (skil38 != null && skil38coll.bounds.Contains(touch.position))
                    {
                        specialtarget1 = null;
                        specialtarget2 = null;
                        specialtarget3 = null;
                        // + включение триггеров
                        podsvetTrigger1.SetActive(true);
                        podsvetTrigger2.SetActive(true);
                        podsvetTrigger3.SetActive(true);
                        podsvetTrigger4.SetActive(true);
                        podsvetTrigger5.SetActive(true);
                        podsvetTrigger6.SetActive(true);
                        podsvetTrigger7.SetActive(true);
                        podsvetTrigger8.SetActive(true);
                        podsvetTrigger9.SetActive(true);
                        if (slots.slot1blocked.activeSelf == false)
                        {
                            podsvetTrigger1Connected.SetActive(true);
                        }
                        if (slots.slot2blocked.activeSelf == false)
                        {
                            podsvetTrigger2Connected.SetActive(true);
                        }
                        if (slots.slot3blocked.activeSelf == false)
                        {
                            podsvetTrigger3Connected.SetActive(true);
                        }
                        if (slots.slot4blocked.activeSelf == false)
                        {
                            podsvetTrigger4Connected.SetActive(true);
                        }
                        if (slots.slot5blocked.activeSelf == false)
                        {
                            podsvetTrigger5Connected.SetActive(true);
                        }
                        if (slots.slot6blocked.activeSelf == false)
                        {
                            podsvetTrigger6Connected.SetActive(true);
                        }
                        if (slots.slot7blocked.activeSelf == false)
                        {
                            podsvetTrigger7Connected.SetActive(true);
                        }
                        if (slots.slot8blocked.activeSelf == false)
                        {
                            podsvetTrigger8Connected.SetActive(true);
                        }
                        if (slots.slot9blocked.activeSelf == false)
                        {
                            podsvetTrigger9Connected.SetActive(true);
                        }
                        // читаем его
                        movedSkill = skil38;
                        slot1falsMishVraga.SetActive(true);
                        slot2falsMishVraga.SetActive(true);
                        slot3falsMishVraga.SetActive(true);
                        slot4falsMishVraga.SetActive(true);
                        slot5falsMishVraga.SetActive(true);
                        slot6falsMishVraga.SetActive(true);
                        slot7falsMishVraga.SetActive(true);
                        slot8falsMishVraga.SetActive(true);
                        slot9falsMishVraga.SetActive(true);
                        if (skBlok38.activeSelf == true)
                        {
                            // спавнит гены этого навыка
                            // Instantiate(mermaids.Sliz, genus1.transform.position, Quaternion.identity, genus1.transform);
                            // Instantiate(mermaids.Luminiscencia, genus2.transform.position, Quaternion.identity, genus2.transform);
                            if (forLevel.languager == 0)
                            {
                                skills.nazvanieSkilla.text = "Fast flashing \n Master a skill?";
                            }
                            else if (forLevel.languager == 1)
                            {
                                skills.nazvanieSkilla.text = "Быстрое мелькание \n Освоить навык?";
                            }
                            else if (forLevel.languager == 2)
                            {
                                skills.nazvanieSkilla.text = "Швидке миготіння \n Освоїти вміння?";
                            }

                            skills.priceIkraSkill = 4f;
                            skills.Ikrun.SetActive(true);
                            skills.skillPrice.text = skills.priceIkraSkill.ToString("F0");
                            if (ikorka.ikra >= skills.priceIkraSkill)
                            {
                                skills.yesPlease.SetActive(true);
                            }
                            else
                            {
                                skills.yesPlease.SetActive(false);
                            }
                            skills.megaBlock.SetActive(true);
                            skills.phonDescr.SetActive(true);
                            skills.priceIcons.SetActive(true);
                        }
                    }
                    else if (skil39 != null && skil39coll.bounds.Contains(touch.position))
                    {
                        specialtarget1 = null;
                        specialtarget2 = null;
                        specialtarget3 = null;
                        // + включение триггеров
                        podsvetTrigger5.SetActive(true);
                        podsvetTrigger7.SetActive(true);
                        podsvetTrigger8.SetActive(true);
                        podsvetTrigger9.SetActive(true);
                        if (slots.slot5blocked.activeSelf == false)
                        {
                            podsvetTrigger5Connected.SetActive(true);
                        }
                        if (slots.slot7blocked.activeSelf == false)
                        {
                            podsvetTrigger7Connected.SetActive(true);
                        }
                        if (slots.slot8blocked.activeSelf == false)
                        {
                            podsvetTrigger8Connected.SetActive(true);
                        }
                        if (slots.slot9blocked.activeSelf == false)
                        {
                            podsvetTrigger9Connected.SetActive(true);
                        }
                        // читаем его
                        movedSkill = skil39;
                        slot2falsMish.SetActive(true);
                        slot4falsMish.SetActive(true);
                        slot5falsMish.SetActive(true);
                        slot6falsMish.SetActive(true);
                        slot7falsMish.SetActive(true);
                        slot8falsMish.SetActive(true);
                        slot9falsMish.SetActive(true);
                        if (skBlok39.activeSelf == true)
                        {
                            // спавнит гены этого навыка
                            // Instantiate(mermaids.Prozrachnost, genus1.transform.position, Quaternion.identity, genus1.transform);
                            // Instantiate(mermaids.Luminiscencia, genus2.transform.position, Quaternion.identity, genus2.transform);
                            if (forLevel.languager == 0)
                            {
                                skills.nazvanieSkilla.text = "Counter-illumination \n Master a skill?";
                            }
                            else if (forLevel.languager == 1)
                            {
                                skills.nazvanieSkilla.text = "Контриллюминация \n Освоить навык?";
                            }
                            else if (forLevel.languager == 2)
                            {
                                skills.nazvanieSkilla.text = "Контріллюмінація \n Освоїти вміння?";
                            }

                            skills.priceIkraSkill = 4f;
                            skills.Ikrun.SetActive(true);
                            skills.skillPrice.text = skills.priceIkraSkill.ToString("F0");
                            if (ikorka.ikra >= skills.priceIkraSkill)
                            {
                                skills.yesPlease.SetActive(true);
                            }
                            else
                            {
                                skills.yesPlease.SetActive(false);
                            }
                            skills.megaBlock.SetActive(true);
                            skills.phonDescr.SetActive(true);
                            skills.priceIcons.SetActive(true);
                        }
                    }
                    else if (skil40 != null && skil40coll.bounds.Contains(touch.position))
                    {
                        specialtarget1 = null;
                        specialtarget2 = null;
                        specialtarget3 = null;
                        // + включение триггеров
                        podsvetTrigger1.SetActive(true);
                        podsvetTrigger2.SetActive(true);
                        podsvetTrigger3.SetActive(true);
                        podsvetTrigger4.SetActive(true);
                        podsvetTrigger5.SetActive(true);
                        podsvetTrigger6.SetActive(true);
                        podsvetTrigger7.SetActive(true);
                        podsvetTrigger8.SetActive(true);
                        podsvetTrigger9.SetActive(true);
                        if (slots.slot1blocked.activeSelf == false)
                        {
                            podsvetTrigger1Connected.SetActive(true);
                        }
                        if (slots.slot2blocked.activeSelf == false)
                        {
                            podsvetTrigger2Connected.SetActive(true);
                        }
                        if (slots.slot3blocked.activeSelf == false)
                        {
                            podsvetTrigger3Connected.SetActive(true);
                        }
                        if (slots.slot4blocked.activeSelf == false)
                        {
                            podsvetTrigger4Connected.SetActive(true);
                        }
                        if (slots.slot5blocked.activeSelf == false)
                        {
                            podsvetTrigger5Connected.SetActive(true);
                        }
                        if (slots.slot6blocked.activeSelf == false)
                        {
                            podsvetTrigger6Connected.SetActive(true);
                        }
                        if (slots.slot7blocked.activeSelf == false)
                        {
                            podsvetTrigger7Connected.SetActive(true);
                        }
                        if (slots.slot8blocked.activeSelf == false)
                        {
                            podsvetTrigger8Connected.SetActive(true);
                        }
                        if (slots.slot9blocked.activeSelf == false)
                        {
                            podsvetTrigger9Connected.SetActive(true);
                        }
                        // читаем его
                        movedSkill = skil40;
                        slot1falsMishVraga.SetActive(true);
                        slot2falsMishVraga.SetActive(true);
                        slot3falsMishVraga.SetActive(true);
                        slot4falsMishVraga.SetActive(true);
                        slot5falsMishVraga.SetActive(true);
                        slot6falsMishVraga.SetActive(true);
                        slot7falsMishVraga.SetActive(true);
                        slot8falsMishVraga.SetActive(true);
                        slot9falsMishVraga.SetActive(true);
                        if (skBlok40.activeSelf == true)
                        {
                            // спавнит гены этого навыка
                            // Instantiate(mermaids.ChernMeshok, genus1.transform.position, Quaternion.identity, genus1.transform);
                            // Instantiate(mermaids.ChernyyPigment, genus2.transform.position, Quaternion.identity, genus2.transform);
                            if (forLevel.languager == 0)
                            {
                                skills.nazvanieSkilla.text = "Disorientation \n Master a skill?";
                            }
                            else if (forLevel.languager == 1)
                            {
                                skills.nazvanieSkilla.text = "Дезориентация \n Освоить навык?";
                            }
                            else if (forLevel.languager == 2)
                            {
                                skills.nazvanieSkilla.text = "Дезорієнтація \n Освоїти вміння?";
                            }

                            skills.priceIkraSkill = 5f;
                            skills.Ikrun.SetActive(true);
                            skills.skillPrice.text = skills.priceIkraSkill.ToString("F0");
                            if (ikorka.ikra >= skills.priceIkraSkill)
                            {
                                skills.yesPlease.SetActive(true);
                            }
                            else
                            {
                                skills.yesPlease.SetActive(false);
                            }
                            skills.megaBlock.SetActive(true);
                            skills.phonDescr.SetActive(true);
                            skills.priceIcons.SetActive(true);
                        }
                    }
                    else if (skil41 != null && skil41coll.bounds.Contains(touch.position))
                    {
                        specialtarget1 = null;
                        specialtarget2 = null;
                        specialtarget3 = null;
                        // + включение триггеров
                        podsvetTrigger4.SetActive(true);
                        podsvetTrigger6.SetActive(true);
                        podsvetTrigger7.SetActive(true);
                        podsvetTrigger8.SetActive(true);
                        podsvetTrigger9.SetActive(true);
                        if (slots.slot4blocked.activeSelf == false)
                        {
                            podsvetTrigger4Connected.SetActive(true);
                        }
                        if (slots.slot6blocked.activeSelf == false)
                        {
                            podsvetTrigger6Connected.SetActive(true);
                        }
                        if (slots.slot7blocked.activeSelf == false)
                        {
                            podsvetTrigger7Connected.SetActive(true);
                        }
                        if (slots.slot8blocked.activeSelf == false)
                        {
                            podsvetTrigger8Connected.SetActive(true);
                        }
                        if (slots.slot9blocked.activeSelf == false)
                        {
                            podsvetTrigger9Connected.SetActive(true);
                        }
                        // читаем его
                        movedSkill = skil41;
                        slot1falsMish.SetActive(true);
                        slot2falsMish.SetActive(true);
                        slot3falsMish.SetActive(true);
                        slot4falsMish.SetActive(true);
                        slot5falsMish.SetActive(true);
                        slot6falsMish.SetActive(true);
                        slot7falsMish.SetActive(true);
                        slot8falsMish.SetActive(true);
                        slot9falsMish.SetActive(true);
                        slot1falsMishVraga.SetActive(true);
                        slot2falsMishVraga.SetActive(true);
                        slot3falsMishVraga.SetActive(true);
                        slot4falsMishVraga.SetActive(true);
                        slot5falsMishVraga.SetActive(true);
                        slot6falsMishVraga.SetActive(true);
                        slot7falsMishVraga.SetActive(true);
                        slot8falsMishVraga.SetActive(true);
                        slot9falsMishVraga.SetActive(true);
                        if (skBlok41.activeSelf == true)
                        {
                            // спавнит гены этого навыка
                            // Instantiate(mermaids.Cirri, genus1.transform.position, Quaternion.identity, genus1.transform);
                            // Instantiate(mermaids.Regeneration, genus2.transform.position, Quaternion.identity, genus2.transform);
                            if (forLevel.languager == 0)
                            {
                                skills.nazvanieSkilla.text = "Blind needle attacks \n Master a skill?";
                            }
                            else if (forLevel.languager == 1)
                            {
                                skills.nazvanieSkilla.text = "Слепые атаки остриями \n Освоить навык?";
                            }
                            else if (forLevel.languager == 2)
                            {
                                skills.nazvanieSkilla.text = "Сліпі атаки вістрями \n Освоїти вміння?";
                            }

                            skills.priceIkraSkill = 4f;
                            skills.Ikrun.SetActive(true);
                            skills.skillPrice.text = skills.priceIkraSkill.ToString("F0");
                            if (ikorka.ikra >= skills.priceIkraSkill)
                            {
                                skills.yesPlease.SetActive(true);
                            }
                            else
                            {
                                skills.yesPlease.SetActive(false);
                            }
                            skills.megaBlock.SetActive(true);
                            skills.phonDescr.SetActive(true);
                            skills.priceIcons.SetActive(true);
                        }
                    }
                    else if (skil42 != null && skil42coll.bounds.Contains(touch.position))
                    {
                        specialtarget1 = null;
                        specialtarget2 = null;
                        specialtarget3 = null;
                        // + включение триггеров
                        podsvetTrigger2.SetActive(true);
                        podsvetTrigger5.SetActive(true);
                        podsvetTrigger6.SetActive(true);
                        podsvetTrigger8.SetActive(true);
                        if (slots.slot2blocked.activeSelf == false)
                        {
                            podsvetTrigger2Connected.SetActive(true);
                        }
                        if (slots.slot5blocked.activeSelf == false)
                        {
                            podsvetTrigger5Connected.SetActive(true);
                        }
                        if (slots.slot6blocked.activeSelf == false)
                        {
                            podsvetTrigger6Connected.SetActive(true);
                        }
                        if (slots.slot8blocked.activeSelf == false)
                        {
                            podsvetTrigger8Connected.SetActive(true);
                        }
                        // читаем его
                        movedSkill = skil42;
                        slot1falsMish.SetActive(true);
                        slot4falsMish.SetActive(true);
                        slot5falsMish.SetActive(true);
                        slot7falsMish.SetActive(true);
                        slot2falsMishVraga.SetActive(true);
                        slot5falsMishVraga.SetActive(true);
                        slot6falsMishVraga.SetActive(true);
                        slot8falsMishVraga.SetActive(true);
                        if (skBlok42.activeSelf == true)
                        {
                            // спавнит гены этого навыка
                            // Instantiate(mermaids.Prisosky, genus1.transform.position, Quaternion.identity, genus1.transform);
                            // Instantiate(mermaids.Mimicria, genus2.transform.position, Quaternion.identity, genus2.transform);
                            if (forLevel.languager == 0)
                            {
                                skills.nazvanieSkilla.text = "Scary camouflage \n Master a skill?";
                            }
                            else if (forLevel.languager == 1)
                            {
                                skills.nazvanieSkilla.text = "Пугающий камуфляж \n Освоить навык?";
                            }
                            else if (forLevel.languager == 2)
                            {
                                skills.nazvanieSkilla.text = "Страхітливий камуфляж \n Освоїти вміння?";
                            }

                            skills.priceIkraSkill = 5f;
                            skills.Ikrun.SetActive(true);
                            skills.skillPrice.text = skills.priceIkraSkill.ToString("F0");
                            if (ikorka.ikra >= skills.priceIkraSkill)
                            {
                                skills.yesPlease.SetActive(true);
                            }
                            else
                            {
                                skills.yesPlease.SetActive(false);
                            }
                            skills.megaBlock.SetActive(true);
                            skills.phonDescr.SetActive(true);
                            skills.priceIcons.SetActive(true);
                        }
                    }
                    else if (skil43 != null && skil43coll.bounds.Contains(touch.position))
                    {
                        specialtarget1 = null;
                        specialtarget2 = null;
                        specialtarget3 = null;
                        // + включение триггеров
                        podsvetTrigger1.SetActive(true);
                        podsvetTrigger2.SetActive(true);
                        podsvetTrigger3.SetActive(true);
                        podsvetTrigger4.SetActive(true);
                        if (slots.slot1blocked.activeSelf == false)
                        {
                            podsvetTrigger1Connected.SetActive(true);
                        }
                        if (slots.slot2blocked.activeSelf == false)
                        {
                            podsvetTrigger2Connected.SetActive(true);
                        }
                        if (slots.slot3blocked.activeSelf == false)
                        {
                            podsvetTrigger3Connected.SetActive(true);
                        }
                        if (slots.slot4blocked.activeSelf == false)
                        {
                            podsvetTrigger4Connected.SetActive(true);
                        }
                        // читаем его
                        movedSkill = skil43;
                        slot1falsMishVraga.SetActive(true);
                        slot2falsMishVraga.SetActive(true);
                        slot3falsMishVraga.SetActive(true);
                        slot4falsMishVraga.SetActive(true);
                        if (skBlok43.activeSelf == true)
                        {
                            // спавнит гены этого навыка
                            // Instantiate(mermaids.Pedicellariy, genus1.transform.position, Quaternion.identity, genus1.transform);
                            // Instantiate(mermaids.UskorennoeRazvitie, genus2.transform.position, Quaternion.identity, genus2.transform);
                            if (forLevel.languager == 0)
                            {
                                skills.nazvanieSkilla.text = "Pulling pincers out \n Master a skill?";
                            }
                            else if (forLevel.languager == 1)
                            {
                                skills.nazvanieSkilla.text = "Вытягивание клешень \n Освоить навык?";
                            }
                            else if (forLevel.languager == 2)
                            {
                                skills.nazvanieSkilla.text = "Витягування клешень \n Освоїти вміння?";
                            }

                            skills.priceIkraSkill = 5f;
                            skills.Ikrun.SetActive(true);
                            skills.skillPrice.text = skills.priceIkraSkill.ToString("F0");
                            if (ikorka.ikra >= skills.priceIkraSkill)
                            {
                                skills.yesPlease.SetActive(true);
                            }
                            else
                            {
                                skills.yesPlease.SetActive(false);
                            }
                            skills.megaBlock.SetActive(true);
                            skills.phonDescr.SetActive(true);
                            skills.priceIcons.SetActive(true);
                        }
                    }



                    else // если нажать ни на один навык, обе таблички пропадут, а также мишени
                    {
                        zvukbudet = true;
                        movedSkill = null;
                        specialtarget1 = null;
                        specialtarget2 = null;
                        specialtarget3 = null;
                    }

                }
                // если тач закончился, отключаются триггеры
                else if (touch.phase == TouchPhase.Ended && skills.megaBlock.activeSelf == false) // если всё стоит, и не потому что покупка
                {
                    // чтобы это не налезало на звук покупки
                    if (!skills.bought3.isPlaying && !skills.bought2.isPlaying && !skills.bought.isPlaying && zvukbudet == false)
                    {
                        
                        switch (Random.Range(0, 2))
                        {
                            case 1:
                                slotzaniat.Play(0);
                                break;
                            default:
                                slotzaniat2.Play(0);
                                break;
                        }
                    }
                    zvukbudet = false;
                    podsvetTrigger1.SetActive(false);
                    podsvetTrigger2.SetActive(false);
                    podsvetTrigger3.SetActive(false);
                    podsvetTrigger4.SetActive(false);
                    podsvetTrigger5.SetActive(false);
                    podsvetTrigger6.SetActive(false);
                    podsvetTrigger7.SetActive(false);
                    podsvetTrigger8.SetActive(false);
                    podsvetTrigger9.SetActive(false);
                    podsvetTrigger1Connected.SetActive(false);
                    podsvetTrigger2Connected.SetActive(false);
                    podsvetTrigger3Connected.SetActive(false);
                    podsvetTrigger4Connected.SetActive(false);
                    podsvetTrigger5Connected.SetActive(false);
                    podsvetTrigger6Connected.SetActive(false);
                    podsvetTrigger7Connected.SetActive(false);
                    podsvetTrigger8Connected.SetActive(false);
                    podsvetTrigger9Connected.SetActive(false);
                    // вот это перенести после MishenCaller
                    slot1falsMish.SetActive(false);
                    slot2falsMish.SetActive(false);
                    slot3falsMish.SetActive(false);
                    slot4falsMish.SetActive(false);
                    slot5falsMish.SetActive(false);
                    slot6falsMish.SetActive(false);
                    slot7falsMish.SetActive(false);
                    slot8falsMish.SetActive(false);
                    slot9falsMish.SetActive(false);
                    slot1falsMishVraga.SetActive(false);
                    slot2falsMishVraga.SetActive(false);
                    slot3falsMishVraga.SetActive(false);
                    slot4falsMishVraga.SetActive(false);
                    slot5falsMishVraga.SetActive(false);
                    slot6falsMishVraga.SetActive(false);
                    slot7falsMishVraga.SetActive(false);
                    slot8falsMishVraga.SetActive(false);
                    slot9falsMishVraga.SetActive(false);
                    if (mishenHolder.activeSelf == false)
                    {
                        doneOnce = false;
                    }
                }
            }
            Cheker();
        }
        // вне скиллзбэков тоже, раньше было только при нем
        if (doneOnce == false)
        {
            MishenOff();
            Invoke("SlotZapolnitel", 0.2f); // тут задержка, чтобы распределить новые места после движения
            Invoke("MishenCaller", 0.3f); // тут задержка, чтобы прочитать нового родителя

        }
        if (mishenHolder.activeSelf == true) // режим мишеней
        {
            // инвоук репитинг функция-читатель и демонстратор
            InvokeRepeating("MishenReader", 0f, 1f); // тут задержка, чтоб места успели распределиться
                                                     // {
                                                     //     InvokeRepeating("demonstrationMisheni", 0f, 0.5f); // перенесла сюда с инвоуком
                                                     // }
        }
    }

    public void MishenReader()
    {
        // ридер читает всё поле, не только выбранный навык. но подсветки работают только на выбранный

        // скилл 1
        if (slot1skill == 1 && thispartisread == false) // если скил 1 на позиции 1 и эта часть не прочитана
        {
            if (slot1target1 == null) //  если цели не были установлены (навык передвинулся) 
            {
                if (movedSkill == skil1) // если работа с этим скилом
                {
                    // тут устанавливаются дефолтные мишени
                    slot1target1 = slotVraga1;
                    slot1target2 = null;
                    slot1target3 = null;
                }
                else // если это не мувд скилл
                {
                    // тут устанавливаются дефолтные мишени
                    slot1target1 = slotVraga1;
                    slot1target2 = null;
                    slot1target3 = null;
                    thispartisread = true;
                }
            }
            else if (slot1target1 != null) // если цели были установлены (навык не двигался)
            {
                if (movedSkill == skil1) // если работа с этим скилом, тут будуть обновляться мишени
                {
                    if (vybrMishen == null) // мы только включили этот режим
                    {
                        // тут включаются все доступные места после тотального отключения (один раз)
                        slot1mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null) // если игрок выбрал мишень, то начинаются махинации, зависимые от навыка. конкретно этот читает только одну мишень, у остальных будут проверки
                    {
                        slot1target1 = vybrMishen; // эта мишень прочиталась при касании выше
                        slot1target2 = null;
                        slot1target3 = null;
                    }
                }
                else // если это не мувд скилл
                {
                    thispartisread = true;
                }
                // тут зовётся функция демонстрации, показываем текущие (предыдущие/ дефолтные) слот таргеты и возможные слоты на поле, остальные отключаем
                specialtarget1 = slot1target1;
                specialtarget2 = slot1target2;
                specialtarget3 = slot1target3;

            }
        }
        if (slot2skill == 1 && thispartisread1 == false) // если скил 1 на позиции 2 и эта часть не прочитана
        {
            if (slot2target1 == null) //  если цели не были установлены (навык передвинулся) 
            {
                if (movedSkill == skil1) // если работа с этим скилом
                {
                    // тут устанавливаются дефолтные мишени
                    slot2target1 = slotVraga2;
                    slot2target2 = null;
                    slot2target3 = null;
                }
                else // если это не мувд скилл
                {
                    // тут устанавливаются дефолтные мишени
                    slot2target1 = slotVraga2;
                    slot2target2 = null;
                    slot2target3 = null;
                    thispartisread1 = true;
                }
            }
            else if (slot2target1 != null) // если цели были установлены (навык не двигался)
            {
                if (movedSkill == skil1) // если работа с этим скилом, тут будуть обновляться мишени
                {
                    if (vybrMishen == null) // мы только включили этот режим
                    {
                        // тут включаются все доступные места после тотального отключения (один раз)
                        slot2mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null) // если игрок выбрал мишень, то начинаются махинации, зависимые от навыка. конкретно этот читает только одну мишень, у остальных будут проверки
                    {
                        slot2target1 = vybrMishen; // эта мишень прочиталась при касании выше
                        slot2target2 = null;
                        slot2target3 = null;
                    }
                }
                else // если это не мувд скилл
                {
                    thispartisread1 = true;
                }
                // тут зовётся функция демонстрации, показываем текущие (предыдущие/ дефолтные) слот таргеты и возможные слоты на поле, остальные отключаем
                specialtarget1 = slot2target1;
                specialtarget2 = slot2target2;
                specialtarget3 = slot2target3;

            }
        }
        if (slot3skill == 1 && thispartisread2 == false) // если скил 1 на позиции 3 и эта часть не прочитана
        {
            if (slot3target1 == null) //  если цели не были установлены (навык передвинулся) 
            {
                if (movedSkill == skil1) // если работа с этим скилом
                {
                    // тут устанавливаются дефолтные мишени
                    slot3target1 = slotVraga3;
                    slot3target2 = null;
                    slot3target3 = null;
                }
                else // если это не мувд скилл
                {
                    // тут устанавливаются дефолтные мишени
                    slot3target1 = slotVraga3;
                    slot3target2 = null;
                    slot3target3 = null;
                    thispartisread2 = true;
                }
            }
            else if (slot3target1 != null) // если цели были установлены (навык не двигался)
            {
                if (movedSkill == skil1) // если работа с этим скилом, тут будуть обновляться мишени
                {
                    if (vybrMishen == null) // мы только включили этот режим
                    {
                        // тут включаются все доступные места после тотального отключения (один раз)
                        slot3mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null) // если игрок выбрал мишень, то начинаются махинации, зависимые от навыка. конкретно этот читает только одну мишень, у остальных будут проверки
                    {
                        slot3target1 = vybrMishen; // эта мишень прочиталась при касании выше
                        slot3target2 = null;
                        slot3target3 = null;
                    }
                }
                else // если это не мувд скилл
                {
                    thispartisread2 = true;
                }
                // тут зовётся функция демонстрации, показываем текущие (предыдущие/ дефолтные) слот таргеты и возможные слоты на поле, остальные отключаем
                specialtarget1 = slot3target1;
                specialtarget2 = slot3target2;
                specialtarget3 = slot3target3;

            }
        }
        if (slot5skill == 1 && thispartisread3 == false) // если скил 1 на позиции 5 и эта часть не прочитана
        {
            if (slot5target1 == null) //  если цели не были установлены (навык передвинулся) 
            {
                if (movedSkill == skil1) // если работа с этим скилом
                {
                    // тут устанавливаются дефолтные мишени
                    slot5target1 = slotVraga2;
                    slot5target2 = null;
                    slot5target3 = null;
                }
                else // если это не мувд скилл
                {
                    // тут устанавливаются дефолтные мишени
                    slot5target1 = slotVraga2;
                    slot5target2 = null;
                    slot5target3 = null;
                    thispartisread3 = true;
                }
            }
            else if (slot5target1 != null) // если цели были установлены (навык не двигался)
            {
                if (movedSkill == skil1) // если работа с этим скилом, тут будуть обновляться мишени
                {
                    if (vybrMishen == null) // мы только включили этот режим
                    {
                        // тут включаются все доступные места после тотального отключения (один раз)
                        slot2mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null) // если игрок выбрал мишень, то начинаются махинации, зависимые от навыка. конкретно этот читает только одну мишень, у остальных будут проверки
                    {
                        slot5target1 = vybrMishen; // эта мишень прочиталась при касании выше
                        slot5target2 = null;
                        slot5target3 = null;
                    }
                }
                else // если это не мувд скилл
                {
                    thispartisread3 = true;
                }
                // тут зовётся функция демонстрации, показываем текущие (предыдущие/ дефолтные) слот таргеты и возможные слоты на поле, остальные отключаем
                specialtarget1 = slot5target1;
                specialtarget2 = slot5target2;
                specialtarget3 = slot5target3;

            }
        }
        // скилл 2
        if (slot1skill == 2 && thispartisread4 == false) // если скил 2
        {
            if (slot1target1 == null)
            {
                if (movedSkill == skil2)
                {

                    slot1target1 = slotVraga4;
                    slot1target2 = null;
                    slot1target3 = null;
                }
                else
                {

                    slot1target1 = slotVraga4;
                    slot1target2 = null;
                    slot1target3 = null;
                    thispartisread4 = true;
                }
            }
            else if (slot1target1 != null)
            {
                if (movedSkill == skil2)
                {
                    if (vybrMishen == null)
                    {

                        slot4mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot1target1 = vybrMishen;
                        slot1target2 = null;
                        slot1target3 = null;
                    }
                }
                else
                {
                    thispartisread4 = true;
                }
                specialtarget1 = slot1target1;
                specialtarget2 = slot1target2;
                specialtarget3 = slot1target3;

            }
        }
        if (slot2skill == 2 && thispartisread7 == false) // если скил 2
        {
            if (slot2target1 == null)
            {
                if (movedSkill == skil2)
                {

                    slot2target1 = slotVraga5;
                    slot2target2 = null;
                    slot2target3 = null;
                }
                else
                {

                    slot2target1 = slotVraga5;
                    slot2target2 = null;
                    slot2target3 = null;
                    thispartisread7 = true;
                }
            }
            else if (slot2target1 != null)
            {
                if (movedSkill == skil2)
                {
                    if (vybrMishen == null)
                    {

                        slot5mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot2target1 = vybrMishen;
                        slot2target2 = null;
                        slot2target3 = null;
                    }
                }
                else
                {
                    thispartisread7 = true;
                }
                specialtarget1 = slot2target1;
                specialtarget2 = slot2target2;
                specialtarget3 = slot2target3;

            }
        }
        if (slot3skill == 2 && thispartisread5 == false) // если скил 2
        {
            if (slot3target1 == null)
            {
                if (movedSkill == skil2)
                {

                    slot3target1 = slotVraga6;
                    slot3target2 = null;
                    slot3target3 = null;
                }
                else
                {

                    slot3target1 = slotVraga6;
                    slot3target2 = null;
                    slot3target3 = null;
                    thispartisread5 = true;
                }
            }
            else if (slot3target1 != null)
            {
                if (movedSkill == skil2)
                {
                    if (vybrMishen == null)
                    {

                        slot6mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot3target1 = vybrMishen;
                        slot3target2 = null;
                        slot3target3 = null;
                    }
                }
                else
                {
                    thispartisread5 = true;
                }
                specialtarget1 = slot3target1;
                specialtarget2 = slot3target2;
                specialtarget3 = slot3target3;

            }
        }
        if (slot5skill == 2 && thispartisread6 == false) // если скил 2
        {
            if (slot5target1 == null)
            {
                if (movedSkill == skil2)
                {

                    slot5target1 = slotVraga5;
                    slot5target2 = null;
                    slot5target3 = null;
                }
                else
                {

                    slot5target1 = slotVraga5;
                    slot5target2 = null;
                    slot5target3 = null;
                    thispartisread6 = true;
                }
            }
            else if (slot5target1 != null)
            {
                if (movedSkill == skil2)
                {
                    if (vybrMishen == null)
                    {

                        slot5mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot5target1 = vybrMishen;
                        slot5target2 = null;
                        slot5target3 = null;
                    }
                }
                else
                {
                    thispartisread6 = true;
                }
                specialtarget1 = slot5target1;
                specialtarget2 = slot5target2;
                specialtarget3 = slot5target3;

            }
        }
        // скилл 3
        if (slot1skill == 3 && thispartisread8 == false) // если скил 3
        {
            if (slot1target1 == null)
            {
                if (movedSkill == skil3)
                {

                    slot1target1 = slotVraga7;
                    slot1target2 = null;
                    slot1target3 = null;
                }
                else
                {

                    slot1target1 = slotVraga7;
                    slot1target2 = null;
                    slot1target3 = null;
                    thispartisread8 = true;
                }
            }
            else if (slot1target1 != null)
            {
                if (movedSkill == skil3)
                {
                    if (vybrMishen == null)
                    {

                        slot7mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot1target1 = vybrMishen;
                        slot1target2 = null;
                        slot1target3 = null;
                    }
                }
                else
                {
                    thispartisread8 = true;
                }
                specialtarget1 = slot1target1;
                specialtarget2 = slot1target2;
                specialtarget3 = slot1target3;

            }
        }
        if (slot2skill == 3 && thispartisread9 == false) // если скил 3
        {
            if (slot2target1 == null)
            {
                if (movedSkill == skil3)
                {

                    slot2target1 = slotVraga8;
                    slot2target2 = null;
                    slot2target3 = null;
                }
                else
                {

                    slot2target1 = slotVraga8;
                    slot2target2 = null;
                    slot2target3 = null;
                    thispartisread9 = true;
                }
            }
            else if (slot2target1 != null)
            {
                if (movedSkill == skil3)
                {
                    if (vybrMishen == null)
                    {

                        slot8mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot2target1 = vybrMishen;
                        slot2target2 = null;
                        slot2target3 = null;
                    }
                }
                else
                {
                    thispartisread9 = true;
                }
                specialtarget1 = slot2target1;
                specialtarget2 = slot2target2;
                specialtarget3 = slot2target3;

            }
        }
        if (slot3skill == 3 && thispartisread10 == false) // если скил 3
        {
            if (slot3target1 == null)
            {
                if (movedSkill == skil3)
                {

                    slot3target1 = slotVraga9;
                    slot3target2 = null;
                    slot3target3 = null;
                }
                else
                {

                    slot3target1 = slotVraga9;
                    slot3target2 = null;
                    slot3target3 = null;
                    thispartisread10 = true;
                }
            }
            else if (slot3target1 != null)
            {
                if (movedSkill == skil3)
                {
                    if (vybrMishen == null)
                    {

                        slot9mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot3target1 = vybrMishen;
                        slot3target2 = null;
                        slot3target3 = null;
                    }
                }
                else
                {
                    thispartisread10 = true;
                }
                specialtarget1 = slot3target1;
                specialtarget2 = slot3target2;
                specialtarget3 = slot3target3;

            }
        }
        if (slot5skill == 3 && thispartisread11 == false) // если скил 3
        {
            if (slot5target1 == null)
            {
                if (movedSkill == skil3)
                {

                    slot5target1 = slotVraga8;
                    slot5target2 = null;
                    slot5target3 = null;
                }
                else
                {

                    slot5target1 = slotVraga8;
                    slot5target2 = null;
                    slot5target3 = null;
                    thispartisread11 = true;
                }
            }
            else if (slot5target1 != null)
            {
                if (movedSkill == skil3)
                {
                    if (vybrMishen == null)
                    {

                        slot8mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot5target1 = vybrMishen;
                        slot5target2 = null;
                        slot5target3 = null;
                    }
                }
                else
                {
                    thispartisread11 = true;
                }
                specialtarget1 = slot5target1;
                specialtarget2 = slot5target2;
                specialtarget3 = slot5target3;

            }
        }
        // скилл 4
        if (slot1skill == 4 && thispartisread12 == false) // если скил 4
        {
            if (slot1target1 == null)
            {
                if (movedSkill == skil4)
                {

                    slot1target1 = slotVraga1;
                    slot1target2 = null;
                    slot1target3 = null;
                }
                else
                {

                    slot1target1 = slotVraga1;
                    slot1target2 = null;
                    slot1target3 = null;
                    thispartisread12 = true;
                }
            }
            else if (slot1target1 != null)
            {
                if (movedSkill == skil4)
                {
                    if (vybrMishen == null)
                    {

                        slot1mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot1target1 = vybrMishen;
                        slot1target2 = null;
                        slot1target3 = null;
                    }
                }
                else
                {
                    thispartisread12 = true;
                }
                specialtarget1 = slot1target1;
                specialtarget2 = slot1target2;
                specialtarget3 = slot1target3;

            }
        }
        if (slot2skill == 4 && thispartisread13 == false) // если скил 3
        {
            if (slot2target1 == null)
            {
                if (movedSkill == skil4)
                {

                    slot2target1 = slotVraga2;
                    slot2target2 = null;
                    slot2target3 = null;
                }
                else
                {

                    slot2target1 = slotVraga2;
                    slot2target2 = null;
                    slot2target3 = null;
                    thispartisread13 = true;
                }
            }
            else if (slot2target1 != null)
            {
                if (movedSkill == skil4)
                {
                    if (vybrMishen == null)
                    {

                        slot2mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot2target1 = vybrMishen;
                        slot2target2 = null;
                        slot2target3 = null;
                    }
                }
                else
                {
                    thispartisread13 = true;
                }
                specialtarget1 = slot2target1;
                specialtarget2 = slot2target2;
                specialtarget3 = slot2target3;

            }
        }
        if (slot3skill == 4 && thispartisread14 == false) // если скил 3
        {
            if (slot3target1 == null)
            {
                if (movedSkill == skil4)
                {

                    slot3target1 = slotVraga3;
                    slot3target2 = null;
                    slot3target3 = null;
                }
                else
                {

                    slot3target1 = slotVraga3;
                    slot3target2 = null;
                    slot3target3 = null;
                    thispartisread14 = true;
                }
            }
            else if (slot3target1 != null)
            {
                if (movedSkill == skil4)
                {
                    if (vybrMishen == null)
                    {

                        slot3mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot3target1 = vybrMishen;
                        slot3target2 = null;
                        slot3target3 = null;
                    }
                }
                else
                {
                    thispartisread14 = true;
                }
                specialtarget1 = slot3target1;
                specialtarget2 = slot3target2;
                specialtarget3 = slot3target3;

            }
        }
        // скилл 9
        if (slot7skill == 9 && thispartisread15 == false) // если скил 3
        {
            if (slot7target1 == null)
            {
                if (movedSkill == skil9)
                {

                    slot7target1 = slotVraga7;
                    slot7target2 = null;
                    slot7target3 = null;
                }
                else
                {
                    slot7target1 = slotVraga7;
                    slot7target2 = null;
                    slot7target3 = null;
                    thispartisread15 = true;
                }
            }
            else if (slot7target1 != null)
            {
                if (movedSkill == skil9)
                {
                    if (vybrMishen == null)
                    {

                        slot7mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot7target1 = vybrMishen;
                        slot7target2 = null;
                        slot7target3 = null;
                    }
                }
                else
                {
                    thispartisread15 = true;
                }
                specialtarget1 = slot7target1;
                specialtarget2 = slot7target2;
                specialtarget3 = slot7target3;

            }
        }
        if (slot8skill == 9 && thispartisread16 == false) // если скил 3
        {
            if (slot8target1 == null)
            {
                if (movedSkill == skil9)
                {

                    slot8target1 = slotVraga8;
                    slot8target2 = null;
                    slot8target3 = null;
                }
                else
                {

                    slot8target1 = slotVraga8;
                    slot8target2 = null;
                    slot8target3 = null;
                    thispartisread16 = true;
                }
            }
            else if (slot8target1 != null)
            {
                if (movedSkill == skil9)
                {
                    if (vybrMishen == null)
                    {

                        slot8mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot8target1 = vybrMishen;
                        slot8target2 = null;
                        slot8target3 = null;
                    }
                }
                else
                {
                    thispartisread16 = true;
                }
                specialtarget1 = slot8target1;
                specialtarget2 = slot8target2;
                specialtarget3 = slot8target3;

            }
        }
        if (slot9skill == 9 && thispartisread17 == false) // если скил 3
        {
            if (slot9target1 == null)
            {
                if (movedSkill == skil9)
                {

                    slot9target1 = slotVraga9;
                    slot9target2 = null;
                    slot9target3 = null;
                }
                else
                {

                    slot9target1 = slotVraga9;
                    slot9target2 = null;
                    slot9target3 = null;
                    thispartisread17 = true;
                }
            }
            else if (slot9target1 != null)
            {
                if (movedSkill == skil9)
                {
                    if (vybrMishen == null)
                    {

                        slot9mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot9target1 = vybrMishen;
                        slot9target2 = null;
                        slot9target3 = null;
                    }
                }
                else
                {
                    thispartisread17 = true;
                }
                specialtarget1 = slot9target1;
                specialtarget2 = slot9target2;
                specialtarget3 = slot9target3;

            }
        }
        // скилл 6
        if (slot4skill == 6 && thispartisread18 == false) // если скил 6
        {
            if (slot4target1 == null)
            {
                if (movedSkill == skil6)
                {

                    slot4target1 = slotGG1;
                    slot4target2 = null;
                    slot4target3 = null;
                }
                else
                {

                    slot4target1 = slotGG1;
                    slot4target2 = null;
                    slot4target3 = null;
                    thispartisread18 = true;
                }
            }
            else if (slot4target1 != null)
            {
                if (movedSkill == skil6)
                {
                    if (vybrMishen == null)
                    {

                        slot1mish.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot4target1 = vybrMishen;
                        slot4target2 = null;
                        slot4target3 = null;
                    }
                }
                else
                {
                    thispartisread18 = true;
                }
                specialtarget1 = slot4target1;
                specialtarget2 = slot4target2;
                specialtarget3 = slot4target3;

            }
        }
        if (slot6skill == 6 && thispartisread19 == false) // если скил 6
        {
            if (slot6target1 == null)
            {
                if (movedSkill == skil6)
                {

                    slot6target1 = slotGG3;
                    slot6target2 = null;
                    slot6target3 = null;
                }
                else
                {

                    slot6target1 = slotGG3;
                    slot6target2 = null;
                    slot6target3 = null;
                    thispartisread19 = true;
                }
            }
            else if (slot6target1 != null)
            {
                if (movedSkill == skil6)
                {
                    if (vybrMishen == null)
                    {

                        slot3mish.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot6target1 = vybrMishen;
                        slot6target2 = null;
                        slot6target3 = null;
                    }
                }
                else
                {
                    thispartisread19 = true;
                }
                specialtarget1 = slot6target1;
                specialtarget2 = slot6target2;
                specialtarget3 = slot6target3;

            }
        }
        if (slot7skill == 6 && thispartisread20 == false) // если скил 6
        {
            if (slot7target1 == null)
            {
                if (movedSkill == skil6)
                {

                    slot7target1 = slotGG4;
                    slot7target2 = null;
                    slot7target3 = null;
                }
                else
                {

                    slot7target1 = slotGG4;
                    slot7target2 = null;
                    slot7target3 = null;
                    thispartisread20 = true;
                }
            }
            else if (slot7target1 != null)
            {
                if (movedSkill == skil6)
                {
                    if (vybrMishen == null)
                    {

                        slot4mish.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot7target1 = vybrMishen;
                        slot7target2 = null;
                        slot7target3 = null;
                    }
                }
                else
                {
                    thispartisread20 = true;
                }
                specialtarget1 = slot7target1;
                specialtarget2 = slot7target2;
                specialtarget3 = slot7target3;

            }
        }
        if (slot8skill == 6 && thispartisread21 == false) // если скил 6
        {
            if (slot8target1 == null)
            {
                if (movedSkill == skil6)
                {

                    slot8target1 = slotGG5;
                    slot8target2 = null;
                    slot8target3 = null;
                }
                else
                {

                    slot8target1 = slotGG5;
                    slot8target2 = null;
                    slot8target3 = null;
                    thispartisread21 = true;
                }
            }
            else if (slot8target1 != null)
            {
                if (movedSkill == skil6)
                {
                    if (vybrMishen == null)
                    {

                        slot5mish.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot8target1 = vybrMishen;
                        slot8target2 = null;
                        slot8target3 = null;
                    }
                }
                else
                {
                    thispartisread21 = true;
                }
                specialtarget1 = slot8target1;
                specialtarget2 = slot8target2;
                specialtarget3 = slot8target3;

            }
        }
        if (slot9skill == 6 && thispartisread21 == false) // если скил 6
        {
            if (slot9target1 == null)
            {
                if (movedSkill == skil6)
                {

                    slot9target1 = slotGG6;
                    slot9target2 = null;
                    slot9target3 = null;
                }
                else
                {

                    slot9target1 = slotGG6;
                    slot9target2 = null;
                    slot9target3 = null;
                    thispartisread21 = true;
                }
            }
            else if (slot9target1 != null)
            {
                if (movedSkill == skil6)
                {
                    if (vybrMishen == null)
                    {

                        slot6mish.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot9target1 = vybrMishen;
                        slot9target2 = null;
                        slot9target3 = null;
                    }
                }
                else
                {
                    thispartisread21 = true;
                }
                specialtarget1 = slot9target1;
                specialtarget2 = slot9target2;
                specialtarget3 = slot9target3;

            }
        }
        // скилл 8
        if (slot4skill == 8 && thispartisread26 == false) // если скил 8
        {
            if (slot4target1 == null)
            {
                if (movedSkill == skil8)
                {

                    slot4target1 = slotGG1;
                    slot4target2 = null;
                    slot4target3 = null;
                }
                else
                {

                    slot4target1 = slotGG1;
                    slot4target2 = null;
                    slot4target3 = null;
                    thispartisread26 = true;
                }
            }
            else if (slot4target1 != null)
            {
                if (movedSkill == skil8)
                {
                    if (vybrMishen == null)
                    {

                        slot1mish.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot4target1 = vybrMishen;
                        slot4target2 = null;
                        slot4target3 = null;
                    }
                }
                else
                {
                    thispartisread26 = true;
                }
                specialtarget1 = slot4target1;
                specialtarget2 = slot4target2;
                specialtarget3 = slot4target3;

            }
        }
        if (slot6skill == 8 && thispartisread27 == false) // если скил 8
        {
            if (slot6target1 == null)
            {
                if (movedSkill == skil8)
                {

                    slot6target1 = slotGG3;
                    slot6target2 = null;
                    slot6target3 = null;
                }
                else
                {

                    slot6target1 = slotGG3;
                    slot6target2 = null;
                    slot6target3 = null;
                    thispartisread27 = true;
                }
            }
            else if (slot6target1 != null)
            {
                if (movedSkill == skil8)
                {
                    if (vybrMishen == null)
                    {

                        slot3mish.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot6target1 = vybrMishen;
                        slot6target2 = null;
                        slot6target3 = null;
                    }
                }
                else
                {
                    thispartisread27 = true;
                }
                specialtarget1 = slot6target1;
                specialtarget2 = slot6target2;
                specialtarget3 = slot6target3;

            }
        }
        if (slot7skill == 8 && thispartisread28 == false) // если скил 8
        {
            if (slot7target1 == null)
            {
                if (movedSkill == skil8)
                {

                    slot7target1 = slotGG4;
                    slot7target2 = null;
                    slot7target3 = null;
                }
                else
                {

                    slot7target1 = slotGG4;
                    slot7target2 = null;
                    slot7target3 = null;
                    thispartisread28 = true;
                }
            }
            else if (slot7target1 != null)
            {
                if (movedSkill == skil8)
                {
                    if (vybrMishen == null)
                    {

                        slot4mish.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot7target1 = vybrMishen;
                        slot7target2 = null;
                        slot7target3 = null;
                    }
                }
                else
                {
                    thispartisread28 = true;
                }
                specialtarget1 = slot7target1;
                specialtarget2 = slot7target2;
                specialtarget3 = slot7target3;

            }
        }
        if (slot8skill == 8 && thispartisread29 == false) // если скил 8
        {
            if (slot8target1 == null)
            {
                if (movedSkill == skil8)
                {

                    slot8target1 = slotGG5;
                    slot8target2 = null;
                    slot8target3 = null;
                }
                else
                {

                    slot8target1 = slotGG5;
                    slot8target2 = null;
                    slot8target3 = null;
                    thispartisread29 = true;
                }
            }
            else if (slot8target1 != null)
            {
                if (movedSkill == skil8)
                {
                    if (vybrMishen == null)
                    {

                        slot5mish.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot8target1 = vybrMishen;
                        slot8target2 = null;
                        slot8target3 = null;
                    }
                }
                else
                {
                    thispartisread29 = true;
                }
                specialtarget1 = slot8target1;
                specialtarget2 = slot8target2;
                specialtarget3 = slot8target3;

            }
        }
        if (slot9skill == 8 && thispartisread29 == false) // если скил 8
        {
            if (slot9target1 == null)
            {
                if (movedSkill == skil8)
                {

                    slot9target1 = slotGG6;
                    slot9target2 = null;
                    slot9target3 = null;
                }
                else
                {

                    slot9target1 = slotGG6;
                    slot9target2 = null;
                    slot9target3 = null;
                    thispartisread29 = true;
                }
            }
            else if (slot9target1 != null)
            {
                if (movedSkill == skil8)
                {
                    if (vybrMishen == null)
                    {

                        slot6mish.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot9target1 = vybrMishen;
                        slot9target2 = null;
                        slot9target3 = null;
                    }
                }
                else
                {
                    thispartisread29 = true;
                }
                specialtarget1 = slot9target1;
                specialtarget2 = slot9target2;
                specialtarget3 = slot9target3;

            }
        }
        // скилл 5
        if (slot4skill == 5 && thispartisread30 == false) // если скил 5
        {
            if (slot4target1 == null)
            {
                if (movedSkill == skil5)
                {

                    slot4target1 = slotGG1;
                    slot4target2 = null;
                    slot4target3 = null;
                }
                else
                {
                    slot4target1 = slotGG1;
                    slot4target2 = null;
                    slot4target3 = null;
                    thispartisread30 = true;
                }
            }
            else if (slot4target1 != null)
            {
                if (movedSkill == skil5)
                {
                    if (vybrMishen == null)
                    {
                        slot1mish.SetActive(true);
                        slot2mish.SetActive(true);
                        slot3mish.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot4target1 = vybrMishen;
                        slot4target2 = null;
                        slot4target3 = null;
                    }
                }
                else
                {
                    thispartisread30 = true;
                }
                specialtarget1 = slot4target1;
                specialtarget2 = slot4target2;
                specialtarget3 = slot4target3;

            }
        }
        if (slot5skill == 5 && thispartisread31 == false) // если скил 5
        {
            if (slot5target1 == null)
            {
                if (movedSkill == skil5)
                {

                    slot5target1 = slotGG1;
                    slot5target2 = null;
                    slot5target3 = null;
                }
                else
                {

                    slot5target1 = slotGG1;
                    slot5target2 = null;
                    slot5target3 = null;
                    thispartisread31 = true;
                }
            }
            else if (slot5target1 != null)
            {
                if (movedSkill == skil5)
                {
                    if (vybrMishen == null)
                    {
                        slot1mish.SetActive(true);
                        slot2mish.SetActive(true);
                        slot3mish.SetActive(true);
                        slot4mish.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot5target1 = vybrMishen;
                        slot5target2 = null;
                        slot5target3 = null;
                    }
                }
                else
                {
                    thispartisread31 = true;
                }
                specialtarget1 = slot5target1;
                specialtarget2 = slot5target2;
                specialtarget3 = slot5target3;

            }
        }
        if (slot6skill == 5 && thispartisread32 == false) // если скил 5
        {
            if (slot6target1 == null)
            {
                if (movedSkill == skil5)
                {

                    slot6target1 = slotGG1;
                    slot6target2 = null;
                    slot6target3 = null;
                }
                else
                {

                    slot6target1 = slotGG1;
                    slot6target2 = null;
                    slot6target3 = null;
                    thispartisread32 = true;
                }
            }
            else if (slot6target1 != null)
            {
                if (movedSkill == skil5)
                {
                    if (vybrMishen == null)
                    {
                        slot1mish.SetActive(true);
                        slot2mish.SetActive(true);
                        slot3mish.SetActive(true);
                        slot4mish.SetActive(true);
                        slot5mish.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot6target1 = vybrMishen;
                        slot6target2 = null;
                        slot6target3 = null;
                    }
                }
                else
                {
                    thispartisread32 = true;
                }
                specialtarget1 = slot6target1;
                specialtarget2 = slot6target2;
                specialtarget3 = slot6target3;

            }
        }
        // скилл 10
        if (slot2skill == 10 && thispartisread33 == false)
        {
            if (slot2target1 == null)
            {
                if (movedSkill == skil10)
                {

                    slot2target1 = slotGG5;
                    slot2target2 = slotGG8;
                    slot2target3 = null;
                }
                else
                {

                    slot2target1 = slotGG5;
                    slot2target2 = slotGG8;
                    slot2target3 = null;
                    thispartisread33 = true;
                }
            }
            else if (slot2target1 != null)
            {
                if (movedSkill == skil10)
                {
                    if (vybrMishen == null)
                    {

                        slot5mish.SetActive(true);
                        slot8mish.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                    }
                }
                else
                {
                    thispartisread33 = true;
                }

                specialtarget1 = slot2target1;
                specialtarget2 = slot2target2;
                specialtarget3 = slot2target3;

            }
        }
        if (slot4skill == 10 && thispartisread34 == false)
        {
            if (slot4target1 == null)
            {
                if (movedSkill == skil10)
                {

                    slot4target1 = slotGG7;
                    slot4target2 = null;
                    slot4target3 = null;
                }
                else
                {

                    slot4target1 = slotGG7;
                    slot4target2 = null;
                    slot4target3 = null;
                    thispartisread34 = true;
                }
            }
            else if (slot4target1 != null)
            {
                if (movedSkill == skil10)
                {
                    if (vybrMishen == null)
                    {

                        slot7mish.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot4target1 = vybrMishen;
                        slot4target2 = null;
                        slot4target3 = null;
                    }
                }
                else
                {
                    thispartisread34 = true;
                }

                specialtarget1 = slot4target1;
                specialtarget2 = slot4target2;
                specialtarget3 = slot4target3;

            }
        }
        if (slot6skill == 10 && thispartisread35 == false)
        {
            if (slot6target1 == null)
            {
                if (movedSkill == skil10)
                {

                    slot6target1 = slotGG9;
                    slot6target2 = null;
                    slot6target3 = null;
                }
                else
                {

                    slot6target1 = slotGG9;
                    slot6target2 = null;
                    slot6target3 = null;
                    thispartisread35 = true;
                }
            }
            else if (slot6target1 != null)
            {
                if (movedSkill == skil10)
                {
                    if (vybrMishen == null)
                    {

                        slot9mish.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot6target1 = vybrMishen;
                        slot6target2 = null;
                        slot6target3 = null;
                    }
                }
                else
                {
                    thispartisread35 = true;
                }

                specialtarget1 = slot6target1;
                specialtarget2 = slot6target2;
                specialtarget3 = slot6target3;

            }
        }
        // скилл 11
        if (slot1skill == 11 && thispartisread36 == false)
        {
            if (slot1target1 == null)
            {
                if (movedSkill == skil11)
                {

                    slot1target1 = slotGG4;
                    slot1target2 = slotGG7;
                    slot1target3 = null;
                }
                else
                {

                    slot1target1 = slotGG4;
                    slot1target2 = slotGG7;
                    slot1target3 = null;
                    thispartisread36 = true;
                }
            }
            else if (slot1target1 != null)
            {
                if (movedSkill == skil11)
                {
                    if (vybrMishen == null)
                    {

                        slot4mish.SetActive(true);
                        slot7mish.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                    }
                }
                else
                {
                    thispartisread36 = true;
                }

                specialtarget1 = slot1target1;
                specialtarget2 = slot1target2;
                specialtarget3 = slot1target3;

            }
        }
        if (slot3skill == 11 && thispartisread37 == false)
        {
            if (slot3target1 == null)
            {
                if (movedSkill == skil11)
                {

                    slot3target1 = slotGG6;
                    slot3target2 = slotGG9;
                    slot3target3 = null;
                }
                else
                {

                    slot3target1 = slotGG6;
                    slot3target2 = slotGG9;
                    slot3target3 = null;
                    thispartisread37 = true;
                }
            }
            else if (slot3target1 != null)
            {
                if (movedSkill == skil11)
                {
                    if (vybrMishen == null)
                    {

                        slot6mish.SetActive(true);
                        slot9mish.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                    }
                }
                else
                {
                    thispartisread37 = true;
                }

                specialtarget1 = slot3target1;
                specialtarget2 = slot3target2;
                specialtarget3 = slot3target3;

            }
        }
        if (slot5skill == 11 && thispartisread38 == false)
        {
            if (slot5target1 == null)
            {
                if (movedSkill == skil11)
                {

                    slot5target1 = slotGG8;
                    slot5target2 = null;
                    slot5target3 = null;
                }
                else
                {

                    slot5target1 = slotGG8;
                    slot5target2 = null;
                    slot5target3 = null;
                    thispartisread38 = true;
                }
            }
            else if (slot5target1 != null)
            {
                if (movedSkill == skil11)
                {
                    if (vybrMishen == null)
                    {

                        slot8mish.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                    }
                }
                else
                {
                    thispartisread38 = true;
                }

                specialtarget1 = slot5target1;
                specialtarget2 = slot5target2;
                specialtarget3 = slot5target3;

            }
        }
        // скилл 12
        if (slot4skill == 12 && thispartisread39 == false) // если скил 5
        {
            if (slot4target1 == null)
            {
                if (movedSkill == skil12)
                {

                    slot4target1 = slotGG5;
                    slot4target2 = null;
                    slot4target3 = null;
                }
                else
                {
                    slot4target1 = slotGG5;
                    slot4target2 = null;
                    slot4target3 = null;
                    thispartisread39 = true;
                }
            }
            else if (slot4target1 != null)
            {
                if (movedSkill == skil12)
                {
                    if (vybrMishen == null)
                    {
                        slot5mish.SetActive(true);
                        slot6mish.SetActive(true);
                        slot7mish.SetActive(true);
                        slot8mish.SetActive(true);
                        slot9mish.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot4target1 = vybrMishen;
                        slot4target2 = null;
                        slot4target3 = null;
                    }
                }
                else
                {
                    thispartisread39 = true;
                }
                specialtarget1 = slot4target1;
                specialtarget2 = slot4target2;
                specialtarget3 = slot4target3;

            }
        }
        if (slot5skill == 12 && thispartisread40 == false) // если скил 5
        {
            if (slot5target1 == null)
            {
                if (movedSkill == skil12)
                {

                    slot5target1 = slotGG6;
                    slot5target2 = null;
                    slot5target3 = null;
                }
                else
                {

                    slot5target1 = slotGG6;
                    slot5target2 = null;
                    slot5target3 = null;
                    thispartisread40 = true;
                }
            }
            else if (slot5target1 != null)
            {
                if (movedSkill == skil12)
                {
                    if (vybrMishen == null)
                    {
                        slot6mish.SetActive(true);
                        slot7mish.SetActive(true);
                        slot8mish.SetActive(true);
                        slot9mish.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot5target1 = vybrMishen;
                        slot5target2 = null;
                        slot5target3 = null;
                    }
                }
                else
                {
                    thispartisread40 = true;
                }
                specialtarget1 = slot5target1;
                specialtarget2 = slot5target2;
                specialtarget3 = slot5target3;

            }
        }
        if (slot6skill == 12 && thispartisread41 == false) // если скил 5
        {
            if (slot6target1 == null)
            {
                if (movedSkill == skil12)
                {

                    slot6target1 = slotGG7;
                    slot6target2 = null;
                    slot6target3 = null;
                }
                else
                {

                    slot6target1 = slotGG7;
                    slot6target2 = null;
                    slot6target3 = null;
                    thispartisread41 = true;
                }
            }
            else if (slot6target1 != null)
            {
                if (movedSkill == skil12)
                {
                    if (vybrMishen == null)
                    {
                        slot7mish.SetActive(true);
                        slot8mish.SetActive(true);
                        slot9mish.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot6target1 = vybrMishen;
                        slot6target2 = null;
                        slot6target3 = null;
                    }
                }
                else
                {
                    thispartisread41 = true;
                }
                specialtarget1 = slot6target1;
                specialtarget2 = slot6target2;
                specialtarget3 = slot6target3;

            }
        }
        // скилл 13
        if (slot4skill == 13 && thispartisread42 == false) // если скил 5
        {
            if (slot4target1 == null)
            {
                if (movedSkill == skil13)
                {

                    slot4target1 = slotVraga1;
                    slot4target2 = null;
                    slot4target3 = null;
                }
                else
                {
                    slot4target1 = slotVraga1;
                    slot4target2 = null;
                    slot4target3 = null;
                    thispartisread42 = true;
                }
            }
            else if (slot4target1 != null)
            {
                if (movedSkill == skil13)
                {
                    if (vybrMishen == null)
                    {
                        slot1mishVraga.SetActive(true);
                        slot4mishVraga.SetActive(true);
                        slot7mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot4target1 = vybrMishen;
                        slot4target2 = null;
                        slot4target3 = null;
                    }
                }
                else
                {
                    thispartisread42 = true;
                }
                specialtarget1 = slot4target1;
                specialtarget2 = slot4target2;
                specialtarget3 = slot4target3;

            }
        }
        if (slot6skill == 13 && thispartisread44 == false) // если скил 5
        {
            if (slot6target1 == null)
            {
                if (movedSkill == skil13)
                {

                    slot6target1 = slotVraga3;
                    slot6target2 = null;
                    slot6target3 = null;
                }
                else
                {

                    slot6target1 = slotVraga3;
                    slot6target2 = null;
                    slot6target3 = null;
                    thispartisread44 = true;
                }
            }
            else if (slot6target1 != null)
            {
                if (movedSkill == skil13)
                {
                    if (vybrMishen == null)
                    {
                        slot3mishVraga.SetActive(true);
                        slot6mishVraga.SetActive(true);
                        slot9mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot6target1 = vybrMishen;
                        slot6target2 = null;
                        slot6target3 = null;
                    }
                }
                else
                {
                    thispartisread44 = true;
                }
                specialtarget1 = slot6target1;
                specialtarget2 = slot6target2;
                specialtarget3 = slot6target3;

            }
        }
        // скилл 14
        if (slot7skill == 14 && thispartisread45 == false) // если скил 5
        {
            if (slot7target1 == null)
            {
                if (movedSkill == skil14)
                {

                    slot7target1 = slotVraga1;
                    slot7target2 = null;
                    slot7target3 = null;
                }
                else
                {
                    slot7target1 = slotVraga1;
                    slot7target2 = null;
                    slot7target3 = null;
                    thispartisread45 = true;
                }
            }
            else if (slot7target1 != null)
            {
                if (movedSkill == skil14)
                {
                    if (vybrMishen == null)
                    {
                        slot1mishVraga.SetActive(true);
                        slot4mishVraga.SetActive(true);
                        slot7mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot7target1 = vybrMishen;
                        slot7target2 = null;
                        slot7target3 = null;
                    }
                }
                else
                {
                    thispartisread45 = true;
                }
                specialtarget1 = slot7target1;
                specialtarget2 = slot7target2;
                specialtarget3 = slot7target3;

            }
        }
        if (slot9skill == 14 && thispartisread46 == false) // если скил 5
        {
            if (slot9target1 == null)
            {
                if (movedSkill == skil14)
                {

                    slot9target1 = slotVraga3;
                    slot9target2 = null;
                    slot9target3 = null;
                }
                else
                {

                    slot9target1 = slotVraga3;
                    slot9target2 = null;
                    slot9target3 = null;
                    thispartisread46 = true;
                }
            }
            else if (slot9target1 != null)
            {
                if (movedSkill == skil14)
                {
                    if (vybrMishen == null)
                    {
                        slot3mishVraga.SetActive(true);
                        slot6mishVraga.SetActive(true);
                        slot9mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot9target1 = vybrMishen;
                        slot9target2 = null;
                        slot9target3 = null;
                    }
                }
                else
                {
                    thispartisread46 = true;
                }
                specialtarget1 = slot9target1;
                specialtarget2 = slot9target2;
                specialtarget3 = slot9target3;

            }
        }
        // скил 15
        if (slot4skill == 15 && thispartisread47 == false) // если скил 3
        {
            if (slot4target1 == null)
            {
                if (movedSkill == skil15)
                {

                    slot4target1 = slotVraga4;
                    slot4target2 = null;
                    slot4target3 = null;
                }
                else
                {
                    slot4target1 = slotVraga4;
                    slot4target2 = null;
                    slot4target3 = null;
                    thispartisread47 = true;
                }
            }
            else if (slot4target1 != null)
            {
                if (movedSkill == skil15)
                {
                    if (vybrMishen == null)
                    {

                        slot4mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot4target1 = vybrMishen;
                        slot4target2 = null;
                        slot4target3 = null;
                    }
                }
                else
                {
                    thispartisread47 = true;
                }
                specialtarget1 = slot4target1;
                specialtarget2 = slot4target2;
                specialtarget3 = slot4target3;

            }
        }
        if (slot5skill == 15 && thispartisread48 == false) // если скил 3
        {
            if (slot5target1 == null)
            {
                if (movedSkill == skil15)
                {

                    slot5target1 = slotVraga5;
                    slot5target2 = null;
                    slot5target3 = null;
                }
                else
                {

                    slot5target1 = slotVraga5;
                    slot5target2 = null;
                    slot5target3 = null;
                    thispartisread48 = true;
                }
            }
            else if (slot5target1 != null)
            {
                if (movedSkill == skil15)
                {
                    if (vybrMishen == null)
                    {

                        slot5mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot5target1 = vybrMishen;
                        slot5target2 = null;
                        slot5target3 = null;
                    }
                }
                else
                {
                    thispartisread48 = true;
                }
                specialtarget1 = slot5target1;
                specialtarget2 = slot5target2;
                specialtarget3 = slot5target3;

            }
        }
        if (slot6skill == 15 && thispartisread49 == false) // если скил 3
        {
            if (slot6target1 == null)
            {
                if (movedSkill == skil15)
                {

                    slot6target1 = slotVraga6;
                    slot6target2 = null;
                    slot6target3 = null;
                }
                else
                {

                    slot6target1 = slotVraga6;
                    slot6target2 = null;
                    slot6target3 = null;
                    thispartisread49 = true;
                }
            }
            else if (slot6target1 != null)
            {
                if (movedSkill == skil15)
                {
                    if (vybrMishen == null)
                    {

                        slot6mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot6target1 = vybrMishen;
                        slot6target2 = null;
                        slot6target3 = null;
                    }
                }
                else
                {
                    thispartisread49 = true;
                }
                specialtarget1 = slot6target1;
                specialtarget2 = slot6target2;
                specialtarget3 = slot6target3;

            }
        }
        // скилл 16
        if (slot7skill == 16 && thispartisread50 == false)
        {
            if (slot7target1 == null)
            {
                if (movedSkill == skil16)
                {

                    slot7target1 = slotVraga7;
                    slot7target2 = slotVraga4;
                    slot7target3 = null;
                }
                else
                {

                    slot7target1 = slotVraga7;
                    slot7target2 = slotVraga4;
                    slot7target3 = null;
                    thispartisread50 = true;
                }
            }
            else if (slot7target1 != null)
            {
                if (movedSkill == skil16)
                {
                    if (vybrMishen == null)
                    {

                        slot7mishVraga.SetActive(true);
                        slot8mishVraga.SetActive(true);
                        slot4mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot7target1 = slotVraga7;
                        if (vybrMishen != slotVraga7) // если выбирали между 4 и 8, что-то изменится, см. может было обнуление
                        {
                            slot7target2 = vybrMishen;
                        }
                        slot7target3 = null;
                    }
                }
                else
                {
                    thispartisread50 = true;
                }

                specialtarget1 = slot7target1;
                specialtarget2 = slot7target2;
                specialtarget3 = slot7target3;

            }
        }
        if (slot8skill == 16 && thispartisread51 == false)
        {
            if (slot8target1 == null)
            {
                if (movedSkill == skil16)
                {

                    slot8target1 = slotVraga8;
                    slot8target2 = slotVraga9;
                    slot8target3 = null;
                }
                else
                {

                    slot8target1 = slotVraga8;
                    slot8target2 = slotVraga9;
                    slot8target3 = null;
                    thispartisread51 = true;
                }
            }
            else if (slot8target1 != null)
            {
                if (movedSkill == skil16)
                {
                    if (vybrMishen == null)
                    {

                        slot8mishVraga.SetActive(true);
                        slot7mishVraga.SetActive(true);
                        slot5mishVraga.SetActive(true);
                        slot9mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot8target1 = slotVraga8;
                        if (vybrMishen != slotVraga8)
                        {
                            slot8target2 = vybrMishen;
                        }
                        slot8target3 = null;
                    }
                }
                else
                {
                    thispartisread51 = true;
                }

                specialtarget1 = slot8target1;
                specialtarget2 = slot8target2;
                specialtarget3 = slot8target3;

            }
        }
        if (slot9skill == 16 && thispartisread52 == false)
        {
            if (slot9target1 == null)
            {
                if (movedSkill == skil16)
                {

                    slot9target1 = slotVraga9;
                    slot9target2 = slotVraga8;
                    slot9target3 = null;
                }
                else
                {

                    slot9target1 = slotVraga9;
                    slot9target2 = slotVraga8;
                    slot9target3 = null;
                    thispartisread52 = true;
                }
            }
            else if (slot9target1 != null)
            {
                if (movedSkill == skil16)
                {
                    if (vybrMishen == null)
                    {

                        slot9mishVraga.SetActive(true);
                        slot6mishVraga.SetActive(true);
                        slot8mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot9target1 = slotVraga9;
                        if (vybrMishen != slotVraga9)
                        {
                            slot9target2 = vybrMishen;
                        }
                        slot9target3 = null;
                    }
                }
                else
                {
                    thispartisread52 = true;
                }

                specialtarget1 = slot9target1;
                specialtarget2 = slot9target2;
                specialtarget3 = slot9target3;

            }
        }
        // скилл 17
        if (slot1skill == 17 && thispartisread53 == false)
        {
            if (slot1target1 == null)
            {
                if (movedSkill == skil17)
                {

                    slot1target1 = slotVraga1;
                    slot1target2 = slotVraga4;
                    slot1target3 = null;
                }
                else
                {

                    slot1target1 = slotVraga1;
                    slot1target2 = slotVraga4;
                    slot1target3 = null;
                    thispartisread53 = true;
                }
            }
            else if (slot1target1 != null)
            {
                if (movedSkill == skil17)
                {
                    if (vybrMishen == null)
                    {

                        slot1mishVraga.SetActive(true);
                        slot2mishVraga.SetActive(true);
                        slot4mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot1target1 = slotVraga1;
                        if (vybrMishen != slotVraga1)
                        {
                            slot1target2 = vybrMishen;
                        }
                        slot1target3 = null;
                    }
                }
                else
                {
                    thispartisread53 = true;
                }

                specialtarget1 = slot1target1;
                specialtarget2 = slot1target2;
                specialtarget3 = slot1target3;

            }
        }
        if (slot2skill == 17 && thispartisread54 == false)
        {
            if (slot2target1 == null)
            {
                if (movedSkill == skil17)
                {

                    slot2target1 = slotVraga2;
                    slot2target2 = slotVraga5;
                    slot2target3 = null;
                }
                else
                {

                    slot2target1 = slotVraga2;
                    slot2target2 = slotVraga5;
                    slot2target3 = null;
                    thispartisread54 = true;
                }
            }
            else if (slot2target1 != null)
            {
                if (movedSkill == skil17)
                {
                    if (vybrMishen == null)
                    {

                        slot2mishVraga.SetActive(true);
                        slot1mishVraga.SetActive(true);
                        slot3mishVraga.SetActive(true);
                        slot5mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot2target1 = slotVraga2;
                        if (vybrMishen != slotVraga2)
                        {
                            slot2target2 = vybrMishen;
                        }
                        slot2target3 = null;
                    }
                }
                else
                {
                    thispartisread54 = true;
                }

                specialtarget1 = slot2target1;
                specialtarget2 = slot2target2;
                specialtarget3 = slot2target3;

            }
        }
        if (slot3skill == 17 && thispartisread55 == false)
        {
            if (slot3target1 == null)
            {
                if (movedSkill == skil17)
                {

                    slot3target1 = slotVraga3;
                    slot3target2 = slotVraga6;
                    slot3target3 = null;
                }
                else
                {

                    slot3target1 = slotVraga3;
                    slot3target2 = slotVraga6;
                    slot3target3 = null;
                    thispartisread55 = true;
                }
            }
            else if (slot3target1 != null)
            {
                if (movedSkill == skil17)
                {
                    if (vybrMishen == null)
                    {

                        slot3mishVraga.SetActive(true);
                        slot6mishVraga.SetActive(true);
                        slot2mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot3target1 = slotVraga3;
                        if (vybrMishen != slotVraga3)
                        {
                            slot3target2 = vybrMishen;
                        }
                        slot3target3 = null;
                    }
                }
                else
                {
                    thispartisread55 = true;
                }

                specialtarget1 = slot3target1;
                specialtarget2 = slot3target2;
                specialtarget3 = slot3target3;

            }
        }
        // скилл 18
        if (slot1skill == 18 && thispartisread56 == false)
        {
            if (slot1target1 == null)
            {
                if (movedSkill == skil18)
                {

                    slot1target1 = slotGG1;
                    slot1target2 = slotGG4;
                    slot1target3 = null;
                }
                else
                {

                    slot1target1 = slotGG1;
                    slot1target2 = slotGG4;
                    slot1target3 = null;
                    thispartisread56 = true;
                }
            }
            else if (slot1target1 != null)
            {
                if (movedSkill == skil18)
                {
                    if (vybrMishen == null)
                    {

                        slot1mish.SetActive(true);
                        slot4mish.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                    }
                }
                else
                {
                    thispartisread56 = true;
                }

                specialtarget1 = slot1target1;
                specialtarget2 = slot1target2;
                specialtarget3 = slot1target3;

            }
        }
        if (slot2skill == 18 && thispartisread57 == false)
        {
            if (slot2target1 == null)
            {
                if (movedSkill == skil18)
                {

                    slot2target1 = slotGG2;
                    slot2target2 = slotGG5;
                    slot2target3 = null;
                }
                else
                {

                    slot2target1 = slotGG2;
                    slot2target2 = slotGG5;
                    slot2target3 = null;
                    thispartisread57 = true;
                }
            }
            else if (slot2target1 != null)
            {
                if (movedSkill == skil18)
                {
                    if (vybrMishen == null)
                    {

                        slot2mish.SetActive(true);
                        slot5mish.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                    }
                }
                else
                {
                    thispartisread57 = true;
                }

                specialtarget1 = slot2target1;
                specialtarget2 = slot2target2;
                specialtarget3 = slot2target3;

            }
        }
        if (slot3skill == 18 && thispartisread58 == false)
        {
            if (slot3target1 == null)
            {
                if (movedSkill == skil18)
                {

                    slot3target1 = slotGG3;
                    slot3target2 = slotGG6;
                    slot3target3 = null;
                }
                else
                {

                    slot3target1 = slotGG3;
                    slot3target2 = slotGG6;
                    slot3target3 = null;
                    thispartisread58 = true;
                }
            }
            else if (slot3target1 != null)
            {
                if (movedSkill == skil18)
                {
                    if (vybrMishen == null)
                    {

                        slot3mish.SetActive(true);
                        slot6mish.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                    }
                }
                else
                {
                    thispartisread58 = true;
                }

                specialtarget1 = slot3target1;
                specialtarget2 = slot3target2;
                specialtarget3 = slot3target3;

            }
        }
        // скилл 19
        if (slot4skill == 19 && thispartisread59 == false)
        {
            if (slot4target1 == null)
            {
                if (movedSkill == skil19)
                {

                    slot4target1 = slotVraga7;
                    slot4target2 = null;
                    slot4target3 = null;
                }
                else
                {

                    slot4target1 = slotVraga7;
                    slot4target2 = null;
                    slot4target3 = null;
                    thispartisread59 = true;
                }
            }
            else if (slot4target1 != null)
            {
                if (movedSkill == skil19)
                {
                    if (vybrMishen == null)
                    {

                        slot1mishVraga.SetActive(true);
                        slot4mishVraga.SetActive(true);
                        slot7mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot4target1 = vybrMishen;
                        slot4target2 = null;
                        slot4target3 = null;
                    }
                }
                else
                {
                    thispartisread59 = true;
                }

                specialtarget1 = slot4target1;
                specialtarget2 = slot4target2;
                specialtarget3 = slot4target3;

            }
        }
        if (slot5skill == 19 && thispartisread60 == false)
        {
            if (slot5target1 == null)
            {
                if (movedSkill == skil19)
                {

                    slot5target1 = slotVraga8;
                    slot5target2 = null;
                    slot5target3 = null;
                }
                else
                {

                    slot5target1 = slotVraga8;
                    slot5target2 = null;
                    slot5target3 = null;
                    thispartisread60 = true;
                }
            }
            else if (slot5target1 != null)
            {
                if (movedSkill == skil19)
                {
                    if (vybrMishen == null)
                    {

                        slot2mishVraga.SetActive(true);
                        slot5mishVraga.SetActive(true);
                        slot8mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot5target1 = vybrMishen;
                        slot5target2 = null;
                        slot5target3 = null;
                    }
                }
                else
                {
                    thispartisread60 = true;
                }

                specialtarget1 = slot5target1;
                specialtarget2 = slot5target2;
                specialtarget3 = slot5target3;

            }
        }
        if (slot6skill == 19 && thispartisread61 == false)
        {
            if (slot6target1 == null)
            {
                if (movedSkill == skil19)
                {

                    slot6target1 = slotVraga9;
                    slot6target2 = null;
                    slot6target3 = null;
                }
                else
                {

                    slot6target1 = slotVraga9;
                    slot6target2 = null;
                    slot6target3 = null;
                    thispartisread61 = true;
                }
            }
            else if (slot6target1 != null)
            {
                if (movedSkill == skil19)
                {
                    if (vybrMishen == null)
                    {

                        slot3mishVraga.SetActive(true);
                        slot6mishVraga.SetActive(true);
                        slot9mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot6target1 = vybrMishen;
                        slot6target2 = null;
                        slot6target3 = null;
                    }
                }
                else
                {
                    thispartisread61 = true;
                }

                specialtarget1 = slot6target1;
                specialtarget2 = slot6target2;
                specialtarget3 = slot6target3;

            }
        }
        // скилл 20 ловушка
        if (slot1skill == 20 && thispartisread62 == false)
        {
            if (slot1target1 == null)
            {
                if (movedSkill == skil20)
                {

                    slot1target1 = null;
                    slot1target2 = null;
                    slot1target3 = null;
                }
                else
                {

                    slot1target1 = null;
                    slot1target2 = null;
                    slot1target3 = null;
                    thispartisread62 = true;
                }
            }
            else if (slot1target1 != null)
            {
                if (movedSkill == skil20)
                {
                    if (vybrMishen == null)
                    {
                    }
                    else if (vybrMishen != null)
                    {
                    }
                }
                else
                {
                    thispartisread62 = true;
                }

                specialtarget1 = slot1target1;
                specialtarget2 = slot1target2;
                specialtarget3 = slot1target3;

            }
        }
        if (slot3skill == 20 && thispartisread63 == false)
        {
            if (slot3target1 == null)
            {
                if (movedSkill == skil20)
                {

                    slot3target1 = null;
                    slot3target2 = null;
                    slot3target3 = null;
                }
                else
                {

                    slot3target1 = null;
                    slot3target2 = null;
                    slot3target3 = null;
                    thispartisread63 = true;
                }
            }
            else if (slot3target1 != null)
            {
                if (movedSkill == skil20)
                {
                    if (vybrMishen == null)
                    {
                    }
                    else if (vybrMishen != null)
                    {
                    }
                }
                else
                {
                    thispartisread63 = true;
                }

                specialtarget1 = slot3target1;
                specialtarget2 = slot3target2;
                specialtarget3 = slot3target3;

            }
        }
        if (slot6skill == 20 && thispartisread64 == false)
        {
            if (slot6target1 == null)
            {
                if (movedSkill == skil20)
                {

                    slot6target1 = null;
                    slot6target2 = null;
                    slot6target3 = null;
                }
                else
                {

                    slot6target1 = null;
                    slot6target2 = null;
                    slot6target3 = null;
                    thispartisread64 = true;
                }
            }
            else if (slot6target1 != null)
            {
                if (movedSkill == skil20)
                {
                    if (vybrMishen == null)
                    {
                    }
                    else if (vybrMishen != null)
                    {
                    }
                }
                else
                {
                    thispartisread64 = true;
                }

                specialtarget1 = slot6target1;
                specialtarget2 = slot6target2;
                specialtarget3 = slot6target3;

            }
        }
        // скилл 21
        if (slot1skill == 21 && thispartisread65 == false) // если скил 1 на позиции 1 и эта часть не прочитана
        {
            if (slot1target1 == null) //  если цели не были установлены (навык передвинулся) 
            {
                if (movedSkill == skil21) // если работа с этим скилом
                {
                    // тут устанавливаются дефолтные мишени
                    slot1target1 = slotGG1;
                    slot1target2 = slotVraga1;
                    slot1target3 = null;
                }
                else // если это не мувд скилл
                {
                    // тут устанавливаются дефолтные мишени
                    slot1target1 = slotGG1;
                    slot1target2 = slotVraga1;
                    slot1target3 = null;
                    thispartisread65 = true;
                }
            }
            else if (slot1target1 != null) // если цели были установлены (навык не двигался)
            {
                if (movedSkill == skil21) // если работа с этим скилом, тут будуть обновляться мишени
                {
                    if (vybrMishen == null) // мы только включили этот режим
                    {
                        // тут включаются все доступные места после тотального отключения (один раз)
                        slot1mish.SetActive(true);
                        slot1mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null) // если игрок выбрал мишень, то начинаются махинации, зависимые от навыка. конкретно этот читает только одну мишень, у остальных будут проверки
                    {
                    }
                }
                else // если это не мувд скилл
                {
                    thispartisread65 = true;
                }
                // тут зовётся функция демонстрации, показываем текущие (предыдущие/ дефолтные) слот таргеты и возможные слоты на поле, остальные отключаем
                specialtarget1 = slot1target1;
                specialtarget2 = slot1target2;
                specialtarget3 = slot1target3;

            }
        }
        if (slot2skill == 21 && thispartisread66 == false) // если скил 1 на позиции 2 и эта часть не прочитана
        {
            if (slot2target1 == null) //  если цели не были установлены (навык передвинулся) 
            {
                if (movedSkill == skil21) // если работа с этим скилом
                {
                    // тут устанавливаются дефолтные мишени
                    slot2target1 = slotGG2;
                    slot2target2 = slotVraga2;
                    slot2target3 = null;
                }
                else // если это не мувд скилл
                {
                    // тут устанавливаются дефолтные мишени
                    slot2target1 = slotGG2;
                    slot2target2 = slotVraga2;
                    slot2target3 = null;
                    thispartisread66 = true;
                }
            }
            else if (slot2target1 != null) // если цели были установлены (навык не двигался)
            {
                if (movedSkill == skil21) // если работа с этим скилом, тут будуть обновляться мишени
                {
                    if (vybrMishen == null) // мы только включили этот режим
                    {
                        // тут включаются все доступные места после тотального отключения (один раз)
                        slot2mish.SetActive(true);
                        slot2mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null) // если игрок выбрал мишень, то начинаются махинации, зависимые от навыка. конкретно этот читает только одну мишень, у остальных будут проверки
                    {
                    }
                }
                else // если это не мувд скилл
                {
                    thispartisread66 = true;
                }
                // тут зовётся функция демонстрации, показываем текущие (предыдущие/ дефолтные) слот таргеты и возможные слоты на поле, остальные отключаем
                specialtarget1 = slot2target1;
                specialtarget2 = slot2target2;
                specialtarget3 = slot2target3;

            }
        }
        // скилл 21
        if (slot3skill == 21 && thispartisread67 == false) // если скил 1 на позиции 1 и эта часть не прочитана
        {
            if (slot3target1 == null) //  если цели не были установлены (навык передвинулся) 
            {
                if (movedSkill == skil21) // если работа с этим скилом
                {
                    // тут устанавливаются дефолтные мишени
                    slot3target1 = slotGG3;
                    slot3target2 = slotVraga3;
                    slot3target3 = null;
                }
                else // если это не мувд скилл
                {
                    // тут устанавливаются дефолтные мишени
                    slot3target1 = slotGG3;
                    slot3target2 = slotVraga3;
                    slot3target3 = null;
                    thispartisread67 = true;
                }
            }
            else if (slot3target1 != null) // если цели были установлены (навык не двигался)
            {
                if (movedSkill == skil21) // если работа с этим скилом, тут будуть обновляться мишени
                {
                    if (vybrMishen == null) // мы только включили этот режим
                    {
                        // тут включаются все доступные места после тотального отключения (один раз)
                        slot3mish.SetActive(true);
                        slot3mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null) // если игрок выбрал мишень, то начинаются махинации, зависимые от навыка. конкретно этот читает только одну мишень, у остальных будут проверки
                    {
                    }
                }
                else // если это не мувд скилл
                {
                    thispartisread67 = true;
                }
                // тут зовётся функция демонстрации, показываем текущие (предыдущие/ дефолтные) слот таргеты и возможные слоты на поле, остальные отключаем
                specialtarget1 = slot3target1;
                specialtarget2 = slot3target2;
                specialtarget3 = slot3target3;

            }
        }
        if (slot4skill == 21 && thispartisread68 == false) // если скил 1 на позиции 2 и эта часть не прочитана
        {
            if (slot4target1 == null) //  если цели не были установлены (навык передвинулся) 
            {
                if (movedSkill == skil21) // если работа с этим скилом
                {
                    // тут устанавливаются дефолтные мишени
                    slot4target1 = slotGG4;
                    slot4target2 = slotVraga4;
                    slot4target3 = null;
                }
                else // если это не мувд скилл
                {
                    // тут устанавливаются дефолтные мишени
                    slot4target1 = slotGG4;
                    slot4target2 = slotVraga4;
                    slot4target3 = null;
                    thispartisread68 = true;
                }
            }
            else if (slot4target1 != null) // если цели были установлены (навык не двигался)
            {
                if (movedSkill == skil21) // если работа с этим скилом, тут будуть обновляться мишени
                {
                    if (vybrMishen == null) // мы только включили этот режим
                    {
                        // тут включаются все доступные места после тотального отключения (один раз)
                        slot4mish.SetActive(true);
                        slot4mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null) // если игрок выбрал мишень, то начинаются махинации, зависимые от навыка. конкретно этот читает только одну мишень, у остальных будут проверки
                    {
                    }
                }
                else // если это не мувд скилл
                {
                    thispartisread68 = true;
                }
                // тут зовётся функция демонстрации, показываем текущие (предыдущие/ дефолтные) слот таргеты и возможные слоты на поле, остальные отключаем
                specialtarget1 = slot4target1;
                specialtarget2 = slot4target2;
                specialtarget3 = slot4target3;

            }
        }
        // скилл 21
        if (slot6skill == 21 && thispartisread69 == false) // если скил 1 на позиции 1 и эта часть не прочитана
        {
            if (slot6target1 == null) //  если цели не были установлены (навык передвинулся) 
            {
                if (movedSkill == skil21) // если работа с этим скилом
                {
                    // тут устанавливаются дефолтные мишени
                    slot6target1 = slotGG6;
                    slot6target2 = slotVraga6;
                    slot6target3 = null;
                }
                else // если это не мувд скилл
                {
                    // тут устанавливаются дефолтные мишени
                    slot6target1 = slotGG6;
                    slot6target2 = slotVraga6;
                    slot6target3 = null;
                    thispartisread69 = true;
                }
            }
            else if (slot6target1 != null) // если цели были установлены (навык не двигался)
            {
                if (movedSkill == skil21) // если работа с этим скилом, тут будуть обновляться мишени
                {
                    if (vybrMishen == null) // мы только включили этот режим
                    {
                        // тут включаются все доступные места после тотального отключения (один раз)
                        slot6mish.SetActive(true);
                        slot6mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null) // если игрок выбрал мишень, то начинаются махинации, зависимые от навыка. конкретно этот читает только одну мишень, у остальных будут проверки
                    {
                    }
                }
                else // если это не мувд скилл
                {
                    thispartisread69 = true;
                }
                // тут зовётся функция демонстрации, показываем текущие (предыдущие/ дефолтные) слот таргеты и возможные слоты на поле, остальные отключаем
                specialtarget1 = slot6target1;
                specialtarget2 = slot6target2;
                specialtarget3 = slot6target3;

            }
        }
        if (slot7skill == 21 && thispartisread70 == false) // если скил 1 на позиции 2 и эта часть не прочитана
        {
            if (slot7target1 == null) //  если цели не были установлены (навык передвинулся) 
            {
                if (movedSkill == skil21) // если работа с этим скилом
                {
                    // тут устанавливаются дефолтные мишени
                    slot7target1 = slotGG7;
                    slot7target2 = slotVraga7;
                    slot7target3 = null;
                }
                else // если это не мувд скилл
                {
                    // тут устанавливаются дефолтные мишени
                    slot7target1 = slotGG7;
                    slot7target2 = slotVraga7;
                    slot7target3 = null;
                    thispartisread70 = true;
                }
            }
            else if (slot7target1 != null) // если цели были установлены (навык не двигался)
            {
                if (movedSkill == skil21) // если работа с этим скилом, тут будуть обновляться мишени
                {
                    if (vybrMishen == null) // мы только включили этот режим
                    {
                        // тут включаются все доступные места после тотального отключения (один раз)
                        slot7mish.SetActive(true);
                        slot7mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null) // если игрок выбрал мишень, то начинаются махинации, зависимые от навыка. конкретно этот читает только одну мишень, у остальных будут проверки
                    {
                    }
                }
                else // если это не мувд скилл
                {
                    thispartisread70 = true;
                }
                // тут зовётся функция демонстрации, показываем текущие (предыдущие/ дефолтные) слот таргеты и возможные слоты на поле, остальные отключаем
                specialtarget1 = slot7target1;
                specialtarget2 = slot7target2;
                specialtarget3 = slot7target3;

            }
        }
        // скилл 21
        if (slot9skill == 21 && thispartisread71 == false) // если скил 1 на позиции 1 и эта часть не прочитана
        {
            if (slot9target1 == null) //  если цели не были установлены (навык передвинулся) 
            {
                if (movedSkill == skil21) // если работа с этим скилом
                {
                    // тут устанавливаются дефолтные мишени
                    slot9target1 = slotGG9;
                    slot9target2 = slotVraga9;
                    slot9target3 = null;
                }
                else // если это не мувд скилл
                {
                    // тут устанавливаются дефолтные мишени
                    slot9target1 = slotGG9;
                    slot9target2 = slotVraga9;
                    slot9target3 = null;
                    thispartisread71 = true;
                }
            }
            else if (slot9target1 != null) // если цели были установлены (навык не двигался)
            {
                if (movedSkill == skil21) // если работа с этим скилом, тут будуть обновляться мишени
                {
                    if (vybrMishen == null) // мы только включили этот режим
                    {
                        // тут включаются все доступные места после тотального отключения (один раз)
                        slot9mish.SetActive(true);
                        slot9mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null) // если игрок выбрал мишень, то начинаются махинации, зависимые от навыка. конкретно этот читает только одну мишень, у остальных будут проверки
                    {
                    }
                }
                else // если это не мувд скилл
                {
                    thispartisread71 = true;
                }
                // тут зовётся функция демонстрации, показываем текущие (предыдущие/ дефолтные) слот таргеты и возможные слоты на поле, остальные отключаем
                specialtarget1 = slot9target1;
                specialtarget2 = slot9target2;
                specialtarget3 = slot9target3;

            }
        }
        // скилл 22
        if (slot2skill == 22 && thispartisread72 == false)
        {
            if (slot2target1 == null)
            {
                if (movedSkill == skil22)
                {

                    slot2target1 = slotVraga2;
                    slot2target2 = null;
                    slot2target3 = null;
                }
                else
                {

                    slot2target1 = slotVraga2;
                    slot2target2 = null;
                    slot2target3 = null;
                    thispartisread72 = true;
                }
            }
            else if (slot2target1 != null)
            {
                if (movedSkill == skil22)
                {
                    if (vybrMishen == null)
                    {
                        slot2mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                    }
                }
                else
                {
                    thispartisread72 = true;
                }

                specialtarget1 = slot2target1;
                specialtarget2 = slot2target2;
                specialtarget3 = slot2target3;

            }
        }

        if (slot5skill == 22 && thispartisread73 == false)
        {
            if (slot5target1 == null)
            {
                if (movedSkill == skil22)
                {

                    slot5target1 = slotVraga5;
                    slot5target2 = null;
                    slot5target3 = null;
                }
                else
                {

                    slot5target1 = slotVraga5;
                    slot5target2 = null;
                    slot5target3 = null;
                    thispartisread73 = true;
                }
            }
            else if (slot5target1 != null)
            {
                if (movedSkill == skil22)
                {
                    if (vybrMishen == null)
                    {
                        slot5mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                    }
                }
                else
                {
                    thispartisread73 = true;
                }

                specialtarget1 = slot5target1;
                specialtarget2 = slot5target2;
                specialtarget3 = slot5target3;

            }
        }

        if (slot8skill == 22 && thispartisread74 == false)
        {
            if (slot8target1 == null)
            {
                if (movedSkill == skil22)
                {

                    slot8target1 = slotVraga8;
                    slot8target2 = null;
                    slot8target3 = null;
                }
                else
                {

                    slot8target1 = slotVraga8;
                    slot8target2 = null;
                    slot8target3 = null;
                    thispartisread74 = true;
                }
            }
            else if (slot8target1 != null)
            {
                if (movedSkill == skil22)
                {
                    if (vybrMishen == null)
                    {
                        slot8mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                    }
                }
                else
                {
                    thispartisread74 = true;
                }

                specialtarget1 = slot8target1;
                specialtarget2 = slot8target2;
                specialtarget3 = slot8target3;

            }
        }
        if (slot7skill == 22 && thispartisread75 == false)
        {
            if (slot7target1 == null)
            {
                if (movedSkill == skil22)
                {

                    slot7target1 = slotVraga7;
                    slot7target2 = null;
                    slot7target3 = null;
                }
                else
                {

                    slot7target1 = slotVraga7;
                    slot7target2 = null;
                    slot7target3 = null;
                    thispartisread75 = true;
                }
            }
            else if (slot7target1 != null)
            {
                if (movedSkill == skil22)
                {
                    if (vybrMishen == null)
                    {
                        slot7mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                    }
                }
                else
                {
                    thispartisread75 = true;
                }

                specialtarget1 = slot7target1;
                specialtarget2 = slot7target2;
                specialtarget3 = slot7target3;

            }
        }

        if (slot9skill == 22 && thispartisread76 == false)
        {
            if (slot9target1 == null)
            {
                if (movedSkill == skil22)
                {

                    slot9target1 = slotVraga9;
                    slot9target2 = null;
                    slot9target3 = null;
                }
                else
                {

                    slot9target1 = slotVraga9;
                    slot9target2 = null;
                    slot9target3 = null;
                    thispartisread76 = true;
                }
            }
            else if (slot9target1 != null)
            {
                if (movedSkill == skil22)
                {
                    if (vybrMishen == null)
                    {
                        slot9mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                    }
                }
                else
                {
                    thispartisread76 = true;
                }

                specialtarget1 = slot9target1;
                specialtarget2 = slot9target2;
                specialtarget3 = slot9target3;

            }
        }
        // скилл 23
        if (slot8skill == 23 && thispartisread77 == false)
        {
            if (slot8target1 == null)
            {
                if (movedSkill == skil23)
                {

                    slot8target1 = slotVraga7;
                    slot8target2 = slotVraga8;
                    slot8target3 = slotVraga9;
                }
                else
                {

                    slot8target1 = slotVraga7;
                    slot8target2 = slotVraga8;
                    slot8target3 = slotVraga9;
                    thispartisread77 = true;
                }
            }
            else if (slot8target1 != null)
            {
                if (movedSkill == skil23)
                {
                    if (vybrMishen == null)
                    {

                        slot7mishVraga.SetActive(true);
                        slot8mishVraga.SetActive(true);
                        slot9mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                    }
                }
                else
                {
                    thispartisread77 = true;
                }

                specialtarget1 = slot8target1;
                specialtarget2 = slot8target2;
                specialtarget3 = slot8target3;

            }
        }
        // скилл 24
        if (slot8skill == 24 && thispartisread78 == false)
        {
            if (slot8target1 == null)
            {
                if (movedSkill == skil24)
                {

                    slot8target1 = slotVraga2;
                    slot8target2 = slotVraga5;
                    slot8target3 = slotVraga8;
                }
                else
                {

                    slot8target1 = slotVraga2;
                    slot8target2 = slotVraga5;
                    slot8target3 = slotVraga8;
                    thispartisread78 = true;
                }
            }
            else if (slot8target1 != null)
            {
                if (movedSkill == skil24)
                {
                    if (vybrMishen == null)
                    {

                        slot2mishVraga.SetActive(true);
                        slot5mishVraga.SetActive(true);
                        slot8mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                    }
                }
                else
                {
                    thispartisread78 = true;
                }

                specialtarget1 = slot8target1;
                specialtarget2 = slot8target2;
                specialtarget3 = slot8target3;

            }
        }
        // скилл 25
        if (slot5skill == 25 && thispartisread79 == false)
        {
            if (slot5target1 == null)
            {
                if (movedSkill == skil25)
                {

                    slot5target1 = slotGG9;
                    slot5target2 = null;
                    slot5target3 = null;
                }
                else
                {

                    slot5target1 = slotGG9;
                    slot5target2 = null;
                    slot5target3 = null;
                    thispartisread79 = true;
                }
            }
            else if (slot5target1 != null)
            {
                if (movedSkill == skil25)
                {
                    if (vybrMishen == null)
                    {

                        slot1mish.SetActive(true);
                        slot3mish.SetActive(true);
                        slot7mish.SetActive(true);
                        slot9mish.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot5target1 = vybrMishen;
                        slot5target2 = null;
                        slot5target3 = null;
                    }
                }
                else
                {
                    thispartisread79 = true;
                }

                specialtarget1 = slot5target1;
                specialtarget2 = slot5target2;
                specialtarget3 = slot5target3;

            }
        }
        // скилл 26
        if (slot5skill == 26 && thispartisread80 == false)
        {
            if (slot5target1 == null)
            {
                if (movedSkill == skil26)
                {

                    slot5target1 = slotGG8;
                    slot5target2 = null;
                    slot5target3 = null;
                }
                else
                {

                    slot5target1 = slotGG8;
                    slot5target2 = null;
                    slot5target3 = null;
                    thispartisread80 = true;
                }
            }
            else if (slot5target1 != null)
            {
                if (movedSkill == skil26)
                {
                    if (vybrMishen == null)
                    {

                        slot2mish.SetActive(true);
                        slot4mish.SetActive(true);
                        slot6mish.SetActive(true);
                        slot8mish.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot5target1 = vybrMishen;
                        slot5target2 = null;
                        slot5target3 = null;
                    }
                }
                else
                {
                    thispartisread80 = true;
                }

                specialtarget1 = slot5target1;
                specialtarget2 = slot5target2;
                specialtarget3 = slot5target3;

            }
        }

        if (slot1skill == 27 && thispartisread81 == false)
        {
            if (slot1target1 == null)
            {
                if (movedSkill == skil27)
                {

                    slot1target1 = slotVraga4;
                    slot1target2 = slotVraga7;
                    slot1target3 = null;
                }
                else
                {

                    slot1target1 = slotVraga4;
                    slot1target2 = slotVraga7;
                    slot1target3 = null;
                    thispartisread81 = true;
                }
            }
            else if (slot1target1 != null)
            {
                if (movedSkill == skil27)
                {
                    if (vybrMishen == null)
                    {

                        slot1mishVraga.SetActive(true);
                        slot4mishVraga.SetActive(true);
                        slot7mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot1target1 = slotVraga4;
                        if (vybrMishen != slotVraga4)
                        {
                            slot1target2 = vybrMishen;
                        }
                        slot1target3 = null;
                    }
                }
                else
                {
                    thispartisread81 = true;
                }

                specialtarget1 = slot1target1;
                specialtarget2 = slot1target2;
                specialtarget3 = slot1target3;

            }
        }

        if (slot3skill == 27 && thispartisread82 == false)
        {
            if (slot3target1 == null)
            {
                if (movedSkill == skil27)
                {

                    slot3target1 = slotVraga6;
                    slot3target2 = slotVraga9;
                    slot3target3 = null;
                }
                else
                {

                    slot3target1 = slotVraga6;
                    slot3target2 = slotVraga9;
                    slot3target3 = null;
                    thispartisread82 = true;
                }
            }
            else if (slot3target1 != null)
            {
                if (movedSkill == skil27)
                {
                    if (vybrMishen == null)
                    {

                        slot3mishVraga.SetActive(true);
                        slot6mishVraga.SetActive(true);
                        slot9mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot3target1 = slotVraga6;
                        if (vybrMishen != slotVraga6)
                        {
                            slot3target2 = vybrMishen;
                        }
                        slot3target3 = null;
                    }
                }
                else
                {
                    thispartisread82 = true;
                }

                specialtarget1 = slot3target1;
                specialtarget2 = slot3target2;
                specialtarget3 = slot3target3;

            }
        }
        if (slot7skill == 27 && thispartisread83 == false)
        {
            if (slot7target1 == null)
            {
                if (movedSkill == skil27)
                {

                    slot7target1 = slotVraga4;
                    slot7target2 = slotVraga7;
                    slot7target3 = null;
                }
                else
                {

                    slot7target1 = slotVraga4;
                    slot7target2 = slotVraga7;
                    slot7target3 = null;
                    thispartisread83 = true;
                }
            }
            else if (slot7target1 != null)
            {
                if (movedSkill == skil27)
                {
                    if (vybrMishen == null)
                    {

                        slot1mishVraga.SetActive(true);
                        slot4mishVraga.SetActive(true);
                        slot7mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot7target1 = slotVraga4;
                        if (vybrMishen != slotVraga4) // если выбирали между 4 и 8, что-то изменится, см. может было обнуление
                        {
                            slot7target2 = vybrMishen;
                        }
                        slot7target3 = null;
                    }
                }
                else
                {
                    thispartisread83 = true;
                }

                specialtarget1 = slot7target1;
                specialtarget2 = slot7target2;
                specialtarget3 = slot7target3;

            }
        }
        if (slot9skill == 27 && thispartisread84 == false)
        {
            if (slot9target1 == null)
            {
                if (movedSkill == skil27)
                {

                    slot9target1 = slotVraga6;
                    slot9target2 = slotVraga9;
                    slot9target3 = null;
                }
                else
                {

                    slot9target1 = slotVraga6;
                    slot9target2 = slotVraga9;
                    slot9target3 = null;
                    thispartisread84 = true;
                }
            }
            else if (slot9target1 != null)
            {
                if (movedSkill == skil27)
                {
                    if (vybrMishen == null)
                    {

                        slot3mishVraga.SetActive(true);
                        slot6mishVraga.SetActive(true);
                        slot9mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot9target1 = slotVraga6;
                        if (vybrMishen != slotVraga6)
                        {
                            slot9target2 = vybrMishen;
                        }
                        slot9target3 = null;
                    }
                }
                else
                {
                    thispartisread84 = true;
                }

                specialtarget1 = slot9target1;
                specialtarget2 = slot9target2;
                specialtarget3 = slot9target3;

            }
        }
        // скилл 28
        if (slot1skill == 28 && thispartisread85 == false)
        {
            if (slot1target1 == null)
            {
                if (movedSkill == skil28)
                {

                    slot1target1 = slotVraga1;
                    slot1target2 = null;
                    slot1target3 = null;
                }
                else
                {

                    slot1target1 = slotVraga1;
                    slot1target2 = null;
                    slot1target3 = null;
                    thispartisread85 = true;
                }
            }
            else if (slot1target1 != null)
            {
                if (movedSkill == skil28)
                {
                    if (vybrMishen == null)
                    {

                        slot1mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot1target1 = vybrMishen;
                        slot1target2 = null;
                        slot1target3 = null;
                    }
                }
                else
                {
                    thispartisread85 = true;
                }

                specialtarget1 = slot1target1;
                specialtarget2 = slot1target2;
                specialtarget3 = slot1target3;

            }
        }

        if (slot2skill == 28 && thispartisread86 == false)
        {
            if (slot2target1 == null)
            {
                if (movedSkill == skil28)
                {

                    slot2target1 = slotVraga2;
                    slot2target2 = null;
                    slot2target3 = null;
                }
                else
                {

                    slot2target1 = slotVraga2;
                    slot2target2 = null;
                    slot2target3 = null;
                    thispartisread86 = true;
                }
            }
            else if (slot2target1 != null)
            {
                if (movedSkill == skil28)
                {
                    if (vybrMishen == null)
                    {

                        slot2mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot2target1 = vybrMishen;
                        slot2target2 = null;
                        slot2target3 = null;
                    }
                }
                else
                {
                    thispartisread86 = true;
                }

                specialtarget1 = slot2target1;
                specialtarget2 = slot2target2;
                specialtarget3 = slot2target3;

            }
        }

        if (slot3skill == 28 && thispartisread87 == false)
        {
            if (slot3target1 == null)
            {
                if (movedSkill == skil28)
                {

                    slot3target1 = slotVraga3;
                    slot3target2 = null;
                    slot3target3 = null;
                }
                else
                {

                    slot3target1 = slotVraga3;
                    slot3target2 = null;
                    slot3target3 = null;
                    thispartisread87 = true;
                }
            }
            else if (slot3target1 != null)
            {
                if (movedSkill == skil28)
                {
                    if (vybrMishen == null)
                    {
                        slot3mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot3target1 = vybrMishen;
                        slot3target2 = null;
                        slot3target3 = null;
                    }
                }
                else
                {
                    thispartisread87 = true;
                }

                specialtarget1 = slot3target1;
                specialtarget2 = slot3target2;
                specialtarget3 = slot3target3;

            }
        }
        if (slot4skill == 28 && thispartisread88 == false)
        {
            if (slot4target1 == null)
            {
                if (movedSkill == skil28)
                {

                    slot4target1 = slotVraga4;
                    slot4target2 = null;
                    slot4target3 = null;
                }
                else
                {

                    slot4target1 = slotVraga4;
                    slot4target2 = null;
                    slot4target3 = null;
                    thispartisread88 = true;
                }
            }
            else if (slot4target1 != null)
            {
                if (movedSkill == skil28)
                {
                    if (vybrMishen == null)
                    {
                        slot4mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot4target1 = vybrMishen;
                        slot4target2 = null;
                        slot4target3 = null;
                    }
                }
                else
                {
                    thispartisread88 = true;
                }

                specialtarget1 = slot4target1;
                specialtarget2 = slot4target2;
                specialtarget3 = slot4target3;

            }
        }
        if (slot5skill == 28 && thispartisread89 == false)
        {
            if (slot5target1 == null)
            {
                if (movedSkill == skil28)
                {

                    slot5target1 = slotVraga5;
                    slot5target2 = null;
                    slot5target3 = null;
                }
                else
                {

                    slot5target1 = slotVraga5;
                    slot5target2 = null;
                    slot5target3 = null;
                    thispartisread89 = true;
                }
            }
            else if (slot5target1 != null)
            {
                if (movedSkill == skil28)
                {
                    if (vybrMishen == null)
                    {
                        slot5mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot5target1 = vybrMishen;
                        slot5target2 = null;
                        slot5target3 = null;
                    }
                }
                else
                {
                    thispartisread89 = true;
                }

                specialtarget1 = slot5target1;
                specialtarget2 = slot5target2;
                specialtarget3 = slot5target3;

            }
        }
        if (slot6skill == 28 && thispartisread90 == false)
        {
            if (slot6target1 == null)
            {
                if (movedSkill == skil28)
                {

                    slot6target1 = slotVraga6;
                    slot6target2 = null;
                    slot6target3 = null;
                }
                else
                {

                    slot6target1 = slotVraga6;
                    slot6target2 = null;
                    slot6target3 = null;
                    thispartisread90 = true;
                }
            }
            else if (slot6target1 != null)
            {
                if (movedSkill == skil28)
                {
                    if (vybrMishen == null)
                    {
                        slot6mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot6target1 = vybrMishen;
                        slot6target2 = null;
                        slot6target3 = null;
                    }
                }
                else
                {
                    thispartisread90 = true;
                }

                specialtarget1 = slot6target1;
                specialtarget2 = slot6target2;
                specialtarget3 = slot6target3;

            }
        }

        // скилл 29
        if (slot4skill == 29 && thispartisread91 == false)
        {
            if (slot4target1 == null)
            {
                if (movedSkill == skil29)
                {

                    slot4target1 = slotGG7;
                    slot4target2 = slotGG8;
                    slot4target3 = slotGG9;
                }
                else
                {

                    slot4target1 = slotGG7;
                    slot4target2 = slotGG8;
                    slot4target3 = slotGG9;
                    thispartisread91 = true;
                }
            }
            else if (slot4target1 != null)
            {
                if (movedSkill == skil29)
                {
                    if (vybrMishen == null)
                    {

                        slot7mish.SetActive(true);
                        slot8mish.SetActive(true);
                        slot9mish.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                    }
                }
                else
                {
                    thispartisread91 = true;
                }

                specialtarget1 = slot4target1;
                specialtarget2 = slot4target2;
                specialtarget3 = slot4target3;

            }
        }

        if (slot6skill == 29 && thispartisread92 == false)
        {
            if (slot6target1 == null)
            {
                if (movedSkill == skil29)
                {

                    slot6target1 = slotGG7;
                    slot6target2 = slotGG8;
                    slot6target3 = slotGG9;
                }
                else
                {

                    slot6target1 = slotGG7;
                    slot6target2 = slotGG8;
                    slot6target3 = slotGG9;
                    thispartisread92 = true;
                }
            }
            else if (slot6target1 != null)
            {
                if (movedSkill == skil29)
                {
                    if (vybrMishen == null)
                    {
                        slot7mish.SetActive(true);
                        slot8mish.SetActive(true);
                        slot9mish.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                    }
                }
                else
                {
                    thispartisread92 = true;
                }

                specialtarget1 = slot6target1;
                specialtarget2 = slot6target2;
                specialtarget3 = slot6target3;

            }
        }
        // 30 скилл
        if (slot4skill == 30 && thispartisread93 == false)
        {
            if (slot4target1 == null)
            {
                if (movedSkill == skil30)
                {

                    slot4target1 = slotVraga1;
                    slot4target2 = slotVraga4;
                    slot4target3 = slotVraga7;
                }
                else
                {

                    slot4target1 = slotVraga1;
                    slot4target2 = slotVraga4;
                    slot4target3 = slotVraga7;
                    thispartisread93 = true;
                }
            }
            else if (slot4target1 != null)
            {
                if (movedSkill == skil30)
                {
                    if (vybrMishen == null)
                    {
                        slot1mishVraga.SetActive(true);
                        slot4mishVraga.SetActive(true);
                        slot7mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                    }
                }
                else
                {
                    thispartisread93 = true;
                }

                specialtarget1 = slot4target1;
                specialtarget2 = slot4target2;
                specialtarget3 = slot4target3;

            }
        }

        if (slot5skill == 30 && thispartisread94 == false)
        {
            if (slot5target1 == null)
            {
                if (movedSkill == skil30)
                {

                    slot5target1 = slotVraga2;
                    slot5target2 = slotVraga5;
                    slot5target3 = slotVraga8;
                }
                else
                {

                    slot5target1 = slotVraga2;
                    slot5target2 = slotVraga5;
                    slot5target3 = slotVraga8;
                    thispartisread94 = true;
                }
            }
            else if (slot5target1 != null)
            {
                if (movedSkill == skil30)
                {
                    if (vybrMishen == null)
                    {
                        slot2mishVraga.SetActive(true);
                        slot5mishVraga.SetActive(true);
                        slot8mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                    }
                }
                else
                {
                    thispartisread94 = true;
                }

                specialtarget1 = slot5target1;
                specialtarget2 = slot5target2;
                specialtarget3 = slot5target3;

            }
        }

        if (slot6skill == 30 && thispartisread95 == false)
        {
            if (slot6target1 == null)
            {
                if (movedSkill == skil30)
                {

                    slot6target1 = slotVraga3;
                    slot6target2 = slotVraga6;
                    slot6target3 = slotVraga9;
                }
                else
                {

                    slot6target1 = slotVraga3;
                    slot6target2 = slotVraga6;
                    slot6target3 = slotVraga9;
                    thispartisread95 = true;
                }
            }
            else if (slot6target1 != null)
            {
                if (movedSkill == skil30)
                {
                    if (vybrMishen == null)
                    {
                        slot3mishVraga.SetActive(true);
                        slot6mishVraga.SetActive(true);
                        slot9mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                    }
                }
                else
                {
                    thispartisread95 = true;
                }

                specialtarget1 = slot6target1;
                specialtarget2 = slot6target2;
                specialtarget3 = slot6target3;

            }
        }
        // скилл 31
        if (slot7skill == 31 && thispartisread96 == false)
        {
            if (slot7target1 == null)
            {
                if (movedSkill == skil31)
                {

                    slot7target1 = slotVraga7;
                    slot7target2 = null;
                    slot7target3 = null;
                }
                else
                {

                    slot7target1 = slotVraga7;
                    slot7target2 = null;
                    slot7target3 = null;
                    thispartisread96 = true;
                }
            }
            else if (slot7target1 != null)
            {
                if (movedSkill == skil31)
                {
                    if (vybrMishen == null)
                    {
                        slot1mishVraga.SetActive(true);
                        slot4mishVraga.SetActive(true);
                        slot7mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot7target1 = vybrMishen;
                        slot7target2 = null;
                        slot7target3 = null;
                    }
                }
                else
                {
                    thispartisread96 = true;
                }

                specialtarget1 = slot7target1;
                specialtarget2 = slot7target2;
                specialtarget3 = slot7target3;

            }
        }

        if (slot8skill == 31 && thispartisread97 == false)
        {
            if (slot8target1 == null)
            {
                if (movedSkill == skil31)
                {

                    slot8target1 = slotVraga8;
                    slot8target2 = null;
                    slot8target3 = null;
                }
                else
                {

                    slot8target1 = slotVraga8;
                    slot8target2 = null;
                    slot8target3 = null;
                    thispartisread97 = true;
                }
            }
            else if (slot8target1 != null)
            {
                if (movedSkill == skil31)
                {
                    if (vybrMishen == null)
                    {
                        slot2mishVraga.SetActive(true);
                        slot5mishVraga.SetActive(true);
                        slot8mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot8target1 = vybrMishen;
                        slot8target2 = null;
                        slot8target3 = null;
                    }
                }
                else
                {
                    thispartisread97 = true;
                }

                specialtarget1 = slot8target1;
                specialtarget2 = slot8target2;
                specialtarget3 = slot8target3;

            }
        }

        if (slot9skill == 31 && thispartisread98 == false)
        {
            if (slot9target1 == null)
            {
                if (movedSkill == skil31)
                {

                    slot9target1 = slotVraga9;
                    slot9target2 = null;
                    slot9target3 = null;
                }
                else
                {

                    slot9target1 = slotVraga9;
                    slot9target2 = null;
                    slot9target3 = null;
                    thispartisread98 = true;
                }
            }
            else if (slot9target1 != null)
            {
                if (movedSkill == skil31)
                {
                    if (vybrMishen == null)
                    {
                        slot3mishVraga.SetActive(true);
                        slot6mishVraga.SetActive(true);
                        slot9mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot9target1 = vybrMishen;
                        slot9target2 = null;
                        slot9target3 = null;
                    }
                }
                else
                {
                    thispartisread98 = true;
                }

                specialtarget1 = slot9target1;
                specialtarget2 = slot9target2;
                specialtarget3 = slot9target3;

            }
        }
        // 32 скилл
        if (slot8skill == 32 && thispartisread99 == false)
        {
            if (slot8target1 == null)
            {
                if (movedSkill == skil32)
                {
                    poriadoksmeni = 0;
                    slot8target1 = slotVraga9;
                    slot8target2 = slotVraga8;
                    slot8target3 = slotVraga7;
                }
                else
                {
                    poriadoksmeni = 0;
                    slot8target1 = slotVraga9;
                    slot8target2 = slotVraga8;
                    slot8target3 = slotVraga7;
                    thispartisread99 = true;
                }
            }
            else if (slot8target1 != null)
            {
                if (movedSkill == skil32)
                {
                    if (vybrMishen == null)
                    {
                        slot1mishVraga.SetActive(true);
                        slot2mishVraga.SetActive(true);
                        slot3mishVraga.SetActive(true);
                        slot4mishVraga.SetActive(true);
                        slot5mishVraga.SetActive(true);
                        slot6mishVraga.SetActive(true);
                        slot7mishVraga.SetActive(true);
                        slot8mishVraga.SetActive(true);
                        slot9mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        if (poriadoksmeni == 0 && slot8target1 != vybrMishen && slot8target2 != vybrMishen && slot8target3 != vybrMishen)
                        {
                            slot8target1 = vybrMishen;
                            poriadoksmeni += 1;
                        }
                        else if (poriadoksmeni == 1 && slot8target1 != vybrMishen && slot8target2 != vybrMishen && slot8target3 != vybrMishen)
                        {
                            slot8target2 = vybrMishen;
                            poriadoksmeni += 1;
                        }
                        else if (poriadoksmeni == 2 && slot8target1 != vybrMishen && slot8target2 != vybrMishen && slot8target3 != vybrMishen)
                        {
                            slot8target3 = vybrMishen;
                            poriadoksmeni = 0;
                        }

                    }
                }
                else
                {
                    thispartisread99 = true;
                }

                specialtarget1 = slot8target1;
                specialtarget2 = slot8target2;
                specialtarget3 = slot8target3;

            }
        }
        // 33 скилл
        if (slot1skill == 33 && thispartisread100 == false)
        {
            if (slot1target1 == null)
            {
                if (movedSkill == skil33)
                {
                    poriadoksmenith = 0;
                    slot1target1 = slotVraga9;
                    slot1target2 = slotVraga8;
                    slot1target3 = null;
                }
                else
                {
                    poriadoksmenith = 0;
                    slot1target1 = slotVraga9;
                    slot1target2 = slotVraga8;
                    slot1target3 = null;
                    thispartisread100 = true;
                }
            }
            else if (slot1target1 != null)
            {
                if (movedSkill == skil33)
                {
                    if (vybrMishen == null)
                    {
                        slot1mishVraga.SetActive(true);
                        slot2mishVraga.SetActive(true);
                        slot3mishVraga.SetActive(true);
                        slot4mishVraga.SetActive(true);
                        slot5mishVraga.SetActive(true);
                        slot6mishVraga.SetActive(true);
                        slot7mishVraga.SetActive(true);
                        slot8mishVraga.SetActive(true);
                        slot9mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        if (poriadoksmenith == 0 && slot1target1 != vybrMishen && slot1target2 != vybrMishen && slot1target3 != vybrMishen)
                        {
                            slot1target1 = vybrMishen;
                            poriadoksmenith += 1;
                        }
                        else if (poriadoksmenith == 1 && slot1target1 != vybrMishen && slot1target2 != vybrMishen && slot1target3 != vybrMishen)
                        {
                            slot1target2 = vybrMishen;
                            poriadoksmenith = 0;
                        }
                        slot1target3 = null;
                    }
                }
                else
                {
                    thispartisread100 = true;
                }

                specialtarget1 = slot1target1;
                specialtarget2 = slot1target2;
                specialtarget3 = slot1target3;

            }
        }
        if (slot2skill == 33 && thispartisread101 == false)
        {
            if (slot2target1 == null)
            {
                if (movedSkill == skil33)
                {
                    poriadoksmenith = 0;
                    slot2target1 = slotVraga9;
                    slot2target2 = slotVraga8;
                    slot2target3 = null;
                }
                else
                {
                    poriadoksmenith = 0;
                    slot2target1 = slotVraga9;
                    slot2target2 = slotVraga8;
                    slot2target3 = null;
                    thispartisread101 = true;
                }
            }
            else if (slot2target1 != null)
            {
                if (movedSkill == skil33)
                {
                    if (vybrMishen == null)
                    {
                        slot1mishVraga.SetActive(true);
                        slot2mishVraga.SetActive(true);
                        slot3mishVraga.SetActive(true);
                        slot4mishVraga.SetActive(true);
                        slot5mishVraga.SetActive(true);
                        slot6mishVraga.SetActive(true);
                        slot7mishVraga.SetActive(true);
                        slot8mishVraga.SetActive(true);
                        slot9mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        if (poriadoksmenith == 0 && slot2target1 != vybrMishen && slot2target2 != vybrMishen && slot2target3 != vybrMishen)
                        {
                            slot2target1 = vybrMishen;
                            poriadoksmenith += 1;
                        }
                        else if (poriadoksmenith == 1 && slot2target1 != vybrMishen && slot2target2 != vybrMishen && slot2target3 != vybrMishen)
                        {
                            slot2target2 = vybrMishen;
                            poriadoksmenith = 0;
                        }
                        slot2target3 = null;
                    }
                }
                else
                {
                    thispartisread101 = true;
                }

                specialtarget1 = slot2target1;
                specialtarget2 = slot2target2;
                specialtarget3 = slot2target3;

            }
        }
        if (slot3skill == 33 && thispartisread102 == false)
        {
            if (slot3target1 == null)
            {
                if (movedSkill == skil33)
                {
                    poriadoksmenith = 0;
                    slot3target1 = slotVraga9;
                    slot3target2 = slotVraga8;
                    slot3target3 = null;
                }
                else
                {
                    poriadoksmenith = 0;
                    slot3target1 = slotVraga9;
                    slot3target2 = slotVraga8;
                    slot3target3 = null;
                    thispartisread102 = true;
                }
            }
            else if (slot3target1 != null)
            {
                if (movedSkill == skil33)
                {
                    if (vybrMishen == null)
                    {
                        slot1mishVraga.SetActive(true);
                        slot2mishVraga.SetActive(true);
                        slot3mishVraga.SetActive(true);
                        slot4mishVraga.SetActive(true);
                        slot5mishVraga.SetActive(true);
                        slot6mishVraga.SetActive(true);
                        slot7mishVraga.SetActive(true);
                        slot8mishVraga.SetActive(true);
                        slot9mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        if (poriadoksmenith == 0 && slot3target1 != vybrMishen && slot3target2 != vybrMishen && slot3target3 != vybrMishen)
                        {
                            slot3target1 = vybrMishen;
                            poriadoksmenith += 1;
                        }
                        else if (poriadoksmenith == 1 && slot3target1 != vybrMishen && slot3target2 != vybrMishen && slot3target3 != vybrMishen)
                        {
                            slot3target2 = vybrMishen;
                            poriadoksmenith = 0;
                        }
                        slot3target3 = null;
                    }
                }
                else
                {
                    thispartisread102 = true;
                }

                specialtarget1 = slot3target1;
                specialtarget2 = slot3target2;
                specialtarget3 = slot3target3;

            }
        }
        if (slot7skill == 33 && thispartisread103 == false)
        {
            if (slot7target1 == null)
            {
                if (movedSkill == skil33)
                {
                    poriadoksmenith = 0;
                    slot7target1 = slotVraga9;
                    slot7target2 = slotVraga8;
                    slot7target3 = null;
                }
                else
                {
                    poriadoksmenith = 0;
                    slot7target1 = slotVraga9;
                    slot7target2 = slotVraga8;
                    slot7target3 = null;
                    thispartisread103 = true;
                }
            }
            else if (slot7target1 != null)
            {
                if (movedSkill == skil33)
                {
                    if (vybrMishen == null)
                    {
                        slot1mishVraga.SetActive(true);
                        slot2mishVraga.SetActive(true);
                        slot3mishVraga.SetActive(true);
                        slot4mishVraga.SetActive(true);
                        slot5mishVraga.SetActive(true);
                        slot6mishVraga.SetActive(true);
                        slot7mishVraga.SetActive(true);
                        slot8mishVraga.SetActive(true);
                        slot9mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        if (poriadoksmenith == 0 && slot7target1 != vybrMishen && slot7target2 != vybrMishen && slot7target3 != vybrMishen)
                        {
                            slot7target1 = vybrMishen;
                            poriadoksmenith += 1;
                        }
                        else if (poriadoksmenith == 1 && slot7target1 != vybrMishen && slot7target2 != vybrMishen && slot7target3 != vybrMishen)
                        {
                            slot7target2 = vybrMishen;
                            poriadoksmenith = 0;
                        }
                        slot7target3 = null;
                    }
                }
                else
                {
                    thispartisread103 = true;
                }

                specialtarget1 = slot7target1;
                specialtarget2 = slot7target2;
                specialtarget3 = slot7target3;

            }
        }
        if (slot8skill == 33 && thispartisread104 == false)
        {
            if (slot8target1 == null)
            {
                if (movedSkill == skil33)
                {
                    poriadoksmenith = 0;
                    slot8target1 = slotVraga9;
                    slot8target2 = slotVraga8;
                    slot8target3 = null;
                }
                else
                {
                    poriadoksmenith = 0;
                    slot8target1 = slotVraga9;
                    slot8target2 = slotVraga8;
                    slot8target3 = null;
                    thispartisread104 = true;
                }
            }
            else if (slot8target1 != null)
            {
                if (movedSkill == skil33)
                {
                    if (vybrMishen == null)
                    {
                        slot1mishVraga.SetActive(true);
                        slot2mishVraga.SetActive(true);
                        slot3mishVraga.SetActive(true);
                        slot4mishVraga.SetActive(true);
                        slot5mishVraga.SetActive(true);
                        slot6mishVraga.SetActive(true);
                        slot7mishVraga.SetActive(true);
                        slot8mishVraga.SetActive(true);
                        slot9mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        if (poriadoksmenith == 0 && slot8target1 != vybrMishen && slot8target2 != vybrMishen && slot8target3 != vybrMishen)
                        {
                            slot8target1 = vybrMishen;
                            poriadoksmenith += 1;
                        }
                        else if (poriadoksmenith == 1 && slot8target1 != vybrMishen && slot8target2 != vybrMishen && slot8target3 != vybrMishen)
                        {
                            slot8target2 = vybrMishen;
                            poriadoksmenith = 0;
                        }
                        slot8target3 = null;
                    }
                }
                else
                {
                    thispartisread104 = true;
                }

                specialtarget1 = slot8target1;
                specialtarget2 = slot8target2;
                specialtarget3 = slot8target3;

            }
        }
        if (slot9skill == 33 && thispartisread105 == false)
        {
            if (slot9target1 == null)
            {
                if (movedSkill == skil33)
                {
                    poriadoksmenith = 0;
                    slot9target1 = slotVraga9;
                    slot9target2 = slotVraga8;
                    slot9target3 = null;
                }
                else
                {
                    poriadoksmenith = 0;
                    slot9target1 = slotVraga9;
                    slot9target2 = slotVraga8;
                    slot9target3 = null;
                    thispartisread105 = true;
                }
            }
            else if (slot9target1 != null)
            {
                if (movedSkill == skil33)
                {
                    if (vybrMishen == null)
                    {
                        slot1mishVraga.SetActive(true);
                        slot2mishVraga.SetActive(true);
                        slot3mishVraga.SetActive(true);
                        slot4mishVraga.SetActive(true);
                        slot5mishVraga.SetActive(true);
                        slot6mishVraga.SetActive(true);
                        slot7mishVraga.SetActive(true);
                        slot8mishVraga.SetActive(true);
                        slot9mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        if (poriadoksmenith == 0 && slot9target1 != vybrMishen && slot9target2 != vybrMishen && slot9target3 != vybrMishen)
                        {
                            slot9target1 = vybrMishen;
                            poriadoksmenith += 1;
                        }
                        else if (poriadoksmenith == 1 && slot9target1 != vybrMishen && slot9target2 != vybrMishen && slot9target3 != vybrMishen)
                        {
                            slot9target2 = vybrMishen;
                            poriadoksmenith = 0;
                        }
                        slot9target3 = null;
                    }
                }
                else
                {
                    thispartisread105 = true;
                }

                specialtarget1 = slot9target1;
                specialtarget2 = slot9target2;
                specialtarget3 = slot9target3;

            }
        }
        // 34 скилл
        if (slot4skill == 34 && thispartisread106 == false)
        {
            if (slot4target1 == null)
            {
                if (movedSkill == skil34)
                {
                    slot4target1 = slotVraga9;
                    slot4target2 = slotVraga8;
                    slot4target3 = slotVraga7;
                }
                else
                {
                    slot4target1 = slotVraga9;
                    slot4target2 = slotVraga8;
                    slot4target3 = slotVraga7;
                    thispartisread106 = true;
                }
            }
            else if (slot4target1 != null)
            {
                if (movedSkill == skil34)
                {
                    if (vybrMishen == null)
                    {
                        slot1mishVraga.SetActive(true);
                        slot2mishVraga.SetActive(true);
                        slot3mishVraga.SetActive(true);
                        slot4mishVraga.SetActive(true);
                        slot5mishVraga.SetActive(true);
                        slot6mishVraga.SetActive(true);
                        slot7mishVraga.SetActive(true);
                        slot8mishVraga.SetActive(true);
                        slot9mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        if (vybrMishen == slotVraga1 || vybrMishen == slotVraga2 || vybrMishen == slotVraga3)
                        {

                            slot4target1 = slotVraga1;
                            slot4target2 = slotVraga2;
                            slot4target3 = slotVraga3;
                        }
                        else if (vybrMishen == slotVraga4 || vybrMishen == slotVraga5 || vybrMishen == slotVraga6)
                        {

                            slot4target1 = slotVraga4;
                            slot4target2 = slotVraga5;
                            slot4target3 = slotVraga6;
                        }
                        else if (vybrMishen == slotVraga7 || vybrMishen == slotVraga8 || vybrMishen == slotVraga9)
                        {

                            slot4target1 = slotVraga7;
                            slot4target2 = slotVraga8;
                            slot4target3 = slotVraga9;
                        }
                    }
                }
                else
                {
                    thispartisread106 = true;
                }

                specialtarget1 = slot4target1;
                specialtarget2 = slot4target2;
                specialtarget3 = slot4target3;

            }
        }
        if (slot5skill == 34 && thispartisread107 == false)
        {
            if (slot5target1 == null)
            {
                if (movedSkill == skil34)
                {
                    slot5target1 = slotVraga9;
                    slot5target2 = slotVraga8;
                    slot5target3 = slotVraga7;
                }
                else
                {
                    slot5target1 = slotVraga9;
                    slot5target2 = slotVraga8;
                    slot5target3 = slotVraga7;
                    thispartisread107 = true;
                }
            }
            else if (slot5target1 != null)
            {
                if (movedSkill == skil34)
                {
                    if (vybrMishen == null)
                    {
                        slot1mishVraga.SetActive(true);
                        slot2mishVraga.SetActive(true);
                        slot3mishVraga.SetActive(true);
                        slot4mishVraga.SetActive(true);
                        slot5mishVraga.SetActive(true);
                        slot6mishVraga.SetActive(true);
                        slot7mishVraga.SetActive(true);
                        slot8mishVraga.SetActive(true);
                        slot9mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        if (vybrMishen == slotVraga1 || vybrMishen == slotVraga2 || vybrMishen == slotVraga3)
                        {

                            slot5target1 = slotVraga1;
                            slot5target2 = slotVraga2;
                            slot5target3 = slotVraga3;
                        }
                        else if (vybrMishen == slotVraga4 || vybrMishen == slotVraga5 || vybrMishen == slotVraga6)
                        {

                            slot5target1 = slotVraga4;
                            slot5target2 = slotVraga5;
                            slot5target3 = slotVraga6;
                        }
                        else if (vybrMishen == slotVraga7 || vybrMishen == slotVraga8 || vybrMishen == slotVraga9)
                        {

                            slot5target1 = slotVraga7;
                            slot5target2 = slotVraga8;
                            slot5target3 = slotVraga9;
                        }
                    }
                }
                else
                {
                    thispartisread107 = true;
                }

                specialtarget1 = slot5target1;
                specialtarget2 = slot5target2;
                specialtarget3 = slot5target3;

            }
        }
        if (slot6skill == 34 && thispartisread108 == false)
        {
            if (slot6target1 == null)
            {
                if (movedSkill == skil34)
                {
                    slot6target1 = slotVraga9;
                    slot6target2 = slotVraga8;
                    slot6target3 = slotVraga7;
                }
                else
                {
                    slot6target1 = slotVraga9;
                    slot6target2 = slotVraga8;
                    slot6target3 = slotVraga7;
                    thispartisread108 = true;
                }
            }
            else if (slot6target1 != null)
            {
                if (movedSkill == skil34)
                {
                    if (vybrMishen == null)
                    {
                        slot1mishVraga.SetActive(true);
                        slot2mishVraga.SetActive(true);
                        slot3mishVraga.SetActive(true);
                        slot4mishVraga.SetActive(true);
                        slot5mishVraga.SetActive(true);
                        slot6mishVraga.SetActive(true);
                        slot7mishVraga.SetActive(true);
                        slot8mishVraga.SetActive(true);
                        slot9mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        if (vybrMishen == slotVraga1 || vybrMishen == slotVraga2 || vybrMishen == slotVraga3)
                        {

                            slot6target1 = slotVraga1;
                            slot6target2 = slotVraga2;
                            slot6target3 = slotVraga3;
                        }
                        else if (vybrMishen == slotVraga4 || vybrMishen == slotVraga5 || vybrMishen == slotVraga6)
                        {

                            slot6target1 = slotVraga4;
                            slot6target2 = slotVraga5;
                            slot6target3 = slotVraga6;
                        }
                        else if (vybrMishen == slotVraga7 || vybrMishen == slotVraga8 || vybrMishen == slotVraga9)
                        {

                            slot6target1 = slotVraga7;
                            slot6target2 = slotVraga8;
                            slot6target3 = slotVraga9;
                        }
                    }
                }
                else
                {
                    thispartisread108 = true;
                }

                specialtarget1 = slot6target1;
                specialtarget2 = slot6target2;
                specialtarget3 = slot6target3;

            }
        }
        if (slot7skill == 34 && thispartisread109 == false)
        {
            if (slot7target1 == null)
            {
                if (movedSkill == skil34)
                {
                    slot7target1 = slotVraga9;
                    slot7target2 = slotVraga8;
                    slot7target3 = slotVraga7;
                }
                else
                {
                    slot7target1 = slotVraga9;
                    slot7target2 = slotVraga8;
                    slot7target3 = slotVraga7;
                    thispartisread109 = true;
                }
            }
            else if (slot7target1 != null)
            {
                if (movedSkill == skil34)
                {
                    if (vybrMishen == null)
                    {
                        slot1mishVraga.SetActive(true);
                        slot2mishVraga.SetActive(true);
                        slot3mishVraga.SetActive(true);
                        slot4mishVraga.SetActive(true);
                        slot5mishVraga.SetActive(true);
                        slot6mishVraga.SetActive(true);
                        slot7mishVraga.SetActive(true);
                        slot8mishVraga.SetActive(true);
                        slot9mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        if (vybrMishen == slotVraga1 || vybrMishen == slotVraga2 || vybrMishen == slotVraga3)
                        {

                            slot7target1 = slotVraga1;
                            slot7target2 = slotVraga2;
                            slot7target3 = slotVraga3;
                        }
                        else if (vybrMishen == slotVraga4 || vybrMishen == slotVraga5 || vybrMishen == slotVraga6)
                        {

                            slot7target1 = slotVraga4;
                            slot7target2 = slotVraga5;
                            slot7target3 = slotVraga6;
                        }
                        else if (vybrMishen == slotVraga7 || vybrMishen == slotVraga8 || vybrMishen == slotVraga9)
                        {

                            slot7target1 = slotVraga7;
                            slot7target2 = slotVraga8;
                            slot7target3 = slotVraga9;
                        }
                    }
                }
                else
                {
                    thispartisread109 = true;
                }

                specialtarget1 = slot7target1;
                specialtarget2 = slot7target2;
                specialtarget3 = slot7target3;

            }
        }
        if (slot9skill == 34 && thispartisread110 == false)
        {
            if (slot9target1 == null)
            {
                if (movedSkill == skil34)
                {
                    slot9target1 = slotVraga9;
                    slot9target2 = slotVraga8;
                    slot9target3 = slotVraga7;
                }
                else
                {
                    slot9target1 = slotVraga9;
                    slot9target2 = slotVraga8;
                    slot9target3 = slotVraga7;
                    thispartisread110 = true;
                }
            }
            else if (slot9target1 != null)
            {
                if (movedSkill == skil34)
                {
                    if (vybrMishen == null)
                    {
                        slot1mishVraga.SetActive(true);
                        slot2mishVraga.SetActive(true);
                        slot3mishVraga.SetActive(true);
                        slot4mishVraga.SetActive(true);
                        slot5mishVraga.SetActive(true);
                        slot6mishVraga.SetActive(true);
                        slot7mishVraga.SetActive(true);
                        slot8mishVraga.SetActive(true);
                        slot9mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        if (vybrMishen == slotVraga1 || vybrMishen == slotVraga2 || vybrMishen == slotVraga3)
                        {

                            slot9target1 = slotVraga1;
                            slot9target2 = slotVraga2;
                            slot9target3 = slotVraga3;
                        }
                        else if (vybrMishen == slotVraga4 || vybrMishen == slotVraga5 || vybrMishen == slotVraga6)
                        {

                            slot9target1 = slotVraga4;
                            slot9target2 = slotVraga5;
                            slot9target3 = slotVraga6;
                        }
                        else if (vybrMishen == slotVraga7 || vybrMishen == slotVraga8 || vybrMishen == slotVraga9)
                        {

                            slot9target1 = slotVraga7;
                            slot9target2 = slotVraga8;
                            slot9target3 = slotVraga9;
                        }
                    }
                }
                else
                {
                    thispartisread110 = true;
                }

                specialtarget1 = slot9target1;
                specialtarget2 = slot9target2;
                specialtarget3 = slot9target3;

            }
        }
        // скилл 35
        if (slot1skill == 35 && thispartisread111 == false)
        {
            if (slot1target1 == null)
            {
                if (movedSkill == skil35)
                {
                    slot1target1 = slotGG2;
                    slot1target2 = slotGG4;
                    slot1target3 = slotGG5;
                }
                else
                {
                    slot1target1 = slotGG2;
                    slot1target2 = slotGG4;
                    slot1target3 = slotGG5;
                    thispartisread111 = true;
                }
            }
            else if (slot1target1 != null)
            {
                if (movedSkill == skil35)
                {
                    if (vybrMishen == null)
                    {
                        slot2mish.SetActive(true);
                        slot4mish.SetActive(true);
                        slot5mish.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {


                    }
                }
                else
                {
                    thispartisread111 = true;
                }

                specialtarget1 = slot1target1;
                specialtarget2 = slot1target2;
                specialtarget3 = slot1target3;

            }
        }
        if (slot3skill == 35 && thispartisread112 == false)
        {
            if (slot3target1 == null)
            {
                if (movedSkill == skil35)
                {
                    slot3target1 = slotGG2;
                    slot3target2 = slotGG6;
                    slot3target3 = slotGG5;
                }
                else
                {
                    slot3target1 = slotGG2;
                    slot3target2 = slotGG6;
                    slot3target3 = slotGG5;
                    thispartisread112 = true;
                }
            }
            else if (slot3target1 != null)
            {
                if (movedSkill == skil35)
                {
                    if (vybrMishen == null)
                    {
                        slot2mish.SetActive(true);
                        slot6mish.SetActive(true);
                        slot5mish.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {


                    }
                }
                else
                {
                    thispartisread112 = true;
                }

                specialtarget1 = slot3target1;
                specialtarget2 = slot3target2;
                specialtarget3 = slot3target3;

            }
        }
        if (slot2skill == 35 && thispartisread113 == false)
        {
            if (slot2target1 == null)
            {
                if (movedSkill == skil35)
                {
                    poriadoksme = 0;
                    slot2target1 = slotGG6;
                    slot2target2 = slotGG5;
                    slot2target3 = slotGG4;
                }
                else
                {
                    poriadoksme = 0;
                    slot2target1 = slotGG6;
                    slot2target2 = slotGG5;
                    slot2target3 = slotGG4;
                    thispartisread113 = true;
                }
            }
            else if (slot2target1 != null)
            {
                if (movedSkill == skil35)
                {
                    if (vybrMishen == null)
                    {
                        slot1mish.SetActive(true);
                        slot3mish.SetActive(true);
                        slot4mish.SetActive(true);
                        slot5mish.SetActive(true);
                        slot6mish.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {

                        if (poriadoksme == 0 && slot2target1 != vybrMishen && slot2target2 != vybrMishen && slot2target3 != vybrMishen)
                        {
                            slot2target1 = vybrMishen;
                            poriadoksme += 1;
                        }
                        else if (poriadoksme == 1 && slot2target1 != vybrMishen && slot2target2 != vybrMishen && slot2target3 != vybrMishen)
                        {
                            slot2target2 = vybrMishen;
                            poriadoksme += 1;
                        }
                        else if (poriadoksme == 2 && slot2target1 != vybrMishen && slot2target2 != vybrMishen && slot2target3 != vybrMishen)
                        {
                            slot2target3 = vybrMishen;
                            poriadoksme = 0;
                        }
                    }
                }
                else
                {
                    thispartisread113 = true;
                }

                specialtarget1 = slot2target1;
                specialtarget2 = slot2target2;
                specialtarget3 = slot2target3;

            }
        }
        // 36 скилл
        if (slot2skill == 36 && thispartisread114 == false)
        {
            if (slot2target1 == null)
            {
                if (movedSkill == skil36)
                {
                    slot2target1 = slotGG1;
                    slot2target2 = slotGG2;
                    slot2target3 = slotGG3;
                }
                else
                {
                    slot2target1 = slotGG1;
                    slot2target2 = slotGG2;
                    slot2target3 = slotGG3;
                    thispartisread114 = true;
                }
            }
            else if (slot2target1 != null)
            {
                if (movedSkill == skil36)
                {
                    if (vybrMishen == null)
                    {
                        slot1mish.SetActive(true);
                        slot2mish.SetActive(true);
                        slot3mish.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {


                    }
                }
                else
                {
                    thispartisread114 = true;
                }

                specialtarget1 = slot2target1;
                specialtarget2 = slot2target2;
                specialtarget3 = slot2target3;

            }
        }
        if (slot5skill == 36 && thispartisread115 == false)
        {
            if (slot5target1 == null)
            {
                if (movedSkill == skil36)
                {
                    slot5target1 = slotGG4;
                    slot5target2 = slotGG5;
                    slot5target3 = slotGG6;
                }
                else
                {
                    slot5target1 = slotGG4;
                    slot5target2 = slotGG5;
                    slot5target3 = slotGG6;
                    thispartisread115 = true;
                }
            }
            else if (slot5target1 != null)
            {
                if (movedSkill == skil36)
                {
                    if (vybrMishen == null)
                    {
                        slot4mish.SetActive(true);
                        slot5mish.SetActive(true);
                        slot6mish.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {


                    }
                }
                else
                {
                    thispartisread115 = true;
                }

                specialtarget1 = slot5target1;
                specialtarget2 = slot5target2;
                specialtarget3 = slot5target3;

            }
        }
        if (slot8skill == 36 && thispartisread116 == false)
        {
            if (slot8target1 == null)
            {
                if (movedSkill == skil36)
                {
                    slot8target1 = slotGG7;
                    slot8target2 = slotGG8;
                    slot8target3 = slotGG9;
                }
                else
                {
                    slot8target1 = slotGG7;
                    slot8target2 = slotGG8;
                    slot8target3 = slotGG9;
                    thispartisread116 = true;
                }
            }
            else if (slot8target1 != null)
            {
                if (movedSkill == skil36)
                {
                    if (vybrMishen == null)
                    {
                        slot7mish.SetActive(true);
                        slot8mish.SetActive(true);
                        slot9mish.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {


                    }
                }
                else
                {
                    thispartisread116 = true;
                }

                specialtarget1 = slot8target1;
                specialtarget2 = slot8target2;
                specialtarget3 = slot8target3;

            }
        }
        // 37 скилл
        if (slot5skill == 37 && thispartisread117 == false)
        {
            if (slot5target1 == null)
            {
                if (movedSkill == skil37)
                {
                    poriadok = 0;
                    slot5target1 = slotVraga9;
                    slot5target2 = slotVraga8;
                    slot5target3 = slotVraga7;
                }
                else
                {
                    poriadok = 0;
                    slot5target1 = slotVraga9;
                    slot5target2 = slotVraga8;
                    slot5target3 = slotVraga7;
                    thispartisread117 = true;
                }
            }
            else if (slot5target1 != null)
            {
                if (movedSkill == skil37)
                {
                    if (vybrMishen == null)
                    {
                        slot1mishVraga.SetActive(true);
                        slot2mishVraga.SetActive(true);
                        slot3mishVraga.SetActive(true);
                        slot4mishVraga.SetActive(true);
                        slot5mishVraga.SetActive(true);
                        slot6mishVraga.SetActive(true);
                        slot7mishVraga.SetActive(true);
                        slot8mishVraga.SetActive(true);
                        slot9mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        if (poriadok == 0 && slot5target1 != vybrMishen && slot5target2 != vybrMishen && slot5target3 != vybrMishen)
                        {
                            slot5target1 = vybrMishen;
                            poriadok += 1;
                        }
                        else if (poriadok == 1 && slot5target1 != vybrMishen && slot5target2 != vybrMishen && slot5target3 != vybrMishen)
                        {
                            slot5target2 = vybrMishen;
                            poriadok += 1;
                        }
                        else if (poriadok == 2 && slot5target1 != vybrMishen && slot5target2 != vybrMishen && slot5target3 != vybrMishen)
                        {
                            slot5target3 = vybrMishen;
                            poriadok = 0;
                        }

                    }
                }
                else
                {
                    thispartisread117 = true;
                }

                specialtarget1 = slot5target1;
                specialtarget2 = slot5target2;
                specialtarget3 = slot5target3;

            }
        }
        if (slot7skill == 37 && thispartisread118 == false)
        {
            if (slot7target1 == null)
            {
                if (movedSkill == skil37)
                {
                    poriadok = 0;
                    slot7target1 = slotVraga9;
                    slot7target2 = slotVraga8;
                    slot7target3 = slotVraga7;
                }
                else
                {
                    poriadok = 0;
                    slot7target1 = slotVraga9;
                    slot7target2 = slotVraga8;
                    slot7target3 = slotVraga7;
                    thispartisread118 = true;
                }
            }
            else if (slot7target1 != null)
            {
                if (movedSkill == skil37)
                {
                    if (vybrMishen == null)
                    {
                        slot1mishVraga.SetActive(true);
                        slot2mishVraga.SetActive(true);
                        slot3mishVraga.SetActive(true);
                        slot4mishVraga.SetActive(true);
                        slot5mishVraga.SetActive(true);
                        slot6mishVraga.SetActive(true);
                        slot7mishVraga.SetActive(true);
                        slot8mishVraga.SetActive(true);
                        slot9mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        if (poriadok == 0 && slot7target1 != vybrMishen && slot7target2 != vybrMishen && slot7target3 != vybrMishen)
                        {
                            slot7target1 = vybrMishen;
                            poriadok += 1;
                        }
                        else if (poriadok == 1 && slot7target1 != vybrMishen && slot7target2 != vybrMishen && slot7target3 != vybrMishen)
                        {
                            slot7target2 = vybrMishen;
                            poriadok += 1;
                        }
                        else if (poriadok == 2 && slot7target1 != vybrMishen && slot7target2 != vybrMishen && slot7target3 != vybrMishen)
                        {
                            slot7target3 = vybrMishen;
                            poriadok = 0;
                        }

                    }
                }
                else
                {
                    thispartisread118 = true;
                }

                specialtarget1 = slot7target1;
                specialtarget2 = slot7target2;
                specialtarget3 = slot7target3;

            }
        }
        if (slot8skill == 37 && thispartisread119 == false)
        {
            if (slot8target1 == null)
            {
                if (movedSkill == skil37)
                {
                    poriadok = 0;
                    slot8target1 = slotVraga9;
                    slot8target2 = slotVraga8;
                    slot8target3 = slotVraga7;
                }
                else
                {
                    poriadok = 0;
                    slot8target1 = slotVraga9;
                    slot8target2 = slotVraga8;
                    slot8target3 = slotVraga7;
                    thispartisread119 = true;
                }
            }
            else if (slot8target1 != null)
            {
                if (movedSkill == skil37)
                {
                    if (vybrMishen == null)
                    {
                        slot1mishVraga.SetActive(true);
                        slot2mishVraga.SetActive(true);
                        slot3mishVraga.SetActive(true);
                        slot4mishVraga.SetActive(true);
                        slot5mishVraga.SetActive(true);
                        slot6mishVraga.SetActive(true);
                        slot7mishVraga.SetActive(true);
                        slot8mishVraga.SetActive(true);
                        slot9mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        if (poriadok == 0 && slot8target1 != vybrMishen && slot8target2 != vybrMishen && slot8target3 != vybrMishen)
                        {
                            slot8target1 = vybrMishen;
                            poriadok += 1;
                        }
                        else if (poriadok == 1 && slot8target1 != vybrMishen && slot8target2 != vybrMishen && slot8target3 != vybrMishen)
                        {
                            slot8target2 = vybrMishen;
                            poriadok += 1;
                        }
                        else if (poriadok == 2 && slot8target1 != vybrMishen && slot8target2 != vybrMishen && slot8target3 != vybrMishen)
                        {
                            slot8target3 = vybrMishen;
                            poriadok = 0;
                        }

                    }
                }
                else
                {
                    thispartisread119 = true;
                }

                specialtarget1 = slot8target1;
                specialtarget2 = slot8target2;
                specialtarget3 = slot8target3;

            }
        }
        if (slot9skill == 37 && thispartisread120 == false)
        {
            if (slot9target1 == null)
            {
                if (movedSkill == skil37)
                {
                    poriadok = 0;
                    slot9target1 = slotVraga9;
                    slot9target2 = slotVraga8;
                    slot9target3 = slotVraga7;
                }
                else
                {
                    poriadok = 0;
                    slot9target1 = slotVraga9;
                    slot9target2 = slotVraga8;
                    slot9target3 = slotVraga7;
                    thispartisread120 = true;
                }
            }
            else if (slot9target1 != null)
            {
                if (movedSkill == skil37)
                {
                    if (vybrMishen == null)
                    {
                        slot1mishVraga.SetActive(true);
                        slot2mishVraga.SetActive(true);
                        slot3mishVraga.SetActive(true);
                        slot4mishVraga.SetActive(true);
                        slot5mishVraga.SetActive(true);
                        slot6mishVraga.SetActive(true);
                        slot7mishVraga.SetActive(true);
                        slot8mishVraga.SetActive(true);
                        slot9mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        if (poriadok == 0 && slot9target1 != vybrMishen && slot9target2 != vybrMishen && slot9target3 != vybrMishen)
                        {
                            slot9target1 = vybrMishen;
                            poriadok += 1;
                        }
                        else if (poriadok == 1 && slot9target1 != vybrMishen && slot9target2 != vybrMishen && slot9target3 != vybrMishen)
                        {
                            slot9target2 = vybrMishen;
                            poriadok += 1;
                        }
                        else if (poriadok == 2 && slot9target1 != vybrMishen && slot9target2 != vybrMishen && slot9target3 != vybrMishen)
                        {
                            slot9target3 = vybrMishen;
                            poriadok = 0;
                        }

                    }
                }
                else
                {
                    thispartisread120 = true;
                }

                specialtarget1 = slot9target1;
                specialtarget2 = slot9target2;
                specialtarget3 = slot9target3;

            }
        }
        // 38 скилл
        if (slot9skill == 38 && thispartisread121 == false)
        {
            if (slot9target1 == null)
            {
                if (movedSkill == skil38)
                {
                    slot9target1 = slotVraga9;
                    slot9target2 = null;
                    slot9target3 = null;
                }
                else
                {
                    slot9target1 = slotVraga9;
                    slot9target2 = null;
                    slot9target3 = null;
                    thispartisread121 = true;
                }
            }
            else if (slot9target1 != null)
            {
                if (movedSkill == skil38)
                {
                    if (vybrMishen == null)
                    {
                        slot3mishVraga.SetActive(true);
                        slot6mishVraga.SetActive(true);
                        slot9mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot9target1 = vybrMishen;
                        slot9target2 = null;
                        slot9target3 = null;
                    }
                }
                else
                {
                    thispartisread121 = true;
                }

                specialtarget1 = slot9target1;
                specialtarget2 = slot9target2;
                specialtarget3 = slot9target3;

            }
        }
        if (slot8skill == 38 && thispartisread122 == false)
        {
            if (slot8target1 == null)
            {
                if (movedSkill == skil38)
                {
                    slot8target1 = slotVraga9;
                    slot8target2 = null;
                    slot8target3 = null;
                }
                else
                {
                    slot8target1 = slotVraga9;
                    slot8target2 = null;
                    slot8target3 = null;
                    thispartisread122 = true;
                }
            }
            else if (slot8target1 != null)
            {
                if (movedSkill == skil38)
                {
                    if (vybrMishen == null)
                    {
                        slot2mishVraga.SetActive(true);
                        slot5mishVraga.SetActive(true);
                        slot8mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot8target1 = vybrMishen;
                        slot8target2 = null;
                        slot8target3 = null;
                    }
                }
                else
                {
                    thispartisread122 = true;
                }

                specialtarget1 = slot8target1;
                specialtarget2 = slot8target2;
                specialtarget3 = slot8target3;

            }
        }
        if (slot7skill == 38 && thispartisread123 == false)
        {
            if (slot7target1 == null)
            {
                if (movedSkill == skil38)
                {
                    slot7target1 = slotVraga9;
                    slot7target2 = null;
                    slot7target3 = null;
                }
                else
                {
                    slot7target1 = slotVraga9;
                    slot7target2 = null;
                    slot7target3 = null;
                    thispartisread123 = true;
                }
            }
            else if (slot7target1 != null)
            {
                if (movedSkill == skil38)
                {
                    if (vybrMishen == null)
                    {
                        slot1mishVraga.SetActive(true);
                        slot4mishVraga.SetActive(true);
                        slot7mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot7target1 = vybrMishen;
                        slot7target2 = null;
                        slot7target3 = null;
                    }
                }
                else
                {
                    thispartisread123 = true;
                }

                specialtarget1 = slot7target1;
                specialtarget2 = slot7target2;
                specialtarget3 = slot7target3;

            }
        }
        if (slot6skill == 38 && thispartisread124 == false)
        {
            if (slot6target1 == null)
            {
                if (movedSkill == skil38)
                {
                    slot6target1 = slotVraga9;
                    slot6target2 = null;
                    slot6target3 = null;
                }
                else
                {
                    slot6target1 = slotVraga9;
                    slot6target2 = null;
                    slot6target3 = null;
                    thispartisread124 = true;
                }
            }
            else if (slot6target1 != null)
            {
                if (movedSkill == skil38)
                {
                    if (vybrMishen == null)
                    {
                        slot3mishVraga.SetActive(true);
                        slot6mishVraga.SetActive(true);
                        slot9mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot6target1 = vybrMishen;
                        slot6target2 = null;
                        slot6target3 = null;
                    }
                }
                else
                {
                    thispartisread124 = true;
                }

                specialtarget1 = slot6target1;
                specialtarget2 = slot6target2;
                specialtarget3 = slot6target3;

            }
        }
        if (slot5skill == 38 && thispartisread125 == false)
        {
            if (slot5target1 == null)
            {
                if (movedSkill == skil38)
                {
                    slot5target1 = slotVraga9;
                    slot5target2 = null;
                    slot5target3 = null;
                }
                else
                {
                    slot5target1 = slotVraga9;
                    slot5target2 = null;
                    slot5target3 = null;
                    thispartisread125 = true;
                }
            }
            else if (slot5target1 != null)
            {
                if (movedSkill == skil38)
                {
                    if (vybrMishen == null)
                    {
                        slot2mishVraga.SetActive(true);
                        slot5mishVraga.SetActive(true);
                        slot8mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot5target1 = vybrMishen;
                        slot5target2 = null;
                        slot5target3 = null;
                    }
                }
                else
                {
                    thispartisread125 = true;
                }

                specialtarget1 = slot5target1;
                specialtarget2 = slot5target2;
                specialtarget3 = slot5target3;

            }
        }
        if (slot4skill == 38 && thispartisread126 == false)
        {
            if (slot4target1 == null)
            {
                if (movedSkill == skil38)
                {
                    slot4target1 = slotVraga9;
                    slot4target2 = null;
                    slot4target3 = null;
                }
                else
                {
                    slot4target1 = slotVraga9;
                    slot4target2 = null;
                    slot4target3 = null;
                    thispartisread126 = true;
                }
            }
            else if (slot4target1 != null)
            {
                if (movedSkill == skil38)
                {
                    if (vybrMishen == null)
                    {
                        slot1mishVraga.SetActive(true);
                        slot4mishVraga.SetActive(true);
                        slot7mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot4target1 = vybrMishen;
                        slot4target2 = null;
                        slot4target3 = null;
                    }
                }
                else
                {
                    thispartisread126 = true;
                }

                specialtarget1 = slot4target1;
                specialtarget2 = slot4target2;
                specialtarget3 = slot4target3;

            }
        }
        if (slot3skill == 38 && thispartisread127 == false)
        {
            if (slot3target1 == null)
            {
                if (movedSkill == skil38)
                {
                    slot3target1 = slotVraga9;
                    slot3target2 = null;
                    slot3target3 = null;
                }
                else
                {
                    slot3target1 = slotVraga9;
                    slot3target2 = null;
                    slot3target3 = null;
                    thispartisread127 = true;
                }
            }
            else if (slot3target1 != null)
            {
                if (movedSkill == skil38)
                {
                    if (vybrMishen == null)
                    {
                        slot3mishVraga.SetActive(true);
                        slot6mishVraga.SetActive(true);
                        slot9mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot3target1 = vybrMishen;
                        slot3target2 = null;
                        slot3target3 = null;
                    }
                }
                else
                {
                    thispartisread127 = true;
                }

                specialtarget1 = slot3target1;
                specialtarget2 = slot3target2;
                specialtarget3 = slot3target3;

            }
        }
        if (slot2skill == 38 && thispartisread128 == false)
        {
            if (slot2target1 == null)
            {
                if (movedSkill == skil38)
                {
                    slot2target1 = slotVraga9;
                    slot2target2 = null;
                    slot2target3 = null;
                }
                else
                {
                    slot2target1 = slotVraga9;
                    slot2target2 = null;
                    slot2target3 = null;
                    thispartisread128 = true;
                }
            }
            else if (slot2target1 != null)
            {
                if (movedSkill == skil38)
                {
                    if (vybrMishen == null)
                    {
                        slot2mishVraga.SetActive(true);
                        slot5mishVraga.SetActive(true);
                        slot8mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot2target1 = vybrMishen;
                        slot2target2 = null;
                        slot2target3 = null;
                    }
                }
                else
                {
                    thispartisread128 = true;
                }

                specialtarget1 = slot2target1;
                specialtarget2 = slot2target2;
                specialtarget3 = slot2target3;

            }
        }
        if (slot1skill == 38 && thispartisread129 == false)
        {
            if (slot1target1 == null)
            {
                if (movedSkill == skil38)
                {
                    slot1target1 = slotVraga9;
                    slot1target2 = null;
                    slot1target3 = null;
                }
                else
                {
                    slot1target1 = slotVraga9;
                    slot1target2 = null;
                    slot1target3 = null;
                    thispartisread129 = true;
                }
            }
            else if (slot1target1 != null)
            {
                if (movedSkill == skil38)
                {
                    if (vybrMishen == null)
                    {
                        slot1mishVraga.SetActive(true);
                        slot4mishVraga.SetActive(true);
                        slot7mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot1target1 = vybrMishen;
                        slot1target2 = null;
                        slot1target3 = null;
                    }
                }
                else
                {
                    thispartisread129 = true;
                }

                specialtarget1 = slot1target1;
                specialtarget2 = slot1target2;
                specialtarget3 = slot1target3;

            }
        }
        if (slot5skill == 39 && thispartisread130 == false)
        {
            if (slot5target1 == null)
            {
                if (movedSkill == skil39)
                {
                    poriad = 0;
                    slot5target1 = slotGG9;
                    slot5target2 = slotGG8;
                    slot5target3 = null;
                }
                else
                {
                    poriad = 0;
                    slot5target1 = slotGG9;
                    slot5target2 = slotGG8;
                    slot5target3 = null;
                    thispartisread130 = true;
                }
            }
            else if (slot5target1 != null)
            {
                if (movedSkill == skil39)
                {
                    if (vybrMishen == null)
                    {
                        slot1mish.SetActive(true);
                        slot2mish.SetActive(true);
                        slot3mish.SetActive(true);
                        slot4mish.SetActive(true);
                        slot6mish.SetActive(true);
                        slot7mish.SetActive(true);
                        slot8mish.SetActive(true);
                        slot9mish.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        if (poriad == 0 && slot8target1 != vybrMishen && slot8target2 != vybrMishen && slot8target3 != vybrMishen)
                        {
                            slot8target1 = vybrMishen;
                            poriad += 1;
                        }
                        else if (poriad == 1 && slot8target1 != vybrMishen && slot8target2 != vybrMishen && slot8target3 != vybrMishen)
                        {
                            slot8target2 = vybrMishen;
                            poriad = 0;
                        }
                        slot8target3 = null;

                    }
                }
                else
                {
                    thispartisread130 = true;
                }

                specialtarget1 = slot5target1;
                specialtarget2 = slot5target2;
                specialtarget3 = slot5target3;

            }
        }
        if (slot7skill == 39 && thispartisread131 == false)
        {
            if (slot7target1 == null)
            {
                if (movedSkill == skil39)
                {
                    poriad = 0;
                    slot7target1 = slotGG8;
                    slot7target2 = slotGG5;
                    slot7target3 = null;
                }
                else
                {
                    poriad = 0;
                    slot7target1 = slotGG8;
                    slot7target2 = slotGG5;
                    slot7target3 = null;
                    thispartisread131 = true;
                }
            }
            else if (slot7target1 != null)
            {
                if (movedSkill == skil39)
                {
                    if (vybrMishen == null)
                    {
                        slot4mish.SetActive(true);
                        slot5mish.SetActive(true);
                        slot8mish.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        if (poriad == 0 && slot8target1 != vybrMishen && slot8target2 != vybrMishen && slot8target3 != vybrMishen)
                        {
                            slot8target1 = vybrMishen;
                            poriad += 1;
                        }
                        else if (poriad == 1 && slot8target1 != vybrMishen && slot8target2 != vybrMishen && slot8target3 != vybrMishen)
                        {
                            slot8target2 = vybrMishen;
                            poriad = 0;
                        }
                        slot8target3 = null;

                    }
                }
                else
                {
                    thispartisread131 = true;
                }

                specialtarget1 = slot7target1;
                specialtarget2 = slot7target2;
                specialtarget3 = slot7target3;

            }
        }
        if (slot8skill == 39 && thispartisread132 == false)
        {
            if (slot8target1 == null)
            {
                if (movedSkill == skil39)
                {
                    poriad = 0;
                    slot8target1 = slotGG9;
                    slot8target2 = slotGG7;
                    slot8target3 = null;
                }
                else
                {
                    poriad = 0;
                    slot8target1 = slotGG9;
                    slot8target2 = slotGG7;
                    slot8target3 = null;
                    thispartisread132 = true;
                }
            }
            else if (slot8target1 != null)
            {
                if (movedSkill == skil39)
                {
                    if (vybrMishen == null)
                    {
                        slot4mish.SetActive(true);
                        slot5mish.SetActive(true);
                        slot6mish.SetActive(true);
                        slot7mish.SetActive(true);
                        slot9mish.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {

                        if (poriad == 0 && slot8target1 != vybrMishen && slot8target2 != vybrMishen && slot8target3 != vybrMishen)
                        {
                            slot8target1 = vybrMishen;
                            poriad += 1;
                        }
                        else if (poriad == 1 && slot8target1 != vybrMishen && slot8target2 != vybrMishen && slot8target3 != vybrMishen)
                        {
                            slot8target2 = vybrMishen;
                            poriad = 0;
                        }
                        slot8target3 = null;
                    }
                }
                else
                {
                    thispartisread132 = true;
                }

                specialtarget1 = slot8target1;
                specialtarget2 = slot8target2;
                specialtarget3 = slot8target3;

            }
        }

        if (slot9skill == 39 && thispartisread133 == false)
        {
            if (slot9target1 == null)
            {
                if (movedSkill == skil39)
                {
                    poriad = 0;
                    slot9target1 = slotGG6;
                    slot9target2 = slotGG8;
                    slot9target3 = null;
                }
                else
                {
                    poriad = 0;
                    slot9target1 = slotGG6;
                    slot9target2 = slotGG8;
                    slot9target3 = null;
                    thispartisread133 = true;
                }
            }
            else if (slot9target1 != null)
            {
                if (movedSkill == skil39)
                {
                    if (vybrMishen == null)
                    {
                        slot5mish.SetActive(true);
                        slot6mish.SetActive(true);
                        slot8mish.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {

                        if (poriad == 0 && slot9target1 != vybrMishen && slot9target2 != vybrMishen && slot9target3 != vybrMishen)
                        {
                            slot8target1 = vybrMishen;
                            poriad += 1;
                        }
                        else if (poriad == 1 && slot9target1 != vybrMishen && slot9target2 != vybrMishen && slot9target3 != vybrMishen)
                        {
                            slot8target2 = vybrMishen;
                            poriad = 0;
                        }
                        slot8target3 = null;
                    }
                }
                else
                {
                    thispartisread133 = true;
                }

                specialtarget1 = slot9target1;
                specialtarget2 = slot9target2;
                specialtarget3 = slot9target3;

            }
        }
        // скилл 40
        if (slot1skill == 40 && thispartisread134 == false)
        {
            if (slot1target1 == null)
            {
                if (movedSkill == skil40)
                {
                    pori = 0;
                    slot1target1 = slotVraga9;
                    slot1target2 = slotVraga8;
                    slot1target3 = null;
                }
                else
                {
                    pori = 0;
                    slot1target1 = slotVraga9;
                    slot1target2 = slotVraga8;
                    slot1target3 = null;
                    thispartisread134 = true;
                }
            }
            else if (slot1target1 != null)
            {
                if (movedSkill == skil40)
                {
                    if (vybrMishen == null)
                    {
                        slot1mishVraga.SetActive(true);
                        slot2mishVraga.SetActive(true);
                        slot3mishVraga.SetActive(true);
                        slot4mishVraga.SetActive(true);
                        slot5mishVraga.SetActive(true);
                        slot6mishVraga.SetActive(true);
                        slot7mishVraga.SetActive(true);
                        slot8mishVraga.SetActive(true);
                        slot9mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        if (pori == 0 && slot1target1 != vybrMishen && slot1target2 != vybrMishen && slot1target3 != vybrMishen)
                        {
                            slot1target1 = vybrMishen;
                            pori += 1;
                        }
                        else if (pori == 1 && slot1target1 != vybrMishen && slot1target2 != vybrMishen && slot1target3 != vybrMishen)
                        {
                            slot1target2 = vybrMishen;
                            pori = 0;
                        }
                        slot1target3 = null;
                    }
                }
                else
                {
                    thispartisread134 = true;
                }

                specialtarget1 = slot1target1;
                specialtarget2 = slot1target2;
                specialtarget3 = slot1target3;

            }
        }
        if (slot2skill == 40 && thispartisread135 == false)
        {
            if (slot2target1 == null)
            {
                if (movedSkill == skil40)
                {
                    pori = 0;
                    slot2target1 = slotVraga9;
                    slot2target2 = slotVraga8;
                    slot2target3 = null;
                }
                else
                {
                    pori = 0;
                    slot2target1 = slotVraga9;
                    slot2target2 = slotVraga8;
                    slot2target3 = null;
                    thispartisread135 = true;
                }
            }
            else if (slot2target1 != null)
            {
                if (movedSkill == skil40)
                {
                    if (vybrMishen == null)
                    {
                        slot1mishVraga.SetActive(true);
                        slot2mishVraga.SetActive(true);
                        slot3mishVraga.SetActive(true);
                        slot4mishVraga.SetActive(true);
                        slot5mishVraga.SetActive(true);
                        slot6mishVraga.SetActive(true);
                        slot7mishVraga.SetActive(true);
                        slot8mishVraga.SetActive(true);
                        slot9mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        if (pori == 0 && slot2target1 != vybrMishen && slot2target2 != vybrMishen && slot2target3 != vybrMishen)
                        {
                            slot2target1 = vybrMishen;
                            pori += 1;
                        }
                        else if (pori == 1 && slot2target1 != vybrMishen && slot2target2 != vybrMishen && slot2target3 != vybrMishen)
                        {
                            slot2target2 = vybrMishen;
                            pori = 0;
                        }
                        slot2target3 = null;
                    }
                }
                else
                {
                    thispartisread135 = true;
                }

                specialtarget1 = slot2target1;
                specialtarget2 = slot2target2;
                specialtarget3 = slot2target3;

            }
        }
        if (slot3skill == 40 && thispartisread136 == false)
        {
            if (slot3target1 == null)
            {
                if (movedSkill == skil40)
                {
                    pori = 0;
                    slot3target1 = slotVraga9;
                    slot3target2 = slotVraga8;
                    slot3target3 = null;
                }
                else
                {
                    pori = 0;
                    slot3target1 = slotVraga9;
                    slot3target2 = slotVraga8;
                    slot3target3 = null;
                    thispartisread136 = true;
                }
            }
            else if (slot3target1 != null)
            {
                if (movedSkill == skil40)
                {
                    if (vybrMishen == null)
                    {
                        slot1mishVraga.SetActive(true);
                        slot2mishVraga.SetActive(true);
                        slot3mishVraga.SetActive(true);
                        slot4mishVraga.SetActive(true);
                        slot5mishVraga.SetActive(true);
                        slot6mishVraga.SetActive(true);
                        slot7mishVraga.SetActive(true);
                        slot8mishVraga.SetActive(true);
                        slot9mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        if (pori == 0 && slot3target1 != vybrMishen && slot3target2 != vybrMishen && slot3target3 != vybrMishen)
                        {
                            slot3target1 = vybrMishen;
                            pori += 1;
                        }
                        else if (pori == 1 && slot3target1 != vybrMishen && slot3target2 != vybrMishen && slot3target3 != vybrMishen)
                        {
                            slot3target2 = vybrMishen;
                            pori = 0;
                        }
                        slot3target3 = null;
                    }
                }
                else
                {
                    thispartisread136 = true;
                }

                specialtarget1 = slot3target1;
                specialtarget2 = slot3target2;
                specialtarget3 = slot3target3;

            }
        }
        if (slot7skill == 40 && thispartisread137 == false)
        {
            if (slot7target1 == null)
            {
                if (movedSkill == skil40)
                {
                    pori = 0;
                    slot7target1 = slotVraga9;
                    slot7target2 = slotVraga8;
                    slot7target3 = null;
                }
                else
                {
                    pori = 0;
                    slot7target1 = slotVraga9;
                    slot7target2 = slotVraga8;
                    slot7target3 = null;
                    thispartisread137 = true;
                }
            }
            else if (slot7target1 != null)
            {
                if (movedSkill == skil40)
                {
                    if (vybrMishen == null)
                    {
                        slot1mishVraga.SetActive(true);
                        slot2mishVraga.SetActive(true);
                        slot3mishVraga.SetActive(true);
                        slot4mishVraga.SetActive(true);
                        slot5mishVraga.SetActive(true);
                        slot6mishVraga.SetActive(true);
                        slot7mishVraga.SetActive(true);
                        slot8mishVraga.SetActive(true);
                        slot9mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        if (pori == 0 && slot7target1 != vybrMishen && slot7target2 != vybrMishen && slot7target3 != vybrMishen)
                        {
                            slot7target1 = vybrMishen;
                            pori += 1;
                        }
                        else if (pori == 1 && slot7target1 != vybrMishen && slot7target2 != vybrMishen && slot7target3 != vybrMishen)
                        {
                            slot7target2 = vybrMishen;
                            pori = 0;
                        }
                        slot7target3 = null;
                    }
                }
                else
                {
                    thispartisread137 = true;
                }

                specialtarget1 = slot7target1;
                specialtarget2 = slot7target2;
                specialtarget3 = slot7target3;

            }
        }
        if (slot8skill == 40 && thispartisread138 == false)
        {
            if (slot8target1 == null)
            {
                if (movedSkill == skil40)
                {
                    pori = 0;
                    slot8target1 = slotVraga9;
                    slot8target2 = slotVraga8;
                    slot8target3 = null;
                }
                else
                {
                    pori = 0;
                    slot8target1 = slotVraga9;
                    slot8target2 = slotVraga8;
                    slot8target3 = null;
                    thispartisread138 = true;
                }
            }
            else if (slot8target1 != null)
            {
                if (movedSkill == skil40)
                {
                    if (vybrMishen == null)
                    {
                        slot1mishVraga.SetActive(true);
                        slot2mishVraga.SetActive(true);
                        slot3mishVraga.SetActive(true);
                        slot4mishVraga.SetActive(true);
                        slot5mishVraga.SetActive(true);
                        slot6mishVraga.SetActive(true);
                        slot7mishVraga.SetActive(true);
                        slot8mishVraga.SetActive(true);
                        slot9mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        if (pori == 0 && slot8target1 != vybrMishen && slot8target2 != vybrMishen && slot8target3 != vybrMishen)
                        {
                            slot8target1 = vybrMishen;
                            pori += 1;
                        }
                        else if (pori == 1 && slot8target1 != vybrMishen && slot8target2 != vybrMishen && slot8target3 != vybrMishen)
                        {
                            slot8target2 = vybrMishen;
                            pori = 0;
                        }
                        slot8target3 = null;
                    }
                }
                else
                {
                    thispartisread138 = true;
                }

                specialtarget1 = slot8target1;
                specialtarget2 = slot8target2;
                specialtarget3 = slot8target3;

            }
        }
        if (slot9skill == 40 && thispartisread139 == false)
        {
            if (slot9target1 == null)
            {
                if (movedSkill == skil40)
                {
                    pori = 0;
                    slot9target1 = slotVraga9;
                    slot9target2 = slotVraga8;
                    slot9target3 = null;
                }
                else
                {
                    pori = 0;
                    slot9target1 = slotVraga9;
                    slot9target2 = slotVraga8;
                    slot9target3 = null;
                    thispartisread139 = true;
                }
            }
            else if (slot9target1 != null)
            {
                if (movedSkill == skil40)
                {
                    if (vybrMishen == null)
                    {
                        slot1mishVraga.SetActive(true);
                        slot2mishVraga.SetActive(true);
                        slot3mishVraga.SetActive(true);
                        slot4mishVraga.SetActive(true);
                        slot5mishVraga.SetActive(true);
                        slot6mishVraga.SetActive(true);
                        slot7mishVraga.SetActive(true);
                        slot8mishVraga.SetActive(true);
                        slot9mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        if (pori == 0 && slot9target1 != vybrMishen && slot9target2 != vybrMishen && slot9target3 != vybrMishen)
                        {
                            slot9target1 = vybrMishen;
                            pori += 1;
                        }
                        else if (pori == 1 && slot9target1 != vybrMishen && slot9target2 != vybrMishen && slot9target3 != vybrMishen)
                        {
                            slot9target2 = vybrMishen;
                            pori = 0;
                        }
                        slot9target3 = null;
                    }
                }
                else
                {
                    thispartisread139 = true;
                }

                specialtarget1 = slot9target1;
                specialtarget2 = slot9target2;
                specialtarget3 = slot9target3;

            }
        }
        if (slot4skill == 40 && thispartisread140 == false)
        {
            if (slot4target1 == null)
            {
                if (movedSkill == skil40)
                {
                    pori = 0;
                    slot4target1 = slotVraga9;
                    slot4target2 = slotVraga8;
                    slot4target3 = null;
                }
                else
                {
                    pori = 0;
                    slot4target1 = slotVraga9;
                    slot4target2 = slotVraga8;
                    slot4target3 = null;
                    thispartisread140 = true;
                }
            }
            else if (slot4target1 != null)
            {
                if (movedSkill == skil40)
                {
                    if (vybrMishen == null)
                    {
                        slot1mishVraga.SetActive(true);
                        slot2mishVraga.SetActive(true);
                        slot3mishVraga.SetActive(true);
                        slot4mishVraga.SetActive(true);
                        slot5mishVraga.SetActive(true);
                        slot6mishVraga.SetActive(true);
                        slot7mishVraga.SetActive(true);
                        slot8mishVraga.SetActive(true);
                        slot9mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        if (pori == 0 && slot4target1 != vybrMishen && slot4target2 != vybrMishen && slot4target3 != vybrMishen)
                        {
                            slot4target1 = vybrMishen;
                            pori += 1;
                        }
                        else if (pori == 1 && slot4target1 != vybrMishen && slot4target2 != vybrMishen && slot4target3 != vybrMishen)
                        {
                            slot4target2 = vybrMishen;
                            pori = 0;
                        }
                        slot4target3 = null;
                    }
                }
                else
                {
                    thispartisread140 = true;
                }

                specialtarget1 = slot4target1;
                specialtarget2 = slot4target2;
                specialtarget3 = slot4target3;

            }
        }
        if (slot5skill == 40 && thispartisread141 == false)
        {
            if (slot5target1 == null)
            {
                if (movedSkill == skil40)
                {
                    pori = 0;
                    slot5target1 = slotVraga9;
                    slot5target2 = slotVraga8;
                    slot5target3 = null;
                }
                else
                {
                    pori = 0;
                    slot5target1 = slotVraga9;
                    slot5target2 = slotVraga8;
                    slot5target3 = null;
                    thispartisread141 = true;
                }
            }
            else if (slot5target1 != null)
            {
                if (movedSkill == skil40)
                {
                    if (vybrMishen == null)
                    {
                        slot1mishVraga.SetActive(true);
                        slot2mishVraga.SetActive(true);
                        slot3mishVraga.SetActive(true);
                        slot4mishVraga.SetActive(true);
                        slot5mishVraga.SetActive(true);
                        slot6mishVraga.SetActive(true);
                        slot7mishVraga.SetActive(true);
                        slot8mishVraga.SetActive(true);
                        slot9mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        if (pori == 0 && slot5target1 != vybrMishen && slot5target2 != vybrMishen && slot5target3 != vybrMishen)
                        {
                            slot5target1 = vybrMishen;
                            pori += 1;
                        }
                        else if (pori == 1 && slot5target1 != vybrMishen && slot5target2 != vybrMishen && slot5target3 != vybrMishen)
                        {
                            slot5target2 = vybrMishen;
                            pori = 0;
                        }
                        slot5target3 = null;
                    }
                }
                else
                {
                    thispartisread141 = true;
                }

                specialtarget1 = slot5target1;
                specialtarget2 = slot5target2;
                specialtarget3 = slot5target3;

            }
        }
        if (slot6skill == 40 && thispartisread142 == false)
        {
            if (slot6target1 == null)
            {
                if (movedSkill == skil40)
                {
                    pori = 0;
                    slot6target1 = slotVraga9;
                    slot6target2 = slotVraga8;
                    slot6target3 = null;
                }
                else
                {
                    pori = 0;
                    slot6target1 = slotVraga9;
                    slot6target2 = slotVraga8;
                    slot6target3 = null;
                    thispartisread142 = true;
                }
            }
            else if (slot6target1 != null)
            {
                if (movedSkill == skil40)
                {
                    if (vybrMishen == null)
                    {
                        slot1mishVraga.SetActive(true);
                        slot2mishVraga.SetActive(true);
                        slot3mishVraga.SetActive(true);
                        slot4mishVraga.SetActive(true);
                        slot5mishVraga.SetActive(true);
                        slot6mishVraga.SetActive(true);
                        slot7mishVraga.SetActive(true);
                        slot8mishVraga.SetActive(true);
                        slot9mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        if (pori == 0 && slot6target1 != vybrMishen && slot6target2 != vybrMishen && slot6target3 != vybrMishen)
                        {
                            slot6target1 = vybrMishen;
                            pori += 1;
                        }
                        else if (pori == 1 && slot6target1 != vybrMishen && slot6target2 != vybrMishen && slot6target3 != vybrMishen)
                        {
                            slot6target2 = vybrMishen;
                            pori = 0;
                        }
                        slot6target3 = null;
                    }
                }
                else
                {
                    thispartisread142 = true;
                }

                specialtarget1 = slot6target1;
                specialtarget2 = slot6target2;
                specialtarget3 = slot6target3;

            }
        }
        // 41 скилл
        if (slot4skill == 41 && thispartisread143 == false)
        {
            if (slot4target1 == null)
            {
                if (movedSkill == skil41)
                {

                    slot4target1 = null;
                    slot4target2 = null;
                    slot4target3 = null;
                }
                else
                {

                    slot4target1 = null;
                    slot4target2 = null;
                    slot4target3 = null;
                    thispartisread143 = true;
                }
            }
            else if (slot4target1 != null)
            {
                if (movedSkill == skil41)
                {
                    if (vybrMishen == null)
                    {
                    }
                    else if (vybrMishen != null)
                    {
                    }
                }
                else
                {
                    thispartisread143 = true;
                }

                specialtarget1 = slot4target1;
                specialtarget2 = slot4target2;
                specialtarget3 = slot4target3;

            }
        }
        if (slot6skill == 41 && thispartisread144 == false)
        {
            if (slot6target1 == null)
            {
                if (movedSkill == skil41)
                {

                    slot6target1 = null;
                    slot6target2 = null;
                    slot6target3 = null;
                }
                else
                {

                    slot6target1 = null;
                    slot6target2 = null;
                    slot6target3 = null;
                    thispartisread144 = true;
                }
            }
            else if (slot6target1 != null)
            {
                if (movedSkill == skil41)
                {
                    if (vybrMishen == null)
                    {
                    }
                    else if (vybrMishen != null)
                    {
                    }
                }
                else
                {
                    thispartisread144 = true;
                }

                specialtarget1 = slot6target1;
                specialtarget2 = slot6target2;
                specialtarget3 = slot6target3;

            }
        }
        if (slot7skill == 41 && thispartisread145 == false)
        {
            if (slot7target1 == null)
            {
                if (movedSkill == skil41)
                {

                    slot7target1 = null;
                    slot7target2 = null;
                    slot7target3 = null;
                }
                else
                {

                    slot7target1 = null;
                    slot7target2 = null;
                    slot7target3 = null;
                    thispartisread145 = true;
                }
            }
            else if (slot7target1 != null)
            {
                if (movedSkill == skil41)
                {
                    if (vybrMishen == null)
                    {
                    }
                    else if (vybrMishen != null)
                    {
                    }
                }
                else
                {
                    thispartisread145 = true;
                }

                specialtarget1 = slot7target1;
                specialtarget2 = slot7target2;
                specialtarget3 = slot7target3;

            }
        }
        if (slot8skill == 41 && thispartisread146 == false)
        {
            if (slot8target1 == null)
            {
                if (movedSkill == skil41)
                {

                    slot8target1 = null;
                    slot8target2 = null;
                    slot8target3 = null;
                }
                else
                {

                    slot8target1 = null;
                    slot8target2 = null;
                    slot8target3 = null;
                    thispartisread146 = true;
                }
            }
            else if (slot8target1 != null)
            {
                if (movedSkill == skil41)
                {
                    if (vybrMishen == null)
                    {
                    }
                    else if (vybrMishen != null)
                    {
                    }
                }
                else
                {
                    thispartisread146 = true;
                }

                specialtarget1 = slot8target1;
                specialtarget2 = slot8target2;
                specialtarget3 = slot8target3;

            }
        }
        if (slot9skill == 41 && thispartisread147 == false)
        {
            if (slot9target1 == null)
            {
                if (movedSkill == skil41)
                {

                    slot9target1 = null;
                    slot9target2 = null;
                    slot9target3 = null;
                }
                else
                {

                    slot9target1 = null;
                    slot9target2 = null;
                    slot9target3 = null;
                    thispartisread147 = true;
                }
            }
            else if (slot9target1 != null)
            {
                if (movedSkill == skil41)
                {
                    if (vybrMishen == null)
                    {
                    }
                    else if (vybrMishen != null)
                    {
                    }
                }
                else
                {
                    thispartisread147 = true;
                }

                specialtarget1 = slot9target1;
                specialtarget2 = slot9target2;
                specialtarget3 = slot9target3;

            }
        }
        if (slot2skill == 42 && thispartisread148 == false)
        {
            if (slot2target1 == null)
            {
                if (movedSkill == skil42)
                {

                    slot2target1 = slotGG1;
                    slot2target2 = null;
                    slot2target3 = null;
                }
                else
                {

                    slot2target1 = slotGG1;
                    slot2target2 = null;
                    slot2target3 = null;
                    thispartisread148 = true;
                }
            }
            else if (slot2target1 != null)
            {
                if (movedSkill == skil42)
                {
                    if (vybrMishen == null)
                    {

                        slot1mish.SetActive(true);
                        slot2mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                    }
                }
                else
                {
                    thispartisread148 = true;
                }

                specialtarget1 = slot2target1;
                specialtarget2 = slot2target2;
                specialtarget3 = slot2target3;

            }
        }
        if (slot5skill == 42 && thispartisread149 == false)
        {
            if (slot5target1 == null)
            {
                if (movedSkill == skil42)
                {

                    slot5target1 = slotGG4;
                    slot5target2 = null;
                    slot5target3 = null;
                }
                else
                {

                    slot5target1 = slotGG4;
                    slot5target2 = null;
                    slot5target3 = null;
                    thispartisread149 = true;
                }
            }
            else if (slot5target1 != null)
            {
                if (movedSkill == skil42)
                {
                    if (vybrMishen == null)
                    {

                        slot4mish.SetActive(true);
                        slot5mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                    }
                }
                else
                {
                    thispartisread149 = true;
                }

                specialtarget1 = slot5target1;
                specialtarget2 = slot5target2;
                specialtarget3 = slot5target3;

            }
        }
        if (slot6skill == 42 && thispartisread150 == false)
        {
            if (slot6target1 == null)
            {
                if (movedSkill == skil42)
                {

                    slot6target1 = slotGG5;
                    slot6target2 = null;
                    slot6target3 = null;
                }
                else
                {

                    slot6target1 = slotGG5;
                    slot6target2 = null;
                    slot6target3 = null;
                    thispartisread150 = true;
                }
            }
            else if (slot6target1 != null)
            {
                if (movedSkill == skil42)
                {
                    if (vybrMishen == null)
                    {

                        slot5mish.SetActive(true);
                        slot6mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                    }
                }
                else
                {
                    thispartisread150 = true;
                }

                specialtarget1 = slot6target1;
                specialtarget2 = slot6target2;
                specialtarget3 = slot6target3;

            }
        }
        if (slot8skill == 42 && thispartisread151 == false)
        {
            if (slot8target1 == null)
            {
                if (movedSkill == skil42)
                {

                    slot8target1 = slotGG7;
                    slot8target2 = null;
                    slot8target3 = null;
                }
                else
                {

                    slot8target1 = slotGG7;
                    slot8target2 = null;
                    slot8target3 = null;
                    thispartisread151 = true;
                }
            }
            else if (slot8target1 != null)
            {
                if (movedSkill == skil42)
                {
                    if (vybrMishen == null)
                    {

                        slot7mish.SetActive(true);
                        slot8mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                    }
                }
                else
                {
                    thispartisread151 = true;
                }

                specialtarget1 = slot8target1;
                specialtarget2 = slot8target2;
                specialtarget3 = slot8target3;

            }
        }
        if (slot1skill == 43 && thispartisread152 == false) // если скил 43
        {
            if (slot1target1 == null)
            {
                if (movedSkill == skil43)
                {

                    slot1target1 = slotVraga1;
                    slot1target2 = null;
                    slot1target3 = null;
                }
                else
                {

                    slot1target1 = slotVraga1;
                    slot1target2 = null;
                    slot1target3 = null;
                    thispartisread152 = true;
                }
            }
            else if (slot1target1 != null)
            {
                if (movedSkill == skil43)
                {
                    if (vybrMishen == null)
                    {

                        slot1mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot1target1 = vybrMishen;
                        slot1target2 = null;
                        slot1target3 = null;
                    }
                }
                else
                {
                    thispartisread152 = true;
                }
                specialtarget1 = slot1target1;
                specialtarget2 = slot1target2;
                specialtarget3 = slot1target3;

            }
        }
        if (slot2skill == 43 && thispartisread153 == false) // если скил 3
        {
            if (slot2target1 == null)
            {
                if (movedSkill == skil43)
                {

                    slot2target1 = slotVraga2;
                    slot2target2 = null;
                    slot2target3 = null;
                }
                else
                {

                    slot2target1 = slotVraga2;
                    slot2target2 = null;
                    slot2target3 = null;
                    thispartisread153 = true;
                }
            }
            else if (slot2target1 != null)
            {
                if (movedSkill == skil43)
                {
                    if (vybrMishen == null)
                    {

                        slot2mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot2target1 = vybrMishen;
                        slot2target2 = null;
                        slot2target3 = null;
                    }
                }
                else
                {
                    thispartisread153 = true;
                }
                specialtarget1 = slot2target1;
                specialtarget2 = slot2target2;
                specialtarget3 = slot2target3;

            }
        }
        if (slot3skill == 43 && thispartisread154 == false) // если скил 3
        {
            if (slot3target1 == null)
            {
                if (movedSkill == skil43)
                {

                    slot3target1 = slotVraga3;
                    slot3target2 = null;
                    slot3target3 = null;
                }
                else
                {

                    slot3target1 = slotVraga3;
                    slot3target2 = null;
                    slot3target3 = null;
                    thispartisread154 = true;
                }
            }
            else if (slot3target1 != null)
            {
                if (movedSkill == skil43)
                {
                    if (vybrMishen == null)
                    {

                        slot3mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot3target1 = vybrMishen;
                        slot3target2 = null;
                        slot3target3 = null;
                    }
                }
                else
                {
                    thispartisread154 = true;
                }
                specialtarget1 = slot3target1;
                specialtarget2 = slot3target2;
                specialtarget3 = slot3target3;

            }
        }
        if (slot4skill == 43 && thispartisread155 == false) // если скил 3
        {
            if (slot4target1 == null)
            {
                if (movedSkill == skil43)
                {

                    slot4target1 = slotVraga4;
                    slot4target2 = null;
                    slot4target3 = null;
                }
                else
                {

                    slot4target1 = slotVraga4;
                    slot4target2 = null;
                    slot4target3 = null;
                    thispartisread155 = true;
                }
            }
            else if (slot4target1 != null)
            {
                if (movedSkill == skil43)
                {
                    if (vybrMishen == null)
                    {

                        slot4mishVraga.SetActive(true);
                    }
                    else if (vybrMishen != null)
                    {
                        slot4target1 = vybrMishen;
                        slot4target2 = null;
                        slot4target3 = null;
                    }
                }
                else
                {
                    thispartisread155 = true;
                }
                specialtarget1 = slot4target1;
                specialtarget2 = slot4target2;
                specialtarget3 = slot4target3;

            }
        }


        if (specialtarget1 != null || specialtarget2 != null || specialtarget3 != null)
        {
            demonstrationMisheni();
        }
        zadnicaChekerMishenei();
    }

    public void zadnicaChekerMishenei() // включает аксоны сзади, если слот задействован как мишень гг
    {
        // если хоть для какого-то скилла цель - 1 слот гг
        if (slot1target1 == slotGG1 || slot1target2 == slotGG1 || slot1target3 == slotGG1 || slot2target1 == slotGG1 || slot2target2 == slotGG1 || slot2target3 == slotGG1 || slot3target1 == slotGG1 || slot3target2 == slotGG1 || slot3target3 == slotGG1 || slot4target1 == slotGG1 || slot4target2 == slotGG1 || slot4target3 == slotGG1 || slot5target1 == slotGG1 || slot5target2 == slotGG1 || slot5target3 == slotGG1 || slot6target1 == slotGG1 || slot6target2 == slotGG1 || slot6target3 == slotGG1 || slot7target1 == slotGG1 || slot7target2 == slotGG1 || slot7target3 == slotGG1 || slot8target1 == slotGG1 || slot8target2 == slotGG1 || slot8target3 == slotGG1 || slot9target1 == slotGG1 || slot9target2 == slotGG1 || slot9target3 == slotGG1)
        {
            mishendemonGG1.SetActive(true);
        }
        else
        {
            mishendemonGG1.SetActive(false);
        }
        // если хоть для какого-то скилла цель - 2 слот гг
        if (slot1target1 == slotGG2 || slot1target2 == slotGG2 || slot1target3 == slotGG2 || slot2target1 == slotGG2 || slot2target2 == slotGG2 || slot2target3 == slotGG2 || slot3target1 == slotGG2 || slot3target2 == slotGG2 || slot3target3 == slotGG2 || slot4target1 == slotGG2 || slot4target2 == slotGG2 || slot4target3 == slotGG2 || slot5target1 == slotGG2 || slot5target2 == slotGG2 || slot5target3 == slotGG2 || slot6target1 == slotGG2 || slot6target2 == slotGG2 || slot6target3 == slotGG2 || slot7target1 == slotGG2 || slot7target2 == slotGG2 || slot7target3 == slotGG2 || slot8target1 == slotGG2 || slot8target2 == slotGG2 || slot8target3 == slotGG2 || slot9target1 == slotGG2 || slot9target2 == slotGG2 || slot9target3 == slotGG2)
        {
            mishendemonGG2.SetActive(true);
        }
        else
        {
            mishendemonGG2.SetActive(false);
        }
        // если хоть для какого-то скилла цель - 3 слот гг
        if (slot1target1 == slotGG3 || slot1target2 == slotGG3 || slot1target3 == slotGG3 || slot2target1 == slotGG3 || slot2target2 == slotGG3 || slot2target3 == slotGG3 || slot3target1 == slotGG3 || slot3target2 == slotGG3 || slot3target3 == slotGG3 || slot4target1 == slotGG3 || slot4target2 == slotGG3 || slot4target3 == slotGG3 || slot5target1 == slotGG3 || slot5target2 == slotGG3 || slot5target3 == slotGG3 || slot6target1 == slotGG3 || slot6target2 == slotGG3 || slot6target3 == slotGG3 || slot7target1 == slotGG3 || slot7target2 == slotGG3 || slot7target3 == slotGG3 || slot8target1 == slotGG3 || slot8target2 == slotGG3 || slot8target3 == slotGG3 || slot9target1 == slotGG3 || slot9target2 == slotGG3 || slot9target3 == slotGG3)
        {
            mishendemonGG3.SetActive(true);
        }
        else
        {
            mishendemonGG3.SetActive(false);
        }
        // если хоть для какого-то скилла цель - 4 слот гг
        if (slot1target1 == slotGG4 || slot1target2 == slotGG4 || slot1target3 == slotGG4 || slot2target1 == slotGG4 || slot2target2 == slotGG4 || slot2target3 == slotGG4 || slot3target1 == slotGG4 || slot3target2 == slotGG4 || slot3target3 == slotGG4 || slot4target1 == slotGG4 || slot4target2 == slotGG4 || slot4target3 == slotGG4 || slot5target1 == slotGG4 || slot5target2 == slotGG4 || slot5target3 == slotGG4 || slot6target1 == slotGG4 || slot6target2 == slotGG4 || slot6target3 == slotGG4 || slot7target1 == slotGG4 || slot7target2 == slotGG4 || slot7target3 == slotGG4 || slot8target1 == slotGG4 || slot8target2 == slotGG4 || slot8target3 == slotGG4 || slot9target1 == slotGG4 || slot9target2 == slotGG4 || slot9target3 == slotGG4)
        {
            mishendemonGG4.SetActive(true);
        }
        else
        {
            mishendemonGG4.SetActive(false);
        }
        // если хоть для какого-то скилла цель - 5 слот гг
        if (slot1target1 == slotGG5 || slot1target2 == slotGG5 || slot1target3 == slotGG5 || slot2target1 == slotGG5 || slot2target2 == slotGG5 || slot2target3 == slotGG5 || slot3target1 == slotGG5 || slot3target2 == slotGG5 || slot3target3 == slotGG5 || slot4target1 == slotGG5 || slot4target2 == slotGG5 || slot4target3 == slotGG5 || slot5target1 == slotGG5 || slot5target2 == slotGG5 || slot5target3 == slotGG5 || slot6target1 == slotGG5 || slot6target2 == slotGG5 || slot6target3 == slotGG5 || slot7target1 == slotGG5 || slot7target2 == slotGG5 || slot7target3 == slotGG5 || slot8target1 == slotGG5 || slot8target2 == slotGG5 || slot8target3 == slotGG5 || slot9target1 == slotGG5 || slot9target2 == slotGG5 || slot9target3 == slotGG5)
        {
            mishendemonGG5.SetActive(true);
        }
        else
        {
            mishendemonGG5.SetActive(false);
        }
        // если хоть для какого-то скилла цель - 6 слот гг
        if (slot1target1 == slotGG6 || slot1target2 == slotGG6 || slot1target3 == slotGG6 || slot2target1 == slotGG6 || slot2target2 == slotGG6 || slot2target3 == slotGG6 || slot3target1 == slotGG6 || slot3target2 == slotGG6 || slot3target3 == slotGG6 || slot4target1 == slotGG6 || slot4target2 == slotGG6 || slot4target3 == slotGG6 || slot5target1 == slotGG6 || slot5target2 == slotGG6 || slot5target3 == slotGG6 || slot6target1 == slotGG6 || slot6target2 == slotGG6 || slot6target3 == slotGG6 || slot7target1 == slotGG6 || slot7target2 == slotGG6 || slot7target3 == slotGG6 || slot8target1 == slotGG6 || slot8target2 == slotGG6 || slot8target3 == slotGG6 || slot9target1 == slotGG6 || slot9target2 == slotGG6 || slot9target3 == slotGG6)
        {
            mishendemonGG6.SetActive(true);
        }
        else
        {
            mishendemonGG6.SetActive(false);
        }
        // если хоть для какого-то скилла цель - 7 слот гг
        if (slot1target1 == slotGG7 || slot1target2 == slotGG7 || slot1target3 == slotGG7 || slot2target1 == slotGG7 || slot2target2 == slotGG7 || slot2target3 == slotGG7 || slot3target1 == slotGG7 || slot3target2 == slotGG7 || slot3target3 == slotGG7 || slot4target1 == slotGG7 || slot4target2 == slotGG7 || slot4target3 == slotGG7 || slot5target1 == slotGG7 || slot5target2 == slotGG7 || slot5target3 == slotGG7 || slot6target1 == slotGG7 || slot6target2 == slotGG7 || slot6target3 == slotGG7 || slot7target1 == slotGG7 || slot7target2 == slotGG7 || slot7target3 == slotGG7 || slot8target1 == slotGG7 || slot8target2 == slotGG7 || slot8target3 == slotGG7 || slot9target1 == slotGG7 || slot9target2 == slotGG7 || slot9target3 == slotGG7)
        {
            mishendemonGG7.SetActive(true);
        }
        else
        {
            mishendemonGG7.SetActive(false);
        }
        // если хоть для какого-то скилла цель - 8 слот гг
        if (slot1target1 == slotGG8 || slot1target2 == slotGG8 || slot1target3 == slotGG8 || slot2target1 == slotGG8 || slot2target2 == slotGG8 || slot2target3 == slotGG8 || slot3target1 == slotGG8 || slot3target2 == slotGG8 || slot3target3 == slotGG8 || slot4target1 == slotGG8 || slot4target2 == slotGG8 || slot4target3 == slotGG8 || slot5target1 == slotGG8 || slot5target2 == slotGG8 || slot5target3 == slotGG8 || slot6target1 == slotGG8 || slot6target2 == slotGG8 || slot6target3 == slotGG8 || slot7target1 == slotGG8 || slot7target2 == slotGG8 || slot7target3 == slotGG8 || slot8target1 == slotGG8 || slot8target2 == slotGG8 || slot8target3 == slotGG8 || slot9target1 == slotGG8 || slot9target2 == slotGG8 || slot9target3 == slotGG8)
        {
            mishendemonGG8.SetActive(true);
        }
        else
        {
            mishendemonGG8.SetActive(false);
        }
        // если хоть для какого-то скилла цель - 9 слот гг
        if (slot1target1 == slotGG9 || slot1target2 == slotGG9 || slot1target3 == slotGG9 || slot2target1 == slotGG9 || slot2target2 == slotGG9 || slot2target3 == slotGG9 || slot3target1 == slotGG9 || slot3target2 == slotGG9 || slot3target3 == slotGG9 || slot4target1 == slotGG9 || slot4target2 == slotGG9 || slot4target3 == slotGG9 || slot5target1 == slotGG9 || slot5target2 == slotGG9 || slot5target3 == slotGG9 || slot6target1 == slotGG9 || slot6target2 == slotGG9 || slot6target3 == slotGG9 || slot7target1 == slotGG9 || slot7target2 == slotGG9 || slot7target3 == slotGG9 || slot8target1 == slotGG9 || slot8target2 == slotGG9 || slot8target3 == slotGG9 || slot9target1 == slotGG9 || slot9target2 == slotGG9 || slot9target3 == slotGG9)
        {
            mishendemonGG9.SetActive(true);
        }
        else
        {
            mishendemonGG9.SetActive(false);
        }
        // если хоть для какого-то скилла цель - 1 слот врага
        if (slot1target1 == slotVraga1 || slot1target2 == slotVraga1 || slot1target3 == slotVraga1 || slot2target1 == slotVraga1 || slot2target2 == slotVraga1 || slot2target3 == slotVraga1 || slot3target1 == slotVraga1 || slot3target2 == slotVraga1 || slot3target3 == slotVraga1 || slot4target1 == slotVraga1 || slot4target2 == slotVraga1 || slot4target3 == slotVraga1 || slot5target1 == slotVraga1 || slot5target2 == slotVraga1 || slot5target3 == slotVraga1 || slot6target1 == slotVraga1 || slot6target2 == slotVraga1 || slot6target3 == slotVraga1 || slot7target1 == slotVraga1 || slot7target2 == slotVraga1 || slot7target3 == slotVraga1 || slot8target1 == slotVraga1 || slot8target2 == slotVraga1 || slot8target3 == slotVraga1 || slot9target1 == slotVraga1 || slot9target2 == slotVraga1 || slot9target3 == slotVraga1)
        {
            mishendemonVraga1.SetActive(true);
        }
        else
        {
            mishendemonVraga1.SetActive(false);
        }
        // если хоть для какого-то скилла цель - 2 слот врага
        if (slot1target1 == slotVraga2 || slot1target2 == slotVraga2 || slot1target3 == slotVraga2 || slot2target1 == slotVraga2 || slot2target2 == slotVraga2 || slot2target3 == slotVraga2 || slot3target1 == slotVraga2 || slot3target2 == slotVraga2 || slot3target3 == slotVraga2 || slot4target1 == slotVraga2 || slot4target2 == slotVraga2 || slot4target3 == slotVraga2 || slot5target1 == slotVraga2 || slot5target2 == slotVraga2 || slot5target3 == slotVraga2 || slot6target1 == slotVraga2 || slot6target2 == slotVraga2 || slot6target3 == slotVraga2 || slot7target1 == slotVraga2 || slot7target2 == slotVraga2 || slot7target3 == slotVraga2 || slot8target1 == slotVraga2 || slot8target2 == slotVraga2 || slot8target3 == slotVraga2 || slot9target1 == slotVraga2 || slot9target2 == slotVraga2 || slot9target3 == slotVraga2)
        {
            mishendemonVraga2.SetActive(true);
        }
        else
        {
            mishendemonVraga2.SetActive(false);
        }
        // если хоть для какого-то скилла цель - 3 слот врага
        if (slot1target1 == slotVraga3 || slot1target2 == slotVraga3 || slot1target3 == slotVraga3 || slot2target1 == slotVraga3 || slot2target2 == slotVraga3 || slot2target3 == slotVraga3 || slot3target1 == slotVraga3 || slot3target2 == slotVraga3 || slot3target3 == slotVraga3 || slot4target1 == slotVraga3 || slot4target2 == slotVraga3 || slot4target3 == slotVraga3 || slot5target1 == slotVraga3 || slot5target2 == slotVraga3 || slot5target3 == slotVraga3 || slot6target1 == slotVraga3 || slot6target2 == slotVraga3 || slot6target3 == slotVraga3 || slot7target1 == slotVraga3 || slot7target2 == slotVraga3 || slot7target3 == slotVraga3 || slot8target1 == slotVraga3 || slot8target2 == slotVraga3 || slot8target3 == slotVraga3 || slot9target1 == slotVraga3 || slot9target2 == slotVraga3 || slot9target3 == slotVraga3)
        {
            mishendemonVraga3.SetActive(true);
        }
        else
        {
            mishendemonVraga3.SetActive(false);
        }
        // если хоть для какого-то скилла цель - 4 слот врага
        if (slot1target1 == slotVraga4 || slot1target2 == slotVraga4 || slot1target3 == slotVraga4 || slot2target1 == slotVraga4 || slot2target2 == slotVraga4 || slot2target3 == slotVraga4 || slot3target1 == slotVraga4 || slot3target2 == slotVraga4 || slot3target3 == slotVraga4 || slot4target1 == slotVraga4 || slot4target2 == slotVraga4 || slot4target3 == slotVraga4 || slot5target1 == slotVraga4 || slot5target2 == slotVraga4 || slot5target3 == slotVraga4 || slot6target1 == slotVraga4 || slot6target2 == slotVraga4 || slot6target3 == slotVraga4 || slot7target1 == slotVraga4 || slot7target2 == slotVraga4 || slot7target3 == slotVraga4 || slot8target1 == slotVraga4 || slot8target2 == slotVraga4 || slot8target3 == slotVraga4 || slot9target1 == slotVraga4 || slot9target2 == slotVraga4 || slot9target3 == slotVraga4)
        {
            mishendemonVraga4.SetActive(true);
        }
        else
        {
            mishendemonVraga4.SetActive(false);
        }
        // если хоть для какого-то скилла цель - 5 слот врага
        if (slot1target1 == slotVraga5 || slot1target2 == slotVraga5 || slot1target3 == slotVraga5 || slot2target1 == slotVraga5 || slot2target2 == slotVraga5 || slot2target3 == slotVraga5 || slot3target1 == slotVraga5 || slot3target2 == slotVraga5 || slot3target3 == slotVraga5 || slot4target1 == slotVraga5 || slot4target2 == slotVraga5 || slot4target3 == slotVraga5 || slot5target1 == slotVraga5 || slot5target2 == slotVraga5 || slot5target3 == slotVraga5 || slot6target1 == slotVraga5 || slot6target2 == slotVraga5 || slot6target3 == slotVraga5 || slot7target1 == slotVraga5 || slot7target2 == slotVraga5 || slot7target3 == slotVraga5 || slot8target1 == slotVraga5 || slot8target2 == slotVraga5 || slot8target3 == slotVraga5 || slot9target1 == slotVraga5 || slot9target2 == slotVraga5 || slot9target3 == slotVraga5)
        {
            mishendemonVraga5.SetActive(true);
        }
        else
        {
            mishendemonVraga5.SetActive(false);
        }
        // если хоть для какого-то скилла цель - 6 слот врага
        if (slot1target1 == slotVraga6 || slot1target2 == slotVraga6 || slot1target3 == slotVraga6 || slot2target1 == slotVraga6 || slot2target2 == slotVraga6 || slot2target3 == slotVraga6 || slot3target1 == slotVraga6 || slot3target2 == slotVraga6 || slot3target3 == slotVraga6 || slot4target1 == slotVraga6 || slot4target2 == slotVraga6 || slot4target3 == slotVraga6 || slot5target1 == slotVraga6 || slot5target2 == slotVraga6 || slot5target3 == slotVraga6 || slot6target1 == slotVraga6 || slot6target2 == slotVraga6 || slot6target3 == slotVraga6 || slot7target1 == slotVraga6 || slot7target2 == slotVraga6 || slot7target3 == slotVraga6 || slot8target1 == slotVraga6 || slot8target2 == slotVraga6 || slot8target3 == slotVraga6 || slot9target1 == slotVraga6 || slot9target2 == slotVraga6 || slot9target3 == slotVraga6)
        {
            mishendemonVraga6.SetActive(true);
        }
        else
        {
            mishendemonVraga6.SetActive(false);
        }
        // если хоть для какого-то скилла цель - 7 слот врага
        if (slot1target1 == slotVraga7 || slot1target2 == slotVraga7 || slot1target3 == slotVraga7 || slot2target1 == slotVraga7 || slot2target2 == slotVraga7 || slot2target3 == slotVraga7 || slot3target1 == slotVraga7 || slot3target2 == slotVraga7 || slot3target3 == slotVraga7 || slot4target1 == slotVraga7 || slot4target2 == slotVraga7 || slot4target3 == slotVraga7 || slot5target1 == slotVraga7 || slot5target2 == slotVraga7 || slot5target3 == slotVraga7 || slot6target1 == slotVraga7 || slot6target2 == slotVraga7 || slot6target3 == slotVraga7 || slot7target1 == slotVraga7 || slot7target2 == slotVraga7 || slot7target3 == slotVraga7 || slot8target1 == slotVraga7 || slot8target2 == slotVraga7 || slot8target3 == slotVraga7 || slot9target1 == slotVraga7 || slot9target2 == slotVraga7 || slot9target3 == slotVraga7)
        {
            mishendemonVraga7.SetActive(true);
        }
        else
        {
            mishendemonVraga7.SetActive(false);
        }
        // если хоть для какого-то скилла цель - 8 слот врага
        if (slot1target1 == slotVraga8 || slot1target2 == slotVraga8 || slot1target3 == slotVraga8 || slot2target1 == slotVraga8 || slot2target2 == slotVraga8 || slot2target3 == slotVraga8 || slot3target1 == slotVraga8 || slot3target2 == slotVraga8 || slot3target3 == slotVraga8 || slot4target1 == slotVraga8 || slot4target2 == slotVraga8 || slot4target3 == slotVraga8 || slot5target1 == slotVraga8 || slot5target2 == slotVraga8 || slot5target3 == slotVraga8 || slot6target1 == slotVraga8 || slot6target2 == slotVraga8 || slot6target3 == slotVraga8 || slot7target1 == slotVraga8 || slot7target2 == slotVraga8 || slot7target3 == slotVraga8 || slot8target1 == slotVraga8 || slot8target2 == slotVraga8 || slot8target3 == slotVraga8 || slot9target1 == slotVraga8 || slot9target2 == slotVraga8 || slot9target3 == slotVraga8)
        {
            mishendemonVraga8.SetActive(true);
        }
        else
        {
            mishendemonVraga8.SetActive(false);
        }
        // если хоть для какого-то скилла цель - 9 слот врага
        if (slot1target1 == slotVraga9 || slot1target2 == slotVraga9 || slot1target3 == slotVraga9 || slot2target1 == slotVraga9 || slot2target2 == slotVraga9 || slot2target3 == slotVraga9 || slot3target1 == slotVraga9 || slot3target2 == slotVraga9 || slot3target3 == slotVraga9 || slot4target1 == slotVraga9 || slot4target2 == slotVraga9 || slot4target3 == slotVraga9 || slot5target1 == slotVraga9 || slot5target2 == slotVraga9 || slot5target3 == slotVraga9 || slot6target1 == slotVraga9 || slot6target2 == slotVraga9 || slot6target3 == slotVraga9 || slot7target1 == slotVraga9 || slot7target2 == slotVraga9 || slot7target3 == slotVraga9 || slot8target1 == slotVraga9 || slot8target2 == slotVraga9 || slot8target3 == slotVraga9 || slot9target1 == slotVraga9 || slot9target2 == slotVraga9 || slot9target3 == slotVraga9)
        {
            mishendemonVraga9.SetActive(true);
        }
        else
        {
            mishendemonVraga9.SetActive(false);
        }
    }

    public void demonstrationMisheni() // показываем текущие выбранные слоты на поле,
    {
        // отключает все таргеты (может только те, которых нет, а то мигать будет)
        // если хоть одним таргетом выбран слот
        if (specialtarget1 != null || specialtarget2 != null || specialtarget3 != null)
        {
            if (specialtarget1 == slotGG1 || specialtarget2 == slotGG1 || specialtarget3 == slotGG1) // если слот гг 1 - одна из трёх мишеней
            {
                slot1mishfull.SetActive(true);
            }
            if (specialtarget1 == slotGG2 || specialtarget2 == slotGG2 || specialtarget3 == slotGG2) // если слот гг 2 в мишенях
            {
                slot2mishfull.SetActive(true);
            }
            if (specialtarget1 == slotGG3 || specialtarget2 == slotGG3 || specialtarget3 == slotGG3) // если слот гг 3 в мишенях
            {
                slot3mishfull.SetActive(true);
            }
            if (specialtarget1 == slotGG4 || specialtarget2 == slotGG4 || specialtarget3 == slotGG4) // если слот гг 4 в мишенях
            {
                slot4mishfull.SetActive(true);
            }
            if (specialtarget1 == slotGG5 || specialtarget2 == slotGG5 || specialtarget3 == slotGG5) // если слот гг 5 в мишенях
            {
                slot5mishfull.SetActive(true);
            }
            if (specialtarget1 == slotGG6 || specialtarget2 == slotGG6 || specialtarget3 == slotGG6) // если слот гг 6 в мишенях
            {
                slot6mishfull.SetActive(true);
            }

            if (specialtarget1 == slotGG7 || specialtarget2 == slotGG7 || specialtarget3 == slotGG7) // если слот гг 7 в мишенях
            {
                slot7mishfull.SetActive(true);
            }

            if (specialtarget1 == slotGG8 || specialtarget2 == slotGG8 || specialtarget3 == slotGG8) // если слот гг 8 в мишенях
            {
                slot8mishfull.SetActive(true);
            }

            if (specialtarget1 == slotGG9 || specialtarget2 == slotGG9 || specialtarget3 == slotGG9) // если слот гг 9 в мишенях
            {
                slot9mishfull.SetActive(true);
            }

            if (specialtarget1 == slotVraga1 || specialtarget2 == slotVraga1 || specialtarget3 == slotVraga1) // если слот гг 1 - одна из трёх мишеней
            {
                slot1mishVragafull.SetActive(true);
            }

            if (specialtarget1 == slotVraga2 || specialtarget2 == slotVraga2 || specialtarget3 == slotVraga2) // если слот гг 2 в мишенях
            {
                slot2mishVragafull.SetActive(true);
            }

            if (specialtarget1 == slotVraga3 || specialtarget2 == slotVraga3 || specialtarget3 == slotVraga3) // если слот гг 3 в мишенях
            {
                slot3mishVragafull.SetActive(true);
            }

            if (specialtarget1 == slotVraga4 || specialtarget2 == slotVraga4 || specialtarget3 == slotVraga4) // если слот гг 4 в мишенях
            {
                slot4mishVragafull.SetActive(true);
            }

            if (specialtarget1 == slotVraga5 || specialtarget2 == slotVraga5 || specialtarget3 == slotVraga5) // если слот гг 5 в мишенях
            {
                slot5mishVragafull.SetActive(true);
            }
            if (specialtarget1 == slotVraga6 || specialtarget2 == slotVraga6 || specialtarget3 == slotVraga6) // если слот гг 6 в мишенях
            {
                slot6mishVragafull.SetActive(true);
            }
            if (specialtarget1 == slotVraga7 || specialtarget2 == slotVraga7 || specialtarget3 == slotVraga7) // если слот гг 7 в мишенях
            {
                slot7mishVragafull.SetActive(true);
            }
            if (specialtarget1 == slotVraga8 || specialtarget2 == slotVraga8 || specialtarget3 == slotVraga8) // если слот гг 8 в мишенях
            {
                slot8mishVragafull.SetActive(true);
            }
            if (specialtarget1 == slotVraga9 || specialtarget2 == slotVraga9 || specialtarget3 == slotVraga9) // если слот гг 9 в мишенях
            {
                slot9mishVragafull.SetActive(true);
            }

            // отключения только на скиллах с выбором
            if (movedSkill == skil5 || movedSkill == skil12 || movedSkill == skil13 || movedSkill == skil14 || movedSkill == skil16 || movedSkill == skil17 || movedSkill == skil19 || movedSkill == skil26 || movedSkill == skil25 || movedSkill == skil27 || movedSkill == skil31 || movedSkill == skil32 || movedSkill == skil33 || movedSkill == skil34 || movedSkill == skil35 || movedSkill == skil37 || movedSkill == skil38 || movedSkill == skil39 || movedSkill == skil40)
            {
                if (specialtarget1 != slotVraga8 && specialtarget2 != slotVraga8 && specialtarget3 != slotVraga8)
                {
                    slot8mishVragafull.SetActive(false);
                }
                if (specialtarget1 != slotVraga9 && specialtarget2 != slotVraga9 && specialtarget3 != slotVraga9)
                {
                    slot9mishVragafull.SetActive(false);
                }
                if (specialtarget1 != slotGG1 && specialtarget2 != slotGG1 && specialtarget3 != slotGG1)
                {
                    slot1mishfull.SetActive(false);
                }
                if (specialtarget1 != slotVraga7 && specialtarget2 != slotVraga7 && specialtarget3 != slotVraga7)
                {
                    slot7mishVragafull.SetActive(false);
                }
                if (specialtarget1 != slotVraga6 && specialtarget2 != slotVraga6 && specialtarget3 != slotVraga6)
                {
                    slot6mishVragafull.SetActive(false);
                }
                if (specialtarget1 != slotVraga5 && specialtarget2 != slotVraga5 && specialtarget3 != slotVraga5)
                {
                    slot5mishVragafull.SetActive(false);
                }
                if (specialtarget1 != slotVraga4 && specialtarget2 != slotVraga4 && specialtarget3 != slotVraga4)
                {
                    slot4mishVragafull.SetActive(false);
                }
                if (specialtarget1 != slotVraga3 && specialtarget2 != slotVraga3 && specialtarget3 != slotVraga3)
                {
                    slot3mishVragafull.SetActive(false);
                }
                if (specialtarget1 != slotGG2 && specialtarget2 != slotGG2 && specialtarget3 != slotGG2)
                {
                    slot2mishfull.SetActive(false);
                }
                if (specialtarget1 != slotGG3 && specialtarget2 != slotGG3 && specialtarget3 != slotGG3)
                {
                    slot3mishfull.SetActive(false);
                }
                if (specialtarget1 != slotGG4 && specialtarget2 != slotGG4 && specialtarget3 != slotGG4)
                {
                    slot4mishfull.SetActive(false);
                }
                if (specialtarget1 != slotGG5 && specialtarget2 != slotGG5 && specialtarget3 != slotGG5)
                {
                    slot5mishfull.SetActive(false);
                }
                if (specialtarget1 != slotGG6 && specialtarget2 != slotGG6 && specialtarget3 != slotGG6)
                {
                    slot6mishfull.SetActive(false);
                }
                if (specialtarget1 != slotGG7 && specialtarget2 != slotGG7 && specialtarget3 != slotGG7)
                {
                    slot7mishfull.SetActive(false);
                }
                if (specialtarget1 != slotGG8 && specialtarget2 != slotGG8 && specialtarget3 != slotGG8)
                {
                    slot8mishfull.SetActive(false);
                }
                if (specialtarget1 != slotGG9 && specialtarget2 != slotGG9 && specialtarget3 != slotGG9)
                {
                    slot9mishfull.SetActive(false);
                }
                if (specialtarget1 != slotVraga1 && specialtarget2 != slotVraga1 && specialtarget3 != slotVraga1)
                {
                    slot1mishVragafull.SetActive(false);
                }
                if (specialtarget1 != slotVraga2 && specialtarget2 != slotVraga2 && specialtarget3 != slotVraga2)
                {
                    slot2mishVragafull.SetActive(false);
                }
            }
        }

    }

    public void MishenCaller()
    {

        if (movedSkill != null && movedSkill.transform.parent == parentofParentofparentPole) // если в одном из слотов, то успокоится
        {
            specialChildforBack.SetActive(true);
            mishenHolder.SetActive(true);
            mishenHolderVraga.SetActive(true);
            doneOnce = true;
        }
        // если другой родитель, тоже успокоится
        // также тут обнуляются все буллы для прочтения новых мишеней
        thispartisread = false;
        thispartisread1 = false;
        thispartisread2 = false;
        thispartisread3 = false;
        thispartisread4 = false;
        thispartisread5 = false;
        thispartisread6 = false;
        thispartisread7 = false;
        thispartisread8 = false;
        thispartisread9 = false;
        thispartisread10 = false;
        thispartisread11 = false;
        thispartisread12 = false;
        thispartisread13 = false;
        thispartisread14 = false;
        thispartisread15 = false;
        thispartisread16 = false;
        thispartisread17 = false;
        thispartisread18 = false;
        thispartisread19 = false;
        thispartisread20 = false;
        thispartisread21 = false;
        thispartisread26 = false;
        thispartisread27 = false;
        thispartisread28 = false;
        thispartisread29 = false;
        thispartisread30 = false;
        thispartisread31 = false;
        thispartisread32 = false;
        thispartisread33 = false;
        thispartisread34 = false;
        thispartisread35 = false;
        thispartisread36 = false;
        thispartisread37 = false;
        thispartisread38 = false;
        thispartisread39 = false;
        thispartisread40 = false;
        thispartisread41 = false;
        thispartisread42 = false;
        thispartisread44 = false;
        thispartisread45 = false;
        thispartisread46 = false;
        thispartisread47 = false;
        thispartisread48 = false;
        thispartisread49 = false;
        thispartisread50 = false;
        thispartisread51 = false;
        thispartisread52 = false;
        thispartisread53 = false;
        thispartisread54 = false;
        thispartisread55 = false;
        thispartisread56 = false;
        thispartisread57 = false;
        thispartisread58 = false;
        thispartisread59 = false;
        thispartisread60 = false;
        thispartisread61 = false;
        thispartisread62 = false;
        thispartisread63 = false;
        thispartisread64 = false;
        thispartisread65 = false;
        thispartisread66 = false;
        thispartisread67 = false;
        thispartisread68 = false;
        thispartisread69 = false;
        thispartisread70 = false;
        thispartisread71 = false;
        thispartisread72 = false;
        thispartisread73 = false;
        thispartisread74 = false;
        thispartisread75 = false;
        thispartisread76 = false;
        thispartisread77 = false;
        thispartisread78 = false;
        thispartisread79 = false;
        thispartisread80 = false;
        thispartisread81 = false;
        thispartisread82 = false;
        thispartisread83 = false;
        thispartisread84 = false;
        thispartisread85 = false;
        thispartisread86 = false;
        thispartisread87 = false;
        thispartisread88 = false;
        thispartisread89 = false;
        thispartisread90 = false;
        thispartisread91 = false;
        thispartisread92 = false;
        thispartisread93 = false;
        thispartisread94 = false;
        thispartisread95 = false;
        thispartisread96 = false;
        thispartisread97 = false;
        thispartisread98 = false;
        thispartisread99 = false;
        thispartisread100 = false;
        thispartisread101 = false;
        thispartisread102 = false;
        thispartisread103 = false;
        thispartisread104 = false;
        thispartisread105 = false;
        thispartisread106 = false;
        thispartisread107 = false;
        thispartisread108 = false;
        thispartisread109 = false;
        thispartisread110 = false;
        thispartisread111 = false;
        thispartisread112 = false;
        thispartisread113 = false;
        thispartisread114 = false;
        thispartisread115 = false;
        thispartisread116 = false;
        thispartisread117 = false;
        thispartisread118 = false;
        thispartisread119 = false;
        thispartisread120 = false;
        thispartisread121 = false;
        thispartisread122 = false;
        thispartisread123 = false;
        thispartisread124 = false;
        thispartisread125 = false;
        thispartisread126 = false;
        thispartisread127 = false;
        thispartisread128 = false;
        thispartisread129 = false;
        thispartisread130 = false;
        thispartisread131 = false;
        thispartisread132 = false;
        thispartisread133 = false;
        thispartisread134 = false;
        thispartisread135 = false;
        thispartisread136 = false;
        thispartisread137 = false;
        thispartisread138 = false;
        thispartisread139 = false;
        thispartisread140 = false;
        thispartisread141 = false;
        thispartisread142 = false;
        thispartisread143 = false;
        thispartisread144 = false;
        thispartisread145 = false;
        thispartisread146 = false;
        thispartisread147 = false;
        thispartisread148 = false;
        thispartisread149 = false;
        thispartisread150 = false;
        thispartisread151 = false;
        thispartisread152 = false;
        thispartisread153 = false;
        thispartisread154 = false;
        thispartisread155 = false;

    }

    public void MishenOff()
    {
        if (mishenHolder.activeSelf == true)
        {
            // + функция, убирающая все мишени и мишенный режим
            mishenHolder.SetActive(false);
            mishenHolderVraga.SetActive(false);
        }
        // доступные мишени
        if (mishenHolder.activeSelf == false)
        {
            slot1mish.SetActive(false);
            slot2mish.SetActive(false);
            slot3mish.SetActive(false);
            slot4mish.SetActive(false);
            slot5mish.SetActive(false);
            slot6mish.SetActive(false);
            slot7mish.SetActive(false);
            slot8mish.SetActive(false);
            slot9mish.SetActive(false);
            slot1mishVraga.SetActive(false);
            slot2mishVraga.SetActive(false);
            slot3mishVraga.SetActive(false);
            slot4mishVraga.SetActive(false);
            slot5mishVraga.SetActive(false);
            slot6mishVraga.SetActive(false);
            slot7mishVraga.SetActive(false);
            slot8mishVraga.SetActive(false);
            slot9mishVraga.SetActive(false);
            // выбранные мишени
            slot1mishfull.SetActive(false);
            slot2mishfull.SetActive(false);
            slot3mishfull.SetActive(false);
            slot4mishfull.SetActive(false);
            slot5mishfull.SetActive(false);
            slot6mishfull.SetActive(false);
            slot7mishfull.SetActive(false);
            slot8mishfull.SetActive(false);
            slot9mishfull.SetActive(false);
            slot1mishVragafull.SetActive(false);
            slot2mishVragafull.SetActive(false);
            slot3mishVragafull.SetActive(false);
            slot4mishVragafull.SetActive(false);
            slot5mishVragafull.SetActive(false);
            slot6mishVragafull.SetActive(false);
            slot7mishVragafull.SetActive(false);
            slot8mishVragafull.SetActive(false);
            slot9mishVragafull.SetActive(false);
        }
        specialChildforBack.SetActive(false);
    }

    public void SlotZapolnitelComparison()
    {
        slot1skillCompare = slot1skill;
        slot2skillCompare = slot2skill;
        slot3skillCompare = slot3skill;
        slot4skillCompare = slot4skill;
        slot5skillCompare = slot5skill;
        slot6skillCompare = slot6skill;
        slot7skillCompare = slot7skill;
        slot8skillCompare = slot8skill;
        slot9skillCompare = slot9skill;
    }

    public void SlotZapolnitel()
    {
        // функция, где мы обновляем, присваиваем каждому слоту гг его скилл (слот1скилл = флоат) для чтения в бою (по трансформ позициям)


        if (skil1.transform.position == podsvetTrigger1.transform.position)
        {
            slot1skill = 1;
        }
        else if (skil2.transform.position == podsvetTrigger1.transform.position)
        {
            slot1skill = 2;
        }
        else if (skil3.transform.position == podsvetTrigger1.transform.position)
        {
            slot1skill = 3;
        }
        else if (skil4.transform.position == podsvetTrigger1.transform.position)
        {
            slot1skill = 4;
        }
        else if (skil5.transform.position == podsvetTrigger1.transform.position)
        {
            slot1skill = 5;
        }
        else if (skil6.transform.position == podsvetTrigger1.transform.position)
        {
            slot1skill = 6;
        }
        else if (skil8.transform.position == podsvetTrigger1.transform.position)
        {
            slot1skill = 8;
        }
        else if (skil9.transform.position == podsvetTrigger1.transform.position)
        {
            slot1skill = 9;
        }
        else if (skil10 != null && skil10.transform.position == podsvetTrigger1.transform.position)
        {
            slot1skill = 10;
        }
        else if (skil11 != null && skil11.transform.position == podsvetTrigger1.transform.position)
        {
            slot1skill = 11;
        }
        else if (skil12 != null && skil12.transform.position == podsvetTrigger1.transform.position)
        {
            slot1skill = 12;
        }
        else if (skil13 != null && skil13.transform.position == podsvetTrigger1.transform.position)
        {
            slot1skill = 13;
        }
        else if (skil14 != null && skil14.transform.position == podsvetTrigger1.transform.position)
        {
            slot1skill = 14;
        }
        else if (skil15 != null && skil15.transform.position == podsvetTrigger1.transform.position)
        {
            slot1skill = 15;
        }
        else if (skil16.transform.position == podsvetTrigger1.transform.position)
        {
            slot1skill = 16;
        }
        else if (skil17.transform.position == podsvetTrigger1.transform.position)
        {
            slot1skill = 17;
        }
        else if (skil18.transform.position == podsvetTrigger1.transform.position)
        {
            slot1skill = 18;
        }
        else if (skil19.transform.position == podsvetTrigger1.transform.position)
        {
            slot1skill = 19;
        }
        else if (skil20.transform.position == podsvetTrigger1.transform.position)
        {
            slot1skill = 20;
        }
        else if (skil21.transform.position == podsvetTrigger1.transform.position)
        {
            slot1skill = 21;
        }
        else if (skil22.transform.position == podsvetTrigger1.transform.position)
        {
            slot1skill = 22;
        }
        else if (skil23.transform.position == podsvetTrigger1.transform.position)
        {
            slot1skill = 23;
        }
        else if (skil24.transform.position == podsvetTrigger1.transform.position)
        {
            slot1skill = 24;
        }
        else if (skil25.transform.position == podsvetTrigger1.transform.position)
        {
            slot1skill = 25;
        }
        else if (skil26.transform.position == podsvetTrigger1.transform.position)
        {
            slot1skill = 26;
        }
        else if (skil27.transform.position == podsvetTrigger1.transform.position)
        {
            slot1skill = 27;
        }
        else if (skil28.transform.position == podsvetTrigger1.transform.position)
        {
            slot1skill = 28;
        }
        else if (skil29.transform.position == podsvetTrigger1.transform.position)
        {
            slot1skill = 29;
        }
        else if (skil30.transform.position == podsvetTrigger1.transform.position)
        {
            slot1skill = 30;
        }
        else if (skil31.transform.position == podsvetTrigger1.transform.position)
        {
            slot1skill = 31;
        }
        else if (skil32.transform.position == podsvetTrigger1.transform.position)
        {
            slot1skill = 32;
        }
        else if (skil33.transform.position == podsvetTrigger1.transform.position)
        {
            slot1skill = 33;
        }
        else if (skil34.transform.position == podsvetTrigger1.transform.position)
        {
            slot1skill = 34;
        }
        else if (skil35.transform.position == podsvetTrigger1.transform.position)
        {
            slot1skill = 35;
        }
        else if (skil36.transform.position == podsvetTrigger1.transform.position)
        {
            slot1skill = 36;
        }
        else if (skil37.transform.position == podsvetTrigger1.transform.position)
        {
            slot1skill = 37;
        }
        else if (skil38.transform.position == podsvetTrigger1.transform.position)
        {
            slot1skill = 38;
        }
        else if (skil39.transform.position == podsvetTrigger1.transform.position)
        {
            slot1skill = 39;
        }
        else if (skil40.transform.position == podsvetTrigger1.transform.position)
        {
            slot1skill = 40;
        }
        else if (skil41.transform.position == podsvetTrigger1.transform.position)
        {
            slot1skill = 41;
        }
        else if (skil42.transform.position == podsvetTrigger1.transform.position)
        {
            slot1skill = 42;
        }
        else if (skil43.transform.position == podsvetTrigger1.transform.position)
        {
            slot1skill = 43;
        }

        else
        {
            slot1skill = 0;
            slot1target1 = null;
            slot1target2 = null;
            slot1target3 = null;
        }


        if (skil1.transform.position == podsvetTrigger2.transform.position)
        {
            slot2skill = 1;
        }
        else if (skil2.transform.position == podsvetTrigger2.transform.position)
        {
            slot2skill = 2;
        }
        else if (skil3.transform.position == podsvetTrigger2.transform.position)
        {
            slot2skill = 3;
        }
        else if (skil4.transform.position == podsvetTrigger2.transform.position)
        {
            slot2skill = 4;
        }
        else if (skil5.transform.position == podsvetTrigger2.transform.position)
        {
            slot2skill = 5;
        }
        else if (skil6.transform.position == podsvetTrigger2.transform.position)
        {
            slot2skill = 6;
        }
        else if (skil8.transform.position == podsvetTrigger2.transform.position)
        {
            slot2skill = 8;
        }
        else if (skil9.transform.position == podsvetTrigger2.transform.position)
        {
            slot2skill = 9;
        }
        else if (skil10 != null && skil10.transform.position == podsvetTrigger2.transform.position)
        {
            slot2skill = 10;
        }
        else if (skil11 != null && skil11.transform.position == podsvetTrigger2.transform.position)
        {
            slot2skill = 11;
        }
        else if (skil12 != null && skil12.transform.position == podsvetTrigger2.transform.position)
        {
            slot2skill = 12;
        }
        else if (skil13 != null && skil13.transform.position == podsvetTrigger2.transform.position)
        {
            slot2skill = 13;
        }
        else if (skil14 != null && skil14.transform.position == podsvetTrigger2.transform.position)
        {
            slot2skill = 14;
        }
        else if (skil15 != null && skil15.transform.position == podsvetTrigger2.transform.position)
        {
            slot2skill = 15;
        }
        else if (skil16.transform.position == podsvetTrigger2.transform.position)
        {
            slot2skill = 16;
        }
        else if (skil17.transform.position == podsvetTrigger2.transform.position)
        {
            slot2skill = 17;
        }
        else if (skil18.transform.position == podsvetTrigger2.transform.position)
        {
            slot2skill = 18;
        }
        else if (skil19.transform.position == podsvetTrigger2.transform.position)
        {
            slot2skill = 19;
        }
        else if (skil20.transform.position == podsvetTrigger2.transform.position)
        {
            slot2skill = 20;
        }
        else if (skil21.transform.position == podsvetTrigger2.transform.position)
        {
            slot2skill = 21;
        }
        else if (skil22.transform.position == podsvetTrigger2.transform.position)
        {
            slot2skill = 22;
        }
        else if (skil23.transform.position == podsvetTrigger2.transform.position)
        {
            slot2skill = 23;
        }
        else if (skil24.transform.position == podsvetTrigger2.transform.position)
        {
            slot2skill = 24;
        }
        else if (skil25.transform.position == podsvetTrigger2.transform.position)
        {
            slot2skill = 25;
        }
        else if (skil26.transform.position == podsvetTrigger2.transform.position)
        {
            slot2skill = 26;
        }
        else if (skil27.transform.position == podsvetTrigger2.transform.position)
        {
            slot2skill = 27;
        }
        else if (skil28.transform.position == podsvetTrigger2.transform.position)
        {
            slot2skill = 28;
        }
        else if (skil29.transform.position == podsvetTrigger2.transform.position)
        {
            slot2skill = 29;
        }
        else if (skil30.transform.position == podsvetTrigger2.transform.position)
        {
            slot2skill = 30;
        }
        else if (skil31.transform.position == podsvetTrigger2.transform.position)
        {
            slot2skill = 31;
        }
        else if (skil32.transform.position == podsvetTrigger2.transform.position)
        {
            slot2skill = 32;
        }
        else if (skil33.transform.position == podsvetTrigger2.transform.position)
        {
            slot2skill = 33;
        }
        else if (skil34.transform.position == podsvetTrigger2.transform.position)
        {
            slot2skill = 34;
        }
        else if (skil35.transform.position == podsvetTrigger2.transform.position)
        {
            slot2skill = 35;
        }
        else if (skil36.transform.position == podsvetTrigger2.transform.position)
        {
            slot2skill = 36;
        }
        else if (skil37.transform.position == podsvetTrigger2.transform.position)
        {
            slot2skill = 37;
        }
        else if (skil38.transform.position == podsvetTrigger2.transform.position)
        {
            slot2skill = 38;
        }
        else if (skil39.transform.position == podsvetTrigger2.transform.position)
        {
            slot2skill = 39;
        }
        else if (skil40.transform.position == podsvetTrigger2.transform.position)
        {
            slot2skill = 40;
        }
        else if (skil41.transform.position == podsvetTrigger2.transform.position)
        {
            slot2skill = 41;
        }
        else if (skil42.transform.position == podsvetTrigger2.transform.position)
        {
            slot2skill = 42;
        }
        else if (skil43.transform.position == podsvetTrigger2.transform.position)
        {
            slot2skill = 43;
        }



        else
        {
            slot2skill = 0;
            slot2target1 = null;
            slot2target2 = null;
            slot2target3 = null;
        }

        if (skil1.transform.position == podsvetTrigger3.transform.position)
        {
            slot3skill = 1;
        }
        else if (skil2.transform.position == podsvetTrigger3.transform.position)
        {
            slot3skill = 2;
        }
        else if (skil3.transform.position == podsvetTrigger3.transform.position)
        {
            slot3skill = 3;
        }
        else if (skil4.transform.position == podsvetTrigger3.transform.position)
        {
            slot3skill = 4;
        }
        else if (skil5.transform.position == podsvetTrigger3.transform.position)
        {
            slot3skill = 5;
        }
        else if (skil6.transform.position == podsvetTrigger3.transform.position)
        {
            slot3skill = 6;
        }
        else if (skil8.transform.position == podsvetTrigger3.transform.position)
        {
            slot3skill = 8;
        }
        else if (skil9.transform.position == podsvetTrigger3.transform.position)
        {
            slot3skill = 9;
        }
        else if (skil10 != null && skil10.transform.position == podsvetTrigger3.transform.position)
        {
            slot3skill = 10;
        }
        else if (skil11 != null && skil11.transform.position == podsvetTrigger3.transform.position)
        {
            slot3skill = 11;
        }
        else if (skil12 != null && skil12.transform.position == podsvetTrigger3.transform.position)
        {
            slot3skill = 12;
        }
        else if (skil13 != null && skil13.transform.position == podsvetTrigger3.transform.position)
        {
            slot3skill = 13;
        }
        else if (skil14 != null && skil14.transform.position == podsvetTrigger3.transform.position)
        {
            slot3skill = 14;
        }
        else if (skil15 != null && skil15.transform.position == podsvetTrigger3.transform.position)
        {
            slot3skill = 15;
        }
        else if (skil16.transform.position == podsvetTrigger3.transform.position)
        {
            slot3skill = 16;
        }
        else if (skil17.transform.position == podsvetTrigger3.transform.position)
        {
            slot3skill = 17;
        }
        else if (skil18.transform.position == podsvetTrigger3.transform.position)
        {
            slot3skill = 18;
        }
        else if (skil19.transform.position == podsvetTrigger3.transform.position)
        {
            slot3skill = 19;
        }
        else if (skil20.transform.position == podsvetTrigger3.transform.position)
        {
            slot3skill = 20;
        }
        else if (skil21.transform.position == podsvetTrigger3.transform.position)
        {
            slot3skill = 21;
        }
        else if (skil22.transform.position == podsvetTrigger3.transform.position)
        {
            slot3skill = 22;
        }
        else if (skil23.transform.position == podsvetTrigger3.transform.position)
        {
            slot3skill = 23;
        }
        else if (skil24.transform.position == podsvetTrigger3.transform.position)
        {
            slot3skill = 24;
        }
        else if (skil25.transform.position == podsvetTrigger3.transform.position)
        {
            slot3skill = 25;
        }
        else if (skil26.transform.position == podsvetTrigger3.transform.position)
        {
            slot3skill = 26;
        }
        else if (skil27.transform.position == podsvetTrigger3.transform.position)
        {
            slot3skill = 27;
        }
        else if (skil28.transform.position == podsvetTrigger3.transform.position)
        {
            slot3skill = 28;
        }
        else if (skil29.transform.position == podsvetTrigger3.transform.position)
        {
            slot3skill = 29;
        }
        else if (skil30.transform.position == podsvetTrigger3.transform.position)
        {
            slot3skill = 30;
        }
        else if (skil31.transform.position == podsvetTrigger3.transform.position)
        {
            slot3skill = 31;
        }
        else if (skil32.transform.position == podsvetTrigger3.transform.position)
        {
            slot3skill = 32;
        }
        else if (skil33.transform.position == podsvetTrigger3.transform.position)
        {
            slot3skill = 33;
        }
        else if (skil34.transform.position == podsvetTrigger3.transform.position)
        {
            slot3skill = 34;
        }
        else if (skil35.transform.position == podsvetTrigger3.transform.position)
        {
            slot3skill = 35;
        }
        else if (skil36.transform.position == podsvetTrigger3.transform.position)
        {
            slot3skill = 36;
        }
        else if (skil37.transform.position == podsvetTrigger3.transform.position)
        {
            slot3skill = 37;
        }
        else if (skil38.transform.position == podsvetTrigger3.transform.position)
        {
            slot3skill = 38;
        }
        else if (skil39.transform.position == podsvetTrigger3.transform.position)
        {
            slot3skill = 39;
        }
        else if (skil40.transform.position == podsvetTrigger3.transform.position)
        {
            slot3skill = 40;
        }
        else if (skil41.transform.position == podsvetTrigger3.transform.position)
        {
            slot3skill = 41;
        }
        else if (skil42.transform.position == podsvetTrigger3.transform.position)
        {
            slot3skill = 42;
        }
        else if (skil43.transform.position == podsvetTrigger3.transform.position)
        {
            slot3skill = 43;
        }

        else
        {
            slot3skill = 0;
            slot3target1 = null;
            slot3target2 = null;
            slot3target3 = null;
        }

        if (skil1.transform.position == podsvetTrigger4.transform.position)
        {
            slot4skill = 1;
        }
        else if (skil2.transform.position == podsvetTrigger4.transform.position)
        {
            slot4skill = 2;
        }
        else if (skil3.transform.position == podsvetTrigger4.transform.position)
        {
            slot4skill = 3;
        }
        else if (skil4.transform.position == podsvetTrigger4.transform.position)
        {
            slot4skill = 4;
        }
        else if (skil5.transform.position == podsvetTrigger4.transform.position)
        {
            slot4skill = 5;
        }
        else if (skil6.transform.position == podsvetTrigger4.transform.position)
        {
            slot4skill = 6;
        }
        else if (skil8.transform.position == podsvetTrigger4.transform.position)
        {
            slot4skill = 8;
        }
        else if (skil9.transform.position == podsvetTrigger4.transform.position)
        {
            slot4skill = 9;
        }
        else if (skil10 != null && skil10.transform.position == podsvetTrigger4.transform.position)
        {
            slot4skill = 10;
        }
        else if (skil11 != null && skil11.transform.position == podsvetTrigger4.transform.position)
        {
            slot4skill = 11;
        }
        else if (skil12 != null && skil12.transform.position == podsvetTrigger4.transform.position)
        {
            slot4skill = 12;
        }
        else if (skil13 != null && skil13.transform.position == podsvetTrigger4.transform.position)
        {
            slot4skill = 13;
        }
        else if (skil14 != null && skil14.transform.position == podsvetTrigger4.transform.position)
        {
            slot4skill = 14;
        }
        else if (skil15 != null && skil15.transform.position == podsvetTrigger4.transform.position)
        {
            slot4skill = 15;
        }
        else if (skil16.transform.position == podsvetTrigger4.transform.position)
        {
            slot4skill = 16;
        }
        else if (skil17.transform.position == podsvetTrigger4.transform.position)
        {
            slot4skill = 17;
        }
        else if (skil18.transform.position == podsvetTrigger4.transform.position)
        {
            slot4skill = 18;
        }
        else if (skil19.transform.position == podsvetTrigger4.transform.position)
        {
            slot4skill = 19;
        }
        else if (skil20.transform.position == podsvetTrigger4.transform.position)
        {
            slot4skill = 20;
        }
        else if (skil21.transform.position == podsvetTrigger4.transform.position)
        {
            slot4skill = 21;
        }
        else if (skil22.transform.position == podsvetTrigger4.transform.position)
        {
            slot4skill = 22;
        }
        else if (skil23.transform.position == podsvetTrigger4.transform.position)
        {
            slot4skill = 23;
        }
        else if (skil24.transform.position == podsvetTrigger4.transform.position)
        {
            slot4skill = 24;
        }
        else if (skil25.transform.position == podsvetTrigger4.transform.position)
        {
            slot4skill = 25;
        }
        else if (skil26.transform.position == podsvetTrigger4.transform.position)
        {
            slot4skill = 26;
        }
        else if (skil27.transform.position == podsvetTrigger4.transform.position)
        {
            slot4skill = 27;
        }
        else if (skil28.transform.position == podsvetTrigger4.transform.position)
        {
            slot4skill = 28;
        }
        else if (skil29.transform.position == podsvetTrigger4.transform.position)
        {
            slot4skill = 29;
        }
        else if (skil30.transform.position == podsvetTrigger4.transform.position)
        {
            slot4skill = 30;
        }
        else if (skil31.transform.position == podsvetTrigger4.transform.position)
        {
            slot4skill = 31;
        }
        else if (skil32.transform.position == podsvetTrigger4.transform.position)
        {
            slot4skill = 32;
        }
        else if (skil33.transform.position == podsvetTrigger4.transform.position)
        {
            slot4skill = 33;
        }
        else if (skil34.transform.position == podsvetTrigger4.transform.position)
        {
            slot4skill = 34;
        }
        else if (skil35.transform.position == podsvetTrigger4.transform.position)
        {
            slot4skill = 35;
        }
        else if (skil36.transform.position == podsvetTrigger4.transform.position)
        {
            slot4skill = 36;
        }
        else if (skil37.transform.position == podsvetTrigger4.transform.position)
        {
            slot4skill = 37;
        }
        else if (skil38.transform.position == podsvetTrigger4.transform.position)
        {
            slot4skill = 38;
        }
        else if (skil39.transform.position == podsvetTrigger4.transform.position)
        {
            slot4skill = 39;
        }
        else if (skil40.transform.position == podsvetTrigger4.transform.position)
        {
            slot4skill = 40;
        }
        else if (skil41.transform.position == podsvetTrigger4.transform.position)
        {
            slot4skill = 41;
        }
        else if (skil42.transform.position == podsvetTrigger4.transform.position)
        {
            slot4skill = 42;
        }
        else if (skil43.transform.position == podsvetTrigger4.transform.position)
        {
            slot4skill = 43;
        }

        else
        {
            slot4skill = 0;
            slot4target1 = null;
            slot4target2 = null;
            slot4target3 = null;
        }

        if (skil1.transform.position == podsvetTrigger5.transform.position)
        {
            slot5skill = 1;
        }
        else if (skil2.transform.position == podsvetTrigger5.transform.position)
        {
            slot5skill = 2;
        }
        else if (skil3.transform.position == podsvetTrigger5.transform.position)
        {
            slot5skill = 3;
        }
        else if (skil4.transform.position == podsvetTrigger5.transform.position)
        {
            slot5skill = 4;
        }
        else if (skil5.transform.position == podsvetTrigger5.transform.position)
        {
            slot5skill = 5;
        }
        else if (skil6.transform.position == podsvetTrigger5.transform.position)
        {
            slot5skill = 6;
        }
        else if (skil8.transform.position == podsvetTrigger5.transform.position)
        {
            slot5skill = 8;
        }
        else if (skil9.transform.position == podsvetTrigger5.transform.position)
        {
            slot5skill = 9;
        }
        else if (skil10 != null && skil10.transform.position == podsvetTrigger5.transform.position)
        {
            slot5skill = 10;
        }
        else if (skil11 != null && skil11.transform.position == podsvetTrigger5.transform.position)
        {
            slot5skill = 11;
        }
        else if (skil12 != null && skil12.transform.position == podsvetTrigger5.transform.position)
        {
            slot5skill = 12;
        }
        else if (skil13 != null && skil13.transform.position == podsvetTrigger5.transform.position)
        {
            slot5skill = 13;
        }
        else if (skil14 != null && skil14.transform.position == podsvetTrigger5.transform.position)
        {
            slot5skill = 14;
        }
        else if (skil15 != null && skil15.transform.position == podsvetTrigger5.transform.position)
        {
            slot5skill = 15;
        }
        else if (skil16.transform.position == podsvetTrigger5.transform.position)
        {
            slot5skill = 16;
        }
        else if (skil17.transform.position == podsvetTrigger5.transform.position)
        {
            slot5skill = 17;
        }
        else if (skil18.transform.position == podsvetTrigger5.transform.position)
        {
            slot5skill = 18;
        }
        else if (skil19.transform.position == podsvetTrigger5.transform.position)
        {
            slot5skill = 19;
        }
        else if (skil20.transform.position == podsvetTrigger5.transform.position)
        {
            slot5skill = 20;
        }
        else if (skil21.transform.position == podsvetTrigger5.transform.position)
        {
            slot5skill = 21;
        }
        else if (skil22.transform.position == podsvetTrigger5.transform.position)
        {
            slot5skill = 22;
        }
        else if (skil23.transform.position == podsvetTrigger5.transform.position)
        {
            slot5skill = 23;
        }
        else if (skil24.transform.position == podsvetTrigger5.transform.position)
        {
            slot5skill = 24;
        }
        else if (skil25.transform.position == podsvetTrigger5.transform.position)
        {
            slot5skill = 25;
        }
        else if (skil26.transform.position == podsvetTrigger5.transform.position)
        {
            slot5skill = 26;
        }
        else if (skil27.transform.position == podsvetTrigger5.transform.position)
        {
            slot5skill = 27;
        }
        else if (skil28.transform.position == podsvetTrigger5.transform.position)
        {
            slot5skill = 28;
        }
        else if (skil29.transform.position == podsvetTrigger5.transform.position)
        {
            slot5skill = 29;
        }
        else if (skil30.transform.position == podsvetTrigger5.transform.position)
        {
            slot5skill = 30;
        }
        else if (skil31.transform.position == podsvetTrigger5.transform.position)
        {
            slot5skill = 31;
        }
        else if (skil32.transform.position == podsvetTrigger5.transform.position)
        {
            slot5skill = 32;
        }
        else if (skil33.transform.position == podsvetTrigger5.transform.position)
        {
            slot5skill = 33;
        }
        else if (skil34.transform.position == podsvetTrigger5.transform.position)
        {
            slot5skill = 34;
        }
        else if (skil35.transform.position == podsvetTrigger5.transform.position)
        {
            slot5skill = 35;
        }
        else if (skil36.transform.position == podsvetTrigger5.transform.position)
        {
            slot5skill = 36;
        }
        else if (skil37.transform.position == podsvetTrigger5.transform.position)
        {
            slot5skill = 37;
        }
        else if (skil38.transform.position == podsvetTrigger5.transform.position)
        {
            slot5skill = 38;
        }
        else if (skil39.transform.position == podsvetTrigger5.transform.position)
        {
            slot5skill = 39;
        }
        else if (skil40.transform.position == podsvetTrigger5.transform.position)
        {
            slot5skill = 40;
        }
        else if (skil41.transform.position == podsvetTrigger5.transform.position)
        {
            slot5skill = 41;
        }
        else if (skil42.transform.position == podsvetTrigger5.transform.position)
        {
            slot5skill = 42;
        }
        else if (skil43.transform.position == podsvetTrigger5.transform.position)
        {
            slot5skill = 43;
        }


        else
        {
            slot5skill = 0;
            slot5target1 = null;
            slot5target2 = null;
            slot5target3 = null;
        }

        if (skil1.transform.position == podsvetTrigger6.transform.position)
        {
            slot6skill = 1;
        }
        else if (skil2.transform.position == podsvetTrigger6.transform.position)
        {
            slot6skill = 2;
        }
        else if (skil3.transform.position == podsvetTrigger6.transform.position)
        {
            slot6skill = 3;
        }
        else if (skil4.transform.position == podsvetTrigger6.transform.position)
        {
            slot6skill = 4;
        }
        else if (skil5.transform.position == podsvetTrigger6.transform.position)
        {
            slot6skill = 5;
        }
        else if (skil6.transform.position == podsvetTrigger6.transform.position)
        {
            slot6skill = 6;
        }
        else if (skil8.transform.position == podsvetTrigger6.transform.position)
        {
            slot6skill = 8;
        }
        else if (skil9.transform.position == podsvetTrigger6.transform.position)
        {
            slot6skill = 9;
        }
        else if (skil10 != null && skil10.transform.position == podsvetTrigger6.transform.position)
        {
            slot6skill = 10;
        }
        else if (skil11 != null && skil11.transform.position == podsvetTrigger6.transform.position)
        {
            slot6skill = 11;
        }
        else if (skil12 != null && skil12.transform.position == podsvetTrigger6.transform.position)
        {
            slot6skill = 12;
        }
        else if (skil13 != null && skil13.transform.position == podsvetTrigger6.transform.position)
        {
            slot6skill = 13;
        }
        else if (skil14 != null && skil14.transform.position == podsvetTrigger6.transform.position)
        {
            slot6skill = 14;
        }
        else if (skil15 != null && skil15.transform.position == podsvetTrigger6.transform.position)
        {
            slot6skill = 15;
        }
        else if (skil16.transform.position == podsvetTrigger6.transform.position)
        {
            slot6skill = 16;
        }
        else if (skil17.transform.position == podsvetTrigger6.transform.position)
        {
            slot6skill = 17;
        }
        else if (skil18.transform.position == podsvetTrigger6.transform.position)
        {
            slot6skill = 18;
        }
        else if (skil19.transform.position == podsvetTrigger6.transform.position)
        {
            slot6skill = 19;
        }
        else if (skil20.transform.position == podsvetTrigger6.transform.position)
        {
            slot6skill = 20;
        }
        else if (skil21.transform.position == podsvetTrigger6.transform.position)
        {
            slot6skill = 21;
        }
        else if (skil22.transform.position == podsvetTrigger6.transform.position)
        {
            slot6skill = 22;
        }
        else if (skil23.transform.position == podsvetTrigger6.transform.position)
        {
            slot6skill = 23;
        }
        else if (skil24.transform.position == podsvetTrigger6.transform.position)
        {
            slot6skill = 24;
        }
        else if (skil25.transform.position == podsvetTrigger6.transform.position)
        {
            slot6skill = 25;
        }
        else if (skil26.transform.position == podsvetTrigger6.transform.position)
        {
            slot6skill = 26;
        }
        else if (skil27.transform.position == podsvetTrigger6.transform.position)
        {
            slot6skill = 27;
        }
        else if (skil28.transform.position == podsvetTrigger6.transform.position)
        {
            slot6skill = 28;
        }
        else if (skil29.transform.position == podsvetTrigger6.transform.position)
        {
            slot6skill = 29;
        }
        else if (skil30.transform.position == podsvetTrigger6.transform.position)
        {
            slot6skill = 30;
        }
        else if (skil31.transform.position == podsvetTrigger6.transform.position)
        {
            slot6skill = 31;
        }
        else if (skil32.transform.position == podsvetTrigger6.transform.position)
        {
            slot6skill = 32;
        }
        else if (skil33.transform.position == podsvetTrigger6.transform.position)
        {
            slot6skill = 33;
        }
        else if (skil34.transform.position == podsvetTrigger6.transform.position)
        {
            slot6skill = 34;
        }
        else if (skil35.transform.position == podsvetTrigger6.transform.position)
        {
            slot6skill = 35;
        }
        else if (skil36.transform.position == podsvetTrigger6.transform.position)
        {
            slot6skill = 36;
        }
        else if (skil37.transform.position == podsvetTrigger6.transform.position)
        {
            slot6skill = 37;
        }
        else if (skil38.transform.position == podsvetTrigger6.transform.position)
        {
            slot6skill = 38;
        }
        else if (skil39.transform.position == podsvetTrigger6.transform.position)
        {
            slot6skill = 39;
        }
        else if (skil40.transform.position == podsvetTrigger6.transform.position)
        {
            slot6skill = 40;
        }
        else if (skil41.transform.position == podsvetTrigger6.transform.position)
        {
            slot6skill = 41;
        }
        else if (skil42.transform.position == podsvetTrigger6.transform.position)
        {
            slot6skill = 42;
        }
        else if (skil43.transform.position == podsvetTrigger6.transform.position)
        {
            slot6skill = 43;
        }

        else
        {
            slot6skill = 0;
            slot6target1 = null;
            slot6target2 = null;
            slot6target3 = null;
        }

        if (skil1.transform.position == podsvetTrigger7.transform.position)
        {
            slot7skill = 1;
        }
        else if (skil2.transform.position == podsvetTrigger7.transform.position)
        {
            slot7skill = 2;
        }
        else if (skil3.transform.position == podsvetTrigger7.transform.position)
        {
            slot7skill = 3;
        }
        else if (skil4.transform.position == podsvetTrigger7.transform.position)
        {
            slot7skill = 4;
        }
        else if (skil5.transform.position == podsvetTrigger7.transform.position)
        {
            slot7skill = 5;
        }
        else if (skil6.transform.position == podsvetTrigger7.transform.position)
        {
            slot7skill = 6;
        }
        else if (skil8.transform.position == podsvetTrigger7.transform.position)
        {
            slot7skill = 8;
        }
        else if (skil9.transform.position == podsvetTrigger7.transform.position)
        {
            slot7skill = 9;
        }
        else if (skil10 != null && skil10.transform.position == podsvetTrigger7.transform.position)
        {
            slot7skill = 10;
        }
        else if (skil11 != null && skil11.transform.position == podsvetTrigger7.transform.position)
        {
            slot7skill = 11;
        }
        else if (skil12 != null && skil12.transform.position == podsvetTrigger7.transform.position)
        {
            slot7skill = 12;
        }
        else if (skil13 != null && skil13.transform.position == podsvetTrigger7.transform.position)
        {
            slot7skill = 13;
        }
        else if (skil14 != null && skil14.transform.position == podsvetTrigger7.transform.position)
        {
            slot7skill = 14;
        }
        else if (skil15 != null && skil15.transform.position == podsvetTrigger7.transform.position)
        {
            slot7skill = 15;
        }
        else if (skil16.transform.position == podsvetTrigger7.transform.position)
        {
            slot7skill = 16;
        }
        else if (skil17.transform.position == podsvetTrigger7.transform.position)
        {
            slot7skill = 17;
        }
        else if (skil18.transform.position == podsvetTrigger7.transform.position)
        {
            slot7skill = 18;
        }
        else if (skil19.transform.position == podsvetTrigger7.transform.position)
        {
            slot7skill = 19;
        }
        else if (skil20.transform.position == podsvetTrigger7.transform.position)
        {
            slot7skill = 20;
        }
        else if (skil21.transform.position == podsvetTrigger7.transform.position)
        {
            slot7skill = 21;
        }
        else if (skil22.transform.position == podsvetTrigger7.transform.position)
        {
            slot7skill = 22;
        }
        else if (skil23.transform.position == podsvetTrigger7.transform.position)
        {
            slot7skill = 23;
        }
        else if (skil24.transform.position == podsvetTrigger7.transform.position)
        {
            slot7skill = 24;
        }
        else if (skil25.transform.position == podsvetTrigger7.transform.position)
        {
            slot7skill = 25;
        }
        else if (skil26.transform.position == podsvetTrigger7.transform.position)
        {
            slot7skill = 26;
        }
        else if (skil27.transform.position == podsvetTrigger7.transform.position)
        {
            slot7skill = 27;
        }
        else if (skil28.transform.position == podsvetTrigger7.transform.position)
        {
            slot7skill = 28;
        }
        else if (skil29.transform.position == podsvetTrigger7.transform.position)
        {
            slot7skill = 29;
        }
        else if (skil30.transform.position == podsvetTrigger7.transform.position)
        {
            slot7skill = 30;
        }
        else if (skil31.transform.position == podsvetTrigger7.transform.position)
        {
            slot7skill = 31;
        }
        else if (skil32.transform.position == podsvetTrigger7.transform.position)
        {
            slot7skill = 32;
        }
        else if (skil33.transform.position == podsvetTrigger7.transform.position)
        {
            slot7skill = 33;
        }
        else if (skil34.transform.position == podsvetTrigger7.transform.position)
        {
            slot7skill = 34;
        }
        else if (skil35.transform.position == podsvetTrigger7.transform.position)
        {
            slot7skill = 35;
        }
        else if (skil36.transform.position == podsvetTrigger7.transform.position)
        {
            slot7skill = 36;
        }
        else if (skil37.transform.position == podsvetTrigger7.transform.position)
        {
            slot7skill = 37;
        }
        else if (skil38.transform.position == podsvetTrigger7.transform.position)
        {
            slot7skill = 38;
        }
        else if (skil39.transform.position == podsvetTrigger7.transform.position)
        {
            slot7skill = 39;
        }
        else if (skil40.transform.position == podsvetTrigger7.transform.position)
        {
            slot7skill = 40;
        }
        else if (skil41.transform.position == podsvetTrigger7.transform.position)
        {
            slot7skill = 41;
        }
        else if (skil42.transform.position == podsvetTrigger7.transform.position)
        {
            slot7skill = 42;
        }
        else if (skil43.transform.position == podsvetTrigger7.transform.position)
        {
            slot7skill = 43;
        }


        else
        {
            slot7skill = 0;
            slot7target1 = null;
            slot7target2 = null;
            slot7target3 = null;
        }

        if (skil1.transform.position == podsvetTrigger8.transform.position)
        {
            slot8skill = 1;
        }
        else if (skil2.transform.position == podsvetTrigger8.transform.position)
        {
            slot8skill = 2;
        }
        else if (skil3.transform.position == podsvetTrigger8.transform.position)
        {
            slot8skill = 3;
        }
        else if (skil4.transform.position == podsvetTrigger8.transform.position)
        {
            slot8skill = 4;
        }
        else if (skil5.transform.position == podsvetTrigger8.transform.position)
        {
            slot8skill = 5;
        }
        else if (skil6.transform.position == podsvetTrigger8.transform.position)
        {
            slot8skill = 6;
        }
        else if (skil8.transform.position == podsvetTrigger8.transform.position)
        {
            slot8skill = 8;
        }
        else if (skil9.transform.position == podsvetTrigger8.transform.position)
        {
            slot8skill = 9;
        }
        else if (skil10 != null && skil10.transform.position == podsvetTrigger8.transform.position)
        {
            slot8skill = 10;
        }
        else if (skil11 != null && skil11.transform.position == podsvetTrigger8.transform.position)
        {
            slot8skill = 11;
        }
        else if (skil12 != null && skil12.transform.position == podsvetTrigger8.transform.position)
        {
            slot8skill = 12;
        }
        else if (skil13 != null && skil13.transform.position == podsvetTrigger8.transform.position)
        {
            slot8skill = 13;
        }
        else if (skil14 != null && skil14.transform.position == podsvetTrigger8.transform.position)
        {
            slot8skill = 14;
        }
        else if (skil15 != null && skil15.transform.position == podsvetTrigger8.transform.position)
        {
            slot8skill = 15;
        }
        else if (skil16.transform.position == podsvetTrigger8.transform.position)
        {
            slot8skill = 16;
        }
        else if (skil17.transform.position == podsvetTrigger8.transform.position)
        {
            slot8skill = 17;
        }
        else if (skil18.transform.position == podsvetTrigger8.transform.position)
        {
            slot8skill = 18;
        }
        else if (skil19.transform.position == podsvetTrigger8.transform.position)
        {
            slot8skill = 19;
        }
        else if (skil20.transform.position == podsvetTrigger8.transform.position)
        {
            slot8skill = 20;
        }
        else if (skil21.transform.position == podsvetTrigger8.transform.position)
        {
            slot8skill = 21;
        }
        else if (skil22.transform.position == podsvetTrigger8.transform.position)
        {
            slot8skill = 22;
        }
        else if (skil23.transform.position == podsvetTrigger8.transform.position)
        {
            slot8skill = 23;
        }
        else if (skil24.transform.position == podsvetTrigger8.transform.position)
        {
            slot8skill = 24;
        }
        else if (skil25.transform.position == podsvetTrigger8.transform.position)
        {
            slot8skill = 25;
        }
        else if (skil26.transform.position == podsvetTrigger8.transform.position)
        {
            slot8skill = 26;
        }
        else if (skil27.transform.position == podsvetTrigger8.transform.position)
        {
            slot8skill = 27;
        }
        else if (skil28.transform.position == podsvetTrigger8.transform.position)
        {
            slot8skill = 28;
        }
        else if (skil29.transform.position == podsvetTrigger8.transform.position)
        {
            slot8skill = 29;
        }
        else if (skil31.transform.position == podsvetTrigger8.transform.position)
        {
            slot8skill = 31;
        }
        else if (skil30.transform.position == podsvetTrigger8.transform.position)
        {
            slot8skill = 30;
        }
        else if (skil32.transform.position == podsvetTrigger8.transform.position)
        {
            slot8skill = 32;
        }
        else if (skil33.transform.position == podsvetTrigger8.transform.position)
        {
            slot8skill = 33;
        }
        else if (skil34.transform.position == podsvetTrigger8.transform.position)
        {
            slot8skill = 34;
        }
        else if (skil35.transform.position == podsvetTrigger8.transform.position)
        {
            slot8skill = 35;
        }
        else if (skil36.transform.position == podsvetTrigger8.transform.position)
        {
            slot8skill = 36;
        }
        else if (skil37.transform.position == podsvetTrigger8.transform.position)
        {
            slot8skill = 37;
        }
        else if (skil38.transform.position == podsvetTrigger8.transform.position)
        {
            slot8skill = 38;
        }
        else if (skil39.transform.position == podsvetTrigger8.transform.position)
        {
            slot8skill = 39;
        }
        else if (skil40.transform.position == podsvetTrigger8.transform.position)
        {
            slot8skill = 40;
        }
        else if (skil41.transform.position == podsvetTrigger8.transform.position)
        {
            slot8skill = 41;
        }
        else if (skil42.transform.position == podsvetTrigger8.transform.position)
        {
            slot8skill = 42;
        }
        else if (skil43.transform.position == podsvetTrigger8.transform.position)
        {
            slot8skill = 43;
        }

        else
        {
            slot8skill = 0;
            slot8target1 = null;
            slot8target2 = null;
            slot8target3 = null;
        }

        if (skil1.transform.position == podsvetTrigger9.transform.position)
        {
            slot9skill = 1;
        }
        else if (skil2.transform.position == podsvetTrigger9.transform.position)
        {
            slot9skill = 2;
        }
        else if (skil3.transform.position == podsvetTrigger9.transform.position)
        {
            slot9skill = 3;
        }
        else if (skil4.transform.position == podsvetTrigger9.transform.position)
        {
            slot9skill = 4;
        }
        else if (skil5.transform.position == podsvetTrigger9.transform.position)
        {
            slot9skill = 5;
        }
        else if (skil6.transform.position == podsvetTrigger9.transform.position)
        {
            slot9skill = 6;
        }
        else if (skil8.transform.position == podsvetTrigger9.transform.position)
        {
            slot9skill = 8;
        }
        else if (skil9.transform.position == podsvetTrigger9.transform.position)
        {
            slot9skill = 9;
        }
        else if (skil10 != null && skil10.transform.position == podsvetTrigger9.transform.position)
        {
            slot9skill = 10;
        }
        else if (skil11 != null && skil11.transform.position == podsvetTrigger9.transform.position)
        {
            slot9skill = 11;
        }
        else if (skil12 != null && skil12.transform.position == podsvetTrigger9.transform.position)
        {
            slot9skill = 12;
        }
        else if (skil13 != null && skil13.transform.position == podsvetTrigger9.transform.position)
        {
            slot9skill = 13;
        }
        else if (skil14 != null && skil14.transform.position == podsvetTrigger9.transform.position)
        {
            slot9skill = 14;
        }
        else if (skil15 != null && skil15.transform.position == podsvetTrigger9.transform.position)
        {
            slot9skill = 15;
        }
        else if (skil16.transform.position == podsvetTrigger9.transform.position)
        {
            slot9skill = 16;
        }
        else if (skil17.transform.position == podsvetTrigger9.transform.position)
        {
            slot9skill = 17;
        }
        else if (skil18.transform.position == podsvetTrigger9.transform.position)
        {
            slot9skill = 18;
        }
        else if (skil19.transform.position == podsvetTrigger9.transform.position)
        {
            slot9skill = 19;
        }
        else if (skil20.transform.position == podsvetTrigger9.transform.position)
        {
            slot9skill = 20;
        }
        else if (skil21.transform.position == podsvetTrigger9.transform.position)
        {
            slot9skill = 21;
        }
        else if (skil22.transform.position == podsvetTrigger9.transform.position)
        {
            slot9skill = 22;
        }
        else if (skil23.transform.position == podsvetTrigger9.transform.position)
        {
            slot9skill = 23;
        }
        else if (skil24.transform.position == podsvetTrigger9.transform.position)
        {
            slot9skill = 24;
        }
        else if (skil25.transform.position == podsvetTrigger9.transform.position)
        {
            slot9skill = 25;
        }
        else if (skil26.transform.position == podsvetTrigger9.transform.position)
        {
            slot9skill = 26;
        }
        else if (skil27.transform.position == podsvetTrigger9.transform.position)
        {
            slot9skill = 27;
        }
        else if (skil28.transform.position == podsvetTrigger9.transform.position)
        {
            slot9skill = 28;
        }
        else if (skil29.transform.position == podsvetTrigger9.transform.position)
        {
            slot9skill = 29;
        }
        else if (skil30.transform.position == podsvetTrigger9.transform.position)
        {
            slot9skill = 30;
        }
        else if (skil31.transform.position == podsvetTrigger9.transform.position)
        {
            slot9skill = 31;
        }
        else if (skil32.transform.position == podsvetTrigger9.transform.position)
        {
            slot9skill = 32;
        }
        else if (skil33.transform.position == podsvetTrigger9.transform.position)
        {
            slot9skill = 33;
        }
        else if (skil34.transform.position == podsvetTrigger9.transform.position)
        {
            slot9skill = 34;
        }
        else if (skil35.transform.position == podsvetTrigger9.transform.position)
        {
            slot9skill = 35;
        }
        else if (skil36.transform.position == podsvetTrigger9.transform.position)
        {
            slot9skill = 36;
        }
        else if (skil37.transform.position == podsvetTrigger9.transform.position)
        {
            slot9skill = 37;
        }
        else if (skil38.transform.position == podsvetTrigger9.transform.position)
        {
            slot9skill = 38;
        }
        else if (skil39.transform.position == podsvetTrigger9.transform.position)
        {
            slot9skill = 39;
        }
        else if (skil40.transform.position == podsvetTrigger9.transform.position)
        {
            slot9skill = 40;
        }
        else if (skil41.transform.position == podsvetTrigger9.transform.position)
        {
            slot9skill = 41;
        }
        else if (skil42.transform.position == podsvetTrigger9.transform.position)
        {
            slot9skill = 42;
        }
        else if (skil43.transform.position == podsvetTrigger9.transform.position)
        {
            slot9skill = 43;
        }

        else
        {
            slot9skill = 0;
            slot9target1 = null;
            slot9target2 = null;
            slot9target3 = null;
        }






        // если произошло изменение
        if (slot1skill != slot1skillCompare)
        {
            
            slot1target1 = null;
            slot1target2 = null;
            slot1target3 = null;
        }
        if (slot2skill != slot2skillCompare)
        {
           
            slot2target1 = null;
            slot2target2 = null;
            slot2target3 = null;
        }
        if (slot3skill != slot3skillCompare)
        {
        
            slot3target1 = null;
            slot3target2 = null;
            slot3target3 = null;
        }
        if (slot4skill != slot4skillCompare)
        {
      
            slot4target1 = null;
            slot4target2 = null;
            slot4target3 = null;
        }
        if (slot5skill != slot5skillCompare)
        {
    
            slot5target1 = null;
            slot5target2 = null;
            slot5target3 = null;
        }
        if (slot6skill != slot6skillCompare)
        {
    
            slot6target1 = null;
            slot6target2 = null;
            slot6target3 = null;
        }
        if (slot7skill != slot7skillCompare)
        {

            slot7target1 = null;
            slot7target2 = null;
            slot7target3 = null;
        }
        if (slot8skill != slot8skillCompare)
        {
   
            slot8target1 = null;
            slot8target2 = null;
            slot8target3 = null;
        }
        if (slot9skill != slot9skillCompare)
        {

            slot9target1 = null;
            slot9target2 = null;
            slot9target3 = null;
        }
        vybrMishen = null;

        SlotZapolnitelComparison();

    }

    public void Cheker()
    {
        // убираем навыки, которые стоят не там, домой
        if (skil1.transform.position == podsvetTrigger4.transform.position || skil1.transform.position == podsvetTrigger6.transform.position || skil1.transform.position == podsvetTrigger7.transform.position || skil1.transform.position == podsvetTrigger8.transform.position || skil1.transform.position == podsvetTrigger9.transform.position)
        {
            skil1.transform.position = colonka1.transform.position;
        }
        if (skil2.transform.position == podsvetTrigger4.transform.position || skil2.transform.position == podsvetTrigger6.transform.position || skil2.transform.position == podsvetTrigger7.transform.position || skil2.transform.position == podsvetTrigger8.transform.position || skil2.transform.position == podsvetTrigger9.transform.position)
        {
            skil2.transform.position = colonka2.transform.position;
        }
        if (skil3.transform.position == podsvetTrigger4.transform.position || skil3.transform.position == podsvetTrigger6.transform.position || skil3.transform.position == podsvetTrigger7.transform.position || skil3.transform.position == podsvetTrigger8.transform.position || skil3.transform.position == podsvetTrigger9.transform.position)
        {
            skil3.transform.position = colonka3.transform.position;
        }
        if (skil4.transform.position == podsvetTrigger4.transform.position || skil4.transform.position == podsvetTrigger5.transform.position || skil4.transform.position == podsvetTrigger6.transform.position || skil4.transform.position == podsvetTrigger7.transform.position || skil4.transform.position == podsvetTrigger8.transform.position || skil4.transform.position == podsvetTrigger9.transform.position)
        {
            skil4.transform.position = colonka4.transform.position;
        }

        if (skil5.transform.position == podsvetTrigger1.transform.position || skil5.transform.position == podsvetTrigger2.transform.position || skil5.transform.position == podsvetTrigger3.transform.position || skil5.transform.position == podsvetTrigger7.transform.position || skil5.transform.position == podsvetTrigger8.transform.position || skil5.transform.position == podsvetTrigger9.transform.position)
        {
            skil5.transform.position = colonka5.transform.position;
        }
        if (skil6.transform.position == podsvetTrigger1.transform.position || skil6.transform.position == podsvetTrigger2.transform.position || skil6.transform.position == podsvetTrigger3.transform.position || skil6.transform.position == podsvetTrigger5.transform.position)
        {
            skil6.transform.position = colonka6.transform.position;
        }
        if (skil8.transform.position == podsvetTrigger1.transform.position || skil8.transform.position == podsvetTrigger2.transform.position || skil8.transform.position == podsvetTrigger3.transform.position || skil8.transform.position == podsvetTrigger5.transform.position)
        {
            skil8.transform.position = colonka8.transform.position;
        }
        if (skil9.transform.position == podsvetTrigger1.transform.position || skil9.transform.position == podsvetTrigger2.transform.position || skil9.transform.position == podsvetTrigger3.transform.position || skil9.transform.position == podsvetTrigger4.transform.position || skil9.transform.position == podsvetTrigger5.transform.position || skil9.transform.position == podsvetTrigger6.transform.position)
        {
            skil9.transform.position = colonka9.transform.position;
        }
        if (skil10.transform.position == podsvetTrigger1.transform.position || skil10.transform.position == podsvetTrigger3.transform.position || skil10.transform.position == podsvetTrigger5.transform.position || skil10.transform.position == podsvetTrigger7.transform.position || skil10.transform.position == podsvetTrigger8.transform.position || skil10.transform.position == podsvetTrigger9.transform.position)
        {
            skil10.transform.position = colonka10.transform.position;
        }
        if (skil11.transform.position == podsvetTrigger2.transform.position || skil11.transform.position == podsvetTrigger4.transform.position || skil11.transform.position == podsvetTrigger6.transform.position || skil11.transform.position == podsvetTrigger7.transform.position || skil11.transform.position == podsvetTrigger8.transform.position || skil11.transform.position == podsvetTrigger9.transform.position)
        {
            skil11.transform.position = colonka11.transform.position;
        }
        if (skil12.transform.position == podsvetTrigger1.transform.position || skil12.transform.position == podsvetTrigger2.transform.position || skil12.transform.position == podsvetTrigger3.transform.position || skil12.transform.position == podsvetTrigger7.transform.position || skil12.transform.position == podsvetTrigger8.transform.position || skil12.transform.position == podsvetTrigger9.transform.position)
        {
            skil12.transform.position = colonka12.transform.position;
        }
        if (skil13.transform.position == podsvetTrigger1.transform.position || skil13.transform.position == podsvetTrigger2.transform.position || skil13.transform.position == podsvetTrigger3.transform.position || skil13.transform.position == podsvetTrigger5.transform.position || skil13.transform.position == podsvetTrigger7.transform.position || skil13.transform.position == podsvetTrigger8.transform.position || skil13.transform.position == podsvetTrigger9.transform.position)
        {
            skil13.transform.position = colonka13.transform.position;
        }
        if (skil14.transform.position == podsvetTrigger1.transform.position || skil14.transform.position == podsvetTrigger2.transform.position || skil14.transform.position == podsvetTrigger3.transform.position || skil14.transform.position == podsvetTrigger4.transform.position || skil14.transform.position == podsvetTrigger5.transform.position || skil14.transform.position == podsvetTrigger6.transform.position || skil14.transform.position == podsvetTrigger8.transform.position)
        {
            skil14.transform.position = colonka14.transform.position;
        }
        if (skil15.transform.position == podsvetTrigger1.transform.position || skil15.transform.position == podsvetTrigger2.transform.position || skil15.transform.position == podsvetTrigger3.transform.position || skil15.transform.position == podsvetTrigger7.transform.position || skil15.transform.position == podsvetTrigger8.transform.position || skil15.transform.position == podsvetTrigger9.transform.position)
        {
            skil15.transform.position = colonka15.transform.position;
        }
        if (skil16.transform.position == podsvetTrigger1.transform.position || skil16.transform.position == podsvetTrigger2.transform.position || skil16.transform.position == podsvetTrigger3.transform.position || skil16.transform.position == podsvetTrigger4.transform.position || skil16.transform.position == podsvetTrigger5.transform.position || skil16.transform.position == podsvetTrigger6.transform.position)
        {
            skil16.transform.position = colonka16.transform.position;
        }
        if (skil17.transform.position == podsvetTrigger7.transform.position || skil17.transform.position == podsvetTrigger8.transform.position || skil17.transform.position == podsvetTrigger9.transform.position || skil17.transform.position == podsvetTrigger4.transform.position || skil17.transform.position == podsvetTrigger5.transform.position || skil17.transform.position == podsvetTrigger6.transform.position)
        {
            skil17.transform.position = colonka17.transform.position;
        }
        if (skil18.transform.position == podsvetTrigger7.transform.position || skil18.transform.position == podsvetTrigger8.transform.position || skil18.transform.position == podsvetTrigger9.transform.position || skil18.transform.position == podsvetTrigger4.transform.position || skil18.transform.position == podsvetTrigger5.transform.position || skil18.transform.position == podsvetTrigger6.transform.position)
        {
            skil18.transform.position = colonka18.transform.position;
        }
        if (skil19.transform.position == podsvetTrigger7.transform.position || skil19.transform.position == podsvetTrigger8.transform.position || skil19.transform.position == podsvetTrigger9.transform.position || skil19.transform.position == podsvetTrigger1.transform.position || skil19.transform.position == podsvetTrigger2.transform.position || skil19.transform.position == podsvetTrigger3.transform.position)
        {
            skil19.transform.position = colonka19.transform.position;
        }
        if (skil20.transform.position == podsvetTrigger7.transform.position || skil20.transform.position == podsvetTrigger8.transform.position || skil20.transform.position == podsvetTrigger9.transform.position || skil20.transform.position == podsvetTrigger2.transform.position || skil20.transform.position == podsvetTrigger4.transform.position || skil20.transform.position == podsvetTrigger5.transform.position)
        {
            skil20.transform.position = colonka20.transform.position;
        }
        if (skil21.transform.position == podsvetTrigger5.transform.position || skil21.transform.position == podsvetTrigger8.transform.position)
        {
            skil21.transform.position = colonka21.transform.position;
        }
        if (skil22.transform.position == podsvetTrigger1.transform.position || skil22.transform.position == podsvetTrigger3.transform.position || skil22.transform.position == podsvetTrigger4.transform.position || skil22.transform.position == podsvetTrigger6.transform.position)
        {
            skil22.transform.position = colonka22.transform.position;
        }
        if (skil23.transform.position == podsvetTrigger1.transform.position || skil23.transform.position == podsvetTrigger2.transform.position || skil23.transform.position == podsvetTrigger3.transform.position || skil23.transform.position == podsvetTrigger4.transform.position || skil23.transform.position == podsvetTrigger5.transform.position || skil23.transform.position == podsvetTrigger6.transform.position || skil23.transform.position == podsvetTrigger7.transform.position || skil23.transform.position == podsvetTrigger9.transform.position)
        {
            skil23.transform.position = colonka23.transform.position;
        }
        if (skil24.transform.position == podsvetTrigger1.transform.position || skil24.transform.position == podsvetTrigger2.transform.position || skil24.transform.position == podsvetTrigger3.transform.position || skil24.transform.position == podsvetTrigger4.transform.position || skil24.transform.position == podsvetTrigger5.transform.position || skil24.transform.position == podsvetTrigger6.transform.position || skil24.transform.position == podsvetTrigger7.transform.position || skil24.transform.position == podsvetTrigger9.transform.position)
        {
            skil24.transform.position = colonka24.transform.position;
        }
        if (skil25.transform.position == podsvetTrigger1.transform.position || skil25.transform.position == podsvetTrigger2.transform.position || skil25.transform.position == podsvetTrigger3.transform.position || skil25.transform.position == podsvetTrigger4.transform.position || skil25.transform.position == podsvetTrigger8.transform.position || skil25.transform.position == podsvetTrigger6.transform.position || skil25.transform.position == podsvetTrigger7.transform.position || skil25.transform.position == podsvetTrigger9.transform.position)
        {
            skil25.transform.position = colonka25.transform.position;
        }
        if (skil26.transform.position == podsvetTrigger1.transform.position || skil26.transform.position == podsvetTrigger2.transform.position || skil26.transform.position == podsvetTrigger3.transform.position || skil26.transform.position == podsvetTrigger4.transform.position || skil26.transform.position == podsvetTrigger8.transform.position || skil26.transform.position == podsvetTrigger6.transform.position || skil26.transform.position == podsvetTrigger7.transform.position || skil26.transform.position == podsvetTrigger9.transform.position)
        {
            skil26.transform.position = colonka26.transform.position;
        }
        if (skil27.transform.position == podsvetTrigger2.transform.position || skil27.transform.position == podsvetTrigger4.transform.position || skil27.transform.position == podsvetTrigger5.transform.position || skil27.transform.position == podsvetTrigger6.transform.position || skil27.transform.position == podsvetTrigger8.transform.position)
        {
            skil27.transform.position = colonka27.transform.position;
        }
        if (skil28.transform.position == podsvetTrigger7.transform.position || skil28.transform.position == podsvetTrigger8.transform.position || skil28.transform.position == podsvetTrigger9.transform.position)
        {
            skil28.transform.position = colonka28.transform.position;
        }
        if (skil30.transform.position == podsvetTrigger7.transform.position || skil30.transform.position == podsvetTrigger8.transform.position || skil30.transform.position == podsvetTrigger9.transform.position || skil30.transform.position == podsvetTrigger1.transform.position || skil30.transform.position == podsvetTrigger2.transform.position || skil30.transform.position == podsvetTrigger3.transform.position)
        {
            skil30.transform.position = colonka30.transform.position;
        }
        if (skil31.transform.position == podsvetTrigger4.transform.position || skil31.transform.position == podsvetTrigger5.transform.position || skil31.transform.position == podsvetTrigger6.transform.position || skil31.transform.position == podsvetTrigger1.transform.position || skil31.transform.position == podsvetTrigger2.transform.position || skil31.transform.position == podsvetTrigger3.transform.position)
        {
            skil31.transform.position = colonka31.transform.position;
        }
        if (skil32.transform.position == podsvetTrigger1.transform.position || skil32.transform.position == podsvetTrigger2.transform.position || skil32.transform.position == podsvetTrigger3.transform.position || skil32.transform.position == podsvetTrigger4.transform.position || skil32.transform.position == podsvetTrigger5.transform.position || skil32.transform.position == podsvetTrigger6.transform.position || skil32.transform.position == podsvetTrigger7.transform.position || skil32.transform.position == podsvetTrigger9.transform.position)
        {
            skil32.transform.position = colonka32.transform.position;
        }
        if (skil34.transform.position == podsvetTrigger1.transform.position || skil34.transform.position == podsvetTrigger2.transform.position || skil34.transform.position == podsvetTrigger3.transform.position || skil34.transform.position == podsvetTrigger8.transform.position)
        {
            skil34.transform.position = colonka34.transform.position;
        }
        if (skil35.transform.position == podsvetTrigger4.transform.position || skil35.transform.position == podsvetTrigger5.transform.position || skil35.transform.position == podsvetTrigger6.transform.position || skil35.transform.position == podsvetTrigger7.transform.position || skil35.transform.position == podsvetTrigger7.transform.position || skil35.transform.position == podsvetTrigger9.transform.position)
        {
            skil35.transform.position = colonka35.transform.position;
        }
        if (skil36.transform.position == podsvetTrigger1.transform.position || skil36.transform.position == podsvetTrigger3.transform.position || skil36.transform.position == podsvetTrigger4.transform.position || skil36.transform.position == podsvetTrigger6.transform.position || skil36.transform.position == podsvetTrigger7.transform.position || skil36.transform.position == podsvetTrigger9.transform.position)
        {
            skil36.transform.position = colonka36.transform.position;
        }
        if (skil37.transform.position == podsvetTrigger1.transform.position || skil37.transform.position == podsvetTrigger2.transform.position || skil37.transform.position == podsvetTrigger3.transform.position || skil37.transform.position == podsvetTrigger4.transform.position || skil37.transform.position == podsvetTrigger6.transform.position)
        {
            skil37.transform.position = colonka37.transform.position;
        }


        if (skil39.transform.position == podsvetTrigger1.transform.position || skil39.transform.position == podsvetTrigger2.transform.position || skil39.transform.position == podsvetTrigger3.transform.position || skil39.transform.position == podsvetTrigger4.transform.position || skil39.transform.position == podsvetTrigger6.transform.position)
        {
            skil39.transform.position = colonka39.transform.position;
        }

        if (skil41.transform.position == podsvetTrigger1.transform.position || skil41.transform.position == podsvetTrigger2.transform.position || skil41.transform.position == podsvetTrigger3.transform.position || skil41.transform.position == podsvetTrigger5.transform.position)
        {
            skil41.transform.position = colonka41.transform.position;
        }
        if (skil42.transform.position == podsvetTrigger1.transform.position || skil42.transform.position == podsvetTrigger3.transform.position || skil42.transform.position == podsvetTrigger4.transform.position || skil42.transform.position == podsvetTrigger7.transform.position || skil42.transform.position == podsvetTrigger9.transform.position)
        {
            skil42.transform.position = colonka42.transform.position;
        }
        if (skil43.transform.position == podsvetTrigger5.transform.position || skil43.transform.position == podsvetTrigger6.transform.position || skil43.transform.position == podsvetTrigger7.transform.position || skil43.transform.position == podsvetTrigger8.transform.position || skil43.transform.position == podsvetTrigger9.transform.position)
        {
            skil43.transform.position = colonka43.transform.position;
        }


        // тт выравниваются плавники
        if (skil29.transform.position == podsvetTrigger1.transform.position || skil29.transform.position == podsvetTrigger2.transform.position || skil29.transform.position == podsvetTrigger3.transform.position || skil29.transform.position == podsvetTrigger5.transform.position || skil29.transform.position == podsvetTrigger7.transform.position || skil29.transform.position == podsvetTrigger8.transform.position || skil29.transform.position == podsvetTrigger9.transform.position)
        {
            skil29.transform.position = colonka29.transform.position;
        }
        if (skil29sosok.transform.position == podsvetTrigger1.transform.position || skil29sosok.transform.position == podsvetTrigger2.transform.position || skil29sosok.transform.position == podsvetTrigger3.transform.position || skil29sosok.transform.position == podsvetTrigger5.transform.position || skil29sosok.transform.position == podsvetTrigger7.transform.position || skil29sosok.transform.position == podsvetTrigger8.transform.position || skil29sosok.transform.position == podsvetTrigger9.transform.position)
        {
            skil29sosok.transform.position = colonka29.transform.position;
        }
        if (skil33.transform.position == podsvetTrigger4.transform.position || skil33.transform.position == podsvetTrigger5.transform.position || skil33.transform.position == podsvetTrigger6.transform.position)
        {
            skil33.transform.position = colonka33.transform.position;
        }
        if (skil33sosok.transform.position == podsvetTrigger4.transform.position || skil33sosok.transform.position == podsvetTrigger5.transform.position || skil33sosok.transform.position == podsvetTrigger6.transform.position)
        {
            skil33sosok.transform.position = colonka33.transform.position;
        }

    }

    public void Otkluchalka() // выключает подсветки и описания для боя
    {
        if (slotsEnemy.slo1.transform.childCount > 0 && slot1skillVraga != 0)
        {
            slotsEnemy.slo1.transform.GetChild(0).transform.GetChild(1).gameObject.SetActive(false);
            slotsEnemy.slo1.transform.GetChild(0).transform.GetChild(0).gameObject.SetActive(false);
        }
        if (slotsEnemy.slo2.transform.childCount > 0 && slot2skillVraga != 0)
        {
            slotsEnemy.slo2.transform.GetChild(0).transform.GetChild(1).gameObject.SetActive(false);
            slotsEnemy.slo2.transform.GetChild(0).transform.GetChild(0).gameObject.SetActive(false);
        }
        if (slotsEnemy.slo3.transform.childCount > 0 && slot3skillVraga != 0)
        {
            slotsEnemy.slo3.transform.GetChild(0).transform.GetChild(1).gameObject.SetActive(false);
            slotsEnemy.slo3.transform.GetChild(0).transform.GetChild(0).gameObject.SetActive(false);
        }
        if (slotsEnemy.slo4.transform.childCount > 0 && slot4skillVraga != 0)
        {
            slotsEnemy.slo4.transform.GetChild(0).transform.GetChild(1).gameObject.SetActive(false);
            slotsEnemy.slo4.transform.GetChild(0).transform.GetChild(0).gameObject.SetActive(false);
        }
        if (slotsEnemy.slo5.transform.childCount > 0 && slot5skillVraga != 0)
        {
            slotsEnemy.slo5.transform.GetChild(0).transform.GetChild(1).gameObject.SetActive(false);
            slotsEnemy.slo5.transform.GetChild(0).transform.GetChild(0).gameObject.SetActive(false);
        }
        if (slotsEnemy.slo6.transform.childCount > 0 && slot6skillVraga != 0)
        {
            slotsEnemy.slo6.transform.GetChild(0).transform.GetChild(1).gameObject.SetActive(false);
            slotsEnemy.slo6.transform.GetChild(0).transform.GetChild(0).gameObject.SetActive(false);
        }
        if (slotsEnemy.slo7.transform.childCount > 0 && slot7skillVraga != 0)
        {
            slotsEnemy.slo7.transform.GetChild(0).transform.GetChild(1).gameObject.SetActive(false);
            slotsEnemy.slo7.transform.GetChild(0).transform.GetChild(0).gameObject.SetActive(false);
        }
        if (slotsEnemy.slo8.transform.childCount > 0 && slot8skillVraga != 0)
        {
            slotsEnemy.slo8.transform.GetChild(0).transform.GetChild(1).gameObject.SetActive(false);
            slotsEnemy.slo8.transform.GetChild(0).transform.GetChild(0).gameObject.SetActive(false);
        }
        if (slotsEnemy.slo9.transform.childCount > 0 && slot9skillVraga != 0)
        {
            slotsEnemy.slo9.transform.GetChild(0).transform.GetChild(1).gameObject.SetActive(false);
            slotsEnemy.slo9.transform.GetChild(0).transform.GetChild(0).gameObject.SetActive(false);
        }

        foreach (GameObject podsvetka in skills.vsepodsvetki) // отключение подсветок
        {
            podsvetka.SetActive(false);
        }
        foreach (GameObject opisanie in skills.vseopisaniia) // отключение подсветок
        {
            opisanie.SetActive(false);
        }

    }

    public void stopMishenCaller()
    {
        CancelInvoke("MishenCaller");
    }
}
