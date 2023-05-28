using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class DistanceToCheckpoint : MonoBehaviour
{
    private static DistanceToCheckpoint instance = null;
    public static DistanceToCheckpoint SharedInstance
    {
        get
        {
            if (instance == null)
            {
                instance = new DistanceToCheckpoint();
            }
            return instance;
        }
    }

    public AudioSource stones;

    [SerializeField]
    private Transform checkpoint;
    public Levels leveler;

    public float subductionZoneAval;
    public GameObject subsuctedge;
    public GameObject subsuctpartleft;
    public GameObject subsuctpartright;


    public GameObject conflicrobuchenie;
    [SerializeField]
    private Text distanceText;
    public GameObject superindicator;
    public GameObject indicanvas;
    public float distance;
    public float timerindikatora;
    private Vector3 indicatorposition;
    private Vector3 indicatordefaultposition;
    private float skorostviezda;
    [SerializeField] private bool biom1shown;
    [SerializeField] private bool biom2shown;
    [SerializeField] private bool biom3shown;
    [SerializeField] private bool biom4shown;
    [SerializeField] private bool biom5shown;
    [SerializeField] private bool biom6shown;

    public bool played;

    private void Start()
    {
       // subsuctedge.SetActive(false);
        subductionZoneAval = PlayerPrefs.GetFloat("subductionZoneAval");

        timerindikatora = 5f;
        skorostviezda = 70;
        superindicator.SetActive(false);
        indicatorposition = new Vector3(superindicator.transform.localPosition.x, superindicator.transform.localPosition.y, superindicator.transform.localPosition.z); // ����� ������
        indicatordefaultposition = new Vector3(superindicator.transform.localPosition.x - 800f, superindicator.transform.localPosition.y, superindicator.transform.localPosition.z); // �� �����
        superindicator.transform.localPosition = indicatordefaultposition;
    }

    private void Update()
    {
        distance = (checkpoint.transform.position.y - 5.9F * transform.position.y);

        // ������ ���-�� �����
        if (superindicator.activeSelf == true)
        {
            if (distance > 5150 && biom1shown == false)
            {
                if (conflicrobuchenie.activeSelf == false && leveler.expe > 0)

                {
                    if (leveler.languager == 0)
                    {
                        distanceText.text = " Abyssal zone \n " + distance.ToString("F1") + " M";
                    }
                    else if (leveler.languager == 1)
                    {
                        distanceText.text = " ����������� ���� \n " + distance.ToString("F1") + " M";
                    }
                    else if (leveler.languager == 2)
                    {
                        distanceText.text = " �������� ���� \n " + distance.ToString("F1") + " M";
                    }
                }
            }
            else if (distance > 5650 && biom2shown == false)
            {
                if (leveler.languager == 0)
                {
                    distanceText.text = " Hydrothermal vents \n " + distance.ToString("F1") + " M";
                }
                else if (leveler.languager == 1)
                {
                    distanceText.text = " ��������������� ��������� \n " + distance.ToString("F1") + " M";
                }
                else if (leveler.languager == 2)
                {
                    distanceText.text = " ó����������� ������� \n " + distance.ToString("F1") + " M";
                }
            }
            else if (distance > 6700 && biom3shown == false)
            {
                if (leveler.languager == 0)
                {
                    distanceText.text = " Hadal zone \n " + distance.ToString("F1") + " M";
                }
                else if (leveler.languager == 1)
                {
                    distanceText.text = " ��������� ���� \n " + distance.ToString("F1") + " M";
                }
                else if (leveler.languager == 2)
                {
                    distanceText.text = " �������� ���� \n " + distance.ToString("F1") + " M";
                }
            }
            else if (distance > 8520 && biom4shown == false)
            {
                if (leveler.languager == 0)
                {
                    distanceText.text = " Trench \n " + distance.ToString("F1") + " M";
                }
                else if (leveler.languager == 1)
                {
                    distanceText.text = " Ƹ��� \n " + distance.ToString("F1") + " M";
                }
                else if (leveler.languager == 2)
                {
                    distanceText.text = " ����� \n " + distance.ToString("F1") + " M";
                }
            }
            else if (distance > 10550 && biom5shown == false)
            {
                if (leveler.languager == 0)
                {
                    distanceText.text = " Trench bottom \n " + distance.ToString("F1") + " M";
                }
                else if (leveler.languager == 1)
                {
                    distanceText.text = " ��� ����� \n " + distance.ToString("F1") + " M";
                }
                else if (leveler.languager == 2)
                {
                    distanceText.text = " ��� ������ \n " + distance.ToString("F1") + " M";
                }
            }

            else if (distance > 12150 && biom6shown == false)
            {
                if (leveler.languager == 0)
                {
                    distanceText.text = " subduction zone";
                }
                else if (leveler.languager == 1)
                {
                    distanceText.text = " ���� ���������";
                }
                else if (leveler.languager == 2)
                {
                    distanceText.text = " ���� ���������";
                }
            }

        }

        // ������� ��������� �� �����, ���� �������� ������ �����

        // ���� 1
        if (distance > 5150)
        {
            if (biom1shown == false && timerindikatora >= 2f)
            {
                superindicator.SetActive(true);
                timerindikatora -= Time.deltaTime;
                superindicator.transform.localPosition = Vector3.MoveTowards(superindicator.transform.localPosition, indicatorposition, skorostviezda);

            }
            else if (timerindikatora < 2f && timerindikatora > 0 && biom1shown == false)
            {
                timerindikatora -= Time.deltaTime;
                superindicator.transform.localPosition = Vector3.MoveTowards(superindicator.transform.localPosition, indicatordefaultposition, skorostviezda);
            }
            else if (timerindikatora <= 0f && biom1shown == false)
            {
                biom1shown = true;
                timerindikatora = 6f; // ��� ����� �����
                superindicator.SetActive(false);
            }
        }

        // ���� 2
        if (distance > 5650)
        {
            if (biom2shown == false && timerindikatora >= 2f)
            {
                superindicator.SetActive(true);
                timerindikatora -= Time.deltaTime;
                superindicator.transform.localPosition = Vector3.MoveTowards(superindicator.transform.localPosition, indicatorposition, skorostviezda);

            }
            else if (timerindikatora < 2f && timerindikatora > 0 && biom2shown == false)
            {
                timerindikatora -= Time.deltaTime;
                superindicator.transform.localPosition = Vector3.MoveTowards(superindicator.transform.localPosition, indicatordefaultposition, skorostviezda);
            }
            else if (timerindikatora <= 0f && biom2shown == false)
            {
                biom2shown = true;
                timerindikatora = 6f; // ��� ����� �����
                superindicator.SetActive(false);
            }
        }

        // ���� 3
        if (distance > 6700)
        {
            if (biom3shown == false && timerindikatora >= 2f)
            {
                superindicator.SetActive(true);
                timerindikatora -= Time.deltaTime;
                superindicator.transform.localPosition = Vector3.MoveTowards(superindicator.transform.localPosition, indicatorposition, skorostviezda);

            }
            else if (timerindikatora < 2f && timerindikatora > 0 && biom3shown == false)
            {
                timerindikatora -= Time.deltaTime;
                superindicator.transform.localPosition = Vector3.MoveTowards(superindicator.transform.localPosition, indicatordefaultposition, skorostviezda);
            }
            else if (timerindikatora <= 0f && biom3shown == false)
            {
                biom3shown = true;
                timerindikatora = 6f; // ��� ����� �����
                superindicator.SetActive(false);
            }
        }

        // ���� 4
        if (distance > 8520)
        {
            if (biom4shown == false && timerindikatora >= 2f)
            {
                superindicator.SetActive(true);
                timerindikatora -= Time.deltaTime;
                superindicator.transform.localPosition = Vector3.MoveTowards(superindicator.transform.localPosition, indicatorposition, skorostviezda);

            }
            else if (timerindikatora < 2f && timerindikatora > 0 && biom4shown == false)
            {
                timerindikatora -= Time.deltaTime;
                superindicator.transform.localPosition = Vector3.MoveTowards(superindicator.transform.localPosition, indicatordefaultposition, skorostviezda);
            }
            else if (timerindikatora <= 0f && biom4shown == false)
            {
                biom4shown = true;
                timerindikatora = 6f; // ��� ����� �����
                superindicator.SetActive(false);
            }
        }

        // ���� 5
        if (distance > 10550)
        {
            if (biom5shown == false && timerindikatora >= 2f)
            {
                superindicator.SetActive(true);
                timerindikatora -= Time.deltaTime;
                superindicator.transform.localPosition = Vector3.MoveTowards(superindicator.transform.localPosition, indicatorposition, skorostviezda);

            }
            else if (timerindikatora < 2f && timerindikatora > 0 && biom5shown == false)
            {
                timerindikatora -= Time.deltaTime;
                superindicator.transform.localPosition = Vector3.MoveTowards(superindicator.transform.localPosition, indicatordefaultposition, skorostviezda);
            }
            else if (timerindikatora <= 0f && biom5shown == false)
            {
                biom5shown = true;
                timerindikatora = 6f; // ��� ����� �����
                superindicator.SetActive(false);
            }
        }

        // ���� ������
        if (distance > 12150)
        {
            if (biom6shown == false && timerindikatora >= 2f)
            {
                superindicator.SetActive(true);
                timerindikatora -= Time.deltaTime;
                superindicator.transform.localPosition = Vector3.MoveTowards(superindicator.transform.localPosition, indicatorposition, skorostviezda);

            }
            else if (timerindikatora < 2f && timerindikatora > 0 && biom6shown == false)
            {
                timerindikatora -= Time.deltaTime;
                superindicator.transform.localPosition = Vector3.MoveTowards(superindicator.transform.localPosition, indicatordefaultposition, skorostviezda);
            }
            else if (timerindikatora <= 0f && biom5shown == false)
            {
                biom6shown = true;
                timerindikatora = 6f; // ��� ����� �����
                superindicator.SetActive(false);
            }
        }



        // ���� ��������� ��������
        if (distance > 12030)
        {
            
            if (played == false)
            {
                played = true;
                stones.Play(0);
                //subsuctedge.SetActive(true);
            }
            if (distance < 12200)
            {
                subsuctpartleft.transform.position = new Vector3(Mathf.Lerp(subsuctpartleft.transform.position.x, subsuctpartleft.transform.position.x - 5, 1 * Time.deltaTime), subsuctpartleft.transform.position.y, subsuctpartleft.transform.position.z);
                subsuctpartright.transform.position = new Vector3(Mathf.Lerp(subsuctpartright.transform.position.x, subsuctpartright.transform.position.x + 5, 1 * Time.deltaTime), subsuctpartright.transform.position.y, subsuctpartright.transform.position.z);
            }
        }
    }

}
