using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSprites1 : MonoBehaviour
{
    //public GameObject character;
    public bool stopRotate = false;
    
    //tart is called before the first frame update
    void Start()
    {
        
    }
    //public void click()
    //{
    //    stopRotate = true;
    //}
    // Update is called once per frame
    void Update()
    {
        //stopRotate = false;
        if (!stopRotate)
        {
            transform.Rotate(0f, 0f, 1f);
        }
        if (transform.position.y < 0)
        {
            Destroy(this);
        }
        
    }
}
