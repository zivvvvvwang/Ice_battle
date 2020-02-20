using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundChange : MonoBehaviour
{
    private Vector3 changeScale;
    
    private void Start()
    {
        changeScale = new Vector3(-0.001f, -0.001f, 0);

        
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.localScale.x >= 1.5 && transform.localScale.y >= 1.5)
        {      
            transform.localScale += changeScale;
        }
        
    }
}
