using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class lava_bewegung : MonoBehaviour
{
    private Vector2 falling;


    void Start()
    {
        
    }

    void Update() {
  
  // test
    
    if (gameObject.transform.position.y <= -43.6 ) {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x,31.7f,0) ;}
    }


}
