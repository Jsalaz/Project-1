using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public static LevelManager instance;

	public float totalScore = 0;
	public float totalTime = 0;
    float fTime = 0;

	Scene currentScene;

	void Awake() {
		instance = this;
		DontDestroyOnLoad (transform.gameObject);

	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public Scene getScene(){
		currentScene = SceneManager.GetActiveScene ();
		return currentScene;
	}

	public void LoadLevel1(){
		SceneManager.LoadScene ("Level1");
        fTime = 0;
	}

	public void LoadLevel2(){
		SceneManager.LoadScene ("Level2");
	}

}