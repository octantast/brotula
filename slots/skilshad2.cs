using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skilshad2 : MonoBehaviour
{

    [SerializeField] private Transform currentParrent;
    [SerializeField] private Vector2 shadowmotherplace;
    [SerializeField] private Vector2 stupidmotherplace;
    [SerializeField] private GameObject shadownottransp;
    [SerializeField] private GameObject podsvetSkila;

    public Collider2D parents;

    private bool triggeredskill;
    private bool chek;

    // Start is called before the first frame update
    void Start()
    {
        stupidmotherplace = new Vector2(transform.position.x, transform.position.y);
        shadowmotherplace = new Vector2(transform.localPosition.x, transform.localPosition.y);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localPosition.x != 0f && shadownottransp.activeSelf == true) // ���� ����� �� ����, � �� �����
        {
            transform.position = stupidmotherplace;
        }

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    chek = false;
                    if (parents.bounds.Contains(touch.position)) // ���� ��� ������� ������ ��� ������
                    {
                        triggeredskill = false;
                    }
                    else // ���� �������� ������ �����
                    {
                        triggeredskill = true;
                    }
                    break;
                case TouchPhase.Ended:
                    chek = true;
                    break;
            }
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        //if (other.CompareTag("Bloker") && shadownottransp.activeSelf == true)
        // {
        //     transform.position = stupidmotherplace;
        // }

        // ���� ������������ ���� - ����� ����� + ���� ���� ��������� ��������
        if (shadownottransp.activeSelf == true && podsvetSkila.activeSelf == true) // ���� ����� � �����, � ������, �� ����������
        {
            if (other.CompareTag("Skill") && transform.localPosition.y != 0f) // �� ������������
            {
                other.transform.position = stupidmotherplace;
            }
        }
        // �� �� ����� ���� ���� �������� ��� ������ � ������ ������ �������� ������� ������ (�� ���� ������ ����� ���� �� �������, �� ��� ���������)
        if (chek && triggeredskill && shadownottransp.activeSelf == true && podsvetSkila.activeSelf == false)
        {
            if (other.CompareTag("Skill") && transform.localPosition.y != 0f) // �� ������������
            {
                other.transform.position = stupidmotherplace;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("kolonka") && transform.localPosition.x != 0f)
        {
            currentParrent.transform.position = transform.position;
        }

       // if (other.CompareTag("Bloker") && shadownottransp.activeSelf == true)
      //  {
         //   transform.position = stupidmotherplace;
       // }
    }


}
