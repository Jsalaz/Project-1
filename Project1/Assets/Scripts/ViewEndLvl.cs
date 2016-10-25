using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ViewEndLvl : MonoBehaviour
{

    public static ViewEndLvl instance;
    public Text scoreLabel;
    public Text highscoreLabel;
    public Text totalScoreLabel;
    public Text totalHighScoreLabel;
    public float tempScore;
    public float totalScore;
    bool countTime;
    float timer;

    void Awake()
    {
        instance = this;
    }

    // Use this for initialization
    void Start()
    {
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

            //if (PlayerPrefs.GetFloat("Level1Score", 0) == 0 || PlayerPrefs.GetFloat("Level2Score", 0) == 0 || PlayerPrefs.GetFloat("Level3Score", 0) == 0)
            //{

            totalHighScoreLabel.text = "\n\n" + System.Math.Round((PlayerPrefs.GetFloat("Level1HighScore", 0) + PlayerPrefs.GetFloat("Level2HighScore", 0) + PlayerPrefs.GetFloat("Level3HighScore", 0)), 2).ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        tempScore = ViewInGame.instance.timer;
        scoreLabel.text = "\n" + System.Math.Round(tempScore, 2).ToString();

    }

    public void EndLvl()
    {
        foreach (float f in LevelManager.instance.totalScoreArray)
        {
            //if (LevelManager.instance.totalScoreArray == 0 || LevelManager.instance.totalScoreArray[1] == 0 || LevelManager.instance.totalScoreArray[2] == 0)
            if (f == 0 || LevelManager.instance.totalScoreArray.Count != 3)
            {
                totalScoreLabel.text = "\n\n\n\nYou need to\nbeat all the\nlevels first";
            }
            else
            {
                //totalScore = PlayerPrefs.GetFloat("Level1Score", 0) + PlayerPrefs.GetFloat("Level2Score", 0) + PlayerPrefs.GetFloat("Level3Score", 0);
                //totalScore = LevelManager.instance.totalScoreArray;
                //totalScore = LevelManager.instance.totalScoreArray[0] + LevelManager.instance.totalScoreArray[1] + LevelManager.instance.totalScoreArray[2];
                totalScore += f;
                totalScoreLabel.text = "\n\n" + System.Math.Round(totalScore, 2).ToString();
            }
        }
    }
}
