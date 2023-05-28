using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MermaidController : MonoBehaviour
{
    public SliderController slidero;
    public music music;
    public DistanceToCheckpoint distancePoints;
    public Levels leveler;
    public ConfirmScreen podtverjdenie;
    public BattleScreen battleModeVisibility;
    public battlefinal resulter;
    public GenController gens;
    public PlayerController player;
    public SkillsController skills;

    public GameObject podrusi;
    public GameObject presents;
    public GameObject liliis;
    public GameObject scroller;

    public AudioSource swipeup;
    public AudioSource swipedown;

    // �����
    private Color32 normalcolor;
    private Color32 transpcolor;
    public GameObject liliaud1;
    public GameObject liliaud2;
    public GameObject liliaud3;
    public GameObject liliacamen1;
    public GameObject liliacamen2;
    public GameObject liliacamen3;
    public GameObject liliacamen4;
    public GameObject liliacamen5;
    public GameObject liliacamen6;
    public GameObject liliacamen1illusion;
    public GameObject liliacamen2illusion;
    public GameObject liliacamen3illusion;
    public GameObject liliacamen4illusion;
    public GameObject liliacamen5illusion;
    public GameObject liliacamen6illusion;

    private bool notnow;
    public Vector2 startTouchPosition, endTouchPosition;
    [SerializeField]
    public GameObject mermaidButton; // ������ �� ������� ������
    public GameObject garemBack; // ��� ��� ���������
    public GameObject mermaidButtonDescription; // ��� ��� ������ ������

    public float mermaids; // ������� ������� � ������ ������
    public GameObject mermaidButtonImitator; // ������ �� ������� ������
    public bool prizpovestka;

    // ����� ��� ������ ������� ��� ����� ������� (0 ��� 1)
    public float pAlissaMermaid; //9
    public float pAsceaMermaid; //29
    public float pAbbetaMermaid; //11
    public float pBabilaMermaid; //17
    public float pBatizaMermaid; //2
    public float pBentaMermaid; //8
    public float pCelliseeaMermaid; //41
    public float pCirrataMermaid;  //3
    public float pDemosaMermaid;  //46
    public float pEchinaMermaid; //21
    public float pEkhiraMermaid; //38
    public float pGalanaMermaid; //34
    public float pGoloraMermaid; //48
    public float pGrenaMermaid; //25
    public float pHadeeaMermaid; //45
    public float pHeethaMermaid; //19
    public float pHioaMermaid; //33
    public float pKhirondaMermaid; //44
    public float pKoryphaMermaid; //26
    public float pKrideiaMermaid; //1
    public float pLataMermaid; //35
    public float pLihetaMermaid; //16
    public float pMariusaMermaid; //40
    public float pMiktaMermaid; //27
    public float pNeminaMermaid; //7
    public float pNerrelidaMermaid; //47
    public float pNophoraMermaid; //28
    public float pPareedaMermaid; //32
    public float pPasteraMermaid; //13
    public float pPhanosaMermaid; //22
    public float pPharnaMermaid; //5
    public float pPhiuaMermaid; //10
    public float pPhobelaMermaid; //12
    public float pPlogaMermaid; //4
    public float pPopmpaMermaid; //14
    public float pProktaMermaid; //31
    public float pRagoaMermaid; //37
    public float pRoidaMermaid; //39
    public float pSactinaMermaid; //18
    public float pSciphaMermaid; //36
    public float pSothetaMermaid; //20
    public float pThanaidaMermaid; //42
    public float pThemumaMermaid; //43
    public float pTheusaMermaid; //23
    public float pTkharaMermaid; //30
    public float pTopelaMermaid; //15
    public float pTyphlonaMermaid; //6
    public float pZemaMermaid; //24

    // ����� ������ ������� ��� ����������� � ��������� � ������� ��������� �����
    public float herPosition1;
    public float herPosition2;
    public float herPosition3;
    public float herPosition4;
    public float herPosition5;
    public float herPosition6;
    [SerializeField] private float herPositionPresent;

    // ��������� ������� ���������; ����� �������������, ��������� = 0
    public bool mermPosition1 = false;
    public bool mermPosition2 = false;
    public bool mermPosition3 = false;
    public bool mermPosition4 = false;
    public bool mermPosition5 = false;
    public bool mermPosition6 = false;

    // �����
    public GameObject mermPlace1;
    public GameObject mermPlace2;
    public GameObject mermPlace3;
    public GameObject mermPlace4;
    public GameObject mermPlace5;
    public GameObject mermPlace6;


    // ��������� ������
    public GameObject mermPlace1Podsvetka;
    public GameObject mermPlace2Podsvetka;
    public GameObject mermPlace3Podsvetka;
    public GameObject mermPlace4Podsvetka;
    public GameObject mermPlace5Podsvetka;
    public GameObject mermPlace6Podsvetka;

    // ������� ������
    public GameObject mermPlace1Ramka;
    public GameObject mermPlace2Ramka;
    public GameObject mermPlace3Ramka;
    public GameObject mermPlace4Ramka;
    public GameObject mermPlace5Ramka;
    public GameObject mermPlace6Ramka;

    // ����������� �����
    public GameObject mermPlace3Block;
    public GameObject mermPlace4Block;
    public GameObject mermPlace5Block;
    public GameObject mermPlace6Block;

    // ��� ����
    public GameObject Statocyst;
    public GameObject Hydropora;
    public GameObject Osmolit;
    public GameObject Lipid;
    public GameObject Krioprotector;
    public GameObject Gigantizm;
    public GameObject Sliz;
    public GameObject Pancer;
    public GameObject Echolocatia;
    public GameObject Hemoreceptor;
    public GameObject Photoreceptor;
    public GameObject Mechanoreceptor;
    public GameObject Electroreceptor;
    public GameObject RedPigment;
    public GameObject Prozrachnost;
    public GameObject ChernyyPigment;
    public GameObject Mimicria;
    public GameObject Luminiscencia;
    public GameObject Toxiny;
    public GameObject Regeneration;
    public GameObject Evisceration;
    public GameObject Pedicellariy;
    public GameObject Prisosky;
    public GameObject ChernMeshok;
    public GameObject Cuvierovi;
    public GameObject Colloblasty;
    public GameObject Cirri;
    public GameObject Plavniki;
    public GameObject Immunitet;
    public GameObject Zuby;
    public GameObject DopPolost;
    public GameObject DopEnergia;
    public GameObject Pheromones;
    public GameObject Degradation;
    public GameObject UskorennoeRazvitie;
    public GameObject Magnetic;


    // ����� � ������
    public GameObject camen1;
    public GameObject camen2;
    public GameObject camen3;
    public GameObject camen4;
    public GameObject camen5;
    public GameObject camen6;
    public GameObject priz1;
    public GameObject priz2;
    public GameObject priz3;
    public GameObject priz4;
    public GameObject priz5;
    public GameObject priz6;
    public bool prizPosition1 = false;
    public bool prizPosition2 = false;
    public bool prizPosition3 = false;
    public bool prizPosition4 = false;
    public bool prizPosition5 = false;
    public bool prizPosition6 = false;

    // ������ ����� �������������
    public GameObject confirmGaremBack;
    public GameObject presentGaremBack;
    public Text presentGaremText;
    public Text presentGaremText2;
    public Text presentGaremText3;
    public GameObject place1;
    public GameObject place2;
    public GameObject presentGaremYes;
    private float moveInput;
    public bool izgnanie = false;
    public bool love = false;
    public float udelenie;
    public float defaultudelenie;
    public int randomGenIkornyy;
    public int genPlace1;
    public int genPlace2;
    public GameObject presentGaremIkra;
    public Text bonusikraGaremText;

    public string rusalkaName;

    public Image liliacomp;
    public Image liliacomp2;
    public Image liliacomp3;

    void Start()
    {
        liliis.SetActive(false);
        scroller.SetActive(false);

        normalcolor = new Color32(88, 20, 20, 255);
        transpcolor = new Color32(88, 20, 20, 0);

        presentGaremIkra.SetActive(false);
        bonusikraGaremText.text = randomGenIkornyy.ToString("F0");
        camen1.SetActive(false);
        camen2.SetActive(false);
        camen3.SetActive(false);
        camen4.SetActive(false);
        camen5.SetActive(false);
        camen6.SetActive(false);
        priz1.SetActive(false);
        priz2.SetActive(false);
        priz3.SetActive(false);
        priz4.SetActive(false);
        priz5.SetActive(false);
        priz6.SetActive(false);
        confirmGaremBack.SetActive(false);
        presentGaremBack.SetActive(false);
        garemBack.SetActive(false); // ��� ���������
        mermaidButton.SetActive(false); // ������, ���������� ���������
        mermaidButtonDescription.SetActive(false); // ���������� ��������� ���������
        mermaidButtonImitator.SetActive(false);
        mermPlace1.SetActive(false);
        mermPlace2.SetActive(false);
        mermPlace3.SetActive(false);
        mermPlace4.SetActive(false);
        mermPlace5.SetActive(false);
        mermPlace6.SetActive(false);
        mermPlace1Podsvetka.SetActive(false);
        mermPlace2Podsvetka.SetActive(false);
        mermPlace3Podsvetka.SetActive(false);
        mermPlace4Podsvetka.SetActive(false);
        mermPlace5Podsvetka.SetActive(false);
        mermPlace6Podsvetka.SetActive(false);
        mermPlace1Ramka.SetActive(false);
        mermPlace2Ramka.SetActive(false);
        mermPlace3Ramka.SetActive(false);
        mermPlace4Ramka.SetActive(false);
        mermPlace5Ramka.SetActive(false);
        mermPlace6Ramka.SetActive(false);
        mermPlace3Block.SetActive(false);
        mermPlace4Block.SetActive(false);
        mermPlace5Block.SetActive(false);
        mermPlace6Block.SetActive(false);
        defaultudelenie = 1;
        udelenie = defaultudelenie;
        herPositionPresent = 0;
        liliaud1.SetActive(true);
        liliaud2.SetActive(true);
        liliaud3.SetActive(true);
        liliacomp.color = normalcolor;
        liliacomp2.color = normalcolor;
        liliacomp3.color = normalcolor;
        liliacamen1illusion.SetActive(true);
        liliacamen2illusion.SetActive(true);
        liliacamen3illusion.SetActive(true);
        liliacamen4illusion.SetActive(true);
        liliacamen5illusion.SetActive(true);
        liliacamen6illusion.SetActive(true);
    }

    public void Update()
    {
        
        if(presentGaremBack.activeSelf == false && presents.activeSelf == false) // �� ������ ��������� �� ����� ������� �� ���
        {
            presentGaremText.text = " ";
            presentGaremText2.text = " ";
            presentGaremText3.text = " ";
            presentGaremYes.SetActive(false);
            liliacamen1illusion.SetActive(true);
            liliacamen2illusion.SetActive(true);
            liliacamen3illusion.SetActive(true);
            liliacamen4illusion.SetActive(true);
            liliacamen5illusion.SetActive(true);
            liliacamen6illusion.SetActive(true);
        }
        else if (presentGaremBack.activeSelf == true || presents.activeSelf == true && slidero.mermaidstop == false) // ���� ��� �� ������� ������, �� ��������
        {
            liliacamen1illusion.SetActive(false);
            liliacamen2illusion.SetActive(false);
            liliacamen3illusion.SetActive(false);
            liliacamen4illusion.SetActive(false);
            liliacamen5illusion.SetActive(false);
            liliacamen6illusion.SetActive(false);
        }

        if (battleModeVisibility.battleMode == true)
        {
            if (udelenie < defaultudelenie)
            {
                udelenie = defaultudelenie;
            }
            if (prizPosition1)
            {
                priz1.SetActive(true);
                prizPosition1 = false;
            }
            if (prizPosition2)
            {
                priz2.SetActive(true);
                prizPosition2 = false;
            }
            if (prizPosition3)
            {
                priz3.SetActive(true);
                prizPosition3 = false;
            }
            if (prizPosition4)
            {
                priz4.SetActive(true);
                prizPosition4 = false;
            }
            if (prizPosition5)
            {
                priz5.SetActive(true);
                prizPosition5 = false;
            }
            if (prizPosition6)
            {
                priz6.SetActive(true);
                prizPosition6 = false;
            }
        }

        if (udelenie == 1) // ��������� ������ ����
        {
            liliacomp.color = normalcolor;
            liliacomp2.color = Color.Lerp(transpcolor, liliacomp2.color, Mathf.PingPong(Time.time, 3f) / 3f);
            liliacomp3.color = Color.Lerp(transpcolor, liliacomp3.color, Mathf.PingPong(Time.time, 3f) / 3f);
        }
        else if (udelenie == 2)
        {
            liliacomp.color = normalcolor;
            liliacomp2.color = normalcolor;
            liliacomp3.color = Color.Lerp(transpcolor, liliacomp3.color, Mathf.PingPong(Time.time, 3f) / 3f);
        }
        else if (udelenie == 3)
        {
            liliacomp.color = normalcolor;
            liliacomp2.color = normalcolor;
            liliacomp3.color = normalcolor;

        }
        else if (udelenie == 0)
        {
            liliacomp.color = Color.Lerp(transpcolor, liliacomp.color, Mathf.PingPong(Time.time, 3f) / 3f);
            liliacomp2.color = Color.Lerp(transpcolor, liliacomp2.color, Mathf.PingPong(Time.time, 3f) / 3f);
            liliacomp3.color = Color.Lerp(transpcolor, liliacomp3.color, Mathf.PingPong(Time.time, 3f) / 3f);

        }
        if (prizPosition1 == true)
        {
            foreach (Transform child in liliacamen1.transform)
            {
                child.gameObject.GetComponent<Image>().color = Color.Lerp(normalcolor, child.gameObject.GetComponent<Image>().color, Mathf.PingPong(Time.time, 3f) / 3f);
            }
        }
        else
        {
            foreach (Transform child in liliacamen1.transform)
            {
                child.gameObject.GetComponent<Image>().color = transpcolor;
            }
        }
        if (prizPosition2 == true)
        {
            foreach (Transform child in liliacamen2.transform)
            {
                child.gameObject.GetComponent<Image>().color = Color.Lerp(normalcolor, child.gameObject.GetComponent<Image>().color, Mathf.PingPong(Time.time, 3f) / 3f);
            }
        }
        else
        {
            foreach (Transform child in liliacamen2.transform)
            {
                child.gameObject.GetComponent<Image>().color = transpcolor;
            }
        }
        if (prizPosition3 == true)
        {
            foreach (Transform child in liliacamen3.transform)
            {
                child.gameObject.GetComponent<Image>().color = Color.Lerp(normalcolor, child.gameObject.GetComponent<Image>().color, Mathf.PingPong(Time.time, 3f) / 3f);
            }
        }
        else
        {
            foreach (Transform child in liliacamen3.transform)
            {
                child.gameObject.GetComponent<Image>().color = transpcolor;
            }
        }
        if (prizPosition4 == true)
        {
            foreach (Transform child in liliacamen4.transform)
            {
                child.gameObject.GetComponent<Image>().color = Color.Lerp(normalcolor, child.gameObject.GetComponent<Image>().color, Mathf.PingPong(Time.time, 3f) / 3f);
            }
        }
        else
        {
            foreach (Transform child in liliacamen4.transform)
            {
                child.gameObject.GetComponent<Image>().color = transpcolor;
            }
        }
        if (prizPosition5 == true)
        {
            foreach (Transform child in liliacamen5.transform)
            {
                child.gameObject.GetComponent<Image>().color = Color.Lerp(normalcolor, child.gameObject.GetComponent<Image>().color, Mathf.PingPong(Time.time, 3f) / 3f);
            }
        }
        else
        {
            foreach (Transform child in liliacamen5.transform)
            {
                child.gameObject.GetComponent<Image>().color = transpcolor;
            }
        }
        if (prizPosition6 == true)
        {
            foreach (Transform child in liliacamen6.transform)
            {
                child.gameObject.GetComponent<Image>().color = Color.Lerp(normalcolor, child.gameObject.GetComponent<Image>().color, Mathf.PingPong(Time.time, 3f) / 3f);
            }
        }
        else
        {
            foreach (Transform child in liliacamen6.transform)
            {
                child.gameObject.GetComponent<Image>().color = transpcolor;
            }
        }
        if (prizpovestka && resulter.resultMode)
        {
            mermaidButtonDescription.SetActive(true);
        }



        // ���������� ������� � �������
        if (herPositionPresent > 0)
        {
            presentGaremText.text = " ";
            presentGaremText2.text = " ";
            if (leveler.languager == 0)
            {
                presentGaremText3.text = "Valuable research \ncontinues";
                presentGaremText2.text = "Selected genes can \nbe inserted after \nthe expedition";

            }
            if (leveler.languager == 1)
            {
                presentGaremText3.text = "������������ \n��� �����";
                presentGaremText2.text = "��������� ��� ����� \n�������� ��� �������� \n����� ����������";
            }
            else if (leveler.languager == 2)
            {
                presentGaremText3.text = "���������� \n�� �����";
                presentGaremText2.text = "������� ��� ����� \n��������� ��� �������� \n���� ����������";
            }
            presentGaremBack.SetActive(true);

            // ���� ������� 1 (������)
            if (herPositionPresent == 1)
            {
                genPlace1 = Random.Range(1, 8);
                switch (genPlace1)
                {
                    case 1:
                        Instantiate(Cirri, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 27;
                        break;
                    case 2:
                        Instantiate(Gigantizm, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 6;
                        break;
                    case 3:
                        Instantiate(Hemoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 10;
                        break;
                    case 4:
                        Instantiate(Mechanoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 12;
                        break;
                    case 5:
                        Instantiate(Pancer, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 8;
                        break;
                    case 6:
                        Instantiate(Pedicellariy, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 22;
                        break;
                    default:
                        Instantiate(RedPigment, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 14;
                        break;
                }
                genPlace2 = Random.Range(1, 8);
                switch (genPlace2)
                {
                    case 1:
                        Instantiate(Cirri, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 27;
                        break;
                    case 2:
                        Instantiate(Gigantizm, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 6;
                        break;
                    case 3:
                        Instantiate(Hemoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 10;
                        break;
                    case 4:
                        Instantiate(Mechanoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 12;
                        break;
                    case 5:
                        Instantiate(Pancer, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 8;
                        break;
                    case 6:
                        Instantiate(Pedicellariy, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 22;
                        break;
                    default:
                        Instantiate(RedPigment, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 14;
                        break;
                }
                randomGenIkornyy = Random.Range(10, 15);
            }

            // ���� ������� 2 �������
            if (herPositionPresent == 2)
            {
                genPlace1 = Random.Range(1, 11);
                switch (genPlace1)
                {
                    case 1:
                        Instantiate(Zuby, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 30;
                        break;
                    case 2:
                        Instantiate(Lipid, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 4;
                        break;
                    case 3:
                        Instantiate(Hemoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 10;
                        break;
                    case 4:
                        Instantiate(Mechanoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 12;
                        break;
                    case 5:
                        Instantiate(Pancer, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 8;
                        break;
                    case 6:
                        Instantiate(DopEnergia, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 32;
                        break;
                    case 7:
                        Instantiate(DopEnergia, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 32;
                        break;
                    case 8:
                        Instantiate(DopEnergia, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 32;
                        break;
                    case 9:
                        Instantiate(Lipid, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 4;
                        break;
                    default:
                        Instantiate(Lipid, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 4;
                        break;
                }
                genPlace2 = Random.Range(1, 11);
                switch (genPlace2)
                {
                    case 1:
                        Instantiate(Zuby, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 30;
                        break;
                    case 2:
                        Instantiate(Lipid, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 4;
                        break;
                    case 3:
                        Instantiate(Hemoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 10;
                        break;
                    case 4:
                        Instantiate(Mechanoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 12;
                        break;
                    case 5:
                        Instantiate(Pancer, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 8;
                        break;
                    case 6:
                        Instantiate(DopEnergia, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 32;
                        break;
                    case 7:
                        Instantiate(DopEnergia, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 32;
                        break;
                    case 8:
                        Instantiate(DopEnergia, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 32;
                        break;
                    case 9:
                        Instantiate(Lipid, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 4;
                        break;
                    default:
                        Instantiate(Lipid, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 4;
                        break;
                }
                randomGenIkornyy = 10;
            }

            // ���� ������� 3 �������
            if (herPositionPresent == 3)
            {
                genPlace1 = Random.Range(1, 9);
                switch (genPlace1)
                {
                    case 1:
                        Instantiate(RedPigment, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 14;
                        break;
                    case 2:
                        Instantiate(Prisosky, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 23;
                        break;
                    case 3:
                        Instantiate(Hemoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 10;
                        break;
                    case 4:
                        Instantiate(Mechanoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 12;
                        break;
                    case 5:
                        Instantiate(Cirri, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 27;
                        break;
                    case 6:
                        Instantiate(Plavniki, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 28;
                        break;
                    case 7:
                        Instantiate(Photoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 11;
                        break;
                    default:
                        Instantiate(Luminiscencia, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 18;
                        break;
                }
                genPlace2 = Random.Range(1, 9);
                switch (genPlace2)
                {
                    case 1:
                        Instantiate(RedPigment, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 14;
                        break;
                    case 2:
                        Instantiate(Prisosky, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 23;
                        break;
                    case 3:
                        Instantiate(Hemoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 10;
                        break;
                    case 4:
                        Instantiate(Mechanoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 12;
                        break;
                    case 5:
                        Instantiate(Cirri, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 27;
                        break;
                    case 6:
                        Instantiate(Plavniki, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 28;
                        break;
                    case 7:
                        Instantiate(Photoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 11;
                        break;
                    default:
                        Instantiate(Luminiscencia, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 18;
                        break;
                }
                randomGenIkornyy = Random.Range(1, 5);
            }

            // ���� ������� 4 �����
            if (herPositionPresent == 4)
            {
                genPlace1 = Random.Range(1, 6);
                switch (genPlace1)
                {
                    case 1:
                        Instantiate(Zuby, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 30;
                        break;
                    case 2:
                        Instantiate(ChernyyPigment, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 16;
                        break;
                    case 3:
                        Instantiate(Osmolit, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 3;
                        break;
                    case 4:
                        Instantiate(ChernyyPigment, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 16;
                        break;
                    default:
                        Instantiate(Osmolit, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 3;
                        break;
                }
                genPlace2 = Random.Range(1, 6);
                switch (genPlace2)
                {
                    case 1:
                        Instantiate(Zuby, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 30;
                        break;
                    case 2:
                        Instantiate(ChernyyPigment, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 16;
                        break;
                    case 3:
                        Instantiate(Osmolit, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 3;
                        break;
                    case 4:
                        Instantiate(ChernyyPigment, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 16;
                        break;
                    default:
                        Instantiate(Osmolit, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 3;
                        break;
                }
                randomGenIkornyy = Random.Range(1, 5);
            }

            // ���� ������� 5 �����
            if (herPositionPresent == 5)
            {
                genPlace1 = Random.Range(1, 14);
                switch (genPlace1)
                {
                    case 1:
                        Instantiate(Zuby, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 30;
                        break;
                    case 2:
                        Instantiate(Luminiscencia, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 18;
                        break;
                    case 3:
                        Instantiate(Degradation, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 34;
                        break;
                    case 4:
                        Instantiate(Mechanoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 12;
                        break;
                    case 5:
                        Instantiate(Hemoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 10;
                        break;
                    case 6:
                        Instantiate(Toxiny, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 19;
                        break;
                    case 7:
                        Instantiate(ChernyyPigment, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 16;
                        break;
                    case 8:
                        Instantiate(DopPolost, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 31;
                        break;
                    case 9:
                        Instantiate(Pheromones, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 33;
                        break;
                    case 10:
                        Instantiate(Pheromones, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 33;
                        break;
                    case 11:
                        Instantiate(Pheromones, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 33;
                        break;
                    case 12:
                        Instantiate(ChernyyPigment, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 16;
                        break;
                    default:
                        Instantiate(ChernyyPigment, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 16;
                        break;
                }
                genPlace2 = Random.Range(1, 14);
                switch (genPlace2)
                {
                    case 1:
                        Instantiate(Zuby, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 30;
                        break;
                    case 2:
                        Instantiate(Luminiscencia, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 18;
                        break;
                    case 3:
                        Instantiate(Degradation, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 34;
                        break;
                    case 4:
                        Instantiate(Mechanoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 12;
                        break;
                    case 5:
                        Instantiate(Hemoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 10;
                        break;
                    case 6:
                        Instantiate(Toxiny, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 19;
                        break;
                    case 7:
                        Instantiate(ChernyyPigment, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 16;
                        break;
                    case 8:
                        Instantiate(DopPolost, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 31;
                        break;
                    case 9:
                        Instantiate(Pheromones, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 33;
                        break;
                    case 10:
                        Instantiate(Pheromones, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 33;
                        break;
                    case 11:
                        Instantiate(Pheromones, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 33;
                        break;
                    case 12:
                        Instantiate(ChernyyPigment, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 16;
                        break;
                    default:
                        Instantiate(ChernyyPigment, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 16;
                        break;
                }
                randomGenIkornyy = Random.Range(1, 5);
            }
            // ���� ������� 6 �������
            if (herPositionPresent == 6)
            {
                genPlace1 = Random.Range(1, 9);
                switch (genPlace1)
                {
                    case 1:
                        Instantiate(Degradation, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 34;
                        break;
                    case 2:
                        Instantiate(Prozrachnost, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 15;
                        break;
                    case 3:
                        Instantiate(Pancer, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 8;
                        break;
                    case 4:
                        Instantiate(Hemoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 10;
                        break;
                    case 5:
                        Instantiate(Plavniki, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 28;
                        break;
                    case 6:
                        Instantiate(Magnetic, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 36;
                        break;
                    case 7:
                        Instantiate(Magnetic, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 36;
                        break;
                    default:
                        Instantiate(Magnetic, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 36;
                        break;

                }
                genPlace2 = Random.Range(1, 9);
                switch (genPlace2)
                {
                    case 1:
                        Instantiate(Degradation, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 34;
                        break;
                    case 2:
                        Instantiate(Prozrachnost, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 15;
                        break;
                    case 3:
                        Instantiate(Pancer, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 8;
                        break;
                    case 4:
                        Instantiate(Hemoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 10;
                        break;
                    case 5:
                        Instantiate(Plavniki, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 28;
                        break;
                    case 6:
                        Instantiate(Magnetic, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 36;
                        break;
                    case 7:
                        Instantiate(Magnetic, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 36;
                        break;
                    default:
                        Instantiate(Magnetic, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 36;
                        break;
                }
                randomGenIkornyy = Random.Range(2, 9);
            }
            // ���� ������� 7 ������
            if (herPositionPresent == 7)
            {
                genPlace1 = Random.Range(1, 8);
                switch (genPlace1)
                {
                    case 1:
                        Instantiate(Sliz, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 7;
                        break;
                    case 2:
                        Instantiate(Prozrachnost, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 15;
                        break;
                    case 3:
                        Instantiate(Cirri, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 27;
                        break;
                    case 4:
                        Instantiate(Hemoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 10;
                        break;
                    case 5:
                        Instantiate(RedPigment, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 14;
                        break;
                    case 6:
                        Instantiate(Statocyst, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 1;
                        break;
                    default:
                        Instantiate(Toxiny, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 19;
                        break;
                }
                genPlace2 = Random.Range(1, 8);
                switch (genPlace2)
                {
                    case 1:
                        Instantiate(Sliz, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 7;
                        break;
                    case 2:
                        Instantiate(Prozrachnost, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 15;
                        break;
                    case 3:
                        Instantiate(Cirri, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 27;
                        break;
                    case 4:
                        Instantiate(Hemoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 10;
                        break;
                    case 5:
                        Instantiate(RedPigment, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 14;
                        break;
                    case 6:
                        Instantiate(Statocyst, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 1;
                        break;
                    default:
                        Instantiate(Toxiny, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 19;
                        break;
                }
                randomGenIkornyy = Random.Range(1, 5);
            }
            // ���� ������� 8 �����
            if (herPositionPresent == 8)
            {
                genPlace1 = Random.Range(1, 15);
                switch (genPlace1)
                {
                    case 1:
                        Instantiate(Hydropora, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 2;
                        break;
                    case 2:
                        Instantiate(RedPigment, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 14;
                        break;
                    case 3:
                        Instantiate(Regeneration, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 20;
                        break;
                    case 4:
                        Instantiate(Pedicellariy, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 22;
                        break;
                    case 5:
                        Instantiate(Prisosky, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 23;
                        break;
                    case 6:
                        Instantiate(Hemoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 10;
                        break;
                    case 7:
                        Instantiate(Evisceration, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 21;
                        break;
                    case 8:
                        Instantiate(Toxiny, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 19;
                        break;
                    case 9:
                        Instantiate(Hydropora, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 2;
                        break;
                    case 10:
                        Instantiate(Hydropora, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 2;
                        break;
                    case 11:
                        Instantiate(Hydropora, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 2;
                        break;
                    case 12:
                        Instantiate(Evisceration, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 21;
                        break;
                    case 13:
                        Instantiate(Evisceration, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 21;
                        break;
                    default:
                        Instantiate(Evisceration, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 21;
                        break;
                }
                genPlace2 = Random.Range(1, 15);
                switch (genPlace2)
                {
                    case 1:
                        Instantiate(Hydropora, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 2;
                        break;
                    case 2:
                        Instantiate(RedPigment, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 14;
                        break;
                    case 3:
                        Instantiate(Regeneration, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 20;
                        break;
                    case 4:
                        Instantiate(Pedicellariy, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 22;
                        break;
                    case 5:
                        Instantiate(Prisosky, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 23;
                        break;
                    case 6:
                        Instantiate(Hemoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 10;
                        break;
                    case 7:
                        Instantiate(Evisceration, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 21;
                        break;
                    case 8:
                        Instantiate(Toxiny, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 19;
                        break;
                    case 9:
                        Instantiate(Hydropora, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 2;
                        break;
                    case 10:
                        Instantiate(Hydropora, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 2;
                        break;
                    case 11:
                        Instantiate(Hydropora, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 2;
                        break;
                    case 12:
                        Instantiate(Evisceration, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 21;
                        break;
                    case 13:
                        Instantiate(Evisceration, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 21;
                        break;
                    default:
                        Instantiate(Evisceration, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 21;
                        break;
                }
                randomGenIkornyy = Random.Range(1, 5);
            }
            // ���� ������� 9 ������
            if (herPositionPresent == 9)
            {
                genPlace1 = Random.Range(1, 8);
                switch (genPlace1)
                {
                    case 1:
                        Instantiate(Gigantizm, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 6;
                        break;
                    case 2:
                        Instantiate(Pedicellariy, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 22;
                        break;
                    case 3:
                        Instantiate(Statocyst, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 1;
                        break;
                    case 4:
                        Instantiate(Degradation, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 34;
                        break;
                    case 5:
                        Instantiate(Mechanoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 12;
                        break;
                    case 6:
                        Instantiate(Hemoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 10;
                        break;
                    default:
                        Instantiate(DopPolost, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 31;
                        break;
                }
                genPlace2 = Random.Range(1, 8);
                switch (genPlace2)
                {
                    case 1:
                        Instantiate(Gigantizm, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 6;
                        break;
                    case 2:
                        Instantiate(Pedicellariy, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 22;
                        break;
                    case 3:
                        Instantiate(Statocyst, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 1;
                        break;
                    case 4:
                        Instantiate(Degradation, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 34;
                        break;
                    case 5:
                        Instantiate(Mechanoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 12;
                        break;
                    case 6:
                        Instantiate(Hemoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 10;
                        break;
                    default:
                        Instantiate(DopPolost, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 31;
                        break;
                }
                randomGenIkornyy = Random.Range(1, 5);
            }
            // ���� ������� 10 ����
            if (herPositionPresent == 10)
            {
                genPlace1 = Random.Range(1, 24);
                switch (genPlace1)
                {
                    case 1:
                        Instantiate(Photoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 11;
                        break;
                    case 2:
                        Instantiate(DopPolost, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 31;
                        break;
                    case 3:
                        Instantiate(RedPigment, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 14;
                        break;
                    case 4:
                        Instantiate(Prisosky, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 23;
                        break;
                    case 5:
                        Instantiate(Regeneration, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 20;
                        break;
                    case 6:
                        Instantiate(Luminiscencia, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 18;
                        break;
                    case 7:
                        Instantiate(Hydropora, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 2;
                        break;
                    case 8:
                        Instantiate(Immunitet, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 29;
                        break;
                    case 9:
                        Instantiate(Mechanoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 12;
                        break;
                    case 10:
                        Instantiate(Toxiny, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 19;
                        break;
                    case 11:
                        Instantiate(Evisceration, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 21;
                        break;
                    case 12:
                        Instantiate(Immunitet, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 29;
                        break;
                    case 13:
                        Instantiate(Hydropora, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 2;
                        break;
                    case 14:
                        Instantiate(Evisceration, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 21;
                        break;
                    case 15:
                        Instantiate(Immunitet, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 29;
                        break;
                    case 16:
                        Instantiate(Hydropora, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 2;
                        break;
                    case 17:
                        Instantiate(Evisceration, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 21;
                        break;
                    case 18:
                        Instantiate(Immunitet, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 29;
                        break;
                    case 19:
                        Instantiate(Hydropora, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 2;
                        break;
                    case 20:
                        Instantiate(Evisceration, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 21;
                        break;
                    case 21:
                        Instantiate(Immunitet, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 29;
                        break;
                    case 22:
                        Instantiate(Hydropora, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 2;
                        break;
                    default:
                        Instantiate(Evisceration, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 21;
                        break;
                }
                genPlace2 = Random.Range(1, 24);
                switch (genPlace2)
                {
                    case 1:
                        Instantiate(Photoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 11;
                        break;
                    case 2:
                        Instantiate(DopPolost, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 31;
                        break;
                    case 3:
                        Instantiate(RedPigment, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 14;
                        break;
                    case 4:
                        Instantiate(Prisosky, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 23;
                        break;
                    case 5:
                        Instantiate(Regeneration, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 20;
                        break;
                    case 6:
                        Instantiate(Luminiscencia, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 18;
                        break;
                    case 7:
                        Instantiate(Hydropora, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 2;
                        break;
                    case 8:
                        Instantiate(Immunitet, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 29;
                        break;
                    case 9:
                        Instantiate(Mechanoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 12;
                        break;
                    case 10:
                        Instantiate(Toxiny, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 19;
                        break;
                    case 11:
                        Instantiate(Evisceration, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 21;
                        break;
                    case 12:
                        Instantiate(Immunitet, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 29;
                        break;
                    case 13:
                        Instantiate(Hydropora, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 2;
                        break;
                    case 14:
                        Instantiate(Evisceration, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 21;
                        break;
                    case 15:
                        Instantiate(Immunitet, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 29;
                        break;
                    case 16:
                        Instantiate(Hydropora, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 2;
                        break;
                    case 17:
                        Instantiate(Evisceration, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 21;
                        break;
                    case 18:
                        Instantiate(Immunitet, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 29;
                        break;
                    case 19:
                        Instantiate(Hydropora, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 2;
                        break;
                    case 20:
                        Instantiate(Evisceration, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 21;
                        break;
                    case 21:
                        Instantiate(Immunitet, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 29;
                        break;
                    case 22:
                        Instantiate(Hydropora, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 2;
                        break;
                    default:
                        Instantiate(Evisceration, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 21;
                        break;
                }
                randomGenIkornyy = Random.Range(1, 5);
            }
            // ���� ������� 11 ������
            if (herPositionPresent == 11)
            {
                genPlace1 = Random.Range(1, 8);
                switch (genPlace1)
                {
                    case 1:
                        Instantiate(Cirri, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 27;
                        break;
                    case 2:
                        Instantiate(Hemoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 10;
                        break;
                    case 3:
                        Instantiate(Degradation, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 34;
                        break;
                    case 4:
                        Instantiate(Plavniki, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 28;
                        break;
                    case 5:
                        Instantiate(Echolocatia, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 9;
                        break;
                    case 6:
                        Instantiate(Echolocatia, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 9;
                        break;
                    default:
                        Instantiate(Echolocatia, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 9;
                        break;
                }
                genPlace2 = Random.Range(1, 8);
                switch (genPlace2)
                {
                    case 1:
                        Instantiate(Cirri, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 27;
                        break;
                    case 2:
                        Instantiate(Hemoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 10;
                        break;
                    case 3:
                        Instantiate(Degradation, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 34;
                        break;
                    case 4:
                        Instantiate(Plavniki, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 28;
                        break;
                    case 5:
                        Instantiate(Echolocatia, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 9;
                        break;
                    case 6:
                        Instantiate(Echolocatia, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 9;
                        break;
                    default:
                        Instantiate(Echolocatia, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 9;
                        break;
                }
                randomGenIkornyy = Random.Range(10, 15);
            }
            // ���� ������� 12 �������
            if (herPositionPresent == 12)
            {
                genPlace1 = Random.Range(1, 5);
                switch (genPlace1)
                {
                    case 1:
                        Instantiate(Luminiscencia, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 18;
                        break;
                    case 2:
                        Instantiate(RedPigment, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 14;
                        break;
                    case 3:
                        Instantiate(Prisosky, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 23;
                        break;
                    default:
                        Instantiate(Mechanoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 12;
                        break;
                }
                genPlace2 = Random.Range(1, 5);
                switch (genPlace2)
                {
                    case 1:
                        Instantiate(Luminiscencia, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 18;
                        break;
                    case 2:
                        Instantiate(RedPigment, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 14;
                        break;
                    case 3:
                        Instantiate(Prisosky, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 23;
                        break;
                    default:
                        Instantiate(Mechanoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 12;
                        break;
                }
                randomGenIkornyy = Random.Range(1, 5);
            }
            // ���� ������� 13 ��������
            if (herPositionPresent == 13)
            {
                genPlace1 = Random.Range(1, 6);
                switch (genPlace1)
                {
                    case 1:
                        Instantiate(Cirri, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 27;
                        break;
                    case 2:
                        Instantiate(Regeneration, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 20;
                        break;
                    case 3:
                        Instantiate(Immunitet, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 29;
                        break;
                    case 4:
                        Instantiate(Photoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 11;
                        break;
                    default:
                        Instantiate(Toxiny, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 19;
                        break;
                }
                genPlace2 = Random.Range(1, 6);
                switch (genPlace2)
                {
                    case 1:
                        Instantiate(Cirri, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 27;
                        break;
                    case 2:
                        Instantiate(Regeneration, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 20;
                        break;
                    case 3:
                        Instantiate(Immunitet, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 29;
                        break;
                    case 4:
                        Instantiate(Photoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 11;
                        break;
                    default:
                        Instantiate(Toxiny, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 19;
                        break;
                }
                randomGenIkornyy = Random.Range(1, 5);
            }
            // ���� ������� 14 �����
            if (herPositionPresent == 14)
            {
                genPlace1 = Random.Range(1, 9);
                switch (genPlace1)
                {
                    case 1:
                        Instantiate(Krioprotector, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 5;
                        break;
                    case 2:
                        Instantiate(Prisosky, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 23;
                        break;
                    case 3:
                        Instantiate(Statocyst, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 1;
                        break;
                    case 4:
                        Instantiate(Photoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 11;
                        break;
                    case 5:
                        Instantiate(Mechanoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 12;
                        break;
                    case 6:
                        Instantiate(Hemoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 10;
                        break;
                    case 7:
                        Instantiate(Regeneration, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 20;
                        break;
                    default:
                        Instantiate(Sliz, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 7;
                        break;
                }
                genPlace2 = Random.Range(1, 9);
                switch (genPlace2)
                {
                    case 1:
                        Instantiate(Krioprotector, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 5;
                        break;
                    case 2:
                        Instantiate(Prisosky, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 23;
                        break;
                    case 3:
                        Instantiate(Statocyst, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 1;
                        break;
                    case 4:
                        Instantiate(Photoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 11;
                        break;
                    case 5:
                        Instantiate(Mechanoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 12;
                        break;
                    case 6:
                        Instantiate(Hemoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 10;
                        break;
                    case 7:
                        Instantiate(Regeneration, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 20;
                        break;
                    default:
                        Instantiate(Sliz, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 7;
                        break;
                }
                randomGenIkornyy = Random.Range(1, 5);
            }

            // ���� ������� 15 �������
            if (herPositionPresent == 15)
            {
                genPlace1 = Random.Range(1, 11);
                switch (genPlace1)
                {
                    case 1:
                        Instantiate(DopPolost, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 31;
                        break;
                    case 2:
                        Instantiate(Pancer, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 8;
                        break;
                    case 3:
                        Instantiate(Prisosky, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 23;
                        break;
                    case 4:
                        Instantiate(Krioprotector, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 5;
                        break;
                    case 5:
                        Instantiate(Sliz, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 7;
                        break;
                    case 6:
                        Instantiate(Statocyst, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 1;
                        break;
                    case 7:
                        Instantiate(Mechanoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 12;
                        break;
                    case 8:
                        Instantiate(Magnetic, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 36;
                        break;
                    case 9:
                        Instantiate(Magnetic, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 36;
                        break;
                    default:
                        Instantiate(Magnetic, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 36;
                        break;
                }
                genPlace2 = Random.Range(1, 11);
                switch (genPlace2)
                {
                    case 1:
                        Instantiate(DopPolost, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 31;
                        break;
                    case 2:
                        Instantiate(Pancer, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 8;
                        break;
                    case 3:
                        Instantiate(Prisosky, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 23;
                        break;
                    case 4:
                        Instantiate(Krioprotector, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 5;
                        break;
                    case 5:
                        Instantiate(Sliz, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 7;
                        break;
                    case 6:
                        Instantiate(Statocyst, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 1;
                        break;
                    case 7:
                        Instantiate(Mechanoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 12;
                        break;
                    case 8:
                        Instantiate(Magnetic, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 36;
                        break;
                    case 9:
                        Instantiate(Magnetic, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 36;
                        break;
                    default:
                        Instantiate(Magnetic, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 36;
                        break;
                }
                randomGenIkornyy = Random.Range(1, 5);
            }
            // ���� ������� 16 ������
            if (herPositionPresent == 16)
            {
                genPlace1 = Random.Range(1, 9);
                switch (genPlace1)
                {
                    case 1:
                        Instantiate(Photoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 11;
                        break;
                    case 2:
                        Instantiate(Sliz, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 7;
                        break;
                    case 3:
                        Instantiate(Plavniki, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 28;
                        break;
                    case 4:
                        Instantiate(Zuby, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 30;
                        break;
                    case 5:
                        Instantiate(Toxiny, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 19;
                        break;
                    case 6:
                        Instantiate(Magnetic, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 36;
                        break;
                    case 7:
                        Instantiate(Magnetic, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 36;
                        break;
                    default:
                        Instantiate(Magnetic, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 36;
                        break;
                }
                genPlace2 = Random.Range(1, 9);
                switch (genPlace2)
                {
                    case 1:
                        Instantiate(Photoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 11;
                        break;
                    case 2:
                        Instantiate(Sliz, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 7;
                        break;
                    case 3:
                        Instantiate(Plavniki, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 28;
                        break;
                    case 4:
                        Instantiate(Zuby, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 30;
                        break;
                    case 5:
                        Instantiate(Toxiny, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 19;
                        break;
                    case 6:
                        Instantiate(Magnetic, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 36;
                        break;
                    case 7:
                        Instantiate(Magnetic, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 36;
                        break;
                    default:
                        Instantiate(Magnetic, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 36;
                        break;
                }
                randomGenIkornyy = Random.Range(1, 5);
            }
            // ���� ������� 17 ������
            if (herPositionPresent == 17)
            {
                genPlace1 = Random.Range(1, 14);
                switch (genPlace1)
                {
                    case 1:
                        Instantiate(Gigantizm, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 6;
                        break;
                    case 2:
                        Instantiate(RedPigment, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 14;
                        break;
                    case 3:
                        Instantiate(Sliz, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 7;
                        break;
                    case 4:
                        Instantiate(Prisosky, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 23;
                        break;
                    case 5:
                        Instantiate(Luminiscencia, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 18;
                        break;
                    case 6:
                        Instantiate(Mechanoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 12;
                        break;
                    case 7:
                        Instantiate(Hemoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 10;
                        break;
                    case 8:
                        Instantiate(Photoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 11;
                        break;
                    case 9:
                        Instantiate(Statocyst, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 1;
                        break;
                    case 10:
                        Instantiate(Immunitet, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 29;
                        break;
                    case 11:
                        Instantiate(Immunitet, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 29;
                        break;
                    case 12:
                        Instantiate(Immunitet, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 29;
                        break;
                    default:
                        Instantiate(Immunitet, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 29;
                        break;
                }
                genPlace2 = Random.Range(1, 14);
                switch (genPlace2)
                {
                    case 1:
                        Instantiate(Gigantizm, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 6;
                        break;
                    case 2:
                        Instantiate(RedPigment, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 14;
                        break;
                    case 3:
                        Instantiate(Sliz, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 7;
                        break;
                    case 4:
                        Instantiate(Prisosky, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 23;
                        break;
                    case 5:
                        Instantiate(Luminiscencia, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 18;
                        break;
                    case 6:
                        Instantiate(Mechanoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 12;
                        break;
                    case 7:
                        Instantiate(Hemoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 10;
                        break;
                    case 8:
                        Instantiate(Photoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 11;
                        break;
                    case 9:
                        Instantiate(Statocyst, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 1;
                        break;
                    case 10:
                        Instantiate(Immunitet, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 29;
                        break;
                    case 11:
                        Instantiate(Immunitet, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 29;
                        break;
                    case 12:
                        Instantiate(Immunitet, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 29;
                        break;
                    default:
                        Instantiate(Immunitet, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 29;
                        break;
                }
                randomGenIkornyy = Random.Range(1, 5);
            }

            // ���� ������� 18 �������
            if (herPositionPresent == 18)
            {
                genPlace1 = Random.Range(1, 11);
                switch (genPlace1)
                {
                    case 1:
                        Instantiate(Degradation, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 34;
                        break;
                    case 2:
                        Instantiate(Mechanoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 12;
                        break;
                    case 3:
                        Instantiate(Hemoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 10;
                        break;
                    case 4:
                        Instantiate(Krioprotector, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 5;
                        break;
                    case 5:
                        Instantiate(UskorennoeRazvitie, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 35;
                        break;
                    case 6:
                        Instantiate(Osmolit, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 3;
                        break;
                    case 7:
                        Instantiate(UskorennoeRazvitie, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 35;
                        break;
                    case 8:
                        Instantiate(Osmolit, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 3;
                        break;
                    case 9:
                        Instantiate(UskorennoeRazvitie, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 35;
                        break;
                    default:
                        Instantiate(Osmolit, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 3;
                        break;
                }
                genPlace2 = Random.Range(1, 11);
                switch (genPlace2)
                {
                    case 1:
                        Instantiate(Degradation, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 34;
                        break;
                    case 2:
                        Instantiate(Mechanoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 12;
                        break;
                    case 3:
                        Instantiate(Hemoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 10;
                        break;
                    case 4:
                        Instantiate(Krioprotector, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 5;
                        break;
                    case 5:
                        Instantiate(UskorennoeRazvitie, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 35;
                        break;
                    case 6:
                        Instantiate(Osmolit, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 3;
                        break;
                    case 7:
                        Instantiate(UskorennoeRazvitie, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 35;
                        break;
                    case 8:
                        Instantiate(Osmolit, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 3;
                        break;
                    case 9:
                        Instantiate(UskorennoeRazvitie, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 35;
                        break;
                    default:
                        Instantiate(Osmolit, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 3;
                        break;
                }
                randomGenIkornyy = Random.Range(1, 10);
            }
            // ���� ������� 19 ����
            if (herPositionPresent == 19)
            {
                genPlace1 = Random.Range(1, 7);
                switch (genPlace1)
                {
                    case 1:
                        Instantiate(Pancer, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 8;
                        break;
                    case 2:
                        Instantiate(Degradation, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 34;
                        break;
                    case 3:
                        Instantiate(Mechanoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 12;
                        break;
                    case 4:
                        Instantiate(Hemoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 10;
                        break;
                    case 5:
                        Instantiate(Photoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 11;
                        break;
                    default:
                        Instantiate(RedPigment, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 14;
                        break;
                }
                genPlace2 = Random.Range(1, 7);
                switch (genPlace2)
                {
                    case 1:
                        Instantiate(Pancer, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 8;
                        break;
                    case 2:
                        Instantiate(Degradation, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 34;
                        break;
                    case 3:
                        Instantiate(Mechanoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 12;
                        break;
                    case 4:
                        Instantiate(Hemoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 10;
                        break;
                    case 5:
                        Instantiate(Photoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 11;
                        break;
                    default:
                        Instantiate(RedPigment, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 14;
                        break;
                }
                randomGenIkornyy = Random.Range(10, 15);
            }
            // ���� ������� 20 ������
            if (herPositionPresent == 20)
            {
                genPlace1 = Random.Range(1, 10);
                switch (genPlace1)
                {
                    case 1:
                        Instantiate(Pancer, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 8;
                        break;
                    case 2:
                        Instantiate(Degradation, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 34;
                        break;
                    case 3:
                        Instantiate(Mechanoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 12;
                        break;
                    case 4:
                        Instantiate(Hemoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 10;
                        break;
                    case 5:
                        Instantiate(Plavniki, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 28;
                        break;
                    case 6:
                        Instantiate(Zuby, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 30;
                        break;
                    case 7:
                        Instantiate(Magnetic, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 36;
                        break;
                    case 8:
                        Instantiate(Magnetic, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 36;
                        break;
                    default:
                        Instantiate(Magnetic, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 36;
                        break;
                }
                genPlace2 = Random.Range(1, 10);
                switch (genPlace2)
                {
                    case 1:
                        Instantiate(Pancer, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 8;
                        break;
                    case 2:
                        Instantiate(Degradation, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 34;
                        break;
                    case 3:
                        Instantiate(Mechanoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 12;
                        break;
                    case 4:
                        Instantiate(Hemoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 10;
                        break;
                    case 5:
                        Instantiate(Plavniki, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 28;
                        break;
                    case 6:
                        Instantiate(Zuby, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 30;
                        break;
                    case 7:
                        Instantiate(Magnetic, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 36;
                        break;
                    case 8:
                        Instantiate(Magnetic, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 36;
                        break;
                    default:
                        Instantiate(Magnetic, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 36;
                        break;
                }
                randomGenIkornyy = 15;
            }
            // ���� ������� 21 �����
            if (herPositionPresent == 21)
            {
                genPlace1 = Random.Range(1, 11);
                switch (genPlace1)
                {
                    case 1:
                        Instantiate(RedPigment, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 14;
                        break;
                    case 2:
                        Instantiate(Immunitet, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 29;
                        break;
                    case 3:
                        Instantiate(Cirri, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 27;
                        break;
                    case 4:
                        Instantiate(Pancer, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 8;
                        break;
                    case 5:
                        Instantiate(Pedicellariy, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 22;
                        break;
                    case 6:
                        Instantiate(Prisosky, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 23;
                        break;
                    case 7:
                        Instantiate(Statocyst, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 1;
                        break;
                    case 8:
                        Instantiate(Mechanoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 12;
                        break;
                    case 9:
                        Instantiate(Photoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 10;
                        break;
                    default:
                        Instantiate(Zuby, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 30;
                        break;
                }
                genPlace2 = Random.Range(1, 11);
                switch (genPlace2)
                {
                    case 1:
                        Instantiate(RedPigment, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 14;
                        break;
                    case 2:
                        Instantiate(Immunitet, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 29;
                        break;
                    case 3:
                        Instantiate(Cirri, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 27;
                        break;
                    case 4:
                        Instantiate(Pancer, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 8;
                        break;
                    case 5:
                        Instantiate(Pedicellariy, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 22;
                        break;
                    case 6:
                        Instantiate(Prisosky, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 23;
                        break;
                    case 7:
                        Instantiate(Statocyst, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 1;
                        break;
                    case 8:
                        Instantiate(Mechanoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 12;
                        break;
                    case 9:
                        Instantiate(Photoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 10;
                        break;
                    default:
                        Instantiate(Zuby, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 30;
                        break;
                }
                randomGenIkornyy = Random.Range(5, 15);
            }
            // ���� ������� 22 ������
            if (herPositionPresent == 22)
            {
                genPlace1 = Random.Range(1, 9);
                switch (genPlace1)
                {
                    case 1:
                        Instantiate(ChernyyPigment, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 16;
                        break;
                    case 2:
                        Instantiate(RedPigment, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 14;
                        break;
                    case 3:
                        Instantiate(Cirri, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 27;
                        break;
                    case 4:
                        Instantiate(Sliz, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 7;
                        break;
                    case 5:
                        Instantiate(Prisosky, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 23;
                        break;
                    case 6:
                        Instantiate(Pedicellariy, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 22;
                        break;
                    case 7:
                        Instantiate(ChernyyPigment, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 16;
                        break;
                    default:
                        Instantiate(ChernyyPigment, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 16;
                        break;
                }
                genPlace2 = Random.Range(1, 9);
                switch (genPlace2)
                {
                    case 1:
                        Instantiate(ChernyyPigment, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 16;
                        break;
                    case 2:
                        Instantiate(RedPigment, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 14;
                        break;
                    case 3:
                        Instantiate(Cirri, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 27;
                        break;
                    case 4:
                        Instantiate(Sliz, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 7;
                        break;
                    case 5:
                        Instantiate(Prisosky, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 23;
                        break;
                    case 6:
                        Instantiate(Pedicellariy, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 22;
                        break;
                    case 7:
                        Instantiate(ChernyyPigment, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 16;
                        break;
                    default:
                        Instantiate(ChernyyPigment, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 16;
                        break;
                }
                randomGenIkornyy = Random.Range(1, 10);
            }
            // ���� ������� 23 �����
            if (herPositionPresent == 23)
            {
                genPlace1 = Random.Range(1, 14);
                switch (genPlace1)
                {
                    case 1:
                        Instantiate(Sliz, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 7;
                        break;
                    case 2:
                        Instantiate(Plavniki, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 28;
                        break;
                    case 3:
                        Instantiate(Prisosky, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 23;
                        break;
                    case 4:
                        Instantiate(RedPigment, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 14;
                        break;
                    case 5:
                        Instantiate(Pancer, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 8;
                        break;
                    case 6:
                        Instantiate(DopPolost, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 31;
                        break;
                    case 7:
                        Instantiate(Mimicria, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 17;
                        break;
                    case 8:
                        Instantiate(Mechanoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 12;
                        break;
                    case 9:
                        Instantiate(Hemoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 10;
                        break;
                    case 10:
                        Instantiate(Photoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 11;
                        break;
                    case 11:
                        Instantiate(Mimicria, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 17;
                        break;
                    case 12:
                        Instantiate(Mimicria, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 17;
                        break;
                    default:
                        Instantiate(Mimicria, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 17;
                        break;
                }
                genPlace2 = Random.Range(1, 14);
                switch (genPlace2)
                {
                    case 1:
                        Instantiate(Sliz, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 7;
                        break;
                    case 2:
                        Instantiate(Plavniki, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 28;
                        break;
                    case 3:
                        Instantiate(Prisosky, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 23;
                        break;
                    case 4:
                        Instantiate(RedPigment, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 14;
                        break;
                    case 5:
                        Instantiate(Pancer, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 8;
                        break;
                    case 6:
                        Instantiate(DopPolost, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 31;
                        break;
                    case 7:
                        Instantiate(Mimicria, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 17;
                        break;
                    case 8:
                        Instantiate(Mechanoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 12;
                        break;
                    case 9:
                        Instantiate(Hemoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 10;
                        break;
                    case 10:
                        Instantiate(Photoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 11;
                        break;
                    case 11:
                        Instantiate(Mimicria, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 17;
                        break;
                    case 12:
                        Instantiate(Mimicria, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 17;
                        break;
                    default:
                        Instantiate(Mimicria, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 17;
                        break;
                }
                randomGenIkornyy = Random.Range(1, 5);
            }
            // ���� ������� 24 ����
            if (herPositionPresent == 24)
            {
                genPlace1 = Random.Range(1, 8);
                switch (genPlace1)
                {
                    case 1:
                        Instantiate(Sliz, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 7;
                        break;
                    case 2:
                        Instantiate(Regeneration, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 20;
                        break;
                    case 3:
                        Instantiate(Evisceration, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 21;
                        break;
                    case 4:
                        Instantiate(RedPigment, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 14;
                        break;
                    case 5:
                        Instantiate(Mechanoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 12;
                        break;
                    case 6:
                        Instantiate(Evisceration, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 21;
                        break;
                    default:
                        Instantiate(Evisceration, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 21;
                        break;
                }
                genPlace2 = Random.Range(1, 8);
                switch (genPlace2)
                {
                    case 1:
                        Instantiate(Sliz, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 7;
                        break;
                    case 2:
                        Instantiate(Regeneration, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 20;
                        break;
                    case 3:
                        Instantiate(Evisceration, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 21;
                        break;
                    case 4:
                        Instantiate(RedPigment, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 14;
                        break;
                    case 5:
                        Instantiate(Mechanoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 12;
                        break;
                    case 6:
                        Instantiate(Evisceration, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 21;
                        break;
                    default:
                        Instantiate(Evisceration, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 21;
                        break;
                }
                randomGenIkornyy = Random.Range(1, 5);
            }
            // ���� ������� 25 �����
            if (herPositionPresent == 25)
            {
                genPlace1 = Random.Range(1, 13);
                switch (genPlace1)
                {
                    case 1:
                        Instantiate(Hemoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 10;
                        break;
                    case 2:
                        Instantiate(Electroreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 13;
                        break;
                    case 3:
                        Instantiate(Mechanoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 12;
                        break;
                    case 4:
                        Instantiate(Zuby, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 30;
                        break;
                    case 5:
                        Instantiate(Plavniki, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 28;
                        break;
                    case 6:
                        Instantiate(Photoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 11;
                        break;
                    case 7:
                        Instantiate(Pancer, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 8;
                        break;
                    case 8:
                        Instantiate(Luminiscencia, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 18;
                        break;
                    case 9:
                        Instantiate(Electroreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 13;
                        break;
                    case 10:
                        Instantiate(Electroreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 13;
                        break;
                    case 11:
                        Instantiate(Electroreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 13;
                        break;
                    default:
                        Instantiate(Electroreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 13;
                        break;
                }
                genPlace2 = Random.Range(1, 13);
                switch (genPlace2)
                {
                    case 1:
                        Instantiate(Hemoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 10;
                        break;
                    case 2:
                        Instantiate(Electroreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 13;
                        break;
                    case 3:
                        Instantiate(Mechanoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 12;
                        break;
                    case 4:
                        Instantiate(Zuby, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 30;
                        break;
                    case 5:
                        Instantiate(Plavniki, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 28;
                        break;
                    case 6:
                        Instantiate(Photoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 11;
                        break;
                    case 7:
                        Instantiate(Pancer, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 8;
                        break;
                    case 8:
                        Instantiate(Luminiscencia, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 18;
                        break;
                    case 9:
                        Instantiate(Electroreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 13;
                        break;
                    case 10:
                        Instantiate(Electroreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 13;
                        break;
                    case 11:
                        Instantiate(Electroreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 13;
                        break;
                    default:
                        Instantiate(Electroreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 13;
                        break;
                }
                randomGenIkornyy = Random.Range(5, 15);
            }
            // ���� ������� 27 �����
            if (herPositionPresent == 27)
            {
                genPlace1 = Random.Range(1, 7);
                switch (genPlace1)
                {
                    case 1:
                        Instantiate(Plavniki, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 28;
                        break;
                    case 2:
                        Instantiate(Hemoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 10;
                        break;
                    case 3:
                        Instantiate(Pancer, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 8;
                        break;
                    case 4:
                        Instantiate(Mechanoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 12;
                        break;
                    case 5:
                        Instantiate(Zuby, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 30;
                        break;
                    default:
                        Instantiate(Degradation, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 34;
                        break;
                }
                genPlace2 = Random.Range(1, 7);
                switch (genPlace2)
                {
                    case 1:
                        Instantiate(Plavniki, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 28;
                        break;
                    case 2:
                        Instantiate(Hemoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 10;
                        break;
                    case 3:
                        Instantiate(Pancer, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 8;
                        break;
                    case 4:
                        Instantiate(Mechanoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 12;
                        break;
                    case 5:
                        Instantiate(Zuby, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 30;
                        break;
                    default:
                        Instantiate(Degradation, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 34;
                        break;
                }
                randomGenIkornyy = 10;
            }
            // ���� ������� 28 ������
            if (herPositionPresent == 28)
            {
                genPlace1 = Random.Range(1, 19);
                switch (genPlace1)
                {
                    case 1:
                        Instantiate(Sliz, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 7;
                        break;
                    case 2:
                        Instantiate(Regeneration, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 20;
                        break;
                    case 3:
                        Instantiate(Mechanoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 12;
                        break;
                    case 4:
                        Instantiate(Hemoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 10;
                        break;
                    case 5:
                        Instantiate(Prisosky, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 23;
                        break;
                    case 6:
                        Instantiate(Colloblasty, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 26;
                        break;
                    case 7:
                        Instantiate(Statocyst, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 1;
                        break;
                    case 8:
                        Instantiate(RedPigment, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 14;
                        break;
                    case 9:
                        Instantiate(ChernMeshok, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 24;
                        break;
                    case 10:
                        Instantiate(Degradation, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 34;
                        break;
                    case 11:
                        Instantiate(ChernMeshok, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 24;
                        break;
                    case 12:
                        Instantiate(ChernMeshok, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 24;
                        break;
                    case 13:
                        Instantiate(ChernMeshok, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 24;
                        break;
                    case 14:
                        Instantiate(ChernMeshok, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 24;
                        break;
                    case 15:
                        Instantiate(Colloblasty, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 26;
                        break;
                    case 16:
                        Instantiate(Colloblasty, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 26;
                        break;
                    case 17:
                        Instantiate(Colloblasty, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 26;
                        break;
                    default:
                        Instantiate(Colloblasty, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 26;
                        break;
                }
                genPlace2 = Random.Range(1, 19);
                switch (genPlace2)
                {
                    case 1:
                        Instantiate(Sliz, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 7;
                        break;
                    case 2:
                        Instantiate(Regeneration, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 20;
                        break;
                    case 3:
                        Instantiate(Mechanoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 12;
                        break;
                    case 4:
                        Instantiate(Hemoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 10;
                        break;
                    case 5:
                        Instantiate(Prisosky, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 23;
                        break;
                    case 6:
                        Instantiate(Colloblasty, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 26;
                        break;
                    case 7:
                        Instantiate(Statocyst, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 1;
                        break;
                    case 8:
                        Instantiate(RedPigment, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 14;
                        break;
                    case 9:
                        Instantiate(ChernMeshok, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 24;
                        break;
                    case 10:
                        Instantiate(Degradation, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 34;
                        break;
                    case 11:
                        Instantiate(ChernMeshok, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 24;
                        break;
                    case 12:
                        Instantiate(ChernMeshok, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 24;
                        break;
                    case 13:
                        Instantiate(ChernMeshok, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 24;
                        break;
                    case 14:
                        Instantiate(ChernMeshok, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 24;
                        break;
                    case 15:
                        Instantiate(Colloblasty, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 26;
                        break;
                    case 16:
                        Instantiate(Colloblasty, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 26;
                        break;
                    case 17:
                        Instantiate(Colloblasty, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 26;
                        break;
                    default:
                        Instantiate(Colloblasty, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 26;
                        break;
                }
                randomGenIkornyy = Random.Range(1, 5);
            }
            // ���� ������� 29 �����
            if (herPositionPresent == 29)
            {
                genPlace1 = Random.Range(1, 12);
                switch (genPlace1)
                {
                    case 1:
                        Instantiate(Toxiny, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 19;
                        break;
                    case 2:
                        Instantiate(Pancer, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 8;
                        break;
                    case 3:
                        Instantiate(Immunitet, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 29;
                        break;
                    case 4:
                        Instantiate(Regeneration, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 20;
                        break;
                    case 5:
                        Instantiate(UskorennoeRazvitie, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 35;
                        break;
                    case 6:
                        Instantiate(RedPigment, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 14;
                        break;
                    case 7:
                        Instantiate(DopPolost, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 31;
                        break;
                    case 8:
                        Instantiate(Statocyst, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 1;
                        break;
                    case 9:
                        Instantiate(UskorennoeRazvitie, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 35;
                        break;
                    case 10:
                        Instantiate(UskorennoeRazvitie, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 35;
                        break;
                    default:
                        Instantiate(UskorennoeRazvitie, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 35;
                        break;
                }
                genPlace2 = Random.Range(1, 12);
                switch (genPlace2)
                {
                    case 1:
                        Instantiate(Toxiny, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 19;
                        break;
                    case 2:
                        Instantiate(Pancer, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 8;
                        break;
                    case 3:
                        Instantiate(Immunitet, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 29;
                        break;
                    case 4:
                        Instantiate(Regeneration, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 20;
                        break;
                    case 5:
                        Instantiate(UskorennoeRazvitie, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 35;
                        break;
                    case 6:
                        Instantiate(RedPigment, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 14;
                        break;
                    case 7:
                        Instantiate(DopPolost, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 31;
                        break;
                    case 8:
                        Instantiate(Statocyst, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 1;
                        break;
                    case 9:
                        Instantiate(UskorennoeRazvitie, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 35;
                        break;
                    case 10:
                        Instantiate(UskorennoeRazvitie, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 35;
                        break;
                    default:
                        Instantiate(UskorennoeRazvitie, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 35;
                        break;
                }
                randomGenIkornyy = Random.Range(1, 5);
            }
            // ���� ������� 30 �����
            if (herPositionPresent == 30)
            {
                genPlace1 = Random.Range(1, 7);
                switch (genPlace1)
                {
                    case 1:
                        Instantiate(RedPigment, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 14;
                        break;
                    case 2:
                        Instantiate(Toxiny, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 19;
                        break;
                    case 3:
                        Instantiate(Statocyst, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 1;
                        break;
                    case 4:
                        Instantiate(Prisosky, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 23;
                        break;
                    case 5:
                        Instantiate(Prozrachnost, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 15;
                        break;
                    default:
                        Instantiate(Sliz, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 7;
                        break;
                }
                genPlace2 = Random.Range(1, 7);
                switch (genPlace2)
                {
                    case 1:
                        Instantiate(RedPigment, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 14;
                        break;
                    case 2:
                        Instantiate(Toxiny, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 19;
                        break;
                    case 3:
                        Instantiate(Statocyst, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 1;
                        break;
                    case 4:
                        Instantiate(Prisosky, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 23;
                        break;
                    case 5:
                        Instantiate(Prozrachnost, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 15;
                        break;
                    default:
                        Instantiate(Sliz, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 7;
                        break;
                }
                randomGenIkornyy = Random.Range(1, 5);
            }
            // ���� ������� 31 ������
            if (herPositionPresent == 31)
            {
                genPlace1 = Random.Range(1, 10);
                switch (genPlace1)
                {
                    case 1:
                        Instantiate(Degradation, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 34;
                        break;
                    case 2:
                        Instantiate(Sliz, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 7;
                        break;
                    case 3:
                        Instantiate(Prozrachnost, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 15;
                        break;
                    case 4:
                        Instantiate(Gigantizm, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 6;
                        break;
                    case 5:
                        Instantiate(Osmolit, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 3;
                        break;
                    case 6:
                        Instantiate(Plavniki, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 28;
                        break;
                    case 7:
                        Instantiate(Osmolit, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 3;
                        break;
                    case 8:
                        Instantiate(Osmolit, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 3;
                        break;
                    default:
                        Instantiate(Osmolit, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 3;
                        break;
                }
                genPlace2 = Random.Range(1, 10);
                switch (genPlace2)
                {
                    case 1:
                        Instantiate(Degradation, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 34;
                        break;
                    case 2:
                        Instantiate(Sliz, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 7;
                        break;
                    case 3:
                        Instantiate(Prozrachnost, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 15;
                        break;
                    case 4:
                        Instantiate(Gigantizm, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 6;
                        break;
                    case 5:
                        Instantiate(Osmolit, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 3;
                        break;
                    case 6:
                        Instantiate(Plavniki, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 28;
                        break;
                    case 7:
                        Instantiate(Osmolit, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 3;
                        break;
                    case 8:
                        Instantiate(Osmolit, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 3;
                        break;
                    default:
                        Instantiate(Osmolit, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 3;
                        break;
                }
                randomGenIkornyy = Random.Range(5, 15);
            }
            // ���� ������� 32 ������
            if (herPositionPresent == 32)
            {
                genPlace1 = Random.Range(1, 10);
                switch (genPlace1)
                {
                    case 1:
                        Instantiate(Degradation, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 34;
                        break;
                    case 2:
                        Instantiate(Sliz, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 7;
                        break;
                    case 3:
                        Instantiate(Prozrachnost, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 15;
                        break;
                    case 4:
                        Instantiate(Gigantizm, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 6;
                        break;
                    case 5:
                        Instantiate(Osmolit, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 3;
                        break;
                    case 6:
                        Instantiate(Plavniki, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 28;
                        break;
                    case 7:
                        Instantiate(Osmolit, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 3;
                        break;
                    case 8:
                        Instantiate(Osmolit, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 3;
                        break;
                    default:
                        Instantiate(Osmolit, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 3;
                        break;
                }
                genPlace2 = Random.Range(1, 10);
                switch (genPlace2)
                {
                    case 1:
                        Instantiate(Degradation, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 34;
                        break;
                    case 2:
                        Instantiate(Sliz, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 7;
                        break;
                    case 3:
                        Instantiate(Prozrachnost, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 15;
                        break;
                    case 4:
                        Instantiate(Gigantizm, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 6;
                        break;
                    case 5:
                        Instantiate(Osmolit, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 3;
                        break;
                    case 6:
                        Instantiate(Plavniki, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 28;
                        break;
                    case 7:
                        Instantiate(Osmolit, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 3;
                        break;
                    case 8:
                        Instantiate(Osmolit, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 3;
                        break;
                    default:
                        Instantiate(Osmolit, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 3;
                        break;
                }
                randomGenIkornyy = Random.Range(5, 13);
            }
            // ���� ������� 33 ����
            if (herPositionPresent == 33)
            {
                genPlace1 = Random.Range(1, 8);
                switch (genPlace1)
                {
                    case 1:
                        Instantiate(Zuby, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 30;
                        break;
                    case 2:
                        Instantiate(Photoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 11;
                        break;
                    case 3:
                        Instantiate(Plavniki, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 28;
                        break;
                    case 4:
                        Instantiate(Sliz, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 7;
                        break;
                    case 5:
                        Instantiate(Hemoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 10;
                        break;
                    default:
                        Instantiate(Mechanoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 12;
                        break;
                }
                genPlace2 = Random.Range(1, 8);
                switch (genPlace2)
                {
                    case 1:
                        Instantiate(Zuby, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 30;
                        break;
                    case 2:
                        Instantiate(Photoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 11;
                        break;
                    case 3:
                        Instantiate(Plavniki, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 28;
                        break;
                    case 4:
                        Instantiate(Sliz, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 7;
                        break;
                    case 5:
                        Instantiate(Hemoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 10;
                        break;
                    default:
                        Instantiate(Mechanoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 12;
                        break;
                }
                randomGenIkornyy = Random.Range(10, 15);
            }
            // ���� ������� 34 ������
            if (herPositionPresent == 34)
            {
                genPlace1 = Random.Range(1, 8);
                switch (genPlace1)
                {
                    case 1:
                        Instantiate(Prisosky, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 23;
                        break;
                    case 2:
                        Instantiate(Regeneration, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 20;
                        break;
                    case 3:
                        Instantiate(RedPigment, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 14;
                        break;
                    case 4:
                        Instantiate(Toxiny, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 19;
                        break;
                    case 5:
                        Instantiate(Pancer, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 8;
                        break;
                    case 6:
                        Instantiate(Statocyst, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 1;
                        break;
                    default:
                        Instantiate(Photoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 11;
                        break;
                }
                genPlace2 = Random.Range(1, 7);
                switch (genPlace2)
                {
                    case 1:
                        Instantiate(Prisosky, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 23;
                        break;
                    case 2:
                        Instantiate(Regeneration, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 20;
                        break;
                    case 3:
                        Instantiate(RedPigment, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 14;
                        break;
                    case 4:
                        Instantiate(Toxiny, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 19;
                        break;
                    case 5:
                        Instantiate(Pancer, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 8;
                        break;
                    case 6:
                        Instantiate(Statocyst, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 1;
                        break;
                    default:
                        Instantiate(Photoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 11;
                        break;
                }
                randomGenIkornyy = Random.Range(1, 5);
            }
            // ���� ������� 35 ����
            if (herPositionPresent == 35)
            {
                genPlace1 = Random.Range(1, 5);
                switch (genPlace1)
                {
                    case 1:
                        Instantiate(Plavniki, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 28;
                        break;
                    case 2:
                        Instantiate(UskorennoeRazvitie, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 35;
                        break;
                    case 3:
                        Instantiate(Mechanoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 12;
                        break;
                    case 4:
                        Instantiate(Zuby, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 30;
                        break;
                    default:
                        Instantiate(Degradation, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 34;
                        break;
                }
                genPlace2 = Random.Range(1, 5);
                switch (genPlace2)
                {
                    case 1:
                        Instantiate(Plavniki, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 28;
                        break;
                    case 2:
                        Instantiate(UskorennoeRazvitie, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 35;
                        break;
                    case 3:
                        Instantiate(Mechanoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 12;
                        break;
                    case 4:
                        Instantiate(Zuby, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 30;
                        break;
                    default:
                        Instantiate(Degradation, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 34;
                        break;
                }
                randomGenIkornyy = 12;
            }
            // ���� ������� 36 �����
            if (herPositionPresent == 36)
            {
                genPlace1 = Random.Range(1, 10);
                switch (genPlace1)
                {
                    case 1:
                        Instantiate(Sliz, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 7;
                        break;
                    case 2:
                        Instantiate(Toxiny, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 19;
                        break;
                    case 3:
                        Instantiate(RedPigment, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 14;
                        break;
                    case 4:
                        Instantiate(Prozrachnost, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 15;
                        break;
                    case 5:
                        Instantiate(Prisosky, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 23;
                        break;
                    case 6:
                        Instantiate(Mechanoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 12;
                        break;
                    case 7:
                        Instantiate(Hemoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 10;
                        break;
                    case 8:
                        Instantiate(Photoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 11;
                        break;
                    case 9:
                        Instantiate(Statocyst, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 1;
                        break;
                    default:
                        Instantiate(Luminiscencia, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 18;
                        break;
                }
                genPlace2 = Random.Range(1, 10);
                switch (genPlace2)
                {
                    case 1:
                        Instantiate(Sliz, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 7;
                        break;
                    case 2:
                        Instantiate(Toxiny, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 19;
                        break;
                    case 3:
                        Instantiate(RedPigment, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 14;
                        break;
                    case 4:
                        Instantiate(Prozrachnost, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 15;
                        break;
                    case 5:
                        Instantiate(Prisosky, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 23;
                        break;
                    case 6:
                        Instantiate(Mechanoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 12;
                        break;
                    case 7:
                        Instantiate(Hemoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 10;
                        break;
                    case 8:
                        Instantiate(Photoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 11;
                        break;
                    case 9:
                        Instantiate(Statocyst, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 1;
                        break;
                    default:
                        Instantiate(Luminiscencia, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 18;
                        break;
                }
                randomGenIkornyy = Random.Range(1, 5);
            }
            // ���� ������� 37 �����
            if (herPositionPresent == 37)
            {
                genPlace1 = Random.Range(1, 4);
                switch (genPlace1)
                {
                    case 1:
                        Instantiate(Degradation, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 34;
                        break;
                    case 2:
                        Instantiate(Pancer, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 8;
                        break;
                    case 3:
                        Instantiate(Prisosky, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 23;
                        break;
                    default:
                        Instantiate(Statocyst, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 1;
                        break;
                }
                genPlace2 = Random.Range(1, 4);
                switch (genPlace2)
                {
                    case 1:
                        Instantiate(Degradation, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 34;
                        break;
                    case 2:
                        Instantiate(Pancer, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 8;
                        break;
                    case 3:
                        Instantiate(Prisosky, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 23;
                        break;
                    default:
                        Instantiate(Statocyst, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 1;
                        break;
                }
                randomGenIkornyy = Random.Range(1, 5);
            }
            // ���� ������� 38 �����
            if (herPositionPresent == 38)
            {
                genPlace1 = Random.Range(1, 5);
                switch (genPlace1)
                {
                    case 1:
                        Instantiate(Sliz, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 7;
                        break;
                    case 2:
                        Instantiate(Hemoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 10;
                        break;
                    default:
                        Instantiate(Statocyst, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 1;
                        break;
                }
                genPlace2 = Random.Range(1, 5);
                switch (genPlace2)
                {
                    case 1:
                        Instantiate(Sliz, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 7;
                        break;
                    case 2:
                        Instantiate(Hemoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 10;
                        break;
                    default:
                        Instantiate(Statocyst, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 1;
                        break;
                }
                randomGenIkornyy = Random.Range(1, 5);
            }
            // ���� ������� 40 �������
            if (herPositionPresent == 40)
            {
                genPlace1 = Random.Range(1, 6);
                switch (genPlace1)
                {
                    case 1:
                        Instantiate(UskorennoeRazvitie, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 35;
                        break;
                    case 2:
                        Instantiate(Gigantizm, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 6;
                        break;
                    case 3:
                        Instantiate(Toxiny, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 19;
                        break;
                    case 4:
                        Instantiate(DopPolost, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 31;
                        break;
                    default:
                        Instantiate(Degradation, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 34;
                        break;
                }
                genPlace2 = Random.Range(1, 6);
                switch (genPlace2)
                {
                    case 1:
                        Instantiate(UskorennoeRazvitie, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 35;
                        break;
                    case 2:
                        Instantiate(Gigantizm, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 6;
                        break;
                    case 3:
                        Instantiate(Toxiny, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 19;
                        break;
                    case 4:
                        Instantiate(DopPolost, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 31;
                        break;
                    default:
                        Instantiate(Degradation, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 34;
                        break;
                }
                randomGenIkornyy = Random.Range(1, 5);
            }
            // ���� ������� 41 �������
            if (herPositionPresent == 41)
            {
                genPlace1 = Random.Range(1, 8);
                switch (genPlace1)
                {
                    case 1:
                        Instantiate(Prozrachnost, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 15;
                        break;
                    case 2:
                        Instantiate(Sliz, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 7;
                        break;
                    case 3:
                        Instantiate(Mechanoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 12;
                        break;
                    case 4:
                        Instantiate(Photoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 11;
                        break;
                    case 5:
                        Instantiate(Prisosky, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 23;
                        break;
                    case 6:
                        Instantiate(Statocyst, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 1;
                        break;
                    default:
                        Instantiate(Regeneration, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 20;
                        break;
                }
                genPlace2 = Random.Range(1, 8);
                switch (genPlace2)
                {
                    case 1:
                        Instantiate(Prozrachnost, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 15;
                        break;
                    case 2:
                        Instantiate(Sliz, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 7;
                        break;
                    case 3:
                        Instantiate(Mechanoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 12;
                        break;
                    case 4:
                        Instantiate(Photoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 11;
                        break;
                    case 5:
                        Instantiate(Prisosky, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 23;
                        break;
                    case 6:
                        Instantiate(Statocyst, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 1;
                        break;
                    default:
                        Instantiate(Regeneration, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 20;
                        break;
                }
                randomGenIkornyy = Random.Range(1, 5);
            }
            // ���� ������� 42 �������
            if (herPositionPresent == 42)
            {
                genPlace1 = Random.Range(1, 5);
                switch (genPlace1)
                {
                    case 1:
                        Instantiate(Pedicellariy, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 22;
                        break;
                    case 2:
                        Instantiate(Pancer, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 8;
                        break;
                    case 3:
                        Instantiate(Mechanoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 12;
                        break;
                    default:
                        Instantiate(Photoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 11;
                        break;
                }
                genPlace2 = Random.Range(1, 5);
                switch (genPlace2)
                {
                    case 1:
                        Instantiate(Pedicellariy, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 22;
                        break;
                    case 2:
                        Instantiate(Pancer, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 8;
                        break;
                    case 3:
                        Instantiate(Mechanoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 12;
                        break;
                    default:
                        Instantiate(Photoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 11;
                        break;
                }
                randomGenIkornyy = Random.Range(1, 5);
            }
            // ���� ������� 44 �������
            if (herPositionPresent == 44)
            {
                genPlace1 = Random.Range(1, 6);
                switch (genPlace1)
                {
                    case 1:
                        Instantiate(Gigantizm, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 6;
                        break;
                    case 2:
                        Instantiate(Pancer, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 8;
                        break;
                    case 3:
                        Instantiate(Statocyst, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 1;
                        break;
                    case 4:
                        Instantiate(Mechanoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 12;
                        break;
                    default:
                        Instantiate(Photoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 11;
                        break;
                }
                genPlace2 = Random.Range(1, 6);
                switch (genPlace2)
                {
                    case 1:
                        Instantiate(Gigantizm, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 6;
                        break;
                    case 2:
                        Instantiate(Pancer, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 8;
                        break;
                    case 3:
                        Instantiate(Statocyst, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 1;
                        break;
                    case 4:
                        Instantiate(Mechanoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 12;
                        break;
                    default:
                        Instantiate(Photoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 11;
                        break;
                }
                randomGenIkornyy = Random.Range(1, 5);
            }
            // ���� ������� 46 ������
            if (herPositionPresent == 46)
            {
                genPlace1 = Random.Range(1, 8);
                switch (genPlace1)
                {
                    case 1:
                        Instantiate(Krioprotector, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 5;
                        break;
                    case 2:
                        Instantiate(Pheromones, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 33;
                        break;
                    case 3:
                        Instantiate(Sliz, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 7;
                        break;
                    case 4:
                        Instantiate(Mechanoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 12;
                        break;
                    case 5:
                        Instantiate(Hemoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 10;
                        break;
                    case 6:
                        Instantiate(Pheromones, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 33;
                        break;
                    default:
                        Instantiate(Pheromones, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 33;
                        break;
                }
                genPlace2 = Random.Range(1, 8);
                switch (genPlace2)
                {
                    case 1:
                        Instantiate(Krioprotector, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 5;
                        break;
                    case 2:
                        Instantiate(Pheromones, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 33;
                        break;
                    case 3:
                        Instantiate(Sliz, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 7;
                        break;
                    case 4:
                        Instantiate(Mechanoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 12;
                        break;
                    case 5:
                        Instantiate(Hemoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 10;
                        break;
                    case 6:
                        Instantiate(Pheromones, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 33;
                        break;
                    default:
                        Instantiate(Pheromones, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 33;
                        break;
                }
                randomGenIkornyy = Random.Range(1, 5);
            }
            // ���� ������� 47 ���������
            if (herPositionPresent == 47)
            {
                genPlace1 = Random.Range(1, 7);
                switch (genPlace1)
                {
                    case 1:
                        Instantiate(Gigantizm, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 6;
                        break;
                    case 2:
                        Instantiate(Pancer, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 8;
                        break;
                    case 3:
                        Instantiate(Photoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 11;
                        break;
                    case 4:
                        Instantiate(Mechanoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 12;
                        break;
                    case 5:
                        Instantiate(RedPigment, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 14;
                        break;
                    default:
                        Instantiate(DopPolost, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 31;
                        break;
                }
                genPlace2 = Random.Range(1, 7);
                switch (genPlace2)
                {
                    case 1:
                        Instantiate(Gigantizm, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 6;
                        break;
                    case 2:
                        Instantiate(Pancer, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 8;
                        break;
                    case 3:
                        Instantiate(Photoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 11;
                        break;
                    case 4:
                        Instantiate(Mechanoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 12;
                        break;
                    case 5:
                        Instantiate(RedPigment, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 14;
                        break;
                    default:
                        Instantiate(DopPolost, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 31;
                        break;
                }
                randomGenIkornyy = Random.Range(1, 5);
            }
            // ���� ������� 48 �������
            if (herPositionPresent == 48)
            {
                genPlace1 = Random.Range(1, 22);
                switch (genPlace1)
                {
                    case 1:
                        Instantiate(Cirri, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 27;
                        break;
                    case 2:
                        Instantiate(Regeneration, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 20;
                        break;
                    case 3:
                        Instantiate(Evisceration, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 21;
                        break;
                    case 4:
                        Instantiate(Toxiny, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 19;
                        break;
                    case 5:
                        Instantiate(Prisosky, place1.transform.position, Quaternion.identity, place1.transform);
                        genPlace1 = 23;
                        break;
                    case 6:
                        Instantiate(Cuvierovi, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 25;
                        break;
                    case 7:
                        Instantiate(RedPigment, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 14;
                        break;
                    case 8:
                        Instantiate(ChernyyPigment, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 16;
                        break;
                    case 9:
                        Instantiate(DopPolost, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 31;
                        break;
                    case 10:
                        Instantiate(Photoreceptor, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 11;
                        break;
                    case 11:
                        Instantiate(Statocyst, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 1;
                        break;

                    case 12:
                        Instantiate(Cuvierovi, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 25;
                        break;
                    case 13:
                        Instantiate(Evisceration, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 21;
                        break;
                    case 14:
                        Instantiate(ChernyyPigment, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 16;
                        break;
                    case 15:
                        Instantiate(Cuvierovi, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 25;
                        break;
                    case 16:
                        Instantiate(Evisceration, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 21;
                        break;
                    case 17:
                        Instantiate(ChernyyPigment, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 16;
                        break;
                    case 18:
                        Instantiate(Cuvierovi, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 25;
                        break;
                    case 19:
                        Instantiate(Evisceration, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 21;
                        break;
                    case 20:
                        Instantiate(ChernyyPigment, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 16;
                        break;
                    default:
                        Instantiate(Cuvierovi, place1.transform.position, Quaternion.identity, place1.transform);
                        // ��� �������� �������� �����
                        genPlace1 = 25;
                        break;
                }
                genPlace2 = Random.Range(1, 22);
                switch (genPlace2)
                {
                    case 1:
                        Instantiate(Cirri, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 27;
                        break;
                    case 2:
                        Instantiate(Regeneration, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 20;
                        break;
                    case 3:
                        Instantiate(Evisceration, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 21;
                        break;
                    case 4:
                        Instantiate(Toxiny, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 19;
                        break;
                    case 5:
                        Instantiate(Prisosky, place2.transform.position, Quaternion.identity, place2.transform);
                        genPlace2 = 23;
                        break;
                    case 6:
                        Instantiate(Cuvierovi, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 25;
                        break;
                    case 7:
                        Instantiate(RedPigment, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 14;
                        break;
                    case 8:
                        Instantiate(ChernyyPigment, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 16;
                        break;
                    case 9:
                        Instantiate(DopPolost, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 31;
                        break;
                    case 10:
                        Instantiate(Photoreceptor, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 11;
                        break;
                    case 11:
                        Instantiate(Statocyst, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 1;
                        break;

                    case 12:
                        Instantiate(Cuvierovi, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 25;
                        break;
                    case 13:
                        Instantiate(Evisceration, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 21;
                        break;
                    case 14:
                        Instantiate(ChernyyPigment, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 16;
                        break;
                    case 15:
                        Instantiate(Cuvierovi, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 25;
                        break;
                    case 16:
                        Instantiate(Evisceration, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 21;
                        break;
                    case 17:
                        Instantiate(ChernyyPigment, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 16;
                        break;
                    case 18:
                        Instantiate(Cuvierovi, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 25;
                        break;
                    case 19:
                        Instantiate(Evisceration, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 21;
                        break;
                    case 20:
                        Instantiate(ChernyyPigment, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 16;
                        break;
                    default:
                        Instantiate(Cuvierovi, place2.transform.position, Quaternion.identity, place2.transform);
                        // ��� �������� �������� �����
                        genPlace2 = 25;
                        break;
                }
                randomGenIkornyy = Random.Range(1, 5);
            }

            // ������� ����� �� ��� ����
            if (gens.pDopPolost == 3)
            {
                randomGenIkornyy += 5;
            }

            bonusikraGaremText.text = randomGenIkornyy.ToString("F0");
            presentGaremIkra.SetActive(true);
            herPositionPresent = 0;
        }

        // �������� ������, ����� ����� ��������, � ���� ��� ������ �������� ������
        if (distancePoints.distance <= 5100 || leveler.settingsMode.activeSelf == true || skills.skillsBack.activeSelf == true)
        {
            mermaidButton.SetActive(false);
            mermaidButtonImitator.SetActive(false);
        }
        if (distancePoints.distance > 5100 && leveler.settingsMode.activeSelf == false && skills.skillsBack.activeSelf == false)
        {
            mermaidButton.SetActive(true);
        }


        

        if (priz1.activeSelf == true || priz2.activeSelf == true || priz3.activeSelf == true || priz4.activeSelf == true || priz5.activeSelf == true || priz6.activeSelf == true)
        {
            prizpovestka = true;
        }
        else if (priz1.activeSelf == false && priz2.activeSelf == false && priz3.activeSelf == false && priz4.activeSelf == false && priz5.activeSelf == false && priz6.activeSelf == false)
        {
            prizpovestka = false;
            mermaidButtonDescription.SetActive(false);
        }

        if (garemBack.activeSelf == true)
        {
            liliis.SetActive(true);
            scroller.SetActive(true);
            mermPlace1.SetActive(true);
            mermPlace2.SetActive(true);
            mermPlace3.SetActive(true);
            if (podrusi.activeSelf == true)
            {
                notnow = true;
            }
            if (notnow == false || leveler.garemSize > 3)
            {
                mermPlace4.SetActive(true);
                mermPlace5.SetActive(true);
                mermPlace6.SetActive(true);
            }

            camen1.SetActive(true);
            camen2.SetActive(true);
            if (leveler.garemSize >= 3)
            {
                camen3.SetActive(true);
            }
            if (leveler.garemSize >= 4)
            {
                camen4.SetActive(true);
            }
            if (leveler.garemSize >= 5)
            {
                camen5.SetActive(true);
            }
            if (leveler.garemSize == 6)
            {
                camen6.SetActive(true);
            }
            if (mermPlace1Podsvetka.activeSelf == false)
            {
                mermPlace1Ramka.SetActive(true);
            }
            if (leveler.garemSize >= 2 && mermPlace2Podsvetka.activeSelf == false)
            {
                mermPlace2Ramka.SetActive(true);
            }
            if (leveler.garemSize >= 3 && mermPlace3Podsvetka.activeSelf == false)
            {
                mermPlace3Ramka.SetActive(true);
            }
            if (leveler.garemSize >= 4 && mermPlace4Podsvetka.activeSelf == false)
            {
                mermPlace4Ramka.SetActive(true);
            }
            if (leveler.garemSize >= 5 && mermPlace5Podsvetka.activeSelf == false)
            {
                mermPlace5Ramka.SetActive(true);
            }
            if (leveler.garemSize == 6 && mermPlace6Podsvetka.activeSelf == false)
            {
                mermPlace6Ramka.SetActive(true);
            }
            if (leveler.garemSize < 6 && (notnow == false || leveler.garemSize > 3))
            {
                mermPlace6Block.SetActive(true);
            }
            if (leveler.garemSize < 5 && (notnow == false || leveler.garemSize > 3))
            {
                mermPlace5Block.SetActive(true);
            }
            if (leveler.garemSize < 4 && (notnow == false || leveler.garemSize > 3))
            {
                mermPlace4Block.SetActive(true);
            }
            if (leveler.garemSize < 3)
            {
                mermPlace3Block.SetActive(true);
            }

        }

        // ������������� ��������
        if (confirmGaremBack.activeSelf == true && izgnanie == true)
        {
            if (podtverjdenie.podtverjdenoTapom == true)
            {
                // ��������
                if (mermPlace1Podsvetka.activeSelf == true)
                {
                    prizPosition1 = false;
                    priz1.SetActive(false);
                    mermPosition1 = false;
                    herPosition1 = 0;
                    foreach (Transform child in mermPlace1.transform)
                    {
                        Destroy(child.gameObject);
                    }
                }
                else if (mermPlace2Podsvetka.activeSelf == true)
                {
                    prizPosition2 = false;
                    priz2.SetActive(false);
                    mermPosition2 = false;
                    herPosition2 = 0;
                    foreach (Transform child in mermPlace2.transform)
                    {
                        Destroy(child.gameObject);
                    }
                }
                else if (mermPlace3Podsvetka.activeSelf == true)
                {
                    prizPosition3 = false;
                    priz3.SetActive(false);
                    mermPosition3 = false;
                    herPosition3 = 0;
                    foreach (Transform child in mermPlace3.transform)
                    {
                        Destroy(child.gameObject);
                    }
                }
                else if (mermPlace4Podsvetka.activeSelf == true)
                {
                    prizPosition4 = false;
                    priz4.SetActive(false);
                    mermPosition4 = false;
                    herPosition4 = 0;
                    foreach (Transform child in mermPlace4.transform)
                    {
                        Destroy(child.gameObject);
                    }
                }
                else if (mermPlace5Podsvetka.activeSelf == true)
                {
                    prizPosition5 = false;
                    priz5.SetActive(false);
                    mermPosition5 = false;
                    herPosition5 = 0;
                    foreach (Transform child in mermPlace5.transform)
                    {
                        Destroy(child.gameObject);
                    }
                }
                else if (mermPlace6Podsvetka.activeSelf == true)
                {
                    prizPosition6 = false;
                    priz6.SetActive(false);
                    mermPosition6 = false;
                    herPosition6 = 0;
                    foreach (Transform child in mermPlace6.transform)
                    {
                        Destroy(child.gameObject);
                    }
                }
                mermaids -= 1;
                mermPlace1Podsvetka.SetActive(false);
                mermPlace2Podsvetka.SetActive(false);
                mermPlace3Podsvetka.SetActive(false);
                mermPlace4Podsvetka.SetActive(false);
                mermPlace5Podsvetka.SetActive(false);
                mermPlace6Podsvetka.SetActive(false);
                izgnanie = false;
                confirmGaremBack.SetActive(false);
                podtverjdenie.podtverjdenoTapom = false;
                podtverjdenie.nepodtverjdenoTapom = false;
                podtverjdenie.podtverjdenoOk = false;
                podtverjdenie.confirmGaremText.text = " ";
            }
            if (podtverjdenie.nepodtverjdenoTapom == true)
            {
                izgnanie = false;
                confirmGaremBack.SetActive(false);
                podtverjdenie.podtverjdenoTapom = false;
                podtverjdenie.nepodtverjdenoTapom = false;
                podtverjdenie.podtverjdenoOk = false;
                podtverjdenie.confirmGaremText.text = " ";
            }
        }


        // ������������� �����
        if (confirmGaremBack.activeSelf == true && love == true)
        {
            if (podtverjdenie.podtverjdenoTapom == true)
            {
                // ��������
                if (mermPlace1Podsvetka.activeSelf == true)
                {
                    prizPosition1 = true;

                    udelenie -= 1;
                }
                if (mermPlace2Podsvetka.activeSelf == true)
                {
                    prizPosition2 = true;
                    udelenie -= 1;
                }
                if (mermPlace3Podsvetka.activeSelf == true)
                {
                    prizPosition3 = true;
                    udelenie -= 1;
                }
                if (mermPlace4Podsvetka.activeSelf == true)
                {
                    prizPosition4 = true;
                    udelenie -= 1;
                }
                if (mermPlace5Podsvetka.activeSelf == true)
                {
                    prizPosition5 = true;
                    udelenie -= 1;
                }
                if (mermPlace6Podsvetka.activeSelf == true)
                {
                    prizPosition6 = true;
                    udelenie -= 1;
                }
                mermPlace1Podsvetka.SetActive(false);
                mermPlace2Podsvetka.SetActive(false);
                mermPlace3Podsvetka.SetActive(false);
                mermPlace4Podsvetka.SetActive(false);
                mermPlace5Podsvetka.SetActive(false);
                mermPlace6Podsvetka.SetActive(false);
                love = false;
                confirmGaremBack.SetActive(false);
                podtverjdenie.podtverjdenoTapom = false;
                podtverjdenie.nepodtverjdenoTapom = false;
                podtverjdenie.podtverjdenoOk = false;
                podtverjdenie.confirmGaremText.text = " ";
            }
            if (podtverjdenie.nepodtverjdenoTapom == true)
            {
                love = false;
                confirmGaremBack.SetActive(false);
                podtverjdenie.podtverjdenoTapom = false;
                podtverjdenie.nepodtverjdenoTapom = false;
                podtverjdenie.podtverjdenoOk = false;
                podtverjdenie.confirmGaremText.text = " ";
            }
        }

        if ((mermPlace1Podsvetka.activeSelf == true || mermPlace2Podsvetka.activeSelf == true || mermPlace3Podsvetka.activeSelf == true || mermPlace4Podsvetka.activeSelf == true || mermPlace5Podsvetka.activeSelf == true || mermPlace6Podsvetka.activeSelf == true) && confirmGaremBack.activeSelf == false)
        {
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            {
                startTouchPosition = Input.GetTouch(0).position;
            }
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                endTouchPosition = Input.GetTouch(0).position;
                if (endTouchPosition.y > startTouchPosition.y && presentGaremBack.activeSelf == false && confirmGaremBack.activeSelf == false) // ����� �����
                {
                    swipeup.Play(0);
                    if (leveler.languager == 0)
                    {
                        podtverjdenie.confirmGaremText.text = rusalkaName + "\nLet her go?";
                    }
                    if (leveler.languager == 1)
                    {
                        podtverjdenie.confirmGaremText.text = rusalkaName + "\n��������� �?";
                    }
                    else if (leveler.languager == 2)
                    {
                        podtverjdenie.confirmGaremText.text = rusalkaName + "\n³�������� ��?";
                    }
                    podtverjdenie.podtverjdenoTapom = false;
                    podtverjdenie.nepodtverjdenoTapom = false;
                    podtverjdenie.podtverjdenoOk = false;
                    izgnanie = true;
                    confirmGaremBack.SetActive(true);
                }

                if (endTouchPosition.y < startTouchPosition.y && presentGaremBack.activeSelf == false && confirmGaremBack.activeSelf == false && resulter.resultMode == false && player.nagradoid == false) // ����� ����
                {
                    if (udelenie > 0)
                    {
                        if (mermPlace1Podsvetka.activeSelf == true && priz1.activeSelf == false)
                        {
                            swipedown.Play(0);
                            if (leveler.languager == 0)
                            {
                                podtverjdenie.confirmGaremText.text = rusalkaName + "\nPay attention to her?";
                            }
                            if (leveler.languager == 1)
                            {
                                podtverjdenie.confirmGaremText.text = rusalkaName + "\n������� �� ��������?";
                            }
                            else if (leveler.languager == 2)
                            {
                                podtverjdenie.confirmGaremText.text = rusalkaName + "\n�������� �� �����?";
                            }
                            podtverjdenie.podtverjdenoTapom = false;
                            podtverjdenie.nepodtverjdenoTapom = false;
                            podtverjdenie.podtverjdenoOk = false;
                            love = true;
                            confirmGaremBack.SetActive(true);
                        }
                        else if(mermPlace1Podsvetka.activeSelf == true && priz1.activeSelf == true)
                            {
                            poluchiPriz1();
                        }
                        if (mermPlace2Podsvetka.activeSelf == true && priz2.activeSelf == false)
                        {
                            swipedown.Play(0);
                            if (leveler.languager == 0)
                            {
                                podtverjdenie.confirmGaremText.text = rusalkaName + "\nPay attention to her?";
                            }
                            if (leveler.languager == 1)
                            {
                                podtverjdenie.confirmGaremText.text = rusalkaName + "\n������� �� ��������?";
                            }
                            else if (leveler.languager == 2)
                            {
                                podtverjdenie.confirmGaremText.text = rusalkaName + "\n�������� �� �����?";
                            }
                            podtverjdenie.podtverjdenoTapom = false;
                            podtverjdenie.nepodtverjdenoTapom = false;
                            podtverjdenie.podtverjdenoOk = false;
                            love = true;
                            confirmGaremBack.SetActive(true);
                        }
                        else if (mermPlace2Podsvetka.activeSelf == true && priz2.activeSelf == true)
                        {
                            poluchiPriz2();
                        }
                        if (mermPlace3Podsvetka.activeSelf == true && priz3.activeSelf == false)
                        {
                            swipedown.Play(0);
                            if (leveler.languager == 0)
                            {
                                podtverjdenie.confirmGaremText.text = rusalkaName + "\nPay attention to her?";
                            }
                            if (leveler.languager == 1)
                            {
                                podtverjdenie.confirmGaremText.text = rusalkaName + "\n������� �� ��������?";
                            }
                            else if (leveler.languager == 2)
                            {
                                podtverjdenie.confirmGaremText.text = rusalkaName + "\n�������� �� �����?";
                            }
                            podtverjdenie.podtverjdenoTapom = false;
                            podtverjdenie.nepodtverjdenoTapom = false;
                            podtverjdenie.podtverjdenoOk = false;
                            love = true;
                            confirmGaremBack.SetActive(true);
                        }
                        else if (mermPlace3Podsvetka.activeSelf == true && priz3.activeSelf == true)
                        {
                            poluchiPriz3();
                        }
                        if (mermPlace4Podsvetka.activeSelf == true && priz4.activeSelf == false)
                        {
                            swipedown.Play(0);
                            if (leveler.languager == 0)
                            {
                                podtverjdenie.confirmGaremText.text = rusalkaName + "\nPay attention to her?";
                            }
                            if (leveler.languager == 1)
                            {
                                podtverjdenie.confirmGaremText.text = rusalkaName + "\n������� �� ��������?";
                            }
                            else if (leveler.languager == 2)
                            {
                                podtverjdenie.confirmGaremText.text = rusalkaName + "\n�������� �� �����?";
                            }
                            podtverjdenie.podtverjdenoTapom = false;
                            podtverjdenie.nepodtverjdenoTapom = false;
                            podtverjdenie.podtverjdenoOk = false;
                            love = true;
                            confirmGaremBack.SetActive(true);
                        }
                        else if (mermPlace4Podsvetka.activeSelf == true && priz4.activeSelf == true)
                        {
                            poluchiPriz4();
                        }
                        if (mermPlace5Podsvetka.activeSelf == true && priz5.activeSelf == false)
                        {
                            swipedown.Play(0);
                            if (leveler.languager == 0)
                            {
                                podtverjdenie.confirmGaremText.text = rusalkaName + "\nPay attention to her?";
                            }
                            if (leveler.languager == 1)
                            {
                                podtverjdenie.confirmGaremText.text = rusalkaName + "\n������� �� ��������?";
                            }
                            else if (leveler.languager == 2)
                            {
                                podtverjdenie.confirmGaremText.text = rusalkaName + "\n�������� �� �����?";
                            }
                            podtverjdenie.podtverjdenoTapom = false;
                            podtverjdenie.nepodtverjdenoTapom = false;
                            podtverjdenie.podtverjdenoOk = false;
                            love = true;
                            confirmGaremBack.SetActive(true);
                        }
                        else if (mermPlace5Podsvetka.activeSelf == true && priz5.activeSelf == true)
                        {
                            poluchiPriz5();
                        }
                        if (mermPlace6Podsvetka.activeSelf == true && priz6.activeSelf == false)
                        {
                            swipedown.Play(0);
                            if (leveler.languager == 0)
                            {
                                podtverjdenie.confirmGaremText.text = rusalkaName + "\nPay attention to her?";
                            }
                            if (leveler.languager == 1)
                            {
                                podtverjdenie.confirmGaremText.text = rusalkaName + "\n������� �� ��������?";
                            }
                            else if (leveler.languager == 2)
                            {
                                podtverjdenie.confirmGaremText.text = rusalkaName + "\n�������� �� �����?";
                            }
                            podtverjdenie.podtverjdenoTapom = false;
                            podtverjdenie.nepodtverjdenoTapom = false;
                            podtverjdenie.podtverjdenoOk = false;
                            love = true;
                            confirmGaremBack.SetActive(true);
                        }
                        else if (mermPlace6Podsvetka.activeSelf == true && priz6.activeSelf == true)
                        {
                            poluchiPriz6();
                        }
                    }
                }
            }

        }

    }

    // ������� �� ������� �� ������
    public void tapMermaids()
    {
        // �������, ��� ������� ������ ��������� ���������
        if (garemBack.activeSelf == false && podtverjdenie.noteBack.activeSelf == false && podtverjdenie.confirmBack.activeSelf == false && battleModeVisibility.battleMode == false)
        {
            music.opensound.Play();
            garemBack.SetActive(true);
        }

        // ������ ��������� ���������
        else
        {
            notnow = false;
            if (garemBack.activeSelf == true && presentGaremBack.activeSelf == false && confirmGaremBack.activeSelf == false)
            {
                music.closesound.Play();
                liliis.SetActive(false);
                scroller.SetActive(false);
                camen1.SetActive(false);
                camen2.SetActive(false);
                camen3.SetActive(false);
                camen4.SetActive(false);
                camen5.SetActive(false);
                camen6.SetActive(false);
                mermPlace1Podsvetka.SetActive(false);
                mermPlace2Podsvetka.SetActive(false);
                mermPlace3Podsvetka.SetActive(false);
                mermPlace4Podsvetka.SetActive(false);
                mermPlace5Podsvetka.SetActive(false);
                mermPlace6Podsvetka.SetActive(false);
                garemBack.SetActive(false);
                mermPlace1.SetActive(false);
                mermPlace2.SetActive(false);
                mermPlace3.SetActive(false);
                mermPlace4.SetActive(false);
                mermPlace5.SetActive(false);
                mermPlace6.SetActive(false);
                mermPlace1Ramka.SetActive(false);
                mermPlace2Ramka.SetActive(false);
                mermPlace3Ramka.SetActive(false);
                mermPlace4Ramka.SetActive(false);
                mermPlace5Ramka.SetActive(false);
                mermPlace6Ramka.SetActive(false);
                mermPlace3Block.SetActive(false);
                mermPlace4Block.SetActive(false);
                mermPlace5Block.SetActive(false);
                mermPlace6Block.SetActive(false);
            }
        }


    }

    public void tapOnlyOff()
    {
        music.closesound.Play();
        notnow = false;
        liliis.SetActive(false);
        scroller.SetActive(false);
        camen1.SetActive(false);
        camen2.SetActive(false);
        camen3.SetActive(false);
        camen4.SetActive(false);
        camen5.SetActive(false);
        camen6.SetActive(false);
        mermPlace1Podsvetka.SetActive(false);
        mermPlace2Podsvetka.SetActive(false);
        mermPlace3Podsvetka.SetActive(false);
        mermPlace4Podsvetka.SetActive(false);
        mermPlace5Podsvetka.SetActive(false);
        mermPlace6Podsvetka.SetActive(false);
        garemBack.SetActive(false);
        mermPlace1.SetActive(false);
        mermPlace2.SetActive(false);
        mermPlace3.SetActive(false);
        mermPlace4.SetActive(false);
        mermPlace5.SetActive(false);
        mermPlace6.SetActive(false);
        mermPlace1Ramka.SetActive(false);
        mermPlace2Ramka.SetActive(false);
        mermPlace3Ramka.SetActive(false);
        mermPlace4Ramka.SetActive(false);
        mermPlace5Ramka.SetActive(false);
        mermPlace6Ramka.SetActive(false);
        mermPlace3Block.SetActive(false);
        mermPlace4Block.SetActive(false);
        mermPlace5Block.SetActive(false);
        mermPlace6Block.SetActive(false);
    }

    // ������� �� ������� �� ��������
    public void tapMermaids2()
    {

        // �������, ��� ������� ������ ��������� ���������
        if (garemBack.activeSelf == false && podtverjdenie.noteBack.activeSelf == false && podtverjdenie.confirmBack.activeSelf == false)
        {
            music.opensound.Play();
            garemBack.SetActive(true);
        }

        // ������ ��������� ���������
        else
        {
            notnow = false;
            if (garemBack.activeSelf == true && presentGaremBack.activeSelf == false && confirmGaremBack.activeSelf == false)
            {
                music.closesound.Play();
                liliis.SetActive(false);
                scroller.SetActive(false);
                camen1.SetActive(false);
                camen2.SetActive(false);
                camen3.SetActive(false);
                camen4.SetActive(false);
                camen5.SetActive(false);
                camen6.SetActive(false);
                mermPlace1Podsvetka.SetActive(false);
                mermPlace2Podsvetka.SetActive(false);
                mermPlace3Podsvetka.SetActive(false);
                mermPlace4Podsvetka.SetActive(false);
                mermPlace5Podsvetka.SetActive(false);
                mermPlace6Podsvetka.SetActive(false);
                garemBack.SetActive(false);
                mermPlace1.SetActive(false);
                mermPlace2.SetActive(false);
                mermPlace3.SetActive(false);
                mermPlace4.SetActive(false);
                mermPlace5.SetActive(false);
                mermPlace6.SetActive(false);
                mermPlace1Ramka.SetActive(false);
                mermPlace2Ramka.SetActive(false);
                mermPlace3Ramka.SetActive(false);
                mermPlace4Ramka.SetActive(false);
                mermPlace5Ramka.SetActive(false);
                mermPlace6Ramka.SetActive(false);
                mermPlace3Block.SetActive(false);
                mermPlace4Block.SetActive(false);
                mermPlace5Block.SetActive(false);
                mermPlace6Block.SetActive(false);
            }
        }


    }

    // ����� ����� 1
    public void tapMermPlace1()
    {
        // �������, ��� ������� ���� ��������������
        if (garemBack.activeSelf == true && mermPosition1 && podtverjdenie.noteBack.activeSelf == false && podtverjdenie.confirmBack.activeSelf == false && confirmGaremBack.activeSelf == false)
        {
            mermPlace1Podsvetka.SetActive(true);
            mermPlace2Podsvetka.SetActive(false);
            mermPlace3Podsvetka.SetActive(false);
            mermPlace4Podsvetka.SetActive(false);
            mermPlace5Podsvetka.SetActive(false);
            mermPlace6Podsvetka.SetActive(false);
            mermPlace1Ramka.SetActive(false);
        }

        if (herPosition1 == 0)
        {
            tapMermaids();
        }
        else
        {
            imenitel();
        }
    }

    // ����� ����� 2
    public void tapMermPlace2()
    {
        // �������, ��� ������� ���� ��������������
        if (garemBack.activeSelf == true && mermPosition2 && podtverjdenie.noteBack.activeSelf == false && podtverjdenie.confirmBack.activeSelf == false && confirmGaremBack.activeSelf == false)
        {
            mermPlace1Podsvetka.SetActive(false);
            mermPlace2Podsvetka.SetActive(true);
            mermPlace3Podsvetka.SetActive(false);
            mermPlace4Podsvetka.SetActive(false);
            mermPlace5Podsvetka.SetActive(false);
            mermPlace6Podsvetka.SetActive(false);
            mermPlace2Ramka.SetActive(false);
        }
        if (herPosition2 == 0)
        {
            tapMermaids();
        }
        else
        {
            imenitel();
        }
    }

    // ����� ����� 3
    public void tapMermPlace3()
    {
        // �������, ��� ������� ���� ��������������
        if (garemBack.activeSelf == true && mermPosition3 && podtverjdenie.noteBack.activeSelf == false && podtverjdenie.confirmBack.activeSelf == false && confirmGaremBack.activeSelf == false)
        {
            mermPlace1Podsvetka.SetActive(false);
            mermPlace2Podsvetka.SetActive(false);
            mermPlace3Podsvetka.SetActive(true);
            mermPlace4Podsvetka.SetActive(false);
            mermPlace5Podsvetka.SetActive(false);
            mermPlace6Podsvetka.SetActive(false);
            mermPlace3Ramka.SetActive(false);
        }
        if (herPosition3 == 0)
        {
            tapMermaids();
        }
        else
        {
            imenitel();
        }
    }

    // ����� ����� 4
    public void tapMermPlace4()
    {
        // �������, ��� ������� ���� ��������������
        if (garemBack.activeSelf == true && mermPosition4 && podtverjdenie.noteBack.activeSelf == false && podtverjdenie.confirmBack.activeSelf == false && confirmGaremBack.activeSelf == false)
        {
            mermPlace1Podsvetka.SetActive(false);
            mermPlace2Podsvetka.SetActive(false);
            mermPlace3Podsvetka.SetActive(false);
            mermPlace4Podsvetka.SetActive(true);
            mermPlace5Podsvetka.SetActive(false);
            mermPlace6Podsvetka.SetActive(false);
            mermPlace4Ramka.SetActive(false);
        }
        if (herPosition4 == 0)
        {
            tapMermaids();
        }
        else
        {
            imenitel();
        }
    }

    // ����� ����� 5
    public void tapMermPlace5()
    {
        // �������, ��� ������� ���� ��������������
        if (garemBack.activeSelf == true && mermPosition5 && podtverjdenie.noteBack.activeSelf == false && podtverjdenie.confirmBack.activeSelf == false && confirmGaremBack.activeSelf == false)
        {
            mermPlace1Podsvetka.SetActive(false);
            mermPlace2Podsvetka.SetActive(false);
            mermPlace3Podsvetka.SetActive(false);
            mermPlace4Podsvetka.SetActive(false);
            mermPlace5Podsvetka.SetActive(true);
            mermPlace6Podsvetka.SetActive(false);
            mermPlace5Ramka.SetActive(false);
        }
        if (herPosition5 == 0)
        {
            tapMermaids();
        }
        else
        {
            imenitel();
        }
    }

    // ����� ����� 6
    public void tapMermPlace6()
    {
        // �������, ��� ������� ���� ��������������
        if (garemBack.activeSelf == true && mermPosition6 && podtverjdenie.noteBack.activeSelf == false && podtverjdenie.confirmBack.activeSelf == false && confirmGaremBack.activeSelf == false)
        {
            mermPlace1Podsvetka.SetActive(false);
            mermPlace2Podsvetka.SetActive(false);
            mermPlace3Podsvetka.SetActive(false);
            mermPlace4Podsvetka.SetActive(false);
            mermPlace5Podsvetka.SetActive(false);
            mermPlace6Podsvetka.SetActive(true);
            mermPlace6Ramka.SetActive(false);
        }
        if (herPosition6 == 0)
        {
            tapMermaids();
        }
        else
        {
            imenitel();
        }
    }

    // ������������� ��������� � ������
    public void imenitel()
    {
        // ���� ������ ���������
        if (mermPlace1Podsvetka.activeSelf == true)
        {
            // ���� ������� 1
            if (herPosition1 == 1)
            {

                if (leveler.languager == 0)
                {
                    rusalkaName = "Creedeia";
                }
                else if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition1 == 2)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Batizza";
                }
                else if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition1 == 3)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Cirrata";
                }
                else if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�������";
                }

            }

            if (herPosition1 == 4)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Gasta";
                }
                else if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition1 == 5)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Pharn";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "����";
                }

            }

            if (herPosition1 == 6)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Nass";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "����";
                }

            }

            if (herPosition1 == 7)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Nemina";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition1 == 8)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Freya";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition1 == 9)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Cella";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition1 == 10)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Pacifica";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "��������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "��������";
                }

            }

            if (herPosition1 == 11)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Abbet";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition1 == 12)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Kophoba";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition1 == 13)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Valva";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition1 == 14)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Vinella";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "³�����";
                }

            }
            if (herPosition1 == 15)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Topel";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }
            if (herPosition1 == 16)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Robins";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }
            if (herPosition1 == 17)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Duse";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�'��";
                }

            }
            if (herPosition1 == 18)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Sactine";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�������";
                }

            }
            if (herPosition1 == 19)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Chita";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "ճ��";
                }

            }
            if (herPosition1 == 20)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Kevia";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "����";
                }

            }
            if (herPosition1 == 21)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Echina";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }
            if (herPosition1 == 22)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Phanosa";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }
            if (herPosition1 == 23)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Theusa";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition1 == 24)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Vita";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "³��";
                }

            }

            if (herPosition1 == 25)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Nadine";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "����";
                }

            }

            if (herPosition1 == 26)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Rurue";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "����";
                }

            }

            if (herPosition1 == 27)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Mikta";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "̳���";
                }

            }

            if (herPosition1 == 28)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Badge";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "����";
                }

            }

            if (herPosition1 == 29)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Vanada";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition1 == 30)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Thara";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition1 == 31)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Amblyss";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition1 == 32)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Amblyss";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition1 == 33)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Hio";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "���";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "ճ�";
                }

            }

            if (herPosition1 == 34)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Galana";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition1 == 35)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Haala";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition1 == 36)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Marida";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition1 == 37)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Lanta";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition1 == 38)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Reeda";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "г��";
                }

            }

            if (herPosition1 == 39)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Royda ";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition1 == 40)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Mariusa";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition1 == 41)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Celeesi";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition1 == 42)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Thanaida";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition1 == 43)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Themuma";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition1 == 44)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Dellia";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition1 == 45)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Hadee";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "���";
                }

            }

            if (herPosition1 == 46)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Demosa";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition1 == 47)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Nirel";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "ͳ����";
                }

            }

            if (herPosition1 == 48)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Goloriia";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

        }
        // ���� ������ ���������
        else if (mermPlace2Podsvetka.activeSelf == true)
        {
            // ���� ������� 1
            if (herPosition2 == 1)
            {

                if (leveler.languager == 0)
                {
                    rusalkaName = "Creedeia";
                }
                else if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition2 == 2)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Batizza";
                }
                else if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition2 == 3)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Cirrata";
                }
                else if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�������";
                }

            }

            if (herPosition2 == 4)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Gasta";
                }
                else if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition2 == 5)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Pharn";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "����";
                }

            }

            if (herPosition2 == 6)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Nass";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "����";
                }

            }

            if (herPosition2 == 7)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Nemina";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition2 == 8)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Freya";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition2 == 9)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Cella";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition2 == 10)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Pacifica";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "��������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "��������";
                }

            }

            if (herPosition2 == 11)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Abbet";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition2 == 12)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Kophoba";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition2 == 13)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Valva";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition2 == 14)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Vinella";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "³�����";
                }

            }
            if (herPosition2 == 15)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Topel";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }
            if (herPosition2 == 16)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Robins";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }
            if (herPosition2 == 17)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Duse";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�'��";
                }

            }
            if (herPosition2 == 18)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Sactine";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�������";
                }

            }
            if (herPosition2 == 19)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Chita";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "ճ��";
                }

            }
            if (herPosition2 == 20)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Kevia";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "����";
                }

            }
            if (herPosition2 == 21)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Echina";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }
            if (herPosition2 == 22)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Phanosa";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }
            if (herPosition2 == 23)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Theusa";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition2 == 24)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Vita";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "³��";
                }

            }

            if (herPosition2 == 25)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Nadine";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "����";
                }

            }

            if (herPosition2 == 26)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Rurue";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "����";
                }

            }

            if (herPosition2 == 27)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Mikta";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "̳���";
                }

            }

            if (herPosition2 == 28)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Badge";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "����";
                }

            }

            if (herPosition2 == 29)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Vanada";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition2 == 30)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Thara";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition2 == 31)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Amblyss";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition2 == 32)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Amblyss";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition2 == 33)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Hio";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "���";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "ճ�";
                }

            }

            if (herPosition2 == 34)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Galana";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition2 == 35)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Haala";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition2 == 36)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Marida";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition2 == 37)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Lanta";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition2 == 38)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Reeda";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "г��";
                }

            }

            if (herPosition2 == 39)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Royda ";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition2 == 40)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Mariusa";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition2 == 41)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Celeesi";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition2 == 42)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Thanaida";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition2 == 43)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Themuma";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition2 == 44)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Dellia";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition2 == 45)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Hadee";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "���";
                }

            }

            if (herPosition2 == 46)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Demosa";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition2 == 47)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Nirel";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "ͳ����";
                }

            }

            if (herPosition2 == 48)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Goloriia";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }
        }
        else if (mermPlace3Podsvetka.activeSelf == true)
        {
            if (herPosition3 == 1)
            {

                if (leveler.languager == 0)
                {
                    rusalkaName = "Creedeia";
                }
                else if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition3 == 2)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Batizza";
                }
                else if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition3 == 3)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Cirrata";
                }
                else if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�������";
                }

            }

            if (herPosition3 == 4)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Gasta";
                }
                else if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition3 == 5)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Pharn";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "����";
                }

            }

            if (herPosition3 == 6)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Nass";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "����";
                }

            }

            if (herPosition3 == 7)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Nemina";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition3 == 8)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Freya";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition3 == 9)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Cella";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition3 == 10)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Pacifica";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "��������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "��������";
                }

            }

            if (herPosition3 == 11)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Abbet";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition3 == 12)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Kophoba";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition3 == 13)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Valva";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition3 == 14)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Vinella";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "³�����";
                }

            }
            if (herPosition3 == 15)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Topel";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }
            if (herPosition3 == 16)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Robins";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }
            if (herPosition3 == 17)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Duse";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�'��";
                }

            }
            if (herPosition3 == 18)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Sactine";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�������";
                }

            }
            if (herPosition3 == 19)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Chita";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "ճ��";
                }

            }
            if (herPosition3 == 20)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Kevia";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "����";
                }

            }
            if (herPosition3 == 21)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Echina";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }
            if (herPosition3 == 22)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Phanosa";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }
            if (herPosition3 == 23)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Theusa";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition3 == 24)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Vita";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "³��";
                }

            }

            if (herPosition3 == 25)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Nadine";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "����";
                }

            }

            if (herPosition3 == 26)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Rurue";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "����";
                }

            }

            if (herPosition3 == 27)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Mikta";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "̳���";
                }

            }

            if (herPosition3 == 28)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Badge";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "����";
                }

            }

            if (herPosition3 == 29)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Vanada";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition3 == 30)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Thara";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition3 == 31)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Amblyss";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition3 == 32)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Amblyss";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition3 == 33)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Hio";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "���";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "ճ�";
                }

            }

            if (herPosition3 == 34)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Galana";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition3 == 35)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Haala";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition3 == 36)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Marida";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition3 == 37)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Lanta";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition3 == 38)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Reeda";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "г��";
                }

            }

            if (herPosition3 == 39)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Royda ";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition3 == 40)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Mariusa";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition3 == 41)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Celeesi";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition3 == 42)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Thanaida";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition3 == 43)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Themuma";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition3 == 44)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Dellia";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition3 == 45)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Hadee";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "���";
                }

            }

            if (herPosition3 == 46)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Demosa";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition3 == 47)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Nirel";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "ͳ����";
                }

            }

            if (herPosition3 == 48)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Goloriia";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }
        }
        else if (mermPlace4Podsvetka.activeSelf == true)
        {
            if (herPosition4 == 1)
            {

                if (leveler.languager == 0)
                {
                    rusalkaName = "Creedeia";
                }
                else if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition4 == 2)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Batizza";
                }
                else if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition4 == 3)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Cirrata";
                }
                else if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�������";
                }

            }

            if (herPosition4 == 4)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Gasta";
                }
                else if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition4 == 5)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Pharn";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "����";
                }

            }

            if (herPosition4 == 6)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Nass";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "����";
                }

            }

            if (herPosition4 == 7)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Nemina";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition4 == 8)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Freya";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition4 == 9)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Cella";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition4 == 10)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Pacifica";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "��������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "��������";
                }

            }

            if (herPosition4 == 11)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Abbet";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition4 == 12)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Kophoba";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition4 == 13)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Valva";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition4 == 14)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Vinella";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "³�����";
                }

            }
            if (herPosition4 == 15)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Topel";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }
            if (herPosition4 == 16)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Robins";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }
            if (herPosition4 == 17)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Duse";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�'��";
                }

            }
            if (herPosition4 == 18)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Sactine";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�������";
                }

            }
            if (herPosition4 == 19)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Chita";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "ճ��";
                }

            }
            if (herPosition4 == 20)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Kevia";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "����";
                }

            }
            if (herPosition4 == 21)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Echina";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }
            if (herPosition4 == 22)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Phanosa";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }
            if (herPosition4 == 23)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Theusa";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition4 == 24)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Vita";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "³��";
                }

            }

            if (herPosition4 == 25)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Nadine";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "����";
                }

            }

            if (herPosition4 == 26)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Rurue";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "����";
                }

            }

            if (herPosition4 == 27)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Mikta";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "̳���";
                }

            }

            if (herPosition4 == 28)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Badge";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "����";
                }

            }

            if (herPosition4 == 29)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Vanada";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition4 == 30)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Thara";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition4 == 31)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Amblyss";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition4 == 32)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Amblyss";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition4 == 33)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Hio";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "���";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "ճ�";
                }

            }

            if (herPosition4 == 34)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Galana";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition4 == 35)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Haala";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition4 == 36)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Marida";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition4 == 37)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Lanta";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition4 == 38)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Reeda";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "г��";
                }

            }

            if (herPosition4 == 39)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Royda ";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition4 == 40)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Mariusa";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition4 == 41)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Celeesi";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition4 == 42)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Thanaida";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition4 == 43)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Themuma";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition4 == 44)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Dellia";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition4 == 45)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Hadee";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "���";
                }

            }

            if (herPosition4 == 46)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Demosa";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition4 == 47)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Nirel";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "ͳ����";
                }

            }

            if (herPosition4 == 48)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Goloriia";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }
        }
        else if (mermPlace5Podsvetka.activeSelf == true)
        {
            if (herPosition5 == 1)
            {

                if (leveler.languager == 0)
                {
                    rusalkaName = "Creedeia";
                }
                else if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition5 == 2)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Batizza";
                }
                else if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition5 == 3)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Cirrata";
                }
                else if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�������";
                }

            }

            if (herPosition5 == 4)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Gasta";
                }
                else if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition5 == 5)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Pharn";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "����";
                }

            }

            if (herPosition5 == 6)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Nass";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "����";
                }

            }

            if (herPosition5 == 7)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Nemina";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition5 == 8)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Freya";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition5 == 9)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Cella";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition5 == 10)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Pacifica";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "��������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "��������";
                }

            }

            if (herPosition5 == 11)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Abbet";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition5 == 12)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Kophoba";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition5 == 13)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Valva";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition5 == 14)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Vinella";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "³�����";
                }

            }
            if (herPosition5 == 15)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Topel";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }
            if (herPosition5 == 16)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Robins";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }
            if (herPosition5 == 17)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Duse";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�'��";
                }

            }
            if (herPosition5 == 18)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Sactine";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�������";
                }

            }
            if (herPosition5 == 19)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Chita";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "ճ��";
                }

            }
            if (herPosition5 == 20)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Kevia";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "����";
                }

            }
            if (herPosition5 == 21)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Echina";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }
            if (herPosition5 == 22)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Phanosa";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }
            if (herPosition5 == 23)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Theusa";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition5 == 24)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Vita";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "³��";
                }

            }

            if (herPosition5 == 25)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Nadine";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "����";
                }

            }

            if (herPosition5 == 26)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Rurue";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "����";
                }

            }

            if (herPosition5 == 27)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Mikta";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "̳���";
                }

            }

            if (herPosition5 == 28)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Badge";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "����";
                }

            }

            if (herPosition5 == 29)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Vanada";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition5 == 30)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Thara";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition5 == 31)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Amblyss";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition5 == 32)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Amblyss";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition5 == 33)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Hio";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "���";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "ճ�";
                }

            }

            if (herPosition5 == 34)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Galana";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition5 == 35)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Haala";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition5 == 36)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Marida";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition5 == 37)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Lanta";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition5 == 38)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Reeda";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "г��";
                }

            }

            if (herPosition5 == 39)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Royda ";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition5 == 40)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Mariusa";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition5 == 41)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Celeesi";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition5 == 42)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Thanaida";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition5 == 43)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Themuma";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition5 == 44)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Dellia";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition5 == 45)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Hadee";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "���";
                }

            }

            if (herPosition5 == 46)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Demosa";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition5 == 47)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Nirel";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "ͳ����";
                }

            }

            if (herPosition5 == 48)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Goloriia";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }
        }
        else if (mermPlace6Podsvetka.activeSelf == true)
        {
            if (herPosition6 == 1)
            {

                if (leveler.languager == 0)
                {
                    rusalkaName = "Creedeia";
                }
                else if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition6 == 2)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Batizza";
                }
                else if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition6 == 3)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Cirrata";
                }
                else if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�������";
                }

            }

            if (herPosition6 == 4)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Gasta";
                }
                else if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition6 == 5)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Pharn";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "����";
                }

            }

            if (herPosition6 == 6)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Nass";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "����";
                }

            }

            if (herPosition6 == 7)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Nemina";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition6 == 8)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Freya";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition6 == 9)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Cella";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition6 == 10)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Pacifica";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "��������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "��������";
                }

            }

            if (herPosition6 == 11)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Abbet";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition6 == 12)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Kophoba";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition6 == 13)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Valva";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition6 == 14)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Vinella";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "³�����";
                }

            }
            if (herPosition6 == 15)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Topel";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }
            if (herPosition6 == 16)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Robins";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }
            if (herPosition6 == 17)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Duse";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�'��";
                }

            }
            if (herPosition6 == 18)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Sactine";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�������";
                }

            }
            if (herPosition6 == 19)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Chita";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "ճ��";
                }

            }
            if (herPosition6 == 20)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Kevia";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "����";
                }

            }
            if (herPosition6 == 21)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Echina";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }
            if (herPosition6 == 22)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Phanosa";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }
            if (herPosition6 == 23)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Theusa";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition6 == 24)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Vita";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "³��";
                }

            }

            if (herPosition6 == 25)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Nadine";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "����";
                }

            }

            if (herPosition6 == 26)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Rurue";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "����";
                }

            }

            if (herPosition6 == 27)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Mikta";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "̳���";
                }

            }

            if (herPosition6 == 28)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Badge";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "����";
                }

            }

            if (herPosition6 == 29)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Vanada";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition6 == 30)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Thara";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition6 == 31)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Amblyss";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition6 == 32)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Amblyss";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition6 == 33)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Hio";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "���";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "ճ�";
                }

            }

            if (herPosition6 == 34)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Galana";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition6 == 35)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Haala";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition6 == 36)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Marida";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition6 == 37)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Lanta";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition6 == 38)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Reeda";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "г��";
                }

            }

            if (herPosition6 == 39)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Royda ";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition6 == 40)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Mariusa";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition6 == 41)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Celeesi";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition6 == 42)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Thanaida";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition6 == 43)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Themuma";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition6 == 44)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Dellia";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "�����";
                }

            }

            if (herPosition6 == 45)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Hadee";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "����";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "���";
                }

            }

            if (herPosition6 == 46)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Demosa";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }

            if (herPosition6 == 47)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Nirel";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "ͳ����";
                }

            }

            if (herPosition6 == 48)
            {
                if (leveler.languager == 0)
                {
                    rusalkaName = "Goloriia";
                }
                if (leveler.languager == 1)
                {
                    rusalkaName = "�������";
                }
                else if (leveler.languager == 2)
                {
                    rusalkaName = "������";
                }

            }
        }
    }



    // ��������� ����� � ����� 1
    public void poluchiPriz1()
    {
        if(presentGaremBack.activeSelf == false && confirmGaremBack.activeSelf == false && resulter.resultMode == false && player.nagradoid == false)
        {
            priz1.SetActive(false);
            herPositionPresent = herPosition1;

        }
    }
    // ��������� ����� � ����� 2
    public void poluchiPriz2()
    {
        if (presentGaremBack.activeSelf == false && confirmGaremBack.activeSelf == false && resulter.resultMode == false && player.nagradoid == false)
        {
            priz2.SetActive(false);
            herPositionPresent = herPosition2;

        }
    }
    // ��������� ����� � ����� 3
    public void poluchiPriz3()
    {
        if (presentGaremBack.activeSelf == false && confirmGaremBack.activeSelf == false && resulter.resultMode == false && player.nagradoid == false)
        {
            priz3.SetActive(false);
            herPositionPresent = herPosition3;

        }
    }
    // ��������� ����� � ����� 4
    public void poluchiPriz4()
    {
        if (presentGaremBack.activeSelf == false && confirmGaremBack.activeSelf == false && resulter.resultMode == false && player.nagradoid == false)
        {
            priz4.SetActive(false);
            herPositionPresent = herPosition4;

        }
    }
    // ��������� ����� � ����� 5
    public void poluchiPriz5()
    {
        if (presentGaremBack.activeSelf == false && confirmGaremBack.activeSelf == false && resulter.resultMode == false && player.nagradoid == false)
        {
            priz5.SetActive(false);
            herPositionPresent = herPosition5;

        }
    }
    // ��������� ����� � ����� 6
    public void poluchiPriz6()
    {
        if (presentGaremBack.activeSelf == false && confirmGaremBack.activeSelf == false && resulter.resultMode == false && player.nagradoid == false)
        {
            priz6.SetActive(false);
            herPositionPresent = herPosition6;

        }
    }
}