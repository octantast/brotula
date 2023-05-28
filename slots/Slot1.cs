using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot1 : MonoBehaviour
{
    public DistanceToCheckpoint distancePoints;
    public SkillsController skills;
    public BattleScreen battleModeVisibility;
    public PlayerController player;
    public battleplayer battlePlay;
    public skillsreader skillet;
    public Levels leveler;

    public GameObject ggslotus;

    [SerializeField]
    public GameObject slot1;
    public GameObject slot2;
    public GameObject slot3;
    public GameObject slot4;
    public GameObject slot5;
    public GameObject slot6;
    public GameObject slot7;
    public GameObject slot8;
    public GameObject slot9;
    public GameObject slot1trigger;
    public GameObject slot2trigger;
    public GameObject slot3trigger;
    public GameObject slot4trigger;
    public GameObject slot5trigger;
    public GameObject slot6trigger;
    public GameObject slot7trigger;
    public GameObject slot8trigger;
    public GameObject slot9trigger;
    public GameObject slotBlokers;
    public GameObject slot1blocked;
    public GameObject slot2blocked;
    public GameObject slot3blocked;
    public GameObject slot4blocked;
    public GameObject slot5blocked;
    public GameObject slot6blocked;
    public GameObject slot7blocked;
    public GameObject slot8blocked;
    public GameObject slot9blocked;
    public float slot1Hp;
    public float slot2Hp;
    public float slot3Hp;
    public float slot4Hp;
    public float slot5Hp;
    public float slot6Hp;
    public float slot7Hp;
    public float slot8Hp;
    public float slot9Hp;


    public float blockpossibilitygg;
    public float blockpossibilitygg7;
    public float blockpossibilitygg6;
    public float blockpossibilitygg8;
    public float blockpossibilitygg9;
    public float blockpossibilitygg4;

    private bool oncedoit;

    void Start()
    {

        blockpossibilitygg = 2;
        blockpossibilitygg7 = 2;
        blockpossibilitygg6 = 2;
        blockpossibilitygg8 = 2;
        blockpossibilitygg9 = 2;
        blockpossibilitygg4 = 2;
        slotBlokers.SetActive(false);

        // слоты выключены, не заблочены, 0 хп
        slot1.SetActive(false);
        slot1blocked.SetActive(false);
        slot1Hp = 0f;
        slot2.SetActive(false);
        slot2blocked.SetActive(false);
        slot2Hp = 0f;
        slot3.SetActive(false);
        slot3blocked.SetActive(false);
        slot3Hp = 0f;
        slot4.SetActive(false);
        slot4blocked.SetActive(false);
        slot4Hp = 0f;
        slot5.SetActive(false);
        slot5blocked.SetActive(false);
        slot5Hp = 0f;
        slot6.SetActive(false);
        slot6blocked.SetActive(false);
        slot6Hp = 0f;
        slot7.SetActive(false);
        slot7blocked.SetActive(false);
        slot7Hp = 0f;
        slot8.SetActive(false);
        slot8blocked.SetActive(false);
        slot8Hp = 0f;
        slot9.SetActive(false);
        slot9blocked.SetActive(false);
        slot9Hp = 0f;
    }

    void Update()
    {
        // Слоты активируются, когда магазин, блокеры тоже
        if (skills.skillsBack.activeSelf == true)
        {
            slot1.SetActive(true);
            slot2.SetActive(true);
            slot3.SetActive(true);
            slot4.SetActive(true);
            slot5.SetActive(true);
            slot6.SetActive(true);
            slot7.SetActive(true);
            slot8.SetActive(true);
            slot9.SetActive(true);
            slotBlokers.SetActive(true);
        }

        // Слоты активируются, когда боевые позиции
        // выезжают
        else if (battleModeVisibility.battleMode == true && player.transform.position.x < 52)
        {
            slot1.SetActive(true);
            slot2.SetActive(true);
            slot3.SetActive(true);
            slot4.SetActive(true);
            slot5.SetActive(true);
            slot6.SetActive(true);
            slot7.SetActive(true);
            slot8.SetActive(true);
            slot9.SetActive(true);
            slotBlokers.SetActive(true);
            skills.slotPriem.SetActive(true);

            if (oncedoit == false)
            {
                if (player.howmanyinteractions > 0 || leveler.level != 0 || (leveler.level == 0 && leveler.expe > 0))
                {
                    skills.tapSkillsOnlyOn();
                }
                // Invoke("Launchskillecran", 0.7f);
                oncedoit = true;
            }



        }
        else
        {
            slot1.SetActive(false);
            slot2.SetActive(false);
            slot3.SetActive(false);
            slot4.SetActive(false);
            slot5.SetActive(false);
            slot6.SetActive(false);
            slot7.SetActive(false);
            slot8.SetActive(false);
            slot9.SetActive(false);
            slotBlokers.SetActive(false);
            skills.slotPriem.SetActive(false);
            oncedoit = false;
        }

        // мониторинг блоков слотов зависимо от дистанции и вспомогательных генов + отключение триггеров
        if (distancePoints.distance >= 5600 && blockpossibilitygg9 > 1)
        {
            slot9blocked.SetActive(true);
            slot9trigger.SetActive(false);
            // очищение мишеней и номера
            skillet.slot9skill = 0;
            skillet.slot9target1 = null;
            skillet.slot9target2 = null;
            skillet.slot9target3 = null;

        }
        if (distancePoints.distance >= 6000 && blockpossibilitygg8 > 1)
        {
            slot8blocked.SetActive(true);
            slot8trigger.SetActive(false);
            skillet.slot8skill = 0;
            skillet.slot8target1 = null;
            skillet.slot8target2 = null;
            skillet.slot8target3 = null;
        }
        if (distancePoints.distance >= 6300 && blockpossibilitygg7 > 1)
        {
            slot7blocked.SetActive(true);
            slot7trigger.SetActive(false);
            skillet.slot7skill = 0;
            skillet.slot7target1 = null;
            skillet.slot7target2 = null;
            skillet.slot7target3 = null;
        }
        if (distancePoints.distance >= 6650 && blockpossibilitygg6 > 1)
        {
            slot6blocked.SetActive(true);
            slot6trigger.SetActive(false);
            skillet.slot6skill = 0;
            skillet.slot6target1 = null;
            skillet.slot6target2 = null;
            skillet.slot6target3 = null;
        }
        if (distancePoints.distance >= 6800 && blockpossibilitygg > 1)
        {
            slot5blocked.SetActive(true);
            slot5trigger.SetActive(false);
            skillet.slot5skill = 0;
            skillet.slot5target1 = null;
            skillet.slot5target2 = null;
            skillet.slot5target3 = null;
        }
        if (distancePoints.distance >= 7000 && blockpossibilitygg4 > 1)
        {
            slot4blocked.SetActive(true);
            slot4trigger.SetActive(false);
            skillet.slot4skill = 0;
            skillet.slot4target1 = null;
            skillet.slot4target2 = null;
            skillet.slot4target3 = null;
        }

        if (distancePoints.distance >= 6300 && blockpossibilitygg9 > 0)
        {
            slot9blocked.SetActive(true);
            slot9trigger.SetActive(false);
            skillet.slot9skill = 0;
            skillet.slot9target1 = null;
            skillet.slot9target2 = null;
            skillet.slot9target3 = null;
        }
        if (distancePoints.distance >= 8000 && blockpossibilitygg8 > 0)
        {
            slot8blocked.SetActive(true);
            slot8trigger.SetActive(false);
            skillet.slot8skill = 0;
            skillet.slot8target1 = null;
            skillet.slot8target2 = null;
            skillet.slot8target3 = null;
        }
        if (distancePoints.distance >= 8470 && blockpossibilitygg7 > 0)
        {
            slot7blocked.SetActive(true);
            slot7trigger.SetActive(false);
            skillet.slot7skill = 0;
            skillet.slot7target1 = null;
            skillet.slot7target2 = null;
            skillet.slot7target3 = null;
        }
        if (distancePoints.distance >= 9000 && blockpossibilitygg6 > 0)
        {
            slot6blocked.SetActive(true);
            slot6trigger.SetActive(false);
            skillet.slot6skill = 0;
            skillet.slot6target1 = null;
            skillet.slot6target2 = null;
            skillet.slot6target3 = null;
        }
        if (distancePoints.distance >= 9500 && blockpossibilitygg > 0)
        {
            slot5blocked.SetActive(true);
            slot5trigger.SetActive(false);
            skillet.slot5skill = 0;
            skillet.slot5target1 = null;
            skillet.slot5target2 = null;
            skillet.slot5target3 = null;
        }
        if (distancePoints.distance >= 10000 && blockpossibilitygg4 > 0)
        {
            slot4blocked.SetActive(true);
            slot4trigger.SetActive(false);
            skillet.slot4skill = 0;
            skillet.slot4target1 = null;
            skillet.slot4target2 = null;
            skillet.slot4target3 = null;
        }

        // Слоту присваивается 1хп до запуска боя. Блок стоит в случае плохой приспособленности к среде, тогда слот нельзя редактировать, у него 0 хп.
    }

    public void Launchskillecran()
    {
        skills.tapSkillsOnlyOn();
        CancelInvoke("Launchskillecran");
    }
}
