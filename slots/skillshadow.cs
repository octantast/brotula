using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skillshadow : MonoBehaviour
{

    [SerializeField] private bool waitforothers = false;
    [SerializeField] private float timer;
    [SerializeField] private bool thereisashield = false;
    [SerializeField] private bool triggeredskill = false;
    [SerializeField] private Vector2 wherefinger; // место касания пальца
    [SerializeField] private Vector2 fixedplace;// начальная точка навыка, котоаря не меняется
    [SerializeField] private Vector2 newslotplace;// начальная точка навыка
    [SerializeField] private Vector2 motherplace; // начальная точка навыка в магазине, устанавливается при спавне (смене фильтра)
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
        

        shadowmotherplace = new Vector2(shadow.transform.localPosition.x, shadow.transform.localPosition.y); // родное место навыка
        decryptSkila.SetActive(true);
        podsvetSkila.SetActive(false);
        sizeNormie = new Vector3(1f, 1f, 0f);
        
        newslotplace = new Vector2(transform.position.x, transform.position.y);
        fixedplace = new Vector2(transform.position.x, transform.position.y);
        stupidmotherplace = new Vector2(transform.position.x, transform.position.y); // фиксированный мазерплейс просто чтобы навык вошёл в колонку
        motherplace = new Vector2(transform.localPosition.x, transform.localPosition.y);
        timer = 0.6f;
        scaleChange = new Vector3(0.01f, 0.01f, 0f);
        shadownottransp.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (skillsBack.activeSelf == false) // если режим боя
        {
            decryptSkila.SetActive(false); // описаний не видно
            triggeredskill = false; // это не зависимый навык
            podsvetSkila.SetActive(false); // этот навык не двигается
        }

        if (sizenormie) // был запрос вернуть скиллу его нормальный размер
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

        // апдейт
        //if (skillsBack != null && skillsBack.activeSelf == false && transform.position.x != newslotplace.x)
        //{
         //   transform.SetParent(currentParrent);
          //  transform.localPosition = motherplace;
        //}

        // любые реакции только, если открыты скиллз
        if (skillsBack.activeSelf == true)
        {

            decryptSkila.SetActive(true);
            if (Input.touchCount > 0 && waitforothers == false && skillsBackChild.activeSelf == false) // если начался тап и всё прочитано снизу
            {
                Touch touch = Input.GetTouch(0);
                Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
                switch (touch.phase)
                {
                    case TouchPhase.Began:

                        thereisashield = false; // отключает щит, чтобы прочитать его заново
                        if (colliderofthis.bounds.Contains(touch.position)) // если тап начался внутри навыка
                        {
                            shadownottransp.SetActive(false);
                            triggeredskill = false; // это не зависимый навык
                            podsvetSkila.SetActive(true); // этот навык дивгается
                            newslotplace = new Vector2(transform.position.x, transform.position.y); // точка возврата - откуда взяли
                            fixedplace = newslotplace; // фиксированная точка - откуда взяли
                        }
                        else // если тапается другой навык
                        {
                            podsvetSkila.SetActive(false); // этот навык не двигается сам
                            triggeredskill = true; // это зависимый навык
                            fixedplace = new Vector2(transform.position.x, transform.position.y);
                        }
                        // тап начался внутри колонки
                        if (colliderofcolumn.bounds.Contains(touch.position))
                        {
                            timer -= Time.deltaTime; // если да, реакция будет после свайпа
                        }
                        else
                        {
                            timer = -0.1f; // если нет, реакция будет сразу
                        }
                        break;
                    case TouchPhase.Moved:
                        // текущие тапы в колонке
                        if (colliderofcolumn.bounds.Contains(touch.position))
                        {
                        }
                        else
                        {
                            timer = -0.1f; // реакция сразу
                        }
                        if (timer < 0)
                        {
                            if (podsvetSkila.activeSelf == true && meinBlok.activeSelf == false) // если этот навык двигается пальцем и не заблокирован
                            {
                                wherefinger = new Vector2(touch.position.x, touch.position.y); // читает, где палец
                                transform.position = wherefinger;// двигает взятый навык к пальцу
                            }
                            if (triggeredskill && thereisashield == true) // если включён щит, то никакого зависимого движения не будет
                            {
                                triggeredskill = false;
                            }
                            else if (triggeredskill && thereisashield == false) // если нет щита, то навык может быть задет
                            {
                                triggeredskill = true;
                            }
                        }
                        break;
                    case TouchPhase.Ended:
                        timer = 0.6f;
                        thereisashield = true; // надевает щит в состоянии покоя, чтобы при отпуске движение ни на что не влияло
                        break;
                }
            }

            if (Input.touchCount <= 0 && podsvetSkila.activeSelf == true) // если движение выбранного навыка закончилось, то только он смещается
            {
                waitforothers = true; // нужно, чтобы именно после движения

                // если он в материнской колонке
                if (transform.parent == currentParrent)
                {
                    transform.localPosition = motherplace;
                    currentposition = new Vector2(transform.localPosition.x, transform.localPosition.y); // читаем, приехал ли навык на точку возврата
                    if (motherplace == currentposition)
                    {
                        waitforothers = false;
                    }
                }
                // если нет
                else
                {
                    shadownottransp.SetActive(true);
                    transform.position = newslotplace; // движение к точке возврата
                    currentposition = new Vector2(transform.position.x, transform.position.y); // читаем, приехал ли навык на точку возврата
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

            if(podsvetSkila.activeSelf == false && transform.parent == currentParrent && transform.localPosition.x != 0) // если он просто криво стоит в колонке
            {
                transform.localPosition = motherplace;
            }
        }

    }



    private void OnTriggerStay2D(Collider2D other)
    {

        // тут код увеличения и уменьшения при стей в центре колонки
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
        // апдейт
        if (skillsBack != null && skillsBack.activeSelf == false) // если чето выпал
        {
            if (other.CompareTag("kolonka"))
            {
                transform.SetParent(currentParrent);
                transform.localPosition = motherplace;
            }
        }

        // если навык касается блокера в состоянии покоя, то он возвращается домой
        //if (other.CompareTag("Bloker") && podsvetSkila.activeSelf == false)
        //{
        //    transform.SetParent(currentParrent);
        //    transform.localPosition = motherplace;
        //}

        if (skillsBack != null && skillsBack.activeSelf == true)
        {
            // если навык касается блокера в состоянии покоя, то он возвращается на фикс позицию
            //if (other.CompareTag("Bloker") && (Input.touchCount <= 0 || podsvetSkila.activeSelf == false))
           // {
           //     transform.position = fixedplace;
            //}

            if (other.CompareTag("SlotTrigger")) // если навык стоит в слоте и не касается другого навыка, то у него меняется родитель
            {
                if (other.CompareTag("Skill"))
                {
                }
                else
                {
                    transform.SetParent(currentStaticParent);
                }
            }

            // если навык стоит в колонке
            if (other.CompareTag("kolonka"))
            {
                if (triggeredskill && podsvetSkila.activeSelf == false) // если это задеваемый скилл, то его нельзя задеть и сместить
                {
                    thereisashield = true;
                    transform.SetParent(currentParrent);
                    transform.localPosition = motherplace;
                    shadownottransp.SetActive(false);
                    shadow.transform.localPosition = shadowmotherplace;
                    
                }
                else if (Input.touchCount <= 0 && triggeredskill == false && podsvetSkila.activeSelf == true) // если этот навык двигался
                {
                    transform.SetParent(currentParrent);
                    transform.localPosition = motherplace;
                    shadownottransp.SetActive(false);
                    shadow.transform.localPosition = shadowmotherplace;
                }
            }

            // если мы двигаемся в пределах слотов
            if (transform.parent == currentStaticParent)

            {

                // если этот скилл двигается
                if (other.CompareTag("Skill") && Input.touchCount <= 0 && triggeredskill == false && podsvetSkila.activeSelf == true)
                {
                    currentposition = new Vector2(transform.position.x, transform.position.y);
                    if (currentposition == newslotplace) // если мы только что двигались, стоим на поле и задеваем другой навык в состоянии покоя, то он смещается на наш фиксед
                    {
                        // делает вторую часть непрозрачной включает непрозрачную часть?
                        shadownottransp.SetActive(true);
                        other.transform.position = stupidmotherplace; // ставим смещаемый навык на свой фиксед, т. е. сметаем с поля
                                                               // задём новый фиксед
                    }
                }

                // если этот скилл задет, но после верхнего всё еще пересекается с другим, он вернётся на свой фиксед
                // нужно чтобы он не задевался другими передвижениями, а только в состоянии покоя (если нет триггера слота?)
                if (other.CompareTag("Skill") && Input.touchCount <= 0 && triggeredskill && podsvetSkila.activeSelf == false && currentposition != fixedplace) // если навыки слипаются и один из них не фикседе
                {
                    transform.position = fixedplace; // ставим смещаемый навык на свой фиксед
                                                     // тут мб обновить плейс
                }

            }
        }

        if (podsvetSkila.activeSelf == true && Input.touchCount > 0) // если этот навык двигается
        {
            // принимает место слота, на который залезает
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
            if (other.CompareTag("kolonka")) // если выйти из колонки, другие навыки будут реагировать
            {
                thereisashield = false;
                transform.localScale = new Vector3(1f, 1f, 0f);
            }
        }
        if (other.CompareTag("Sizerrr2") || other.CompareTag("Sizerrr"))
        {
            sizenormie = true;
        }

        if (podsvetSkila.activeSelf == true && Input.touchCount > 0 && slot4trigger.activeSelf == true) // если этот навык двигается
        {
            // принимает место слота, на который залезает
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

            if (other.CompareTag("SlotCanvas")) // если выходим за пределы слотов, то мы вернёмся на фикс позицию
            {
                shadownottransp.SetActive(false);
                shadow.transform.localPosition = shadowmotherplace;
            }
        }
       

    }

    // если входим в зону триггера и ещё двигаемся
    private void OnTriggerEnter2D(Collider2D other)
    {


        if (skillsBack != null && skillsBack.activeSelf == true)
        {
            if (other.CompareTag("kolonka")) // если входим в область колонки любым навыком, то мы вернёмся на родное место
            {
                newslotplace = stupidmotherplace;
                shadownottransp.SetActive(false);
                shadow.transform.localPosition = shadowmotherplace;
            }

            if (podsvetSkila.activeSelf == true && Input.touchCount > 0) // если этот навык двигается
            {
                // принимает место слота, на который залезает
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

                if (other.CompareTag("SlotCanvas")) // если выходим за пределы слотов, то мы вернёмся на фикс позицию
                {
                    newslotplace = fixedplace;
                }
            }

        }
    }

}
