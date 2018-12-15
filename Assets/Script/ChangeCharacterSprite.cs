using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCharacterSprite : MonoBehaviour
{

	public Sprite frontSprite, backSprite;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		//when you move forward change to seeing back of character
		if (Input.GetKeyDown(KeyCode.W))
		{
			GetComponent<SpriteRenderer>().sprite = backSprite; 
		}else if (Input.GetKeyDown(KeyCode.S))
		{
			//move backwards see front of character
			GetComponent<SpriteRenderer>().sprite = frontSprite;
		}
	}
}
