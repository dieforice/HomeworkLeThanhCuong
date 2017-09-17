//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//
//public class MultipleChoice : MonoBehaviour {
//	public List<Image> questionContent;
//	public List<Image> multiquestions;
//	public Button TrueButton;
//	public Button FalseButton;
//	public Button A1;
//	public Button B1;//true
//	public Button C1;
//	public Button D1;
//
//	public Button A2;//true
//	public Button B2;
//	public Button C2;
//	public Button D2;
//
//	public Button A3;
//	public Button B3;
//	public Button C3;
//	public Button D3;//true
//
//	int num;
//	SceneScript scenescript =  new SceneScript();
//	public void TrueAnswer () {
//		//point++;
//		scenescript.levelPoint++;
//		print (scenescript.levelPoint);
//		TrueButton.gameObject.SetActive (false);
//		FalseButton.gameObject.SetActive (false);
//	}
//
//	public void FalseAnswer () {
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
//	List<Button> multiAnswer = new List<Button>();
//	public void addComponent(){
//		multiAnswer.Add(A1);
//		multiAnswer.Add(B1);
//		multiAnswer.Add(C1);
//		multiAnswer.Add(D1);
//
//		multiAnswer.Add(A2);
//		multiAnswer.Add(B2);
//		multiAnswer.Add(C2);
//		multiAnswer.Add(D2);
//
//		multiAnswer.Add(A3);
//		multiAnswer.Add(B3);
//		multiAnswer.Add(C3);
//		multiAnswer.Add(D3);
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
