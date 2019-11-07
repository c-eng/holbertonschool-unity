using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

///<summary>Stops a timer</summary>
public class WinTrigger : MonoBehaviour
{
    public Text timerText;

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            other.gameObject.GetComponent<Timer>().enabled = false;
            timerText.fontSize = 72;
            timerText.color = Color.green;
        }
    }
}
