using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FalseResult : MonoBehaviour {

	public Text resultText;

	void Start () {

	}

	public void FalseAnswer () {
		resultText.text = "FALSE";
		resultText.color = Color.red;
	}

}
