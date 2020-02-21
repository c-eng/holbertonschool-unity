using System;
using UnityEngine;

public class DoorTriggerInteract : MonoBehaviour
{
    public Animator doorAnimator;
    public Transform player;
    public GameObject plate;
    private GetAnimatorStateName aniName;
    private PlateInteract plateTrigger;
    public bool triggered;

    void Start()
    {
        aniName = GetComponent<GetAnimatorStateName>();
        plateTrigger = plate.GetComponent<PlateInteract>();
    }

    public void Interact()
    {
        triggered = plateTrigger.triggered;
        if (InRange() && !triggered)
        {
            DoorTrigger();
        }

    }

    bool InRange()
    {
        float dist = Vector3.Distance(player.position, transform.position);
        if (dist <= 3f)
        {
            return (true);
        }
        return (false);
    }

    public void DoorTrigger()
    {
        doorAnimator.SetTrigger("DoorTrigger");
        string temp = aniName.GetCurrentAnimatorStateName();
        if (String.Equals(temp, "glass_door_closed"))
        {
            plate.SetActive(true);
        }
        else
        {
            plate.SetActive(false);
        }
    }
}
