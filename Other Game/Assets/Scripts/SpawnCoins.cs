using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoins : MonoBehaviour {

	public Transform[] coinSpawns;
	public GameObject coin;

	// Use this for initialization
	void Start () {
		Spawn ();
	}

	void Spawn()
	{
		for (int x = 0; x < coinSpawns.Length; x++) 
		{
			int coinFlip = Random.Range (0, 2);

			if (coinFlip > 0)
				Instantiate (coin, coinSpawns[x].position, Quaternion.identity);
		}
	}
}
