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
        // ��� ����
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
                    taptoswim.text = "����� �� ������";
                }
                else if (leveler.languager == 2)
                {
                    taptoswim.text = "������ �� �������";
                }
                taptoswim.color = Color.Lerp(taptoswim.color, whitecolorreal, Mathf.PingPong(Time.deltaTime * 20f, 4f) / 4f);
            }
            else
            {
                timer = 0.5f;
                taptoswim.color = Color.Lerp(taptoswim.color, whitecolor, Mathf.PingPong(Time.deltaTime * 20f, 4f) / 4f);
            }
        }

        // ��� ����� �������
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
                    taptoswim.text = "���������� ���������� \n ������� �������";
                }
                else if (leveler.languager == 2)
                {
                    taptoswim.text = "��������� ���������� \n ������ ���������";
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


        // ��� �������� ���������� ��� �����
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
                    taptoswim.text = "����� ���� ��������, ���� \n �� �������� �� �� ������";
                }
                else if (leveler.languager == 2)
                {
                    taptoswim.text = "��� ���� ��������, ���� \n �� ������ �� �� ������";
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
        // ��� �������� ���������� ��� �����
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
                    taptoswim.text = "�������, ����� �����";
                }
                else if (leveler.languager == 2)
                {
                    taptoswim.text = "���������, ��� ������";
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
                    taptoswim.text = "������ ���������\n\n� ����� ������� �������\n" + reguliator.genescount.ToString("F1") + "% �����, " + reguliator.enemiescount.ToString("F1") + "% ������,\n� " + reguliator.mermaidscount.ToString("F1") + "% �������";
                }
                else if (leveler.languager == 2)
                {
                    taptoswim.text = "̳�� ��������\n\n�� ����� ������ ��������\n" + reguliator.genescount.ToString("F1") + "% ����, " + reguliator.enemiescount.ToString("F1") + "% ������,\n� " + reguliator.mermaidscount.ToString("F1") + "% ���������";
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
                    taptoswim.text = "���������� �� ����� �������� �����,\n ����������� ���� ��������";
                }
                else if (leveler.languager == 2)
                {
                    taptoswim.text = "����������� ��� �������, \n��� �������� ��������� �����";
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
        // ���� ������ �������
        else if(distance.distance >= 5070 && distance.distance <= 5200)
        {
            taptoswim.color = Color.Lerp(taptoswim.color, whitecolorreal, Mathf.PingPong(Time.deltaTime * 20f, 4f) / 4f);
            if (leveler.languager == 0)
            {
                taptoswim.text = "exploration of depth \nrequires survival skills";
            }
            else if (leveler.languager == 1)
            {
                taptoswim.text = "�������� ������ ������� \n������ ����������";
            }
            else if (leveler.languager == 2)
            {
                taptoswim.text = "��������� �� �������� \n������� ���������";
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
                taptoswim.text = "���������� ������ ����� ���� \n\n���, ��� �������� ������ ������,\n�������� � �����";
            }
            else if (leveler.languager == 2)
            {
                taptoswim.text = "��������� ���� �� ���\n\n���, ��� �������� ����� �����,\n����� �� ����";
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
                    taptoswim.text = "��������� ����� � ������� ��� \n \n��� ������ ��������� �����";
                }
                else if (leveler.languager == 2)
                {
                    taptoswim.text = "�������� �� ������ ��� ����� \n \n��������� �����, ��� ������";
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
                        taptoswim.text = "�������� �����, ����� �������� \n \n����� ������� �������� - ����";
                    }
                    else if (leveler.languager == 2)
                    {
                        taptoswim.text = "������� �����, ��� �������� \n \n��� �������� ����� - ����";
                    }
                    timer = 0.5f;
                }
                else
                {
                    taptoswim.text = " ";
                }
            }
            else if (reguliator.mermadstipkrug && reguliator.skipneud.activeSelf == false) // ���� �� �������������
            {

                if (reguliator.mozhnogasnut == false && (distance.distance <= 5460 || distance.distance >= 5600 && distance.distance <= 6420 || distance.distance >= 6570 && distance.distance <= 7000))
                {
                    if (leveler.languager == 0)
                    {
                        taptoswim.text = "the path is easier \nin pleasant company";
                    }
                    else if (leveler.languager == 1)
                    {
                        taptoswim.text = "�������� ������� \n��������� ����";
                    }
                    else if (leveler.languager == 2)
                    {
                        taptoswim.text = "������� ���������� \n���� ���� ������";
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
                    taptoswim.text = "������������ � ���������, \n ���� ���� ����";
                }
                else if (leveler.languager == 2)
                {
                    taptoswim.text = "���������� ��������� \n � ������� ������";
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
            else // ���������
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
                taptoswim.text = "��������� ���������� ����� \n� ��������� ������ ��� ���������";
            }
            else if (leveler.languager == 2)
            {
                taptoswim.text = "��������� ������, ���� \n��������� ���� ��� ��������";
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
