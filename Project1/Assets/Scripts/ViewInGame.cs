using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class ViewInGame : MonoBehaviour
{
    public Text scoreLabel;
    public Text highscoreLabel;
    public float endTime = 0;
    public float timer;
    public bool countTime;
    public float highScore = 0;

    public static ViewInGame instance;

    void Awake()
    {
        instance = this;
    }

    void Update()
    {

	}
    
	void FixedUpdate()
    {
        if(countTime)
            timer += Time.deltaTime;

        //if (GameManager.instance.currentGameState == GameState.inGame)
        //{
            //scoreLabel.text = Mathf.Round(Time.time).ToString();
            scoreLabel.text = "\n" + System.Math.Round(timer, 2).ToString();

        if (LevelManager.instance.getScene().name == "Level1")
        {
            highscoreLabel.text = "\n" + System.Math.Round(PlayerPrefs.GetFloat("Level1", 0), 2).ToString();
            highScore = PlayerPrefs.GetFloat("Level1", 0);
        }
        else if (LevelManager.instance.getScene().name == "Level2")
        {
            highscoreLabel.text = "\n" + System.Math.Round(PlayerPrefs.GetFloat("Level2", 0), 2).ToString();
            highScore = PlayerPrefs.GetFloat("Level2", 0);
        }

        else if (LevelManager.instance.getScene().name == "Level3")
        {
            highscoreLabel.text = "\n" + System.Math.Round(PlayerPrefs.GetFloat("Level3", 0), 2).ToString();
            highScore = PlayerPrefs.GetFloat("Level3", 0);
        }
        //}

    }
}
