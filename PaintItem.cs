using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintItem : MonoBehaviour
{
    float RotateSpeed = 200;
    float disableTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(Random.Range(-4.5f, 14.6f), 0.5f, Random.Range(-4.5f, 14.6f));
    }

    // Update is called once per frame
    void Update()
    {

        if (disableTime != 0)
        {
            Debug.Log("»ç¶óÁü");
            if (Time.time - disableTime > 10)
            {
                gameObject.SetActive(true);
                transform.position = new Vector3(Random.Range(-4.5f, 14.6f), 0.5f, Random.Range(-4.5f, 14.6f));
            }
        }
        transform.Rotate(Vector3.up * RotateSpeed * Time.deltaTime, Space.World);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            gameObject.SetActive(false);
            disableTime = Time.time;
        }
    }
}
