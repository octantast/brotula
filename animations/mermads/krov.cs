using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class krov : MonoBehaviour
{
    private Color32 whitecolor;
    private Image itself;
    // Start is called before the first frame update
    void Start()
    {
        itself = GetComponent<Image>();
        whitecolor = new Color32(225, 225, 225, 225);
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = Vector2.MoveTowards(transform.localPosition, new Vector3(300f, 300f, 0f), 1f);
        itself.color = Color.Lerp(itself.color, whitecolor, Time.deltaTime / 5f);
    }
}
