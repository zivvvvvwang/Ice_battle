using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject player;
    public Text score_text;
    public static int p1s, p2s, p3s, p4s;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score_text.text = (player.GetComponent<ControlSprites1>().score / 10).ToString();
        if (player.name == "Assassino")
        {
            p1s = player.gameObject.GetComponent<ControlSprites1>().score / 10;
        }
        else if (player.name == "Carrasco")
        {
            p2s = player.gameObject.GetComponent<ControlSprites1>().score / 10;
        }
        else if (player.name == "Gueirreiro")
        {
            p3s = player.gameObject.GetComponent<ControlSprites1>().score / 10;
        }
        else
        {
            p4s = player.gameObject.GetComponent<ControlSprites1>().score / 10;
        }

    }
}
