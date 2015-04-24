//Abraham Hijazeen - G00295881

using UnityEngine;
using System.Collections;

public class BumperScript : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D c2d)
	{
		if (c2d.tag == "Player") {
		
			Application.LoadLevel(2);
			//Debug.Break ();// For more scenes add within()
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