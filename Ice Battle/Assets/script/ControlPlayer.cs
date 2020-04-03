using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
    public GameObject characters;
    // Start is called before the first frame update
    private ControlSprites1 player;
    private float thrust = 2.0f;
    private Vector3 curv;
    private Rigidbody rb;

    void Start()
    {
        player = characters.GetComponent<ControlSprites1>();
        Debug.Log(player);
        rb = player.GetComponent<Rigidbody>();
        //curv = player.rb.velocity;
    }

    public void click()
    {

        player.isActiveAndEnabled = true;
        Debug.Log(player.isActiveAndEnabled);
        //player.rb.AddForce(player.transform.up * thrust);
    }

    public void unclic()
    {
        player.isActiveAndEnabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        //print(curv);
    }
}
