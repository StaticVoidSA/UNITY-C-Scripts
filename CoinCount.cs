using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CoinCount : MonoBehaviour 
{
	public Text countText;
	public Text winText;

	private int count;


	// Use this for initialization
	void Start () 
	{
		count = 0;
		winText.text = "";
		SetCountText ();
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Coin")) 
		{
			count ++;
			SetCountText ();
			other.gameObject.SetActive (false);
		}

	}

	void SetCountText ()
	{
		countText.text = "Score: " + count.ToString ();

		if (count >= 20) 
		{
			winText.text = "You Win!!";
			SceneManager.LoadScene ("LevelCompletedScene");
	    }
	}
}
