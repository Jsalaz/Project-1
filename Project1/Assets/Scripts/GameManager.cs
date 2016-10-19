using UnityEngine;
using System.Collections;

public enum GameState
{
    //menu,
    inGame,
    gameOver,
}

public class GameManager : MonoBehaviour
{
    public Canvas inGameCanvas;
    //public Canvas menuCanvas;
    public Canvas gameOverCanvas;
    public static GameManager instance;
    public GameState currentGameState = GameState.inGame; // = GameState.menu;

    // Use this for initialization
    void Awake ()
    {
        instance = this;
	}

    void Start()
    {
        //currentGameState = GameState.menu;
    }

    void SetGameState(GameState newGameState)
    {
        //if (newGameState == GameState.menu)
        //{
        //    //setup Unity scene for menu state
        //    //menuCanvas.enabled = true;
        //    inGameCanvas.enabled = false;
        //    gameOverCanvas.enabled = false;
        //}
        if (newGameState == GameState.inGame)
        {
            //setup Unity scene for inGame state
            //menuCanvas.enabled = false;
            inGameCanvas.enabled = true;
            gameOverCanvas.enabled = false;
        }
        else if (newGameState == GameState.gameOver)
        {
            //setup Unity scene for gameOver state
            //menuCanvas.enabled = false;
            inGameCanvas.enabled = false;
            gameOverCanvas.enabled = true;
        }
        //else if (newGameState == GameState.levelTwo)
        //{
        //    menuCanvas.enabled = false;
        //    inGameCanvas.enabled = false;
        //    GameOverCanvas.enabled = false;
        //    level2Canvas.enabled = true;
        //}
        currentGameState = newGameState;
    }

    // Update is called once per frame
    void Update ()
    {
	
	}
}
