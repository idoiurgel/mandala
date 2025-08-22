using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spieler_Bewegung : MonoBehaviour
{

    public float speed = 10f;
    public Transform BodenCheck;
    public float BodenRadius = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     bool amBoden = Physics2D.OverlapCircle(BodenCheck.position, BodenRadius);

        GetComponent<Rigidbody2D>().AddForce(Vector2.up * speed);
        if(Input.GetKey("right")){transform.Translate(Vector2.right * speed * Time.deltaTime);}
        if(Input.GetKey("left")){transform.Translate(Vector2.left * speed * Time.deltaTime);}
        if(Input.GetKey("down")){transform.Translate(Vector2.down * speed * Time.deltaTime);}

    }
}
