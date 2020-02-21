using UnityEngine;

public class ProjectorInteract : MonoBehaviour
{
    public GameObject particleSystem;
    public Transform player;

    public void Interact()
    {
        if (InRange())
        {
            ParticleActivate();
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

    public void ParticleActivate()
    {
        if (particleSystem.activeInHierarchy == false)
        {
            particleSystem.SetActive(true); 
        }
    }
}
