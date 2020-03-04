using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float player_number;//import player number

    //import player name
    public string bear_name, walrus_name, husky_name, penguin_name, s;
    public GameObject bear, walrus, husky, penguin;
   
    Text bear_score, walrus_score, husky_score, penguin_score;
    public int p1score, p2score, p3score, p4score;

    void Start()
    {
        
        player_number = Set_player_number.numberSliderGet;

        bear_name = Get_player_name.p1name;
        walrus_name = Get_player_name.p2name;
        husky_name = Get_player_name.p3name;
        penguin_name = Get_player_name.p4name;
 
        p1score = 1111;
        p2score = 22222;
        p3score = 333;
        p4score = 4444;

        bear.SetActive(true);
        walrus.SetActive(true);
        husky.SetActive(true);
        penguin.SetActive(true);

        if (player_number == 1)
        {
            walrus.SetActive(false);
            husky.SetActive(false);
            penguin.SetActive(false);
            bear_score = GameObject.Find("player_bear_score").GetComponent<Text>();
        }
        else if (player_number == 2)
        {
            husky.SetActive(false);
            penguin.SetActive(false);
            bear_score = GameObject.Find("player_bear_score").GetComponent<Text>();
            walrus_score = GameObject.Find("player_walrus_score").GetComponent<Text>();
        }
        else if (player_number == 3)
        {
            penguin.SetActive(false);
            bear_score = GameObject.Find("player_bear_score").GetComponent<Text>();
            walrus_score = GameObject.Find("player_walrus_score").GetComponent<Text>();
            husky_score = GameObject.Find("player_husky_score").GetComponent<Text>();
        }

        //setup score of each palyer
        bear_score = GameObject.Find("player_bear_score").GetComponent<Text>();
        walrus_score = GameObject.Find("player_walrus_score").GetComponent<Text>();
        husky_score = GameObject.Find("player_husky_score").GetComponent<Text>();
        penguin_score = GameObject.Find("player_penguin_score").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        s = "{0:-15}: {1,15}";
        p1score = Score.p1s;
        p2score = Score.p2s;
        p3score = Score.p3s;
        p4score = Score.p4s;
        Debug.Log("pppppp" + p1score);
        if (player_number == 1)
        {
            bear_score.text = string.Format(s, bear_name, p1score);
        }else if (player_number == 2)
        {
            bear_score.text = string.Format(s, bear_name, p1score);
            walrus_score.text = string.Format(s, walrus_name, p2score);
        }else if (player_number == 3)
        {
            bear_score.text = string.Format(s, bear_name, p1score);
            walrus_score.text = string.Format(s, walrus_name, p2score);
            husky_score.text = string.Format(s, husky_name, p3score);
        }else {
            bear_score.text = string.Format(s, bear_name, p1score);
            walrus_score.text = string.Format(s, walrus_name, p2score);
            husky_score.text = string.Format(s, husky_name, p3score);
            penguin_score.text = string.Format(s, penguin_name, p4score);
        }

    }
}
