﻿using UnityEngine;
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
		//Should only work if program editing starts from MainMenu Scene
        //Debug.Log(LevelManager.instance.getScene().name);

        isAlive = false;
        //rb.constraints = RigidbodyConstraints.FreezeAll;

        GameManager.instance.SetEndLvl();
        //Popuphighscorecanvas will call viewendlvl
        //ViewEndLvl.instance.EndLvl ();

        //other code for winning
        ViewInGame.instance.countTime = false;
        float timef = ViewInGame.instance.timer;
		LevelManager.instance.SetTime(ViewInGame.instance.timer, true);

        //LevelManager.instance.totalScoreArray += ViewInGame.instance.timer;

        if (LevelManager.instance.getScene().name == "Level1")
        {
            if (PlayerPrefs.GetFloat("Level1HighScore", 0) == 0)
            {
                PlayerPrefs.SetFloat("Level1HighScore", ViewInGame.instance.timer);
                PlayerPrefs.SetFloat("Level1Score", ViewInGame.instance.timer);
                LevelManager.instance.totalScoreArray.Add(timef);
            }

            else
            {
                if (PlayerPrefs.GetFloat("Level1HighScore", 0) > ViewInGame.instance.timer)
                {
                    PlayerPrefs.SetFloat("Level1HighScore", ViewInGame.instance.timer);
                    PlayerPrefs.SetFloat("Level1Score", ViewInGame.instance.timer);
                    LevelManager.instance.totalScoreArray.Add(ViewInGame.instance.timer);
                }
                else
                {
                    PlayerPrefs.SetFloat("Level1Score", ViewInGame.instance.timer);
                    LevelManager.instance.totalScoreArray.Add(ViewInGame.instance.timer);
                }
                
            }
        }
        else if (LevelManager.instance.getScene().name == "Level2")
        {
            if (PlayerPrefs.GetFloat("Level2HighScore", 0) == 0)
            {
                PlayerPrefs.SetFloat("Level2HighScore", ViewInGame.instance.timer);
                PlayerPrefs.SetFloat("Level2Score", ViewInGame.instance.timer);
                LevelManager.instance.totalScoreArray.Add(ViewInGame.instance.timer);
            }

            else
            {
                if (PlayerPrefs.GetFloat("Level2HighScore", 0) > ViewInGame.instance.timer)
                {
                    PlayerPrefs.SetFloat("Level2HighScore", ViewInGame.instance.timer);
                    PlayerPrefs.SetFloat("Level2Score", ViewInGame.instance.timer);
                    LevelManager.instance.totalScoreArray.Add(ViewInGame.instance.timer);
                }
                else
                {
                    PlayerPrefs.SetFloat("Level2Score", ViewInGame.instance.timer);
                    LevelManager.instance.totalScoreArray.Add(ViewInGame.instance.timer);
                }
            }
        }

        else if (LevelManager.instance.getScene().name == "Level3")
        {
            if (PlayerPrefs.GetFloat("Level3HighScore", 0) == 0)
            {
                PlayerPrefs.SetFloat("Level3HighScore", ViewInGame.instance.timer);
                PlayerPrefs.SetFloat("Level3Score", ViewInGame.instance.timer);
                LevelManager.instance.totalScoreArray.Add(ViewInGame.instance.timer);
            }

            else
            {
                if (PlayerPrefs.GetFloat("Level3HighScore", 0) > ViewInGame.instance.timer)
                {
                    PlayerPrefs.SetFloat("Level3HighScore", ViewInGame.instance.timer);
                    PlayerPrefs.SetFloat("Level3Score", ViewInGame.instance.timer);
                    LevelManager.instance.totalScoreArray.Add(ViewInGame.instance.timer);
                }
                else
                {
                    PlayerPrefs.SetFloat("Level3Score", ViewInGame.instance.timer);
                    LevelManager.instance.totalScoreArray.Add(ViewInGame.instance.timer);
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
