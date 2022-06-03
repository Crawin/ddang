using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rezenItem : MonoBehaviour
{
    float time = 0;
    int childcnt;
    GameObject[] childs;
    // Start is called before the first frame update
    void Start()
    {
        childcnt = gameObject.transform.childCount;
        childs = new GameObject[childcnt];
        for (int i = 0; i < childcnt; ++i)
        {
            childs[i] = gameObject.transform.GetChild(i).gameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - time > 10)
        {
            time = Time.time;
            foreach(GameObject child in childs)
            {
                if (!child.active)
                {
                    Debug.Log("ÇÏ³ª ¸®Á¨");
                    child.SetActive(true);
                    child.transform.position = new Vector3(Random.Range(-4.5f, 14.6f), 0.5f, Random.Range(-4.5f, 14.6f));
                }
            }
        }

    }
}
