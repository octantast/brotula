using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GenController : MonoBehaviour
{
    public music music;

    public Slider GenSlider;
    public Slider GenObmanSlider;
    public Levels leveler;
    public MermaidController mermaids;
    public ConfirmScreen confirms;
    public IkraIndicator ikorka;
    public DistanceToCheckpoint distancePoints;
    public Slo1 mermanslots;
    public Slot1 ggslots;
    public PlayerController player;
    public BattleScreen battleModeVisibility;
    public BeforeDive beforedive;

    public GameObject derzhalkagenov; // ��� � ������ �������
    public AudioSource shprits;
    public float totalreads;

    // ������������ �� ������ �������� � �� ���������
    public GameObject place1;
    public GameObject place2;
    public GameObject place3;
    public GameObject KeyLight1;
    public GameObject KeyLight2;
    public GameObject KeyLight3;
    public GameObject genButton;
    public GameObject gensBack;
    public GameObject descriptionGenes;
    public GameObject indicatorGenes;
    public GameObject presentGaremBackSp;

    // ����� ����, ��� ����� �������
    public bool IkraGenKey = false;
    public bool StatocystKey = false;
    public bool HydroporaKey = false;
    public bool OsmolitKey = false;
    public bool LipidKey = false;
    public bool KrioprotectorKey = false;
    public bool GigantizmKey = false;
    public bool SlizKey = false;
    public bool PancerKey = false;
    public bool EcholocatiaKey = false;
    public bool HemoreceptorKey = false;
    public bool PhotoreceptorKey = false;
    public bool MechanoreceptorKey = false;
    public bool ElectroreceptorKey = false;
    public bool RedPigmentKey = false;
    public bool ProzrachnostKey = false;
    public bool ChernyyPigmentKey = false;
    public bool MimicriaKey = false;
    public bool LuminiscenciaKey = false;
    public bool ToxinyKey = false;
    public bool RegenerationKey = false;
    public bool EviscerationKey = false;
    public bool PedicellariyKey = false;
    public bool PrisoskyKey = false;
    public bool ChernMeshokKey = false;
    public bool CuvieroviKey = false;
    public bool ColloblastyKey = false;
    public bool CirriKey = false;
    public bool PlavnikiKey = false;
    public bool ImmunitetKey = false;
    public bool ZubyKey = false;
    public bool DopPolostKey = false;
    public bool DopEnergiaKey = false;
    public bool PheromonesKey = false;
    public bool DegradationKey = false;
    public bool UskorennoeRazvitieKey = false;
    public bool MagneticKey = false;

    // ��������� �����
    public float rStatocyst;
    public float rHydropora;
    public float rOsmolit;
    public float rLipid;
    public float rKrioprotector;
    public float rGigantizm;
    public float rSliz;
    public float rPancer;
    public float rEcholocatia;
    public float rHemoreceptor;
    public float rPhotoreceptor;
    public float rMechanoreceptor;
    public float rElectroreceptor;
    public float rRedPigment;
    public float rProzrachnost;
    public float rChernyyPigment;
    public float rMimicria;
    public float rLuminiscencia;
    public float rToxiny;
    public float rRegeneration;
    public float rEvisceration;
    public float rPedicellariy;
    public float rPrisosky;
    public float rChernMeshok;
    public float rCuvierovi;
    public float rColloblasty;
    public float rCirri;
    public float rPlavniki;
    public float rImmunitet;
    public float rZuby;
    public float rDopPolost;
    public float rDopEnergia;
    public float rPheromones;
    public float rDegradation;
    public float rUskorennoeRazvitie;
    public float rMagnetic;

    // ����� ����� �� ��������
    public float kachStatocyst;
    public float kachHydropora;
    public float kachOsmolit;
    public float kachLipid;
    public float kachKrioprotector;
    public float kachGigantizm;
    public float kachSliz;
    public float kachPancer;
    public float kachEcholocatia;
    public float kachHemoreceptor;
    public float kachPhotoreceptor;
    public float kachMechanoreceptor;
    public float kachElectroreceptor;
    public float kachRedPigment;
    public float kachProzrachnost;
    public float kachChernyyPigment;
    public float kachMimicria;
    public float kachLuminiscencia;
    public float kachToxiny;
    public float kachRegeneration;
    public float kachEvisceration;
    public float kachPedicellariy;
    public float kachPrisosky;
    public float kachChernMeshok;
    public float kachCuvierovi;
    public float kachColloblasty;
    public float kachCirri;
    public float kachPlavniki;
    public float kachImmunitet;
    public float kachZuby;
    public float kachDopPolost;
    public float kachDopEnergia;
    public float kachPheromones;
    public float kachDegradation;
    public float kachUskorennoeRazvitie;
    public float kachMagnetic;

    // ������� �������� �����
    public float pStatocyst;
    public float pHydropora;
    public float pOsmolit;
    public float pLipid;
    public float pKrioprotector;
    public float pGigantizm;
    public float pSliz;
    public float pPancer;
    public float pEcholocatia;
    public float pHemoreceptor;
    public float pPhotoreceptor;
    public float pMechanoreceptor;
    public float pElectroreceptor;
    public float pRedPigment;
    public float pProzrachnost;
    public float pChernyyPigment;
    public float pMimicria;
    public float pLuminiscencia;
    public float pToxiny;
    public float pRegeneration;
    public float pEvisceration;
    public float pPedicellariy;
    public float pPrisosky;
    public float pChernMeshok;
    public float pCuvierovi;
    public float pColloblasty;
    public float pCirri;
    public float pPlavniki;
    public float pImmunitet;
    public float pZuby;
    public float pDopPolost;
    public float pDopEnergia;
    public float pPheromones;
    public float pDegradation;
    public float pUskorennoeRazvitie;
    public float pMagnetic;

    // ����������
    public float dStatocyst;
    public float dHydropora;
    public float dOsmolit;
    public float dLipid;
    public float dKrioprotector;
    public float dGigantizm;
    public float dSliz;
    public float dPancer;
    public float dEcholocatia;
    public float dHemoreceptor;
    public float dPhotoreceptor;
    public float dMechanoreceptor;
    public float dElectroreceptor;
    public float dRedPigment;
    public float dProzrachnost;
    public float dChernyyPigment;
    public float dMimicria;
    public float dLuminiscencia;
    public float dToxiny;
    public float dRegeneration;
    public float dEvisceration;
    public float dPedicellariy;
    public float dPrisosky;
    public float dChernMeshok;
    public float dCuvierovi;
    public float dColloblasty;
    public float dCirri;
    public float dPlavniki;
    public float dImmunitet;
    public float dZuby;
    public float dDopPolost;
    public float dDopEnergia;
    public float dPheromones;
    public float dDegradation;
    public float dUskorennoeRazvitie;
    public float dMagnetic;

    // ���� ���������� ����
    public float readStatocyst;
    public float readHydropora;
    public float readOsmolit;
    public float readLipid;
    public float readKrioprotector;
    public float readGigantizm;
    public float readSliz;
    public float readPancer;
    public float readEcholocatia;
    public float readHemoreceptor;
    public float readPhotoreceptor;
    public float readMechanoreceptor;
    public float readElectroreceptor;
    public float readRedPigment;
    public float readProzrachnost;
    public float readChernyyPigment;
    public float readMimicria;
    public float readLuminiscencia;
    public float readToxiny;
    public float readRegeneration;
    public float readEvisceration;
    public float readPedicellariy;
    public float readPrisosky;
    public float readChernMeshok;
    public float readCuvierovi;
    public float readColloblasty;
    public float readCirri;
    public float readPlavniki;
    public float readImmunitet;
    public float readZuby;
    public float readDopPolost;
    public float readDopEnergia;
    public float readPheromones;
    public float readUskorennoeRazvitie;
    public float readMagnetic;

    // ����������� ����� �����, ���� ��� �������
    public GameObject seenStatocyst;
    public GameObject seenHydropora;
    public GameObject seenOsmolit;
    public GameObject seenLipid;
    public GameObject seenKrioprotector;
    public GameObject seenGigantizm;
    public GameObject seenSliz;
    public GameObject seenPancer;
    public GameObject seenEcholocatia;
    public GameObject seenHemoreceptor;
    public GameObject seenPhotoreceptor;
    public GameObject seenMechanoreceptor;
    public GameObject seenElectroreceptor;
    public GameObject seenRedPigment;
    public GameObject seenProzrachnost;
    public GameObject seenChernyyPigment;
    public GameObject seenMimicria;
    public GameObject seenLuminiscencia;
    public GameObject seenToxiny;
    public GameObject seenRegeneration;
    public GameObject seenEvisceration;
    public GameObject seenPedicellariy;
    public GameObject seenPrisosky;
    public GameObject seenChernMeshok;
    public GameObject seenCuvierovi;
    public GameObject seenColloblasty;
    public GameObject seenCirri;
    public GameObject seenPlavniki;
    public GameObject seenImmunitet;
    public GameObject seenZuby;
    public GameObject seenDopPolost;
    public GameObject seenDopEnergia;
    public GameObject seenPheromones;
    public GameObject seenUskorennoeRazvitie;
    public GameObject seenMagnetic;

    // �������
    public GameObject adoptationTab;
    public GameObject receptorsTab;
    public GameObject battleTab;
    public GameObject pigmentTab;
    public GameObject progressTab;
    public GameObject receptorsWhite;
    public GameObject adoptionWhite;
    public GameObject progressWhite;
    public GameObject pigmentWhite;
    public GameObject battleWhite;
    public GameObject receptorsButton;
    public GameObject adoptionButton;
    public GameObject progressButton;
    public GameObject pigmentButton;
    public GameObject battleButton;

    // �������� ����� � ��������� ��� ����������
    public Text nazvanieText;
    public Text descriptionText;
    public GameObject genSpravka;
    public Text spravkaText1;
    public Text spravkaText2;
    public Text spravkaText3;
    public Text indicatorText;

    // ������� ����� �������� �����������
    public float maximumSprits;
    public float currentSprits;
    public float currentRs;
    public float currentPs;
    public float currentDs;
    public bool maximumSpritsa;
    public bool SpritsUsed;
    public Text SpritsText;
    public GameObject SamShprits;
    public bool SpritsEbosh;
    public float forSprits;

    public GameObject kletinki;
    public GameObject Kletochka1;
    public GameObject Kletochka2;
    public GameObject Kletochka3;
    public GameObject Kletochka4;
    public GameObject Kletochka5;
    public GameObject Kletochka6;
    public GameObject Kletochka7;
    public GameObject Kletochka8;
    public GameObject Kletochka9;

    private float degrodadoptPossibility;
    private float degrodreceptPossibility;
    private float degrodbatolPossibility;
    private float degrodprogrPossibility;
    private float degrodpigmaPossibility;
    private bool degrodus1;
    private bool degrodus2;
    private bool degrodus3;
    private bool degrodus4;
    private bool degrodus5;
    private bool degrodus6;
    private bool degrodus7;
    private bool degrodus8;
    private bool degrodus9;
    private bool degrodus10;
    private bool degrodus11;
    private bool degrodus12;
    private bool degrodus13;
    private bool degrodus14;
    private bool degrodus15;
    private bool degrodus16;
    private bool degrodus17;
    private bool degrodus18;
    private bool degrodus19;
    private bool degrodus20;
    private bool degrodus21;
    private bool degrodus22;
    private bool degrodus23;
    private bool degrodus24;
    private bool degrodus25;
    private bool degrodus26;
    private bool degrodus27;
    private int randomdegradeRus;
    private float randomuser;
    private float randomuser7;
    private float randomuser6;
    private float randomuser8;
    private float randomuser9;
    private float randomuser4;
    private bool ustanovka;

    public bool pulsation;

    public GameObject vyhod;

    public void Start()
    {
        degrodadoptPossibility = Random.Range(0, 10);
        degrodreceptPossibility = Random.Range(0, 10);
        degrodbatolPossibility = Random.Range(0, 10);
        degrodprogrPossibility = Random.Range(0, 10);
        degrodpigmaPossibility = Random.Range(0, 10);
        randomuser = Random.Range(0, 2);
        randomuser7 = Random.Range(0, 2);
        randomuser6 = Random.Range(0, 2);
        randomuser8 = Random.Range(0, 2);
        randomuser9 = Random.Range(0, 2);
        randomuser4 = Random.Range(0, 2);

        // ������ ����, ������� ��� �����������
        readStatocyst = PlayerPrefs.GetFloat("readStatocyst");
        readHydropora = PlayerPrefs.GetFloat("readHydropora");
        readOsmolit = PlayerPrefs.GetFloat("readOsmolit");
        readLipid = PlayerPrefs.GetFloat("readLipid");
        readKrioprotector = PlayerPrefs.GetFloat("readKrioprotector");
        readGigantizm = PlayerPrefs.GetFloat("readGigantizm");
        readSliz = PlayerPrefs.GetFloat("readSliz");
        readPancer = PlayerPrefs.GetFloat("readPancer");
        readEcholocatia = PlayerPrefs.GetFloat("readEcholocatia");
        readHemoreceptor = PlayerPrefs.GetFloat("readHemoreceptor");
        readPhotoreceptor = PlayerPrefs.GetFloat("readPhotoreceptor");
        readMechanoreceptor = PlayerPrefs.GetFloat("readMechanoreceptor");
        readElectroreceptor = PlayerPrefs.GetFloat("readElectroreceptor");
        readRedPigment = PlayerPrefs.GetFloat("readRedPigment");
        readProzrachnost = PlayerPrefs.GetFloat("readProzrachnost");
        readChernyyPigment = PlayerPrefs.GetFloat("readChernyyPigment");
        readMimicria = PlayerPrefs.GetFloat("readMimicria");
        readLuminiscencia = PlayerPrefs.GetFloat("readLuminiscencia");
        readToxiny = PlayerPrefs.GetFloat("readToxiny");
        readRegeneration = PlayerPrefs.GetFloat("readRegeneration");
        readEvisceration = PlayerPrefs.GetFloat("readEvisceration");
        readPedicellariy = PlayerPrefs.GetFloat("readPedicellariy");
        readPrisosky = PlayerPrefs.GetFloat("readPrisosky");
        readChernMeshok = PlayerPrefs.GetFloat("readChernMeshok");
        readCuvierovi = PlayerPrefs.GetFloat("readCuvierovi");
        readColloblasty = PlayerPrefs.GetFloat("readColloblasty");
        readCirri = PlayerPrefs.GetFloat("readCirri");
        readPlavniki = PlayerPrefs.GetFloat("readPlavniki");
        readImmunitet = PlayerPrefs.GetFloat("readImmunitet");
        readZuby = PlayerPrefs.GetFloat("readZuby");
        readDopPolost = PlayerPrefs.GetFloat("readDopPolost");
        readDopEnergia = PlayerPrefs.GetFloat("readDopEnergia");
        readPheromones = PlayerPrefs.GetFloat("readPheromones");
        readUskorennoeRazvitie = PlayerPrefs.GetFloat("readUskorennoeRazvitie");
        readMagnetic = PlayerPrefs.GetFloat("readMagnetic");

                // ���������� ����, ������� ��� �����������
        seenStatocyst.SetActive(false);
        seenHydropora.SetActive(false);
        seenOsmolit.SetActive(false);
        seenLipid.SetActive(false);
        seenKrioprotector.SetActive(false);
        seenGigantizm.SetActive(false);
        seenSliz.SetActive(false);
        seenPancer.SetActive(false);
        seenEcholocatia.SetActive(false);
        seenHemoreceptor.SetActive(false);
        seenPhotoreceptor.SetActive(false);
        seenMechanoreceptor.SetActive(false);
        seenElectroreceptor.SetActive(false);
        seenRedPigment.SetActive(false);
        seenProzrachnost.SetActive(false);
        seenChernyyPigment.SetActive(false);
        seenMimicria.SetActive(false);
        seenLuminiscencia.SetActive(false);
        seenToxiny.SetActive(false);
        seenRegeneration.SetActive(false);
        seenEvisceration.SetActive(false);
        seenPedicellariy.SetActive(false);
        seenPrisosky.SetActive(false);
        seenChernMeshok.SetActive(false);
        seenCuvierovi.SetActive(false);
        seenColloblasty.SetActive(false);
        seenCirri.SetActive(false);
        seenPlavniki.SetActive(false);
        seenImmunitet.SetActive(false);
        seenZuby.SetActive(false);
        seenDopPolost.SetActive(false);
        seenDopEnergia.SetActive(false);
        seenPheromones.SetActive(false);
        seenUskorennoeRazvitie.SetActive(false);
        seenMagnetic.SetActive(false);
        if (readStatocyst > 0)
        {
            seenStatocyst.SetActive(true);
        }
        if (readHydropora > 0)
        {
            seenHydropora.SetActive(true);
        }
        if (readOsmolit > 0)
        {
            seenOsmolit.SetActive(true);
        }
        if (readLipid > 0)
        {
            seenLipid.SetActive(true);
        }
        if (readKrioprotector > 0)
        {
            seenKrioprotector.SetActive(true);
        }
        if (readGigantizm > 0)
        {
            seenGigantizm.SetActive(true);
        }
        if (readSliz > 0)
        {
            seenSliz.SetActive(true);
        }
        if (readPancer > 0)
        {
            seenPancer.SetActive(true);
        }
        if (readEcholocatia > 0)
        {
            seenEcholocatia.SetActive(true);
        }
        if (readHemoreceptor > 0)
        {
            seenHemoreceptor.SetActive(true);
        }
        if (readPhotoreceptor > 0)
        {
            seenPhotoreceptor.SetActive(true);
        }
        if (readMechanoreceptor > 0)
        {
            seenMechanoreceptor.SetActive(true);
        }
        if (readElectroreceptor > 0)
        {
            seenElectroreceptor.SetActive(true);
        }
        if (readRedPigment > 0)
        {
            seenRedPigment.SetActive(true);
        }
        if (readProzrachnost > 0)
        {
            seenProzrachnost.SetActive(true);
        }
        if (readChernyyPigment > 0)
        {
            seenChernyyPigment.SetActive(true);
        }
        if (readMimicria > 0)
        {
            seenMimicria.SetActive(true);
        }
        if (readLuminiscencia > 0)
        {
            seenLuminiscencia.SetActive(true);
        }
        if (readToxiny > 0)
        {
            seenToxiny.SetActive(true);
        }
        if (readRegeneration > 0)
        {
            seenRegeneration.SetActive(true);
        }
        if (readEvisceration > 0)
        {
            seenEvisceration.SetActive(true);
        }
        if (readPedicellariy > 0)
        {
            seenPedicellariy.SetActive(true);
        }
        if (readPrisosky > 0)
        {
            seenPrisosky.SetActive(true);
        }
        if (readChernMeshok > 0)
        {
            seenChernMeshok.SetActive(true);
        }
        if (readCuvierovi > 0)
        {
            seenCuvierovi.SetActive(true);
        }
        if (readColloblasty > 0)
        {
            seenColloblasty.SetActive(true);
        }
        if (readCirri > 0)
        {
            seenCirri.SetActive(true);
        }
        if (readPlavniki > 0)
        {
            seenPlavniki.SetActive(true);
        }
        if (readImmunitet > 0)
        {
            seenImmunitet.SetActive(true);
        }
        if (readZuby > 0)
        {
            seenZuby.SetActive(true);
        }
        if (readDopPolost > 0)
        {
            seenDopPolost.SetActive(true);
        }
        if (readDopEnergia > 0)
        {
            seenDopEnergia.SetActive(true);
        }
        if (readPheromones > 0)
        {
            seenPheromones.SetActive(true);
        }
        if (readUskorennoeRazvitie > 0)
        {
            seenUskorennoeRazvitie.SetActive(true);
        }
        if (readMagnetic > 0)
        {
            seenMagnetic.SetActive(true);
        }

        totalreads = readStatocyst + readHydropora + readOsmolit + readLipid + readKrioprotector + readGigantizm + readSliz + readPancer + readEcholocatia + readHemoreceptor + readPhotoreceptor + readMechanoreceptor + readElectroreceptor + readRedPigment + readProzrachnost + readChernyyPigment + readMimicria + readLuminiscencia + readToxiny + readRegeneration + readEvisceration + readPedicellariy + readPrisosky + readChernMeshok + readCuvierovi + readColloblasty + readCirri + readPlavniki + readImmunitet + readZuby + readDopPolost + readDopEnergia + readPheromones + readUskorennoeRazvitie + readMagnetic;

        // ���� ��� ��� �����, �� ������ ����� ����

    }

    public void Update()
    {

        if (distancePoints.distance < 5050 && gensBack.activeSelf == true && adoptationTab.activeSelf == false && receptorsTab.activeSelf == false && battleTab.activeSelf == false && pigmentTab.activeSelf == false && progressTab.activeSelf == false)
        {
            vyhod.SetActive(true);
        }
        else if(distancePoints.distance < 5050)
        {
            vyhod.SetActive(false);
        }

        // ������� ���������� ����, ��� �� ����� ������������� (�� ��� ���������)
        if (readStatocyst == 0)
        {
            dStatocyst = 0;
        }
        if (readHydropora == 0)
        {
            dHydropora = 0;
        }
        if (readOsmolit == 0)
        {
            dOsmolit = 0;
        }
        if (readLipid == 0)
        {
            dLipid = 0;
        }
        if (readKrioprotector == 0)
        {
            dKrioprotector = 0;
        }
        if (readGigantizm == 0)
        {
            dGigantizm = 0;
        }
        if (readSliz == 0)
        {
            dSliz = 0;
        }
        if (readPancer == 0)
        {
            dPancer = 0;
        }
        if (readEcholocatia == 0)
        {
            dEcholocatia = 0;
        }
        if (readHemoreceptor == 0)
        {
            dHemoreceptor = 0;
        }
        if (readPhotoreceptor == 0)
        {
            dPhotoreceptor = 0;
        }
        if (readMechanoreceptor == 0)
        {
            dMechanoreceptor = 0;
        }
        if (readElectroreceptor == 0)
        {
            dElectroreceptor = 0;
        }
        if (readRedPigment == 0)
        {
            dRedPigment = 0;
        }
        if (readProzrachnost == 0)
        {
            dProzrachnost = 0;
        }
        if (readChernyyPigment == 0)
        {
            dChernyyPigment = 0;
        }
        if (readMimicria == 0)
        {
            dMimicria = 0;
        }
        if (readLuminiscencia == 0)
        {
            dLuminiscencia = 0;
        }
        if (readToxiny == 0)
        {
            dToxiny = 0;
        }
        if (readRegeneration == 0)
        {
            dRegeneration = 0;
        }
        if (readEvisceration == 0)
        {
            dEvisceration = 0;
        }
        if (readPedicellariy == 0)
        {
            dPedicellariy = 0;
        }
        if (readPrisosky == 0)
        {
            dPrisosky = 0;
        }
        if (readChernMeshok == 0)
        {
            dChernMeshok = 0;
        }
        if (readCuvierovi == 0)
        {
            dCuvierovi = 0;
        }
        if (readColloblasty == 0)
        {
            dColloblasty = 0;
        }
        if (readCirri == 0)
        {
            dCirri = 0;
        }
        if (readPlavniki == 0)
        {
            dPlavniki = 0;
        }
        if (readImmunitet == 0)
        {
            dImmunitet = 0;
        }
        if (readZuby == 0)
        {
            dZuby = 0;
        }
        if (readDopPolost == 0)
        {
            dDopPolost = 0;
        }
        if (readDopEnergia == 0)
        {
            dDopEnergia = 0;
        }
        if (readPheromones == 0)
        {
            dPheromones = 0;
        }
        if (readUskorennoeRazvitie == 0)
        {
            dUskorennoeRazvitie = 0;
        }
        if (readMagnetic == 0)
        {
            dMagnetic = 0;
        }

        // ������ ������� ����� ��� ������ �������, �� ������� ������!
        if (distancePoints.distance >= 5050 && ustanovka == false)
        {
            ustanovka = true;

            // ������� �� �����
            if (pMimicria == 2)
            {
                player.skipCheck = 40;
            }
            if (pMimicria == 3)
            {
                player.skipCheck = 20;
            }
            if(pProzrachnost > 1)
            {
                player.skipCheck += 5;
            }
            // ������� �� �����
            if (pPheromones == 2)
            {
                mermaids.defaultudelenie = 2;
                mermaids.udelenie = 2;
            }
            if (pPheromones == 3)
            {
                mermaids.defaultudelenie = 3;
                mermaids.udelenie = 3;
            }

            // ������� �� �����
            if (pStatocyst == 2)
            {
                ggslots.blockpossibilitygg -= randomuser;
            }
            if (pStatocyst == 3)
            {
                ggslots.blockpossibilitygg = 0;
            }
            if (pHydropora == 2)
            {
                ggslots.blockpossibilitygg7 -= randomuser7;
            }
            if (pHydropora == 3)
            {
                ggslots.blockpossibilitygg7 = 0;
            }
            if (pLipid == 2 && pEcholocatia < 2)
            {
                ggslots.blockpossibilitygg9 -= randomuser9;
            }
            else if (pLipid == 3 && pEcholocatia < 3)
            {
                ggslots.blockpossibilitygg9 = 0;
            }
            if (pGigantizm == 2)
            {
                ggslots.blockpossibilitygg8 -= randomuser8;
            }
            if (pGigantizm == 3)
            {
                ggslots.blockpossibilitygg8 = 0;
            }
            if (pDopEnergia == 2)
            {
                player.normalSpeed += 1f;
            }
            if (pDopEnergia == 3)
            {
                player.normalSpeed += 2f;
            }
            if (pSliz == 2)
            {
                ggslots.blockpossibilitygg4 -= randomuser4;
            }
            if (pSliz == 3 && pPancer < pSliz)
            {
                ggslots.blockpossibilitygg4 = 0;
            }
            if (pPancer == 2)
            {
                ggslots.blockpossibilitygg6 -= randomuser6;
            }
            if (pPancer == 3 && pPancer > pSliz)
            {
                ggslots.blockpossibilitygg6 = 0;
            }
            if (pOsmolit == 2)
            {
                mermanslots.blockpossibility8 -= randomuser8;
            }
            if (pOsmolit == 3)
            {
                mermanslots.blockpossibility8 = 0;
            }
            if (pKrioprotector == 2)
            {
                mermanslots.blockpossibility7 -= randomuser7;
            }
            if (pKrioprotector == 3)
            {
                mermanslots.blockpossibility7 = 0;
            }
            if (pHemoreceptor == 2)
            {
                mermanslots.blockpossibility4 -= randomuser4;
            }
            if (pHemoreceptor == 3)
            {
                mermanslots.blockpossibility4 = 0;
            }
            if (pPhotoreceptor == 2)
            {
                mermanslots.blockpossibility5 -= randomuser;
            }
            if (pPhotoreceptor == 3)
            {
                mermanslots.blockpossibility5 = 0;
            }
            if (pMechanoreceptor == 2)
            {
                mermanslots.blockpossibility6 -= randomuser6;
            }
            if (pMechanoreceptor == 3)
            {
                mermanslots.blockpossibility6 = 0;
            }
            if (pMagnetic == 2)
            {
                mermanslots.blockpossibility9 -= randomuser9;
            }
            if (pMagnetic == 3)
            {
                mermanslots.blockpossibility9 = 0;
            }
        }

        // ������, ����� ���� ����� ������, ������ ���� ������ ����� �����
        if (presentGaremBackSp.activeSelf == true && mermaids.presentGaremBack.activeSelf == true)
        {
            if (StatocystKey == true)
            {
                readStatocyst = 1;
            }
            if (HydroporaKey == true)
            {
                readHydropora = 1;
            }
            if (OsmolitKey == true)
            {
                readOsmolit = 1;
            }
            if (LipidKey == true)
            {
                readLipid = 1;
            }
            if (KrioprotectorKey == true)
            {
                readKrioprotector = 1;
            }
            if (GigantizmKey == true)
            {
                readGigantizm = 1;
            }
            if (SlizKey == true)
            {
                readSliz = 1;
            }
            if (PancerKey == true)
            {
                readPancer = 1;
            }
            if (EcholocatiaKey == true)
            {
                readEcholocatia = 1;
            }
            if (HemoreceptorKey == true)
            {
                readHemoreceptor = 1;
            }
            if (PhotoreceptorKey == true)
            {
                readPhotoreceptor = 1;
            }
            if (MechanoreceptorKey == true)
            {
                readMechanoreceptor = 1;
            }
            if (ElectroreceptorKey == true)
            {
                readElectroreceptor = 1;
            }
            if (RedPigmentKey == true)
            {
                readRedPigment = 1;
            }
            if (ProzrachnostKey == true)
            {
                readProzrachnost = 1;
            }
            if (ChernyyPigmentKey == true)
            {
                readChernyyPigment = 1;
            }
            if (MimicriaKey == true)
            {
                readMimicria = 1;
            }
            if (LuminiscenciaKey == true)
            {
                readLuminiscencia = 1;
            }
            if (ToxinyKey == true)
            {
                readToxiny = 1;
            }
            if (RegenerationKey == true)
            {
                readRegeneration = 1;
            }
            if (EviscerationKey == true)
            {
                readEvisceration = 1;
            }
            if (PedicellariyKey == true)
            {
                readPedicellariy = 1;
            }
            if (PrisoskyKey == true)
            {
                readPrisosky = 1;
            }
            if (ChernMeshokKey == true)
            {
                readChernMeshok = 1;
            }
            if (CuvieroviKey == true)
            {
                readCuvierovi = 1;
            }
            if (ColloblastyKey == true)
            {
                readColloblasty = 1;
            }
            if (CirriKey == true)
            {
                readCirri = 1;
            }
            if (PlavnikiKey == true)
            {
                readPlavniki = 1;
            }
            if (ImmunitetKey == true)
            {
                readImmunitet = 1;
            }
            if (ZubyKey == true)
            {
                readZuby = 1;
            }
            if (DopPolostKey == true)
            {
                readDopPolost = 1;
            }
            if (DopEnergiaKey == true)
            {
                readDopEnergia = 1;
            }
            if (PheromonesKey == true)
            {
                readPheromones = 1;
            }
            if (UskorennoeRazvitieKey == true)
            {
                readUskorennoeRazvitie = 1;
            }
            if (MagneticKey == true)
            {
                readMagnetic = 1;
            }
        }

        // ���� �����
        if (confirms.podtverjdenoTapom && SpritsEbosh)
        {
            SpritsVveden();
        }

        // ������� ����� ���� �������
        if (SpritsUsed == false)
        {
            currentPs = pStatocyst + pHydropora + pOsmolit + pLipid + pKrioprotector + pGigantizm + pSliz + pPancer + pEcholocatia + pHemoreceptor + pPhotoreceptor + pMechanoreceptor + pElectroreceptor + pRedPigment + pProzrachnost + pChernyyPigment + pMimicria + pLuminiscencia + pToxiny + pRegeneration + pEvisceration + pPedicellariy + pPrisosky + pChernMeshok + pCuvierovi + pColloblasty + pCirri + pPlavniki + pImmunitet + pZuby + pDopPolost + pDopEnergia + pPheromones + pDegradation + pUskorennoeRazvitie + pMagnetic;
            currentSprits = kachStatocyst + kachHydropora + kachOsmolit + kachLipid + kachKrioprotector + kachGigantizm + kachSliz + kachPancer + kachEcholocatia + kachHemoreceptor + kachPhotoreceptor + kachMechanoreceptor + kachElectroreceptor + kachRedPigment + kachProzrachnost + kachChernyyPigment + kachMimicria + kachLuminiscencia + kachToxiny + kachRegeneration + kachEvisceration + kachPedicellariy + kachPrisosky + kachChernMeshok + kachCuvierovi + kachColloblasty + kachCirri + kachPlavniki + kachImmunitet + kachZuby + kachDopPolost + kachDopEnergia + kachPheromones + kachDegradation + kachUskorennoeRazvitie + kachMagnetic;
            SpritsText.text = currentSprits.ToString("F0") + "/" + maximumSprits.ToString("F0");
            currentRs = rStatocyst + rHydropora + rOsmolit + rLipid + rKrioprotector + rGigantizm + rSliz + rPancer + rEcholocatia + rHemoreceptor + rPhotoreceptor + rMechanoreceptor + rElectroreceptor + rRedPigment + rProzrachnost + rChernyyPigment + rMimicria + rLuminiscencia + rToxiny + rRegeneration + rEvisceration + rPedicellariy + rPrisosky + rChernMeshok + rCuvierovi + rColloblasty + rCirri + rPlavniki + rImmunitet + rZuby + rDopPolost + rDopEnergia + rPheromones + rDegradation + rUskorennoeRazvitie + rMagnetic;
        }
        else if (SpritsUsed && distancePoints.distance <= 5050)
        {
            SpritsText.text = currentSprits.ToString("F0") + "/" + maximumSprits.ToString("F0");
            GenSlider.value = forSprits;
            GenObmanSlider.value = forSprits;
            if (currentSprits >= 0)
            {
                currentSprits -= 0.05f;
                forSprits -= 0.05f;
            }
        }

        // ����� ������� ���� ��� ���� ���������
        if ((presentGaremBackSp.activeSelf == true && mermaids.presentGaremBack.activeSelf == true && confirms.podtverjdenoTapom == true) || (player.nagradoid == true && confirms.podtverjdenoTapom == true))
        {
            confirms.prizsound.Play(0);
            // ������� �� �����
            if (IkraGenKey == true) // ���� ����� ������ ����
            {
                ikorka.ikra += mermaids.randomGenIkornyy;
            }

            // ���� ����� ������ �����-�� ���
            if (StatocystKey == true)
            {
                rStatocyst += 1;
                PlayerPrefs.SetFloat("rStatocyst", rStatocyst);
                Instantiate(mermaids.Statocyst, derzhalkagenov.transform.position, Quaternion.identity, derzhalkagenov.transform);
            }
            if (HydroporaKey == true)
            {
                rHydropora += 1;
                PlayerPrefs.SetFloat("rHydropora", rHydropora);
                Instantiate(mermaids.Hydropora, derzhalkagenov.transform.position, Quaternion.identity, derzhalkagenov.transform);
            }
            if (OsmolitKey == true)
            {
                rOsmolit += 1;
                PlayerPrefs.SetFloat("rOsmolit", rOsmolit);
                Instantiate(mermaids.Osmolit, derzhalkagenov.transform.position, Quaternion.identity, derzhalkagenov.transform);
            }
            if (LipidKey == true)
            {
                rLipid += 1;
                PlayerPrefs.SetFloat("rLipid", rLipid);
                Instantiate(mermaids.Lipid, derzhalkagenov.transform.position, Quaternion.identity, derzhalkagenov.transform);
            }
            if (KrioprotectorKey == true)
            {
                rKrioprotector += 1;
                PlayerPrefs.SetFloat("rKrioprotector", rKrioprotector);
                Instantiate(mermaids.Krioprotector, derzhalkagenov.transform.position, Quaternion.identity, derzhalkagenov.transform);
            }
            if (GigantizmKey == true)
            {
                rGigantizm += 1;
                PlayerPrefs.SetFloat("rGigantizm", rGigantizm);
                Instantiate(mermaids.Gigantizm, derzhalkagenov.transform.position, Quaternion.identity, derzhalkagenov.transform);
            }
            if (SlizKey == true)
            {
                rSliz += 1;
                PlayerPrefs.SetFloat("rSliz", rSliz);
                Instantiate(mermaids.Sliz, derzhalkagenov.transform.position, Quaternion.identity, derzhalkagenov.transform);
            }
            if (PancerKey == true)
            {
                rPancer += 1;
                PlayerPrefs.SetFloat("rPancer", rPancer);
                Instantiate(mermaids.Pancer, derzhalkagenov.transform.position, Quaternion.identity, derzhalkagenov.transform);
            }
            if (EcholocatiaKey == true)
            {
                rEcholocatia += 1;
                PlayerPrefs.SetFloat("rEcholocatia", rEcholocatia);
                Instantiate(mermaids.Echolocatia, derzhalkagenov.transform.position, Quaternion.identity, derzhalkagenov.transform);
            }
            if (HemoreceptorKey == true)
            {
                rHemoreceptor += 1;
                PlayerPrefs.SetFloat("rHemoreceptor", rHemoreceptor);
                Instantiate(mermaids.Hemoreceptor, derzhalkagenov.transform.position, Quaternion.identity, derzhalkagenov.transform);
            }
            if (PhotoreceptorKey == true)
            {
                rPhotoreceptor += 1;
                PlayerPrefs.SetFloat("rPhotoreceptor", rPhotoreceptor);
                Instantiate(mermaids.Photoreceptor, derzhalkagenov.transform.position, Quaternion.identity, derzhalkagenov.transform);
            }
            if (MechanoreceptorKey == true)
            {
                rMechanoreceptor += 1;
                PlayerPrefs.SetFloat("rMechanoreceptor", rMechanoreceptor);
                Instantiate(mermaids.Mechanoreceptor, derzhalkagenov.transform.position, Quaternion.identity, derzhalkagenov.transform);
            }
            if (ElectroreceptorKey == true)
            {
                rElectroreceptor += 1;
                PlayerPrefs.SetFloat("rElectroreceptor", rElectroreceptor);
                Instantiate(mermaids.Electroreceptor, derzhalkagenov.transform.position, Quaternion.identity, derzhalkagenov.transform);
            }
            if (RedPigmentKey == true)
            {
                rRedPigment += 1;
                PlayerPrefs.SetFloat("rRedPigment", rRedPigment);
                Instantiate(mermaids.RedPigment, derzhalkagenov.transform.position, Quaternion.identity, derzhalkagenov.transform);
            }
            if (ProzrachnostKey == true)
            {
                rProzrachnost += 1;
                PlayerPrefs.SetFloat("rProzrachnost", rProzrachnost);
                Instantiate(mermaids.Prozrachnost, derzhalkagenov.transform.position, Quaternion.identity, derzhalkagenov.transform);
            }
            if (ChernyyPigmentKey == true)
            {
                rChernyyPigment += 1;
                PlayerPrefs.SetFloat("rChernyyPigment", rChernyyPigment);
                Instantiate(mermaids.ChernyyPigment, derzhalkagenov.transform.position, Quaternion.identity, derzhalkagenov.transform);
            }
            if (MimicriaKey == true)
            {
                rMimicria += 1;
                PlayerPrefs.SetFloat("rMimicria", rMimicria);
                Instantiate(mermaids.Mimicria, derzhalkagenov.transform.position, Quaternion.identity, derzhalkagenov.transform);
            }
            if (LuminiscenciaKey == true)
            {
                rLuminiscencia += 1;
                PlayerPrefs.SetFloat("rLuminiscencia", rLuminiscencia);
                Instantiate(mermaids.Luminiscencia, derzhalkagenov.transform.position, Quaternion.identity, derzhalkagenov.transform);
            }
            if (ToxinyKey == true)
            {
                rToxiny += 1;
                PlayerPrefs.SetFloat("rToxiny", rToxiny);
                Instantiate(mermaids.Toxiny, derzhalkagenov.transform.position, Quaternion.identity, derzhalkagenov.transform);
            }
            if (RegenerationKey == true)
            {
                rRegeneration += 1;
                PlayerPrefs.SetFloat("rRegeneration", rRegeneration);
                Instantiate(mermaids.Regeneration, derzhalkagenov.transform.position, Quaternion.identity, derzhalkagenov.transform);
            }
            if (EviscerationKey == true)
            {
                rEvisceration += 1;
                PlayerPrefs.SetFloat("rEvisceration", rEvisceration);
                Instantiate(mermaids.Evisceration, derzhalkagenov.transform.position, Quaternion.identity, derzhalkagenov.transform);
            }
            if (PedicellariyKey == true)
            {
                rPedicellariy += 1;
                PlayerPrefs.SetFloat("rPedicellariy", rPedicellariy);
                Instantiate(mermaids.Pedicellariy, derzhalkagenov.transform.position, Quaternion.identity, derzhalkagenov.transform);
            }
            if (PrisoskyKey == true)
            {
                rPrisosky += 1;
                PlayerPrefs.SetFloat("rPrisosky", rPrisosky);
                Instantiate(mermaids.Prisosky, derzhalkagenov.transform.position, Quaternion.identity, derzhalkagenov.transform);
            }
            if (ChernMeshokKey == true)
            {
                rChernMeshok += 1;
                PlayerPrefs.SetFloat("rChernMeshok", rChernMeshok);
                Instantiate(mermaids.ChernMeshok, derzhalkagenov.transform.position, Quaternion.identity, derzhalkagenov.transform);
            }
            if (CuvieroviKey == true)
            {
                rCuvierovi += 1;
                PlayerPrefs.SetFloat("rCuvierovi", rCuvierovi);
                Instantiate(mermaids.Cuvierovi, derzhalkagenov.transform.position, Quaternion.identity, derzhalkagenov.transform);
            }
            if (ColloblastyKey == true)
            {
                rColloblasty += 1;
                PlayerPrefs.SetFloat("rColloblasty", rColloblasty);
                Instantiate(mermaids.Colloblasty, derzhalkagenov.transform.position, Quaternion.identity, derzhalkagenov.transform);
            }
            if (CirriKey == true)
            {
                rCirri += 1;
                PlayerPrefs.SetFloat("rCirri", rCirri);
                Instantiate(mermaids.Cirri, derzhalkagenov.transform.position, Quaternion.identity, derzhalkagenov.transform);
            }
            if (PlavnikiKey == true)
            {
                rPlavniki += 1;
                PlayerPrefs.SetFloat("rPlavniki", rPlavniki);
                Instantiate(mermaids.Plavniki, derzhalkagenov.transform.position, Quaternion.identity, derzhalkagenov.transform);
            }
            if (ImmunitetKey == true)
            {
                rImmunitet += 1;
                PlayerPrefs.SetFloat("rImmunitet", rImmunitet);
                Instantiate(mermaids.Immunitet, derzhalkagenov.transform.position, Quaternion.identity, derzhalkagenov.transform);
            }
            if (ZubyKey == true)
            {
                rZuby += 1;
                PlayerPrefs.SetFloat("rZuby", rZuby);
                Instantiate(mermaids.Zuby, derzhalkagenov.transform.position, Quaternion.identity, derzhalkagenov.transform);
            }
            if (DopPolostKey == true)
            {
                rDopPolost += 1;
                PlayerPrefs.SetFloat("rDopPolost", rDopPolost);
                Instantiate(mermaids.DopPolost, derzhalkagenov.transform.position, Quaternion.identity, derzhalkagenov.transform);
            }
            if (DopEnergiaKey == true)
            {
                rDopEnergia += 1;
                PlayerPrefs.SetFloat("rDopEnergia", rDopEnergia);
                Instantiate(mermaids.DopEnergia, derzhalkagenov.transform.position, Quaternion.identity, derzhalkagenov.transform);
            }
            if (PheromonesKey == true)
            {
                rPheromones += 1;
                PlayerPrefs.SetFloat("rPheromones", rPheromones);
                Instantiate(mermaids.Pheromones, derzhalkagenov.transform.position, Quaternion.identity, derzhalkagenov.transform);
            }
            if (UskorennoeRazvitieKey == true)
            {
                rUskorennoeRazvitie += 1;
                PlayerPrefs.SetFloat("rUskorennoeRazvitie", rUskorennoeRazvitie);
                Instantiate(mermaids.UskorennoeRazvitie, derzhalkagenov.transform.position, Quaternion.identity, derzhalkagenov.transform);
            }
            if (MagneticKey == true)
            {
                rMagnetic += 1;
                PlayerPrefs.SetFloat("rMagnetic", rMagnetic);
                Instantiate(mermaids.Magnetic, derzhalkagenov.transform.position, Quaternion.identity, derzhalkagenov.transform);
            }

            // ��� ������ �� ���� ����, ����� �� �� ������
            foreach (Transform child in derzhalkagenov.transform)
            {
                child.gameObject.tag = "Untagged";
            }

            // ��� ���������� ����������, ���� ��� ��������� ��� ����������
            if (mermaids.genPlace2 == 34 || mermaids.genPlace1 == 34)
            {
                // ���� ��������� �� �����
                if (pImmunitet < 2)
                {
                    randomdegradeRus = Random.Range(1, 40);
                }
                else if(pImmunitet == 2)
                {
                    randomdegradeRus = Random.Range(1, 80);
                }
                else if (pImmunitet == 3)
                {
                    randomdegradeRus = 0;
                }
                switch (randomdegradeRus)
                {
                    case 1:
                        dStatocyst += 1;
                        break;
                    case 2:
                        dHydropora += 1;
                        break;
                    case 3:
                        dOsmolit += 1;
                        break;
                    case 5:
                        dLipid += 1;
                        break;
                    case 6:
                        dKrioprotector += 1;
                        break;
                    case 7:
                        dGigantizm += 1;
                        break;
                    case 8:
                        dSliz += 1;
                        break;
                    case 9:
                        dPancer += 1;
                        break;
                    case 10:
                        dEcholocatia += 1;
                        break;
                    case 11:
                        dHemoreceptor += 1;
                        break;
                    case 12:
                        dPhotoreceptor += 1;
                        break;
                    case 13:
                        dMechanoreceptor += 1;
                        break;
                    case 14:
                        dElectroreceptor += 1;
                        break;
                    case 15:
                        dRedPigment += 1;
                        break;
                    case 16:
                        dProzrachnost += 1;
                        break;
                    case 17:
                        dChernyyPigment += 1;
                        break;
                    case 18:
                        dMimicria += 1;
                        break;
                    case 19:
                        dLuminiscencia += 1;
                        break;
                    case 20:
                        dToxiny += 1;
                        break;
                    case 21:
                        dRegeneration += 1;
                        break;
                    case 22:
                        dEvisceration += 1;
                        break;
                    case 23:
                        dPedicellariy += 1;
                        break;
                    case 24:
                        dPrisosky += 1;
                        break;
                    case 25:
                        dChernMeshok += 1;
                        break;
                    case 26:
                        dCuvierovi += 1;
                        break;
                    case 27:
                        dColloblasty += 1;
                        break;
                    case 28:
                        dCirri += 1;
                        break;
                    case 29:
                        dPlavniki += 1;
                        break;
                    case 30:
                        dImmunitet += 1;
                        break;
                    case 31:
                        dZuby += 1;
                        break;
                    case 32:
                        dDopPolost += 1;
                        break;
                    case 33:
                        dDopEnergia += 1;
                        break;
                    case 34:
                        dPheromones += 1;
                        break;
                    case 35:
                        dUskorennoeRazvitie += 1;
                        break;
                    case 36:
                        dMagnetic += 1;
                        break;
                    case 37:
                        dHemoreceptor += 1;
                        break;
                    case 38:
                        dMechanoreceptor += 1;
                        break;
                    case 39:
                        dHemoreceptor += 1;
                        break;
                    case 40:
                        dMechanoreceptor += 1;
                        break;
                    default:
                        break;
                }
                PlayerPrefs.SetFloat("dStatocyst", dStatocyst);
                PlayerPrefs.SetFloat("dHydropora", dHydropora);
                PlayerPrefs.SetFloat("dOsmolit", dOsmolit);
                PlayerPrefs.SetFloat("dLipid", dLipid);
                PlayerPrefs.SetFloat("dKrioprotector", dKrioprotector);
                PlayerPrefs.SetFloat("dGigantizm", dGigantizm);
                PlayerPrefs.SetFloat("dSliz", dSliz);
                PlayerPrefs.SetFloat("dPancer", dPancer);
                PlayerPrefs.SetFloat("dEcholocatia", dEcholocatia);
                PlayerPrefs.SetFloat("dHemoreceptor", dHemoreceptor);
                PlayerPrefs.SetFloat("dPhotoreceptor", dPhotoreceptor);
                PlayerPrefs.SetFloat("dMechanoreceptor", dMechanoreceptor);
                PlayerPrefs.SetFloat("dElectroreceptor", dElectroreceptor);
                PlayerPrefs.SetFloat("dRedPigment", dRedPigment);
                PlayerPrefs.SetFloat("dProzrachnost", dProzrachnost);
                PlayerPrefs.SetFloat("dChernyyPigment", dChernyyPigment);
                PlayerPrefs.SetFloat("dMimicria", dMimicria);
                PlayerPrefs.SetFloat("dLuminiscencia", dLuminiscencia);
                PlayerPrefs.SetFloat("dToxiny", dToxiny);
                PlayerPrefs.SetFloat("dRegeneration", dRegeneration);
                PlayerPrefs.SetFloat("dEvisceration", dEvisceration);
                PlayerPrefs.SetFloat("dPedicellariy", dPedicellariy);
                PlayerPrefs.SetFloat("dPrisosky", dPrisosky);
                PlayerPrefs.SetFloat("dChernMeshok", dChernMeshok);
                PlayerPrefs.SetFloat("dCuvierovi", dCuvierovi);
                PlayerPrefs.SetFloat("dColloblasty", dColloblasty);
                PlayerPrefs.SetFloat("dCirri", dCirri);
                PlayerPrefs.SetFloat("dPlavniki", dPlavniki);
                PlayerPrefs.SetFloat("dImmunitet", dImmunitet);
                PlayerPrefs.SetFloat("dZuby", dZuby);
                PlayerPrefs.SetFloat("dDopPolost", dDopPolost);
                PlayerPrefs.SetFloat("dDopEnergia", dDopEnergia);
                PlayerPrefs.SetFloat("dPheromones", dPheromones);
                PlayerPrefs.SetFloat("dDegradation", dDegradation);
                PlayerPrefs.SetFloat("dUskorennoeRazvitie", dUskorennoeRazvitie);
                PlayerPrefs.SetFloat("dMagnetic", dMagnetic);
            }
            // ��� ������������ ����, ������� ����� �������
            PlayerPrefs.SetFloat("readStatocyst", readStatocyst);
            PlayerPrefs.SetFloat("readHydropora", readHydropora);
            PlayerPrefs.SetFloat("readOsmolit", readOsmolit);
            PlayerPrefs.SetFloat("readLipid", readLipid);
            PlayerPrefs.SetFloat("readKrioprotector", readKrioprotector);
            PlayerPrefs.SetFloat("readGigantizm", readGigantizm);
            PlayerPrefs.SetFloat("readSliz", readSliz);
            PlayerPrefs.SetFloat("readPancer", readPancer);
            PlayerPrefs.SetFloat("readEcholocatia", readEcholocatia);
            PlayerPrefs.SetFloat("readHemoreceptor", readHemoreceptor);
            PlayerPrefs.SetFloat("readPhotoreceptor", readPhotoreceptor);
            PlayerPrefs.SetFloat("readMechanoreceptor", readMechanoreceptor);
            PlayerPrefs.SetFloat("readElectroreceptor", readElectroreceptor);
            PlayerPrefs.SetFloat("readRedPigment", readRedPigment);
            PlayerPrefs.SetFloat("readProzrachnost", readProzrachnost);
            PlayerPrefs.SetFloat("readChernyyPigment", readChernyyPigment);
            PlayerPrefs.SetFloat("readMimicria", readMimicria);
            PlayerPrefs.SetFloat("readLuminiscencia", readLuminiscencia);
            PlayerPrefs.SetFloat("readToxiny", readToxiny);
            PlayerPrefs.SetFloat("readRegeneration", readRegeneration);
            PlayerPrefs.SetFloat("readEvisceration", readEvisceration);
            PlayerPrefs.SetFloat("readPedicellariy", readPedicellariy);
            PlayerPrefs.SetFloat("readPrisosky", readPrisosky);
            PlayerPrefs.SetFloat("readChernMeshok", readChernMeshok);
            PlayerPrefs.SetFloat("readCuvierovi", readCuvierovi);
            PlayerPrefs.SetFloat("readColloblasty", readColloblasty);
            PlayerPrefs.SetFloat("readCirri", readCirri);
            PlayerPrefs.SetFloat("readPlavniki", readPlavniki);
            PlayerPrefs.SetFloat("readImmunitet", readImmunitet);
            PlayerPrefs.SetFloat("readZuby", readZuby);
            PlayerPrefs.SetFloat("readDopPolost", readDopPolost);
            PlayerPrefs.SetFloat("readDopEnergia", readDopEnergia);
            PlayerPrefs.SetFloat("readPheromones", readPheromones);
            PlayerPrefs.SetFloat("readUskorennoeRazvitie", readUskorennoeRazvitie);
            PlayerPrefs.SetFloat("readMagnetic", readMagnetic);
            PlayerPrefs.Save();
            // ����� �� ������ ������� ������� �������
            GameObject[] gens = GameObject.FindGameObjectsWithTag("Gen");
            foreach (GameObject gen in gens)
                GameObject.Destroy(gen);

            IkraGenKey = false;
            StatocystKey = false;
            HydroporaKey = false;
            OsmolitKey = false;
            LipidKey = false;
            KrioprotectorKey = false;
            GigantizmKey = false;
            SlizKey = false;
            PancerKey = false;
            EcholocatiaKey = false;
            HemoreceptorKey = false;
            PhotoreceptorKey = false;
            MechanoreceptorKey = false;
            ElectroreceptorKey = false;
            RedPigmentKey = false;
            ProzrachnostKey = false;
            ChernyyPigmentKey = false;
            MimicriaKey = false;
            LuminiscenciaKey = false;
            ToxinyKey = false;
            RegenerationKey = false;
            EviscerationKey = false;
            PedicellariyKey = false;
            PrisoskyKey = false;
            ChernMeshokKey = false;
            CuvieroviKey = false;
            ColloblastyKey = false;
            CirriKey = false;
            PlavnikiKey = false;
            ImmunitetKey = false;
            ZubyKey = false;
            DopPolostKey = false;
            DopEnergiaKey = false;
            PheromonesKey = false;
            DegradationKey = false;
            UskorennoeRazvitieKey = false;
            MagneticKey = false;
            mermaids.randomGenIkornyy = 0;
            mermaids.genPlace2 = 0;
            mermaids.genPlace1 = 0;
            KeyLight1.SetActive(false);
            KeyLight2.SetActive(false);
            KeyLight3.SetActive(false);
            mermaids.presentGaremYes.SetActive(false);
            confirms.podtverjdenoTapom = false;
            confirms.nepodtverjdenoTapom = false;
            confirms.podtverjdenoOk = false;
            mermaids.presentGaremIkra.SetActive(false);
            mermaids.presentGaremBack.SetActive(false);
            presentGaremBackSp.SetActive(false);

        }

        // ��� ���������� ����, ���� ��� ������� ��� ������
        if (player.nagradoid == true && confirms.podtverjdenoTapom == true)
        {
            battleModeVisibility.skippingMode = true;
        }


        // ���������� ����� ������ �� ��� �����
        if (maximumSpritsa == false)
        {
            maximumSpritsa = true;
            maximumSprits = 4;
            if (pUskorennoeRazvitie == 2)
            {
                maximumSprits = Random.Range(3, 5);
            }
            if (pUskorennoeRazvitie == 3)
            {
                maximumSprits = 5;
            }
            GenSlider.maxValue = 5;
            GenObmanSlider.maxValue = 15;
        }

        // ������������� � ������ �����
        if (SpritsUsed == false)
        {
            GenSlider.value = forSprits;
            GenObmanSlider.value = forSprits;
            if (currentSprits > forSprits)
            {
                forSprits += 0.1f;
            }
            if (currentSprits < forSprits)
            {
                forSprits -= 0.1f;
            }
            


        }

        // �������� ������ ����� �� �����, � ���� ��� ������ �������� ������
        if (distancePoints.distance <= 5050 && leveler.settingsMode.activeSelf == false)
        {
            genButton.SetActive(true);
        }
        if (distancePoints.distance <= 5050 && leveler.settingsMode.activeSelf == true)
        {
            genButton.SetActive(false);
        }
    }












    // ������� �� ������� �� ������ �����
    public void tapGens()
    {
        // ������ ��������� ����
        if (gensBack.activeSelf == true && confirms.noteBack.activeSelf == false && confirms.confirmBack.activeSelf == false)
        {
            music.closesound.Play();
            if (currentRs > 0 && SpritsUsed == false)
            {
                indicatorGenes.SetActive(true);
                pulsation = true;
            }
            kletinki.SetActive(false);
            Kletochka1.SetActive(false);
            Kletochka2.SetActive(false);
            Kletochka3.SetActive(false);
            Kletochka4.SetActive(false);
            Kletochka5.SetActive(false);
            Kletochka6.SetActive(false);
            Kletochka7.SetActive(false);
            Kletochka8.SetActive(false);
            Kletochka9.SetActive(false);
            gensBack.SetActive(false);
            descriptionGenes.SetActive(false);
            adoptationTab.SetActive(false);
            receptorsTab.SetActive(false);
            battleTab.SetActive(false);
            pigmentTab.SetActive(false);
            progressTab.SetActive(false);
            receptorsWhite.SetActive(false);
            adoptionWhite.SetActive(false);
            progressWhite.SetActive(false);
            pigmentWhite.SetActive(false);
            battleWhite.SetActive(false);
            receptorsButton.SetActive(false);
            adoptionButton.SetActive(false);
            progressButton.SetActive(false);
            pigmentButton.SetActive(false);
            battleButton.SetActive(false);
            genSpravka.SetActive(false);
        }
        // �������, ��� ������� ������ ��������� ����
        else
        {
            music.opensound.Play();
            indicatorGenes.SetActive(false);
            pulsation = false;
            kletinki.SetActive(false);
            Kletochka1.SetActive(false);
            Kletochka2.SetActive(false);
            Kletochka3.SetActive(false);
            Kletochka4.SetActive(false);
            Kletochka5.SetActive(false);
            Kletochka6.SetActive(false);
            Kletochka7.SetActive(false);
            Kletochka8.SetActive(false);
            Kletochka9.SetActive(false);
            adoptationTab.SetActive(false);
            receptorsTab.SetActive(false);
            battleTab.SetActive(false);
            pigmentTab.SetActive(false);
            progressTab.SetActive(false);
            receptorsWhite.SetActive(false);
            adoptionWhite.SetActive(false);
            progressWhite.SetActive(false);
            pigmentWhite.SetActive(false);
            battleWhite.SetActive(false);
            receptorsButton.SetActive(true);
            adoptionButton.SetActive(true);
            progressButton.SetActive(true);
            pigmentButton.SetActive(true);
            battleButton.SetActive(true);
            gensBack.SetActive(true); // � ���� ����������� � �������, � ��������
            descriptionGenes.SetActive(true);
            nazvanieText.text = " ";
            descriptionText.text = " ";
            // ������ �������, ��������, ���� ��� ������� �������
            if (leveler.languager == 0)
            {
                spravkaText1.text = "new available genes";
                spravkaText2.text = "new inserted genes";
                spravkaText3.text = "degrading genes";
            }
            if (leveler.languager == 1)
            {
                spravkaText1.text = "����� ����";
                spravkaText2.text = "���������� ����";
                spravkaText3.text = "������������� ����";
            }
            else if (leveler.languager == 2)
            {
                spravkaText1.text = "��� ������� ����";
                spravkaText2.text = "������������� ����";
                spravkaText3.text = "����, �� ����������";
            }
            genSpravka.SetActive(true);
            // ����� ����������, ��������������� �����
            
        }
    }

    public void tapGensOnlyClose()
    {
        if (adoptationTab.activeSelf == false && receptorsTab.activeSelf == false && battleTab.activeSelf == false && pigmentTab.activeSelf == false && progressTab.activeSelf == false)
        {
            music.closesound.Play();
            if (currentRs > 0 && SpritsUsed == false)
            {
                indicatorGenes.SetActive(true);
                pulsation = true;
            }
            kletinki.SetActive(false);
            Kletochka1.SetActive(false);
            Kletochka2.SetActive(false);
            Kletochka3.SetActive(false);
            Kletochka4.SetActive(false);
            Kletochka5.SetActive(false);
            Kletochka6.SetActive(false);
            Kletochka7.SetActive(false);
            Kletochka8.SetActive(false);
            Kletochka9.SetActive(false);
            gensBack.SetActive(false);
            descriptionGenes.SetActive(false);
            adoptationTab.SetActive(false);
            receptorsTab.SetActive(false);
            battleTab.SetActive(false);
            pigmentTab.SetActive(false);
            progressTab.SetActive(false);
            receptorsWhite.SetActive(false);
            adoptionWhite.SetActive(false);
            progressWhite.SetActive(false);
            pigmentWhite.SetActive(false);
            battleWhite.SetActive(false);
            receptorsButton.SetActive(false);
            adoptionButton.SetActive(false);
            progressButton.SetActive(false);
            pigmentButton.SetActive(false);
            battleButton.SetActive(false);
            genSpravka.SetActive(false);
        }
    }

    // ������ ������� ����������
    public void tapReceptorSpiral()
    {
        // �������, ��� ������� ������ ��������� ����
        if (confirms.noteBack.activeSelf == false && confirms.confirmBack.activeSelf == false)
        {

            // ��������� ��� ����� � �� �������
            kletinki.SetActive(false);
            Kletochka1.SetActive(false);
            Kletochka2.SetActive(false);
            Kletochka3.SetActive(false);
            Kletochka4.SetActive(false);
            Kletochka5.SetActive(false);
            Kletochka6.SetActive(false);
            Kletochka7.SetActive(false);
            Kletochka8.SetActive(false);
            Kletochka9.SetActive(false);
            genSpravka.SetActive(false);
            adoptationTab.SetActive(false);
            receptorsTab.SetActive(false);
            battleTab.SetActive(false);
            pigmentTab.SetActive(false);
            progressTab.SetActive(false);
            receptorsWhite.SetActive(false);
            adoptionWhite.SetActive(false);
            progressWhite.SetActive(false);
            pigmentWhite.SetActive(false);
            battleWhite.SetActive(false);
            // ��������� �����, �������, ��������� ������, ��������� ������ ������
            receptorsTab.SetActive(true);
            receptorsWhite.SetActive(true);
            receptorsButton.SetActive(false);
            adoptionButton.SetActive(true);
            progressButton.SetActive(true);
            pigmentButton.SetActive(true);
            battleButton.SetActive(true);
            nazvanieText.text = " ";
            descriptionText.text = " ";
        }
    }
    // ������ ������� ���������
    public void tapAdaptationSpiral()
    {
        // �������, ��� ������� ������ ��������� ����
        if (confirms.noteBack.activeSelf == false && confirms.confirmBack.activeSelf == false)
        {
            kletinki.SetActive(false);
            Kletochka1.SetActive(false);
            Kletochka2.SetActive(false);
            Kletochka3.SetActive(false);
            Kletochka4.SetActive(false);
            Kletochka5.SetActive(false);
            Kletochka6.SetActive(false);
            Kletochka7.SetActive(false);
            Kletochka8.SetActive(false);
            Kletochka9.SetActive(false);
            genSpravka.SetActive(false);
            adoptationTab.SetActive(false);
            receptorsTab.SetActive(false);
            battleTab.SetActive(false);
            pigmentTab.SetActive(false);
            progressTab.SetActive(false);
            receptorsWhite.SetActive(false);
            adoptionWhite.SetActive(false);
            progressWhite.SetActive(false);
            pigmentWhite.SetActive(false);
            battleWhite.SetActive(false);

            adoptationTab.SetActive(true);
            adoptionWhite.SetActive(true);
            receptorsButton.SetActive(true);
            adoptionButton.SetActive(false);
            progressButton.SetActive(true);
            pigmentButton.SetActive(true);
            battleButton.SetActive(true);
            nazvanieText.text = " ";
            descriptionText.text = " ";
        }
    }
    // ������ ������� ���������
    public void tapProgressSpiral()
    {
        // �������, ��� ������� ������ ��������� ����
        if (confirms.noteBack.activeSelf == false && confirms.confirmBack.activeSelf == false)
        {
            kletinki.SetActive(false);
            Kletochka1.SetActive(false);
            Kletochka2.SetActive(false);
            Kletochka3.SetActive(false);
            Kletochka4.SetActive(false);
            Kletochka5.SetActive(false);
            Kletochka6.SetActive(false);
            Kletochka7.SetActive(false);
            Kletochka8.SetActive(false);
            Kletochka9.SetActive(false);
            genSpravka.SetActive(false);
            adoptationTab.SetActive(false);
            receptorsTab.SetActive(false);
            battleTab.SetActive(false);
            pigmentTab.SetActive(false);
            progressTab.SetActive(false);
            receptorsWhite.SetActive(false);
            adoptionWhite.SetActive(false);
            progressWhite.SetActive(false);
            pigmentWhite.SetActive(false);
            battleWhite.SetActive(false);

            progressTab.SetActive(true);
            progressWhite.SetActive(true);
            receptorsButton.SetActive(true);
            adoptionButton.SetActive(true);
            progressButton.SetActive(false);
            pigmentButton.SetActive(true);
            battleButton.SetActive(true);
            nazvanieText.text = " ";
            descriptionText.text = " ";
        }
    }
    // ������ ������� ��������
    public void tapPigmentSpiral()
    {
        // �������, ��� ������� ������ ��������� ����
        if (confirms.noteBack.activeSelf == false && confirms.confirmBack.activeSelf == false)
        {
            kletinki.SetActive(false);
            Kletochka1.SetActive(false);
            Kletochka2.SetActive(false);
            Kletochka3.SetActive(false);
            Kletochka4.SetActive(false);
            Kletochka5.SetActive(false);
            Kletochka6.SetActive(false);
            Kletochka7.SetActive(false);
            Kletochka8.SetActive(false);
            Kletochka9.SetActive(false);
            genSpravka.SetActive(false);
            adoptationTab.SetActive(false);
            receptorsTab.SetActive(false);
            battleTab.SetActive(false);
            pigmentTab.SetActive(false);
            progressTab.SetActive(false);
            receptorsWhite.SetActive(false);
            adoptionWhite.SetActive(false);
            progressWhite.SetActive(false);
            pigmentWhite.SetActive(false);
            battleWhite.SetActive(false);

            pigmentTab.SetActive(true);
            pigmentWhite.SetActive(true);
            receptorsButton.SetActive(true);
            adoptionButton.SetActive(true);
            progressButton.SetActive(true);
            pigmentButton.SetActive(false);
            battleButton.SetActive(true);
            nazvanieText.text = " ";
            descriptionText.text = " ";
        }
    }
    // ������ ������� �����
    public void tapBattleSpiral()
    {
        // �������, ��� ������� ������ ��������� ����
        if (confirms.noteBack.activeSelf == false && confirms.confirmBack.activeSelf == false)
        {
            kletinki.SetActive(false);
            Kletochka1.SetActive(false);
            Kletochka2.SetActive(false);
            Kletochka3.SetActive(false);
            Kletochka4.SetActive(false);
            Kletochka5.SetActive(false);
            Kletochka6.SetActive(false);
            Kletochka7.SetActive(false);
            Kletochka8.SetActive(false);
            Kletochka9.SetActive(false);
            genSpravka.SetActive(false);
            adoptationTab.SetActive(false);
            receptorsTab.SetActive(false);
            battleTab.SetActive(false);
            pigmentTab.SetActive(false);
            progressTab.SetActive(false);
            receptorsWhite.SetActive(false);
            adoptionWhite.SetActive(false);
            progressWhite.SetActive(false);
            pigmentWhite.SetActive(false);
            battleWhite.SetActive(false);

            battleTab.SetActive(true);
            battleWhite.SetActive(true);
            receptorsButton.SetActive(true);
            adoptionButton.SetActive(true);
            progressButton.SetActive(true);
            pigmentButton.SetActive(true);
            battleButton.SetActive(false);
            nazvanieText.text = " ";
            descriptionText.text = " ";
        }
    }
    // �������� ��������
    public void tapCloseSpiral()
    {
        if (confirms.noteBack.activeSelf == false && confirms.confirmBack.activeSelf == false)
        {
            kletinki.SetActive(false);
            Kletochka1.SetActive(false);
            Kletochka2.SetActive(false);
            Kletochka3.SetActive(false);
            Kletochka4.SetActive(false);
            Kletochka5.SetActive(false);
            Kletochka6.SetActive(false);
            Kletochka7.SetActive(false);
            Kletochka8.SetActive(false);
            Kletochka9.SetActive(false);
            adoptationTab.SetActive(false);
            receptorsTab.SetActive(false);
            battleTab.SetActive(false);
            pigmentTab.SetActive(false);
            progressTab.SetActive(false);
            receptorsWhite.SetActive(false);
            adoptionWhite.SetActive(false);
            progressWhite.SetActive(false);
            pigmentWhite.SetActive(false);
            battleWhite.SetActive(false);
            receptorsButton.SetActive(true);
            adoptionButton.SetActive(true);
            progressButton.SetActive(true);
            pigmentButton.SetActive(true);
            battleButton.SetActive(true);
            nazvanieText.text = " ";
            descriptionText.text = " ";
            // ������ �������, ��������, ���� ��� ������� �������
            if (leveler.languager == 0)
            {
                spravkaText1.text = "new available genes";
                spravkaText2.text = "new inserted genes";
                spravkaText3.text = "degrading genes";
            }
            if (leveler.languager == 1)
            {
                spravkaText1.text = "����� ����";
                spravkaText2.text = "���������� ����";
                spravkaText3.text = "������������� ����";
            }
            else if (leveler.languager == 2)
            {
                spravkaText1.text = "��� ������� ����";
                spravkaText2.text = "������������� ����";
                spravkaText3.text = "����, �� ����������";
            }
            genSpravka.SetActive(true);
        }
    }





// ������� �� ���� 1
public void place1GaremDescription()
    {
        confirms.podtverjdenoTapom = false;
        mermaids.presentGaremYes.SetActive(false);
        KeyLight1.SetActive(false);
        KeyLight2.SetActive(false);
        KeyLight3.SetActive(false);

        IkraGenKey = false;
        StatocystKey = false;
        HydroporaKey = false;
        OsmolitKey = false;
        LipidKey = false;
        KrioprotectorKey = false;
        GigantizmKey = false;
        SlizKey = false;
        PancerKey = false;
        EcholocatiaKey = false;
        HemoreceptorKey = false;
        PhotoreceptorKey = false;
        MechanoreceptorKey = false;
        ElectroreceptorKey = false;
        RedPigmentKey = false;
        ProzrachnostKey = false;
        ChernyyPigmentKey = false;
        MimicriaKey = false;
        LuminiscenciaKey = false;
        ToxinyKey = false;
        RegenerationKey = false;
        EviscerationKey = false;
        PedicellariyKey = false;
        PrisoskyKey = false;
        ChernMeshokKey = false;
        CuvieroviKey = false;
        ColloblastyKey = false;
        CirriKey = false;
        PlavnikiKey = false;
        ImmunitetKey = false;
        ZubyKey = false;
        DopPolostKey = false;
        DopEnergiaKey = false;
        PheromonesKey = false;
        DegradationKey = false;
        UskorennoeRazvitieKey = false;
        MagneticKey = false;
        mermaids.presentGaremText2.text = " ";

        if (mermaids.genPlace1 == 1)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Statoliths \n\nCell 5 isn`t blocked \ndue to high pressure";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "��������� \n\n������ 5 �� ����������� \n��-�� �������� ��������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "�������� \n\n������ 5 ���������� �� \n�������� �����";
            }
            KeyLight1.SetActive(true);
            StatocystKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace1 == 2)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Hydropores \n\nCell 7 isn`t blocked \ndue to high pressure";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "��������� \n\n������ 7 �� ����������� \n��-�� �������� ��������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "ó������� \n\n������ 7 ���������� �� \n�������� �����";
            }
            KeyLight1.SetActive(true);
            HydroporaKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace1 == 3)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Osmoreception \n\nEnemy cell 8 is visible \ndue to developed \nreceptors";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "������������ \n\n��������� ������ 8 ����� \n��������� �������� \n����������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "������������ \n\n���������� ������ 8 ����� \n������� ���������� \n����������";
            }
            KeyLight1.SetActive(true);
            OsmolitKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace1 == 4)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Lipids \n\nCell 9 isn`t blocked \ndue to high pressure";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "������ \n\n������ 9 �� ����������� \n��-�� �������� ��������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "˳��� \n\n������ 9 ���������� \n�� �������� �����";
            }
            KeyLight1.SetActive(true);
            LipidKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace1 == 5)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Thermoreception \n\nEnemy cell 7 is visible \ndue to developed \nreceptors";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "������������� \n\n��������� ������ 7 ����� \n��������� �������� \n����������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "������������� \n\n���������� ������ 7 ����� \n������� ���������� \n����������";
            }
            KeyLight1.SetActive(true);
            KrioprotectorKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace1 == 6)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Gigantism \n\nCell 8 isn`t blocked \ndue to high pressure";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "��������� \n\n������ 8 �� ����������� \n��-�� �������� ��������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "ó������� \n\n������ 8 ���������� \n�� �������� �����";
            }
            KeyLight1.SetActive(true);
            GigantizmKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace1 == 7)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Gelatinity, mucus \n\nCell 4 isn`t blocked \ndue to high pressure";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "�������������, ����� \n\n������ 4 �� ����������� \n��-�� �������� ��������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "������������, ���� \n\n������ 4 ���������� �� \n�������� �����";
            }
            KeyLight1.SetActive(true);
            SlizKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace1 == 8)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Hard body covering \n\nCell 6 isn`t blocked \ndue to high pressure";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "������ ������� \n\n������ 6 �� ����������� \n��-�� �������� ��������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "����� ������� \n\n������ 6 ���������� �� \n�������� �����";
            }
            KeyLight1.SetActive(true);
            PancerKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace1 == 9)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Echolocation \n\nMore creatures found \nin biomes";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "���������� \n\n�� ������ ����������� \n������ �������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "���������� \n\n�� ����� ����������� \n����� �����";
            }
            KeyLight1.SetActive(true);
            EcholocatiaKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace1 == 10)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Chemoreception \n\nEnemy cell 4 is visible \ndue to developed \nreceptors";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "������������ \n\n��������� ������ 4 ����� \n��������� �������� \n����������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "������������ \n\n���������� ������ 4 ����� \n������� ���������� \n����������";
            }
            KeyLight1.SetActive(true);
            HemoreceptorKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace1 == 11)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Photoreception \n\nEnemy cell 5 is visible \ndue to developed \nreceptors";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "������������ \n\n��������� ������ 5 ����� \n��������� �������� \n����������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "������������ \n\n���������� ������ 5 ����� \n������� ���������� \n����������";
            }
            KeyLight1.SetActive(true);
            PhotoreceptorKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace1 == 12)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Mechanoreception \n\nEnemy cell 6 is visible \ndue to developed \nreceptors";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "�������������� \n\n��������� ������ 6 ����� \n��������� �������� \n����������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "�������������� \n\n���������� ������ 6 ����� \n������� ���������� \n����������";
            }
            KeyLight1.SetActive(true);
            MechanoreceptorKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace1 == 13)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Electroreception \n\nAttracting one new companion \nduring the escape is \npossible";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "��������������� \n\n��� ������ ����� �������� �� \n����� ����� ��������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "��������������� \n\n��� ����� ����� �������� �� \n����� ���� ���������";
            }
            KeyLight1.SetActive(true);
            ElectroreceptorKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace1 == 14)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Red pigmentation \n\nHealing skills";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "������� ����������� \n\n������ ���������� \n�������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "������� ���������� \n\n������ ��������� �� \n��������";
            }
            KeyLight1.SetActive(true);
            RedPigmentKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace1 == 15)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Transparency \n\nDefensive skills";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "������������ \n\n������ �������� �������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "��������� \n\n������ ��������� �� \n�������";
            }

            KeyLight1.SetActive(true);
            ProzrachnostKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace1 == 16)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Black pigmentation \n\nOffensive skills";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "׸���� ����������� \n\n������ ��������� �������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "����� ���������� \n\n������ ��������� ����";
            }
            KeyLight1.SetActive(true);
            ChernyyPigmentKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace1 == 17)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Mimicry \n\nEscape chance is doubled";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "�������� \n\n���� ������ ����� ����";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "̳���� \n\n���� ����� ����� ������";
            }
            KeyLight1.SetActive(true);
            MimicriaKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace1 == 18)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Bioluminescence \n\nBlocking skills";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "���������������� \n\n������ ����������� �������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "�������������� \n\n������ ��������� �� \n����������";
            }
            KeyLight1.SetActive(true);
            LuminiscenciaKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }

        if (mermaids.genPlace1 == 19)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Toxins \n\nMulti-turn skills";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "������� \n\n������ �������, \n����������� ��������� \n�����";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "������� \n\n������ ��������� � \n��������� ��������";
            }
            KeyLight1.SetActive(true);
            ToxinyKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace1 == 20)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Regeneration \n\nHealth-threatening skills";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "����������� \n\n������ ������� �������, \n������������ ��������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "����������� \n\n������ ���������, \n����������� ��� \n��������";
            }
            KeyLight1.SetActive(true);
            RegenerationKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace1 == 21)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Evisceration \n\nSkills used a limited \nnumber of times";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "����������� \n\n������ �������, \n������������ ������������ \n���������� ���";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "���������� \n\n������ ���������, \n��������� � �������� \n�������";
            }
            KeyLight1.SetActive(true);
            EviscerationKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace1 == 22)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Pedicellariae \n\nMelee skills";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "������������ \n\n������ ������� �������� \n���";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "��������� \n\n������ ��������� �� \n��������� ���";
            }
            KeyLight1.SetActive(true);
            PedicellariyKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace1 == 23)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Tentacles, suckers \n\nSkills from the middle \nrow";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "��������, �������� \n\n������ ������� ��� �� \n�������� ���� ������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "��������, �������� \n\n������ ��������� �� \n��� � ���������� \n����";
            }
            KeyLight1.SetActive(true);
            PrisoskyKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace1 == 24)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Ink bag \n\nMass destruction skills";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "���������� ����� \n\n������ ������� \n��������� ���������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "���������� ���� \n\n������� ����� \n�������� ��������";
            }
            KeyLight1.SetActive(true);
            ChernMeshokKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace1 == 25)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Cuvier tubules \n\nPoint focused skills";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "��������� �������� \n\n������ ������� \n�������� ���������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "���'���� �������� \n\n������� ����� \n��������� ��������";
            }
            KeyLight1.SetActive(true);
            CuvieroviKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }

        if (mermaids.genPlace1 == 26)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Colloblasts \n\nSkills for which \ntargets are chosen \nin groups";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "����������� \n\n������ �������, ��� \n������� ���� \n���������� �������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "���������� \n\n������ ���������, \n��� ���� ��� \n���������� �������";
            }
            KeyLight1.SetActive(true);
            ColloblastyKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace1 == 27)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Cirri, needles \n\nRanged skills";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "�����, ���� \n\n������ ������� �������� \n���";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "�����, ����� \n\n������ ��������� �� \n�������� ���";
            }
            KeyLight1.SetActive(true);
            CirriKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace1 == 28)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Fins \n\ndual skills";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "�������� \n\n������ ������ \n�������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "�������� \n\n������ ������ \n���������";
            }
            KeyLight1.SetActive(true);
            PlavnikiKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace1 == 29)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "High immunity \n\nProtection from defective \ngenes transferred from \ncompanions";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "������� ��������� \n\n������ �� ��������� �����, \n�������������� � �������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "������� ������� \n\n������ �� ��������� ����, \n����������� � ���������";
            }
            KeyLight1.SetActive(true);
            ImmunitetKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace1 == 30)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Teeth \n\nPower absorption skills";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "���� \n\n������ ������� ���������� \n���";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "���� \n\n������ ��������� �� \n���������� ���";
            }
            KeyLight1.SetActive(true);
            ZubyKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace1 == 31)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Additional cavity \n\nCompanion caviar loot \nincreased";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "�������������� ������� \n\n������ ���� �� �������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "��������� ��������� \n\n������ ���� �� ���������";
            }
            KeyLight1.SetActive(true);
            DopPolostKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace1 == 32)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Additional fat pad \n\nMore energy to make the \nfirst move constantly";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "������� ��������� \n\n������ ������� �� ��, ����� \n������ ������ ������ ���";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "������ �������� \n\n������ ����㳿 �� ��, ��� \n������ ������ ������";
            }
            KeyLight1.SetActive(true);
            DopEnergiaKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace1 == 33)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Pheromones \n\nSpending time with more \ncompanions is possible";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "�������� \n\n����� ���������� ����� \n������� ����� �����, \n��� ����� ��������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "�������� \n\n����� �������� ����� \n�����, �� ���� \n��������� �� ���";
            }
            KeyLight1.SetActive(true);
            PheromonesKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace1 == 34)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Reduction \n\nThe random gene can be \nreduced during the next \nexpedition";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "�������� \n\n��������� ��� ����� \n������������� �� ����� \n��������� ����������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "�������� \n\n���������� ��� ���� \n����������� �� ��� \n�������� ����������";
            }
            KeyLight1.SetActive(true);
            confirms.podtverjdenoTapom = false;
        }
        if (mermaids.genPlace1 == 35)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Intensive development \n\nUp to 5 genes can be \ninserted before diving \ninstead of 4";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "����������� �������� \n\n����� �������� 5 ����� \n������ 4 �� ����������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "����������� �������� \n\n����� ������ 5 ���� \n������ 4 �� ����������";
            }
            KeyLight1.SetActive(true);
            UskorennoeRazvitieKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace1 == 36)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Magnetoreception \n\nEnemy cell 9 is visible \ndue to developed \nreceptors";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "��������������� \n\n��������� ������ 9 ����� \n��������� �������� \n����������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "�������������� \n\n���������� ������ 9 ����� \n������� ���������� \n����������";
            }
            KeyLight1.SetActive(true);
            MagneticKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        
    }

    // ������� �� ���� 2
    public void place2GaremDescription()
    {
        confirms.podtverjdenoTapom = false;
        mermaids.presentGaremYes.SetActive(false);
        KeyLight1.SetActive(false);
        KeyLight2.SetActive(false);
        KeyLight3.SetActive(false);

        IkraGenKey = false;
        StatocystKey = false;
        HydroporaKey = false;
        OsmolitKey = false;
        LipidKey = false;
        KrioprotectorKey = false;
        GigantizmKey = false;
        SlizKey = false;
        PancerKey = false;
        EcholocatiaKey = false;
        HemoreceptorKey = false;
        PhotoreceptorKey = false;
        MechanoreceptorKey = false;
        ElectroreceptorKey = false;
        RedPigmentKey = false;
        ProzrachnostKey = false;
        ChernyyPigmentKey = false;
        MimicriaKey = false;
        LuminiscenciaKey = false;
        ToxinyKey = false;
        RegenerationKey = false;
        EviscerationKey = false;
        PedicellariyKey = false;
        PrisoskyKey = false;
        ChernMeshokKey = false;
        CuvieroviKey = false;
        ColloblastyKey = false;
        CirriKey = false;
        PlavnikiKey = false;
        ImmunitetKey = false;
        ZubyKey = false;
        DopPolostKey = false;
        DopEnergiaKey = false;
        PheromonesKey = false;
        DegradationKey = false;
        UskorennoeRazvitieKey = false;
        MagneticKey = false;
        mermaids.presentGaremText2.text = " ";

        if (mermaids.genPlace2 == 1)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Statoliths \n\nCell 5 isn`t blocked \ndue to high pressure";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "��������� \n\n������ 5 �� ����������� \n��-�� �������� ��������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "�������� \n\n������ 5 ���������� �� \n�������� �����";
            }
            KeyLight2.SetActive(true);
            StatocystKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace2 == 2)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Hydropores \n\nCell 7 isn`t blocked \ndue to high pressure";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "��������� \n\n������ 7 �� ����������� \n��-�� �������� ��������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "ó������� \n\n������ 7 ���������� �� \n�������� �����";
            }
            KeyLight2.SetActive(true);
            HydroporaKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace2 == 3)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Osmoreception \n\nEnemy cell 8 is visible \ndue to developed \nreceptors";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "������������ \n\n��������� ������ 8 ����� \n��������� �������� \n����������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "������������ \n\n���������� ������ 8 ����� \n������� ���������� \n����������";
            }
            KeyLight2.SetActive(true);
            OsmolitKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace2 == 4)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Lipids \n\nCell 9 isn`t blocked \ndue to high pressure";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "������ \n\n������ 9 �� ����������� \n��-�� �������� ��������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "˳��� \n\n������ 9 ���������� \n�� �������� �����";
            }
            KeyLight2.SetActive(true);
            LipidKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace2 == 5)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Thermoreception \n\nEnemy cell 7 is visible \ndue to developed \nreceptors";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "������������� \n\n��������� ������ 7 ����� \n��������� �������� \n����������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "������������� \n\n���������� ������ 7 ����� \n������� ���������� \n����������";
            }
            KeyLight2.SetActive(true);
            KrioprotectorKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace2 == 6)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Gigantism \n\nCell 8 isn`t blocked \ndue to high pressure";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "��������� \n\n������ 8 �� ����������� \n��-�� �������� ��������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "ó������� \n\n������ 8 ���������� \n�� �������� �����";
            }
            KeyLight2.SetActive(true);
            GigantizmKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace2 == 7)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Gelatinity, mucus \n\nCell 4 isn`t blocked \ndue to high pressure";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "�������������, ����� \n\n������ 4 �� ����������� \n��-�� �������� ��������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "������������, ���� \n\n������ 4 ���������� �� \n�������� �����";
            }
            KeyLight2.SetActive(true);
            SlizKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace2 == 8)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Hard body covering \n\nCell 6 isn`t blocked \ndue to high pressure";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "������ ������� \n\n������ 6 �� ����������� \n��-�� �������� ��������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "����� ������� \n\n������ 6 ���������� �� \n�������� �����";
            }
            KeyLight2.SetActive(true);
            PancerKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace2 == 9)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Echolocation \n\nMore creatures found \nin biomes";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "���������� \n\n����������� �������� ������ \n� �������������� �����";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "���������� \n\n�� ����� ����������� \n����� �����";
            }
            KeyLight2.SetActive(true);
            EcholocatiaKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace2 == 10)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Chemoreception \n\nEnemy cell 4 is visible \ndue to developed \nreceptors";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "������������ \n\n��������� ������ 4 ����� \n��������� �������� \n����������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "������������ \n\n���������� ������ 4 ����� \n������� ���������� \n����������";
            }
            KeyLight2.SetActive(true);
            HemoreceptorKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace2 == 11)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Photoreception \n\nEnemy cell 5 is visible \ndue to developed \nreceptors";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "������������ \n\n��������� ������ 5 ����� \n��������� �������� \n����������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "������������ \n\n���������� ������ 5 ����� \n������� ���������� \n����������";
            }
            KeyLight2.SetActive(true);
            PhotoreceptorKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace2 == 12)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Mechanoreception \n\nEnemy cell 6 is visible \ndue to developed \nreceptors";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "�������������� \n\n��������� ������ 6 ����� \n��������� �������� \n����������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "�������������� \n\n���������� ������ 6 ����� \n������� ���������� \n����������";
            }
            KeyLight2.SetActive(true);
            MechanoreceptorKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace2 == 13)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Electroreception \n\nAttracting one new companion \nduring the escape is \npossible";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "��������������� \n\n��� ������ ����� �������� �� \n����� ����� ��������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "��������������� \n\n��� ����� ����� �������� �� \n����� ���� ���������";
            }
            KeyLight2.SetActive(true);
            ElectroreceptorKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace2 == 14)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Red pigmentation \n\nHealing skills";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "������� ����������� \n\n������ ���������� \n�������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "������� ���������� \n\n������ ��������� �� \n��������";
            }
            KeyLight2.SetActive(true);
            RedPigmentKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace2 == 15)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Transparency \n\nDefensive skills";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "������������ \n\n������ �������� �������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "��������� \n\n������ ��������� �� \n�������";
            }

            KeyLight2.SetActive(true);
            ProzrachnostKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace2 == 16)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Black pigmentation \n\nOffensive skills";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "׸���� ����������� \n\n������ ��������� �������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "����� ���������� \n\n������ ��������� ����";
            }
            KeyLight2.SetActive(true);
            ChernyyPigmentKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace2 == 17)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Mimicry \n\nEscape chance is doubled";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "�������� \n\n���� ������ ����� ����";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "̳���� \n\n���� ����� ����� ������";
            }
            KeyLight2.SetActive(true);
            MimicriaKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace2 == 18)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Bioluminescence \n\nBlocking skills";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "���������������� \n\n������ ����������� �������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "�������������� \n\n������ ��������� �� \n����������";
            }
            KeyLight2.SetActive(true);
            LuminiscenciaKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }

        if (mermaids.genPlace2 == 19)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Toxins \n\nMulti-turn skills";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "������� \n\n������ �������, \n����������� ��������� \n�����";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "������� \n\n������ ��������� � \n��������� ��������";
            }
            KeyLight2.SetActive(true);
            ToxinyKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace2 == 20)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Regeneration \n\nHealth-threatening skills";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "����������� \n\n������ ������� �������, \n������������ ��������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "����������� \n\n������ ���������, \n����������� ��� \n��������";
            }
            KeyLight2.SetActive(true);
            RegenerationKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace2 == 21)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Evisceration \n\nSkills used a limited \nnumber of times";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "����������� \n\n������ �������, \n������������ ������������ \n���������� ���";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "���������� \n\n������ ���������, \n��������� � �������� \n�������";
            }
            KeyLight2.SetActive(true);
            EviscerationKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace2 == 22)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Pedicellariae \n\nMelee skills";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "������������ \n\n������ ������� �������� \n���";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "��������� \n\n������ ��������� �� \n��������� ���";
            }
            KeyLight2.SetActive(true);
            PedicellariyKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace2 == 23)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Tentacles, suckers \n\nSkills from the middle \nrow";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "��������, �������� \n\n������ ������� ��� �� \n�������� ���� ������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "��������, �������� \n\n������ ��������� �� \n��� � ���������� \n����";
            }
            KeyLight2.SetActive(true);
            PrisoskyKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace2 == 24)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Ink bag \n\nMass destruction skills";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "���������� ����� \n\n������ ������� \n��������� ���������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "���������� ���� \n\n������� ����� \n�������� ��������";
            }
            KeyLight2.SetActive(true);
            ChernMeshokKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace2 == 25)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Cuvier tubules \n\nPoint focused skills";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "��������� �������� \n\n������ ������� \n�������� ���������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "���'���� �������� \n\n������� ����� \n��������� ��������";
            }
            KeyLight2.SetActive(true);
            CuvieroviKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }

        if (mermaids.genPlace2 == 26)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Colloblasts \n\nSkills for which \ntargets are chosen \nin groups";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "����������� \n\n������ �������, ��� \n������� ���� \n���������� �������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "���������� \n\n������ ���������, \n��� ���� ��� \n���������� �������";
            }
            KeyLight2.SetActive(true);
            ColloblastyKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace2 == 27)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Cirri, needles \n\nRanged skills";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "�����, ���� \n\n������ ������� �������� \n���";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "�����, ����� \n\n������ ��������� �� \n�������� ���";
            }
            KeyLight2.SetActive(true);
            CirriKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace2 == 28)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Fins \n\ndual skills";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "�������� \n\n������ ������ \n�������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "�������� \n\n������ ������ \n���������";
            }
            KeyLight2.SetActive(true);
            PlavnikiKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace2 == 29)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "High immunity \n\nProtection from defective \ngenes transferred from \ncompanions";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "������� ��������� \n\n������ �� ��������� �����, \n�������������� � �������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "������� ������� \n\n������ �� ��������� ����, \n����������� � ���������";
            }
            KeyLight2.SetActive(true);
            ImmunitetKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace2 == 30)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Teeth \n\nPower absorption skills";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "���� \n\n������ ������� ���������� \n���";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "���� \n\n������ ��������� �� \n���������� ���";
            }
            KeyLight2.SetActive(true);
            ZubyKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace2 == 31)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Additional cavity \n\nCompanion caviar loot \nincreased";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "�������������� ������� \n\n������ ���� �� �������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "��������� ��������� \n\n������ ���� �� ���������";
            }
            KeyLight2.SetActive(true);
            DopPolostKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace2 == 32)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Additional fat pad \n\nMore energy to make the \nfirst move constantly";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "������� ��������� \n\n������ ������� �� ��, ����� \n������ ������ ������ ���";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "������ �������� \n\n������ ����㳿 �� ��, ��� \n������ ������ ������";
            }
            KeyLight2.SetActive(true);
            DopEnergiaKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace2 == 33)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Pheromones \n\nSpending time with more \ncompanions is possible";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "�������� \n\n����� ���������� ����� \n������� ����� ������, \n��� ����� ��������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "�������� \n\n����� �������� ����� \n�����, �� ���� \n��������� �� ���";
            }
            KeyLight2.SetActive(true);
            PheromonesKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace2 == 34)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Reduction \n\nThe random gene can be \nreduced during the next \nexpedition";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "�������� \n\n��������� ��� ����� \n������������� �� ����� \n��������� ����������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "�������� \n\n���������� ��� ���� \n����������� �� ��� \n�������� ����������";
            }
            KeyLight2.SetActive(true);
            confirms.podtverjdenoTapom = false;
        }
        if (mermaids.genPlace2 == 35)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Intensive development \n\nUp to 5 genes can be \ninserted before diving \ninstead of 4";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "����������� �������� \n\n����� �������� 5 ����� \n������ 4 �� ����������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "����������� �������� \n\n����� ������ 5 ���� \n������ 4 �� ����������";
            }
            KeyLight2.SetActive(true);
            UskorennoeRazvitieKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
        if (mermaids.genPlace2 == 36)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Magnetoreception \n\nEnemy cell 9 is visible \ndue to developed \nreceptors";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "��������������� \n\n��������� ������ 9 ����� \n��������� �������� \n����������";
            }
            else if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "�������������� \n\n���������� ������ 9 ����� \n������� ���������� \n����������";
            }
            KeyLight2.SetActive(true);
            MagneticKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
        }
    }

    // ������� �� ���� 3
    public void place3GaremDescription()
    {
        confirms.podtverjdenoTapom = false;
        mermaids.presentGaremYes.SetActive(false);
        KeyLight1.SetActive(false);
        KeyLight2.SetActive(false);
        KeyLight3.SetActive(false);

        IkraGenKey = false;
        StatocystKey = false;
        HydroporaKey = false;
        OsmolitKey = false;
        LipidKey = false;
        KrioprotectorKey = false;
        GigantizmKey = false;
        SlizKey = false;
        PancerKey = false;
        EcholocatiaKey = false;
        HemoreceptorKey = false;
        PhotoreceptorKey = false;
        MechanoreceptorKey = false;
        ElectroreceptorKey = false;
        RedPigmentKey = false;
        ProzrachnostKey = false;
        ChernyyPigmentKey = false;
        MimicriaKey = false;
        LuminiscenciaKey = false;
        ToxinyKey = false;
        RegenerationKey = false;
        EviscerationKey = false;
        PedicellariyKey = false;
        PrisoskyKey = false;
        ChernMeshokKey = false;
        CuvieroviKey = false;
        ColloblastyKey = false;
        CirriKey = false;
        PlavnikiKey = false;
        ImmunitetKey = false;
        ZubyKey = false;
        DopPolostKey = false;
        DopEnergiaKey = false;
        PheromonesKey = false;
        DegradationKey = false;
        UskorennoeRazvitieKey = false;
        MagneticKey = false;
        mermaids.presentGaremText2.text = " ";

        if (mermaids.randomGenIkornyy >= 0)
        {
            if (leveler.languager == 0)
            {
                mermaids.presentGaremText2.text = "Caviar: " + mermaids.randomGenIkornyy.ToString("F0") + "\n\ntastes better than the\nsynthetic surrogate\nfrom the surface";
            }
            if (leveler.languager == 1)
            {
                mermaids.presentGaremText2.text = "����: " + mermaids.randomGenIkornyy.ToString("F0") + "\n\n�������, ��� �������������\n�������� � �����������";
            }
            if (leveler.languager == 2)
            {
                mermaids.presentGaremText2.text = "����: " + mermaids.randomGenIkornyy.ToString("F0") + "\n\n�� ����������. �� ������� \n����� �� ��������� ����";
            }
            KeyLight3.SetActive(true);
            IkraGenKey = true;
            confirms.podtverjdenoTapom = false;
            mermaids.presentGaremYes.SetActive(true);
            
        }

    }

    // ������� �� ���
    public void SlizDescription()
    {
        // ��� ��������
        if (leveler.languager == 0)
        {
            nazvanieText.text = "Gelatinity, mucus";
            descriptionText.text = "Cell 4 is unblockable: \namorphousness and secretion \nincrease body maneuverability,\nequalize pressure";
        }
        if (leveler.languager == 1)
        {
            nazvanieText.text = "�������������, �����";
            descriptionText.text = "������ 4 �� �����������: \n���������� � ��������� ����� \n��������� ���� �������������, \n����������� ��������";
        }
        else if (leveler.languager == 2)
        {
            nazvanieText.text = "������������, ����";
            descriptionText.text = "������ 4 ���������� �� �����:\n��������� �� �������� �����\n������� ��� �����������, \n��������� ����";
        }
        kletinki.SetActive(true);
        Kletochka1.SetActive(false);
        Kletochka2.SetActive(false);
        Kletochka3.SetActive(false);
        Kletochka4.SetActive(false);
        Kletochka5.SetActive(true);
        Kletochka6.SetActive(false);
        Kletochka7.SetActive(false);
        Kletochka8.SetActive(false);
        Kletochka9.SetActive(false);
        if (SpritsUsed == false)
        {
            if (rSliz > 0 && currentSprits < maximumSprits) // �������� ���������, ���� ���� ����
            {
                rSliz -= 1;
                kachSliz += 1;
                // ����� �������� ����������
                if (degrodadoptPossibility + pPancer > 5 && degrodus1 == false)
                {
                    degrodus1 = true;
                    dPancer += 1;
                }
            }
            else if (rSliz > 0 && kachSliz > 0 && currentSprits == maximumSprits) // �������� ��������� ��������, ���� ������ ������
            {
                // ����� ���������� ��������� � ���� �� ���������
                if (degrodus1)
                {
                    dPancer -= 1;
                    degrodus1 = false;
                }
                rSliz += kachSliz;
                kachSliz = 0;
                
            }
            else if (rSliz == 0 && kachSliz > 0) // �������� ��������� ��������, ���� ������� ��������
            {
                // ����� ���������� ��������� � ���� �� ���������
                if (degrodus1)
                {
                    dPancer -= 1;
                    degrodus1 = false;
                }
                rSliz = kachSliz;
                kachSliz = 0;
                
            }

            // ������ �� ���������, ���� ����� ��������, � ���� ��� ������; ���� ������ ������; ���� ����� �����������;

        }
    }
    public void GigantizmDescription()
    {
        // ��� ��������
        if (leveler.languager == 0)
        {
            nazvanieText.text = "Gigantism";
            descriptionText.text = "Cell 8 is unblockable: \nthe larger the organism, \nthe longer it keeps warm \nand the slower it functions";
        }
        if (leveler.languager == 1)
        {
            nazvanieText.text = "���������";
            descriptionText.text = "������ 8 �� �����������:\n��� ������� ��������, ��� ������ \n�� ������ ����� � ��������� \n�������������";
        }
        else if (leveler.languager == 2)
        {
            nazvanieText.text = "ó�������";
            descriptionText.text = "������ 8 ���������� �� �����: \n��� ������ �������, ��� \n����� �� ������ ����� � \n�������� ���������";
        }
        kletinki.SetActive(true);
        Kletochka1.SetActive(true);
        Kletochka2.SetActive(false);
        Kletochka3.SetActive(false);
        Kletochka4.SetActive(false);
        Kletochka5.SetActive(false);
        Kletochka6.SetActive(false);
        Kletochka7.SetActive(false);
        Kletochka8.SetActive(false);
        Kletochka9.SetActive(false);
        if (SpritsUsed == false)
        {
            if (rGigantizm > 0 && currentSprits < maximumSprits) // �������� ���������, ���� ���� ����
            {
                rGigantizm -= 1;
                kachGigantizm += 1;
            }
            else if (rGigantizm > 0 && kachGigantizm > 0 && currentSprits == maximumSprits) // �������� ��������� ��������, ���� ������ ������
            {
                rGigantizm += kachGigantizm;
                kachGigantizm = 0;
            }
            else if (rGigantizm == 0 && kachGigantizm > 0) // �������� ��������� ��������, ���� ������� ��������
            {
                rGigantizm = kachGigantizm;
                kachGigantizm = 0;

            }
        }
    }

    public void StatocystDescription()
    {
        // ��� ��������
        if (leveler.languager == 0)
        {
            nazvanieText.text = "Statoliths";
            descriptionText.text = "Cell 5 is unblockable: \nthese organelles help \nmaintain balance and steadiness";
        }
        if (leveler.languager == 1)
        {
            nazvanieText.text = "���������";
            descriptionText.text = "������ 5 �� �����������: \n��� ��������� �������� ��������� \n���������� � ������������";
        }
        else if (leveler.languager == 2)
        {
            nazvanieText.text = "��������";
            descriptionText.text = "������ 5 ���������� �� �����: \n�� �������� ����������� \n�������� �������� � �������";
        }
        kletinki.SetActive(true);
        Kletochka1.SetActive(false);
        Kletochka2.SetActive(false);
        Kletochka3.SetActive(false);
        Kletochka4.SetActive(true);
        Kletochka5.SetActive(false);
        Kletochka6.SetActive(false);
        Kletochka7.SetActive(false);
        Kletochka8.SetActive(false);
        Kletochka9.SetActive(false);
        if (SpritsUsed == false)
        {
            if (rStatocyst > 0 && currentSprits < maximumSprits) // �������� ���������, ���� ���� ����
            {
                rStatocyst -= 1;
                kachStatocyst += 1;
            }
            else if (rStatocyst > 0 && kachStatocyst > 0 && currentSprits == maximumSprits) // �������� ��������� ��������, ���� ������ ������
            {
                rStatocyst += kachStatocyst;
                kachStatocyst = 0;
            }
            else if (rStatocyst == 0 && kachStatocyst > 0) // �������� ��������� ��������, ���� ������� ��������
            {
                rStatocyst = kachStatocyst;
                kachStatocyst = 0;

            }
        }
    }
    public void PancerDescription()
    {
        // ��� ��������
        if (leveler.languager == 0)
        {
            nazvanieText.text = "Hard body covering";
            descriptionText.text = "Cell 6 is unblockable: \nscales or shell protect \nthe body from deformation, \nbut impair its streamlining";
        }
        if (leveler.languager == 1)
        {
            nazvanieText.text = "������ �������";
            descriptionText.text = "������ 6 �� �����������:\n����� ��� ������� \n�������� �������� �� ����������, �� \n�������� ��� ������������";
        }
        else if (leveler.languager == 2)
        {
            nazvanieText.text = "����� �������";
            descriptionText.text = "������ 6 ���������� �� �����: \n����� ��� ������ ��������� \n������� �� ����������, ��� \n��������� ���� ��������";
        }
        kletinki.SetActive(true);
        Kletochka1.SetActive(false);
        Kletochka2.SetActive(false);
        Kletochka3.SetActive(true);
        Kletochka4.SetActive(false);
        Kletochka5.SetActive(false);
        Kletochka6.SetActive(false);
        Kletochka7.SetActive(false);
        Kletochka8.SetActive(false);
        Kletochka9.SetActive(false);
        if (SpritsUsed == false)
        {
            if (rPancer > 0 && currentSprits < maximumSprits) // �������� ���������, ���� ���� ����
            {
                rPancer -= 1;
                kachPancer += 1;
                // ����� ����������
                if (degrodadoptPossibility + pSliz > 5 && degrodus2 == false)
                {
                    dSliz += 1;
                    degrodus2 = true;
                }
                if (degrodpigmaPossibility + pProzrachnost > 5 && degrodus3 == false)
                {
                    dProzrachnost += 1;
                    degrodus3 = true;
                }
            }
            else if (rPancer > 0 && kachPancer > 0 && currentSprits == maximumSprits) // �������� ��������� ��������, ���� ������ ������
            {
                // ����� ���������� ��������� � ���� �� ���������
                if (degrodus2)
                {
                    dSliz -= 1;
                    degrodus2 = false;
                }
                if (degrodus3)
                {
                    dProzrachnost -= 1;
                    degrodus3 = false;
                }
                rPancer += kachPancer;
                kachPancer = 0;
            }
            else if (rPancer == 0 && kachPancer > 0) // �������� ��������� ��������, ���� ������� ��������
            {
                if (degrodus2)
                {
                    dSliz -= 1;
                    degrodus2 = false;
                }
                if (degrodus3)
                {
                    dProzrachnost -= 1;
                    degrodus3 = false;
                }
                rPancer = kachPancer;
                kachPancer = 0;

            }
        }
    }
    public void HydroporaDescription()
    {
        // ��� ��������
        if (leveler.languager == 0)
        {
            nazvanieText.text = "Hydropores";
            descriptionText.text = "Cell 7 is unblockable: \na special water filtration system \nequalizes internal and external \npressure";
        }
        if (leveler.languager == 1)
        {
            nazvanieText.text = "���������";
            descriptionText.text = "������ 7 �� �����������:\n������ ������� \n���������� ���� �������������� \n���������� � ������� ��������";
        }
        else if (leveler.languager == 2)
        {
            nazvanieText.text = "ó�������";
            descriptionText.text = "������ 7 ���������� �� �����: \n�������� ������� ���������� \n���� ��������� ������� \n�� �������� ����";
        }
        kletinki.SetActive(true);
        Kletochka1.SetActive(false);
        Kletochka2.SetActive(true);
        Kletochka3.SetActive(false);
        Kletochka4.SetActive(false);
        Kletochka5.SetActive(false);
        Kletochka6.SetActive(false);
        Kletochka7.SetActive(false);
        Kletochka8.SetActive(false);
        Kletochka9.SetActive(false);
        if (SpritsUsed == false)
        {
            if (rHydropora > 0 && currentSprits < maximumSprits) // �������� ���������, ���� ���� ����
            {
                rHydropora -= 1;
                kachHydropora += 1;
            }
            else if (rHydropora > 0 && kachHydropora > 0 && currentSprits == maximumSprits) // �������� ��������� ��������, ���� ������ ������
            {
                rHydropora += kachHydropora;
                kachHydropora = 0;
            }
            else if (rHydropora == 0 && kachHydropora > 0) // �������� ��������� ��������, ���� ������� ��������
            {
                rHydropora = kachHydropora;
                kachHydropora = 0;

            }
        }
    }
    public void LipidDescription()
    {
        // ��� ��������
        if (leveler.languager == 0)
        {
            nazvanieText.text = "Lipids";
            descriptionText.text = "Cell 9 is unblockable: \na fat-filled swim bladder \nprovides buoyancy but \nreduces the echolocation ability";
        }
        if (leveler.languager == 1)
        {
            nazvanieText.text = "������";
            descriptionText.text = "������ 9 �� �����������:\n������ ���� ������������ ������ \n������������ ����������, \n�� ���������� ����������";
        }
        else if (leveler.languager == 2)
        {
            nazvanieText.text = "˳���";
            descriptionText.text = "������ 9 ���������� �� �����: \n������ ���� ���������� ���� \n��������� ����������, \n��� ��������� ����������";
        }
        kletinki.SetActive(true);
        Kletochka1.SetActive(true);
        Kletochka2.SetActive(false);
        Kletochka3.SetActive(false);
        Kletochka4.SetActive(false);
        Kletochka5.SetActive(false);
        Kletochka6.SetActive(false);
        Kletochka7.SetActive(false);
        Kletochka8.SetActive(false);
        Kletochka9.SetActive(false);
        if (SpritsUsed == false)
        {
            if (rLipid > 0 && currentSprits < maximumSprits) // �������� ���������, ���� ���� ����
            {
                rLipid -= 1;
                kachLipid += 1;
                if (degrodreceptPossibility + pEcholocatia > 5 && degrodus4 == false)
                {
                    dEcholocatia += 1;
                    degrodus4 = true;
                }
            }
            else if (rLipid > 0 && kachLipid > 0 && currentSprits == maximumSprits) // �������� ��������� ��������, ���� ������ ������
            {
                if (degrodus4)
                {
                    dEcholocatia -= 1;
                    degrodus4 = false;
                }
                rLipid += kachLipid;
                kachLipid = 0;
            }
            else if (rLipid == 0 && kachLipid > 0) // �������� ��������� ��������, ���� ������� ��������
            {
                if (degrodus4)
                {
                    dEcholocatia -= 1;
                    degrodus4 = false;
                }
                rLipid = kachLipid;
                kachLipid = 0;

            }
        }
    }
    public void OsmolitDescription()
    {
        // ��� ��������
        if (leveler.languager == 0)
        {
            nazvanieText.text = "Osmoreception";
            descriptionText.text = "Enemy cell 8 is visible: \npressure changes no longer \ncause perceptual disturbances \nor destroy proteins";
        }
        if (leveler.languager == 1)
        {
            nazvanieText.text = "������������";
            descriptionText.text = "��������� ������ 8 ����� �����: \n������� ������� �� ��������� \n�������� �������� ��������� ������,\n����������������";
        }
        else if (leveler.languager == 2)
        {
            nazvanieText.text = "������������";
            descriptionText.text = "���������� ������ 8 ����� �����: \n������ ������� �� ���� ����� \n������ ������ ����, \n������������";
        }
        kletinki.SetActive(true);
        Kletochka1.SetActive(false);
        Kletochka2.SetActive(false);
        Kletochka3.SetActive(false);
        Kletochka4.SetActive(false);
        Kletochka5.SetActive(false);
        Kletochka6.SetActive(false);
        Kletochka7.SetActive(true);
        Kletochka8.SetActive(false);
        Kletochka9.SetActive(false);
        if (SpritsUsed == false)
        {
            if (rOsmolit > 0 && currentSprits < maximumSprits) // �������� ���������, ���� ���� ����
            {
                rOsmolit -= 1;
                kachOsmolit += 1;
            }
            else if (rOsmolit > 0 && kachOsmolit > 0 && currentSprits == maximumSprits) // �������� ��������� ��������, ���� ������ ������
            {
                rOsmolit += kachOsmolit;
                kachOsmolit = 0;
            }
            else if (rOsmolit == 0 && kachOsmolit > 0) // �������� ��������� ��������, ���� ������� ��������
            {
                rOsmolit = kachOsmolit;
                kachOsmolit = 0;

            }

        }
    }
    public void KrioprotectorDescription()
    {
        // ��� ��������
        if (leveler.languager == 0)
        {
            nazvanieText.text = "Thermoreception";
            descriptionText.text = "Enemy cell 7 is visible: \ntemperature changes are \nmore tangible";
        }
        if (leveler.languager == 1)
        {
            nazvanieText.text = "�������������";
            descriptionText.text = "��������� ������ 7 ����� �����: \n������� ������� �� ��������� \n����������� �������� \n���������������";
        }
        else if (leveler.languager == 2)
        {
            nazvanieText.text = "�������������";
            descriptionText.text = "���������� ������ 7 ����� �����: \n������ ������� �� ���� \n����������� ��������\n�����������";
        }
        kletinki.SetActive(true);
        Kletochka1.SetActive(false);
        Kletochka2.SetActive(false);
        Kletochka3.SetActive(false);
        Kletochka4.SetActive(false);
        Kletochka5.SetActive(false);
        Kletochka6.SetActive(false);
        Kletochka7.SetActive(false);
        Kletochka8.SetActive(true);
        Kletochka9.SetActive(false);
        if (SpritsUsed == false)
        {
            if (rKrioprotector > 0 && currentSprits < maximumSprits) // �������� ���������, ���� ���� ����
            {
                rKrioprotector -= 1;
                kachKrioprotector += 1;
                if (degrodprogrPossibility + pDopEnergia > 5 && degrodus5 == false)
                {
                    dDopEnergia += 1;
                    degrodus5 = true;
                }
            }
            else if (rKrioprotector > 0 && kachKrioprotector > 0 && currentSprits == maximumSprits) // �������� ��������� ��������, ���� ������ ������
            {
                if (degrodus5)
                {
                    dDopEnergia -= 1;
                    degrodus5 = false;
                }
                rKrioprotector += kachKrioprotector;
                kachKrioprotector = 0;
            }
            else if (rKrioprotector == 0 && kachKrioprotector > 0) // �������� ��������� ��������, ���� ������� ��������
            {
                if (degrodus5)
                {
                    dDopEnergia -= 1;
                    degrodus5 = false;
                }
                rKrioprotector = kachKrioprotector;
                kachKrioprotector = 0;

            }
        }
    }
    public void EcholocatiaDescription()
    {
        // ��� ��������
        if (leveler.languager == 0)
        {
            nazvanieText.text = "Echolocation";
            descriptionText.text = "More creatures found in biomes: \na fat-free swim bladder allows to \nmake sounds and find objects \nreflecting them";
        }
        if (leveler.languager == 1)
        {
            nazvanieText.text = "����������";
            descriptionText.text = "�� ������ ����������� ������ �������: \n� ������� ������� ������������� \n������ ��� ���� ����� �������� ����� � \n�������� ���������� �� �������";
        }
        else if (leveler.languager == 2)
        {
            nazvanieText.text = "����������";
            descriptionText.text = "�� ����� ����������� ����� \n�����: ������ ���������� ���� ��� ���� \n�������� �������� ����� � ��������� \n��'����, �� �� �����������";
        }
        kletinki.SetActive(false);
        Kletochka1.SetActive(false);
        Kletochka2.SetActive(false);
        Kletochka3.SetActive(false);
        Kletochka4.SetActive(false);
        Kletochka5.SetActive(false);
        Kletochka6.SetActive(false);
        Kletochka7.SetActive(false);
        Kletochka8.SetActive(false);
        Kletochka9.SetActive(false);
        if (SpritsUsed == false)
        {
            if (rEcholocatia > 0 && currentSprits < maximumSprits) // �������� ���������, ���� ���� ����
            {
                rEcholocatia -= 1;
                kachEcholocatia += 1;
                if (degrodadoptPossibility + pLipid > 5 && degrodus6 == false)
                {
                    dLipid += 1;
                    degrodus6 = true;
                }
            }
            else if (rEcholocatia > 0 && kachEcholocatia > 0 && currentSprits == maximumSprits) // �������� ��������� ��������, ���� ������ ������
            {
                if (degrodus6)
                {
                    dLipid -= 1;
                    degrodus6 = false;
                }
                rEcholocatia += kachEcholocatia;
                kachEcholocatia = 0;
            }
            else if (rEcholocatia == 0 && kachEcholocatia > 0) // �������� ��������� ��������, ���� ������� ��������
            {
                rEcholocatia = kachEcholocatia;
                kachEcholocatia = 0;
                if (degrodus6)
                {
                    dLipid -= 1;
                    degrodus6 = false;
                }
            }
        }
    }
    public void HemoreceptorDescription()
    {
        // ��� ��������
        if (leveler.languager == 0)
        {
            nazvanieText.text = "Chemoreception";
            descriptionText.text = "Enemy cell 4 is visible: \nsubstance concentration \nchanges are more tangible";
        }
        if (leveler.languager == 1)
        {
            nazvanieText.text = "������������";
            descriptionText.text = "��������� ������ 4 ����� �����: \n������� ������� �� ���������\n������������ ������� �������� \n���������������";
        }
        else if (leveler.languager == 2)
        {
            nazvanieText.text = "������������";
            descriptionText.text = "���������� ������ 4 ����� �����: \n������ ������� �� ���� \n������������ ������� ������� \n����������";
        }
        kletinki.SetActive(true);
        Kletochka1.SetActive(false);
        Kletochka2.SetActive(false);
        Kletochka3.SetActive(false);
        Kletochka4.SetActive(false);
        Kletochka5.SetActive(true);
        Kletochka6.SetActive(false);
        Kletochka7.SetActive(false);
        Kletochka8.SetActive(false);
        Kletochka9.SetActive(false);
        if (SpritsUsed == false)
        {
            if (rHemoreceptor > 0 && currentSprits < maximumSprits) // �������� ���������, ���� ���� ����
            {
                rHemoreceptor -= 1;
                kachHemoreceptor += 1;
                if (degrodreceptPossibility + kachHemoreceptor > 5 && degrodus7 == false)
                {
                    dPhotoreceptor += 1;
                    dMechanoreceptor += 1;
                    degrodus7 = true;
                }
            }
            else if (rHemoreceptor > 0 && kachHemoreceptor > 0 && currentSprits == maximumSprits) // �������� ��������� ��������, ���� ������ ������
            {
                if (degrodus7)
                {
                    dPhotoreceptor -= 1;
                    dMechanoreceptor -= 1;
                    degrodus7 = false;
                }
                rHemoreceptor += kachHemoreceptor;
                kachHemoreceptor = 0;
            }
            else if (rHemoreceptor == 0 && kachHemoreceptor > 0) // �������� ��������� ��������, ���� ������� ��������
            {
                if (degrodus7)
                {
                    dPhotoreceptor -= 1;
                    dMechanoreceptor -= 1;
                    degrodus7 = false;
                }
                rHemoreceptor = kachHemoreceptor;
                kachHemoreceptor = 0;

            }
        }
    }
    public void PhotoreceptorDescription()
    {
        // ��� ��������
        if (leveler.languager == 0)
        {
            nazvanieText.text = "Photoreception";
            descriptionText.text = "Enemy cell 5 is visible: \nlight and its polarization \nare more tangible";
        }
        if (leveler.languager == 1)
        {
            nazvanieText.text = "������������";
            descriptionText.text = "��������� ������ 5 ����� �����: \n������� ������� �� ���� \n� ��� ����������� ��������\n���������������";
        }
        else if (leveler.languager == 2)
        {
            nazvanieText.text = "������������";
            descriptionText.text = "���������� ������ 5 ����� �����: \n������ ������� �� ����� \n�� ���� ����������� �������\n����������";
        }
        kletinki.SetActive(true);
        Kletochka1.SetActive(false);
        Kletochka2.SetActive(false);
        Kletochka3.SetActive(false);
        Kletochka4.SetActive(true);
        Kletochka5.SetActive(false);
        Kletochka6.SetActive(false);
        Kletochka7.SetActive(false);
        Kletochka8.SetActive(false);
        Kletochka9.SetActive(false);
        if (SpritsUsed == false)
        {
            if (rPhotoreceptor > 0 && currentSprits < maximumSprits) // �������� ���������, ���� ���� ����
            {
                rPhotoreceptor -= 1;
                kachPhotoreceptor += 1;
                if (degrodreceptPossibility + kachPhotoreceptor > 5 && degrodus8 == false)
                {
                    dHemoreceptor += 1;
                    dMechanoreceptor += 1;
                    degrodus8 = true;
                }
            }
            else if (rPhotoreceptor > 0 && kachPhotoreceptor > 0 && currentSprits == maximumSprits) // �������� ��������� ��������, ���� ������ ������
            {
                if (degrodus8)
                {
                    dHemoreceptor -= 1;
                    dMechanoreceptor -= 1;
                    degrodus8 = false;
                }
                rPhotoreceptor += kachPhotoreceptor;
                kachPhotoreceptor = 0;
            }
            else if (rPhotoreceptor == 0 && kachPhotoreceptor > 0) // �������� ��������� ��������, ���� ������� ��������
            {
                if (degrodus8)
                {
                    dHemoreceptor -= 1;
                    dMechanoreceptor -= 1;
                    degrodus8 = false;
                }
                rPhotoreceptor = kachPhotoreceptor;
                kachPhotoreceptor = 0;

            }
        }
    }
    public void MechanoreceptorDescription()
    {
        // ��� ��������
        if (leveler.languager == 0)
        {
            nazvanieText.text = "Mechanoreception";
            descriptionText.text = "Enemy cell 6 is visible: \nwave oscillation is more \ntangible";
        }
        if (leveler.languager == 1)
        {
            nazvanieText.text = "��������������";
            descriptionText.text = "��������� ������ 6 ����� �����: \n������� ������� �� ��������� \n���� �������� ���������������";
        }
        else if (leveler.languager == 2)
        {
            nazvanieText.text = "��������������";
            descriptionText.text = "���������� ������ 6 ����� �����: \n������ ������� �� ��������� \n����� ������� ������� \n����������";
        }
        kletinki.SetActive(true);
        Kletochka1.SetActive(false);
        Kletochka2.SetActive(false);
        Kletochka3.SetActive(true);
        Kletochka4.SetActive(false);
        Kletochka5.SetActive(false);
        Kletochka6.SetActive(false);
        Kletochka7.SetActive(false);
        Kletochka8.SetActive(false);
        Kletochka9.SetActive(false);
        if (SpritsUsed == false)
        {
            if (rMechanoreceptor > 0 && currentSprits < maximumSprits) // �������� ���������, ���� ���� ����
            {
                rMechanoreceptor -= 1;
                kachMechanoreceptor += 1;
                if (degrodreceptPossibility + kachMechanoreceptor > 5 && degrodus9 == false)
                {
                    dHemoreceptor += 1;
                    dPhotoreceptor += 1;
                    degrodus9 = true;
                }
            }
            else if (rMechanoreceptor > 0 && kachMechanoreceptor > 0 && currentSprits == maximumSprits) // �������� ��������� ��������, ���� ������ ������
            {
                if (degrodus9)
                {
                    dHemoreceptor -= 1;
                    dPhotoreceptor -= 1;
                    degrodus9 = false;
                }
                rMechanoreceptor += kachMechanoreceptor;
                kachMechanoreceptor = 0;
            }
            else if (rMechanoreceptor == 0 && kachMechanoreceptor > 0) // �������� ��������� ��������, ���� ������� ��������
            {
                if (degrodus9)
                {
                    dHemoreceptor -= 1;
                    dPhotoreceptor -= 1;
                    degrodus9 = false;
                }
                rMechanoreceptor = kachMechanoreceptor;
                kachMechanoreceptor = 0;

            }
        }
    }
    public void ElectroreceptorDescription()
    {
        // ��� ��������
        if (leveler.languager == 0)
        {
            nazvanieText.text = "Electroreception";
            descriptionText.text = "Attracting someone while escaping \nis possible due to the emission\nand perception of electrical impulses,\nmucus needed as a conductor";
        }
        if (leveler.languager == 1)
        {
            nazvanieText.text = "���������������";
            descriptionText.text = "��� ������ ����� �������� �� ����� \n����� �������� ��������� ��������� � \n���������� ������������� ���������, �� � \n�������� ���������� ���������� �����";
        }
        else if (leveler.languager == 2)
        {
            nazvanieText.text = "���������������";
            descriptionText.text = "��� ����� ����� �������� �� ����� \n���� ��������� ������� ������������� \n�� ���������� ����������� ��������, \n��� � ����� ��������� ���������� ����";
        }
        kletinki.SetActive(false);
        Kletochka1.SetActive(false);
        Kletochka2.SetActive(false);
        Kletochka3.SetActive(false);
        Kletochka4.SetActive(false);
        Kletochka5.SetActive(false);
        Kletochka6.SetActive(false);
        Kletochka7.SetActive(false);
        Kletochka8.SetActive(false);
        Kletochka9.SetActive(false);
        if (SpritsUsed == false)
        {
            if (rElectroreceptor > 0 && currentSprits < maximumSprits) // �������� ���������, ���� ���� ����
            {
                rElectroreceptor -= 1;
                kachElectroreceptor += 1;
            }
            else if (rElectroreceptor > 0 && kachElectroreceptor > 0 && currentSprits == maximumSprits) // �������� ��������� ��������, ���� ������ ������
            {
                rElectroreceptor += kachElectroreceptor;
                kachElectroreceptor = 0;
            }
            else if (rElectroreceptor == 0 && kachElectroreceptor > 0) // �������� ��������� ��������, ���� ������� ��������
            {
                rElectroreceptor = kachElectroreceptor;
                kachElectroreceptor = 0;

            }
        }
    }
    public void MagneticDescription()
    {
        // ��� ��������
        if (leveler.languager == 0)
        {
            nazvanieText.text = "Magnetoreception";
            descriptionText.text = "Enemy cell 9 is visible: \nthe Earth's magnetic field \nis more tangible";
        }
        if (leveler.languager == 1)
        {
            nazvanieText.text = "���������������";
            descriptionText.text = "��������� ������ 9 ����� �����: \n��������� ���� ����� �������� \n���������������";
        }
        else if (leveler.languager == 2)
        {
            nazvanieText.text = "��������������";
            descriptionText.text = "���������� ������ 9 ����� �����: \n���������� ��������� ���� ���� \n������� ����������";
        }
        kletinki.SetActive(true);
        Kletochka1.SetActive(false);
        Kletochka2.SetActive(false);
        Kletochka3.SetActive(false);
        Kletochka4.SetActive(false);
        Kletochka5.SetActive(false);
        Kletochka6.SetActive(true);
        Kletochka7.SetActive(false);
        Kletochka8.SetActive(false);
        Kletochka9.SetActive(false);
        if (SpritsUsed == false)
        {
            if (rMagnetic > 0 && currentSprits < maximumSprits) // �������� ���������, ���� ���� ����
            {
                rMagnetic -= 1;
                kachMagnetic += 1;
            }
            else if (rMagnetic > 0 && kachMagnetic > 0 && currentSprits == maximumSprits) // �������� ��������� ��������, ���� ������ ������
            {
                rMagnetic += kachMagnetic;
                kachMagnetic = 0;
            }
            else if (rMagnetic == 0 && kachMagnetic > 0) // �������� ��������� ��������, ���� ������� ��������
            {
                rMagnetic = kachMagnetic;
                kachMagnetic = 0;

            }
        }
    }
    public void RedPigmentDescription()
    {
        // ��� ��������
        if (leveler.languager == 0)
        {
            nazvanieText.text = "Red pigmentation";
            descriptionText.text = "Healing skills available: red \nis imperceptible at depth, and \nechinochrome pigment prevents \ndiseases, promotes regeneration";
        }
        if (leveler.languager == 1)
        {
            nazvanieText.text = "������� �����������";
            descriptionText.text = "������ ���������� �������: \n�� ������� ������ �� ����� �������, \n� ������� ��������� ������������� \n���������� � �������� �����������";
        }
        else if (leveler.languager == 2)
        {
            nazvanieText.text = "������� ����������";
            descriptionText.text = "������ ��������� �� ��������: \n�� �������� �������� ����� ����, \n� ������ ��������� ������� \n���������� �� ��������� �����������";
        }
        kletinki.SetActive(false);
        Kletochka1.SetActive(false);
        Kletochka2.SetActive(false);
        Kletochka3.SetActive(false);
        Kletochka4.SetActive(false);
        Kletochka5.SetActive(false);
        Kletochka6.SetActive(false);
        Kletochka7.SetActive(false);
        Kletochka8.SetActive(false);
        Kletochka9.SetActive(false);
        if (SpritsUsed == false)
        {
            if (rRedPigment > 0 && currentSprits < maximumSprits) // �������� ���������, ���� ���� ����
            {
                rRedPigment -= 1;
                kachRedPigment += 1;
                if (degrodpigmaPossibility + pProzrachnost > 5 && degrodus10 == false)
                {
                    dProzrachnost += 1;
                    degrodus10 = true;
                }
            }
            else if (rRedPigment > 0 && kachRedPigment > 0 && currentSprits == maximumSprits) // �������� ��������� ��������, ���� ������ ������
            {
                if (degrodus10)
                {
                    degrodus10 = false;
                    dProzrachnost -= 1;
                }
                rRedPigment += kachRedPigment;
                kachRedPigment = 0;
            }
            else if (rRedPigment == 0 && kachRedPigment > 0) // �������� ��������� ��������, ���� ������� ��������
            {
                if (degrodus10)
                {
                    dProzrachnost -= 1;
                    degrodus10 = false;
                }
                rRedPigment = kachRedPigment;
                kachRedPigment = 0;

            }
        }
    }
    public void ChernyyPigmentDescription()
    {
        // ��� ��������
        if (leveler.languager == 0)
        {
            nazvanieText.text = "Black pigmentation";
            descriptionText.text = "Offensive skills available: \ncompressed melanin absorbs light, \ninsuring the invisibility";
        }
        if (leveler.languager == 1)
        {
            nazvanieText.text = "׸���� �����������";
            descriptionText.text = "������ ��������� �������: \n������������ ������� ��������� \n����, ��� ������������ �����������";
        }
        else if (leveler.languager == 2)
        {
            nazvanieText.text = "����� ����������";
            descriptionText.text = "������ ��������� ����: ����������� \n������ ������� ����� � ������ ��� \n�����, �� ��������� ����������";
        }
        kletinki.SetActive(false);
        Kletochka1.SetActive(false);
        Kletochka2.SetActive(false);
        Kletochka3.SetActive(false);
        Kletochka4.SetActive(false);
        Kletochka5.SetActive(false);
        Kletochka6.SetActive(false);
        Kletochka7.SetActive(false);
        Kletochka8.SetActive(false);
        Kletochka9.SetActive(false);
        if (SpritsUsed == false)
        {
            if (rChernyyPigment > 0 && currentSprits < maximumSprits) // �������� ���������, ���� ���� ����
            {
                rChernyyPigment -= 1;
                kachChernyyPigment += 1;
                if (degrodpigmaPossibility + pProzrachnost > 5)
                {
                    dProzrachnost += 1;
                }
            }
            else if (rChernyyPigment > 0 && kachChernyyPigment > 0 && currentSprits == maximumSprits) // �������� ��������� ��������, ���� ������ ������
            {
                if (degrodpigmaPossibility + pProzrachnost > 5)
                {
                    dProzrachnost -= 1;
                }
                rChernyyPigment += kachChernyyPigment;
                kachChernyyPigment = 0;
            }
            else if (rChernyyPigment == 0 && kachChernyyPigment > 0) // �������� ��������� ��������, ���� ������� ��������
            {
                if (degrodpigmaPossibility + pProzrachnost > 5)
                {
                    dProzrachnost -= 1;
                }
                rChernyyPigment = kachChernyyPigment;
                kachChernyyPigment = 0;

            }
        }
    }
    public void ProzrachnostDescription()
    {
        // ��� ��������
        if (leveler.languager == 0)
        {
            nazvanieText.text = "Transparency";
            descriptionText.text = "Defensive skills available: lack \nof pigmentation is camouflage, \nbut is associated with organs \nreduction";
        }
        if (leveler.languager == 1)
        {
            nazvanieText.text = "������������";
            descriptionText.text = "������ �������� �������: \n���������� ����������� �������� \n����������, �� ������� � ���������� \n���������";
        }
        else if (leveler.languager == 2)
        {
            nazvanieText.text = "���������";
            descriptionText.text = "������ ��������� �� �������: \n��������� ���������� ������� \n����������, ����� ������ ��������� \n������";
        }
        kletinki.SetActive(false);
        Kletochka1.SetActive(false);
        Kletochka2.SetActive(false);
        Kletochka3.SetActive(false);
        Kletochka4.SetActive(false);
        Kletochka5.SetActive(false);
        Kletochka6.SetActive(false);
        Kletochka7.SetActive(false);
        Kletochka8.SetActive(false);
        Kletochka9.SetActive(false);
        if (SpritsUsed == false)
        {
            if (rProzrachnost > 0 && currentSprits < maximumSprits) // �������� ���������, ���� ���� ����
            {
                rProzrachnost -= 1;
                kachProzrachnost += 1;
                if (degrodpigmaPossibility + pRedPigment > 5 && degrodus11 == false)
                {
                    dRedPigment += 1;
                    degrodus11 = true;
                }
                if (degrodpigmaPossibility + pChernyyPigment > 5 && degrodus12 == false)
                {
                    dChernyyPigment += 1;
                    degrodus12 = true;
                }
                if (degrodpigmaPossibility + pLuminiscencia > 5 && degrodus13 == false)
                {
                    dLuminiscencia += 1;
                    degrodus13 = true;
                }
                if (degrodreceptPossibility > 5 && degrodus14 == false)
                {
                    dPhotoreceptor += 1;
                    degrodus14 = true;
                }
            }
            else if (rProzrachnost > 0 && kachProzrachnost > 0 && currentSprits == maximumSprits) // �������� ��������� ��������, ���� ������ ������
            {
                if (degrodus11)
                {
                    dRedPigment -= 1;
                    degrodus11 = false;
                }
                if (degrodus12)
                {
                    dChernyyPigment -= 1;
                    degrodus12 = false;
                }
                if (degrodus13)
                {
                    dLuminiscencia -= 1;
                    degrodus13 = false;
                }
                if (degrodus14)
                {
                    dPhotoreceptor -= 1;
                    degrodus14 = false;
                }
                rProzrachnost += kachProzrachnost;
                kachProzrachnost = 0;
            }
            else if (rProzrachnost == 0 && kachProzrachnost > 0) // �������� ��������� ��������, ���� ������� ��������
            {
                if (degrodus11)
                {
                    dRedPigment -= 1;
                    degrodus11 = false;
                }
                if (degrodus12)
                {
                    dChernyyPigment -= 1;
                    degrodus12 = false;
                }
                if (degrodus13)
                {
                    dLuminiscencia -= 1;
                    degrodus13 = false;
                }
                if (degrodus14)
                {
                    dPhotoreceptor -= 1;
                    degrodus14 = false;
                }
                rProzrachnost = kachProzrachnost;
                kachProzrachnost = 0;

            }
        }
    }
    public void LuminiscenciaDescription()
    {
        // ��� ��������
        if (leveler.languager == 0)
        {
            nazvanieText.text = "Bioluminescence";
            descriptionText.text = "Blocking skills available: the \nglow of symbionts, luciferin or \necvorin allows to perform \ndeceptive maneuvers and enchant";
        }
        if (leveler.languager == 1)
        {
            nazvanieText.text = "����������������";
            descriptionText.text = "������ ����������� �������: \n�������� ����������, ���������� \n��� �������� ��������� ��������� \n�������� ������ � ������������";
        }
        else if (leveler.languager == 2)
        {
            nazvanieText.text = "��������������";
            descriptionText.text = "������ ��������� �� ����������: \n������ ��������, ���������� \n��� �������� �������� ���������� \n������ ������� �� ������������";
        }
        kletinki.SetActive(false);
        Kletochka1.SetActive(false);
        Kletochka2.SetActive(false);
        Kletochka3.SetActive(false);
        Kletochka4.SetActive(false);
        Kletochka5.SetActive(false);
        Kletochka6.SetActive(false);
        Kletochka7.SetActive(false);
        Kletochka8.SetActive(false);
        Kletochka9.SetActive(false);
        if (SpritsUsed == false)
        {
            if (rLuminiscencia > 0 && currentSprits < maximumSprits) // �������� ���������, ���� ���� ����
            {
                rLuminiscencia -= 1;
                kachLuminiscencia += 1;
            }
            else if (rLuminiscencia > 0 && kachLuminiscencia > 0 && currentSprits == maximumSprits) // �������� ��������� ��������, ���� ������ ������
            {
                rLuminiscencia += kachLuminiscencia;
                kachLuminiscencia = 0;
            }
            else if (rLuminiscencia == 0 && kachLuminiscencia > 0) // �������� ��������� ��������, ���� ������� ��������
            {
                rLuminiscencia = kachLuminiscencia;
                kachLuminiscencia = 0;

            }
        }
    }
    public void MimicriaDescription()
    {
        // ��� ��������
        if (leveler.languager == 0)
        {
            nazvanieText.text = "Mimicry";
            descriptionText.text = "Escape chance is doubled: if the \nbody is colored, pigment cells of \none color become wider and \nmerge with the environment";
        }
        if (leveler.languager == 1)
        {
            nazvanieText.text = "��������";
            descriptionText.text = "���� ������ ����� ����: ���������� \n������ ������ ����� ���������� \n���� ������, �������� � ����������, \n������ ���� �������� �� ����������";
        }
        else if (leveler.languager == 2)
        {
            nazvanieText.text = "̳����";
            descriptionText.text = "���� ����� ����� ������: ������� \n������ ������ ������� ������ \n����� �� ����, ������� ��������. \n�� ��������� ��� ���������";
        }
        kletinki.SetActive(false);
        Kletochka1.SetActive(false);
        Kletochka2.SetActive(false);
        Kletochka3.SetActive(false);
        Kletochka4.SetActive(false);
        Kletochka5.SetActive(false);
        Kletochka6.SetActive(false);
        Kletochka7.SetActive(false);
        Kletochka8.SetActive(false);
        Kletochka9.SetActive(false);
        if (SpritsUsed == false)
        {
            if (rMimicria > 0 && currentSprits < maximumSprits) // �������� ���������, ���� ���� ����
            {
                rMimicria -= 1;
                kachMimicria += 1;
                if (degrodpigmaPossibility + pProzrachnost > 5 && degrodus15 == false)
                {
                    dProzrachnost += 1;
                    degrodus15 = true;
                }
            }
            else if (rMimicria > 0 && kachMimicria > 0 && currentSprits == maximumSprits) // �������� ��������� ��������, ���� ������ ������
            {
                if (degrodus15)
                {
                    dProzrachnost -= 1;
                    degrodus15 = false;
                }
                rMimicria += kachMimicria;
                kachMimicria = 0;
            }
            else if (rMimicria == 0 && kachMimicria > 0) // �������� ��������� ��������, ���� ������� ��������
            {
                if (degrodus15)
                {
                    dProzrachnost -= 1;
                    degrodus15 = false;
                }
                rMimicria = kachMimicria;
                kachMimicria = 0;
            }
        }
    }
    public void ImmunitetDescription()
    {
        // ��� ��������
        if (leveler.languager == 0)
        {
            nazvanieText.text = "High immunity";
            descriptionText.text = "Protection from defective genes \ntransferred from companions: \ngranulocytes protect the body \nfrom poisons, parasites and diseases";
        }
        if (leveler.languager == 1)
        {
            nazvanieText.text = "������� ���������";
            descriptionText.text = "������ �� ��������� �����, \n�������������� � �������: \n����������� �������� �������� \n�� ����, ��������� � ��������";
        }
        else if (leveler.languager == 2)
        {
            nazvanieText.text = "������� �������";
            descriptionText.text = "������ �� ��������� ����, \n����������� � ���������: \n����������� ��������� ������� \n�� �����, �������� �� ������";
        }
        kletinki.SetActive(false);
        Kletochka1.SetActive(false);
        Kletochka2.SetActive(false);
        Kletochka3.SetActive(false);
        Kletochka4.SetActive(false);
        Kletochka5.SetActive(false);
        Kletochka6.SetActive(false);
        Kletochka7.SetActive(false);
        Kletochka8.SetActive(false);
        Kletochka9.SetActive(false);
        if (SpritsUsed == false)
        {
            if (rImmunitet > 0 && currentSprits < maximumSprits) // �������� ���������, ���� ���� ����
            {
                rImmunitet -= 1;
                kachImmunitet += 1;
            }
            else if (rImmunitet > 0 && kachImmunitet > 0 && currentSprits == maximumSprits) // �������� ��������� ��������, ���� ������ ������
            {
                rImmunitet += kachImmunitet;
                kachImmunitet = 0;
            }
            else if (rImmunitet == 0 && kachImmunitet > 0) // �������� ��������� ��������, ���� ������� ��������
            {
                rImmunitet = kachImmunitet;
                kachImmunitet = 0;

            }
        }
    }
    public void DopPolostDescription()
    {
        // ��� ��������
        if (leveler.languager == 0)
        {
            nazvanieText.text = "Additional cavity";
            descriptionText.text = "Companion caviar loot increased,\nbut special reservoir is also \nsuitable for parasitic bacteria";
        }
        if (leveler.languager == 1)
        {
            nazvanieText.text = "�������������� �������";
            descriptionText.text = "������ ����� ��� ���� �� �������, \n�� ����������� ��������� ������� \n� ��� �������������� ��������";
        }
        else if (leveler.languager == 2)
        {
            nazvanieText.text = "��������� ���������";
            descriptionText.text = "������ ���� ��� ���� ���������,\n��� ����������� ��������� �������� \n� ��� ������������ �������";
        }
        kletinki.SetActive(false);
        Kletochka1.SetActive(false);
        Kletochka2.SetActive(false);
        Kletochka3.SetActive(false);
        Kletochka4.SetActive(false);
        Kletochka5.SetActive(false);
        Kletochka6.SetActive(false);
        Kletochka7.SetActive(false);
        Kletochka8.SetActive(false);
        Kletochka9.SetActive(false);
        if (SpritsUsed == false)
        {
            if (rDopPolost > 0 && currentSprits < maximumSprits) // �������� ���������, ���� ���� ����
            {
                rDopPolost -= 1;
                kachDopPolost += 1;
                if (degrodprogrPossibility > 5 && degrodus16 == false)
                {
                    dImmunitet += 1;
                    degrodus16 = true;
                }
            }
            else if (rDopPolost > 0 && kachDopPolost > 0 && currentSprits == maximumSprits) // �������� ��������� ��������, ���� ������ ������
            {
                if (degrodus16)
                {
                    dImmunitet -= 1;
                    degrodus16 = false;
                }
                rDopPolost += kachDopPolost;
                kachDopPolost = 0;
            }
            else if (rDopPolost == 0 && kachDopPolost > 0) // �������� ��������� ��������, ���� ������� ��������
            {
                if (degrodus16)
                {
                    dImmunitet -= 1;
                    degrodus16 = false;
                }
                rDopPolost = kachDopPolost;
                kachDopPolost = 0;

            }
        }
    }
    public void DopEnergiaDescription()
    {
        // ��� ��������
        if (leveler.languager == 0)
        {
            nazvanieText.text = "Additional fat pad";
            descriptionText.text = "More energy to make the first \nmove constantly and dive a \nlittle faster";
        }
        if (leveler.languager == 1)
        {
            nazvanieText.text = "������� ���������";
            descriptionText.text = "������ ������� �� ��, ����� \n������ ������ ������ ��� \n� ���� ������� ���������";
        }
        else if (leveler.languager == 2)
        {
            nazvanieText.text = "������ ��������";
            descriptionText.text = "������ ����㳿 �� ��, ��� \n������ ������ ������ � \n����� ���������� ����";
        }
        kletinki.SetActive(false);
        Kletochka1.SetActive(false);
        Kletochka2.SetActive(false);
        Kletochka3.SetActive(false);
        Kletochka4.SetActive(false);
        Kletochka5.SetActive(false);
        Kletochka6.SetActive(false);
        Kletochka7.SetActive(false);
        Kletochka8.SetActive(false);
        Kletochka9.SetActive(false);
        if (SpritsUsed == false)
        {
            if (rDopEnergia > 0 && currentSprits < maximumSprits) // �������� ���������, ���� ���� ����
            {
                rDopEnergia -= 1;
                kachDopEnergia += 1;
            }
            else if (rDopEnergia > 0 && kachDopEnergia > 0 && currentSprits == maximumSprits) // �������� ��������� ��������, ���� ������ ������
            {
                rDopEnergia += kachDopEnergia;
                kachDopEnergia = 0;
            }
            else if (rDopEnergia == 0 && kachDopEnergia > 0) // �������� ��������� ��������, ���� ������� ��������
            {
                rDopEnergia = kachDopEnergia;
                kachDopEnergia = 0;

            }
        }
    }

    public void PheromonesDescription()
    {
        // ��� ��������
        if (leveler.languager == 0)
        {
            nazvanieText.text = "Pheromones";
            descriptionText.text = "Spending time with more \ncompanions is possible: no more \nresentment that someone \nelse got desired attention";
        }
        if (leveler.languager == 1)
        {
            nazvanieText.text = "��������";
            descriptionText.text = "����� ���������� ����� ������� \n����� �����, ��� ����� ��������: \n������� ������ ����, ��� �������� \n��������� ����-�� ���";
        }
        else if (leveler.languager == 2)
        {
            nazvanieText.text = "��������";
            descriptionText.text = "����� �������� ����� �����, �� \n���� ��������� �� ���: ����� ����� \n�� ��, �� ������ ����� �������� \n� �����";
        }
        kletinki.SetActive(false);
        Kletochka1.SetActive(false);
        Kletochka2.SetActive(false);
        Kletochka3.SetActive(false);
        Kletochka4.SetActive(false);
        Kletochka5.SetActive(false);
        Kletochka6.SetActive(false);
        Kletochka7.SetActive(false);
        Kletochka8.SetActive(false);
        Kletochka9.SetActive(false);
        if (SpritsUsed == false)
        {
            if (rPheromones > 0 && currentSprits < maximumSprits) // �������� ���������, ���� ���� ����
            {
                rPheromones -= 1;
                kachPheromones += 1;
            }
            else if (rPheromones > 0 && kachPheromones > 0 && currentSprits == maximumSprits) // �������� ��������� ��������, ���� ������ ������
            {
                rPheromones += kachPheromones;
                kachPheromones = 0;
            }
            else if (rPheromones == 0 && kachPheromones > 0) // �������� ��������� ��������, ���� ������� ��������
            {
                rPheromones = kachPheromones;
                kachPheromones = 0;

            }
        }
    }
    public void UskorennoeRazvitieDescription()
    {
        // ��� ��������
        if (leveler.languager == 0)
        {
            nazvanieText.text = "Intensive development";
            descriptionText.text = "Up to 5 genes can be inserted \nbefore the expedition instead of 4";
        }
        if (leveler.languager == 1)
        {
            nazvanieText.text = "����������� ��������";
            descriptionText.text = "����� �������� 5 ����� ������ 4 \n�� ������ ����������";
        }
        else if (leveler.languager == 2)
        {
            nazvanieText.text = "����������� ��������";
            descriptionText.text = "����� ������ 5 ���� ������ 4 \n�� ������� ����������";
        }
        kletinki.SetActive(false);
        Kletochka1.SetActive(false);
        Kletochka2.SetActive(false);
        Kletochka3.SetActive(false);
        Kletochka4.SetActive(false);
        Kletochka5.SetActive(false);
        Kletochka6.SetActive(false);
        Kletochka7.SetActive(false);
        Kletochka8.SetActive(false);
        Kletochka9.SetActive(false);
        if (SpritsUsed == false)
        {
            if (rUskorennoeRazvitie > 0 && currentSprits < maximumSprits) // �������� ���������, ���� ���� ����
            {
                rUskorennoeRazvitie -= 1;
                kachUskorennoeRazvitie += 1;
            }
            else if (rUskorennoeRazvitie > 0 && kachUskorennoeRazvitie > 0 && currentSprits == maximumSprits) // �������� ��������� ��������, ���� ������ ������
            {
                rUskorennoeRazvitie += kachUskorennoeRazvitie;
                kachUskorennoeRazvitie = 0;
            }
            else if (rUskorennoeRazvitie == 0 && kachUskorennoeRazvitie > 0) // �������� ��������� ��������, ���� ������� ��������
            {
                rUskorennoeRazvitie = kachUskorennoeRazvitie;
                kachUskorennoeRazvitie = 0;

            }
        }
    }
    public void ToxinyDescription()
    {
        // ��� ��������
        if (leveler.languager == 0)
        {
            nazvanieText.text = "Toxins";
            descriptionText.text = "Multi-turn skills available: toxic \nholoturin or vanadium contained \nin knidocytes can cause damage \nto organs and systems";
        }
        if (leveler.languager == 1)
        {
            nazvanieText.text = "�������";
            descriptionText.text = "������ �������, ����������� ���� \n�����: ������������ � ���������� \n��� - ��������� ��� ������� - ����� \n�������� ��������� ������� � ������";
        }
        else if (leveler.languager == 2)
        {
            nazvanieText.text = "�������";
            descriptionText.text = "������ ��������� � ��������� \n��������: ������ ��������� �� \n������, �� �������� � ���������, \n����� ��������� �������� ������";
        }
        kletinki.SetActive(false);
        Kletochka1.SetActive(false);
        Kletochka2.SetActive(false);
        Kletochka3.SetActive(false);
        Kletochka4.SetActive(false);
        Kletochka5.SetActive(false);
        Kletochka6.SetActive(false);
        Kletochka7.SetActive(false);
        Kletochka8.SetActive(false);
        Kletochka9.SetActive(false);
        if (SpritsUsed == false)
        {
            if (rToxiny > 0 && currentSprits < maximumSprits) // �������� ���������, ���� ���� ����
            {
                rToxiny -= 1;
                kachToxiny += 1;
                if (degrodbatolPossibility + pPedicellariy > 5 && degrodus17 == false)
                {
                    dPedicellariy += 1;
                    degrodus17 = true;
                }
                if (degrodbatolPossibility + pCuvierovi > 5 && degrodus18 == false)
                {
                    dCuvierovi += 1;
                    degrodus18 = true;
                }
            }
            else if (rToxiny > 0 && kachToxiny > 0 && currentSprits == maximumSprits) // �������� ��������� ��������, ���� ������ ������
            {
                if (degrodus17)
                {
                    dPedicellariy -= 1;
                    degrodus17 = false;
                }
                if (degrodus18)
                {
                    dCuvierovi -= 1;
                    degrodus18 = false;
                }
                rToxiny += kachToxiny;
                kachToxiny = 0;
            }
            else if (rToxiny == 0 && kachToxiny > 0) // �������� ��������� ��������, ���� ������� ��������
            {
                if (degrodus17)
                {
                    dPedicellariy -= 1;
                    degrodus17 = false;
                }
                if (degrodus18)
                {
                    dCuvierovi -= 1;
                    degrodus18 = false;
                }
                rToxiny = kachToxiny;
                kachToxiny = 0;

            }
        }
    }
    public void RegenerationDescription()
    {
        // ��� ��������
        if (leveler.languager == 0)
        {
            nazvanieText.text = "Regeneration";
            descriptionText.text = "Health-threatening skills \navailable: renewing enterocytes \nre-grow damaged areas";
        }
        if (leveler.languager == 1)
        {
            nazvanieText.text = "�����������";
            descriptionText.text = "������ �������, ������� ��� \n���������: ����������� ���������� \n���������� ������������ ������� \n������";
        }
        else if (leveler.languager == 2)
        {
            nazvanieText.text = "�����������";
            descriptionText.text = "������ ���������, ����������� ��� \n��������: ��������� ���������� \n��������� ��������� ���� ������";
        }
        kletinki.SetActive(false);
        Kletochka1.SetActive(false);
        Kletochka2.SetActive(false);
        Kletochka3.SetActive(false);
        Kletochka4.SetActive(false);
        Kletochka5.SetActive(false);
        Kletochka6.SetActive(false);
        Kletochka7.SetActive(false);
        Kletochka8.SetActive(false);
        Kletochka9.SetActive(false);
        if (SpritsUsed == false)
        {
            if (rRegeneration > 0 && currentSprits < maximumSprits) // �������� ���������, ���� ���� ����
            {
                rRegeneration -= 1;
                kachRegeneration += 1;
            }
            else if (rRegeneration > 0 && kachRegeneration > 0 && currentSprits == maximumSprits) // �������� ��������� ��������, ���� ������ ������
            {
                rRegeneration += kachRegeneration;
                kachRegeneration = 0;
            }
            else if (rRegeneration == 0 && kachRegeneration > 0) // �������� ��������� ��������, ���� ������� ��������
            {
                rRegeneration = kachRegeneration;
                kachRegeneration = 0;

            }
        }
    }
    public void EviscerationDescription()
    {
        // ��� ��������
        if (leveler.languager == 0)
        {
            nazvanieText.text = "Evisceration";
            descriptionText.text = "Skills used a limited number of \ntimes available: entrails ejection \nfrightens or distracts the target, \nbut then requires regeneration";
        }
        if (leveler.languager == 1)
        {
            nazvanieText.text = "�����������";
            descriptionText.text = "������ �������, ������������ \n������������ ���������� ���: ������ \n������� ���������� ��� ��������� \n����, �� ����� ����� ����� �����������";
        }
        else if (leveler.languager == 2)
        {
            nazvanieText.text = "����������";
            descriptionText.text = "������ ���������, ��������� � \n�������� �������: ����� ������ \n������ ��� ������� ����, ����� \n���� ����� ������� ������������";
        }
        kletinki.SetActive(false);
        Kletochka1.SetActive(false);
        Kletochka2.SetActive(false);
        Kletochka3.SetActive(false);
        Kletochka4.SetActive(false);
        Kletochka5.SetActive(false);
        Kletochka6.SetActive(false);
        Kletochka7.SetActive(false);
        Kletochka8.SetActive(false);
        Kletochka9.SetActive(false);
        if (SpritsUsed == false)
        {
            if (rEvisceration > 0 && currentSprits < maximumSprits) // �������� ���������, ���� ���� ����
            {
                rEvisceration -= 1;
                kachEvisceration += 1;
            }
            else if (rEvisceration > 0 && kachEvisceration > 0 && currentSprits == maximumSprits) // �������� ��������� ��������, ���� ������ ������
            {
                rEvisceration += kachEvisceration;
                kachEvisceration = 0;
            }
            else if (rEvisceration == 0 && kachEvisceration > 0) // �������� ��������� ��������, ���� ������� ��������
            {
                rEvisceration = kachEvisceration;
                kachEvisceration = 0;

            }
        }
    }
    public void PedicellariyDescription()
    {
        // ��� ��������
        if (leveler.languager == 0)
        {
            nazvanieText.text = "Pedicellariae";
            descriptionText.text = "Melee skills available: numerous \npincers on body coverings clean \nand protect it, and are not \ncombined with scales or suckers";
        }
        if (leveler.languager == 1)
        {
            nazvanieText.text = "������������";
            descriptionText.text = "������ ������� �������� ���: \n�������������� ������� �� ���� \n������� � �������� ���, � ��� �� \n���������� � ����� � ����������";
        }
        else if (leveler.languager == 2)
        {
            nazvanieText.text = "���������";
            descriptionText.text = "������ ��������� �� ��������� ���: \n������� ������� �� �� �������� \n�� ��������� ����, � �� �� \n��������� � ������ �� ����������";
        }
        kletinki.SetActive(false);
        Kletochka1.SetActive(false);
        Kletochka2.SetActive(false);
        Kletochka3.SetActive(false);
        Kletochka4.SetActive(false);
        Kletochka5.SetActive(false);
        Kletochka6.SetActive(false);
        Kletochka7.SetActive(false);
        Kletochka8.SetActive(false);
        Kletochka9.SetActive(false);
        if (SpritsUsed == false)
        {
            if (rPedicellariy > 0 && currentSprits < maximumSprits) // �������� ���������, ���� ���� ����
            {
                rPedicellariy -= 1;
                kachPedicellariy += 1;
                if (degrodadoptPossibility + pPancer > 5 && degrodus19 == false)
                {
                    dPancer += 1;
                    degrodus19 = true;
                }
                if (degrodbatolPossibility + pPrisosky > 5 && degrodus20 == false)
                {
                    dPrisosky += 1;
                    degrodus20 = true;
                }
            }
            else if (rPedicellariy > 0 && kachPedicellariy > 0 && currentSprits == maximumSprits) // �������� ��������� ��������, ���� ������ ������
            {
                if (degrodus19)
                {
                    dPancer -= 1;
                    degrodus19 = false;
                }
                if (degrodus20)
                {
                    dPrisosky -= 1;
                    degrodus20 = false;
                }
                rPedicellariy += kachPedicellariy;
                kachPedicellariy = 0;
            }
            else if (rPedicellariy == 0 && kachPedicellariy > 0) // �������� ��������� ��������, ���� ������� ��������
            {
                if (degrodus19)
                {
                    dPancer -= 1;
                    degrodus19 = false;
                }
                if (degrodus20)
                {
                    dPrisosky -= 1;
                    degrodus20 = false;
                }
                rPedicellariy = kachPedicellariy;
                kachPedicellariy = 0;

            }
        }
    }
    public void PrisoskyDescription()
    {
        // ��� ��������
        if (leveler.languager == 0)
        {
            nazvanieText.text = "Tentacles, suckers";
            descriptionText.text = "Skills from the middle row are \navailable: moving long outgrowths \nfacilitate grasping and moving, \nincompatible with scales, pinkers";
        }
        if (leveler.languager == 1)
        {
            nazvanieText.text = "��������, ��������";
            descriptionText.text = "������ ������� ��� �� �������� \n����: �������� ������� ������� \n������ ��� ������� � ������������, �� \n�� ���������� � ����� � ���������";
        }
        else if (leveler.languager == 2)
        {
            nazvanieText.text = "��������, ��������";
            descriptionText.text = "������ ��������� �� ��� � ���������� \n����: ������ ���� ������� ������� \n��� ���������� �� �����������, ��� \n�� ����� � ������ �� ���������";
        }
        kletinki.SetActive(false);
        Kletochka1.SetActive(false);
        Kletochka2.SetActive(false);
        Kletochka3.SetActive(false);
        Kletochka4.SetActive(false);
        Kletochka5.SetActive(false);
        Kletochka6.SetActive(false);
        Kletochka7.SetActive(false);
        Kletochka8.SetActive(false);
        Kletochka9.SetActive(false);
        if (SpritsUsed == false)
        {
            if (rPrisosky > 0 && currentSprits < maximumSprits) // �������� ���������, ���� ���� ����
            {
                rPrisosky -= 1;
                kachPrisosky += 1;
                if (degrodadoptPossibility + pPancer > 5 && degrodus21 == false)
                {
                    dPancer += 1;
                    degrodus21 = true;
                }
                if (degrodbatolPossibility + pPedicellariy > 5 && degrodus22 == false)
                {
                    dPedicellariy += 1;
                    degrodus22 = true;
                }
            }
            else if (rPrisosky > 0 && kachPrisosky > 0 && currentSprits == maximumSprits) // �������� ��������� ��������, ���� ������ ������
            {
                if (degrodus21)
                {
                    dPancer -= 1;
                    degrodus21 = false;
                }
                if (degrodus22)
                {
                    dPedicellariy -= 1;
                    degrodus22 = false;
                }
                rPrisosky += kachPrisosky;
                kachPrisosky = 0;
            }
            else if (rPrisosky == 0 && kachPrisosky > 0) // �������� ��������� ��������, ���� ������� ��������
            {
                if (degrodus21)
                {
                    dPancer -= 1;
                    degrodus21 = false;
                }
                if (degrodus22)
                {
                    dPedicellariy -= 1;
                    degrodus22 = false;
                }
                rPrisosky = kachPrisosky;
                kachPrisosky = 0;

            }
        }
    }
    public void ChernMeshokDescription()
    {
        // ��� ��������
        if (leveler.languager == 0)
        {
            nazvanieText.text = "Ink bag";
            descriptionText.text = "Mass destruction skills available: \nblack alkaloid squirting from the \ngut can cause numbness and \nchemoreceptor anesthesia";
        }
        if (leveler.languager == 1)
        {
            nazvanieText.text = "���������� �����";
            descriptionText.text = "������ ������� ��������� ���������: \n������ ��������, ����������� \n�� ��������� ����� �������� \n��������, ��������� ��������������";
        }
        else if (leveler.languager == 2)
        {
            nazvanieText.text = "���������� ����";
            descriptionText.text = "������ ���� �������� ��������: \n������������� ������� �������� � \n��������� ���� ��������� \n������, �������� �������������";
        }
        kletinki.SetActive(false);
        Kletochka1.SetActive(false);
        Kletochka2.SetActive(false);
        Kletochka3.SetActive(false);
        Kletochka4.SetActive(false);
        Kletochka5.SetActive(false);
        Kletochka6.SetActive(false);
        Kletochka7.SetActive(false);
        Kletochka8.SetActive(false);
        Kletochka9.SetActive(false);
        if (SpritsUsed == false)
        {
            if (rChernMeshok > 0 && currentSprits < maximumSprits) // �������� ���������, ���� ���� ����
            {
                rChernMeshok -= 1;
                kachChernMeshok += 1;
                if (degrodreceptPossibility > 5 && degrodus23 == false)
                {
                    dHemoreceptor += 1;
                    degrodus23 = true;
                }
                if (degrodbatolPossibility + pCuvierovi > 5 && degrodus24 == false)
                {
                    dCuvierovi += 1;
                    degrodus24 = true;
                }
            }
            else if (rChernMeshok > 0 && kachChernMeshok > 0 && currentSprits == maximumSprits) // �������� ��������� ��������, ���� ������ ������
            {
                if (degrodus23)
                {
                    dHemoreceptor -= 1;
                    degrodus23 = false;
                }
                if (degrodus24)
                {
                    dCuvierovi -= 1;
                    degrodus24 = false;
                }
                rChernMeshok += kachChernMeshok;
                kachChernMeshok = 0;
            }
            else if (rChernMeshok == 0 && kachChernMeshok > 0) // �������� ��������� ��������, ���� ������� ��������
            {
                if (degrodus23)
                {
                    dHemoreceptor -= 1;
                    degrodus23 = false;
                }
                if (degrodus24)
                {
                    dCuvierovi -= 1;
                    degrodus24 = false;
                }
                rChernMeshok = kachChernMeshok;
                kachChernMeshok = 0;

            }
        }
    }
    public void CuvieroviDescription()
    {
        // ��� ��������
        if (leveler.languager == 0)
        {
            nazvanieText.text = "Cuvier tubules";
            descriptionText.text = "Point-focused skills available: \nwhen thrown out, the sticky \nthreads swell, lengthen, entangle \nthe enemy, and limit his mobility";
        }
        if (leveler.languager == 1)
        {
            nazvanieText.text = "��������� ��������";
            descriptionText.text = "������ ������� �������� ���������: \n��� ������������ ������ ������� \n���� ��������, ����������, �������� \n�����, � ������ ��� �����������";
        }
        else if (leveler.languager == 2)
        {
            nazvanieText.text = "���'���� ��������";
            descriptionText.text = "������ ���� ��������� ��������: \n��� ����� ������ ����� ����� \n��������, ��������� � ���������� \n����, ����������� �� ���������";
        }
        kletinki.SetActive(false);
        Kletochka1.SetActive(false);
        Kletochka2.SetActive(false);
        Kletochka3.SetActive(false);
        Kletochka4.SetActive(false);
        Kletochka5.SetActive(false);
        Kletochka6.SetActive(false);
        Kletochka7.SetActive(false);
        Kletochka8.SetActive(false);
        Kletochka9.SetActive(false);
        if (SpritsUsed == false)
        {
            if (rCuvierovi > 0 && currentSprits < maximumSprits) // �������� ���������, ���� ���� ����
            {
                rCuvierovi -= 1;
                kachCuvierovi += 1;
                if (degrodbatolPossibility + pChernMeshok > 5 && degrodus25 == false)
                {
                    dChernMeshok += 1;
                    degrodus25 = true;
                }
            }
            else if (rCuvierovi > 0 && kachCuvierovi > 0 && currentSprits == maximumSprits) // �������� ��������� ��������, ���� ������ ������
            {
                if (degrodus25)
                {
                    dChernMeshok -= 1;
                    degrodus25 = false;
                }
                rCuvierovi += kachCuvierovi;
                kachCuvierovi = 0;
            }
            else if (rCuvierovi == 0 && kachCuvierovi > 0) // �������� ��������� ��������, ���� ������� ��������
            {
                if (degrodus25)
                {
                    dChernMeshok -= 1;
                    degrodus25 = false;
                }
                rCuvierovi = kachCuvierovi;
                kachCuvierovi = 0;

            }
        }
    }
    public void ColloblastyDescription()
    {
            // ��� ��������
        if (leveler.languager == 0)
        {
            nazvanieText.text = "Colloblasts";
            descriptionText.text = "Skills for which targets \nare chosen in groups: sticky \nsecret allows to capture and \nneutralize them";
        }
        if (leveler.languager == 1)
        {
            nazvanieText.text = "�����������";
            descriptionText.text = "������ �������, ��� ������� \n���� ���������� �������: � \n������� �������� ������� ����� \n��������� � ����������� ��";
        }
        else if (leveler.languager == 2)
        {
            nazvanieText.text = "����������";
            descriptionText.text = "������ ���������, ��� ���� \n��� ���������� �������: �� \n��������� �������� ������� \n�� ����� �������� �� ����������";
        }
        kletinki.SetActive(false);
        Kletochka1.SetActive(false);
        Kletochka2.SetActive(false);
        Kletochka3.SetActive(false);
        Kletochka4.SetActive(false);
        Kletochka5.SetActive(false);
        Kletochka6.SetActive(false);
        Kletochka7.SetActive(false);
        Kletochka8.SetActive(false);
        Kletochka9.SetActive(false);
        if (SpritsUsed == false)
        {
            if (rColloblasty > 0 && currentSprits < maximumSprits) // �������� ���������, ���� ���� ����
            {
                rColloblasty -= 1;
                kachColloblasty += 1;
            }
            else if (rColloblasty > 0 && kachColloblasty > 0 && currentSprits == maximumSprits) // �������� ��������� ��������, ���� ������ ������
            {
                rColloblasty += kachColloblasty;
                kachColloblasty = 0;
            }
            else if (rColloblasty == 0 && kachColloblasty > 0) // �������� ��������� ��������, ���� ������� ��������
            {
                rColloblasty = kachColloblasty;
                kachColloblasty = 0;

            }
        }
    }
    public void CirriDescription()
    {
        // ��� ��������
        if (leveler.languager == 0)
        {
            nazvanieText.text = "Cirri, needles";
            descriptionText.text = "Ranged skills available: sharp \nappendages facilitate movement on \nthe substrate, perform a protective \nfunction and provide angularity";
        }
        if (leveler.languager == 1)
        {
            nazvanieText.text = "�����, ����";
            descriptionText.text = "������ ������� �������� ���: ������ \n�������� ��������� �������� �� \n��������� � ��������� �������� \n�������, ������� �����������";
        }
        else if (leveler.languager == 2)
        {
            nazvanieText.text = "�����, �����";
            descriptionText.text = "������ ��������� �� �������� ���: \n����� �������� ���������� ��� �� \n��������� �� ��������� ������� \n�������, ���������� ���������";
        }
        kletinki.SetActive(false);
        Kletochka1.SetActive(false);
        Kletochka2.SetActive(false);
        Kletochka3.SetActive(false);
        Kletochka4.SetActive(false);
        Kletochka5.SetActive(false);
        Kletochka6.SetActive(false);
        Kletochka7.SetActive(false);
        Kletochka8.SetActive(false);
        Kletochka9.SetActive(false);
        if (SpritsUsed == false)
        {
            if (rCirri > 0 && currentSprits < maximumSprits) // �������� ���������, ���� ���� ����
            {
                rCirri -= 1;
                kachCirri += 1;
                if (degrodadoptPossibility + pSliz > 5 && degrodus26 == false)
                {
                    dSliz += 1;
                    degrodus26 = true;
                }
            }
            else if (rCirri > 0 && kachCirri > 0 && currentSprits == maximumSprits) // �������� ��������� ��������, ���� ������ ������
            {
                if (degrodus26)
                {
                    dSliz -= 1;
                    degrodus26 = false;
                }
                rCirri += kachCirri;
                kachCirri = 0;
            }
            else if (rCirri == 0 && kachCirri > 0) // �������� ��������� ��������, ���� ������� ��������
            {
                if (degrodus26)
                {
                    dSliz -= 1;
                    degrodus26 = false;
                }
                rCirri = kachCirri;
                kachCirri = 0;

            }
        }
    }
    public void PlavnikiDescription()
    {
        // ��� ��������
        if (leveler.languager == 0)
        {
            nazvanieText.text = "Fins";
            descriptionText.text = "dual skills available: \nsymmetrical limbs support \nmovement and balancing \ndeep in the ocean";
        }
        if (leveler.languager == 1)
        {
            nazvanieText.text = "��������";
            descriptionText.text = "������ ������ �������: \n������������ ���������� \n������������ ������������ � \n�������������� � ����� ����";
        }
        else if (leveler.languager == 2)
        {
            nazvanieText.text = "��������";
            descriptionText.text = "������ ������ ���������: \n��������� ������� �������� \n����������� �� ������������ � \n����� ����";
        }
        kletinki.SetActive(false);
        Kletochka1.SetActive(false);
        Kletochka2.SetActive(false);
        Kletochka3.SetActive(false);
        Kletochka4.SetActive(false);
        Kletochka5.SetActive(false);
        Kletochka6.SetActive(false);
        Kletochka7.SetActive(false);
        Kletochka8.SetActive(false);
        Kletochka9.SetActive(false);
        if (SpritsUsed == false)
        {
            if (rPlavniki > 0 && currentSprits < maximumSprits) // �������� ���������, ���� ���� ����
            {
                rPlavniki -= 1;
                kachPlavniki += 1;
            }
            else if (rPlavniki > 0 && kachPlavniki > 0 && currentSprits == maximumSprits) // �������� ��������� ��������, ���� ������ ������
            {
                rPlavniki += kachPlavniki;
                kachPlavniki = 0;
            }
            else if (rPlavniki == 0 && kachPlavniki > 0) // �������� ��������� ��������, ���� ������� ��������
            {
                rPlavniki = kachPlavniki;
                kachPlavniki = 0;

            }
        }
    }
    public void ZubyDescription()
    {
        // ��� ��������
        if (leveler.languager == 0)
        {
            nazvanieText.text = "Teeth";
            descriptionText.text = "Power absorption skills available: \ndangerous articulated jaws allow \nto catch and swallow the whole \nprey without any energy waste";
        }
        if (leveler.languager == 1)
        {
            nazvanieText.text = "����";
            descriptionText.text = "������ ������� ���������� ���: \n������� �������� ���������� \n������� ��������� ������ � ������� \n������ ������� ��� ������ �������";
        }
        else if (leveler.languager == 2)
        {
            nazvanieText.text = "����";
            descriptionText.text = "������ ��������� �� ���������� ���: \n���������� ������� ��������� \n������ �������� ������ � ������� \n������ ������� ��� ������ ����㳿";
        }
        kletinki.SetActive(false);
        Kletochka1.SetActive(false);
        Kletochka2.SetActive(false);
        Kletochka3.SetActive(false);
        Kletochka4.SetActive(false);
        Kletochka5.SetActive(false);
        Kletochka6.SetActive(false);
        Kletochka7.SetActive(false);
        Kletochka8.SetActive(false);
        Kletochka9.SetActive(false);
        if (SpritsUsed == false)
        {
            if (rZuby > 0 && currentSprits < maximumSprits) // �������� ���������, ���� ���� ����
            {
                rZuby -= 1;
                kachZuby += 1;
                if (degrodadoptPossibility + pSliz > 5 && degrodus27 == false)
                {
                    dSliz += 1;
                    degrodus27 = true;
                }
            }
            else if (rZuby > 0 && kachZuby > 0 && currentSprits == maximumSprits) // �������� ��������� ��������, ���� ������ ������
            {
                if (degrodus27)
                {
                    dSliz -= 1;
                    degrodus27 = false;
                }
                rZuby += kachZuby;
                kachZuby = 0;

            }
            else if (rZuby == 0 && kachZuby > 0) // �������� ��������� ��������, ���� ������� ��������
            {
                if (degrodus27)
                {
                    dSliz -= 1;
                    degrodus27 = false;
                }
                rZuby = kachZuby;
                kachZuby = 0;

            }
        }
    }

    public void SpritsVveden()
    {
        if (SpritsEbosh == false && currentSprits > 0)
        {
            SpritsEbosh = true;
        }

        if (SpritsEbosh && confirms.podtverjdenoTapom == false)
        {
            confirms.noteBack.SetActive(false);
            if (leveler.languager == 0)
            {
                confirms.confirmText.text = "Insert selected \ngenes?";
            }
            if (leveler.languager == 1)
            {
                confirms.confirmText.text = "�������� ��������� \n����?";
            }
            if (leveler.languager == 2)
            {
                confirms.confirmText.text = "������ ����� ����?";
            }
            confirms.podtverjdenoTapom = false;
            confirms.nepodtverjdenoTapom = false;
            confirms.podtverjdenoOk = false;
            confirms.confirmBack.SetActive(true);
        }

        if (confirms.podtverjdenoTapom && SpritsEbosh)
        {
            shprits.Play(0);
            confirms.confirmBack.SetActive(false);
            SpritsEbosh = false;
            confirms.podtverjdenoTapom = false;
            confirms.nepodtverjdenoTapom = false;
            confirms.podtverjdenoOk = false;
            // ������ ���������� � ������ (��� � ����������� � �, ��������� � � �, � = 0, � = 0)
            pStatocyst += kachStatocyst;
            pHydropora += kachHydropora;
            pOsmolit += kachOsmolit;
            pLipid += kachLipid;
            pKrioprotector += kachKrioprotector;
            pGigantizm += kachGigantizm;
            pSliz += kachSliz;
            pPancer += kachPancer;
            pEcholocatia += kachEcholocatia;
            pHemoreceptor += kachHemoreceptor;
            pPhotoreceptor += kachPhotoreceptor;
            pMechanoreceptor += kachMechanoreceptor;
            pElectroreceptor += kachElectroreceptor;
            pRedPigment += kachRedPigment;
            pProzrachnost += kachProzrachnost;
            pChernyyPigment += kachChernyyPigment;
            pMimicria += kachMimicria;
            pLuminiscencia += kachLuminiscencia;
            pToxiny += kachToxiny;
            pRegeneration += kachRegeneration;
            pEvisceration += kachEvisceration;
            pPedicellariy += kachPedicellariy;
            pPrisosky += kachPrisosky;
            pChernMeshok += kachChernMeshok;
            pCuvierovi += kachCuvierovi;
            pColloblasty += kachColloblasty;
            pCirri += kachCirri;
            pPlavniki += kachPlavniki;
            pImmunitet += kachImmunitet;
            pZuby += kachZuby;
            pDopPolost += kachDopPolost;
            pDopEnergia += kachDopEnergia;
            pPheromones += kachPheromones;
            pDegradation += kachDegradation;
            pUskorennoeRazvitie += kachUskorennoeRazvitie;
            pMagnetic += kachMagnetic;
            rStatocyst = 0;
            rHydropora = 0;
            rOsmolit = 0;
            rLipid = 0;
            rKrioprotector = 0;
            rGigantizm = 0;
            rSliz = 0;
            rPancer = 0;
            rEcholocatia = 0;
            rHemoreceptor = 0;
            rPhotoreceptor = 0;
            rMechanoreceptor = 0;
            rElectroreceptor = 0;
            rRedPigment = 0;
            rProzrachnost = 0;
            rChernyyPigment = 0;
            rMimicria = 0;
            rLuminiscencia = 0;
            rToxiny = 0;
            rRegeneration = 0;
            rEvisceration = 0;
            rPedicellariy = 0;
            rPrisosky = 0;
            rChernMeshok = 0;
            rCuvierovi = 0;
            rColloblasty = 0;
            rCirri = 0;
            rPlavniki = 0;
            rImmunitet = 0;
            rZuby = 0;
            rDopPolost = 0;
            rDopEnergia = 0;
            rPheromones = 0;
            rDegradation = 0;
            rUskorennoeRazvitie = 0;
            rMagnetic = 0;

            PlayerPrefs.SetFloat("pStatocyst", pStatocyst);
            PlayerPrefs.SetFloat("pHydropora", pHydropora);
            PlayerPrefs.SetFloat("pOsmolit", pOsmolit);
            PlayerPrefs.SetFloat("pLipid", pLipid);
            PlayerPrefs.SetFloat("pKrioprotector", pKrioprotector);
            PlayerPrefs.SetFloat("pGigantizm", pGigantizm);
            PlayerPrefs.SetFloat("pSliz", pSliz);
            PlayerPrefs.SetFloat("pPancer", pPancer);
            PlayerPrefs.SetFloat("pEcholocatia", pEcholocatia);
            PlayerPrefs.SetFloat("pHemoreceptor", pHemoreceptor);
            PlayerPrefs.SetFloat("pPhotoreceptor", pPhotoreceptor);
            PlayerPrefs.SetFloat("pMechanoreceptor", pMechanoreceptor);
            PlayerPrefs.SetFloat("pElectroreceptor", pElectroreceptor);
            PlayerPrefs.SetFloat("pRedPigment", pRedPigment);
            PlayerPrefs.SetFloat("pProzrachnost", pProzrachnost);
            PlayerPrefs.SetFloat("pChernyyPigment", pChernyyPigment);
            PlayerPrefs.SetFloat("pMimicria", pMimicria);
            PlayerPrefs.SetFloat("pLuminiscencia", pLuminiscencia);
            PlayerPrefs.SetFloat("pToxiny", pToxiny);
            PlayerPrefs.SetFloat("pRegeneration", pRegeneration);
            PlayerPrefs.SetFloat("pEvisceration", pEvisceration);
            PlayerPrefs.SetFloat("pPedicellariy", pPedicellariy);
            PlayerPrefs.SetFloat("pPrisosky", pPrisosky);
            PlayerPrefs.SetFloat("pChernMeshok", pChernMeshok);
            PlayerPrefs.SetFloat("pCuvierovi", pCuvierovi);
            PlayerPrefs.SetFloat("pColloblasty", pColloblasty);
            PlayerPrefs.SetFloat("pCirri", pCirri);
            PlayerPrefs.SetFloat("pPlavniki", pPlavniki);
            PlayerPrefs.SetFloat("pImmunitet", pImmunitet);
            PlayerPrefs.SetFloat("pZuby", pZuby);
            PlayerPrefs.SetFloat("pDopPolost", pDopPolost);
            PlayerPrefs.SetFloat("pDopEnergia", pDopEnergia);
            PlayerPrefs.SetFloat("pPheromones", pPheromones);
            PlayerPrefs.SetFloat("pDegradation", pDegradation);
            PlayerPrefs.SetFloat("pUskorennoeRazvitie", pUskorennoeRazvitie);
            PlayerPrefs.SetFloat("pMagnetic", pMagnetic);
            PlayerPrefs.SetFloat("dStatocyst", dStatocyst);
            PlayerPrefs.SetFloat("dHydropora", dHydropora);
            PlayerPrefs.SetFloat("dOsmolit", dOsmolit);
            PlayerPrefs.SetFloat("dLipid", dLipid);
            PlayerPrefs.SetFloat("dKrioprotector", dKrioprotector);
            PlayerPrefs.SetFloat("dGigantizm", dGigantizm);
            PlayerPrefs.SetFloat("dSliz", dSliz);
            PlayerPrefs.SetFloat("dPancer", dPancer);
            PlayerPrefs.SetFloat("dEcholocatia", dEcholocatia);
            PlayerPrefs.SetFloat("dHemoreceptor", dHemoreceptor);
            PlayerPrefs.SetFloat("dPhotoreceptor", dPhotoreceptor);
            PlayerPrefs.SetFloat("dMechanoreceptor", dMechanoreceptor);
            PlayerPrefs.SetFloat("dElectroreceptor", dElectroreceptor);
            PlayerPrefs.SetFloat("dRedPigment", dRedPigment);
            PlayerPrefs.SetFloat("dProzrachnost", dProzrachnost);
            PlayerPrefs.SetFloat("dChernyyPigment", dChernyyPigment);
            PlayerPrefs.SetFloat("dMimicria", dMimicria);
            PlayerPrefs.SetFloat("dLuminiscencia", dLuminiscencia);
            PlayerPrefs.SetFloat("dToxiny", dToxiny);
            PlayerPrefs.SetFloat("dRegeneration", dRegeneration);
            PlayerPrefs.SetFloat("dEvisceration", dEvisceration);
            PlayerPrefs.SetFloat("dPedicellariy", dPedicellariy);
            PlayerPrefs.SetFloat("dPrisosky", dPrisosky);
            PlayerPrefs.SetFloat("dChernMeshok", dChernMeshok);
            PlayerPrefs.SetFloat("dCuvierovi", dCuvierovi);
            PlayerPrefs.SetFloat("dColloblasty", dColloblasty);
            PlayerPrefs.SetFloat("dCirri", dCirri);
            PlayerPrefs.SetFloat("dPlavniki", dPlavniki);
            PlayerPrefs.SetFloat("dImmunitet", dImmunitet);
            PlayerPrefs.SetFloat("dZuby", dZuby);
            PlayerPrefs.SetFloat("dDopPolost", dDopPolost);
            PlayerPrefs.SetFloat("dDopEnergia", dDopEnergia);
            PlayerPrefs.SetFloat("dPheromones", dPheromones);
            PlayerPrefs.SetFloat("dDegradation", dDegradation);
            PlayerPrefs.SetFloat("dUskorennoeRazvitie", dUskorennoeRazvitie);
            PlayerPrefs.SetFloat("dMagnetic", dMagnetic);

            // ���������� �����������, ���� ��� ������������ ����� ������ �� ��������������
            PlayerPrefs.SetFloat("rStatocyst", 0);
            PlayerPrefs.SetFloat("rHydropora", 0);
            PlayerPrefs.SetFloat("rOsmolit", 0);
            PlayerPrefs.SetFloat("rLipid", 0);
            PlayerPrefs.SetFloat("rKrioprotector", 0);
            PlayerPrefs.SetFloat("rGigantizm", 0);
            PlayerPrefs.SetFloat("rSliz", 0);
            PlayerPrefs.SetFloat("rPancer", 0);
            PlayerPrefs.SetFloat("rEcholocatia", 0);
            PlayerPrefs.SetFloat("rHemoreceptor", 0);
            PlayerPrefs.SetFloat("rPhotoreceptor", 0);
            PlayerPrefs.SetFloat("rMechanoreceptor", 0);
            PlayerPrefs.SetFloat("rElectroreceptor", 0);
            PlayerPrefs.SetFloat("rRedPigment", 0);
            PlayerPrefs.SetFloat("rProzrachnost", 0);
            PlayerPrefs.SetFloat("rChernyyPigment", 0);
            PlayerPrefs.SetFloat("rMimicria", 0);
            PlayerPrefs.SetFloat("rLuminiscencia", 0);
            PlayerPrefs.SetFloat("rToxiny", 0);
            PlayerPrefs.SetFloat("rRegeneration", 0);
            PlayerPrefs.SetFloat("rEvisceration", 0);
            PlayerPrefs.SetFloat("rPedicellariy", 0);
            PlayerPrefs.SetFloat("rPrisosky", 0);
            PlayerPrefs.SetFloat("rChernMeshok", 0);
            PlayerPrefs.SetFloat("rCuvierovi", 0);
            PlayerPrefs.SetFloat("rColloblasty", 0);
            PlayerPrefs.SetFloat("rCirri", 0);
            PlayerPrefs.SetFloat("rPlavniki", 0);
            PlayerPrefs.SetFloat("rImmunitet", 0);
            PlayerPrefs.SetFloat("rZuby", 0);
            PlayerPrefs.SetFloat("rDopPolost", 0);
            PlayerPrefs.SetFloat("rDopEnergia", 0);
            PlayerPrefs.SetFloat("rPheromones", 0);
            PlayerPrefs.SetFloat("rDegradation", 0);
            PlayerPrefs.SetFloat("rUskorennoeRazvitie", 0);
            PlayerPrefs.SetFloat("rMagnetic", 0);
            PlayerPrefs.Save();
            indicatorText.text = " ";
            SpritsUsed = true;
            SpritsText.text = " ";
            kachStatocyst = 0;
            kachHydropora = 0;
            kachOsmolit = 0;
            kachLipid = 0;
            kachKrioprotector = 0;
            kachGigantizm = 0;
            kachSliz = 0;
            kachPancer = 0;
            kachEcholocatia = 0;
            kachHemoreceptor = 0;
            kachPhotoreceptor = 0;
            kachMechanoreceptor = 0;
            kachElectroreceptor = 0;
            kachRedPigment = 0;
            kachProzrachnost = 0;
            kachChernyyPigment = 0;
            kachMimicria = 0;
            kachLuminiscencia = 0;
            kachToxiny = 0;
            kachRegeneration = 0;
            kachEvisceration = 0;
            kachPedicellariy = 0;
            kachPrisosky = 0;
            kachChernMeshok = 0;
            kachCuvierovi = 0;
            kachColloblasty = 0;
            kachCirri = 0;
            kachPlavniki = 0;
            kachImmunitet = 0;
            kachZuby = 0;
            kachDopPolost = 0;
            kachDopEnergia = 0;
            kachPheromones = 0;
            kachDegradation = 0;
            kachUskorennoeRazvitie = 0;
            kachMagnetic = 0;
        }
    }








}
