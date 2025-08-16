using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spieler_Bewegung : MonoBehaviour
{

    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("up")){transform.Translate(Vector2.up * speed * Time.deltaTime);}
        if(Input.GetKey("right")){transform.Translate(Vector2.right * speed * Time.deltaTime);}
        if(Input.GetKey("left")){transform.Translate(Vector2.left * speed * Time.deltaTime);}
        if(Input.GetKey("down")){transform.Translate(Vector2.down * speed * Time.deltaTime);}

    }
}
