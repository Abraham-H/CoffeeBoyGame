//Abraham Hijazeen - G00295881

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class HudScript : MonoBehaviour {//Heads Up Display
	
	
	float score = 0;
	public Text goScore;
	int hs;
	int round;

	// Update is called once per frame
	void Update () {

		//hs = PlayerPrefs.GetInt ("Highscore");


		score += Time.deltaTime;//Increase Score as time accumulates

		round = (int)Math.Round (score * 100, 0);
		goScore.text = ( "Score: " + (score * 100).ToString());


		//if (score > hs) {
		//	PlayerPrefs.SetInt("Highscore", round);
		//}

		PlayerPrefs.SetInt ("Score", round);
		
	}

//	void OnDisable(){
		//PlayerPrefs.SetInt ("Score", ((int)score *100));


	//}
	
	public void incScore(int amount){//Allows score to be increases with power ups etc
		
		score += amount;
			
	}
	
	void onGUI(){//ScoreBoard

		GUI.color = Color.black;
		GUI.Label (new Rect (-40, 90, 150, 30), "Score:" + (int)(score * 1000));
		
	}
	
}
