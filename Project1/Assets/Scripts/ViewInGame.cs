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

    public static ViewInGame instance;

    void Awake()
    {
        instance = this;
    }

    void Update()
    {
        //if (GameManager.instance.currentGameState == GameState.inGame)
        //{
        //    scoreLabel.text = Mathf.Round(Time.time).ToString();
        
        //highscoreLabel.text = PlayerPrefs.GetFloat("highscore", 0).ToString("f0");
        //}
    }
    void FixedUpdate()
    {
        if(countTime)
            timer += Time.deltaTime;

        //if (GameManager.instance.currentGameState == GameState.inGame)
        //{
            //scoreLabel.text = Mathf.Round(Time.time).ToString();
            scoreLabel.text = Mathf.Round(timer).ToString();

            highscoreLabel.text = PlayerPrefs.GetFloat("highscore", 0).ToString("f0");
        //}

    }
}
