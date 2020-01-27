using UnityEngine;

///<summary>Handles Button Animation.</summary>
public class ButtonScale : MonoBehaviour
{
    private Transform button;

    void Start()
    {
        button = GetComponent<Transform>();
    }

    ///<summary>Triggers button scale up animation.</summary>
    public void ButtonScaleUp()
    {
        button.localScale = new Vector3(1.2f, 1.2f, 1.2f);
    }

    ///<summary>Triggers button scale down animation.</summary>
    public void ButtonScaleDown()
    {
        button.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }
}
