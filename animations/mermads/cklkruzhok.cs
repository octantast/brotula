using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cklkruzhok : MonoBehaviour
{
    public Levels leveler;
    public obuchregul reguliator;
    public DistanceToCheckpoint distance;
    public MermaidController mermaids;

    public GameObject kruzhok_obuchatel;
    private float timer;
    public Image malutkin;
    public Text taptoswim;

    private Color32 whitecolor;
    private Color32 whitecolorreal;

    void Start()
    {
        whitecolor = new Color32(225, 225, 225, 0);
        whitecolorreal = new Color32(225, 225, 225, 120);
        timer = 0.1f;
        kruzhok_obuchatel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // это скип
        if (reguliator.skipneud.activeSelf == true)
        {
            if (reguliator.skippi)
            {
                if (leveler.languager == 0)
                {
                    taptoswim.text = "Escape failed";
                }
                else if (leveler.languager == 1)
                {
                    taptoswim.text = "Побег не удался";
                }
                else if (leveler.languager == 2)
                {
                    taptoswim.text = "Втекти не вдалося";
                }
                taptoswim.color = Color.Lerp(taptoswim.color, whitecolorreal, Mathf.PingPong(Time.deltaTime * 20f, 4f) / 4f);
            }
            else
            {
                timer = 0.5f;
                taptoswim.color = Color.Lerp(taptoswim.color, whitecolor, Mathf.PingPong(Time.deltaTime * 20f, 4f) / 4f);
            }
        }

        // это лимит русалок
        if (reguliator.podsklimit.activeSelf == true)
        {
            if(reguliator.mermaidslimited)
            {
                if (leveler.languager == 0)
                {
                    taptoswim.text = "Impossible to keep \n more companions";
                }
                else if (leveler.languager == 1)
                {
                    taptoswim.text = "Невозможно удерживать \n столько спутниц";
                }
                else if (leveler.languager == 2)
                {
                    taptoswim.text = "Неможливо втримувати \n стільки супутниць";
                }
                taptoswim.color = Color.Lerp(taptoswim.color, whitecolorreal, Mathf.PingPong(Time.deltaTime * 20f, 4f) / 4f);

                if (kruzhok_obuchatel.activeSelf == false)
                {
                    kruzhok_obuchatel.transform.localScale = new Vector2(0f, 0f);
                    timer -= Time.deltaTime;
                    if (timer <= 0)
                    {
                        timer = 0.5f;
                        kruzhok_obuchatel.SetActive(true);
                    }
                }
            }
            else
            {
                timer = 0.5f;
                taptoswim.color = Color.Lerp(taptoswim.color, whitecolor, Mathf.PingPong(Time.deltaTime * 20f, 4f) / 4f);
            }
        }


        // это читается подсказкой как плыть
        if (distance.distance < 5050 && reguliator.podskgenes.activeSelf == true)
        {
            if (reguliator.genofond)
            {
                if (leveler.languager == 0)
                {
                    taptoswim.text = "Unused genes disappear \n if the expedition begins";
                }
                else if (leveler.languager == 1)
                {
                    taptoswim.text = "Новые гены исчезнут, если \n не внедрить их до спуска";
                }
                else if (leveler.languager == 2)
                {
                    taptoswim.text = "Нові гени зникнуть, якщо \n не ввести їх до спуску";
                }
                taptoswim.color = Color.Lerp(taptoswim.color, whitecolorreal, Mathf.PingPong(Time.deltaTime * 20f, 4f) / 4f);

                if (kruzhok_obuchatel.activeSelf == false)
                {
                    kruzhok_obuchatel.transform.localScale = new Vector2(0f, 0f);
                    timer -= Time.deltaTime;
                    if (timer <= 0)
                    {
                        timer = 0.5f;
                        kruzhok_obuchatel.SetActive(true);
                    }
                }
            }
            else
            {
                timer = 0.5f;
                taptoswim.color = Color.Lerp(taptoswim.color, whitecolor, Mathf.PingPong(Time.deltaTime * 20f, 4f) / 4f);
            }
        }
        // это читается подсказкой как плыть
        else if (distance.distance < 5020 && reguliator.podskgenes1.activeSelf == false)
        {
            if (reguliator.pidskazka_the_end == false)
            {
                if (leveler.languager == 0)
                {
                    taptoswim.text = "Tap and hold to swim";
                }
                else if (leveler.languager == 1)
                {
                    taptoswim.text = "Зажмите, чтобы плыть";
                }
                else if (leveler.languager == 2)
                {
                    taptoswim.text = "Утримуйте, щоб плисти";
                }
                taptoswim.color = Color.Lerp(taptoswim.color, whitecolorreal, Mathf.PingPong(Time.deltaTime * 20f, 4f) / 4f);

                if (kruzhok_obuchatel.activeSelf == false)
                {
                    kruzhok_obuchatel.transform.localScale = new Vector2(0f, 0f);
                    timer -= Time.deltaTime;
                    if (timer <= 0)
                    {
                        timer = 0.5f;
                        kruzhok_obuchatel.SetActive(true);
                    }
                }
            }
            else if(reguliator.pidskazka_the_end)
            {
                if (leveler.languager == 0)
                {
                    taptoswim.text = "Mission complete\n\n" + reguliator.genescount.ToString("F1") + "% of genes, " + reguliator.enemiescount.ToString("F1") + "% of enemies\nand " + reguliator.mermaidscount.ToString("F1") + "% of companions \nhave been already found";
                }
                else if (leveler.languager == 1)
                {
                    taptoswim.text = "Миссия выполнена\n\nк этому моменту найдено\n" + reguliator.genescount.ToString("F1") + "% генов, " + reguliator.enemiescount.ToString("F1") + "% врагов,\nи " + reguliator.mermaidscount.ToString("F1") + "% спутниц";
                }
                else if (leveler.languager == 2)
                {
                    taptoswim.text = "Місію виконано\n\nна даний момент занйдено\n" + reguliator.genescount.ToString("F1") + "% генів, " + reguliator.enemiescount.ToString("F1") + "% ворогів,\nі " + reguliator.mermaidscount.ToString("F1") + "% супутниць";
                }
                taptoswim.color = Color.Lerp(taptoswim.color, whitecolorreal, Mathf.PingPong(Time.deltaTime * 20f, 4f) / 4f);

            }
        }
        else if (distance.distance < 5020 && reguliator.podskgenes1.activeSelf == true)
        {
            if (reguliator.gentipnormie)
            {
                if (leveler.languager == 0)
                {
                    taptoswim.text = "modify your body \nto reach the deepest point";
                }
                else if (leveler.languager == 1)
                {
                    taptoswim.text = "доберитесь до самой глубокой точки,\n модифицируя свой организм";
                }
                else if (leveler.languager == 2)
                {
                    taptoswim.text = "модифікуйте свій організм, \nщоб дістатися найглибшої точки";
                }
                taptoswim.color = Color.Lerp(taptoswim.color, whitecolorreal, Mathf.PingPong(Time.deltaTime * 20f, 4f) / 4f);

                if (kruzhok_obuchatel.activeSelf == false)
                {
                    kruzhok_obuchatel.transform.localScale = new Vector2(0f, 0f);
                    timer -= Time.deltaTime;
                    if (timer <= 0)
                    {
                        timer = 0.5f;
                        kruzhok_obuchatel.SetActive(true);
                    }
                }
            }
            else
            {
                timer = 0.5f;
                taptoswim.color = Color.Lerp(taptoswim.color, whitecolor, Mathf.PingPong(Time.deltaTime * 20f, 4f) / 4f);
            }
        }
        else if (distance.distance >= 5020 && distance.distance < 5050 && reguliator.podskgenes2.activeSelf == false && reguliator.podskgenes1.activeSelf == false && reguliator.podskgenes.activeSelf == false)
        {
            timer = 0.5f;
            taptoswim.color = Color.Lerp(taptoswim.color, whitecolor, Mathf.PingPong(Time.deltaTime * 20f, 4f) / 4f);
        }
        // если навыки снаружи
        else if(distance.distance >= 5070 && distance.distance <= 5200)
        {
            taptoswim.color = Color.Lerp(taptoswim.color, whitecolorreal, Mathf.PingPong(Time.deltaTime * 20f, 4f) / 4f);
            if (leveler.languager == 0)
            {
                taptoswim.text = "exploration of depth \nrequires survival skills";
            }
            else if (leveler.languager == 1)
            {
                taptoswim.text = "освоение глубин требует \nособой подготовки";
            }
            else if (leveler.languager == 2)
            {
                taptoswim.text = "виживання на глибинах \nпотребує підготовки";
            }
            if (kruzhok_obuchatel.activeSelf == false)
            {
                kruzhok_obuchatel.transform.localScale = new Vector2(0f, 0f);
                timer -= Time.deltaTime;
                if (timer <= 0)
                {
                    timer = 0.5f;
                    kruzhok_obuchatel.SetActive(true);
                }
            }
        }
        else if (distance.distance >= 5200 && distance.distance < 5250 && reguliator.batoltip.activeSelf == false && reguliator.batoltip2.activeSelf == false)
        {
            timer = 0.5f;
            taptoswim.color = Color.Lerp(taptoswim.color, whitecolor, Mathf.PingPong(Time.deltaTime * 20f, 4f) / 4f);
        }

        if(reguliator.batoltip.activeSelf == true && distance.distance > 5050 && reguliator.skipneud.activeSelf == false)
        {
            taptoswim.color = Color.Lerp(taptoswim.color, whitecolorreal, Mathf.PingPong(Time.deltaTime * 20f, 4f) / 4f);
            if (leveler.languager == 0)
            {
                taptoswim.text = "prepare your field for the fight \n\nthe one who lose more cells,\nwill retreat frightened";
            }
            else if (leveler.languager == 1)
            {
                taptoswim.text = "расставьте навыки перед боем \n\nтот, кто потеряет больше клеток,\nотступит в ужасе";
            }
            else if (leveler.languager == 2)
            {
                taptoswim.text = "підготуйте поле до бою\n\nтой, хто втратить більше клітин,\nвтече від жаху";
            }
            if (kruzhok_obuchatel.activeSelf == false)
            {
                kruzhok_obuchatel.transform.localScale = new Vector2(0f, 0f);
                timer -= Time.deltaTime;
                if (timer <= 0)
                {
                    timer = 0.5f;
                    kruzhok_obuchatel.SetActive(true);
                }
            }
        }
        else if (reguliator.batoltip2.activeSelf == true && distance.distance > 5050 && reguliator.skipneud.activeSelf == false)
        {
            if (reguliator.batoltip2ugasnet == false)
            {
                taptoswim.color = Color.Lerp(taptoswim.color, whitecolorreal, Mathf.PingPong(Time.deltaTime * 20f, 4f) / 4f);
                if (leveler.languager == 0)
                {
                    taptoswim.text = "Touch the enemy to attack \n \ntouch the character to escape";
                }
                else if (leveler.languager == 1)
                {
                    taptoswim.text = "Коснитесь врага и начните бой \n \nдля побега коснитесь героя";
                }
                else if (leveler.languager == 2)
                {
                    taptoswim.text = "Натисніть на ворога для атаки \n \nторкніться героя, щоб втекти";
                }
            }
            else
            {
                timer = 0.5f;
                taptoswim.color = Color.Lerp(taptoswim.color, whitecolor, Mathf.PingPong(Time.deltaTime * 20f, 4f) / 4f);
            }

        }

        if(reguliator.mermadstip.activeSelf == true)
        {
            if (reguliator.mermadstiptext)
            {
                if (mermaids.garemBack.activeSelf == true)
                {
                    taptoswim.transform.localPosition = new Vector3(0f, -1560f, 0f);
                    taptoswim.color = Color.Lerp(taptoswim.color, whitecolorreal, Mathf.PingPong(Time.deltaTime * 20f, 4f) / 4f);
                    if (leveler.languager == 0)
                    {
                        taptoswim.text = "swipe up to drive away \n \nswipe down to please";
                    }
                    else if (leveler.languager == 1)
                    {
                        taptoswim.text = "смахните вверх, чтобы прогнать \n \nчтобы уделить внимание - вниз";
                    }
                    else if (leveler.languager == 2)
                    {
                        taptoswim.text = "змахніть вгору, щоб прогнати \n \nЩоб приділити увагу - вниз";
                    }
                    timer = 0.5f;
                }
                else
                {
                    taptoswim.text = " ";
                }
            }
            else if (reguliator.mermadstipkrug && reguliator.skipneud.activeSelf == false) // чтобі не конфликтовали
            {

                if (reguliator.mozhnogasnut == false && (distance.distance <= 5460 || distance.distance >= 5600 && distance.distance <= 6420 || distance.distance >= 6570 && distance.distance <= 7000))
                {
                    if (leveler.languager == 0)
                    {
                        taptoswim.text = "the path is easier \nin pleasant company";
                    }
                    else if (leveler.languager == 1)
                    {
                        taptoswim.text = "спутницы помогут \nоблегчить путь";
                    }
                    else if (leveler.languager == 2)
                    {
                        taptoswim.text = "завдяки супутницям \nшлях буде легшим";
                    }
                    taptoswim.transform.localPosition = new Vector3(0f, -1712f, 0f);
                    taptoswim.color = Color.Lerp(taptoswim.color, whitecolorreal, Mathf.PingPong(Time.deltaTime * 20f, 4f) / 4f);
                    
                    if (kruzhok_obuchatel.activeSelf == false)
                    {
                        kruzhok_obuchatel.transform.localScale = new Vector2(0f, 0f);
                        timer -= Time.deltaTime;
                        if (timer <= 0)
                        {
                            timer = 0.5f;
                            kruzhok_obuchatel.SetActive(true);
                        }
                    }
                }
                else
                {
                    if (distance.distance <= 5460 || distance.distance >= 5600 && distance.distance <= 6420 || distance.distance >= 6570 && distance.distance <= 7000)
                    {

                    }
                    else
                    {
                        taptoswim.text = " ";
                    }
                    timer = 0.5f;
                    taptoswim.color = Color.Lerp(taptoswim.color, whitecolor, Mathf.PingPong(Time.deltaTime * 20f, 4f) / 4f);
                }
            }
            else
            {
                timer = 0.5f;
                taptoswim.color = Color.Lerp(taptoswim.color, whitecolor, Mathf.PingPong(Time.deltaTime * 20f, 4f) / 4f);
            }
            

        }

        if(reguliator.mermadstippriz.activeSelf == true)
        {
            if(reguliator.prizegone && (distance.distance <= 5460 || distance.distance >= 5600 && distance.distance <= 6420 || distance.distance >= 6570 && distance.distance <= 7000)) //
            {
                if (leveler.languager == 0)
                {
                    taptoswim.text = "take care of companions \nwhile the path is clear";
                }
                else if (leveler.languager == 1)
                {
                    taptoswim.text = "заглядывайте к спутницам, \n пока путь чист";
                }
                else if (leveler.languager == 2)
                {
                    taptoswim.text = "доглядайте супутниць \n в моменти спокою";
                }
                taptoswim.color = Color.Lerp(taptoswim.color, whitecolorreal, Mathf.PingPong(Time.deltaTime * 20f, 4f) / 4f);

                if (kruzhok_obuchatel.activeSelf == false)
                {
                    kruzhok_obuchatel.transform.localScale = new Vector2(0f, 0f);
                    timer -= Time.deltaTime;
                    if (timer <= 0)
                    {
                        timer = 0.5f;
                        kruzhok_obuchatel.SetActive(true);
                    }
                }
            }
            else // затухание
            {
                kruzhok_obuchatel.SetActive(false);
                timer = 0.5f;
                taptoswim.color = Color.Lerp(taptoswim.color, whitecolor, Mathf.PingPong(Time.deltaTime * 20f, 4f) / 4f);
            }
        }

        if(distance.distance <= 5050 && reguliator.podskgenes2.activeSelf == true)
        {
            if (leveler.languager == 0)
            {
                taptoswim.text = "tap the syringe to inject \nselected genes \nbefore expedition starts";
            }
            else if (leveler.languager == 1)
            {
                taptoswim.text = "составьте комбинацию генов \nи коснитесь шприца для внедрения";
            }
            else if (leveler.languager == 2)
            {
                taptoswim.text = "торкніться шприца, коли \nскомбінуєте гени для введення";
            }
            taptoswim.color = Color.Lerp(taptoswim.color, whitecolorreal, Mathf.PingPong(Time.deltaTime * 20f, 4f) / 4f);

            if (kruzhok_obuchatel.activeSelf == false)
            {
                kruzhok_obuchatel.transform.localScale = new Vector2(0f, 0f);
                timer -= Time.deltaTime;
                if (timer <= 0)
                {
                    timer = 0.5f;
                    kruzhok_obuchatel.SetActive(true);
                }
            }
        }


    }
}
