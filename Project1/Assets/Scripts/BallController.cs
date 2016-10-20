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
        isAlive = false;
		//rb.constraints = RigidbodyConstraints.FreezeAll;
        
		GameManager.instance.SetEndLvl ();
        //Popuphighscorecanvas will call viewendlvl
		//ViewEndLvl.instance.EndLvl ();

//<<<<<<< HEAD
//=======
		//other code for winning
        ViewInGame.instance.countTime = false;

//>>>>>>> b5fd6b2fe9610a5a6895843515f3b71ba55f7f17
        if (PlayerPrefs.GetFloat("highscore", 0) > ViewInGame.instance.timer)
        {
            PlayerPrefs.SetFloat("highscore", ViewInGame.instance.timer);
        }
    }

    public void Kill()
    {
        isAlive = false;
		rb.constraints = RigidbodyConstraints.FreezeAll;

		GameManager.instance.SetGameOver ();
		ViewGameOver.instance.GameOver();

        ViewInGame.instance.countTime = false;
    }
}
