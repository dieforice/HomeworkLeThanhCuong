using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneScript : MonoBehaviour {
	public string levelContent = "LEVEL";
	public string levelNumber;
	public string levelAnswer;
	public string sceneName;

	public Text levelText;
	public InputField inputField;
	public Button submitButton;
	public Text hintText;

	ChangeSceneScript changeScene = new ChangeSceneScript();
	string playerAnswer;

	void Start () 
	{
		levelText.text = levelContent;
		StartCoroutine (ChangeLevelTextRoutine ());
	}

	public void GetInput()
	{
		playerAnswer = inputField.text;
		CheckAnswer (playerAnswer);
	}
	public void CheckAnswer(string playerAnswer)
	{
		if (playerAnswer == levelAnswer) 
		{
			hintText.text = "Good answer";
			changeScene.ChangeScene (sceneName);

		} 
		else 
		{
			hintText.text = "Nub la";
			hintText.color = Color.red;
			StartCoroutine (ChangeHintTextRountine ());
			inputField.text = "";
			inputField.ActivateInputField ();
		}
	}
	IEnumerator ChangeHintTextRountine()
	{
		yield return new WaitForSeconds (2f);
		if (levelNumber=="1")
		{
			hintText.text = "Name of this place";
		}
		if (levelNumber == "2") {
			hintText.text = "Who is this?";
		} else 
		{
			hintText.text = "";
		}
		hintText.color = Color.black;
	}

	IEnumerator ChangeLevelTextRoutine()
	{
		while (true) 
		{
			levelText.text = levelContent;
			//wait 2 seconds
			yield return new WaitForSeconds (2f);
			levelText.text = levelNumber;
			yield return new WaitForSeconds (2f);
		}
	}
}
