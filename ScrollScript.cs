﻿//Abraham Hijazeen - G00295881
//The following Class is used to set the scroll

using UnityEngine;
using System.Collections;

public class ScrollScript : MonoBehaviour {


	public float speed = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		renderer.material.mainTextureOffset = new Vector2 (Time.time * speed, 0f);
	
	}
}
