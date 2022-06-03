using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    TextMeshProUGUI textMesh;
    CountArea b_finish;
    float startTime = 0;
    Vector3 center;
    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
        Debug.Log(textMesh.transform.position);
        b_finish = GameObject.FindObjectOfType<CountArea>();
        startTime = Time.time;
        //center = new Vector3(Camera.main.pixelWidth / 2, Camera.main.pixelHeight / 2, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (b_finish.finish)
        {
            Debug.Log("Finish");
            textMesh.transform.position = new Vector3(Camera.main.pixelWidth / 2, Camera.main.pixelHeight / 2, 0);
            textMesh.transform.localScale = new Vector3(2, 2, 0);
            textMesh.color = Color.black;
            //textMesh.text = "Record: " + textMesh.text;
        }
        else
        {
            textMesh.text = (Mathf.RoundToInt((Time.time - startTime) * 100) * 0.01f).ToString("F2");
        }
    }
}
