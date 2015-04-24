//Abraham Hijazeen - G00295881

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Over : MonoBehaviour {

	int scores;
	int hs;
	Text textOver;
	int fscore;
	public Text goScore;
	
	// Use this for initialization
	void Awake() {
	
		scores = PlayerPrefs.GetInt("Score");
		hs = PlayerPrefs.GetInt ("Highscore");

	}

	void Update()
	{
		//Stores Highscores
		if (scores > hs) {
			PlayerPrefs.SetInt("Highscore", scores);
		}
	}

	void OnGUI()
	{

		//GUI.Label (new Rect(Screen.width/2 -40, 50, 80, 30), "GAME OVER");
		GUI.color = Color.black;
		//GUI.Label(new Rect(Screen.width/2 -40, 100, 90, 30), "Score: " + scores);

		//hs = PlayerPrefs.GetInt("Highscore");
		//GUI.Label(new Rect(Screen.width/2 -40, 100, 90, 30), "Highscore: " + hs);

		goScore.text = ( "Score: " + (scores));

		GUI.color = Color.green;
		if(GUI.Button(new Rect(Screen.width/2 -40, 170, 80, 30), "Retry"))
		{
			Application.LoadLevel(1);
		}

		if(GUI.Button(new Rect(Screen.width/2 -40, 210, 80, 30), "Menu"))
		{
			Application.LoadLevel(0);
		}

	}
}

