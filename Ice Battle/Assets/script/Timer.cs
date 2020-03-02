using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text TimerText;
    public bool pause;
    private float start_time;
    // Start is called before the first frame update
    void Start()
    {
        start_time = Time.time;
        pause = false;
    }
    public void click()
    {
        
        pause = true;
    }
    public void unclick()
    {
        
        pause = false;
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - start_time;

        string minutes = ((int)t / 60).ToString();
        string second = (t % 60).ToString("f2");

        TimerText.text = minutes + ":" + second;

    }
}
