using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TrueResult : MonoBehaviour {

	public Text resultText;
	public Button TrueButton;

	void Start () {

	}

	public void TrueAnswer () {
		resultText.text = "TRUE";
		resultText.color = Color.green;
		TrueButton.gameObject.SetActive (false);
	}

}
