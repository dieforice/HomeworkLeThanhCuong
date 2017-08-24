using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSceneScript : MonoBehaviour {

	public ChangeSceneScript()
	{
	}
	public void ChangeScene (string scenename)
	{
		Application.LoadLevel (scenename);
	}
}
