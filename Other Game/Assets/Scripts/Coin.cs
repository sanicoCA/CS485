using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

//turn of circle collider

public class Coin : MonoBehaviour {

	//NEW
	public static int myScore = 0;

	float hitTime = 0.1f;
	float hitTimer = 0;
	bool canHit = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		hitTimer += Time.deltaTime;

		if (hitTimer > hitTime) 
		{
			canHit = true;
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(!canHit)
		{
			return;
		}

		if (other.gameObject.CompareTag ("Player")) 
		{
			//NEW
			myScore += 1;
			Destroy (gameObject);
		}

		hitTimer = 0;
	}
}
