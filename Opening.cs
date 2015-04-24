//Abraham Hijazeen - G00295881

using UnityEngine;
using System.Collections;

public class Opening : MonoBehaviour {

		
		// Use this for initialization
		void Start () {
			
			//scores = PlayerPrefs.GetInt("Score");
		}
		
		void OnGUI()
		{
			GUI.color = Color.black;
			
			if(GUI.Button(new Rect(Screen.width/2 -40, 150, 80, 30), "Play"))
			{
				Application.LoadLevel(1);
			}

		if(GUI.Button(new Rect(Screen.width/2 -40, 190, 80, 30), "About"))
		{
			Application.LoadLevel(3);
		}

		if(GUI.Button(new Rect(Screen.width/2 -40, 230, 80, 30), "Highscore"))
		{
			Application.LoadLevel(4);
		}

			
		}
	}
	
