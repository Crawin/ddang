using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tile : MonoBehaviour
{
    MeshRenderer mesh;
    Material material;
    PlayerCharacter character;
    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        material = mesh.material;
        material.color = Color.white;
        character = GameObject.Find("Player").GetComponent<PlayerCharacter>();
    }

    // Update is called once per frame
    void Update()
    { 
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            if (character.leftPaint > 0)
                material.color = new Color32(0, 0, 255, 0);
        }
        if(collision.gameObject.tag == "Bot")
        {
            material.color = new Color32(255, 0, 0, 0);
        }
    }
}
