using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    private int min = 0;
    private float sec = 0.00f;
    private float thyme = 0f;
    private string text;

    // Update is called once per frame
    void Update()
    {
        thyme += Time.deltaTime;
        min = (int)(thyme / 60);
        sec = (thyme % 60f);
        text = min.ToString() + ":" + sec.ToString("00.00");
        timerText.text = text;
    }
}
