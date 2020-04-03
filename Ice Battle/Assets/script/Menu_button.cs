using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_button : MonoBehaviour
{
    private int mode;
    //public GameObject bb;
    // Start is called before the first frame update
    void Start()
    {
        mode = CartoonDropdown.modelNumber;
    }


    public void Click()
    {
        Debug.Log(mode);
        if (mode == 1)
        {
            Debug.Log("aaaaaa");
            SceneManager.LoadScene("InGamePlay");
        }else if (mode == 2)
        {
            Debug.Log("bbbbbb");
            SceneManager.LoadScene("expert");
         
        }
    }
   

    
}
