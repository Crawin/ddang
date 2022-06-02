using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    MeshRenderer mesh;
    Material material;
    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        material = mesh.material;
        material.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            material.color = new Color32(0, 0, 255, 0);
        }
        if(collision.gameObject.name == "Bot")
        {
            material.color = new Color32(255, 0, 0, 0);
        }
    }
}
