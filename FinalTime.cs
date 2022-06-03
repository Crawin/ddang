using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinalTime : MonoBehaviour
{
    TextMeshProUGUI timerText;
    TextMeshProUGUI final;
    // Start is called before the first frame update
    void Start()
    {
        timerText = GameObject.Find("Timer").GetComponent<TextMeshProUGUI>();
        final = GetComponent<TextMeshProUGUI>();
        final.text = timerText.text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
