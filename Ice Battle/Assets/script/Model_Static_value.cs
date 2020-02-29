using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Model_Static_value : MonoBehaviour
{
    //private float Player_number1 = GameObject.Find("Player Slider").GetComponent<Slider>().value;
    static public int model;
    //public static float player_number = Player_number1;



    public void model_choose(int mode)
    {
        model = mode;
    }
    

    
}
