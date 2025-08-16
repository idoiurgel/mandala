using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lebenssystem : MonoBehaviour
{
    public GameObject player;
    public Lebensanzeige leben_slider;
    public int player_max_leben;
    public int current_leben;


    // Start is called before the first frame update
    void Start()
    {
        player_max_leben = 5;
        leben_slider.setzeMaxLeben(player_max_leben);
        current_leben = player_max_leben;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void deplete_leben(){
        if(current_leben<=1){
            //game over script
        }else{
        current_leben-=1;
        leben_slider.setzeLeben(current_leben);
        }
    }
    
    

}