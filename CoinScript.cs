using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class CoinScript : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
      // Initialize new objects here...
	}
	
	// Update is called once per frame
	void Update () 
	{
		  // To perform per-frame updates
	}

	// Used to destroy coin object from the game once contact has been made
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.CompareTag ("Player")) 
		{
			Destroy (gameObject);
			//col.gameObject.SendMessage ("CoinPickup");
		}
	}
}
