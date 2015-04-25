using UnityEngine;
using System.Collections;

public class ScoreSave : MonoBehaviour {

	void OnGUI()
	{
	
		GUI.color = Color.black;

		
		if(GUI.Button(new Rect(Screen.width/2 -40, 190, 80, 30), "Back"))
		{
			Application.LoadLevel(0);
		}
		
		
	}





}
