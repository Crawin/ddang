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
    }
}
