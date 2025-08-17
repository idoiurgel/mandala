using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class sprinttest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
public float Sprungkraft = 1f;
public float Power = 100000f;


 void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collide");
        Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.right * 4000);
    }
}
