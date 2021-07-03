using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
	
	public AudioSource music;
	

	void Awake()
	{
		music.Play();
	}
}