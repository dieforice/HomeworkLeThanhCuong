//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//using UnityEngine.SceneManagement;
//
//
//public class Timer : MonoBehaviour {
//	public int Time;
//	public string TimeString;
//	public Text TimeText;
//	void Start () {
//		StartCoroutine ("PlayTimer");
//	}
//	public IEnumerator PlayTimer()
//	{
//		while (true) {
//			string TimeString = Time.ToString ();
//			yield return new WaitForSeconds (1);
//			Time -= 1;
//			TimeText.text = TimeString;
//			print ("hello");
//
//		}
//
//	}
//
//}
