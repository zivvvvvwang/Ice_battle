using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Set_player_number : MonoBehaviour
{
    public static float numberSliderGet;
    private Text numberSetter;
    // Start is called before the first frame update
    void Start()
    {
        numberSliderGet = GameObject.Find("Player Slider").GetComponent<Slider>().value;
        
        numberSetter = GameObject.Find("number").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        numberSliderGet = GameObject.Find("Player Slider").GetComponent<Slider>().value;
        numberSetter.text = "Player Number: " + numberSliderGet;
    }
}
