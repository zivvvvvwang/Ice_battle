using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CollisionCheck : MonoBehaviour
{
    public static float player_score;
    
    
    private void Start()
    {
        //player_num_check = GetComponent<Restart_Game>().player;
        player_score = Set_player_number.numberSliderGet;
        
        Debug.Log("........." + player_score);
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "dropdown_cyan")
        {
            
            this.gameObject.SetActive(false);
            player_score -= 1;

            if (player_score == 1 || player_score == 0)
            {
                SceneManager.LoadScene("pulishment");
            }
            Debug.Log(player_score);
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
            //Debug.Log("dir" +  gameObject.GetComponent<ControlSprites1>().direction);
            //Debug.Log("1");
        }
    }
    void Update()
    {
        
    }
}
