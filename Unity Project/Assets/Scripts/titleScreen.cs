﻿using UnityEngine;
using System.Collections;

public class titleScreen : MonoBehaviour {

	public 
	// Use this for initialization
	void Start () {
		this.GetComponent<AudioSource>().Play ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown (KeyCode.Space))
			Application.LoadLevel ("RebeccaScene");
	}
}