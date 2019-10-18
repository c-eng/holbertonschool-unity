using UnityEngine;

///<summary>Handles camera control.</summary>
public class CameraController : MonoBehaviour
{
    ///<summary>Player to follow.</summary>
    public GameObject player;
    ///<summary>Offset from player object.</summary>
    public Vector3 offset;

    ///<summary>Update function.</summary>
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
