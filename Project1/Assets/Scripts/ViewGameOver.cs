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

        if (LevelManager.instance.getScene().name == "Level1")
        {
            highscoreLabel.text = PlayerPrefs.GetFloat("Level1", 0).ToString("f0");
        }
        else if (LevelManager.instance.getScene().name == "Level2")
        {
            highscoreLabel.text = PlayerPrefs.GetFloat("Level2", 0).ToString("f0");
        }

        else if (LevelManager.instance.getScene().name == "Level3")
        {
            highscoreLabel.text = PlayerPrefs.GetFloat("Level3", 0).ToString("f0");
        }
	}
}
