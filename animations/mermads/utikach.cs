using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class utikach : MonoBehaviour
{
    public float timer;
    public bool otschot;
    public bool pobeg;

    void Start()
    {
        timer = 10f;
    }

    void Update()
    {
        if (otschot && timer > 0) // ���� ���� ��� �������, ����� �������������
        {
            timer -= Time.deltaTime;
        }
        else if (otschot && timer <= 0) // ����� ���������
        {
            pobeg = true;
            otschot = false;
        }

        if(pobeg) // ��� �����
        {
            transform.position = new Vector3(transform.position.x, Mathf.Lerp(transform.position.y, transform.position.y - 10, 1 * Time.deltaTime), transform.position.z);
        }

    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            otschot = false; // �� ���� �������
        }

        if (other.CompareTag("Utikach"))
        {
            otschot = true; // �� ���� �������
        }

        if (other.CompareTag("Merman"))
        {
            DestroyObject(this);
        }

        
    }
}