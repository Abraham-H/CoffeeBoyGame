﻿//Abraham Hijazeen - G00295881

using UnityEngine;
using System.Collections;

public class CameraRunScript : MonoBehaviour {


	public Transform player;
	
	// Update is called once per frame
	void Update () {

		transform.position = new Vector3 (player.position.x + 6, 0, -10);
	
	}
}