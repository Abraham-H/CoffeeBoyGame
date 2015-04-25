//Abraham Hijazeen - G00295881 
//The following script is used to spawn random game objects(Eg: Platforms)
//The min/max can be increased using unity

using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {//Used for "randomly" creating ground..enemies etc.

	public GameObject[] obj;
	public float min = 1f;
	public float max = 2f;

	// Use this for initialization
	void Start () {
	
		Spawn();

	}

	void Spawn()
	{

		Instantiate (obj[Random.Range(0,obj.GetLength(0))], transform.position, Quaternion.identity); //Chooses random object that we provide
		Invoke ("Spawn", Random.Range(min,max));//Respawn/recreate within min + max                           									 //Quaternion=Basic rotation
	}

}
