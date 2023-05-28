using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IkraIndicator : MonoBehaviour
{
    [SerializeField]
    public MermaidController mermaids;
    public GameObject ikraBack;
    public Text ikraText;
    public float ikra; // то, что должно отобразиться
    public DistanceToCheckpoint distancePoints;
    public Levels leveler;
    private float vspomogatelnayaikra; // то, что отображается
    public GameObject ikraTo10;
    public GameObject ikraTo30;
    public GameObject ikraTo50;
    public GameObject ikraMegaZapas;

    void Start()
    {
        ikraTo10.SetActive(true);
        ikraTo30.SetActive(false);
        ikraTo50.SetActive(false);
        ikraMegaZapas.SetActive(false);
        ikraBack.SetActive(false);
        vspomogatelnayaikra = 0;
        ikra = leveler.minimumIkra;
    }

    public void Update()
    {
        // показывает запас икры по 1
        if(vspomogatelnayaikra != ikra)
        {
            if (vspomogatelnayaikra < ikra)
            {
                vspomogatelnayaikra += 1;
            }
            else if (vspomogatelnayaikra > ikra)
            {
                vspomogatelnayaikra -= 1;
            }
        }
        // показывает картинку, соотв-ую кол-ву икры
        if(vspomogatelnayaikra < 15)
        {
            ikraTo10.SetActive(true);
            ikraTo30.SetActive(false);
            ikraTo50.SetActive(false);
            ikraMegaZapas.SetActive(false);
        }
        else if (vspomogatelnayaikra >= 15 && vspomogatelnayaikra < 30)
        {
            ikraTo10.SetActive(false);
            ikraTo30.SetActive(true);
            ikraTo50.SetActive(false);
            ikraMegaZapas.SetActive(false);
        }
        else if (vspomogatelnayaikra >= 30 && vspomogatelnayaikra < 50)
        {
            ikraTo10.SetActive(false);
            ikraTo30.SetActive(false);
            ikraTo50.SetActive(true);
            ikraMegaZapas.SetActive(false);
        }
        else if (vspomogatelnayaikra >= 50)
        {
            ikraTo10.SetActive(false);
            ikraTo30.SetActive(false);
            ikraTo50.SetActive(false);
            ikraMegaZapas.SetActive(true);
        }


        if (distancePoints.distance >= 5050 && distancePoints.distance <= 5060)
        {
            ikra = leveler.minimumIkra;
            ikraBack.SetActive(false);
            ikraText.text = " ";
        }
        if (distancePoints.distance >= 5100 && leveler.settingsMode.activeSelf == false && mermaids.garemBack.activeSelf == false)
        {
            ikraBack.SetActive(true);
            ikraText.text = vspomogatelnayaikra.ToString("F0");
        }
        else if(distancePoints.distance >= 5100 && (leveler.settingsMode.activeSelf == true || mermaids.garemBack.activeSelf == true))
        {
            ikraBack.SetActive(false);
            ikraText.text = " ";
        }
    }
}
