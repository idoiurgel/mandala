using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_bewegung : MonoBehaviour
{
    public float p_speed = 7f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("up")){
            transform.Translate(Vector2.up * p_speed * Time.deltaTime);
        }
        if(Input.GetKey("right")){
            transform.Translate(Vector2.right * p_speed * Time.deltaTime);
        }
        if(Input.GetKey("left")){
            transform.Translate(Vector2.left * p_speed * Time.deltaTime);
        }
        if(Input.GetKey("down")){
            transform.Translate(Vector2.down * p_speed * Time.deltaTime);
        }

    }
}
