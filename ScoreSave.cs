using UnityEngine;
using System.Collections;

public class ScoreSave : MonoBehaviour {



//	void Start () {
//		
//		scores = PlayerPrefs.GetInt("Score");
//	}

	void OnGUI()
	{

//		if(PlayerPrefs.HasKey("Score"))
//		{
//
//				GUI.Label(new Rect(Screen.width/2 -40, 90, 150, 50),PlayerPrefs.GetInt(scores));
//				
//			}
//
//			else
//			{
//			GUI.Label(new Rect(Screen.width/2 -40, 190, 80, 30), "Back");
//
//				 }
	
		GUI.color = Color.black;

		
		if(GUI.Button(new Rect(Screen.width/2 -40, 190, 80, 30), "Back"))
		{
			Application.LoadLevel(0);
		}
		
		
	}





}
