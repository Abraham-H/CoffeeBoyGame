//Abraham Hijazeen - G00295881
//The following Class is used to generate the score page gui
//It retrieved highscore from highscores storeed in Playerprefs

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScorePage : MonoBehaviour {
	int hs;
	public Text scoreTxt;

	void OnGUI()
	{
		hs = PlayerPrefs.GetInt("Highscore");

		scoreTxt.text = hs.ToString ();
		//GUI.Label(new Rect(Screen.width/2 -40, 90, 150, 30),"Highscore: " + hs);
		
		if(GUI.Button(new Rect(Screen.width/2 -40, 150, 80, 30), "Back"))
		{
			Application.LoadLevel(0);
		}
		
	}
}
