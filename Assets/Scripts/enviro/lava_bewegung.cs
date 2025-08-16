using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class lava_bewegung : MonoBehaviour
{
    public Rigidbody2D l_rigidbody;
    public GameObject player;

    //public float lava_geschwindigkeit = 30f;
    void Start()
    {
        
    }

    void Update()
    {
        // if player is below lava, fall
        if (player.transform.position.x >= this.transform.position.x){
            
            l_rigidbody.AddForce(Vector2.down, ForceMode2D.Impulse);
        }
    }
}
