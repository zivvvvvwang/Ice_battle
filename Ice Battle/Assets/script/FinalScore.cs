using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    private float playerNumber;//import player number
    private string p1name, p2name, p3name, p4name;   //import player name
    private int p1score, p2score, p3score, p4score, maxScore, minScore;

    public GameObject player1, player2, player3, player4,maxPlayer,minPlayer;
    public Text p1Score, p1Name, p2Score, p2Name, p3Score, p3Name, p4Score, p4Name;
    private RectTransform max,min;

    // Start is called before the first frame update
    void Start()
    {
        playerNumber = Set_player_number.numberSliderGet;
        if (playerNumber < 4)
        {
        
            GameObject.Find("player4").SetActive(false);
            if (playerNumber < 3)
            {
                GameObject.Find("player3").SetActive(false);
                if (playerNumber < 2)
                {
                    GameObject.Find("player2").SetActive(false);
                }
            }
        }
        if (playerNumber > 0)
        {
            p1name = Get_player_name.p1name;
            p1score = ScoreScript.p1s;
            p1Score = GameObject.Find("player1_score").GetComponent<Text>();
            p1Name = GameObject.Find("player1_name").GetComponent<Text>();
        }

        if (playerNumber > 1)
        {
            p2name = Get_player_name.p2name;
            p2score = ScoreScript.p2s;
            p2Score = GameObject.Find("player2_score").GetComponent<Text>();
            p2Name = GameObject.Find("player2_name").GetComponent<Text>();
        }

        if (playerNumber > 2)
        {
            p3Name = GameObject.Find("player3_name").GetComponent<Text>();
            p3Score = GameObject.Find("player3_score").GetComponent<Text>();
            p3name = Get_player_name.p3name;
            p3score = ScoreScript.p3s;
        }

        if (playerNumber > 3)
        {
            p4name = Get_player_name.p4name;
            p4score = ScoreScript.p4s;
            p4Name = GameObject.Find("player4_name").GetComponent<Text>();
            p4Score = GameObject.Find("player4_score").GetComponent<Text>();
        }

        maxScore = FindMax(p1score, p2score, p3score, p4score);
        minScore = FindMin(p1score, p2score, p3score, p4score);
    }

    private int FindMax(int p1s, int p2s, int p3s, int p4s)
    {
        int max = p1s;

        if (p1s > p2s)
        {
            max = p1s;
        }
        else
        {
            max = p2s;
        }
        if (p3s > max)
        {
            max = p3s;
        }
        if (p4s > max)
        {
            max = p4s;
        }

        return max;
    }

    private int FindMin(int p1s, int p2s, int p3s, int p4s)
    {
        int min = p1s;
        if (p2s == 0) {
            return min;
        }
    
        if (p1s < p2s)
        {
            min = p1s;
        }
        else
        {
            min = p2s;
        }

        if (p3s == 0)
        {
            return min;
        }

        if (p3s < min)
        {
            min = p3s;
        }

        if (p4s == 0)
        {
            return min;
        }

        if (p4s < min)
        {
            min = p4s;
        }
        return min;
    }

    //Update is called once per frame
    void Update()
    {
        //setup score of each palyer
        if (playerNumber > 0)
        {
            p1Score.text = p1score.ToString();
            p1Name.text = p1name;
            if (p1score == maxScore)
            {
                //max.position.y = 100; 
                //maxPlayer.Position.y = 100;
            }
            if (p1score == minScore) {
                //minPlayer.posi
            }
            
        }

        if (playerNumber > 1)
        {
     
            p2Score.text = p2score.ToString();
            p2Name.text = p2name;

        }

        if (playerNumber > 2)
        {
       
            p3Score.text = p3score.ToString();
            p3Name.text = p3name;
        }

        if (playerNumber > 3)
        {
            p4Score.text = p4score.ToString();
            p4Name.text = p4name;

        }

    }
}