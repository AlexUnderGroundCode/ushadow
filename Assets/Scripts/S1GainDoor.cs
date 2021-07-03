using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class S1GainDoor : MonoBehaviour
{
	public float TheDistance;
	public GameObject ActionDisplay;
	public GameObject ActionText;
	public GameObject TheDoor;
	public AudioSource CreakSound;
	public GameObject ExtraCross;


	// Update is called once per frame
	void Update()
	{
		TheDistance = PlayerCasting.DistanceFromTarget;

	}

	void OnMouseOver()
	{
		//Accetable distance
		if (TheDistance <= 2)
		{
			ExtraCross.SetActive(true);
			ActionDisplay.SetActive(true);
			ActionText.SetActive(true);
		}
		if (Input.GetButtonDown("Action"))
		{
			if (TheDistance <= 2)
			{
				SceneManager.LoadScene("Level2");
			}
		}

	}

	void OnMouseExit()
	{
		ExtraCross.SetActive(false);
		ActionDisplay.SetActive(false);
		ActionText.SetActive(false);
	}
}