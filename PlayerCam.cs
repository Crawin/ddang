using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    Transform PlayerTransform;
    Vector3 Offset;
    float Angle;
    // Start is called before the first frame update
    void Start()
    {
        PlayerTransform = GameObject.Find("Player").transform;
        Offset = transform.position - PlayerTransform.position;
    }
    private void Update()
    {
        Rotate();
    }

    void LateUpdate()
    {
        Vector3 Pos = new Vector3(PlayerTransform.position.x + Offset.x, 3.5f, PlayerTransform.position.z + Offset.z);
        transform.position = Pos;
        Rotate();

    }

    void Rotate()
    {
        if (Input.GetMouseButton(0))
        {
            float mx = Input.GetAxisRaw("Mouse X");
            Angle += mx;
            Debug.Log(mx);
            transform.RotateAround(PlayerTransform.position, Vector3.up, mx);
            Offset = transform.position - PlayerTransform.position;
        }
    }
}
