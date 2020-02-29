using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Get_player_name : MonoBehaviour
{
    InputField playerInbox;
    public float playerNumber;
    public static string p1name;
    public static string p2name;
    public static string p3name;
    public static string p4name;
    // Start is called before the first frame update
    void Start()
    {
        playerNumber = Set_player_number.numberSliderGet;
        Debug.Log(playerNumber);

        if (playerNumber < 4)
        {
            GameObject.Find("Player4").SetActive(false);
            if (playerNumber < 3)
            {
                GameObject.Find("Player3").SetActive(false);
                if (playerNumber < 2)
                {
                    GameObject.Find("Player2").SetActive(false);
                }
            }

        }

    }

    // Update is called once per frame
    void Update()
    {
      if (playerNumber>0) {
        playerInbox = (GameObject.Find("Player1").GetComponent<InputField>());
        p1name = playerInbox.text;

      }

      if (playerNumber>1){
        playerInbox = (GameObject.Find("Player2").GetComponent<InputField>());
        p2name = playerInbox.text;
      }

      if(playerNumber>2){
        playerInbox = (GameObject.Find("Player3").GetComponent<InputField>());
        p3name = playerInbox.text;
      }

      if(playerNumber>3){
        playerInbox = (GameObject.Find("Player4").GetComponent<InputField>());
        p4name = playerInbox.text;
        Debug.Log(p4name);
      }

    }
}
