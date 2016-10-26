using UnityEngine;
using System.Collections;

public enum GameState
{
    //menu,
    inGame,
    gameOver,
    endLevel,
    popUp,
}

public class GameManager : MonoBehaviour
{
    //canvases
    public Canvas inGameCanvas;
    public Canvas endLvlCanvas;
    public Canvas gameOverCanvas;
    public Canvas PopupHighScoreCanvas;
    


    //singleton
    public static GameManager instance;
    //enum game state instance
    public GameState currentGameState;// = GameState.inGame; 

    // Use this for initialization
    void Awake()
    {
        instance = this;

        //totalScore = new ArrayList();

        //PlayerPrefs.DeleteAll();

        //Debug.Log(System.Math.Round((PlayerPrefs.GetFloat("Level1", 0)), 2));
    }

    void Start()
    {
        //currentGameState = GameState.menu;
        //PopupHighScoreCanvas.GetComponent<Canvas>().enabled = false;

        currentGameState = GameState.inGame; //GameManager.instance.
        endLvlCanvas.enabled = false;
        PopupHighScoreCanvas.enabled = false;
        GameManager.instance.PopupHighScoreCanvas.GetComponent<Canvas>().enabled = false;

        //PlayerPrefs.DeleteKey("Level1Score");
        //PlayerPrefs.DeleteKey("Level2Score");
        //PlayerPrefs.DeleteKey("Level3Score");.
        //Debug.Log("Level 1 Previous Score " + PlayerPrefs.GetFloat("Level1Score", 0));
        //Debug.Log("Level 2 Previous Score " + PlayerPrefs.GetFloat("Level2Score", 0));
        //Debug.Log("Level 3 Previous Score " + PlayerPrefs.GetFloat("Level3Score", 0));

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

        else if (newGameState == GameState.endLevel)
        {
            inGameCanvas.enabled = false;
            //gameOverCanvas.enabled = false;
            endLvlCanvas.enabled = true;
            PopupHighScoreCanvas.enabled = false;
        }

        else if (newGameState == GameState.popUp)
        {
            inGameCanvas.enabled = false;
            //gameOverCanvas.enabled = false;
            endLvlCanvas.enabled = false;
            PopupHighScoreCanvas.enabled = true;
        }

        currentGameState = newGameState;
    }

    public void SetEndLvl()
    {
        SetGameState(GameState.endLevel);
    }

    public void SetFinalCanvas()
    {
        ViewEndLvl.instance.EndLvl();
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
