using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotCharacter : MonoBehaviour
{
    Rigidbody rigid;
    Transform playerTransform;
    Vector3 Dir;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(9.5f, 0.5f, 9.5f);
        rigid = GetComponent<Rigidbody>();
        playerTransform = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        Dir = playerTransform.position - transform.position;
        rigid.AddForce(Dir.normalized * 2);
        if (transform.position.y < -1)
        {
            transform.position = new Vector3(9.5f, 0.5f, 9.5f);
            rigid.velocity = Vector3.zero;
        }
    }
}
