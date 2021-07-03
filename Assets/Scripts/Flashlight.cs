using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
	private Light myLight;
    // Start is called before the first frame update
    void Start()
    {
        myLight = GetComponent <Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.F))
		{
			myLight.enabled = !myLight.enabled;
		}
    }
}
