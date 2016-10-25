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
		scoreLabel.text = "\n" + System.Math.Round(tempScore, 2).ToString();

        if (LevelManager.instance.getScene().name == "Level1")
        {
            highscoreLabel.text = "\n" + System.Math.Round(PlayerPrefs.GetFloat("Level1HighScore", 0), 2).ToString();
        }
        else if (LevelManager.instance.getScene().name == "Level2")
        {
            highscoreLabel.text = "\n" + System.Math.Round(PlayerPrefs.GetFloat("Level2HighScore", 0), 2).ToString();
        }

        else if (LevelManager.instance.getScene().name == "Level3")
        {
            highscoreLabel.text = "\n" + System.Math.Round(PlayerPrefs.GetFloat("Level3HighScore", 0), 2).ToString();
        }
	}
}
