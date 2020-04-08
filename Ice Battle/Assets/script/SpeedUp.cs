using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    public ControlSprites1 player;
    public Rigidbody2D playerRB;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(this.gameObject);
            player = collision.GetComponent<ControlSprites1>();
            playerRB = player.GetComponent<Rigidbody2D>();
            collision.gameObject.transform.position += collision.GetComponent<ControlSprites1>().direction * 3.0f;
        }
    }
}
