using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CircleSlider : MonoBehaviour
{
    public Image circleSlider;
    public float exValue = 60.0f; // 0 - 100, dont use int
    public TextMeshProUGUI exvalTxt;

    float circleTime = 1.0f;
    public float presentTime = 0.0f;


    void Start()
    {
        circleSlider.fillAmount = 0.0f;
        exvalTxt.enabled = false;
    }

    private void Update()
    {
        if (presentTime > circleTime)
        {
            presentTime = 10.0f;
            //Debug.Log("case end");
        }

        else
        {
            presentTime += Time.deltaTime;
            circleSlider.fillAmount = (Mathf.Lerp(0, 100, presentTime / circleTime) * (exValue / 10000));
            //Debug.Log(circleSlider.fillAmount);

            Invoke("EnableEx", 2f);

        }
    }

    public void EnableEx()
    {
        exvalTxt.enabled = true;
    }
}
