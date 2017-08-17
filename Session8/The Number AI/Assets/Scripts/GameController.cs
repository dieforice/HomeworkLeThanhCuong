using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public Text displayText;
	public Button chooseLower;
	public Button chooseYes;
	public Button chooseHigher;
	public Button playAgain;
	int guessNumber;
	int max = 100;
	int min = 0;
	int guessCount=0;
	string guess;



	void Start () {
		GuessNumber ();
	}
	public void GuessNumber()
	{
		guessNumber = Random.Range (min, max);
		displayText.text = "Pick a number between 0 and 100, I guess the number is " + guessNumber;
		guessCount++;
		playAgain.gameObject.SetActive (false);
		chooseHigher.gameObject.SetActive (true);
		chooseLower.gameObject.SetActive (true);
	}
	public void ChooseLower()
	{
		max = guessNumber-1;
		guessNumber = Random.Range (min, max);
		displayText.text = "A lower number? Is it " + guessNumber + " ?";
		guessCount++;
		LastResult ();
	}
	public void ChooseHigher()
	{
		min = guessNumber+1;
		guessNumber = Random.Range (min, max);
		guessCount++;
		if (guessNumber + 1 > 100) 
		{
			guessNumber = 100;
		}
		displayText.text = "A higher number? Is it " + guessNumber + " ?";
		LastResult ();
	}
	public void ChooseYes()
	{
		playAgain.gameObject.SetActive (true);
		if (guessCount > 1) 
		{
			displayText.text = "I got the right one after " + guessCount + " times";
		} 
		else 
		{
			displayText.text = "Flawless! I only need " + guessCount + " to predict your number";
		}
	}
	public void LastResult()
	{
		if (min >=max) 
		{
			displayText.text = "Last Result is " + guessNumber;
			chooseHigher.gameObject.SetActive (false);
			chooseLower.gameObject.SetActive (false);
		}
	}
	public void PlayAgain()
	{
		max = 100;
		min = 0;
		guessCount = 0;
		GuessNumber ();
	}
}
