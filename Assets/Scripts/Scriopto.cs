using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;


public class Scriopto : MonoBehaviour
{
	[SerializeField]
	//private GameObject i = 0; //Нет изменений в движке
	//public
	private float u = 22.56f;
	
	void Start()
	{
		Show();
	}
	
	void FixedUpdate()
	{
		Debug.Log("Fixed Update time : " + Time.deltaTime);
		//Time beetween frames
	}
	
	void Update()
	{
		Debug.Log("Update time : " + Time.deltaTime);
	}
	
	void Show()
	{
		print(u);
	}
	//Text 
	//Срабатывает до старта
	/*void Awake()
	{
		print("Hi, Awake");
	}
    // Start is called before the first frame update
    void Start()//При старте программы
    {
			print("Hi");
    }*/

    // Update is called once per frame
	/*int i =0;
    void Update()//Срабатывает каждый frame
    {
        print(i);
		i++;
    }*/
}
