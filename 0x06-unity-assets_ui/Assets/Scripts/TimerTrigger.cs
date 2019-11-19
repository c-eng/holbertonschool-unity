using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>Triggers a timer</summary>
public class TimerTrigger : MonoBehaviour
{
    //Begins timer
    void OnTriggerExit(Collider other)
    {
        if (other.name == "Player")
        {
            other.gameObject.GetComponent<Timer>().enabled = true;
        }
    }
}
