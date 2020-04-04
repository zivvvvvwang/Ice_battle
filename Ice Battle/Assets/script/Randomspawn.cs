using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomspawn : MonoBehaviour
{
    public GameObject prop;
    public Transform trans;
    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(-7f, 7f);
        float y = Random.Range(-3f, 3f);
        Instantiate(prop, new Vector3(x, y, 0f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
