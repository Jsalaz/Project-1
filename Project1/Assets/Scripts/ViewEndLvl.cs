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

        if (LevelManager.instance.getScene().name == "Level1")
        {
            highscoreLabel.text = System.Math.Round(PlayerPrefs.GetFloat("Level1", 0), 2).ToString();
        }
        else if (LevelManager.instance.getScene().name == "Level2")
        {
            highscoreLabel.text = System.Math.Round(PlayerPrefs.GetFloat("Level2", 0), 2).ToString();
        }

        else if (LevelManager.instance.getScene().name == "Level3")
        {
            highscoreLabel.text = System.Math.Round(PlayerPrefs.GetFloat("Level3", 0), 2).ToString();
        }
        
    }

	public void EndLvl(){
		
	}
}
