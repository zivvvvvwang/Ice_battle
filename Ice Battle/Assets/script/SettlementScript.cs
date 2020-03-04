using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettlementScript : MonoBehaviour
{
    public string[] arr; 
    public string punishment;
    public int index;
    public Text punishment_text;

    // Start is called before the first frame update
    void Start()
    {

        arr = new string[6];
        PunishmentScript.user_punishments.CopyTo(arr);
        //Debug
        Debug.Log("!!![Current punishment arr list in Punishment Cavans:");
        foreach (string a in arr) {
            Debug.Log(a);
        }

        index = Random.Range(0, 5);
        Debug.Log("Final punishment[:"+index+"]: "+ arr[index]);
        punishment = arr[index];
        punishment_text = GameObject.Find("Punishment_Text").GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        punishment_text.text = punishment;

    }
}
