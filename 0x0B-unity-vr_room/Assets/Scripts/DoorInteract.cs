using UnityEngine;

public class DoorInteract : MonoBehaviour
{
    public Animator doorAnimator;
    public Transform player;
    public GameObject mini;

    public void Interact()
    {
        if (InRange() && mini.GetComponent<PlateInteract>().triggered)
        {
            DoorTrigger();
        }
    }

    bool InRange()
    {
        float dist = Vector3.Distance(player.position, transform.position);
        if (dist <= 4f)
        {
            return (true);
        }
        return (false);
    }

    public void DoorTrigger()
    {
        doorAnimator.SetTrigger("DoorTrigger");
    }
}
