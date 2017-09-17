using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ChangeSceneScript : MonoBehaviour {

	public ChangeSceneScript()
	{
	}
	public void ChangeScene (string scenename)
	{
		SceneManager.LoadScene (scenename);
	}
}
