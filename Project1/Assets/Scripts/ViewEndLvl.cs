using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ViewEndLvl : MonoBehaviour {

	public static ViewEndLvl instance;
	public Text scoreLabel;
	public Text highscoreLabel;
	public float tempScore;

	void Awake(){
		instance = this;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate()
    {
        tempScore = ViewInGame.instance.timer;
        scoreLabel.text = System.Math.Round(tempScore, 2).ToString();
        highscoreLabel.text = System.Math.Round(PlayerPrefs.GetFloat("highscore", 0), 2).ToString();
    }

	public void EndLvl(){
		
	}
}
