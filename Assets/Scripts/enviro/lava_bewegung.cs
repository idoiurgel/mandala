using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class lava_bewegung : MonoBehaviour
{
    public Rigidbody2D l_rigidbody;
    public GameObject player;
    private Vector2 falling;
    public Lebenssystem leben;

    public void OnTriggerEnter2D(Collider2D other){
        leben.deplete_leben();
       
    }

    void Start()
    {
        
    }

    void Update() {
  
    
    if (gameObject.transform.position.y <= -43.6 ) {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x,31.7f,0) ;}
    
    
    
    }


}
