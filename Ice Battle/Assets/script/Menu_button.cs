using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_button : MonoBehaviour
{
    //public GameObject bb;
    // Start is called before the first frame update
    public void start_button(string scenesName)
    {
        SceneManager.LoadScene(scenesName);
    }

    
}
