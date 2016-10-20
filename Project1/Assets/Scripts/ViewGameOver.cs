using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ViewGameOver : MonoBehaviour {

	public static ViewGameOver instance;
	public Text scoreLabel;
	public Text highscoreLabel;
	public float tempScore;

	void Awake(){
		instance = this;
	}

	public void GameOver(){
		tempScore = ViewInGame.instance.timer;
		scoreLabel.text = Mathf.Round(tempScore).ToString();
		highscoreLabel.text = PlayerPrefs.GetFloat("highscore", 0).ToString("f0");
	}

}
