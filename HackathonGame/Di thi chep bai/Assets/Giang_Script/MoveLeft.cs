using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MoveLeft : MonoBehaviour {
	public float movespeed= 4;
	public int distance = 8;
	public int x;


	// Use this for initialization
	void Start () {


	}

	IEnumerator MovetoLeft(){
		float distanceMoved = 0f;
		while (distanceMoved < distance) {
			transform.position = new Vector3 (
				transform.position.x - movespeed * Time.deltaTime,
				transform.position.y,
				transform.position.z);
			distanceMoved += movespeed * Time.deltaTime;
			yield return null;
		}

	}
	public void ChangeC(){
		StartCoroutine (MovetoLeft ());
	}	
	void Update(){
		

	}
}
