using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class BFirstTrigger : MonoBehaviour
{
	public GameObject ThePlayer;
	public GameObject TextBox;
	public GameObject TheMarker;
	public GameObject Trigger;
	
	
	void OnTriggerEnter()
	{
		ThePlayer.GetComponent<FirstPersonController>().enabled = false;
		StartCoroutine (ScenePlayer());
		
	}
	
	IEnumerator ScenePlayer ()
	{
		TextBox.GetComponent<Text>().text = "I think someone left a walkie-talkie on the table.";
		yield return new WaitForSeconds (2.5f);
		TextBox.GetComponent<Text>().text = "";
		TextBox.GetComponent<Text>().text = "Maybe i can contact with someone.";
		yield return new WaitForSeconds (2.5f);
		TextBox.GetComponent<Text>().text = "";
		ThePlayer.GetComponent<FirstPersonController>().enabled = true;
		TheMarker.SetActive(true);
		Trigger.SetActive (false);
		
		
	}
}
