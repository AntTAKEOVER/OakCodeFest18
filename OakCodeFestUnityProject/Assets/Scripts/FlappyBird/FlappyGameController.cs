using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlappyGameController : MonoBehaviour {

	public bool sawOnce = false;
	public Text scoreText; 
	public Text highscoreText; 
	public Text beginText;

	int score, highscoreAI, highscoreHuman; 

	// Use this for initialization
	void Start () {
		score = 0; 
		highscoreAI = PlayerPrefs.GetInt ("HighScoreAI");
		highscoreHuman = PlayerPrefs.GetInt ("HighScoreHuman");

		if (!sawOnce) {
			Time.timeScale = 0;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeScale == 0 && (Input.GetKeyDown (KeyCode.Space))) {
			Time.timeScale = 1; 

		}
	}

			
}
