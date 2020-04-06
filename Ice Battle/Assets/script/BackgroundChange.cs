using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundChange : MonoBehaviour
{
    private Vector3 changeScale;
    private bool pause;
    public float speed ;
    
    private void Start()
    {
        changeScale = new Vector3(-speed , -speed, 0);
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
        if (transform.localScale.x >= 1.5 && transform.localScale.y >= 1.5 && !pause)
        {      
            transform.localScale += changeScale;
        }
        
    }
}
