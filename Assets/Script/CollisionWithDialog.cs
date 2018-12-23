using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using Collision = UnityEngine.Collision;

public class CollisionWithDialog : MonoBehaviour
{

	public bool hasTalked; 

	public Flowchart flowchart; 

	// Use this for initialization
	void Start ()
	{
		Debug.Log("test load");
		hasTalked = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}



	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Shop") && hasTalked == false)
		{
			Debug.Log("test");
			GetComponent<FirstPersonController>().enabled = false;
			
		}
		
		
	}

	public void turnOnWalk()
	{
		GetComponent<FirstPersonController>().enabled = true;
		hasTalked = true;
	}
}
