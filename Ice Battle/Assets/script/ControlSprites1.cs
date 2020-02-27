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
    private float a;
    private float vel = 1;
    

    //tart is called before the first frame update
    void Start()
    {
        stopRotate = false;
        pause = false;
        score = 0;
    }
    public void click()
    {
        stopRotate = true;
        
    }
    public void check()
    {
        pause = true;
    }
    public void uncheck()
    {
        pause = false;
    }
    public void unclick()
    {
        stopRotate = false;
        
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
            transform.position += direction * Time.deltaTime;
            Debug.Log("===" + angle);
            //Debug.Log(Mathf.Cos(angle));
            //Debug.Log(vel * Mathf.Cos(angle));
        }
        if (this.gameObject.activeSelf && !pause)
        {
            score += 1;

            
        }
        Debug.Log(gameObject.name + ": " + score % 2);

    }
}
