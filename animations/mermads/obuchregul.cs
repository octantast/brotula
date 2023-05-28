using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class obuchregul : MonoBehaviour
{
    public music music;
    public battlefinal final;
    public PlayerController playercontrl;
    public BattleScreen batol;
    public battleplayer bplayer;
    public MermaidController mermaids;
    public BeforeDive beforedive;
    public SkillsController skills;
    public Levels leveler;
    public GenController gens;
    public DistanceToCheckpoint distan;
    public skillsreader skilletina;

    public GameObject podsklimit;
    public GameObject podskgenes;
    public GameObject nachalnyyecrantap;
    public GameObject skillpokaz;
    public GameObject batoltip;
    public GameObject batoltip2;
    public GameObject mermadstip;
    public GameObject mermadstippriz;
    public GameObject podskgenes1;
    public GameObject podskgenes2;
    public bool mermadstipkrug;
    public bool mermadstiptext;
    public ConfirmScreen confirms;
    public GameObject skipneud;

    private bool once;
    public bool mozhnogasnut;
    public bool batoltip2ugasnet;
    public bool prizegone;
    public bool prizestillreading;
    public bool prizegoneforever;
    public bool gentipnormie;
    public bool genofond;
    public bool mermaidslimited;

    public Text thatpriztext;
    private float skipneudacha;
    public bool skippi;
    public bool pidskazka_the_end;

    public float genescount;
    public float mermaidscount;
    public float enemiescount;

    // Start is called before the first frame update
    void Start()
    {
        skipneud.SetActive(false);
        skillpokaz.SetActive(false);
        batoltip.SetActive(false);
        batoltip2.SetActive(false);
        mermadstip.SetActive(false);
        mermadstippriz.SetActive(false);
        podskgenes1.SetActive(false);
        podskgenes2.SetActive(false);
        podsklimit.SetActive(false);
        music.cutscene3Unlocked = PlayerPrefs.GetFloat("cutscene3Unlocked");

    }

    public void SkipOtkl()
    {
        skippi = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (skipneud.activeSelf == true && batol.battleMode && bplayer.playingMode == false && batol.skippingMode == false && leveler.settingsMode.activeSelf == false && skills.skillsBack.activeSelf == false && confirms.presentBack.activeSelf == false && confirms.noteBack.activeSelf == false && confirms.confirmBack.activeSelf == false)
        {
            skippi = true;
        }
        else if (skipneud.activeSelf == true && (bplayer.playingMode || batol.skippingMode))
        {
            skippi = false;
        }
        else if (skipneud.activeSelf == true && playercontrl.transform.position.x >= 51)
        {
            skippi = false;
            skipneud.SetActive(false);
        }
        else if (skipneud.activeSelf == true)
        {
            skippi = false;
            skipneud.SetActive(false);
        }


        if (podsklimit.activeSelf == true && mermaids.garemBack.activeSelf == false && confirms.presentBack.activeSelf == true && confirms.presentYes.activeSelf == false)
        {
            mermaidslimited = true;
        }
        else if(podsklimit.activeSelf == true && confirms.presentBack.activeSelf == true && confirms.presentYes.activeSelf == true)
        {
            mermaidslimited = false;
        }
        else if(podsklimit.activeSelf == true)
        {
            mermaidslimited = false;
            podsklimit.SetActive(false);
        }

        if (distan.distance <= 5030 && podskgenes.activeSelf == true && gens.gensBack.activeSelf == false && leveler.settingsMode.activeSelf == false)
        {
            genofond = true;
        }
        else if (distan.distance <= 5030 && podskgenes.activeSelf == true && gens.gensBack.activeSelf == true)
        {
            podskgenes.SetActive(false);
            genofond = false;
        }
        else if(distan.distance < 5049 && podskgenes.activeSelf == true && gens.gensBack.activeSelf == false)
        {
            genofond = false;
        }
        else if(distan.distance >= 5049 && podskgenes.activeSelf == true)
        {
            podskgenes.SetActive(false);
            genofond = false;
        }



        // если первые тотал редз и дистанци€ меньше 50 и нет экрана генов или настроек или окскрина или презентскрина
        if (leveler.genstopevershown == 0 && gens.totalreads != 0f && distan.distance < 5030 && leveler.settingsMode.activeSelf == false && confirms.noteBack.activeSelf == false && confirms.confirmBack.activeSelf == false && confirms.presentBack.activeSelf == false && gens.gensBack.activeSelf == false && leveler.settingsMode.activeSelf == false)
        {
            gentipnormie = true;
            podskgenes1.SetActive(true);
        }
        // если экран генов, исчезает
        else if (distan.distance < 5030 && podskgenes1.activeSelf == true && gens.gensBack.activeSelf == true)
        {
            leveler.genstopevershown = 1;
            voidgenstopevershown();
            gentipnormie = false;
            podskgenes1.SetActive(false);
        }
        // иначе гаснет, об€зательно до 50
        else if (distan.distance >= 5030 && distan.distance < 5050 && podskgenes1.activeSelf == true)
        {
            gentipnormie = false;
        }

        // если есть гены и еще ничего не вкачано (0 п, кто считает? кружок ниже кнопки получаетс€), чтоб все спирали были закрыты
        if (gens.totalreads != 0f && distan.distance <= 5030 && gens.currentRs > 0 && gens.currentPs == 0 && gens.gensBack.activeSelf == true && gens.adoptationTab.activeSelf == false && gens.receptorsTab.activeSelf == false && gens.battleTab.activeSelf == false && gens.progressTab.activeSelf == false && gens.pigmentTab.activeSelf == false && gens.SpritsUsed == false)
        {
            podskgenes2.SetActive(true);
        }
        else if (distan.distance <= 5030)
        {
            podskgenes2.SetActive(false);
        }
        else if (distan.distance > 5030 && distan.distance < 5050)
        {
            podskgenes2.SetActive(false);
        }


        if ((distan.distance <= 5050 && gens.gensBack.activeSelf == false && leveler.settingsMode.activeSelf == false && leveler.expe == 0 && leveler.level == 0) || (music.cutscene3Unlocked == 1 && distan.distance <= 5050 && gens.gensBack.activeSelf == false && leveler.settingsMode.activeSelf == false))
        {
            if (music.cutscene3Unlocked == 1)
            {
                // PlayerPrefs.SetFloat("cutscene3Unlocked", 2);
                // PlayerPrefs.Save();
                genescount = gens.totalreads * 100f / 33f; // % генов из 35
                // враги из 45
                batol.readfish = PlayerPrefs.GetFloat("readfish");
                batol.readAliss = PlayerPrefs.GetFloat("readAliss");
                batol.readAsce = PlayerPrefs.GetFloat("readAsce");
                batol.readAbbet = PlayerPrefs.GetFloat("readAbbet");
                batol.readBabil = PlayerPrefs.GetFloat("readBabil");
                batol.readBatiz = PlayerPrefs.GetFloat("readBatiz");
                batol.readBent = PlayerPrefs.GetFloat("readBent");
                batol.readCellisee = PlayerPrefs.GetFloat("readCellisee");
                batol.readCirrat = PlayerPrefs.GetFloat("readCirrat");
                batol.readDemos = PlayerPrefs.GetFloat("readDemos");
                batol.readEchin = PlayerPrefs.GetFloat("readEchin");
                batol.readEkhir = PlayerPrefs.GetFloat("readEkhir");
                batol.readGalan = PlayerPrefs.GetFloat("readGalan");
                batol.readGolor = PlayerPrefs.GetFloat("readGolor");
                batol.readGren = PlayerPrefs.GetFloat("readGren");
                batol.readHadee = PlayerPrefs.GetFloat("readHadee");
                batol.readHeeth = PlayerPrefs.GetFloat("readHeeth");
                batol.readHio = PlayerPrefs.GetFloat("readHio");
                batol.readKhirond = PlayerPrefs.GetFloat("readKhirond");
                batol.readKoryph = PlayerPrefs.GetFloat("readKoryph");
                batol.readKridei = PlayerPrefs.GetFloat("readKridei");
                batol.readLat = PlayerPrefs.GetFloat("readLat");
                batol.readLihet = PlayerPrefs.GetFloat("readLihet");
                batol.readMarius = PlayerPrefs.GetFloat("readMarius");
                batol.readMikt = PlayerPrefs.GetFloat("readMikt");
                batol.readNemin = PlayerPrefs.GetFloat("readNemin");
                batol.readNerrelid = PlayerPrefs.GetFloat("readNerrelid");
                batol.readNophor = PlayerPrefs.GetFloat("readNophor");
                batol.readPareed = PlayerPrefs.GetFloat("readPareed");
                batol.readPaster = PlayerPrefs.GetFloat("readPaster");
                batol.readPhanos = PlayerPrefs.GetFloat("readPhanos");
                batol.readPharn = PlayerPrefs.GetFloat("readPharn");
                batol.readPhiu = PlayerPrefs.GetFloat("readPhiu");
                batol.readPhobel = PlayerPrefs.GetFloat("readPhobel");
                batol.readPlog = PlayerPrefs.GetFloat("readPlog");
                batol.readPopmp = PlayerPrefs.GetFloat("readPopmp");
                batol.readProkt = PlayerPrefs.GetFloat("readProkt");
                batol.readRago = PlayerPrefs.GetFloat("readRago");
                batol.readRoid = PlayerPrefs.GetFloat("readRoid");
                batol.readSactin = PlayerPrefs.GetFloat("readSactin");
                batol.readSciph = PlayerPrefs.GetFloat("readSciph");
                batol.readSothet = PlayerPrefs.GetFloat("readSothet");
                batol.readThanaid = PlayerPrefs.GetFloat("readThanaid");
                batol.readThemum = PlayerPrefs.GetFloat("readThemum");
                batol.readTheus = PlayerPrefs.GetFloat("readTheus");
                batol.readTkhar = PlayerPrefs.GetFloat("readTkhar");
                batol.readTopel = PlayerPrefs.GetFloat("readTopel");
                batol.readTyphlon = PlayerPrefs.GetFloat("readTyphlon");
                batol.readZem = PlayerPrefs.GetFloat("readZem");
                enemiescount = (batol.readfish + batol.readAliss + batol.readAsce + batol.readAbbet + batol.readBabil + batol.readBatiz + batol.readBent + batol.readCellisee + batol.readCirrat + batol.readDemos + batol.readEchin + batol.readEkhir + batol.readGalan + batol.readGolor + batol.readGren + batol.readHadee + batol.readHeeth + batol.readHio + batol.readKhirond + batol.readKoryph + batol.readKridei + batol.readLat + batol.readLihet + batol.readMarius + batol.readMikt + batol.readNemin + batol.readNerrelid + batol.readNophor + batol.readPareed + batol.readPaster + batol.readPhanos + batol.readPharn + batol.readPhiu + batol.readPhobel + batol.readPlog + batol.readPopmp + batol.readProkt + batol.readRago + batol.readRoid + batol.readSactin + batol.readSciph + batol.readSothet + batol.readThanaid + batol.readThemum + batol.readTheus + batol.readTkhar + batol.readTopel + batol.readTyphlon + batol.readZem) * 100f / 45f;
                mermaids.pAlissaMermaid = PlayerPrefs.GetFloat("pAlissaMermaid"); //9
                mermaids.pAsceaMermaid = PlayerPrefs.GetFloat("pAsceaMermaid"); //29
                mermaids.pAbbetaMermaid = PlayerPrefs.GetFloat("pAbbetaMermaid"); //11
                mermaids.pBabilaMermaid = PlayerPrefs.GetFloat("pBabilaMermaid"); //17
                mermaids.pBatizaMermaid = PlayerPrefs.GetFloat("pBatizaMermaid"); //2
                mermaids.pBentaMermaid = PlayerPrefs.GetFloat("pBentaMermaid"); //8
                mermaids.pCelliseeaMermaid = PlayerPrefs.GetFloat("pCelliseeaMermaid"); //41
                mermaids.pCirrataMermaid = PlayerPrefs.GetFloat("pCirrataMermaid");  //3
                mermaids.pDemosaMermaid = PlayerPrefs.GetFloat("pDemosaMermaid");  //46
                mermaids.pEchinaMermaid = PlayerPrefs.GetFloat("pEchinaMermaid"); //21
                mermaids.pEkhiraMermaid = PlayerPrefs.GetFloat("pEkhiraMermaid"); //38
                mermaids.pGalanaMermaid = PlayerPrefs.GetFloat("pGalanaMermaid"); //34
                mermaids.pGoloraMermaid = PlayerPrefs.GetFloat("pGoloraMermaid"); //48
                mermaids.pGrenaMermaid = PlayerPrefs.GetFloat("pGrenaMermaid"); //25
                mermaids.pHadeeaMermaid = PlayerPrefs.GetFloat("pHadeeaMermaid"); //45
                mermaids.pHeethaMermaid = PlayerPrefs.GetFloat("pHeethaMermaid"); //19
                mermaids.pHioaMermaid = PlayerPrefs.GetFloat("pHioaMermaid"); //33
                mermaids.pKhirondaMermaid = PlayerPrefs.GetFloat("pKhirondaMermaid"); //44
                mermaids.pKoryphaMermaid = PlayerPrefs.GetFloat("pKoryphaMermaid"); //26
                mermaids.pKrideiaMermaid = PlayerPrefs.GetFloat("pKrideiaMermaid"); //1
                mermaids.pLataMermaid = PlayerPrefs.GetFloat("pLataMermaid"); //35
                mermaids.pLihetaMermaid = PlayerPrefs.GetFloat("pLihetaMermaid"); //16
                mermaids.pMariusaMermaid = PlayerPrefs.GetFloat("pMariusaMermaid"); //40
                mermaids.pMiktaMermaid = PlayerPrefs.GetFloat("pMiktaMermaid"); //27
                mermaids.pNeminaMermaid = PlayerPrefs.GetFloat("pNeminaMermaid"); //7
                mermaids.pNerrelidaMermaid = PlayerPrefs.GetFloat("pNerrelidaMermaid"); //47
                mermaids.pNophoraMermaid = PlayerPrefs.GetFloat("pNophoraMermaid"); //28
                mermaids.pPareedaMermaid = PlayerPrefs.GetFloat("pPareedaMermaid"); //32
                mermaids.pPasteraMermaid = PlayerPrefs.GetFloat("pPasteraMermaid"); //13
                mermaids.pPhanosaMermaid = PlayerPrefs.GetFloat("pPhanosaMermaid"); //22
                mermaids.pPharnaMermaid = PlayerPrefs.GetFloat("pPharnaMermaid"); //5
                mermaids.pPhiuaMermaid = PlayerPrefs.GetFloat("pPhiuaMermaid"); //10
                mermaids.pPhobelaMermaid = PlayerPrefs.GetFloat("pPhobelaMermaid"); //12
                mermaids.pPlogaMermaid = PlayerPrefs.GetFloat("pPlogaMermaid"); //4
                mermaids.pPopmpaMermaid = PlayerPrefs.GetFloat("pPopmpaMermaid"); //14
                mermaids.pProktaMermaid = PlayerPrefs.GetFloat("pProktaMermaid"); //31
                mermaids.pRagoaMermaid = PlayerPrefs.GetFloat("pRagoaMermaid"); //37
                mermaids.pRoidaMermaid = PlayerPrefs.GetFloat("pRoidaMermaid"); //39
                mermaids.pSactinaMermaid = PlayerPrefs.GetFloat("pSactinaMermaid"); //18
                mermaids.pSciphaMermaid = PlayerPrefs.GetFloat("pSciphaMermaid"); //36
                mermaids.pSothetaMermaid = PlayerPrefs.GetFloat("pSothetaMermaid"); //20
                mermaids.pThanaidaMermaid = PlayerPrefs.GetFloat("pThanaidaMermaid"); //42
                mermaids.pThemumaMermaid = PlayerPrefs.GetFloat("pThemumaMermaid"); //43
                mermaids.pTheusaMermaid = PlayerPrefs.GetFloat("pTheusaMermaid"); //23
                mermaids.pTkharaMermaid = PlayerPrefs.GetFloat("pTkharaMermaid"); //30
                mermaids.pTopelaMermaid = PlayerPrefs.GetFloat("pTopelaMermaid"); //15
                mermaids.pTyphlonaMermaid = PlayerPrefs.GetFloat("pTyphlonaMermaid"); //6
                mermaids.pZemaMermaid = PlayerPrefs.GetFloat("pZemaMermaid"); //24

                mermaidscount = (mermaids.pAlissaMermaid + mermaids.pAsceaMermaid + mermaids.pAbbetaMermaid + mermaids.pBabilaMermaid + mermaids.pBatizaMermaid + mermaids.pBentaMermaid + mermaids.pCelliseeaMermaid + mermaids.pCirrataMermaid + mermaids.pDemosaMermaid + mermaids.pEchinaMermaid + mermaids.pEkhiraMermaid + mermaids.pGalanaMermaid + mermaids.pGoloraMermaid + mermaids.pGrenaMermaid + mermaids.pHadeeaMermaid + mermaids.pHeethaMermaid + mermaids.pHioaMermaid + mermaids.pKhirondaMermaid + mermaids.pKoryphaMermaid + mermaids.pKrideiaMermaid + mermaids.pLataMermaid + mermaids.pLihetaMermaid + mermaids.pMariusaMermaid + mermaids.pMiktaMermaid + mermaids.pNeminaMermaid + mermaids.pNerrelidaMermaid + mermaids.pNophoraMermaid + mermaids.pPareedaMermaid + mermaids.pPasteraMermaid + mermaids.pPhanosaMermaid + mermaids.pPharnaMermaid + mermaids.pPhiuaMermaid + mermaids.pPhobelaMermaid + mermaids.pPlogaMermaid + mermaids.pPopmpaMermaid + mermaids.pProktaMermaid + mermaids.pRagoaMermaid + mermaids.pRoidaMermaid + mermaids.pSactinaMermaid + mermaids.pSciphaMermaid + mermaids.pSothetaMermaid + mermaids.pThanaidaMermaid + mermaids.pThemumaMermaid + mermaids.pTheusaMermaid + mermaids.pTkharaMermaid + mermaids.pTopelaMermaid + mermaids.pTyphlonaMermaid + mermaids.pZemaMermaid) * 100f / 44f;
                pidskazka_the_end = true;
            }
            nachalnyyecrantap.SetActive(true);
        }
        else
        {
            pidskazka_the_end = false;
            nachalnyyecrantap.SetActive(false);
        }

        if (distan.distance > 5110 && beforedive.skillsknopablesk.activeSelf == true && skills.skillsBack.activeSelf == false && leveler.expe == 0 && leveler.level == 0 && leveler.settingsMode.activeSelf == false && mermaids.garemBack.activeSelf == false && batol.battleMode == false)
        {
            skillpokaz.SetActive(true);
        }
        else
        {
            skillpokaz.SetActive(false);
        }


        // обучение пропуску и бою, это если включилс€ экран скиллов, и если на поле ни одного навыка. как только там навык, текст мен€етс€
        // если первый враг встретилс€, слоты выехали, и игрок еще не сходил в навыки
        if (once == false && leveler.level == 0 && leveler.expe == 0 && batol.battleMode == true && skills.skillsBack.activeSelf == false && leveler.settingsMode.activeSelf == false && confirms.noteBack.activeSelf == false && confirms.confirmBack.activeSelf == false && confirms.presentBack.activeSelf == false && bplayer.playingMode == false && batol.skippingMode == false)
        {
            playercontrl.podtverjdBoi.SetActive(false);
            skills.skillson.SetActive(true);
            batoltip.SetActive(true);
        }
        else if (batoltip.activeSelf == true)
        {
            batoltip.SetActive(false);
            if (skills.skillsBack.activeSelf == true) // если после показа зашли в скиллз, то надпись изменитс€
            {
                once = true;

            }
        }
        // здесь не учитывает удачный пропуск
        if (skipneud.activeSelf == false && distan.distance < 5370 && once && leveler.level == 0 && leveler.expe == 0 && batol.battleMode == true && skills.skillsBack.activeSelf == false && leveler.settingsMode.activeSelf == false && confirms.noteBack.activeSelf == false && confirms.confirmBack.activeSelf == false && confirms.presentBack.activeSelf == false && bplayer.playingMode == false && batol.skippingMode == false)
        {
            playercontrl.podtverjdBoi.SetActive(true);
            skills.skillson.SetActive(true);
            batoltip2.SetActive(true);
        }
        else if((once && leveler.expe == 0 && leveler.level == 0 && batol.battleMode == true && skills.skillsBack.activeSelf == false && leveler.settingsMode.activeSelf == false && confirms.noteBack.activeSelf == false && confirms.confirmBack.activeSelf == false && confirms.presentBack.activeSelf == false) && (bplayer.playingMode == true || batol.skippingMode == true)) // угасание
        {
            batoltip2ugasnet = true;
        }
        else
        {
            batoltip2.SetActive(false);
        }




        if (mermaids.udelenie > 0 && leveler.mermaidstopevershown == 0 && mermaids.mermaids > 0 && mermaids.garemBack.activeSelf == false && batol.battleMode == false && skills.skillsBack.activeSelf == false && leveler.settingsMode.activeSelf == false && confirms.noteBack.activeSelf == false && confirms.confirmBack.activeSelf == false && confirms.presentBack.activeSelf == false && bplayer.playingMode == false && final.zametkascreen.activeSelf == false && skipneud.activeSelf == false)
        {
            mermadstiptext = false;
            mermadstipkrug = true;
            mermadstip.SetActive(true);
        }
        else if (mermaids.udelenie > 0 && leveler.mermaidstopevershown == 0 && mermaids.garemBack.activeSelf == true && mermaids.mermaids > 0 && mermaids.confirmGaremBack.activeSelf == false && mermaids.presentGaremBack.activeSelf == false && skipneud.activeSelf == false)
        {
            mermadstiptext = true;
            mermadstipkrug = false;
            mermadstip.SetActive(true);
            mermaidszdes();
        }
        else if (mermaids.udelenie == 0)
        {
            mermadstiptext = false;
            mermadstipkrug = false;
            if (mermadstip.activeSelf == true)
            {
                prizegone = true;
            }
            mermadstip.SetActive(false);

            leveler.mermaidstopevershown = 1;
        }
        else // не откл, но тушим
        {
            mermadstiptext = false;
            mermadstipkrug = false;
        }


        // если была использована подсказка свайпа, если хвост мигает, и не экран русалок, и призы еще есть, а также не настройки, конфирмы и т.д
        if(prizegoneforever == false && mermadstip.activeSelf == false && (prizegone || mermadstippriz.activeSelf == true) && mermaids.udelenie == mermaids.defaultudelenie && mermaids.garemBack.activeSelf == false && batol.battleMode == false && skills.skillsBack.activeSelf == false && leveler.settingsMode.activeSelf == false && confirms.noteBack.activeSelf == false && confirms.confirmBack.activeSelf == false && confirms.presentBack.activeSelf == false && bplayer.playingMode == false && final.zametkascreen.activeSelf == false)
        {
            mermadstippriz.SetActive(true);
            prizegone = true;
        }
        // другой экран
        else if(mermadstippriz.activeSelf == true && mermadstip.activeSelf == false && prizegone && mermaids.udelenie == mermaids.defaultudelenie && mermaids.garemBack.activeSelf == false && (skills.skillsBack.activeSelf == true || leveler.settingsMode.activeSelf == true || confirms.noteBack.activeSelf == true || confirms.confirmBack.activeSelf == true || confirms.presentBack.activeSelf == true))
        {
            
            prizegone = false;
            thatpriztext.text = " ";
        }
        // просто тушитс€
        else if (mermadstippriz.activeSelf == true && mermadstip.activeSelf == false && prizegone && mermaids.udelenie == mermaids.defaultudelenie && mermaids.garemBack.activeSelf == false)
        {
            prizegone = false;
        }
        else if (mermadstippriz.activeSelf == true && mermaids.garemBack.activeSelf == true) // если использована, она резко откл в экране русалок
        {
            prizegone = false;
            mermadstippriz.SetActive(false);
            prizegoneforever = true;
        }


    }

    void mermaidszdes()
    {
        PlayerPrefs.SetFloat("mermaidstopevershown", 1);
        PlayerPrefs.Save();
        mozhnogasnut = true;
    }

    void voidgenstopevershown()
    {
        PlayerPrefs.SetFloat("genstopevershown", 1);
        PlayerPrefs.Save();
    }
}
