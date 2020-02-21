using System;
using UnityEngine;

public class PlateInteract : MonoBehaviour
{
    public Transform player;
    public Transform pocket;
    public Transform target;
    private Camera main;
    public bool triggered = false;

    public void Interact()
    {
        if (InRange())
        {
            Debug.Log("In Range");
            if (pocket.childCount != 0 && String.Equals(pocket.GetChild(0).gameObject.name, "Exitmann"))
            {
                ExitmannDrop();
            }
        }
        else
        {
            Debug.Log("Not In Range");
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

    public void ExitmannDrop()
    {
        Transform dropping = pocket.GetChild(0);
        dropping.position = target.position;
        dropping.rotation = target.rotation;
        dropping.parent = null;
        /*dropping.GetComponent<Rigidbody>().isKinematic = false;*/
        triggered = true;
        dropping.gameObject.GetComponent<ObjectInteract>().enabled = false;
    }
}
