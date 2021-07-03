using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test2 : MonoBehaviour
{
	private Light myLight;
	
	
    // Start is called before the first frame update
    void Start()
    {
       myLight  = GetComponent <Light>  ();
    }
	
	
}
