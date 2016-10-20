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

	public void EndLvl(){
		tempScore = ViewInGame.instance.timer;
		scoreLabel.text = Mathf.Round(tempScore).ToString();
		highscoreLabel.text = PlayerPrefs.GetFloat("highscore", 0).ToString("f0");
	}
}
