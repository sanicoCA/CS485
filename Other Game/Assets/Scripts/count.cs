using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class count : MonoBehaviour {

	public Text countTxt;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		//NEW
		countTxt.text = "Score: " + Coin.myScore;
	}
}
