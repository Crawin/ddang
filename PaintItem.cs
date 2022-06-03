using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintItem : MonoBehaviour
{
    float RotateSpeed = 200;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(Random.Range(-9.5f, 9.6f), 0.5f, Random.Range(-9.5f, 9.6f));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * RotateSpeed * Time.deltaTime, Space.World);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            gameObject.SetActive(false);
        }
    }
}
