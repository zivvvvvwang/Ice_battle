using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundCheck : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.tag == "Player")
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0.0f, 0.0f);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {

        //Debug.Log("++++" + collision.gameObject.GetComponent<Rigidbody2D>().velocity);
        //Debug.Log("!!!!!!!!!");
        Debug.Log(collision.gameObject.name);

        if (collision.gameObject.name == "wall")
        {
            Debug.Log("!!!!!!!!!");
            Debug.Log("!!!!!!!!!");

        }
        //Debug.Log(collision.gameObject.name);
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        Debug.Log("+++++++++");
        Debug.Log("+++++++++");
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "wall")
        {
            Debug.Log("+++++++++");
            Debug.Log("+++++++++");
            //this.gameObject.;
            gameObject.transform.position -= gameObject.GetComponent<ControlSprites1>().direction * 0.1f;

        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
