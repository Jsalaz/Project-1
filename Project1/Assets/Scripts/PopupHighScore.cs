using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PopupHighScore : MonoBehaviour
{ 
    public Text winTime;
    public Text loseTime;
    public Text winText;
    public Text loseText;
    public Text highScoreLabel;
    public float timerf;

    public float oldHighScore1;
    public float oldHighScore2;
    public float oldHighScore3;

    //public float timer;
    //public bool countTime;

    public static PopupHighScore instance;

    void Awake()
    {
        instance = this;
        oldHighScore1 = PlayerPrefs.GetFloat("Level1HighScore", 0);
        oldHighScore2 = PlayerPrefs.GetFloat("Level2HighScore", 0);
        oldHighScore3 = PlayerPrefs.GetFloat("Level3HighScore", 0);
    }

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        //if(countTime)
        //    timer += Time.deltaTime;

        if (LevelManager.instance.getScene().name == "Level1")
        {
            highScoreLabel.text = "\n" + System.Math.Round((PlayerPrefs.GetFloat("Level1HighScore", 0)), 2).ToString();

            if (ViewInGame.instance.timer < oldHighScore1 || oldHighScore1 == 0) //(PlayerPrefs.GetFloat("Level1", 0))
            {
                PopupHighScore.instance.winText.GetComponent<Text>().enabled = true;
                PopupHighScore.instance.loseText.GetComponent<Text>().enabled = false;
                PopupHighScore.instance.winTime.GetComponent<Text>().enabled = true;
                PopupHighScore.instance.winTime.text = System.Math.Round((ViewInGame.instance.timer - oldHighScore1), 2).ToString();
                //PopupHighScore.instance.winTime.text = ((ViewInGame.instance.timer - float.Parse(highScoreLabel.text) * 100f) / 100f).ToString();
                PopupHighScore.instance.loseTime.GetComponent<Text>().enabled = false;
            }
            else
            {
                //Debug.Log();
                PopupHighScore.instance.winText.GetComponent<Text>().enabled = false;
                PopupHighScore.instance.loseText.GetComponent<Text>().enabled = true;
                PopupHighScore.instance.loseTime.GetComponent<Text>().enabled = true;
                PopupHighScore.instance.loseTime.text = "+" + System.Math.Round((ViewInGame.instance.timer - oldHighScore1), 2).ToString();
                //PopupHighScore.instance.loseTime.text = ((ViewInGame.instance.timer - float.Parse(highScoreLabel.text) * 100f) / 100f).ToString();
                PopupHighScore.instance.winTime.GetComponent<Text>().enabled = false;
            }
        }
        else if (LevelManager.instance.getScene().name == "Level2")
        {
            highScoreLabel.text = "\n" + System.Math.Round((PlayerPrefs.GetFloat("Level2HighScore", 0)), 2).ToString();

            if (ViewInGame.instance.timer < oldHighScore2 || oldHighScore2 == 0) //if(PlayerPrefs.GetFloat("highscore", 0) > ViewInGame.instance.timer)
            {
                PopupHighScore.instance.winText.GetComponent<Text>().enabled = true;
                PopupHighScore.instance.loseText.GetComponent<Text>().enabled = false;
                PopupHighScore.instance.winTime.GetComponent<Text>().enabled = true;
                PopupHighScore.instance.winTime.text = System.Math.Round((ViewInGame.instance.timer - oldHighScore2), 2).ToString();
                //PopupHighScore.instance.winTime.text = ((ViewInGame.instance.timer - float.Parse(highScoreLabel.text) * 100f) / 100f).ToString();
                PopupHighScore.instance.loseTime.GetComponent<Text>().enabled = false;
            }
            else
            {
                //Debug.Log();
                PopupHighScore.instance.winText.GetComponent<Text>().enabled = false;
                PopupHighScore.instance.loseText.GetComponent<Text>().enabled = true;
                PopupHighScore.instance.loseTime.GetComponent<Text>().enabled = true;
                PopupHighScore.instance.loseTime.text = "+" + System.Math.Round((ViewInGame.instance.timer - oldHighScore2), 2).ToString();
                //PopupHighScore.instance.loseTime.text = ((ViewInGame.instance.timer - float.Parse(highScoreLabel.text) * 100f) / 100f).ToString();
                PopupHighScore.instance.winTime.GetComponent<Text>().enabled = false;
            }
        }

        else if (LevelManager.instance.getScene().name == "Level3")
        {
            highScoreLabel.text = "\n" + System.Math.Round((PlayerPrefs.GetFloat("Level3HighScore", 0)), 2).ToString();

            if (ViewInGame.instance.timer < oldHighScore3 || oldHighScore3 == 0) //if(PlayerPrefs.GetFloat("highscore", 0) > ViewInGame.instance.timer)
            {
                PopupHighScore.instance.winText.GetComponent<Text>().enabled = true;
                PopupHighScore.instance.loseText.GetComponent<Text>().enabled = false;
                PopupHighScore.instance.winTime.GetComponent<Text>().enabled = true;
                PopupHighScore.instance.winTime.text = System.Math.Round((ViewInGame.instance.timer - oldHighScore3), 2).ToString();
                //PopupHighScore.instance.winTime.text = ((ViewInGame.instance.timer - float.Parse(highScoreLabel.text) * 100f) / 100f).ToString();
                PopupHighScore.instance.loseTime.GetComponent<Text>().enabled = false;
            }
            else
            {
                //Debug.Log();
                PopupHighScore.instance.winText.GetComponent<Text>().enabled = false;
                PopupHighScore.instance.loseText.GetComponent<Text>().enabled = true;
                PopupHighScore.instance.loseTime.GetComponent<Text>().enabled = true;
                PopupHighScore.instance.loseTime.text = "+" + System.Math.Round((ViewInGame.instance.timer - oldHighScore3), 2).ToString();
                //PopupHighScore.instance.loseTime.text = ((ViewInGame.instance.timer - float.Parse(highScoreLabel.text) * 100f) / 100f).ToString();
                PopupHighScore.instance.winTime.GetComponent<Text>().enabled = false;
            }
        }

        
    }

    void Update()
    {
        
    }
}
