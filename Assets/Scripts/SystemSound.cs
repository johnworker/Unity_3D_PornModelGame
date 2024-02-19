using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SystemSound : MonoBehaviour
{
	public static SystemSound instance;

	private AudioSource aud;

	private void Awake()
	{
		instance = this;
		aud = GetComponent<AudioSource>();
	}

	public void PlaySound(AudioClip sound, Vector2 rangeVolum)
	{
		float volum = UnityEngine.Random.Range(rangeVolum.x, rangeVolum.y);

		aud.PlayOneShot(sound, volum);
	}

}
