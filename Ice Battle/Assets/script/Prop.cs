using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prop : MonoBehaviour
{
    public float speedMultiplier = 2.0f;
    private ControlSprites1 player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator waitAndPrint(float waitTime) {
        yield return new WaitForSeconds(waitTime);
        print("wait");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            collision.gameObject.SetActive(true);
           // player.isActiveAndEnabled = true;
            waitAndPrint(1);
            collision.gameObject.SetActive(false);
            //player.isActiveAndEnabled = false;

        }
    }
}
