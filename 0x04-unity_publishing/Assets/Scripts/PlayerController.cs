using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

///<summary>Handles player control</summary>
public class PlayerController : MonoBehaviour
{
    //<summary>Health value.</summary>
    private int health = 5;
    //<summary>Score value.</summary>
    private int score = 0;
    ///<summary>Player collision box.</summary>
    public Rigidbody body;
    ///<summary>Player speed.</summary>
    public float speed = 750;
    ///<summary>Text for score display.</summary>
    public Text scoreText;
    ///<summary>Text for health display.</summary>
    public Text healthText;
    ///<summary>Text for end of game display.</summary>
    public Text winLoseT;
    ///<summary>Background for end of game display.</summary>
    public Image winLoseB;

    ///<summary>FixedUpdate function.</summary>
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            body.AddForce(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            body.AddForce(0, 0, -speed * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            body.AddForce(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            body.AddForce(speed * Time.deltaTime, 0, 0);
        }

    }
    ///<summary>Collision actions functions.</summary>
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Pickup")
        {
            score++;
            //Debug.Log ("Score: " + score);
            SetScoreText();
            other.gameObject.SetActive(false);
        }
        if (other.tag == "Trap")
        {
            health--;
            SetHealthText();
            //Debug.Log ("Health: " + health);
        }
        if (other.tag == "Goal")
        {
            winLoseB.color = Color.green;
            winLoseT.color = Color.black;
            winLoseT.text = "You Win!";
            winLoseB.gameObject.SetActive(true);
            StartCoroutine(LoadScene(3));
            //Debug.Log ("You win!");
        }
    }
    ///<summary>Update function.</summary>
    void Update()
    {
        if (health <= 0)
        {
            winLoseT.text = "Game Over!";
            winLoseB.gameObject.SetActive(true);
            StartCoroutine(LoadScene(3));
            //Debug.Log ("Game Over!");
            //SceneManager.LoadScene("Maze", LoadSceneMode.Single);
        }
        if (Input.GetKey("escape"))
        {
            SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        }
    }
    ///<summary>Updates score display.</summary>
    void SetScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
    ///<summary>Updates health display.</summary>
    void SetHealthText()
    {
        healthText.text = "Health: " + health.ToString();
    }
    ///<summary>Controls game reloading.</summary>
    IEnumerator LoadScene(float seconds)
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Maze", LoadSceneMode.Single);
        score = 0;
        health = 5;
    }
}
