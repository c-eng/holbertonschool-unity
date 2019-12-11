using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

///<summary>Stops a timer</summary>
public class WinTrigger : MonoBehaviour
{
    private bool won = false;
    //Triggers Win()
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player" && won == false)
        {
            won = true;
            other.gameObject.GetComponent<Timer>().Win();
        }
    }
}
