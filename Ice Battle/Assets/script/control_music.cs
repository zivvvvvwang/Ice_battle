using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control_music : MonoBehaviour
{
    private bool status;
    private void Start()
    {
        status = true;
    }
    // Start is called before the first frame update
    public void click()
    {
        if (AudioListener.pause == true)
        {
            AudioListener.pause = false;
        }
        else
        {
            AudioListener.pause = true;
        }
        
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
