using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class CountArea : MonoBehaviour
{
    TextMeshProUGUI score;
    int tilecnt;
    Material[] tileMat;
    int mytile;
    public bool finish;
    GameObject restartbutton;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<TextMeshProUGUI>();
        tilecnt = GameObject.Find("Tile").transform.childCount;
        tileMat = new Material[tilecnt];
        for (int i = 0; i < tilecnt; ++i)
        {
            tileMat[i] = GameObject.Find("Tile").transform.GetChild(i).GetComponent<MeshRenderer>().material;
        }
        restartbutton = GameObject.Find("Button");
        restartbutton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        foreach(Material mat in tileMat)
        {
            if(mat.color == new Color32(0, 0, 255, 0))
            {
                ++mytile;
            }
        }
        score.text = mytile.ToString() + " / " + tilecnt.ToString();
        if(mytile >= 180)
        {
            finish = true;
            Cursor.lockState = CursorLockMode.None;
            restartbutton.SetActive(true);
        }
        mytile = 0;
    }
}
