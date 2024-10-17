using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Halth_bar : MonoBehaviour
{
    public Slider slider;

    public void SetMaxHelth(int health)
    {
        //Debug.Log("h1" + health.ToString());
        slider.maxValue = health;
        slider.value = health;
        
    }

    public void SetHealth(int health)
    {   
        
        //Debug.Log("h2" + health.ToString() );
        slider.value = health; 

    }


}
//https://www.youtube.com/watch?v=BLfNP4Sc_iA&t=143s
