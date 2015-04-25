//Abraham Hijazeen - G00295881
//The following Class is used to generate the about page gui

using UnityEngine;
using System.Collections;

public class About : MonoBehaviour {

	void OnGUI()
	{
		GUI.color = Color.black;
		GUI.color = Color.blue;

		GUI.color = Color.black;


		if(GUI.Button(new Rect(Screen.width/2 -40, 90, 150, 50), "By Tropical Evolution"))
		{
		}
			
		if(GUI.Button(new Rect(Screen.width/2 -40, 150, 80, 30), "Back"))
		{
			Application.LoadLevel(0);
		}
		
	}
}

