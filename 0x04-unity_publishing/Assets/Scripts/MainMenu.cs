using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

///<summary>Handles menu behaviour.</summary>
public class MainMenu : MonoBehaviour
{
    ///<summary>Material for traps.</summary>
    public Material trapMat;
    ///<summary>Material for goal.</summary>
    public Material goalMat;
    ///<summary>Toggle for Colorblindmode.</summary>
    public Toggle colorblindMode;
    //<summary>Persists colorblind mode value.</summary>
    static private bool cbMode;

    ///<summary>Start function.</summary>
    public void Start ()
    {
        colorblindMode.isOn = cbMode;
    }
    ///<summary>Handles "Play" option from menu.</summary>
    public void PlayMaze()
    {
        cbMode = colorblindMode.isOn;
        if (cbMode)
        {
            trapMat.color = new Color32(255, 112, 0, 1);
            goalMat.color = Color.blue;
        }
        else
        {
            trapMat.color = Color.red;
            goalMat.color = Color.green;
        }
        SceneManager.LoadScene("Maze", LoadSceneMode.Single);
    }
    ///<summary>Handles "Quit" option from menu.</summary>
    public void QuitMaze()
    {
        Debug.Log("Quit Game");
    }
}
