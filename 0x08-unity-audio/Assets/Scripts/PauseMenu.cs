using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

///<summary>Handles Pause Menu UI.</summary>
public class PauseMenu : MonoBehaviour
{
    public Canvas pause;
    public GameObject cc;
    private Scene current;
    public AudioMixer master;
    public AudioMixerSnapshot unpaused;
    public AudioMixerSnapshot paused;

    //Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
            {
                Resume();
            }
    }
    ///<summary>Handles game pause behaviour.</summary>
    public void Pause()
    {
        pause.gameObject.SetActive(true);
        Time.timeScale = 0.0f;
        cc.gameObject.GetComponent<CameraController>().enabled = false;
        master.ClearFloat("BGM");
        paused.TransitionTo(0.01f);
    }
    ///<summary>Handles game resume behaviour.</summary>
    public void Resume()
    {
        Time.timeScale = 1.0f;
        cc.gameObject.GetComponent<CameraController>().enabled = true;
        pause.gameObject.SetActive(false);
        unpaused.TransitionTo(0.01f);
        master.SetFloat("BGM", Mathf.Log10(PlayerPrefs.GetFloat("bgm", 1f)) * 20);
    }
    ///<summary>Handles game restart behaviour.</summary>
    public void Restart()
    {
        Resume();
        current = SceneManager.GetActiveScene();
        SceneManager.LoadSceneAsync(current.buildIndex, LoadSceneMode.Single);
    }
    ///<summary>To options menu.</summary>
    public void Options()
    {
        current = SceneManager.GetActiveScene();
        PlayerPrefs.SetString("Prev", current.name);
        Resume();
        SceneManager.LoadSceneAsync("Options", LoadSceneMode.Single);
    }
    ///<summary>To main menu.</summary>
    public void MainMenu()
    {
        Resume();
        SceneManager.LoadSceneAsync("MainMenu", LoadSceneMode.Single);
    }
}
