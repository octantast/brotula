using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skilldragdrop : MonoBehaviour
{
    [SerializeField] private bool waitforothers = false;
    [SerializeField] private float timer;
    [SerializeField] private bool thereisashield = false;
    [SerializeField] private bool triggeredskill = false;
    [SerializeField] private Vector2 wherefinger; // ����� ������� ������
    [SerializeField] private Vector2 fixedplace;// ��������� ����� ������, ������� �� ��������
    [SerializeField] private Vector2 newslotplace;// ��������� ����� ������
    [SerializeField] private Vector2 motherplace; // ��������� ����� ������ � ��������, ��������������� ��� ������ (����� �������)
    [SerializeField] private Vector2 stupidmotherplace;
    [SerializeField] private Vector2 currentposition;
    [SerializeField] private Transform currentpromezhutochnyyParrent;
    [SerializeField] private Transform currentpromezhutochnyyParrent2;
    [SerializeField] private Transform currentParrent;
    [SerializeField] private Transform currentParrentOfParent;
    [SerializeField] private Transform currentStaticParent;
    [SerializeField] private Transform currentKolonkaParentFinal;
    [SerializeField] private GameObject podsvetSkila;
    [SerializeField] private GameObject decryptSkila;

    [SerializeField] private GameObject skillsBack;
    [SerializeField] private GameObject skillsBackChild;
    [SerializeField] private bool beganByl;
    [SerializeField] private Vector3 scaleChange;
    private bool sizenormie;
    private Vector3 sizeNormie;
    [SerializeField] private GameObject meinBlok;

    public Collider2D colliderofthis;
    public Collider2D colliderofcolumn;

    void Start()
    {
       
        decryptSkila.SetActive(true);
        podsvetSkila.SetActive(false);
        sizeNormie = new Vector3(1f, 1f, 0f);
        newslotplace = new Vector2(transform.position.x, transform.position.y);
        fixedplace = new Vector2(transform.position.x, transform.position.y);
        stupidmotherplace = new Vector2(transform.position.x, transform.position.y); // ������������� ���������� ������ ����� ����� ����� � �������
        motherplace = new Vector2(transform.localPosition.x, transform.localPosition.y);
        timer = 0.6f;
        scaleChange = new Vector3(0.01f, 0.01f, 0f);
    }

    // Update is called once per frame
    void Update()
    {

        if (skillsBack.activeSelf == false) // ���� ����� ���
        {
            decryptSkila.SetActive(false); // �������� �� �����
            triggeredskill = false; // ��� �� ��������� �����
            podsvetSkila.SetActive(false); // ���� ����� �� ���������
        }

        if (sizenormie) // ��� ������ ������� ������ ��� ���������� ������
        {
            if (transform.localScale != sizeNormie)
            {
                transform.localScale = Vector3.Lerp(transform.localScale, sizeNormie, 0.05f);
            }
            else
            {
                sizenormie = false;
            }

        }

        // ����� ������� ������, ���� ������� ������
        if (skillsBack.activeSelf == true)
        {
            
            decryptSkila.SetActive(true);
            if (Input.touchCount > 0 && waitforothers == false && skillsBackChild.activeSelf == false) // ���� ������� ��� � �� ��������� �����
            {
                Touch touch = Input.GetTouch(0);
                Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
                switch (touch.phase)
                {
                    case TouchPhase.Began:
                        
                        thereisashield = false; // ��������� ���, ����� ��������� ��� ������
                        if (colliderofthis.bounds.Contains(touch.position)) // ���� ��� ������� ������ ������
                        {
                            triggeredskill = false; // ��� �� ��������� �����
                            podsvetSkila.SetActive(true); // ���� ����� ���������
                            newslotplace = new Vector2(transform.position.x, transform.position.y); // ����� �������� - ������ �����
                            fixedplace = newslotplace; // ������������� ����� - ������ �����
                            // rb.velocity = new Vector2(0, 0);
                        }
                        else // ���� �������� ������ �����
                        {
                            podsvetSkila.SetActive(false); // ���� ����� �� ��������� ���
                            triggeredskill = true; // ��� ��������� �����
                            fixedplace = new Vector2(transform.position.x, transform.position.y);
                        }
                        // ��� ������� ������ �������
                        if (colliderofcolumn.bounds.Contains(touch.position))
                        {
                            timer -= Time.deltaTime; // ���� ��, ������� ����� ����� ������
                        }
                        else
                        {
                            timer = -0.1f; // ���� ���, ������� ����� �����
                        }
                        break;
                    case TouchPhase.Moved:
                        // ������� ���� � �������
                        if (colliderofcolumn.bounds.Contains(touch.position))
                        {
                        }
                        else
                        {
                            timer = -0.1f; // ������� �����
                        }
                        if (timer < 0)
                        {
                            if (podsvetSkila.activeSelf == true && meinBlok.activeSelf == false) // ���� ���� ����� ��������� ������� � �� ������������
                            {
                                wherefinger = new Vector2(touch.position.x, touch.position.y); // ������, ��� �����
                                transform.position = wherefinger;// ������� ������ ����� � ������
                            }
                            if (triggeredskill && thereisashield == true) // ���� ������� ���, �� �������� ���������� �������� �� �����
                            {
                                triggeredskill = false;
                            }
                            else if (triggeredskill && thereisashield == false) // ���� ��� ����, �� ����� ����� ���� �����
                            {
                                triggeredskill = true;
                            }
                        }
                        break;
                    case TouchPhase.Ended:
                        timer = 0.6f;
                        thereisashield = true; // �������� ��� � ��������� �����, ����� ��� ������� �������� �� �� ��� �� ������
                        break;
                }
            }

            if (Input.touchCount <= 0 && podsvetSkila.activeSelf == true) // ���� �������� ���������� ������ �����������, �� ������ �� ���������
            {
                waitforothers = true; // �����, ����� ������ ����� ��������

                // ���� �� � ����������� �������
                if (transform.parent == currentParrent)
                {
                    transform.localPosition = motherplace;
                    currentposition = new Vector2(transform.localPosition.x, transform.localPosition.y); // ������, ������� �� ����� �� ����� ��������
                    if (motherplace == currentposition)
                    {
                        waitforothers = false;
                    }
                }
                // ���� ���
                else
                {
                    transform.position = newslotplace; // �������� � ����� ��������
                    currentposition = new Vector2(transform.position.x, transform.position.y); // ������, ������� �� ����� �� ����� ��������
                    if (newslotplace == currentposition)
                    {
                        waitforothers = false;
                    }
                }
            }
            else if (Input.touchCount <= 0 && triggeredskill)
            {
                currentposition = new Vector2(transform.position.x, transform.position.y);
            }
        }

    }



    private void OnTriggerStay2D(Collider2D other)
    {

        // ��� ��� ���������� � ���������� ��� ���� � ������ �������
        if (other.CompareTag("Sizerrr"))
        {
            if (transform.localScale.y < 1.15f)
            {
                transform.localScale += scaleChange;
            }
        }
        else if (other.CompareTag("Sizerrr2"))
        {
            if (transform.localScale.y > 0.85f)
            {
                transform.localScale -= scaleChange;
            }
        }


        // ���� ����� �������� ������� � ��������� �����, �� �� ������������ �����, ��� ���� ���������������� ������
       // if (other.CompareTag("Bloker") && podsvetSkila.activeSelf == false)
      //  {
         //   transform.SetParent(currentParrent);
       //     transform.localPosition = motherplace;
       // }


        // ������
        if (skillsBack != null && skillsBack.activeSelf == false) // ���� ���� �����
        {
            if (other.CompareTag("kolonka"))
            {
                transform.SetParent(currentParrent);
                transform.localPosition = motherplace;
            }
        }

        if (skillsBack != null && skillsBack.activeSelf == true)
        {
            // ���� ����� �������� ������� � ��������� �����, �� �� ������������ �� ���� �������, ��� ���� ���������������� ������
            //if (other.CompareTag("Bloker") && (Input.touchCount <= 0 || podsvetSkila.activeSelf == false))
            //{
            //    transform.position = fixedplace;
            //}

            if (other.CompareTag("SlotTrigger")) // ���� ����� ����� � ����� � �� �������� ������� ������, �� � ���� �������� ��������
            {
                if (other.CompareTag("Skill"))
                {
                }
                else
                {
                    transform.SetParent(currentStaticParent);
                }
            }

            // ���� ����� ����� � �������
            if (other.CompareTag("kolonka"))
            {
                if (triggeredskill && podsvetSkila.activeSelf == false) // ���� ��� ���������� �����, �� ��� ������ ������ � ��������
                {
                    thereisashield = true;
                    transform.SetParent(currentParrent);
                    transform.localPosition = motherplace;

                }
                else if (Input.touchCount <= 0 && triggeredskill == false && podsvetSkila.activeSelf == true) // ���� ���� ����� ��������
                {
                    transform.SetParent(currentParrent);
                    transform.localPosition = motherplace;
                }
            }

            // ���� �� ��������� � �������� ������
            if (transform.parent == currentStaticParent)

            {

                // ���� ���� ����� ���������
                if (other.CompareTag("Skill") && Input.touchCount <= 0 && triggeredskill == false && podsvetSkila.activeSelf == true)
                {
                    currentposition = new Vector2(transform.position.x, transform.position.y);
                    if (currentposition == newslotplace) // ���� �� ������ ��� ���������, ����� �� ���� � �������� ������ ����� � ��������� �����, �� �� ��������� �� ��� ������
                    {
                        other.transform.position = fixedplace; // ������ ��������� ����� �� ���� ������
                                                               // ���� ����� ������
                    }
                }

                // ���� ���� ����� �����, �� ����� �������� �� ��� ������������ � ������, �� ������� �� ���� ������
                // ����� ����� �� �� ��������� ������� ��������������, � ������ � ��������� ����� (���� ��� �������� �����?)
                if (other.CompareTag("Skill") && Input.touchCount <= 0 && triggeredskill && podsvetSkila.activeSelf == false && currentposition != fixedplace) // ���� ������ ��������� � ���� �� ��� �� �������
                {
                    transform.position = fixedplace; // ������ ��������� ����� �� ���� ������
                                                     // ��� �� �������� �����
                }

            }
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (skillsBack != null && skillsBack.activeSelf == true)
        {
            if (other.CompareTag("kolonka")) // ���� ����� �� �������, ������ ������ ����� �����������
            {
                thereisashield = false;
                transform.localScale = new Vector3(1f, 1f, 0f);
            }
        }
        if (other.CompareTag("Sizerrr2") || other.CompareTag("Sizerrr"))
        {
            sizenormie = true;
        }
    }

    // ���� ������ � ���� �������� � ��� ���������
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (skillsBack.activeSelf == true)
        {
            if (other.CompareTag("kolonka")) // ���� ������ � ������� ������� ����� �������, �� �� ������� �� ������ �����
            {
                newslotplace = stupidmotherplace;
            }

            if (podsvetSkila.activeSelf == true && Input.touchCount > 0) // ���� ���� ����� ���������
            {
                if (other.CompareTag("SlotCanvas")) // ���� ������� �� ������� ������, �� �� ������� �� ���� �������
                {
                    newslotplace = fixedplace;
                }

                // ��������� ����� �����, �� ������� ��������
                if (other.name == "triggersvet1")
                {
                    newslotplace = new Vector2(other.transform.position.x, other.transform.position.y);
                }
                if (other.name == "triggersvet2")
                {
                    newslotplace = new Vector2(other.transform.position.x, other.transform.position.y);
                }
                if (other.name == "triggersvet3")
                {
                    newslotplace = new Vector2(other.transform.position.x, other.transform.position.y);
                }
                if (other.name == "triggersvet4")
                {
                    newslotplace = new Vector2(other.transform.position.x, other.transform.position.y);
                }
                if (other.name == "triggersvet5")
                {
                    newslotplace = new Vector2(other.transform.position.x, other.transform.position.y);
                }
                if (other.name == "triggersvet6")
                {
                    newslotplace = new Vector2(other.transform.position.x, other.transform.position.y);
                }
                if (other.name == "triggersvet7")
                {
                    newslotplace = new Vector2(other.transform.position.x, other.transform.position.y);
                }
                if (other.name == "triggersvet8")
                {
                    newslotplace = new Vector2(other.transform.position.x, other.transform.position.y);
                }
                if (other.name == "triggersvet9")
                {
                    newslotplace = new Vector2(other.transform.position.x, other.transform.position.y);
                }


            }

        }
    }

}
