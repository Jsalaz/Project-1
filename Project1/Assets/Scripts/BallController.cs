using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour
{
    public static BallController instance;

    public float speed = 2.0f;
    private Rigidbody rb;
    public bool isAlive;

    void Awake()
    {
        instance = this;
        isAlive = true;
    }

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ViewInGame.instance.countTime = true;
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        //Debug.Log (moveHorizontal + " " + moveVertical);
        if (isAlive)
        {
            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
            rb.AddForce(movement * speed);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Win()
    {

        Debug.Log(LevelManager.instance.getScene().name);

        isAlive = false;
        //rb.constraints = RigidbodyConstraints.FreezeAll;

        GameManager.instance.SetEndLvl();
        //Popuphighscorecanvas will call viewendlvl
        //ViewEndLvl.instance.EndLvl ();

        //other code for winning
        ViewInGame.instance.countTime = false;

        if (LevelManager.instance.getScene().name == "Level1")
        {
            if (PlayerPrefs.GetFloat("Level1", 0) == 0)
            {
                PlayerPrefs.SetFloat("Level1", ViewInGame.instance.timer);
            }

            else
            {
                if (PlayerPrefs.GetFloat("Level1", 0) > ViewInGame.instance.timer)
                {
                    PlayerPrefs.SetFloat("Level1", ViewInGame.instance.timer);
                }
            }
        }
        else if (LevelManager.instance.getScene().name == "Level2")
        {
            if (PlayerPrefs.GetFloat("Level2", 0) == 0)
            {
                PlayerPrefs.SetFloat("Level2", ViewInGame.instance.timer);
            }

            else
            {
                if (PlayerPrefs.GetFloat("Level2", 0) > ViewInGame.instance.timer)
                {
                    PlayerPrefs.SetFloat("Level2", ViewInGame.instance.timer);
                }
            }
        }

        else if (LevelManager.instance.getScene().name == "Level3")
        {
            if (PlayerPrefs.GetFloat("Level3", 0) == 0)
            {
                PlayerPrefs.SetFloat("Level3", ViewInGame.instance.timer);
            }

            else
            {
                if (PlayerPrefs.GetFloat("Level3", 0) > ViewInGame.instance.timer)
                {
                    PlayerPrefs.SetFloat("Level3", ViewInGame.instance.timer);
                }
            }
        }
    }

    public void Kill()
    {
        isAlive = false;
        //rb.constraints = RigidbodyConstraints.FreezeAll;

        GameManager.instance.SetGameOver();
        ViewGameOver.instance.GameOver();

        if (LevelManager.instance.getScene().name == "Level2")
        {
            GameManager.instance.gameOverCanvas.GetComponent<Canvas>().enabled = true;
        }

        if (LevelManager.instance.getScene().name == "Level3")
        {
            GameManager.instance.gameOverCanvas.GetComponent<Canvas>().enabled = true;
        }

        ViewInGame.instance.countTime = false;
    }
}
