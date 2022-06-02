using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    Rigidbody rigid;

    // Start is called before the first frame update
    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        //transform.position = new Vector3(-4.5f, 0.5f, -4.5f);
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 vec = new Vector3(h /2 , 0, v / 2);
        rigid.AddForce(vec, ForceMode.Impulse);
        if (transform.position.y < -1)
        {
            Debug.Log("Ãß¶ô");
            transform.position = new Vector3(-4.5f, 0.5f, -4.5f);
            rigid.velocity = Vector3.zero;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bot")
        {

        }
    }
}
