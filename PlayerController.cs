using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using Cinemachine;

public class PlayerController : MonoBehaviour
{
    
    public music music;
    public EnemySpawnerB1 enemyspawner;
    public mermenreader mermreader;
    public ConfirmScreen podtverjdenie;
    public battleplayer battleModePlay;
    public Levels progress;
    public BattleScreen battleModeVisibility;
    public IkraIndicator ikorka;
    public GenController gens;
    public DistanceToCheckpoint distancePoints;
    public battlefinal final;
    public MermaidController mermaids;
    public SkillsController skills;
    public gganimation animate;

    public AudioSource deathreal;
    public AudioSource deathreal2;
    public AudioSource deathelectro;
    //public AudioSource deathelectrovspysh;

    public GameObject skipneud;
    public GameObject movingbutton;
    public GameObject obuchalka;
    public float speed;
    public float normalSpeed;
    private float moveInput;
    private Rigidbody2D rb;
    private Rigidbody2D rbtruesprite;
    public Vector2 startTouchPosition, endTouchPosition;
    private float skipProbability;
    public float skipCheck;
    public bool difference = false;
    public bool anotherdifference = false;
    private float gigaSize;
    public GameObject trueSprite;
    public bool nagradoid;
    public GameObject podtverjdBoi;
    public GameObject podtverjdSkip;

    private bool swipubyt;
    public GameObject startscreen;
    public CinemachineVirtualCamera biom1;
    public CinemachineVirtualCamera biom2;
    public CinemachineVirtualCamera biom3;
    public CinemachineVirtualCamera biom4;
    public CinemachineVirtualCamera biom5;

    public List<GameObject> partsbody; // части тела
    public GameObject otherholder;
    public GameObject fador;
    public GameObject ded;
    public GameObject ded2;

    public GameObject fisher;
    public GameObject currentMerman;
    public float howmanyinteractions;

    private void Start()
    {
        transform.localPosition = new Vector3(54.687f, transform.localPosition.y, -788.1f);
        skipCheck = 70;
        speed = 0f;
        normalSpeed = 7f;
        podtverjdBoi.SetActive(false);
        podtverjdSkip.SetActive(false);
    }

    public void OnUpButtonDown()
    {
        if (speed >= 0F && battleModeVisibility.battleMode == false)
        {
            speed = -normalSpeed;
            animate.booldvizh = true;
        }
    }

    public void OnButtonTop()
    {
        speed = 0f;
    }

    public void Update()
    {
        // это касается всего плеера
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, transform.position.y + speed, transform.position.z), -speed * Time.deltaTime);
        // trueSprite.transform.position = Vector3.MoveTowards(trueSprite.transform.position, new Vector3(trueSprite.transform.position.x, trueSprite.transform.position.y + speed, trueSprite.transform.position.z), 0.1f);

        // равняет гг, если он не в бою, и не скиппинг мод
        if (distancePoints.distance > 5050 && transform.position.x > 54.7 && battleModeVisibility.skippingMode == false && battleModeVisibility.battleMode == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x - 5, transform.position.y, transform.position.z), 5f * Time.deltaTime);
            //transform.position = new Vector3(Mathf.Lerp(transform.position.x, transform.position.x - 5, 1 * Time.deltaTime), transform.position.y, transform.position.z);
        }


        // меняет размер зависимо от гигантизма до заплыва
        if (distancePoints.distance <= 5050)
        {
            if (gens.pGigantizm == 0)
            {
                gigaSize = 1f;
            }
            else if (gens.pGigantizm == 1)
            {
                gigaSize = 1.1f;
            }
            else if (gens.pGigantizm == 2)
            {
                gigaSize = 1.2f;
            }
            else if (gens.pGigantizm == 3)
            {
                gigaSize = 1.3f;
            }
            trueSprite.transform.localScale = new Vector3 (gigaSize, gigaSize, 1f);
        }

        
        // Подтверждение пропуска
        if (podtverjdenie.confirmBack.activeSelf == true && anotherdifference == true)
        {
            if (podtverjdenie.podtverjdenoTapom == true)
            {
                anotherdifference = false;
                podtverjdenie.confirmBack.SetActive(false);
                if (enemyspawner.fishbiom) // при рыбе не убежишь
                {
                    skipProbability = 0;
                }
                else
                {
                    skipProbability = Random.Range(1, 100);
                }
                // удачный побег
                if (skipProbability > skipCheck)
                {
                    // если электрорецепторы и они ещё не играли роли, то награда
                    if ((gens.pElectroreceptor == 1 && gens.pSliz > 2) || (gens.pElectroreceptor == 2 && gens.pSliz > 1) || (gens.pElectroreceptor == 3 && gens.pSliz > 0))
                    {
                        if (nagradoid == false)
                        {
                            nagradoid = true;
                            // зовём окно награды
                            mermaids.mermaidButtonDescription.SetActive(true);
                            mermaids.mermaidButtonImitator.SetActive(true);
                            if (progress.languager == 0)
                            {
                                podtverjdenie.presentText.text = "New companion joins...";
                            }
                            if (progress.languager == 1)
                            {
                                podtverjdenie.presentText.text = "Кто-то увязался следом...";
                            }
                            else if (progress.languager == 2)
                            {
                                podtverjdenie.presentText.text = "Когось можна привабити...";
                            }
                            if (progress.languager == 0)
                            {
                                podtverjdenie.presentText3.text = "Choose";
                            }
                            if (progress.languager == 1)
                            {
                                podtverjdenie.presentText3.text = "Пора выбирать";
                            }
                            else if (progress.languager == 2)
                            {
                                podtverjdenie.presentText3.text = "Час обирати";
                            }
                            final.nagradataker = true;
                            podtverjdenie.podtverjdenoTapom = false;
                            podtverjdenie.presentBack.SetActive(true);
                            battleModeVisibility.randomIkornyy = 1;
                            final.presentIkra.SetActive(true);
                            final.bonusikraText.text = battleModeVisibility.randomIkornyy.ToString("F0");
                            // спавн значка русалки зависимо от её вида
                            if (battleModeVisibility.mermaidPlace1 == 2 || battleModeVisibility.mermaidPlace1 == 4 || battleModeVisibility.mermaidPlace1 == 5 || battleModeVisibility.mermaidPlace1 == 6 || battleModeVisibility.mermaidPlace1 == 11 || battleModeVisibility.mermaidPlace1 == 16 || battleModeVisibility.mermaidPlace1 == 20 || battleModeVisibility.mermaidPlace1 == 25 || battleModeVisibility.mermaidPlace1 == 27 || battleModeVisibility.mermaidPlace1 == 31 || battleModeVisibility.mermaidPlace1 == 32 || battleModeVisibility.mermaidPlace1 == 33 || battleModeVisibility.mermaidPlace1 == 35) // рыбы
                            {
                                Instantiate(final.presentryba, final.place1.transform.position, Quaternion.identity, final.place1.transform);
                            }
                            else if (battleModeVisibility.mermaidPlace1 == 1 || battleModeVisibility.mermaidPlace1 == 9 || battleModeVisibility.mermaidPlace1 == 37 || battleModeVisibility.mermaidPlace1 == 42 || battleModeVisibility.mermaidPlace1 == 44 || battleModeVisibility.mermaidPlace1 == 47)
                            {
                                Instantiate(final.presentrak, final.place1.transform.position, Quaternion.identity, final.place1.transform);
                            }
                            else if (battleModeVisibility.mermaidPlace1 == 3 || battleModeVisibility.mermaidPlace1 == 15 || battleModeVisibility.mermaidPlace1 == 19 || battleModeVisibility.mermaidPlace1 == 23 || battleModeVisibility.mermaidPlace1 == 38)
                            {
                                Instantiate(final.presentmolusk, final.place1.transform.position, Quaternion.identity, final.place1.transform);
                            }
                            else if (battleModeVisibility.mermaidPlace1 == 7 || battleModeVisibility.mermaidPlace1 == 14 || battleModeVisibility.mermaidPlace1 == 24 || battleModeVisibility.mermaidPlace1 == 41 || battleModeVisibility.mermaidPlace1 == 46)
                            {
                                Instantiate(final.presentcherv, final.place1.transform.position, Quaternion.identity, final.place1.transform);
                            }
                            else if (battleModeVisibility.mermaidPlace1 == 8 || battleModeVisibility.mermaidPlace1 == 21 || battleModeVisibility.mermaidPlace1 == 10)
                            {
                                Instantiate(final.presentzvezdi, final.place1.transform.position, Quaternion.identity, final.place1.transform);
                            }
                            else if (battleModeVisibility.mermaidPlace1 == 12 || battleModeVisibility.mermaidPlace1 == 17 || battleModeVisibility.mermaidPlace1 == 22 || battleModeVisibility.mermaidPlace1 == 28 || battleModeVisibility.mermaidPlace1 == 29 || battleModeVisibility.mermaidPlace1 == 34 || battleModeVisibility.mermaidPlace1 == 36 || battleModeVisibility.mermaidPlace1 == 40)
                            {
                                Instantiate(final.presentmedus, final.place1.transform.position, Quaternion.identity, final.place1.transform);
                            }
                            else if (battleModeVisibility.mermaidPlace1 == 13 || battleModeVisibility.mermaidPlace1 == 18 || battleModeVisibility.mermaidPlace1 == 48 || battleModeVisibility.mermaidPlace1 == 30)
                            {
                                Instantiate(final.presenthubka, final.place1.transform.position, Quaternion.identity, final.place1.transform);
                            }
                            if (battleModeVisibility.randomObilia == 2)
                            {
                                if (battleModeVisibility.mermaidPlace2 == 2 || battleModeVisibility.mermaidPlace2 == 4 || battleModeVisibility.mermaidPlace2 == 5 || battleModeVisibility.mermaidPlace2 == 6 || battleModeVisibility.mermaidPlace2 == 11 || battleModeVisibility.mermaidPlace2 == 16 || battleModeVisibility.mermaidPlace2 == 20 || battleModeVisibility.mermaidPlace2 == 25 || battleModeVisibility.mermaidPlace2 == 27 || battleModeVisibility.mermaidPlace2 == 31 || battleModeVisibility.mermaidPlace2 == 32 || battleModeVisibility.mermaidPlace2 == 33 || battleModeVisibility.mermaidPlace2 == 35) // рыбы
                                {
                                    Instantiate(final.presentryba, final.place2.transform.position, Quaternion.identity, final.place2.transform);
                                }
                                else if (battleModeVisibility.mermaidPlace2 == 1 || battleModeVisibility.mermaidPlace2 == 9 || battleModeVisibility.mermaidPlace2 == 37 || battleModeVisibility.mermaidPlace2 == 42 || battleModeVisibility.mermaidPlace2 == 44 || battleModeVisibility.mermaidPlace2 == 47)
                                {
                                    Instantiate(final.presentrak, final.place2.transform.position, Quaternion.identity, final.place2.transform);
                                }
                                else if (battleModeVisibility.mermaidPlace2 == 3 || battleModeVisibility.mermaidPlace2 == 15 || battleModeVisibility.mermaidPlace2 == 19 || battleModeVisibility.mermaidPlace2 == 23 || battleModeVisibility.mermaidPlace2 == 38)
                                {
                                    Instantiate(final.presentmolusk, final.place2.transform.position, Quaternion.identity, final.place2.transform);
                                }
                                else if (battleModeVisibility.mermaidPlace2 == 7 || battleModeVisibility.mermaidPlace2 == 14 || battleModeVisibility.mermaidPlace2 == 24 || battleModeVisibility.mermaidPlace2 == 41 || battleModeVisibility.mermaidPlace2 == 46)
                                {
                                    Instantiate(final.presentcherv, final.place2.transform.position, Quaternion.identity, final.place2.transform);
                                }
                                else if (battleModeVisibility.mermaidPlace2 == 8 || battleModeVisibility.mermaidPlace2 == 21 || battleModeVisibility.mermaidPlace2 == 10)
                                {
                                    Instantiate(final.presentzvezdi, final.place2.transform.position, Quaternion.identity, final.place2.transform);
                                }
                                else if (battleModeVisibility.mermaidPlace2 == 12 || battleModeVisibility.mermaidPlace2 == 17 || battleModeVisibility.mermaidPlace2 == 22 || battleModeVisibility.mermaidPlace2 == 28 || battleModeVisibility.mermaidPlace2 == 29 || battleModeVisibility.mermaidPlace2 == 34 || battleModeVisibility.mermaidPlace2 == 36 || battleModeVisibility.mermaidPlace2 == 40)
                                {
                                    Instantiate(final.presentmedus, final.place2.transform.position, Quaternion.identity, final.place2.transform);
                                }
                                else if (battleModeVisibility.mermaidPlace2 == 13 || battleModeVisibility.mermaidPlace2 == 18 || battleModeVisibility.mermaidPlace2 == 48 || battleModeVisibility.mermaidPlace2 == 30)
                                {
                                    Instantiate(final.presenthubka, final.place2.transform.position, Quaternion.identity, final.place2.transform);
                                }
                                else if (battleModeVisibility.mermaidPlace2 == 60)
                                {
                                    Instantiate(final.presentnote, final.place2.transform.position, Quaternion.identity, final.place2.transform);
                                }

                            }


                            final.garemSpecial2Button.SetActive(true);
                            // после этого скиппинг мод?
                        }
                    }

                    else
                    {
                        battleModeVisibility.skippingMode = true;
                    }

                }
                // неудачный побег
                else if(podtverjdSkip.activeSelf == true)
                {
                    skipneud.SetActive(true);
                    skipCheck = 500;
                    //podtverjdSkip.SetActive(false);
                }
            }
        }

        // Если встретили врага
        if (battleModeVisibility.battleMode == true)
        {
            speed = 0f;
            if (obuchalka.activeSelf == false && skills.skillsBack.activeSelf == false)
            {
                podtverjdBoi.SetActive(true);
                if (distancePoints.distance <= 12070)
                {
                    podtverjdSkip.SetActive(true);
                }
            }
            else
            {
                podtverjdBoi.SetActive(false);
                podtverjdSkip.SetActive(false);
            }

            // двигаемся влево
            if (transform.position.x >= 49.8 && battleModeVisibility.skippingMode == false)
            {

                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x - 5, transform.position.y, transform.position.z), 5f * Time.deltaTime);
                if (enemyspawner.fishbiom == false)
                {
                    currentMerman.transform.position = Vector3.MoveTowards(currentMerman.transform.position, new Vector3(currentMerman.transform.position.x - 5, currentMerman.transform.position.y + 2, currentMerman.transform.position.z), 6f * Time.deltaTime);
                }
            }
            
        }

        // Выключение батл мода после врага, это универсальный скиппинг мод
        if (battleModeVisibility.skippingMode == true)
        {
            mermreader.skipEnemy();
            podtverjdBoi.SetActive(false);
            podtverjdSkip.SetActive(false);
            nagradoid = false;
            battleModeVisibility.battleMode = false;
            if (transform.position.x < 54.6)
            {
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x + 5, transform.position.y - 2, transform.position.z), 5f * Time.deltaTime);
                if (enemyspawner.fishbiom == false)
                {
                    currentMerman.transform.position = Vector3.MoveTowards(currentMerman.transform.position, new Vector3(currentMerman.transform.position.x - 7, currentMerman.transform.position.y + 5, currentMerman.transform.position.z), 10f * Time.deltaTime);
                }

               // transform.position = new Vector3(Mathf.Lerp(transform.position.x, transform.position.x + 5, 1 * Time.deltaTime), Mathf.Lerp(transform.position.y, transform.position.y - 2, 1 * Time.deltaTime), transform.position.z);
              //  currentMerman.transform.position = new Vector3(Mathf.Lerp(currentMerman.transform.position.x, currentMerman.transform.position.x - 7, 1 * Time.deltaTime), Mathf.Lerp(currentMerman.transform.position.y, currentMerman.transform.position.y + 5, 1 * Time.deltaTime), currentMerman.transform.position.z);
            }
            else
            {
                // для рыбы другое условие
                if (enemyspawner.fishbiom == false)
                {
                    Destroy(currentMerman);
                    currentMerman = null;
                }
                battleModeVisibility.skippingMode = false;
                enemyspawner.fishbiom = false;
                skipCheck = 70;
                if (gens.pMimicria == 1)
                {
                    skipCheck = 60;
                }
                if (gens.pMimicria == 2)
                {
                    skipCheck = 50;
                }
                if (gens.pMimicria == 3)
                {
                    skipCheck = 40;
                }
                if (gens.pProzrachnost == 3)
                {
                    skipCheck += 10;
                }
                podtverjdenie.podtverjdenoTapom = false;
                podtverjdenie.nepodtverjdenoTapom = false;
                podtverjdenie.podtverjdenoOk = false;
            }
            
        }
        // двигаемся вправо на смерть, то, что можно вернуть при рекламе, сначала убрать дес мод, потом в мерменридере убрать булы врагов
        if (final.deathmode)
        {
            Invoke("Death", 3f);
            foreach (AudioSource sourcerer in music.katka) // затухание основного эмбиента
            {
                sourcerer.volume -= Time.deltaTime;
            }
            if (!deathelectro.isPlaying && !deathreal.isPlaying && !deathreal2.isPlaying) 
            {
                if (enemyspawner.bBabil || enemyspawner.bCirrat || enemyspawner.bNophor || enemyspawner.bSciph || enemyspawner.bTheus || enemyspawner.bTkhar)// это зависит от врага
                {
                   // Invoke("vspysh", 0.5f);
                    
                    deathelectro.Play(0);
                }
                else
                {
                    switch (Random.Range(0, 3))
                    {
                        case 1:
                            deathreal.Play(0);
                            break;
                        default:
                            deathreal2.Play(0);
                            break;
                    }
                    ded.SetActive(true);
                }
                // если рыба, то камера фолловит её?
                

                movingbutton.SetActive(false);
                mermreader.skipEnemy();
                podtverjdBoi.SetActive(false);
                podtverjdSkip.SetActive(false);
                nagradoid = false;
                battleModeVisibility.battleMode = false;
                podtverjdenie.podtverjdenoTapom = false;
                podtverjdenie.nepodtverjdenoTapom = false;
                podtverjdenie.podtverjdenoOk = false;
                // это уже после подтверждения смерти
                // если на экране капсула
                // 

            }
            if (enemyspawner.fishbiom)
            {
                if (otherholder.transform.localPosition.y <= -70)
                {
                    otherholder.transform.localPosition = Vector3.MoveTowards(otherholder.transform.localPosition, new Vector3(otherholder.transform.localPosition.x + 1, otherholder.transform.localPosition.y + 5, otherholder.transform.localPosition.z), 10f * Time.deltaTime);
                }
            }
            else
            {
                currentMerman.transform.position = Vector3.MoveTowards(currentMerman.transform.position, new Vector3(currentMerman.transform.position.x - 5, currentMerman.transform.position.y, currentMerman.transform.position.z), 5f * Time.deltaTime);

                if (otherholder.transform.localPosition.y <= -87)
                {
                    otherholder.transform.localPosition = Vector3.MoveTowards(otherholder.transform.localPosition, new Vector3(otherholder.transform.localPosition.x + 1, otherholder.transform.localPosition.y + 5, otherholder.transform.localPosition.z), 5f * Time.deltaTime);
                    trueSprite.transform.localPosition = Vector3.MoveTowards(trueSprite.transform.localPosition, new Vector3(trueSprite.transform.localPosition.x - 5, trueSprite.transform.localPosition.y, trueSprite.transform.localPosition.z), 5f * Time.deltaTime);
                }
            }
        }
    }

    public void Death()
    {
        fador.SetActive(true);
    }

    // это только подтверждение
    public void skipEnemy()
{
        if (battleModePlay.playingMode == false && progress.settingsMode.activeSelf == false && nagradoid == false && skills.skillsBack.activeSelf == false && podtverjdenie.noteBack.activeSelf == false && podtverjdenie.confirmBack.activeSelf == false && podtverjdenie.presentBack.activeSelf == false)
        {
            podtverjdenie.noteBack.SetActive(false);
            if (progress.languager == 0)
            {
                podtverjdenie.confirmText.text = "Try to swim around \n and skip the enemy?";
            }
            if (progress.languager == 1)
            {
                podtverjdenie.confirmText.text = "Попробовать обплыть и \n пропустить врага?";
            }
            else if (progress.languager == 2)
            {
                podtverjdenie.confirmText.text = "Спробувати обплисти й \n пропустити ворога?";
            }
            podtverjdenie.podtverjdenoTapom = false;
            podtverjdenie.nepodtverjdenoTapom = false;
            podtverjdenie.podtverjdenoOk = false;
            anotherdifference = true;
            podtverjdenie.confirmBack.SetActive(true);
        }

}

public void podtverjdenieBoi()
    {
        if (podtverjdenie.noteBack.activeSelf == false && podtverjdenie.confirmBack.activeSelf == false && podtverjdenie.presentBack.activeSelf == false && battleModePlay.playingMode == false && progress.settingsMode.activeSelf == false && nagradoid == false && skills.skillsBack.activeSelf == false)
        {
            podtverjdenie.confirmBack.SetActive(false);
            skipCheck = 500;
            podtverjdenie.podtverjdenoTapom = false;
            podtverjdenie.nepodtverjdenoTapom = false;
            podtverjdenie.podtverjdenoOk = false;
            battleModePlay.playingMode = true;
        }
    }
}
