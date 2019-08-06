using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class Audio : MonoBehaviour 
{
	public AudioClip sound;
	AudioSource source;

	void Start()
	{
		source = GetComponent<AudioSource> ();
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") 
		{
			AudioSource.PlayClipAtPoint (sound, transform.position);
			Destroy (this.gameObject);
		}
	}
}
