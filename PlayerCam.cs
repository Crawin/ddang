using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    Transform PlayerTransform;
    Vector3 Offset;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        PlayerTransform = GameObject.Find("Player").transform;
        Offset = transform.position - PlayerTransform.position;
    }
    private void Update()
    {
    }

    void LateUpdate()
    {
        Vector3 Pos = new Vector3(PlayerTransform.position.x + Offset.x, 3.5f, PlayerTransform.position.z + Offset.z);
        transform.position = Pos;
        Rotate();

    }

    void Rotate()
    {
        float mx = Input.GetAxis("Mouse X");
        transform.RotateAround(PlayerTransform.position, Vector3.up, mx);
        Offset = transform.position - PlayerTransform.position;
    }
}
