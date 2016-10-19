using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class ViewInGame : MonoBehaviour
{
    public Text scoreLabel;

    public static ViewInGame instance;

    void Awake()
    {
        instance = this;
    }

    void Update()
    {
        //if (GameManager.instance.currentGameState == GameState.inGame)
        //{
            scoreLabel.text = Mathf.Round(Time.time).ToString();
        //}
    }
}
