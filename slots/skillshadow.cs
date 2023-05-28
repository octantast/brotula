using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skillshadow : MonoBehaviour
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
    [SerializeField] private Transform currentParrent;
    [SerializeField] private Transform currentParrentOfParent;
    [SerializeField] private Transform currentStaticParent;
    [SerializeField] private Transform currentKolonkaParentFinal;
    [SerializeField] private GameObject podsvetSkila;
    [SerializeField] private GameObject decryptSkila;
    [SerializeField] private Transform currentpromezhutochnyyParrent;
    [SerializeField] private Transform currentpromezhutochnyyParrent2;

    [SerializeField] private GameObject skillsBack;
    [SerializeField] private GameObject skillsBackChild;
     private bool beganByl;
    [SerializeField] private Vector3 scaleChange;
    private bool sizenormie;
    private Vector3 sizeNormie;
    [SerializeField] private GameObject meinBlok;
    [SerializeField] private GameObject shadow;
    [SerializeField] private GameObject shadownottransp;
    [SerializeField] private Vector2 shadowmotherplace;

    [SerializeField] private GameObject slot4;
    [SerializeField] private GameObject slot6;
    [SerializeField] private GameObject slot4trigger;
    [SerializeField] private GameObject slot6trigger;

    public Collider2D colliderofthis;
    public Collider2D colliderofcolumn;

    void Start()
    {
        

        shadowmotherplace = new Vector2(shadow.transform.localPosition.x, shadow.transform.localPosition.y); // ������ ����� ������
        decryptSkila.SetActive(true);
        podsvetSkila.SetActive(false);
        sizeNormie = new Vector3(1f, 1f, 0f);
        
        newslotplace = new Vector2(transform.position.x, transform.position.y);
        fixedplace = new Vector2(transform.position.x, transform.position.y);
        stupidmotherplace = new Vector2(transform.position.x, transform.position.y); // ������������� ���������� ������ ����� ����� ����� � �������
        motherplace = new Vector2(transform.localPosition.x, transform.localPosition.y);
        timer = 0.6f;
        scaleChange = new Vector3(0.01f, 0.01f, 0f);
        shadownottransp.SetActive(false);
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
                shadow.transform.localScale = Vector3.Lerp(shadow.transform.localScale, new Vector2(0.7f, 0.7f), 0.05f);
            }
            else
            {
                sizenormie = false;
            }

        }

        // ������
        //if (skillsBack != null && skillsBack.activeSelf == false && transform.position.x != newslotplace.x)
        //{
         //   transform.SetParent(currentParrent);
          //  transform.localPosition = motherplace;
        //}

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
                            shadownottransp.SetActive(false);
                            triggeredskill = false; // ��� �� ��������� �����
                            podsvetSkila.SetActive(true); // ���� ����� ���������
                            newslotplace = new Vector2(transform.position.x, transform.position.y); // ����� �������� - ������ �����
                            fixedplace = newslotplace; // ������������� ����� - ������ �����
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
                    shadownottransp.SetActive(true);
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

            if(podsvetSkila.activeSelf == false && transform.parent == currentParrent && transform.localPosition.x != 0) // ���� �� ������ ����� ����� � �������
            {
                transform.localPosition = motherplace;
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
                shadow.transform.localScale -= scaleChange;
            }
        }
        else if (other.CompareTag("Sizerrr2"))
        {
            if (transform.localScale.y > 0.85f)
            {
                transform.localScale -= scaleChange;
                shadow.transform.localScale += scaleChange;
            }
        }
        // ������
        if (skillsBack != null && skillsBack.activeSelf == false) // ���� ���� �����
        {
            if (other.CompareTag("kolonka"))
            {
                transform.SetParent(currentParrent);
                transform.localPosition = motherplace;
            }
        }

        // ���� ����� �������� ������� � ��������� �����, �� �� ������������ �����
        //if (other.CompareTag("Bloker") && podsvetSkila.activeSelf == false)
        //{
        //    transform.SetParent(currentParrent);
        //    transform.localPosition = motherplace;
        //}

        if (skillsBack != null && skillsBack.activeSelf == true)
        {
            // ���� ����� �������� ������� � ��������� �����, �� �� ������������ �� ���� �������
            //if (other.CompareTag("Bloker") && (Input.touchCount <= 0 || podsvetSkila.activeSelf == false))
           // {
           //     transform.position = fixedplace;
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
                    shadownottransp.SetActive(false);
                    shadow.transform.localPosition = shadowmotherplace;
                    
                }
                else if (Input.touchCount <= 0 && triggeredskill == false && podsvetSkila.activeSelf == true) // ���� ���� ����� ��������
                {
                    transform.SetParent(currentParrent);
                    transform.localPosition = motherplace;
                    shadownottransp.SetActive(false);
                    shadow.transform.localPosition = shadowmotherplace;
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
                        // ������ ������ ����� ������������ �������� ������������ �����?
                        shadownottransp.SetActive(true);
                        other.transform.position = stupidmotherplace; // ������ ��������� ����� �� ���� ������, �. �. ������� � ����
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

        if (podsvetSkila.activeSelf == true && Input.touchCount > 0) // ���� ���� ����� ���������
        {
            // ��������� ����� �����, �� ������� ��������
            if (other.name == "triggersvet4")
            {
                shadow.transform.localPosition = new Vector2(-300f, 0f);
            }

            if (other.name == "triggersvet6")
            {
                shadow.transform.localPosition = new Vector2(300f, 0f);
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

        if (podsvetSkila.activeSelf == true && Input.touchCount > 0 && slot4trigger.activeSelf == true) // ���� ���� ����� ���������
        {
            // ��������� ����� �����, �� ������� ��������
            if (other.name == "triggersvet4")
            {
                shadownottransp.SetActive(false);
                shadow.transform.localPosition = shadowmotherplace;
            }

            if (other.name == "triggersvet6")
            {
                shadownottransp.SetActive(false);
                shadow.transform.localPosition = shadowmotherplace;
            }

            if (other.CompareTag("SlotCanvas")) // ���� ������� �� ������� ������, �� �� ������� �� ���� �������
            {
                shadownottransp.SetActive(false);
                shadow.transform.localPosition = shadowmotherplace;
            }
        }
       

    }

    // ���� ������ � ���� �������� � ��� ���������
    private void OnTriggerEnter2D(Collider2D other)
    {


        if (skillsBack != null && skillsBack.activeSelf == true)
        {
            if (other.CompareTag("kolonka")) // ���� ������ � ������� ������� ����� �������, �� �� ������� �� ������ �����
            {
                newslotplace = stupidmotherplace;
                shadownottransp.SetActive(false);
                shadow.transform.localPosition = shadowmotherplace;
            }

            if (podsvetSkila.activeSelf == true && Input.touchCount > 0) // ���� ���� ����� ���������
            {
                // ��������� ����� �����, �� ������� ��������
                if (other.name == "triggersvet4")
                {
                    newslotplace = new Vector2(other.transform.position.x, other.transform.position.y);
                    shadow.transform.localPosition = new Vector2(-300f, 0f);
                }
                
                if (other.name == "triggersvet6")
                {
                    newslotplace = new Vector2(other.transform.position.x, other.transform.position.y);
                    shadow.transform.localPosition = new Vector2(300f, 0f);
                }

                if (other.CompareTag("SlotCanvas")) // ���� ������� �� ������� ������, �� �� ������� �� ���� �������
                {
                    newslotplace = fixedplace;
                }
            }

        }
    }

}
