using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaintBar : MonoBehaviour
{
    PlayerCharacter character;
    Image paintBar;
    bool turnred;
    float cycle;
    float aftercycle;
    // Start is called before the first frame update
    void Start()
    {
        character = GameObject.Find("Player").GetComponent<PlayerCharacter>();
        paintBar = GetComponent<Image>();
        paintBar.fillAmount = 0;
        cycle = 0.3f;
        aftercycle = 0;
    }

    // Update is called once per frame
    void Update()
    {
        paintBar.fillAmount = character.leftPaint;
        if(paintBar.fillAmount == 1)
        {
            paintBar.color = new Color32(49, 49, 255, 255);
            turnred = false;
        }
        if(paintBar.fillAmount < 0.3)
        {
            if (paintBar.fillAmount == 0)
            {
                paintBar.color = new Color32(49, 49, 255, 255);
                turnred = false;
            }
            else
            {
                if (Time.time - aftercycle > cycle)
                {
                    aftercycle = Time.time;
                    turnred = !turnred;
                    if (turnred)
                    {
                        paintBar.color = Color.red;
                    }
                    else
                    {
                        paintBar.color = new Color32(49, 49, 255, 255);
                    }
                }
            }
        }
    }
}
