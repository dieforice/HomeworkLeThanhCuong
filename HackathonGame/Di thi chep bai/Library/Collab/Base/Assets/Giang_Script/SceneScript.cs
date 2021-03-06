using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour {
	public int Time;
	public int Time2;
	public string TimeString;
	public Text TimeText;
	public IEnumerator PlayTimer()
	{
		while (true) {
			string TimeString = Time.ToString ();
			TimeText.text = TimeString;
			yield return new WaitForSeconds (1);
			Time -= 1;

			if (Time == -1) {
				checkResults ();		
				break;
			}
		}
	}

	void Start () {
		addComponent ();
		displayContent ();
		playAgain.gameObject.SetActive (false);
		StartCoroutine ("PlayTimer");
		addComponent ();
		displayContent ();
		playAgain.gameObject.SetActive (false);
	}
	List<Question> questionsList = new List<Question> ();
//	List<Question> questionsList2 = new List<Question> ();
	public Text textContent1;
	public Text textContent2;
	public Text textContent3;
	public Text textContent4;
	public Text textContent5;
	public Text textContent6;public Text textContent7;public Text textContent8;public Text textContent9;public Text textContent10;
	public InputField inputAnswer1;
	public InputField inputAnswer2;
	public InputField inputAnswer3;
	public InputField inputAnswer4;
	public InputField inputAnswer5;
	public InputField inputAnswer6;public InputField inputAnswer7;public InputField inputAnswer8;public InputField inputAnswer9;public InputField inputAnswer10;
	public Button playAgain;
	public Button openQuestion1;
	int number;int number2;int number3;int number4;int number5;int number6;int number7;int number8;int number9;int number10;
	public int levelPoint;
	string rightAnswer1;string rightAnswer2;string rightAnswer3; string rightAnswer4; string rightAnswer5;string rightAnswer6;string rightAnswer7;string rightAnswer8;string rightAnswer9;string rightAnswer10;
	string answer1;string answer2;string answer3;string answer4;string answer5;string answer6;string answer7;string answer8;string answer9;string answer10;
	public void addComponent ()
	{
		Question q1 = new Question ("Banh cuon lam tu Gao hay Bot mi?", "Gao");
		Question q2 = new Question ("Khuc hat song que la ca khuc cua ai?", "Anh Tho");
		Question q3 = new Question ("London la thu do cua nuoc nao?", "Anh");
		Question q4 = new Question ("Quoc ca Viet Nam do ai sang tac?", "Van Cao");
		Question q5 = new Question ("Sofia la thu do cua nuoc nao?", "Bulgaria");
		Question q6 = new Question ("Ai la vua cua nuoc Anh nam 888?", "Alfred");
		Question q7 = new Question ("Ai la tong thong My bay gio?", "Donald Trump");
		Question q8 = new Question ("Ha Noi la thu do cua Viet Nam lan dau nam bao nhieu?", "1010");
		Question q9 = new Question ("Truong Sa la cua Trung Quoc hay Viet Nam?", "Viet Nam");
		Question q10 = new Question ("Pho bo cua mien Nam hay mien Bac", "Bac");
		Question q11 = new Question ("Ai la lanh tu vi dai cua Viet Nam?", "Ho Chi Minh");
		Question q12 = new Question ("Ten cua chang trai Nghe An ra di tim duong cu nuoc?", "Nguyen Tat Thanh");
		Question q13 = new Question ("Ten khai sinh cua Chu tich Ho Chi Minh la gi?", "Nguyen Sinh Cung");
		Question q14 = new Question ("Ten cua Bac Ho khi o Phap la gi?", "Nguyen Ai Quoc");
		Question q15 = new Question ("Bac Ho mat nam bao nhieu?", "1969");
		Question q16 = new Question ("Viet Nam nam o vi tri nao o chau A", "Dong Nam A");
		Question q17 = new Question ("Ten that cua vua Quang Trung la gi?", "Nguyen Hue");
		Question q18 = new Question ("Cong thuc tinh quang duong lop 5 la gi?(viet thuong)", "s=vt");
		Question q19 = new Question ("H2O + Na => ?", "NaOH + (1/2)H2");
		Question q20 = new Question ("Cong thuc dinh luat II Newton lop 6", "F=ma");
		Question q21 = new Question ("Toa nha nao cao nhat Viet Nam?", "Keangnam");
		Question q22 = new Question ("Thanh pho nao dong dan nhat Viet Nam?", "Sai Gon");
		Question q23 = new Question ("PV = n*T,* la gi?", "r");
		Question q24 = new Question ("He mat troi co may hanh tinh?", "7");
		Question q25 = new Question ("G-Dragon cua Viet Nam la ai?(3 chu)", "MTP");
		Question q26 = new Question ("Tu 1 den 150 co bao nhieu chu so 0?", "16");
		Question q27 = new Question ("Cong thuc cau tao cua Glycerin?", "C3H8O3");
		Question q28 = new Question ("Khi roi tu do vat bi lech ve phuong nao?", "Dong");
		Question q29 = new Question ("Nam cao trao cua phong trao Dong Khoi?", "1960");
		Question q30 = new Question (",Ngu tieu y thuat van dap, la tac pham cua ai?", "Nguyen Dinh Chieu");
		Question q31 = new Question ("Ai la nguoi dua ra thuyet tien hoa trung tinh?", "Kimura");
		Question q32 = new Question ("Max Planck hoc Vat Li o truong dai hoc nao?(viet tat)", "LMU");
		Question q33 = new Question ("Dan Mach hay Viet Nam co dien tich lon hon?", "Dan Mach");
		Question q34 = new Question ("f=x**1/3, f'(8) =?", "1/12");
		Question q35 = new Question ("Tap xac dinh cua arcsin(sinx) la?", "R");
		Question q36 = new Question ("Compose co nghia la binh tinh, Dung hay Sai?", "Dung");
		Question q37 = new Question ("Nuoc nao ten bat dau bang chu D o chau Phi?", "Djibouti");
		Question q38 = new Question ("Truong dai hoc Miami nam o bang nao Hoa Ky?", "Ohio");
		Question q39 = new Question ("Phat minh nao tu sau nam 1945 co anh huong lon nhat trong nganh dien tu?", "Transistor");
		Question q40 = new Question ("Chau My duoc dat ten theo ai?", "Amerigo");
		Question q41 = new Question ("sinh(x)cosh(y) + cosh(x)sinh(y) = ?", "sinh(x+y)");
		Question q42 = new Question ("2sinh(x)cosh(x) = ?", "sinh(2x)");
		Question q43 = new Question ("Ham so nguoc cua y = (x-3)/2 la?", "y = 2x+3");
		Question q44 = new Question ("Vo cung be tuong duong cua sinx la gi?", "x");
		Question q45 = new Question ("Co may loai diem gian doan co ban cu ham so cap?", "2");
		Question q46 = new Question ("Ngon ngu Python la do ai tao ra (day du ten)?", "Guido van Rossum");
		Question q47 = new Question ("Java da co mat bao nhieu nam, tinh den 2017?", "22");
		Question q48 = new Question ("Charles Darwin hoc y nam 1825 o truong dai hoc nao?", "Edinburgh University");
		Question q49 = new Question ("Thang 10 nam 1973 xuat hien cuoc khung hoang nao?", "Dau mo");
		Question q50 = new Question ("Quoc gia nao co 2 thu do?", "Yemen");
		Question q51 = new Question ("Luong mua trung binh hang nam o Dong Nam Bo la bao nhieu?", "1500-2000mm");
		Question q52 = new Question ("HBr tham gia phan ung cong voi propen theo quy tac?", "Markovnikov");
		Question q53 = new Question ("Quoc gia nao da dang ve dia hinh, khi hau nhat?", "Trung Quoc");
		Question q54 = new Question ("Ban co muon ngu voi toi khong?(trong tieng Phap la gi)", "Voulez-vous coucher avec moi?");
		Question q55 = new Question ("Ai la tong thong Han Quoc da bi muu sat 3 lan?", "Park Chung-hee");
		questionsList.Add (q1);questionsList.Add (q2);questionsList.Add (q3);questionsList.Add (q4);questionsList.Add (q5);
		questionsList.Add (q6);questionsList.Add (q7);questionsList.Add (q8);questionsList.Add (q9);questionsList.Add (q10);
		questionsList.Add (q11);questionsList.Add (q12);questionsList.Add (q13);questionsList.Add (q14);questionsList.Add (q15);
		questionsList.Add (q16);questionsList.Add (q17);questionsList.Add (q18);questionsList.Add (q19);questionsList.Add (q20);
		questionsList.Add (q21);questionsList.Add (q22);questionsList.Add (q23);questionsList.Add (q24);questionsList.Add (q25);
		questionsList.Add (q26);questionsList.Add (q27);questionsList.Add (q28);questionsList.Add (q29);questionsList.Add (q30);
		questionsList.Add (q31);questionsList.Add (q32);questionsList.Add (q33);questionsList.Add (q34);questionsList.Add (q35);
		questionsList.Add (q36);questionsList.Add (q37);questionsList.Add (q38);questionsList.Add (q39);questionsList.Add (q40);
		questionsList.Add (q41);questionsList.Add (q42);questionsList.Add (q43);questionsList.Add (q44);questionsList.Add (q45);
		questionsList.Add (q46);questionsList.Add (q47);questionsList.Add (q48);questionsList.Add (q49);questionsList.Add (q50);
		questionsList.Add (q51);questionsList.Add (q52);questionsList.Add (q53);questionsList.Add (q54);questionsList.Add (q55);
		}
		// day la phan nhap du lieu, tao cac cau hoi.
		public void displayContent ()
	{
		number = Random.Range (0, 5);number2 = Random.Range (5, 10);number3 = Random.Range (10, 15);number4 = Random.Range (15, 20);number5 = Random.Range (20, 25);
		number6 = Random.Range (25, 30);number7 = Random.Range (30, 35);number8 = Random.Range (35, 40);number9 = Random.Range (40, 45);number10 = Random.Range (45, 50);
		textContent1.text = questionsList [number].Content;
		textContent2.text = questionsList [number2].Content;
		textContent3.text = questionsList [number3].Content;
		textContent4.text = questionsList [number4].Content;		
		textContent5.text = questionsList [number5].Content;
		textContent6.text = questionsList [number6].Content;
		textContent7.text = questionsList [number7].Content;
		textContent8.text = questionsList [number8].Content;
		textContent9.text = questionsList [number9].Content;
		textContent10.text = questionsList [number10].Content;
		rightAnswer1 = questionsList [number].Answer;
		rightAnswer2 = questionsList [number2].Answer;
		rightAnswer3 = questionsList [number3].Answer;
		rightAnswer4 = questionsList [number4].Answer;
		rightAnswer5 = questionsList [number5].Answer;
		rightAnswer6 = questionsList [number6].Answer;
		rightAnswer7 = questionsList [number7].Answer;
		rightAnswer8 = questionsList [number8].Answer;
		rightAnswer9 = questionsList [number9].Answer;
		rightAnswer10 = questionsList [number10].Answer;
	}
    // phan nay dung de connect cai Content va Answer trong list vao voi file Text va Dap an oi UI
	public void GetInput()
	{
		answer1 = inputAnswer1.text;
		answer2 = inputAnswer2.text;
		answer3 = inputAnswer3.text;
		answer4 = inputAnswer4.text;
		answer5 = inputAnswer5.text;
		answer6 = inputAnswer6.text;
		answer7 = inputAnswer7.text;
		answer8 = inputAnswer8.text;
		answer9 = inputAnswer9.text;
		answer10 = inputAnswer10.text;
		checkAnswer ();
	}
	public void checkAnswer()
	{
		if (rightAnswer1 == answer1) {
			levelPoint+=1;
			inputAnswer1.gameObject.SetActive (false);
			rightAnswer1 = "e";
			inputAnswer1.text = "";
		} 
		if (rightAnswer2 == answer2) {
			levelPoint+=1;
			inputAnswer2.gameObject.SetActive (false);
			rightAnswer2 = "e";
			inputAnswer2.text = "";
		}
		if (rightAnswer3 == answer3) {
			levelPoint+=1;
			inputAnswer3.gameObject.SetActive (false);
			rightAnswer3 = "e";
			inputAnswer3.text = "";
		}
		if (rightAnswer4 == answer4) {
			levelPoint+=1;
			inputAnswer4.gameObject.SetActive (false);
			rightAnswer4 = "e";
			inputAnswer4.text = "";
		}
		if (rightAnswer5 == answer5) {
			levelPoint+=1;
			inputAnswer5.gameObject.SetActive (false);
			rightAnswer5 = "e";
			inputAnswer5.text = "";
		}
		if (rightAnswer6 == answer6) {
			levelPoint+=1;
			inputAnswer6.gameObject.SetActive (false);
			rightAnswer6 = "e";
			inputAnswer6.text = "";
		} 
		if (rightAnswer7 == answer7) {
			levelPoint+=1;
			inputAnswer7.gameObject.SetActive (false);
			rightAnswer7 = "e";
			inputAnswer7.text = "";
		} 
		if (rightAnswer8 == answer8) {
			levelPoint+=1;
			inputAnswer8.gameObject.SetActive (false);
			rightAnswer8 = "e";
			inputAnswer8.text = "";
		} 
		if (rightAnswer9 == answer9) {
			levelPoint+=1;
			inputAnswer9.gameObject.SetActive (false);
			rightAnswer9 = "e";
			inputAnswer9.text = "";
		} 
		if (rightAnswer10 == answer10) {
			levelPoint+=1;
			inputAnswer10.gameObject.SetActive (false);
			rightAnswer10 = "e";
			inputAnswer10.text = "";
		} 
	}
	// doan nay de kiem tra xem dap an dung hay sai, neu dung se duoc cong diem. rightanswer = "e" la de set lai cai gia tri string cho tinh diem.
	public void checkResults(){
		Time = 0;
		print (levelPoint);
		if (levelPoint >= 3) {
			print ("Passed");
		} else {
			playAgain.gameObject.SetActive (true);
		}	
	}



	// cai nay dung cho Button cuoi cung nhu kiem submit bai
	public void playAgainButton()
	{
		levelPoint = 0;
		displayContent ();
		playAgain.gameObject.SetActive (false);
		inputAnswer1.gameObject.SetActive (true);
		inputAnswer2.gameObject.SetActive (true);
		inputAnswer3.gameObject.SetActive (true);
		inputAnswer4.gameObject.SetActive (true);
		inputAnswer5.gameObject.SetActive (true);
		inputAnswer6.gameObject.SetActive (true);
		inputAnswer7.gameObject.SetActive (true);
		inputAnswer8.gameObject.SetActive (true);
		inputAnswer9.gameObject.SetActive (true);
		inputAnswer10.gameObject.SetActive (true);
		// Doan nay set lai time
		Time = Time2;
		StartCoroutine ("PlayTimer");
	}

}
