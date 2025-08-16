using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kill : MonoBehaviour
{
    public Lebenssystem leben;
    public Spieler player;
    // Start is called before the first frame update
    void Start()
    {
        //affix under camera
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other){
        leben.deplete_leben();
        player.GotoStart();
    }
}
