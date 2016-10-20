using UnityEngine;
using System.Collections;

public enum GameState
{
    //menu,
    inGame,
    endLevel,
    gameOver,
    popUp,
}

public class GameManager : MonoBehaviour
{
    //canvases
    public Canvas inGameCanvas;
    public Canvas endLvlCanvas;
    public Canvas gameOverCanvas;
    //<<<<<<< HEAD
    public Canvas PopupHighScoreCanvas;
    //=======

    //singleton
    //>>>>>>> b5fd6b2fe9610a5a6895843515f3b71ba55f7f17
    public static GameManager instance;
    //enum game state instance
    public GameState currentGameState;// = GameState.inGame; 

    // Use this for initialization
    void Awake()
    {
        instance = this;
        //currentGameState = GameState.inGame;
    }

    void Start()
    {
        //<<<<<<< HEAD
        //currentGameState = GameState.menu;
        PopupHighScoreCanvas.GetComponent<Canvas>().enabled = false;
        //=======
        currentGameState = GameState.inGame;
        endLvlCanvas.enabled = false;
        //>>>>>>> b5fd6b2fe9610a5a6895843515f3b71ba55f7f17
    }

    void SetGameState(GameState newGameState)
    {
        if (newGameState == GameState.inGame)
        {
            //setup Unity scene for inGame state
            inGameCanvas.enabled = true;
            //gameOverCanvas.enabled = false;
            endLvlCanvas.enabled = false;
            PopupHighScoreCanvas.enabled = false; //endLevelCanvas >> PopupHighScoreCanvas
        }
        else if (newGameState == GameState.gameOver)
        {
            //setup Unity scene for gameOver state
            inGameCanvas.enabled = false;
            //gameOverCanvas.enabled = true;
            endLvlCanvas.enabled = false;
            PopupHighScoreCanvas.enabled = false;
        }
        else if (newGameState == GameState.popUp)
        {
            inGameCanvas.enabled = false;
            //gameOverCanvas.enabled = false;
            endLvlCanvas.enabled = false;
            PopupHighScoreCanvas.enabled = true;
        }
        else if (newGameState == GameState.endLevel)
        {
            inGameCanvas.enabled = false;
            //gameOverCanvas.enabled = false;
            endLvlCanvas.enabled = true;
            PopupHighScoreCanvas.enabled = false;
        }

        currentGameState = newGameState;
    }

    public void SetEndLvl()
    {
        SetGameState(GameState.endLevel);
    }

    public void SetGameOver()
    {
        SetGameState(GameState.gameOver);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
