using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class kruch2 : MonoBehaviour
{
    private Color32 whitecolor;
    private Image itself;
    private Color32 whitecolorreal;
    private float timer;

    void Start()
    {
        itself = GetComponent<Image>();
        whitecolor = new Color32(0, 0, 0, 225);
        //whitecolorreal = new Color32(225, 225, 225, 225);
        timer = 1.3f;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer > 0)
        {
            // transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(1.5f, 1.5f, 0f), 0.05f);
            itself.color = Color.Lerp(itself.color, whitecolor, Time.deltaTime / 0.5f);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}