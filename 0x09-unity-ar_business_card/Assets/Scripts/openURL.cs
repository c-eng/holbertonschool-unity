using UnityEngine;

public class openURL : MonoBehaviour
{
    public void TWurl()
    {
        Application.OpenURL("https://twitter.com/c33Eng");
    }

    public void GHurl()
    {
        Application.OpenURL("https://github.com/c-eng");
    }

    public void INurl()
    {
        Application.OpenURL("https://www.linkedin.com/in/cameron-eng-5a8b7773/");
    }

    public void EMurl()
    {
        Application.OpenURL("mailto:388@holbertonschool.com");
    }
}
