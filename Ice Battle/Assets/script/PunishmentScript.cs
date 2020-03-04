using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PunishmentScript : MonoBehaviour
{

    public static List<string> default_punishments;
    public static List<string> user_punishments;
    public static List<InputField> input_text;

    // Start is called before the first frame update
    void Start()
    {

        user_punishments = new List<string>();
        input_text = new List<InputField>();
        input_text.Add(GameObject.Find("Punishment_1").GetComponent<InputField>());
        input_text.Add(GameObject.Find("Punishment_2").GetComponent<InputField>());
        input_text.Add(GameObject.Find("Punishment_3").GetComponent<InputField>());
        input_text.Add(GameObject.Find("Punishment_4").GetComponent<InputField>());
        input_text.Add(GameObject.Find("Punishment_5").GetComponent<InputField>());
        input_text.Add(GameObject.Find("Punishment_6").GetComponent<InputField>());

        default_punishments = new List<string>();
        default_punishments.Add("Go Outside And Dance Like A Cowboy.");
        default_punishments.Add("Do A Model Runway Walk Outside On The Sidewalk.");
        default_punishments.Add("Pour A Cup Of Ice Cold Or Hot Water On Yourself Outside");
        default_punishments.Add("Stand In You Front Yard, Wave And Say ‘Hi!’ To Everyone You See.");
        default_punishments.Add("Call Your Crush And Explain The Rules Of Monopoly To Him/Her.");
        default_punishments.Add("Everything You Say For The Next 15 Minutes Must Be Sung To The Tune Of “Happy Birthday”.");


        foreach (string p in default_punishments)
        {
            user_punishments.Add(p);
        }

        for (int i = 0; i < default_punishments.Count; i++) {
            input_text[i].text = default_punishments[i];
        }

        //Debug
        print("Default Punishment :");
        foreach (string punishment in default_punishments)
        {
            print(punishment);
        }

        print("User Punishment:");
        foreach (string punishment in user_punishments)
        {
            print(punishment);
        }

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < default_punishments.Count; i++)
        {
            if (input_text[i].text.Length < 1)
            {
                input_text[i].text = default_punishments[i];

            }
            user_punishments[i] = input_text[i].text;

        }

    }

}
