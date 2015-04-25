//Abraham Hijazeen - G00295881

//The following Class is used to create a bumper
//Anytime a game object or character hits this this object it is destroyed

using UnityEngine;
using System.Collections;

public class BumperScript : MonoBehaviour {


	//If the player(Coffee Boy) hits the bumper end scene is loaded

	void OnTriggerEnter2D(Collider2D c2d)
	{
		if (c2d.tag == "Player") {
		
			Application.LoadLevel(2);
			//Debug.Break ();// For more scenes add within() - Used for testing
			return;

		}

		if (c2d.gameObject.transform.parent) {//destyroys objects and parents
		
			Destroy (c2d.gameObject.transform.parent.gameObject);
		
		} 
		else {//if it doesnt have parent

			Destroy (c2d.gameObject);
		}


	}
}