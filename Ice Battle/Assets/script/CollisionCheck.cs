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
        if (gameObject.tag == "Player")
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0.0f,0.0f);
        }

        Debug.Log("........." + player_score);
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "dropdown_cyan")
        {
            this.gameObject.GetComponent<ControlSprites1>().score -= 100;
            this.gameObject.SetActive(false);
            
            player_score -= 1;
            
            if (player_score == 1 || player_score == 0)
            {
                SceneManager.LoadScene("punishment");
            }
            Debug.Log(player_score);
        }
        //Debug.Log(collision.gameObject.name);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("1");
        if (collision.gameObject.tag == "Player" && gameObject.tag == "Player")
        {
            //collision.gameObject.transform.position += this.gameObject.GetComponent
            //collision.gameObject.transform.position += gameObject.GetComponent<ControlSprites1>().direction * 0.3f;
            //collision.gameObject.GetComponent<Rigidbody>().velocity += ;
            //Debug.Log(gameObject.transform.position);
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(Mathf.Cos(gameObject.GetComponent<ControlSprites1>().direction.x), Mathf.Sin(gameObject.GetComponent<ControlSprites1>().direction.y));
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(-1 * Mathf.Cos(gameObject.GetComponent<ControlSprites1>().direction.x), -1 * Mathf.Sin(gameObject.GetComponent<ControlSprites1>().direction.y));
            //gameObject.GetComponent<Rigidbody2D>().MovePosition(gameObject.GetComponent<Rigidbody2D>().velocity * -0.1f);
            //gameObject.transform.position -= 0.5f * new Vector3(gameObject.GetComponent<Rigidbody2D>().velocity.x, gameObject.GetComponent<Rigidbody2D>().velocity.y, 1f);
            //collision.gameObject.transform.position += 0.5f * new Vector3(gameObject.GetComponent<Rigidbody2D>().velocity.x, gameObject.GetComponent<Rigidbody2D>().velocity.y, 1f);
            collision.gameObject.transform.position += gameObject.GetComponent<ControlSprites1>().direction * 0.2f;
            gameObject.transform.position -= gameObject.GetComponent<ControlSprites1>().direction * 0.1f;

            Debug.Log("vel" +  collision.gameObject.GetComponent<Rigidbody2D>().velocity);
            //Debug.Log("1");
        }
    }
    void Update()
    {
        if (gameObject.tag == "Player")
        {
            gameObject.GetComponent<Rigidbody2D>().velocity *= 0.99f;
        }
        
    }
}
