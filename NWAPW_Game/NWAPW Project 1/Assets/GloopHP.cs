﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GloopHP : MonoBehaviour {
	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void GloopDmgDwn ()
	{
		anim.SetTrigger ("damage");
	}
}