using UnityEngine;

///<summary>Handles info button interaction.</summary>
public class InfoTog : MonoBehaviour
{
    public Transform buttonCanvas;

    ///<summary>Toggles info panels.</summary>
    public void InfoToggle(string panelName)
    {
        Transform ui = buttonCanvas.Find(panelName.Substring(0, 2) + "UI");
        Transform panel = ui.Find(panelName);
        if (panel.gameObject.activeSelf)
        {
            panel.gameObject.SetActive(false);
        }
        else
        {
            panel.gameObject.SetActive(true);
        }
    }
}
