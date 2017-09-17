using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Test : MonoBehaviour {
	public int Time;
	public string TimeString;

	void Start () {
		StartCoroutine ("PlayTimer");
	}
	public IEnumerator PlayTimer()
	{
		while (true) {
			string TimeString = Time.ToString ();

			yield return new WaitForSeconds (1);
			Time -= 1;
			print ("hello");
			if (Time == 0) {
				break;
			}

		}

	}

}
