using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow_player : MonoBehaviour
{
    public Transform player;
    public float offset_x;
    public float offset_y = 20;
    public float offset_z = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3 (player.position.x + offset_x, player.position.y + offset_y, offset_z);   
    }
}
