using UnityEngine;
using System.Collections;

public enum GameState
{
    //menu,
    inGame,
	endLevel,
    gameOver,
}

public class GameManager : MonoBehaviour
{
	//canvases
    public Canvas inGameCanvas;
    public Canvas endLvlCanvas;
    public Canvas gameOverCanvas;

	//singleton
    public static GameManager instance;
	//enum game state instance
	public GameState currentGameState;// = GameState.inGame; 

    // Use this for initialization
    void Awake ()
    {
        instance = this;
		currentGameState = GameState.inGame;
	}

    void Start()
    {
        //currentGameState = GameState.menu;
    }

    void SetGameState(GameState newGameState)
    {
		if (newGameState == GameState.inGame) {
			//setup Unity scene for inGame state
			inGameCanvas.enabled = true;
			gameOverCanvas.enabled = false;
			endLvlCanvas.enabled = false;
		} else if (newGameState == GameState.gameOver) {
			//setup Unity scene for gameOver state
			inGameCanvas.enabled = false;
			gameOverCanvas.enabled = true;
			endLvlCanvas.enabled = false;
		} else if (newGameState == GameState.endLevel) {
			inGameCanvas.enabled = false;
			gameOverCanvas.enabled = false;
			endLvlCanvas.enabled = true;
		}

		currentGameState = newGameState;
    }

	public void SetEndLvl(){
		SetGameState (GameState.endLevel);
	}

	public void SetGameOver(){
		SetGameState (GameState.gameOver);
	}
    // Update is called once per frame
    void Update ()
    {
	
	}
}
