using UnityEngine;

public class InteractableHighlight : MonoBehaviour
{
    public Material hiMat;
    private Material baseMat;
    private Renderer baseRender;

    void Start()
    {
        baseRender = GetComponent<Renderer>();
        baseMat = GetComponent<Renderer>().material;
    }

    public void HighlightInteractable()
    {
        baseRender.material = hiMat;
    }

    public void UnhighlightInteractable()
    {
        baseRender.material = baseMat;
    }
}
