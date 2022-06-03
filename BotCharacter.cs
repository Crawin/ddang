using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotCharacter : MonoBehaviour
{
    Rigidbody rigid;
    Transform playerTransform;
    Vector3 Dir;
    Vector3 DefaultPosition;
    // Start is called before the first frame update
    void Start()
    {
        DefaultPosition = transform.position;
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
            transform.position = DefaultPosition;
            rigid.velocity = Vector3.zero;
        }
    }
}
