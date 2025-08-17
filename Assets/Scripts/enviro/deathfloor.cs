using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathfloor : MonoBehaviour
{
    public Lebenssystem leben;
    public Spieler player;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnTriggerEnter2D(Collider2D other){
        leben.deplete_leben();
        player.GotoStart();
    }
}
