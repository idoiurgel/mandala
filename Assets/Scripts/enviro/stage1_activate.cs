using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class trigger_script : MonoBehaviour
{
    public GameObject schlucht;
    public GameObject platforms;
    public Vector3 currentpos;
    public Vector3 endpos;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        currentpos = new Vector3(11f, -8.5f, 0);
        endpos = new Vector3(25f, -8.5f, 0);
        speed = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other){
        Debug.Log("collided");
        // schlucht2 wackelt, geht langsam nach x 25, platforms1 gehen nach oben
    }
}
