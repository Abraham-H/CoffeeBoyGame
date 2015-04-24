//Abraham Hijazeen - G00295881

using UnityEngine;
using System.Collections;

public class Specials : MonoBehaviour {

	HudScript hScript;

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Player"){

			hScript = GameObject.Find("Main Camera").GetComponent<HudScript>();
			hScript.incScore(100);
			Destroy(this.gameObject);

		}
	}
}
