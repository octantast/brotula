using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gganimation : MonoBehaviour
{
    public DistanceToCheckpoint distance;
    public PlayerController player;
    public BeforeDive beforer;
    public GenController gens;

    public GameObject head;
    public GameObject nek;
    public GameObject chest;
    public GameObject belly;
    public GameObject bedra;
    public GameObject legs;
    public GameObject shoulder;
    public GameObject arm;
    public GameObject shoulder2;
    public GameObject arm2;
    private Rigidbody2D rbhead;
    private Rigidbody2D rbnek;
    private Rigidbody2D rbchest;
    private Rigidbody2D rbbelly;
    private Rigidbody2D rbbedra;
    private Rigidbody2D rblegs;
    private Rigidbody2D rbshoulder;
    private Rigidbody2D rbarm;
    private Rigidbody2D rbshoulder2;
    private Rigidbody2D rbarm2;
    public float nekspeed;
    private float timer;
    public bool booldvizh;
    private bool onceset;

    [SerializeField] private Vector3 rotationChange;
    [SerializeField] private Vector3 positionChangey;
    private Vector2 positiongotova;
    private Vector2 nepositiongotova;
    private Quaternion anglegotova;
    private Quaternion neanglegotova;

    [SerializeField] private float kolebanie;
    [SerializeField] private float elozit;
    [SerializeField] private float balda;
    [SerializeField] private float telesa;
    [SerializeField] private bool ziklnogi;
    [SerializeField] private bool ziklruki;
    [SerializeField] private bool ziklbashki;
    [SerializeField] private bool zikltela;

    public GameObject fullbody;
    public GameObject headpart;
    public GameObject nekpart;
    public GameObject chestpart;
    public GameObject bellypart;
    public GameObject bedrapart;
    public GameObject legspart;
    public GameObject armpart;
    public GameObject shouldpart;
    public GameObject armpart2;
    public GameObject shouldpart2;

    // списки элементов для 2 режимов

    public GameObject headstart;
    public GameObject eyestart1;
    public GameObject eyestart2;
    public GameObject eyestart3;
    public GameObject chestswim;
    public GameObject bellyswim;
    public GameObject bedraswim;
    public GameObject legsswim;
    public GameObject leftarmswim;
    public GameObject leftshswim;
    public GameObject rightarmswim;
    public GameObject rightshswim;

    public GameObject leftarmswimpedic1;
    public GameObject leftarmswimpedic2;
    public GameObject leftarmswimpedic3;
    public GameObject rightarmswimcirr1;
    public GameObject rightarmswimcirr2;
    public GameObject rightarmswimcirr3;
    public GameObject legsswimfins12;
    public GameObject legsswimfins3;
    public GameObject electrobashka1;
    public GameObject electrobashka123;
    public GameObject hydroorbaska;
    public GameObject hemobaska1;
    public GameObject hemobaska2;
    public GameObject hemobaska3;
    public GameObject hemobaska3swim;
    public GameObject mechabaska1;
    public GameObject mechabaska2;
    public GameObject mechabaska3;
    public GameObject headpancer12;
    public GameObject headpancer3;
    public GameObject zuby1;
    public GameObject zuby2;
    public GameObject zuby3;
    public GameObject sliz1;
    public GameObject sliz2;
    public GameObject sliz3;
    public GameObject lumini1;
    public GameObject lumini2;
    public GameObject lumini3;
    // грудь, заплыв
    public GameObject chestpancer12;
    public GameObject chestpancer3;
    public GameObject chestsliz12;
    public GameObject chestsliz3;
    public GameObject chestmechano12;
    public GameObject chestmechano3;
    // пузо заплыв
    public GameObject bellypancer12;
    public GameObject bellypancer3;
    public GameObject bellysliz12;
    public GameObject bellysliz3;
    public GameObject bellymechano3;
    // бёдра заплыв
    public GameObject bedrapancer12;
    public GameObject bedrapancer3;
    public GameObject bedrasliz12;
    public GameObject bedrasliz3;
    public GameObject bedrafins12;
    public GameObject bedrafins3;
    // щупальца заплыв
    public GameObject prisoski2;
    public GameObject prisoski2left;
    public GameObject prisoski3;
    public GameObject prisoski3left;
    // плечо заплыв
    public GameObject shoulderpancer12;
    public GameObject shoulderpancer3;
    public GameObject shouldersliz12;
    public GameObject shouldersliz3;
    public GameObject shoulderfins3;
    public GameObject rightshoulderpancer12;
    public GameObject rightshoulderpancer3;
    public GameObject rightshouldersliz12;
    public GameObject rightshouldersliz3;
    public GameObject rightshoulderfins3;

    // общие подкладки
    public GameObject polost1;
    public GameObject polost2;
    public GameObject polost3;
    public GameObject zhir1;
    public GameObject zhir2;
    public GameObject zhir3;

    // шея
    public GameObject nekhydropora;
    public GameObject nekstart;
    public GameObject nekpancer12;
    public GameObject nekpancer3;
    public GameObject neksliz12;
    public GameObject neksliz3;

    // грудь
    public GameObject seccheststart;
    public GameObject secchestpancer12;
    public GameObject secchestpancer3;
    public GameObject secchestsliz12;
    public GameObject secchestsliz3;

    // пузо
    public GameObject bellystart;
    public GameObject bellychesh12;
    public GameObject bellychesh3;
    public GameObject chern1;
    public GameObject chern2;
    public GameObject chern3;
    public GameObject evisc1;
    public GameObject evisc2;
    public GameObject evisc3;
    public GameObject kuvier12;
    public GameObject kuvier3;
    public GameObject bellystartsliz12;
    public GameObject bellystartneksliz3;

    // жопа
    public GameObject bedrastart;
    public GameObject startbedrachesh12;
    public GameObject startbedrachesh3;
    public GameObject startbedrasliz12;
    public GameObject startbedrasliz3;
    public GameObject startbedrafins12;
    public GameObject startbedrafins3;

    // хвост
    public GameObject legsstart;
    public GameObject legsstartfins12;
    public GameObject legsstartfins3;
    public GameObject startprisoski2;
    public GameObject startprisoski2left;
    public GameObject startprisoski3;
    public GameObject startprisoski3left;

    // плечи старт
    public GameObject shoulderstart;
    public GameObject shoulderstart2;
    public GameObject startshoulderpancer12;
    public GameObject startshoulderpancer3;
    public GameObject startshouldersliz12;
    public GameObject startshouldersliz3;
    public GameObject startrightshoulderpancer12;
    public GameObject startrightshoulderpancer3;
    public GameObject startrightshouldersliz12;
    public GameObject startrightshouldersliz3;

    // руки
    public GameObject righthandstart;
    public GameObject lefthandstart;
    public GameObject rightarmpedic1;
    public GameObject rightarmpedic2;
    public GameObject rightarmpedic3;
    public GameObject leftarmcirr1;
    public GameObject leftarmcirr2;
    public GameObject leftarmcirr3;

    // наросты
    public GameObject ringwohead;
    public GameObject ringwoarm;
    public GameObject ringwodown;

    public List<Renderer> renderList; // список рендеров для смены цвета
    public List<Renderer> renderListProzrachno;

    // Start is called before the first frame update
    void Start()
    {
        rbhead = head.GetComponent<Rigidbody2D>();
        rbnek = nek.GetComponent<Rigidbody2D>();
        rbchest = chest.GetComponent<Rigidbody2D>();
        rbbelly = belly.GetComponent<Rigidbody2D>();
        rbbedra = bedra.GetComponent<Rigidbody2D>();
        rblegs = legs.GetComponent<Rigidbody2D>();
        rbshoulder = shoulder.GetComponent<Rigidbody2D>();
        rbarm = arm.GetComponent<Rigidbody2D>();
        rbshoulder2 = shoulder2.GetComponent<Rigidbody2D>();
        rbarm2 = arm2.GetComponent<Rigidbody2D>();
        kolebanie = 0f;
        elozit = 1f;
        balda = 0f;

    }

    // Update is called once per frame
    void Update()
    {
        // движение вниз
        


        // вращение ног
        if (kolebanie < 2.1f && ziklnogi == false)
        {
            kolebanie += Time.deltaTime;
        }
        else
        {
            ziklnogi = true;
        }
        if (kolebanie > -2.1f && ziklnogi)
        {

            kolebanie -= Time.deltaTime;
        }
        else
        {
            ziklnogi = false;
        }
        rblegs.transform.localEulerAngles = new Vector3(0f, 0f, kolebanie * 0.35f);
        rbbedra.transform.localEulerAngles = new Vector3(0f, 0f, kolebanie * -0.6f);

        // движение рук
        if (elozit < 4f && ziklruki == false)
        {
            elozit += Time.deltaTime * 1.5f;
        }
        else
        {
            ziklruki = true;
        }
        if (elozit > -4f && ziklruki)
        {

            elozit -= Time.deltaTime;
        }
        else
        {
            ziklruki = false;
        }

        rbshoulder.transform.localEulerAngles = new Vector3(0f, 0f, elozit);
        rbshoulder2.transform.localEulerAngles = new Vector3(0f, 0f, elozit * -1f);
        rbarm.transform.localEulerAngles = new Vector3(0f, 0f, elozit * 2f);
        rbarm2.transform.localEulerAngles = new Vector3(0f, 0f, elozit * -2f);

        // движение башки

        if (balda < 0.3f && ziklbashki == false)
        {
            balda += Time.deltaTime * 0.2f;
        }
        else if (ziklbashki == false)
        {
            ziklbashki = true;
            timer = 5f;
        }
        if (balda > -0.5f && ziklbashki)
        {
            balda -= Time.deltaTime * 0.2f;
        }
        else
        {
            ziklbashki = false;
        }
        if (timer > 0f)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            timer = 0f;
            head.transform.position = new Vector3(head.transform.position.x, Mathf.Lerp(head.transform.position.y, head.transform.position.y - balda, 0.3f * Time.deltaTime), head.transform.position.z);
            nek.transform.position = new Vector3(nek.transform.position.x, Mathf.Lerp(nek.transform.position.y, nek.transform.position.y - balda, 0.2f * Time.deltaTime), nek.transform.position.z);
            chest.transform.position = new Vector3(chest.transform.position.x, Mathf.Lerp(chest.transform.position.y, chest.transform.position.y - balda, 0.1f * Time.deltaTime), chest.transform.position.z);
        }

        //if (distance.distance > 12650 && onceset == false)
        //{
          //  onceset = true;
            //ringwoarm.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 0);
            //ringwodown.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 0);
        //}

        if (gens.pMimicria > 1)
        {

            if (distance.distance > 12150 && distance.distance < 12600) // мимикрирует в белый
            {

                foreach (Renderer tempObject in renderList)
                {
                    tempObject.material.color = Color.Lerp(tempObject.material.color, new Color32(255, 255, 255, 255), Time.deltaTime / 10f);
                }
            }
            else if (distance.distance <= 12150)
            {
                float lerp = Mathf.PingPong(Time.time, beforer.duration) / beforer.duration;
                foreach (Renderer tempObject in renderList)
                {
                    tempObject.material.color = Color.Lerp(beforer.ggcolorfortransp, beforer.colorEnd, lerp);
                }
            }
            

            
        }
        

    }
}
