using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillsController : MonoBehaviour
{

    public AudioSource bought;
    public AudioSource bought2;
    public AudioSource bought3;

    // public kolonkamahinations mahination;
    public music music;
    public battleplayer batlplair;
    public mermenreader mermanReader;
    public Levels leveler;
    public MermaidController mermaids;
    public ConfirmScreen confirms;
    public DistanceToCheckpoint distancePoints;
    public PlayerController player;
    public GenController gens;
    public BattleScreen battleModeVisibility;
    public skillsreader skillchitaka;
    public BeforeDive chekerbefore;
    public IkraIndicator ikorka;
    public battleplayer batol;
    public Slo1 slotmerman;

    public GameObject vyhod;
    public GameObject megaecranformother; // вьюпорт
    public GameObject movement;
    public GameObject slotMother;
    public GameObject colonkaMama;
    public GameObject slotsColonka;
    public GameObject slotPriem;
    public GameObject skillButton;
    public GameObject skillsBack;
    public Vector2 colonkahomie;
    public Vector2 colonkacurrent;
    public float startcolonkaPosition, endcolonkaPosition;

    public GameObject skillsImitatorfordescrypt;
    public GameObject descripGG; // это шторка с объяснениями иконок
    public GameObject descripGGPanel;
    public Text description1Text;
    public Text description2Text;
    public Text description3Text;
    public Text description4Text;
    public Text description5Text;
    public Text description6Text;
    public Text description7Text;

    // магазинное
    public GameObject megaBlock;
    public GameObject phonDescr;
    public GameObject priceIcons;
    public Text nazvanieSkilla;
    public GameObject genPlace1;
    public GameObject genPlace2;
    public GameObject genPlace3;
    public GameObject yesPlease;
    public GameObject Ikrun;
    public Text skillPrice;
    public float priceIkraSkill;
    public GameObject moverCollider;
    public GameObject batolmoverCollider;

    public List<GameObject> slotList; // купленные
    public List<GameObject> slotListdostupni; // магазин
    public List<GameObject> vsepodsvetki; // магазин
    public List<GameObject> vseopisaniia;

    // слоты колонки как объекты
    public GameObject slotKolonka1, slotKolonka2, slotKolonka3, slotKolonka4, slotKolonka5, slotKolonka6, slotKolonka8, slotKolonka9, slotKolonka10, slotKolonka11, slotKolonka12, slotKolonka13, slotKolonka14, slotKolonka15, slotKolonka16, slotKolonka17, slotKolonka18, slotKolonka19, slotKolonka20, slotKolonka21, slotKolonka22, slotKolonka23, slotKolonka24, slotKolonka25, slotKolonka26, slotKolonka27, slotKolonka28, slotKolonka29, slotKolonka30, slotKolonka31, slotKolonka32, slotKolonka33, slotKolonka34, slotKolonka35, slotKolonka36, slotKolonka37, slotKolonka38, slotKolonka39, slotKolonka40, slotKolonka41, slotKolonka42, slotKolonka43;

    public bool skillotkriti;
    public GameObject skillson;

    public float timerpokaz;

    // Start is called before the first frame update
    void Start()
    {

        skillsBack.SetActive(false);
        descripGGPanel.SetActive(false);
        slotPriem.SetActive(false);
        slotMother.SetActive(false);
        megaecranformother.SetActive(false);
        descripGG.SetActive(false);
        skillsImitatorfordescrypt.SetActive(false);
        megaBlock.SetActive(false);
        phonDescr.SetActive(false);
        priceIcons.SetActive(false);
        genPlace1.SetActive(false);
        genPlace2.SetActive(false);
        genPlace3.SetActive(false);
        yesPlease.SetActive(false);
        Ikrun.SetActive(true);
        nazvanieSkilla.text = " ";
        skillPrice.text = " ";
        priceIkraSkill = 0f;
        // slotList = new List<GameObject>();
        moverCollider.SetActive(false);
        batolmoverCollider.SetActive(false);
        skillson.SetActive(false);
        vyhod.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        

        // включает кнопку навыков, если нет экрана настроек сейчас и экрана русалок
        if (distancePoints.distance <= 5100 || leveler.settingsMode.activeSelf == true || mermaids.garemBack.activeSelf == true)
        {
            skillButton.SetActive(false);
        }
        if (distancePoints.distance > 5100 && leveler.settingsMode.activeSelf == false && mermaids.garemBack.activeSelf == false)
        {
            skillButton.SetActive(true);
        }

        if (battleModeVisibility.skippingMode == true) // проверяет одноразовые навыки, если что прячет их
        {
            if(skillchitaka.skil22used)
            {
                skillchitaka.skBlok22.SetActive(true);
                skillchitaka.skil22.transform.position = skillchitaka.colonka22.transform.position;
                skillchitaka.skil22.transform.SetParent(skillchitaka.colonka22.transform);
            }
            if (skillchitaka.skil30used)
            {
                skillchitaka.skBlok30.SetActive(true);
                skillchitaka.skil30.transform.position = skillchitaka.colonka30.transform.position;
                skillchitaka.skil30.transform.SetParent(skillchitaka.colonka30.transform);
            }
            if (skillchitaka.skil32used)
            {
                skillchitaka.skBlok32.SetActive(true);
                skillchitaka.skil32.transform.position = skillchitaka.colonka32.transform.position;
                skillchitaka.skil32.transform.SetParent(skillchitaka.colonka32.transform);
            }
        }

    }

    public void tapSkillsOnlyOn()
    {
        // Открывает, если не бой (магазин)
        if (skillsBack.activeSelf == false && confirms.noteBack.activeSelf == false && confirms.confirmBack.activeSelf == false && confirms.presentBack.activeSelf == false && battleModeVisibility.battleMode == false)
        {
            skillchitaka.zvukbudet = true;
            music.opensound.Play();
            movement.SetActive(false);
            skillson.SetActive(false);
            skillotkriti = true;
            player.speed = 0f;
            descripGG.SetActive(true);
            skillchitaka.additionBackVraga.SetActive(true);
            skillchitaka.additionBack.SetActive(true);
            skillsImitatorfordescrypt.SetActive(true);
            skillsBack.SetActive(true);

            slotPriem.SetActive(true);
            megaBlock.SetActive(false);
            phonDescr.SetActive(false);
            priceIcons.SetActive(false);

            // тут сначала отключение всего, что было раньше
            yesPlease.SetActive(false);
            Ikrun.SetActive(true);
            skillPrice.text = " ";
            nazvanieSkilla.text = " ";
            priceIkraSkill = 0f;
            chekerbefore.skillSpesholInd.SetActive(true);
            // активирует колонку

            moverCollider.SetActive(true);
            // включает спецмассив, который формировался ниже
            foreach (GameObject tempObject in slotListdostupni)
            {
                tempObject.SetActive(true);
            }
          
            // mahination.odinrazok = false;
            slotMother.SetActive(true);
            megaecranformother.SetActive(true);
            vyhod.SetActive(true);
            //skillchitaka.SlotZapolnitel();
        }
        // Открывает, бой
        else if (batol.playingMode == false && skillsBack.activeSelf == false && confirms.noteBack.activeSelf == false && confirms.confirmBack.activeSelf == false && confirms.presentBack.activeSelf == false && battleModeVisibility.battleMode == true)
        {
            skillchitaka.zvukbudet = true;
            music.opensound.Play();
            movement.SetActive(false);
            skillson.SetActive(false);
            player.speed = 0f;
            descripGG.SetActive(true);
            skillchitaka.additionBackVraga.SetActive(true);
            skillchitaka.additionBack.SetActive(true);
            skillsImitatorfordescrypt.SetActive(true);
            skillsBack.SetActive(true);
            
            megaBlock.SetActive(false);
            phonDescr.SetActive(false);
            priceIcons.SetActive(false);
            skillPrice.text = " ";
            nazvanieSkilla.text = " ";
            priceIkraSkill = 0f;
            yesPlease.SetActive(false);
            chekerbefore.skillSpesholInd.SetActive(false);
            // ВКЛЮЧАЕТ КОЛОНКУ, но тут нужнен фильтр на доступные
            // отключает всех детей слотматери, все слоты

            moverCollider.SetActive(false);
            batolmoverCollider.SetActive(true);

            foreach (GameObject tempObject in slotList)
            {
                tempObject.SetActive(true);
            }
            // mahination.odinrazok = false;
            slotMother.SetActive(true);
            megaecranformother.SetActive(true);
            // тут слоты гг и врага
            vyhod.SetActive(true);
            slotPriem.SetActive(true);
            //skillchitaka.SlotZapolnitel();
        }
    }

    public void tapSkillsOnlyOff()
    {
        if (skillsBack.activeSelf == true && skillchitaka.mishenHolder.activeSelf == false && Input.touchCount < 2)
        {
            music.closesound.Play();
            timerpokaz = 19f;
            mermanReader.blokderzhalka.SetActive(false);
            batlplair.obnuliator();
            movement.SetActive(true);
            if (battleModeVisibility.battleMode == true)
            {
                skillson.SetActive(true);
            }
            skillchitaka.MishenOff();
            //skillchitaka.SlotZapolnitel();
            skillchitaka.movedSkill = null;
            descripGG.SetActive(false);
            skillsBack.SetActive(false);
            slotPriem.SetActive(false);
            
            megaecranformother.SetActive(false);
            slotMother.SetActive(false);
            skillsImitatorfordescrypt.SetActive(false);
            skillchitaka.additionBackVraga.SetActive(false);
            skillchitaka.additionBack.SetActive(false);
            megaBlock.SetActive(false);
            phonDescr.SetActive(false);
            priceIcons.SetActive(false);
            skillPrice.text = " ";
            nazvanieSkilla.text = " ";
            priceIkraSkill = 0f;
            yesPlease.SetActive(false);
            chekerbefore.skillSpesholInd.SetActive(false);
            moverCollider.SetActive(false);
            batolmoverCollider.SetActive(false);
            vyhod.SetActive(false);
            foreach (GameObject temporObject in slotListdostupni)
            {
                temporObject.SetActive(false);
            }
            foreach (GameObject podsvetka in vsepodsvetki) // отключение подсветок
            {
                podsvetka.SetActive(false);
            }
        }
    }

    // разные реакции на кнопку зависимо от того, бой сейчас или нет
    public void tapSkills()
    {
        // Открывает, если не бой (магазин)
        if (skillsBack.activeSelf == false && confirms.noteBack.activeSelf == false && confirms.confirmBack.activeSelf == false && confirms.presentBack.activeSelf == false && battleModeVisibility.battleMode == false)
        {
            skillchitaka.zvukbudet = true;
            music.opensound.Play();
            movement.SetActive(false);
            skillson.SetActive(false);
            skillotkriti = true;
            player.speed = 0f;
            descripGG.SetActive(true);
            skillchitaka.additionBackVraga.SetActive(true);
            skillchitaka.additionBack.SetActive(true);
            skillsImitatorfordescrypt.SetActive(true);
            skillsBack.SetActive(true);
            

            slotPriem.SetActive(true);
            megaBlock.SetActive(false);
            phonDescr.SetActive(false);
            priceIcons.SetActive(false);

            // тут сначала отключение всего, что было раньше
            yesPlease.SetActive(false);
            Ikrun.SetActive(true);
            skillPrice.text = " ";
            nazvanieSkilla.text = " ";
            priceIkraSkill = 0f;
            chekerbefore.skillSpesholInd.SetActive(true);
            // активирует колонку
            moverCollider.SetActive(true);
            // включает спецмассив, который формировался ниже
            foreach (GameObject tempObject in slotListdostupni)
            {
                tempObject.SetActive(true);
            }
            // mahination.odinrazok = false;
            slotMother.SetActive(true);
            megaecranformother.SetActive(true);
            // тут слоты гг + снизу табличка описания + слева листаемый перечень скиллов (изученные + неизученные)
            vyhod.SetActive(true);

            //skillchitaka.SlotZapolnitel();





        }
        // Открывает, бой
        else if (batol.playingMode == false && skillsBack.activeSelf == false && confirms.noteBack.activeSelf == false && confirms.confirmBack.activeSelf == false && confirms.presentBack.activeSelf == false && battleModeVisibility.battleMode == true)
        {
            skillchitaka.zvukbudet = true;
            music.opensound.Play();
            movement.SetActive(false);
            skillson.SetActive(false);
            player.speed = 0f;
            descripGG.SetActive(true);
            skillchitaka.additionBackVraga.SetActive(true);
            skillchitaka.additionBack.SetActive(true);
            skillsImitatorfordescrypt.SetActive(true);
            skillsBack.SetActive(true);
           
            megaBlock.SetActive(false);
            phonDescr.SetActive(false);
            priceIcons.SetActive(false);
            skillPrice.text = " ";
            nazvanieSkilla.text = " ";
            priceIkraSkill = 0f;
            yesPlease.SetActive(false);
            chekerbefore.skillSpesholInd.SetActive(false);
            // ВКЛЮЧАЕТ КОЛОНКУ, но тут нужнен фильтр на доступные
            // отключает всех детей слотматери, все слоты
            moverCollider.SetActive(false);
            batolmoverCollider.SetActive(true);
            // включает спецмассив, который формировался ниже

            foreach (GameObject tempObject in slotList)
            {
                tempObject.SetActive(true);
            }
            // mahination.odinrazok = false;
            slotMother.SetActive(true);
            megaecranformother.SetActive(true);
            // тут слоты гг и врага
            vyhod.SetActive(true);
            slotPriem.SetActive(true);

            //skillchitaka.SlotZapolnitel();
        }


        // Кнопка закрывает инвентарь
        else if (skillsBack.activeSelf == true && Input.touchCount < 2)
        {
            music.closesound.Play();
            // skillchitaka.SlotZapolnitel();
            timerpokaz = 19f;
            mermanReader.blokderzhalka.SetActive(false);
            batlplair.obnuliator();
            movement.SetActive(true);
            if (battleModeVisibility.battleMode == true)
            {
                skillson.SetActive(true);
            }
            skillchitaka.MishenOff();
           // skillchitaka.SlotZapolnitel();
            skillchitaka.movedSkill = null;
            descripGG.SetActive(false);
            skillsBack.SetActive(false);
            slotPriem.SetActive(false);
            
            megaecranformother.SetActive(false);
            slotMother.SetActive(false);
            skillsImitatorfordescrypt.SetActive(false);
            skillchitaka.additionBackVraga.SetActive(false);
            skillchitaka.additionBack.SetActive(false);
            megaBlock.SetActive(false);
            phonDescr.SetActive(false);
            priceIcons.SetActive(false);
            skillPrice.text = " ";
            nazvanieSkilla.text = " ";
            priceIkraSkill = 0f;
            yesPlease.SetActive(false);
            chekerbefore.skillSpesholInd.SetActive(false);
            moverCollider.SetActive(false);
            batolmoverCollider.SetActive(false);
            vyhod.SetActive(false);
            foreach (GameObject temporObject in slotListdostupni)
            {
                temporObject.SetActive(false);
            }
            foreach (GameObject podsvetka in vsepodsvetki)
            {
                podsvetka.SetActive(false);
            }
        }
    }


    public void tapDecription()
    {
        if (descripGGPanel.activeSelf == false)
        {
            skillsImitatorfordescrypt.SetActive(false);
            if (leveler.languager == 0)
            {
                description1Text.text = "Lowers enemy brain cell activity";
                description2Text.text = "Increases brain cell activity";
                description3Text.text = "Clouds the mind while not extinguished";
                description4Text.text = "Maintains mental clarity while not extinguished";
                description5Text.text = "The cell generates long-lasting impulse";
                description6Text.text = "the cell is activated and damaged when excited";
                description7Text.text = "Impulse reach multiple targets";
            }
            if (leveler.languager == 1)
            {
                description1Text.text = "Понижает мозговую активность врага";
                description2Text.text = "Повышает активность клеток мозга";
                description3Text.text = "Затуманивает разум, пока эта клетка не погасла";
                description4Text.text = "Поддерживает ясность ума, пока эта клетка не погасла";
                description5Text.text = "Клетка образует длительный импульс";
                description6Text.text = "Клетка активируется и отмирает, получая импульс";
                description7Text.text = "Импульс достигает нескольких целей";
            }
            else if (leveler.languager == 2)
            {
                description1Text.text = "Знижує мозкову активність ворога";
                description2Text.text = "Підвищує активність клітин мозку";
                description3Text.text = "Затуманює розум, поки ця клітина не згасла";
                description4Text.text = "Підтримує ясність розуму, поки ця клітина не згасла";
                description5Text.text = "Клітина утворює довготривалий імпульс";
                description6Text.text = "Клітина активується та відмирає при подразненні";
                description7Text.text = "Імпульс досягає кількох цілей";
            }


            descripGGPanel.SetActive(true);

        }
        else if(descripGGPanel.activeSelf == true)
        {
            descripGGPanel.SetActive(false);
            skillsImitatorfordescrypt.SetActive(true);
        }
    }

    public void megaBlockTouch()
    {
        // + находит и уничтожает все гены
        foreach (Transform child in genPlace1.transform)
        {
            Destroy(child.gameObject);
        }
        foreach (Transform child in genPlace2.transform)
        {
            Destroy(child.gameObject);
        }
        foreach (Transform child in genPlace3.transform)
        {
            Destroy(child.gameObject);
        }
        nazvanieSkilla.text = " "; // имя
        priceIkraSkill = 0f; // устанавливает цену
        skillPrice.text = " "; // показывает цену
        yesPlease.SetActive(false);
        // проводит фазу ендед
        skillchitaka.podsvetTrigger1.SetActive(false);
        skillchitaka.podsvetTrigger2.SetActive(false);
        skillchitaka.podsvetTrigger3.SetActive(false);
        skillchitaka.podsvetTrigger4.SetActive(false);
        skillchitaka.podsvetTrigger5.SetActive(false);
        skillchitaka.podsvetTrigger6.SetActive(false);
        skillchitaka.podsvetTrigger7.SetActive(false);
        skillchitaka.podsvetTrigger8.SetActive(false);
        skillchitaka.podsvetTrigger9.SetActive(false);
        skillchitaka.podsvetTrigger1Connected.SetActive(false);
        skillchitaka.podsvetTrigger2Connected.SetActive(false);
        skillchitaka.podsvetTrigger3Connected.SetActive(false);
        skillchitaka.podsvetTrigger4Connected.SetActive(false);
        skillchitaka.podsvetTrigger5Connected.SetActive(false);
        skillchitaka.podsvetTrigger6Connected.SetActive(false);
        skillchitaka.podsvetTrigger7Connected.SetActive(false);
        skillchitaka.podsvetTrigger8Connected.SetActive(false);
        skillchitaka.podsvetTrigger9Connected.SetActive(false);
        skillchitaka.slot1falsMish.SetActive(false);
        skillchitaka.slot2falsMish.SetActive(false);
        skillchitaka.slot3falsMish.SetActive(false);
        skillchitaka.slot4falsMish.SetActive(false);
        skillchitaka.slot5falsMish.SetActive(false);
        skillchitaka.slot6falsMish.SetActive(false);
        skillchitaka.slot7falsMish.SetActive(false);
        skillchitaka.slot8falsMish.SetActive(false);
        skillchitaka.slot9falsMish.SetActive(false);
        skillchitaka.slot1falsMishVraga.SetActive(false);
        skillchitaka.slot2falsMishVraga.SetActive(false);
        skillchitaka.slot3falsMishVraga.SetActive(false);
        skillchitaka.slot4falsMishVraga.SetActive(false);
        skillchitaka.slot5falsMishVraga.SetActive(false);
        skillchitaka.slot6falsMishVraga.SetActive(false);
        skillchitaka.slot7falsMishVraga.SetActive(false);
        skillchitaka.slot8falsMishVraga.SetActive(false);
        skillchitaka.slot9falsMishVraga.SetActive(false);
        phonDescr.SetActive(false);
        priceIcons.SetActive(false);
        megaBlock.SetActive(false);

    }

    public void tapSoSlota1()
    {
        if(slotmerman.slo1.transform.childCount == 0)
        {
            tapSkills();
        }
        else
        {
            tapSkillsOnlyOn();
        }
    }

    public void tapSoSlota2()
    {
        if (slotmerman.slo2.transform.childCount == 0)
        {
            tapSkills();
        }
        else
        {
            tapSkillsOnlyOn();
        }
    }

    public void tapSoSlota3()
    {
        if (slotmerman.slo3.transform.childCount == 0)
        {
            tapSkills();
        }
        else
        {
            tapSkillsOnlyOn();
        }
    }

    public void tapSoSlota4()
    {
        if (slotmerman.slo4.transform.childCount == 0)
        {
            tapSkills();
        }
        else
        {
            tapSkillsOnlyOn();
        }
    }

    public void tapSoSlota5()
    {
        if (slotmerman.slo5.transform.childCount == 0)
        {
            tapSkills();
        }
        else
        {
            tapSkillsOnlyOn();
        }
    }

    public void tapSoSlota6()
    {
        if (slotmerman.slo6.transform.childCount == 0)
        {
            tapSkills();
        }
        else
        {
            tapSkillsOnlyOn();
        }
    }

    public void tapSoSlota7()
    {
        if (slotmerman.slo7.transform.childCount == 0)
        {
            tapSkills();
        }
        else
        {
            tapSkillsOnlyOn();
        }
    }

    public void tapSoSlota8()
    {
        if (slotmerman.slo8.transform.childCount == 0)
        {
            tapSkills();
        }
        else
        {
            tapSkillsOnlyOn();
        }
    }

    public void tapSoSlota9()
    {
        if (slotmerman.slo9.transform.childCount == 0)
        {
            tapSkills();
        }
        else
        {
            tapSkillsOnlyOn();
        }
    }

    public void yesPleaseTouch()
    {
        switch (Random.Range(0, 4))
        {
            case 1:
                bought3.Play(0);
                break;
            case 2:

                bought2.Play(0);
                break;
            default:
                bought.Play(0);

                break;
        }


        // + находит и уничтожает все гены
        foreach (Transform child in genPlace1.transform)
        {
            Destroy(child.gameObject);
        }
        foreach (Transform child in genPlace2.transform)
        {
            Destroy(child.gameObject);
        }
        foreach (Transform child in genPlace3.transform)
        {
            Destroy(child.gameObject);
        }
        // снимает блок с купленного гена
        if (skillchitaka.movedSkill == skillchitaka.skil1)
        {
            skillchitaka.skBlok1.SetActive(false);
            slotList.Add(slotKolonka1);
        }
        else if (skillchitaka.movedSkill == skillchitaka.skil2)
        {
            skillchitaka.skBlok2.SetActive(false);
            slotList.Add(slotKolonka2);
        }
        else if (skillchitaka.movedSkill == skillchitaka.skil3)
        {
            skillchitaka.skBlok3.SetActive(false);
            slotList.Add(slotKolonka3);
        }
        else if (skillchitaka.movedSkill == skillchitaka.skil4)
        {
            skillchitaka.skBlok4.SetActive(false);
            slotList.Add(slotKolonka4);
        }
        else if (skillchitaka.movedSkill == skillchitaka.skil5)
        {
            skillchitaka.skBlok5.SetActive(false);
            slotList.Add(slotKolonka9);
        }
        else if (skillchitaka.movedSkill == skillchitaka.skil6)
        {
            skillchitaka.skBlok6.SetActive(false);
            slotList.Add(slotKolonka6);
        }
        else if (skillchitaka.movedSkill == skillchitaka.skil8)
        {
            skillchitaka.skBlok8.SetActive(false);
            slotList.Add(slotKolonka8);
        }
        else if (skillchitaka.movedSkill == skillchitaka.skil9)
        {
            skillchitaka.skBlok9.SetActive(false);
            slotList.Add(slotKolonka5);
        }
        else if (skillchitaka.skil10 != null && skillchitaka.movedSkill == skillchitaka.skil10)
        {
            skillchitaka.skBlok10.SetActive(false);
            slotList.Add(slotKolonka10);
        }
        else if (skillchitaka.skil11 != null && skillchitaka.movedSkill == skillchitaka.skil11)
        {
            skillchitaka.skBlok11.SetActive(false);
            slotList.Add(slotKolonka11);
        }
        else if (skillchitaka.skil12 != null && skillchitaka.movedSkill == skillchitaka.skil12)
        {
            skillchitaka.skBlok12.SetActive(false);
            slotList.Add(slotKolonka12);
        }
        else if (skillchitaka.skil13 != null && skillchitaka.movedSkill == skillchitaka.skil13)
        {
            skillchitaka.skBlok13.SetActive(false);
            slotList.Add(slotKolonka13);
        }
        else if (skillchitaka.skil14 != null && skillchitaka.movedSkill == skillchitaka.skil14)
        {
            skillchitaka.skBlok14.SetActive(false);
            slotList.Add(slotKolonka14);
        }
        else if (skillchitaka.skil15 != null && skillchitaka.movedSkill == skillchitaka.skil15)
        {
            skillchitaka.skBlok15.SetActive(false);
            slotList.Add(slotKolonka15);
        }
        else if (skillchitaka.skil16 != null && skillchitaka.movedSkill == skillchitaka.skil16)
        {
            skillchitaka.skBlok16.SetActive(false);
            slotList.Add(slotKolonka16);
        }
        else if (skillchitaka.skil17 != null && skillchitaka.movedSkill == skillchitaka.skil17)
        {
            skillchitaka.skBlok17.SetActive(false);
            slotList.Add(slotKolonka17);
        }
        else if (skillchitaka.skil18 != null && skillchitaka.movedSkill == skillchitaka.skil18)
        {
            skillchitaka.skBlok18.SetActive(false);
            slotList.Add(slotKolonka18);
        }
        else if (skillchitaka.skil19 != null && skillchitaka.movedSkill == skillchitaka.skil19)
        {
            skillchitaka.skBlok19.SetActive(false);
            slotList.Add(slotKolonka19);
        }
        else if (skillchitaka.skil20 != null && skillchitaka.movedSkill == skillchitaka.skil20)
        {
            skillchitaka.skBlok20.SetActive(false);
            slotList.Add(slotKolonka20);
        }
        else if (skillchitaka.skil21 != null && skillchitaka.movedSkill == skillchitaka.skil21)
        {
            skillchitaka.skBlok21.SetActive(false);
            slotList.Add(slotKolonka21);
        }
        else if (skillchitaka.skil22 != null && skillchitaka.movedSkill == skillchitaka.skil22)
        {
            skillchitaka.skBlok22.SetActive(false);
            slotList.Add(slotKolonka22);
            skillchitaka.skil22used = false; // одноразовый навык
        }
        else if (skillchitaka.skil23 != null && skillchitaka.movedSkill == skillchitaka.skil23)
        {
            skillchitaka.skBlok23.SetActive(false);
            slotList.Add(slotKolonka23);
        }
        else if (skillchitaka.skil24 != null && skillchitaka.movedSkill == skillchitaka.skil24)
        {
            skillchitaka.skBlok24.SetActive(false);
            slotList.Add(slotKolonka24);
        }
        else if (skillchitaka.skil25 != null && skillchitaka.movedSkill == skillchitaka.skil25)
        {
            skillchitaka.skBlok25.SetActive(false);
            slotList.Add(slotKolonka25);
        }
        else if (skillchitaka.skil26 != null && skillchitaka.movedSkill == skillchitaka.skil26)
        {
            skillchitaka.skBlok26.SetActive(false);
            slotList.Add(slotKolonka26);
        }
        else if (skillchitaka.skil27 != null && skillchitaka.movedSkill == skillchitaka.skil27)
        {
            skillchitaka.skBlok27.SetActive(false);
            slotList.Add(slotKolonka27);
        }
        else if (skillchitaka.skil28 != null && skillchitaka.movedSkill == skillchitaka.skil28)
        {
            skillchitaka.skBlok28.SetActive(false);
            slotList.Add(slotKolonka28);
        }
        else if (skillchitaka.skil29 != null && skillchitaka.movedSkill == skillchitaka.skil29)
        {
            skillchitaka.skBlok29.SetActive(false);
            slotList.Add(slotKolonka29);
        }
        else if (skillchitaka.skil30 != null && skillchitaka.movedSkill == skillchitaka.skil30)
        {
            skillchitaka.skBlok30.SetActive(false);
            slotList.Add(slotKolonka30);
            skillchitaka.skil30used = false;
        }
        else if (skillchitaka.skil31 != null && skillchitaka.movedSkill == skillchitaka.skil31)
        {
            skillchitaka.skBlok31.SetActive(false);
            slotList.Add(slotKolonka31);
        }
        else if (skillchitaka.skil32 != null && skillchitaka.movedSkill == skillchitaka.skil32)
        {
            skillchitaka.skBlok32.SetActive(false);
            slotList.Add(slotKolonka32);
            skillchitaka.skil32used = false;
        }
        else if (skillchitaka.skil33 != null && skillchitaka.movedSkill == skillchitaka.skil33)
        {
            skillchitaka.skBlok33.SetActive(false);
            slotList.Add(slotKolonka33);
        }
        else if (skillchitaka.skil34 != null && skillchitaka.movedSkill == skillchitaka.skil34)
        {
            skillchitaka.skBlok34.SetActive(false);
            slotList.Add(slotKolonka34);
        }
        else if (skillchitaka.skil35 != null && skillchitaka.movedSkill == skillchitaka.skil35)
        {
            skillchitaka.skBlok35.SetActive(false);
            slotList.Add(slotKolonka35);
        }
        else if (skillchitaka.skil36 != null && skillchitaka.movedSkill == skillchitaka.skil36)
        {
            skillchitaka.skBlok36.SetActive(false);
            slotList.Add(slotKolonka36);
        }
        else if (skillchitaka.skil37 != null && skillchitaka.movedSkill == skillchitaka.skil37)
        {
            skillchitaka.skBlok37.SetActive(false);
            slotList.Add(slotKolonka37);
        }
        else if (skillchitaka.skil38 != null && skillchitaka.movedSkill == skillchitaka.skil38)
        {
            skillchitaka.skBlok38.SetActive(false);
            slotList.Add(slotKolonka38);
        }
        else if (skillchitaka.skil39 != null && skillchitaka.movedSkill == skillchitaka.skil39)
        {
            skillchitaka.skBlok39.SetActive(false);
            slotList.Add(slotKolonka39);
        }
        else if (skillchitaka.skil40 != null && skillchitaka.movedSkill == skillchitaka.skil40)
        {
            skillchitaka.skBlok40.SetActive(false);
            slotList.Add(slotKolonka40);
        }
        else if (skillchitaka.skil41 != null && skillchitaka.movedSkill == skillchitaka.skil41)
        {
            skillchitaka.skBlok41.SetActive(false);
            slotList.Add(slotKolonka41);
        }
        else if (skillchitaka.skil42 != null && skillchitaka.movedSkill == skillchitaka.skil42)
        {
            skillchitaka.skBlok42.SetActive(false);
            slotList.Add(slotKolonka42);
        }
        else if (skillchitaka.skil43 != null && skillchitaka.movedSkill == skillchitaka.skil43)
        {
            skillchitaka.skBlok43.SetActive(false);
            slotList.Add(slotKolonka43);
        }

        // отнимает икру
        ikorka.ikra -= priceIkraSkill;
        nazvanieSkilla.text = " "; // имя
        priceIkraSkill = 0f; // устанавливает цену
        skillPrice.text = " "; // показывает цену
        // проводит фазу ендед
        skillchitaka.podsvetTrigger1.SetActive(false);
        skillchitaka.podsvetTrigger2.SetActive(false);
        skillchitaka.podsvetTrigger3.SetActive(false);
        skillchitaka.podsvetTrigger4.SetActive(false);
        skillchitaka.podsvetTrigger5.SetActive(false);
        skillchitaka.podsvetTrigger6.SetActive(false);
        skillchitaka.podsvetTrigger7.SetActive(false);
        skillchitaka.podsvetTrigger8.SetActive(false);
        skillchitaka.podsvetTrigger9.SetActive(false);
        skillchitaka.podsvetTrigger1Connected.SetActive(false);
        skillchitaka.podsvetTrigger2Connected.SetActive(false);
        skillchitaka.podsvetTrigger3Connected.SetActive(false);
        skillchitaka.podsvetTrigger4Connected.SetActive(false);
        skillchitaka.podsvetTrigger5Connected.SetActive(false);
        skillchitaka.podsvetTrigger6Connected.SetActive(false);
        skillchitaka.podsvetTrigger7Connected.SetActive(false);
        skillchitaka.podsvetTrigger8Connected.SetActive(false);
        skillchitaka.podsvetTrigger9Connected.SetActive(false);
        skillchitaka.slot1falsMish.SetActive(false);
        skillchitaka.slot2falsMish.SetActive(false);
        skillchitaka.slot3falsMish.SetActive(false);
        skillchitaka.slot4falsMish.SetActive(false);
        skillchitaka.slot5falsMish.SetActive(false);
        skillchitaka.slot6falsMish.SetActive(false);
        skillchitaka.slot7falsMish.SetActive(false);
        skillchitaka.slot8falsMish.SetActive(false);
        skillchitaka.slot9falsMish.SetActive(false);
        skillchitaka.slot1falsMishVraga.SetActive(false);
        skillchitaka.slot2falsMishVraga.SetActive(false);
        skillchitaka.slot3falsMishVraga.SetActive(false);
        skillchitaka.slot4falsMishVraga.SetActive(false);
        skillchitaka.slot5falsMishVraga.SetActive(false);
        skillchitaka.slot6falsMishVraga.SetActive(false);
        skillchitaka.slot7falsMishVraga.SetActive(false);
        skillchitaka.slot8falsMishVraga.SetActive(false);
        skillchitaka.slot9falsMishVraga.SetActive(false);
        phonDescr.SetActive(false);
        priceIcons.SetActive(false);
        megaBlock.SetActive(false);
        yesPlease.SetActive(false);
    }
}
