using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlSprites1 : MonoBehaviour
{
    //public GameObject character;
    public bool stopRotate = false;
    public bool pause;
    public Vector3 direction;
    public int score;
    private float angle;
    private float acc;
    private float a;
    private float vel = 1;
    private float playerNum;
    

    //tart is called before the first frame update
    void Start()
    {
        stopRotate = false;
        pause = false;
        score = 0;
        acc = 0;
        Time.timeScale = 1;
        playerNum = Set_player_number.numberSliderGet;
        //playerNum = 4;
        if (playerNum == 1 && this.name == "Assassino")
        {
            GameObject.Find("Player2").SetActive(false);
            GameObject.Find("Player3").SetActive(false);
            GameObject.Find("Player4").SetActive(false);
            GameObject.Find("Mago").SetActive(false);
            GameObject.Find("Carrasco").SetActive(false);
            GameObject.Find("Gueirreiro").SetActive(false);
        }else if (playerNum == 2 && (this.name == "Assassino" || this.name == "Carrasco"))
        {
            
            GameObject.Find("Player3").SetActive(false);
            GameObject.Find("Player4").SetActive(false);
            GameObject.Find("Mago").SetActive(false);
            GameObject.Find("Gueirreiro").SetActive(false);
            
        }else if (playerNum == 3 && this.name != "Mago")
        {
            GameObject.Find("Player4").SetActive(false);
            GameObject.Find("Mago").SetActive(false);
        }
    }
    public void click()
    {
        stopRotate = true;
        acc += 1f;
        
        
    }
    public void check()
    {
        pause = true;
        Time.timeScale = 0;
    }
    public void uncheck()
    {
        pause = false;
        Time.timeScale = 1;
    }
    public void unclick()
    {
        stopRotate = false;
        if (acc > 0)
        {
            acc -= 0.9f;
        }
        
        
        
    }
    // Update is called once per frame
    void Update()
    {
        //stopRotate = false;
        //direction = GetComponent<ControlPlayer>().d;
        //Debug.Log("s" + direction);
        if (!stopRotate)
        {
            transform.Rotate(0f, 0f, 1f);
        }
        if (stopRotate && !pause)
        {
            angle = transform.eulerAngles.z;
            a = (angle * Mathf.PI) / 180 -80;
            direction = new Vector3(vel * Mathf.Cos(a), vel * Mathf.Sin(a), 0);
            transform.position +=  acc * direction * Time.deltaTime;
            Debug.Log("===" + direction);
            //Debug.Log(Mathf.Cos(angle));
            //Debug.Log(vel * Mathf.Cos(angle));
        }
        if (this.gameObject.activeSelf && !pause)
        {
            score += 1;

            
        }
       // Debug.Log(gameObject.name + ": " + score % 2);

    }
}
