using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpWalkieTalkie : MonoBehaviour
{
	public float TheDistance;
	public GameObject ActionDisplay;
	public GameObject ActionText;
	public GameObject FakeWalkie;
	public GameObject GuideArrow;
	public GameObject RealWalkie;
	public GameObject ExtraCross;
	public GameObject TheJumpTrigger;
	
    // Update is called once per frame
    void Update()
    {
      TheDistance = PlayerCasting.DistanceFromTarget;
	  
    }
	
	void OnMouseOver()
	{
		//Accetable distance
		if(TheDistance <= 2)
		{
			ExtraCross.SetActive(true);
			ActionText.GetComponent<Text>().text = "Pick up walkie-talkie";
			ActionDisplay.SetActive (true);
			ActionText.SetActive (true);
		}
		if(Input.GetButtonDown("Action"))
		{
			if(TheDistance <= 2)
			{
				this.GetComponent<BoxCollider>().enabled = false;
				ActionDisplay.SetActive(false);
				ActionText.SetActive(false);
				FakeWalkie.SetActive(false);
				RealWalkie.SetActive(false);
				ExtraCross.SetActive(false);
				GuideArrow.SetActive(false);
				TheJumpTrigger.SetActive(false);
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
