using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spieler : MonoBehaviour
{
    
    public float Geschwindigkeit = 2f;
    public float Sprungkraft = 40f;
    public Rigidbody2D rigidbody;

    Vector2 bewegungsvektor = new Vector2(0,0);
    Vector2 laufvektor = new Vector2(0,0);
    Vector2 sprungvektor = new Vector2(0,0);
    bool istInDerLuft;

    //public Vector3 spawn_pos = new Vector3(-13.42f, 1.59f, 0); 
    public GameObject spawnPunkt;

    public void GotoStart(){
        gameObject.transform.position = spawnPunkt.transform.position;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(rigidbody.velocity.y == 0.0f){
            istInDerLuft = false;
        }else{
            istInDerLuft = true;
        }

        bewegungsvektor = new Vector2(0,0);
        
        if (Input.GetKey("up") && !istInDerLuft)
        {
            bewegungsvektor = bewegungsvektor + Vector2.up * Sprungkraft;
        }

        if (Input.GetKey("right"))
        {
            bewegungsvektor = bewegungsvektor + Vector2.right * Geschwindigkeit;
        }

        if (Input.GetKey("left"))
        {
            bewegungsvektor = bewegungsvektor + Vector2.left * Geschwindigkeit;
        }
        
    }

    void FixedUpdate(){
        rigidbody.AddForce(bewegungsvektor, ForceMode2D.Impulse);
    }


}