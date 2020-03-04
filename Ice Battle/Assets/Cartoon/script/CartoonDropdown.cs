using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//This script manages the dropdown (or "dropup") menu

public class CartoonDropdown : MonoBehaviour
{
    public AnimationCurve curve;

    public float animationTime = 0.25f;

    private RectTransform content;
    private VerticalLayoutGroup vertGroup;

    private RectTransform background;

    private float yHeight;
    private float targetHeight;

    private Text nomal;
    private Text pops;
    private Text down;

    private int modelNumber;
    //-------
    private void Start()
    {
        nomal = GameObject.Find("nomalMode").GetComponent<Text>();
        pops = GameObject.Find("popMode").GetComponent<Text>();
        down = GameObject.Find("display").GetComponent<Text>();
        
    }

    void Awake()
    {
        content = GetComponent<RectTransform>();
        vertGroup = GetComponent<VerticalLayoutGroup>();
        background = gameObject.transform.parent.parent.GetComponentInParent<RectTransform>();

    }

    void OnEnable()
    {
        //calculate content size
        int chNumb = gameObject.transform.childCount;
        content.sizeDelta = new Vector2(content.sizeDelta.x, 350f * chNumb + vertGroup.spacing * chNumb);

        yHeight = content.sizeDelta.y + 250f;

        background.sizeDelta = new Vector2(background.sizeDelta.x, 80f);
    }


    //sliding up animation
    IEnumerator SlideUp()
    {

        float startPos = background.sizeDelta.y;

        float eTime = 0f;

        float track = targetHeight - startPos;

        while (eTime < animationTime)
        {

            float yPos = curve.Evaluate(eTime / animationTime) * track;

            background.sizeDelta = new Vector2(background.sizeDelta.x, startPos + yPos);

            yield return null;

            eTime += Time.unscaledDeltaTime;

        }

        background.sizeDelta = new Vector2(background.sizeDelta.x, targetHeight);

    }

    //toggle dropdown
    public void SlideButton() {

        if (background.sizeDelta.y != yHeight)
        {

            targetHeight = yHeight;
        }
        else
        {

            targetHeight = 80f;
        }

        StartCoroutine("SlideUp");
    }

    public void changeNomalContext()
    {
        down.text = nomal.text;
       // GetComponent<Model_Static_value>().model_choose(0);
//        modelNumber.model_choose(0);
        Debug.Log(modelNumber);
        //StartCoroutine("SlideUp");
    }
    public void changePopContext()
    {
        down.text = pops.text;
 //       modelNumber.model_choose(1);
        //StartCoroutine("SlideUp");
    }
}
