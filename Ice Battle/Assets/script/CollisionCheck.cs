using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollisionCheck : MonoBehaviour
{
    public int player_score;
    
    
    private void Start()
    {
        //player_num_check = GetComponent<Restart_Game>().player;
        player_score = 0;
        
        //Debug.Log(player_num_check);
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "dropdown_cyan")
        {
            
            this.gameObject.SetActive(false);
            
        }
        //Debug.Log(collision.gameObject.name);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("1");
        if (collision.gameObject.tag == "Player")
        {
            //collision.gameObject.transform.position += this.gameObject.GetComponent
            collision.gameObject.transform.position += gameObject.GetComponent<ControlSprites1>().direction * 0.3f;
            gameObject.transform.position -= gameObject.GetComponent<ControlSprites1>().direction * 0.3f;
            //Debug.Log(gameObject.transform.position);
            Debug.Log("dir" +  gameObject.GetComponent<ControlSprites1>().direction);
            //Debug.Log("1");
        }
    }
    void Update()
    {
        
    }
}
