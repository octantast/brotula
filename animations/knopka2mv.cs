using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knopka2mv : MonoBehaviour
{
    public battlefinal final;
    public SliderController slidor;
    public ConfirmScreen podtverjdenie;
    public battlefinal batol;
    public PlayerController player;
    public BattleScreen battleModeVisibility;
    private Vector2 motherpos;
    private Vector2 hidepos;
    public DistanceToCheckpoint distancePoints;
    // Start is called before the first frame update
    void Start()
    {
        motherpos = new Vector2(transform.localPosition.x, transform.localPosition.y);
        transform.localPosition = new Vector2(transform.localPosition.x + 220f, transform.localPosition.y);
        hidepos = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (distancePoints.distance <= 5150 && batol.evermermaids > 0)
        {
            transform.localPosition = Vector2.MoveTowards(transform.localPosition, motherpos, 50f);
        }
        else if (distancePoints.distance > 5150 && batol.evermermaids > 0 && distancePoints.distance < 12070)
        {
            if (battleModeVisibility.battleMode && battleModeVisibility.skippingMode == false && batol.resultMode == false)
            {
                transform.localPosition = Vector2.MoveTowards(transform.localPosition, hidepos, 50f);
            }
            else if (batol.resultMode && podtverjdenie.noteBack.activeSelf == false && final.deathmode == false || battleModeVisibility.skippingMode)
            {
                transform.localPosition = Vector2.MoveTowards(transform.localPosition, motherpos, 50f);
            }

            // если бой и движение, то кнопка съедет, если резалт мод или скиппинг, вернется

        }
        else if (distancePoints.distance >= 12070)
        {
            transform.localPosition = Vector2.MoveTowards(transform.localPosition, hidepos, 50f);
        }
    }
}
