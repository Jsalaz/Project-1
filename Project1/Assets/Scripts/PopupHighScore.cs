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

    public static PopupHighScore instance;

    void Awake()
    {
        instance = this;
        timerf = ViewInGame.instance.timer;
    }

    void Start()
    {
        highScoreLabel.text = (PlayerPrefs.GetFloat("highscore", 0)).ToString("f0");
        Debug.Log(float.Parse(highScoreLabel.text));
        if (float.Parse(highScoreLabel.text) > timerf) //if(PlayerPrefs.GetFloat("highscore", 0) > ViewInGame.instance.timer)
        {
            PopupHighScore.instance.winText.GetComponent<Text>().enabled = true;
            PopupHighScore.instance.loseText.GetComponent<Text>().enabled = false;
            PopupHighScore.instance.winTime.text = (((ViewInGame.instance.timer - ViewInGame.instance.highScore) * 100f) / 100f).ToString();
            //PopupHighScore.instance.winTime.text = ((ViewInGame.instance.timer - float.Parse(highScoreLabel.text) * 100f) / 100f).ToString();
            PopupHighScore.instance.loseTime.GetComponent<Text>().enabled = false;
        }
        else
        {
            PopupHighScore.instance.winText.GetComponent<Text>().enabled = false;
            PopupHighScore.instance.loseText.GetComponent<Text>().enabled = true;
            PopupHighScore.instance.loseTime.text = (((ViewInGame.instance.timer - ViewInGame.instance.highScore) * 100f) / 100f).ToString();
            //PopupHighScore.instance.loseTime.text = ((ViewInGame.instance.timer - float.Parse(highScoreLabel.text) * 100f) / 100f).ToString();
            PopupHighScore.instance.winTime.GetComponent<Text>().enabled = false;
        }
    }
}
