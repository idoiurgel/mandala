using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class lava_bewegung : MonoBehaviour
{
    public Rigidbody2D l_rigidbody;
    public Spieler player;
    private Vector2 falling;

    public void OnTriggerEnter2D(Collider2D other){
        //deplete_leben();
    }

    void Start()
    {
        
    }

    void Update()
    {
        if(l_rigidbody != null){
            if (l_rigidbody.transform.position.y < -19){
                Destroy(l_rigidbody);
            }
            if (player.transform.position.x >= this.transform.position.x){ // if player is below lava, fall
                falling = falling + Vector2.down;
            }

            l_rigidbody.AddForce(falling, ForceMode2D.Impulse);
        }
    }


}
