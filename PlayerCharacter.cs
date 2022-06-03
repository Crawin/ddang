using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    Rigidbody rigid;
    public float leftPaint;
    GameObject PlayerCam;
    Vector3 camLookat;
    Vector3 camRight;
    // Start is called before the first frame update
    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        //transform.position = new Vector3(-4.5f, 0.5f, -4.5f);
        leftPaint = 1;
        PlayerCam = GameObject.Find("Camera");
        camLookat = PlayerCam.GetComponent<Transform>().forward;
        camLookat = Vector3.ProjectOnPlane(camLookat, new Vector3(0, -1, 0));
        camLookat = Vector3.Normalize(camLookat);

        camRight = PlayerCam.GetComponent<Transform>().right;
        camRight = Vector3.ProjectOnPlane(camRight, new Vector3(0, -1, 0));
        camRight = Vector3.Normalize(camRight);
    }

    // Update is called once per frame
    void Update()
    {
        leftPaint -= 0.1f * Time.deltaTime;
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }

    }
    private void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        camLookat = PlayerCam.GetComponent<Transform>().forward;
        camLookat = Vector3.ProjectOnPlane(camLookat, new Vector3(0, -1, 0));
        camLookat = Vector3.Normalize(camLookat);
        camRight = PlayerCam.GetComponent<Transform>().right;
        camRight = Vector3.ProjectOnPlane(camRight, new Vector3(0, -1, 0));
        camRight = Vector3.Normalize(camRight);
        Vector3 vec = (camLookat * v / 2) + (camRight * h / 2);
        vec = Vector3.Normalize(vec) / 2;

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
