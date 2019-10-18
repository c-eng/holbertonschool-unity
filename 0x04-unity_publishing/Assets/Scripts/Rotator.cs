using UnityEngine;

///<summary>Rotates objects.</summary>
public class Rotator : MonoBehaviour
{
    ///<summary>Update function.</summary>
    void Update()
    {
        transform.Rotate(45 * Time.deltaTime, 0, 0, Space.Self);
    }
}
