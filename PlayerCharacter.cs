using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    Rigidbody rigid;
    public float leftPaint;
    // Start is called before the first frame update
    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        //transform.position = new Vector3(-4.5f, 0.5f, -4.5f);
        leftPaint = 1;
    }

    // Update is called once per frame
    void Update()
    {
        leftPaint -= 0.1f * Time.deltaTime;
    }
    private void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 vec = new Vector3(h /2 , 0, v / 2);
        rigid.AddForce(vec, ForceMode.Impulse);
        if (transform.position.y < -1)
        {
            transform.position = new Vector3(-9.5f, 0.5f, -9.5f);
            rigid.velocity = Vector3.zero;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bot")
        {
            transform.position = new Vector3(-9.5f, 0.5f, -9.5f);
            rigid.velocity = Vector3.zero;
            leftPaint /= 2;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Paint")
        {
            leftPaint = 1;
        }
    }
}
