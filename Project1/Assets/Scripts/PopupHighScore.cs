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

    //public float timer;
    //public bool countTime;

    public static PopupHighScore instance;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        //if(countTime)
        //    timer += Time.deltaTime;

        highScoreLabel.text = System.Math.Round((PlayerPrefs.GetFloat("highscore", 0)), 2).ToString();
        if (ViewInGame.instance.timer < (PlayerPrefs.GetFloat("highscore", 0))) //if(PlayerPrefs.GetFloat("highscore", 0) > ViewInGame.instance.timer)
        {
            PopupHighScore.instance.winText.GetComponent<Text>().enabled = true;
            PopupHighScore.instance.loseText.GetComponent<Text>().enabled = false;
            PopupHighScore.instance.winTime.GetComponent<Text>().enabled = true;
            PopupHighScore.instance.winTime.text = System.Math.Round((ViewInGame.instance.timer - (PlayerPrefs.GetFloat("highscore", 0))), 2).ToString();
            //PopupHighScore.instance.winTime.text = ((ViewInGame.instance.timer - float.Parse(highScoreLabel.text) * 100f) / 100f).ToString();
            PopupHighScore.instance.loseTime.GetComponent<Text>().enabled = false;
        }
        else
        {
            //Debug.Log();
            PopupHighScore.instance.winText.GetComponent<Text>().enabled = false;
            PopupHighScore.instance.loseText.GetComponent<Text>().enabled = true;
            PopupHighScore.instance.loseTime.GetComponent<Text>().enabled = true;
            PopupHighScore.instance.loseTime.text = "+" + System.Math.Round((ViewInGame.instance.timer - (PlayerPrefs.GetFloat("highscore", 0))), 2).ToString();
            //PopupHighScore.instance.loseTime.text = ((ViewInGame.instance.timer - float.Parse(highScoreLabel.text) * 100f) / 100f).ToString();
            PopupHighScore.instance.winTime.GetComponent<Text>().enabled = false;
        }
    }

    void Update()
    {
        
    }
}
