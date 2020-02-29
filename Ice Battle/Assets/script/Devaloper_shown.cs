using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Devaloper_shown : MonoBehaviour
{
    // Start is called before the first frame update


    void Start()
    {
        gameObject.SetActive(false);
    }
    public void onShown()
    {
        gameObject.SetActive(true);
    }

    public void close()
    {
        gameObject.SetActive(false);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
