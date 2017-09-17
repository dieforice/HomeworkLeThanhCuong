//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//
//public class MultiChoices2 : MonoBehaviour {
//	public List<Image> questionContent;
//	public List<Image> multiquestions;
//	public Button TrueButton;
//	public Button FalseButton;
//	public Button A4;
//	public Button B4;//true
//	public Button C4;
//	public Button D4;
//
//	public Button A5;//true
//	public Button B5;
//	public Button C5;
//	public Button D5;
//
//	public Button A6;
//	public Button B6;
//	public Button C6;
//	public Button D6;//true
//
//	public Sprite mqi4;
//	public Sprite mqi5;
//	public Sprite mqi6;
//	int num;
//	SceneScript scenescript = new SceneScript();
//	public void TrueAnswer () {
//		//point++;
//		scenescript.levelPoint++;
//		print (scenescript.levelPoint);
//		TrueButton.gameObject.SetActive (false);
//		FalseButton.gameObject.SetActive (false);
//	}
//
//	public void FalseAnswer () {
//		//point++;
//		TrueButton.gameObject.SetActive (false);
//		FalseButton.gameObject.SetActive(false);
//
//	}
//	void Start () {
//		addComponent ();
//		QuestionsAndAnswerContent ();
//
//	}
//
//
//	//	List<Image> multiQuestion = new List<Sprite> ();
//	List<Button> multiAnswer = new List<Button>();
//	public void addComponent(){
//
//
//		//		multiQuestion.Add (mqi1);
//		//		multiQuestion.Add (mqi2);
//		//		multiQuestion.Add (mqi3);
//
//
//		multiAnswer.Add(A4);
//		multiAnswer.Add(B4);
//		multiAnswer.Add(C4);
//		multiAnswer.Add(D4);
//
//		multiAnswer.Add(A5);
//		multiAnswer.Add(B5);
//		multiAnswer.Add(C5);
//		multiAnswer.Add(D5);
//
//		multiAnswer.Add(A6);
//		multiAnswer.Add(B6);
//		multiAnswer.Add(C6);
//		multiAnswer.Add(D6);
//
//
//
//	}
//
//	public void QuestionsAndAnswerContent(){
//		int num = Random.Range (0, 3);
//		if (num == 0) {
//			multiquestions [num].gameObject.SetActive (true);
//			for (int i = 0; i < 12; i++) {
//				if (i < 4) {
//					multiAnswer [i].gameObject.SetActive (true);
//				} else {
//					multiAnswer [i].gameObject.SetActive (false);
//				}
//			}
//		}
//
//		if (num == 1) {
//			multiquestions [num].gameObject.SetActive (true);
//			for (int i = 0; i < 12; i++) {
//				if (i > 3 && i < 8) {
//					multiAnswer [i].gameObject.SetActive (true);
//				} else {
//					multiAnswer [i].gameObject.SetActive (false);
//				}
//			}
//		}
//		if (num == 2) {
//			multiquestions [num].gameObject.SetActive (true);
//			for (int i = 0; i < 12; i++) {
//				if (i > 7 && i < 12) {
//					multiAnswer [i].gameObject.SetActive (true);
//				} else {
//					multiAnswer [i].gameObject.SetActive (false);
//				}
//			}
//		}
//
//
//
//	}
//
//
//}
