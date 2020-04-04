using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{
    public float playerNumber;//import player number

    //import player name
    private string  p1name,p2name,p3name,p4name;
    private int p1score,p2score,p3score,p4score;
    public static int p1s, p2s, p3s, p4s;
    public GameObject player1, player2, player3, player4;
    Text p1Score, p1Name, p2Score, p2Name, p3Score, p3Name, p4Score, p4Name;
    public int mode;
    public static int round = 0;

    // Start is called before the first frame update
    void Start()
    {
        //mode = CartoonDropdown.modelNumber;
        mode = 1;

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
        if (round == 2) {
            GameObject.Find("AgainButton").SetActive(false);
        }


        if (playerNumber > 0)
        {
         
            p1name = Get_player_name.p1name;
            p1score = Score.p1s;
            p1Score = GameObject.Find("player1_score").GetComponent<Text>();
            p1Name = GameObject.Find("player1_name").GetComponent<Text>();
       
            if (p1s == 0)
            {
                p1s = p1score;
            }
            else
            {
                p1s += p1score;
            }
    
        }

        if (playerNumber > 1)
        {
      
            p2name = Get_player_name.p2name;
            p2score = Score.p2s;
            p2Score = GameObject.Find("player2_score").GetComponent<Text>();
            p2Name = GameObject.Find("player2_name").GetComponent<Text>();
         
            if (p2s == 0)
            {
                p2s = p2score;
            }
            else
            {
                p2s += p2score;
            }
   
        }

        if (playerNumber > 2)
        {
            p3Name = GameObject.Find("player3_name").GetComponent<Text>();
            p3Score = GameObject.Find("player3_score").GetComponent<Text>();
            p3name = Get_player_name.p3name;
            p3score = Score.p3s;
            if (p3s == 0)
            {
                p3s = p3score;
            }
            else
            {
                p3s += p3score;
            }
 
        }

        if (playerNumber > 3)
        {
            p4name = Get_player_name.p4name;
            p4score = Score.p4s;

            p4Name = GameObject.Find("player4_name").GetComponent<Text>();
            p4Score = GameObject.Find("player4_score").GetComponent<Text>();
        
            if (p4s == 0)
            {
                p4s = p4score;
            }
            else
            {
                p4s += p4score;
            }
          
        }
    }

    private void Awake()
    {
        Button continueButton = GameObject.Find("AgainButton").GetComponent<Button>() as Button;
        continueButton.onClick.AddListener(conClick);

    }
    // Update is called once per frame
    void Update()
    {
       
        //setup score of each palyer
        if (playerNumber > 0)
        {
        
            p1Score.text = p1score.ToString();
            p1Name.text = p1name;
          
            Debug.Log("P1SSSS");
            Debug.Log(p1score);
            Debug.Log(p1s);
        }

        if (playerNumber > 1)
        {
         
            p2Score.text = p2score.ToString();
            p2Name.text = p2name;
       
            Debug.Log("P2SSSS");
            Debug.Log(p2score);
            Debug.Log(p2s);
        }

        if (playerNumber > 2)
        {
           
            
            p3Score.text = p3score.ToString();
            p3Name.text = p3name;
            
            Debug.Log("P3SSSS");
            Debug.Log(p3score);
            Debug.Log(p3s);
        }

        if (playerNumber > 3)
        {
          
            p4Score.text = p4score.ToString();
            p4Name.text = p4name;
         
            Debug.Log("P4SSSS");
            Debug.Log(p4score);
            Debug.Log(p4s);
        }


        Debug.Log("Round::::");
        Debug.Log(round);
    }
    void conClick() {
        print("Again Button Click");

        if (mode == 1) { 
            SceneManager.LoadScene("InGamePlay");
        }
        else {
            SceneManager.LoadScene("expert");
        }
        round += 1;
    }

}
