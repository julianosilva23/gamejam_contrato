﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

	public Collider2D coll;
	// Use this for initialization
	void Start () {
		
		if (coll.isTrigger) {
			
			Debug.Log ("This collider está selecionado");

		} else if (!coll.isTrigger) {

			Debug.Log ("This collider não está selecionado");

		}

		Debug.Log("start"); }
	
	float timeLeft = 7.0f;
	bool gost = false;

	void Update()
	{				
		timeLeft -= Time.deltaTime;
		if(timeLeft < 0)
		{
			if (!gost) {
				Debug.Log ("gost");
				gost = true;
				timeLeft = 7.0f;
				coll.isTrigger = true;

			} else {
				Debug.Log ("human");
				gost = false;
				coll.isTrigger = false;
				timeLeft = 7.0f;



                 
			}
		}
	}
}	
