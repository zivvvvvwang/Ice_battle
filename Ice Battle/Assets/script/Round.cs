using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Round : MonoBehaviour
{

    //public static int startRound=1;
    private int round;
  
    public int getRound() { return round; }
    public void addRound() { round += 1; }
    public void resetRound() { round = 1; }
    //public static int roundGet;
    private Text roundText;
    //private int round;
    // Start is called before the first frame update
    void Start()
    {
  
        round = ScoreScript.round+1;
      
        
    }

    // Update is called once per frame
    void Update()
    {
        roundText = GameObject.Find("Round").GetComponent<Text>();
        roundText.text = "- " + round + " -";

    }

}