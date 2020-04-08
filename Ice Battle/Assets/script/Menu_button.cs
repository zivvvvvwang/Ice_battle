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
    public int mode;
    void Start()
    {
        mode = CartoonDropdown.modelNumber;
        Debug.Log("the scene:" + mode);
    }
    public void Click()
    {
        Debug.Log("click"+mode);
        if (mode == 1)
        {
            Debug.Log("aaaaa");
            SceneManager.LoadScene("InGamePlay");
        }
        else if (mode == 2)
        {
            Debug.Log("bbbbb");
            SceneManager.LoadScene("expert");
        }
    }

    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }

}
