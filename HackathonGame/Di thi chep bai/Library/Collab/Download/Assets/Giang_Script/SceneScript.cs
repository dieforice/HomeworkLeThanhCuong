using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour {
	public int Time;
	public int Time2;
	public int TimeClick;
	public string TimeString;
	public Text TimeText;
//	public Text BigText;
//	public InputField BigInputfield;
//	public Button BigButton;
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
		StartCoroutine ("PlayTimer");
		addComponent ();
		displayContent ();
		playAgain.gameObject.SetActive (false);
	}
	List<Question> questionsList = new List<Question> ();
	List<Question> questionsList2 = new List<Question> ();
	public List<Image> imageList1;
	public Text cheatText1;
	public Text cheatText2;
	public Text cheatText3;
	public Text cheatText4;
	public Text cheatText5;
	public Text cheatText6;
	public Text textContent1;
	public Text textContent2;
	public Text textContent3;
	public Text textContent4;
	public Text textContent5;
	public Text textContent6;
	public Text textContent7;
	public Text textContent8;
	public Text textContent9;
	public Text textContent10;
	public Text textContent11;
	public Text textContent12;
	public Text textContent13;
	public Text textContent14;
	public Text textContent15;
	public Text textContent16;
	public InputField inputAnswer1;
	public InputField inputAnswer2;
	public InputField inputAnswer3;
	public InputField inputAnswer4;
	public InputField inputAnswer5;
	public InputField inputAnswer6;
	public InputField inputAnswer7;
	public InputField inputAnswer8;
	public InputField inputAnswer9;
	public InputField inputAnswer10;
	public InputField inputAnswer11;
	public InputField inputAnswer12;
	public InputField inputAnswer13;
	public InputField inputAnswer14;
	public InputField inputAnswer15;
	public InputField inputAnswer16;
	public Button playAgain;
	public Button cheatButton;
	public Button createImage;
	public Button turnOffImage;
	public Button turnOnImage;
	int number;int number2;int number3;int number4;int number5;
	int number6;int number7;int number8;int number9;int number10;
	int number11; int number12;int number13; int number14; int number15;
	int rollNumber;
	int numberImage; int numberImage2;
	public int levelPoint;
	string rightAnswer1;string rightAnswer2;string rightAnswer3;string rightAnswer4;string rightAnswer5;
	string rightAnswer6;string rightAnswer7;string rightAnswer8;string rightAnswer9; string rightAnswer10;  string rightAnswer11;
	string rightAnswer12; string rightAnswer13; string rightAnswer14; string rightAnswer15; string rightAnswer16;
	string answer1;string answer2;string answer3;string answer4;string answer5;
	string answer6;string answer7;string answer8;string answer9;string answer10;string answer11;
	string answer12;string answer13;string answer14;string answer15;string answer16;
	public void addComponent ()
	{
		Question q1 = new Question ("Banh cuon lam tu Gao hay Bot mi?", "Gao");
		Question q2 = new Question ("Khuc hat song que la ca khuc cua ai?", "Anh Tho");
		Question q3 = new Question ("London la thu do cua nuoc nao?", "Anh");
		Question q4 = new Question ("Quoc ca Viet Nam do ai sang tac?", "Van Cao");
		Question q5 = new Question ("Bac Kinh la thu do cua nuoc nao?", "Trung Quoc");
		Question q6 = new Question ("Lien Minh Soviet tan ra nam bao nhieu?", "1991");
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
		Question q23 = new Question ("PV = nxT,x la gi?", "r");
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
		Question q40 = new Question ("Xe tang nao duoc san xuat nhieu nhat trong chien tranh the gioi 2?", "T-34");
		Question q41 = new Question ("sinh(x)cosh(y) + cosh(x)sinh(y) = ?", "sinh(x+y)");
		Question q42 = new Question ("2sinh(x)cosh(x) = ?", "sinh(2x)");
		Question q43 = new Question ("Nam bao nhieu la nam bat dau nganh dien anh?", "1895");
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
		Question q56 = new Question ("Ten cua nhung cuoc chien tranh nong dan o Phap the ki 14?", "Jacquerie");
		Question q57 = new Question ("Lien Xo thon tinh ba nuoc Baltic vao nam bao nhieu?", "1940");
		Question q58 = new Question ("Ham so nguoc cua y = (x-3)/2 la?", "y = 2x+3");
		Question q59 = new Question ("Vi tuong nao la tac gia 95 luat dao Thien Chua Giao?", "Martin Luther");
		Question q60 = new Question ("Vi tuong nao nha Tran duoc menh danh la biet nhieu thu tieng nhat Dai Viet?", "Tran Nhat Duat");
		Question q61 = new Question ("Dong co hoi nuoc duoc phat minh ra nam bao nhieu?", "1781");
		Question q62 = new Question ("Transistor duoc chinh thuc phat minh ra nam bao nhieu?", "1947");
		Question q63 = new Question ("Ai la nguoi dau tien trong lich su nuoc Anh da chem dau 1 vi vua?", "Oliver Cromwell");
		Question q64 = new Question ("Chau My duoc dat ten theo ai?", "Amerigo");
		Question q65 = new Question ("Nhac quoc ca Lien Xo do ai sang tac?", "Alexander Alexandrov");
		Question q66 = new Question ("Ai la vua cua nuoc Anh nam 888?", "Alfred");
		Question q67 = new Question ("Sofia la thu do cua nuoc nao?", "Bulgaria");
		Question q68 = new Question ("Thu do cua Australia la?", "Canberra");
		Question q69 = new Question ("Nha khoa hoc nao bi thieu song nam 1600 vi noi len su that ve he mat troi?", "Geordano Bruno");
		Question q70 = new Question ("Truong dai hoc cua Ngo Bao Chau ten la gi?(khong dau,ten day du)", "Ecole Normale Superieure");
		Question q71 = new Question ("Hoa si nao la nguoi ve ra Batman dau tien?", "Bob Kane");
		Question q72 = new Question ("Tran Yadrang dien ra nam bao nhieu?", "1965");
		Question q73 = new Question ("Trong phan ung hat nhan toa nang luong thi khoi luong hat ban dau nho hon hay lon hon khoi luong sau phan ung?", "Lon hon");
		Question q74 = new Question ("Tru so Riot Games nam o thanh pho nao?", "Los Angeles");
		Question q75 = new Question ("Nguoi Viet Nam nao da nghi ra thuoc sung dau tien?", "Ho Han Thuong");

		Question iq1 = new Question ("Day la may bay gi trong the chien hai?", "F6F");
		Question iq2 = new Question ("Day la nhan vat nao?", "Guy Fawkes");
		Question iq3 = new Question ("Day la loai may bay gi cua Lien Xo trong the chien thu 2", "IL2");
		Question iq4 = new Question ("Nguoi bi thieu song la ai?", "Jean Huss");
		Question iq5 = new Question ("Cuoc hoi nghi dien ra o dau?", "Munich");



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

		questionsList2.Add (iq1);questionsList2.Add (iq2);questionsList2.Add (iq3);questionsList2.Add (iq4);questionsList2.Add (iq5);


		questionsList.Add (q51);questionsList.Add (q52);questionsList.Add (q53);questionsList.Add (q54);questionsList.Add (q55);
		questionsList.Add (q56);questionsList.Add (q57);questionsList.Add (q58);questionsList.Add (q59);questionsList.Add (q60);
		questionsList.Add (q61);questionsList.Add (q62);questionsList.Add (q63);questionsList.Add (q64);questionsList.Add (q65);
		questionsList.Add (q66);questionsList.Add (q67);questionsList.Add (q68);questionsList.Add (q69);questionsList.Add (q70);
		questionsList.Add (q71);questionsList.Add (q72);questionsList.Add (q73);questionsList.Add (q74);questionsList.Add (q75);
		}
		// day la phan nhap du lieu, tao cac cau hoi.
		public void displayContent ()
	{
		number = Random.Range (0, 5);number2 = Random.Range (5, 10);number3 = Random.Range (10, 15);number4 = Random.Range (15, 20);number5 = Random.Range (20, 25);
		number6 = Random.Range (25, 30);number7 = Random.Range (30, 35);number8 = Random.Range (35, 40);number9 = Random.Range (40, 45);number10 = Random.Range (45, 50);
		number11 = Random.Range (50, 55);number12 = Random.Range (55, 60);number13 = Random.Range (60, 65);number14 = Random.Range (65, 70);number15 = Random.Range (70, 75);
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
		textContent12.text = questionsList [number11].Content;
		textContent13.text = questionsList [number12].Content;
		textContent14.text = questionsList [number13].Content;
		textContent15.text = questionsList [number14].Content;
		textContent16.text = questionsList [number15].Content;
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
		rightAnswer12 = questionsList [number11].Answer;
		rightAnswer13 = questionsList [number12].Answer;
		rightAnswer14 = questionsList [number13].Answer;
		rightAnswer15 = questionsList [number14].Answer;
		rightAnswer16 = questionsList [number15].Answer;
	}
	public void randomImage1 ()
	{
		numberImage = Random.Range (0, 5);
		imageList1 [numberImage].gameObject.SetActive (true);
		textContent11.text = questionsList2 [numberImage].Content;
		rightAnswer11 = questionsList2[numberImage].Answer;
		createImage.gameObject.SetActive (false);
		turnOffImage.gameObject.SetActive (true);
	}
	public void turnOff()
	{
		turnOnImage.gameObject.SetActive(true);
		turnOffImage.gameObject.SetActive(false);
		imageList1[numberImage].gameObject.SetActive(false);
	}
	public void turnOn()
	{
		turnOffImage.gameObject.SetActive(true);
		turnOnImage.gameObject.SetActive (false);
		imageList1[numberImage].gameObject.SetActive(true);
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
		answer11 = inputAnswer11.text;
		answer12 = inputAnswer12.text;
		answer13 = inputAnswer13.text;
		answer14 = inputAnswer14.text;
		answer15 = inputAnswer15.text;
		answer16 = inputAnswer16.text;
	}
	public void checkAnswer()
	{
		if (rightAnswer1 == answer1) {
			levelPoint+=1;
			inputAnswer1.gameObject.SetActive (false);
		} 
		if (rightAnswer2 == answer2) {
			levelPoint+=1;
			inputAnswer2.gameObject.SetActive (false);
		}
		if (rightAnswer3 == answer3) {
			levelPoint+=1;
			inputAnswer3.gameObject.SetActive (false);
		}
		if (rightAnswer4 == answer4) {
			levelPoint+=1;
			inputAnswer4.gameObject.SetActive (false);
		}
		if (rightAnswer5 == answer5) {
			levelPoint+=1;
			inputAnswer5.gameObject.SetActive (false);
		}
		if (rightAnswer6 == answer6) {
			levelPoint+=1;
			inputAnswer6.gameObject.SetActive (false);
		} 
		if (rightAnswer7 == answer7) {
			levelPoint+=1;
			inputAnswer7.gameObject.SetActive (false);
		} 
		if (rightAnswer8 == answer8) {
			levelPoint+=1;
			inputAnswer8.gameObject.SetActive (false);
		} 
		if (rightAnswer9 == answer9) {
			levelPoint+=1;
			inputAnswer9.gameObject.SetActive (false);
		} 
		if (rightAnswer10 == answer10) {
			levelPoint+=1;
			inputAnswer10.gameObject.SetActive (false);
		} 
		if (rightAnswer11 == answer11) {
			levelPoint+=1;
			inputAnswer11.gameObject.SetActive (false);
		} 
		if (rightAnswer12 == answer12) {
			levelPoint+=1;
			inputAnswer12.gameObject.SetActive (false);
		} 
		if (rightAnswer13 == answer13) {
			levelPoint+=1;
			inputAnswer13.gameObject.SetActive (false);
		} 
		if (rightAnswer10 == answer10) {
			levelPoint+=1;
			inputAnswer10.gameObject.SetActive (false);
		} 
		if (rightAnswer14 == answer14) {
			levelPoint+=1;
			inputAnswer14.gameObject.SetActive (false);
		} 
		if (rightAnswer15 == answer15) {
			levelPoint+=1;
			inputAnswer15.gameObject.SetActive (false);
		} 
		if (rightAnswer16 == answer16) {
			levelPoint+=1;
			inputAnswer16.gameObject.SetActive (false);
		} 
	}
	// doan nay de kiem tra xem dap an dung hay sai, neu dung se duoc cong diem.
	public void checkResults(){
		Time = 0;
		print (levelPoint);
		checkAnswer ();
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
		imageList1 [numberImage].gameObject.SetActive (false);
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
//	public void ChepBai(){
//		TimeClick++;
//		if (TimeClick==1) {
//			BigText.gameObject.SetActive (false);
//			BigInputfield.gameObject.SetActive (false);
//			BigButton.gameObject.SetActive (false);
//		}
//		if (TimeClick == 2) {
//			BigText.gameObject.SetActive (true);
//			BigInputfield.gameObject.SetActive (true);
//			BigButton.gameObject.SetActive (true);
//		}
//
//	}
	// doan nay la cac ham dung cho cheat button
	public void getAnswer3()
	{
		rollNumber = Random.Range (0, 10);
		if (rollNumber >2)
		{
			cheatText1.text = rightAnswer3;
		}
		else 
		{
			checkResults ();
		}
	}
	public void getAnswer5()
	{
		rollNumber = Random.Range (0, 10);
		if (rollNumber >2)
		{
			cheatText2.text = rightAnswer5;
		}
		else 
		{
			checkResults ();
		}
	}
	public void getAnswer6()
	{
		rollNumber = Random.Range (0, 10);
		if (rollNumber >3)
		{
			cheatText1.text = rightAnswer6;
		}
		else 
		{
			checkResults ();
		}
	}
	public void getAnswer7()
	{
		rollNumber = Random.Range (0, 10);
		if (rollNumber >3)
		{
			cheatText2.text = rightAnswer7;
		}
		else 
		{
			checkResults ();
		}
	}
	public void getAnswer8()
	{
		rollNumber = Random.Range (0, 10);
		if (rollNumber >3)
		{
			cheatText3.text = rightAnswer8;
		}
		else 
		{
			checkResults ();
		}
	}
	public void getAnswer9()
	{
		rollNumber = Random.Range (0, 10);
		if (rollNumber >3)
		{
			cheatText4.text = rightAnswer9;
		}
		else 
		{
			checkResults ();
		}
	}
	public void getAnswer10()
	{
		rollNumber = Random.Range (0, 10);
		if (rollNumber >3)
		{
			cheatText5.text = rightAnswer10;
		}
		else 
		{
			checkResults ();
		}
	}
	public void getAnswer11()
	{
		rollNumber = Random.Range (0, 10);
		if (rollNumber >3)
		{
			cheatText6.text = rightAnswer11;
		}
		else 
		{
			checkResults ();
		}
	}
	public void getAnswer12()
	{
		rollNumber = Random.Range (0, 10);
		if (rollNumber >2)
		{
			rollNumber = Random.Range (0, 10);
			if (rollNumber > 4) {
				cheatText1.text = rightAnswer12;
			} else {
				cheatText1.text = "Einstein";
			}
		}
		else 
		{
			checkResults ();
		}
	}
	public void getAnswer13()
	{
		rollNumber = Random.Range (0, 10);
		if (rollNumber >3)
		{
			rollNumber = Random.Range (0, 10);
			if (rollNumber > 4) {
				cheatText2.text = rightAnswer13;
			}
			else
			{cheatText2.text = "Dota 2";}
		}
		else 
		{
			checkResults ();
		}
	}
	public void getAnswer14()
	{
		rollNumber = Random.Range (0, 10);
		if (rollNumber >4)
		{
			cheatText3.text = rightAnswer14;
		}
		else 
		{
			checkResults ();
		}
	}
	public void getAnswer15()
	{
		rollNumber = Random.Range (0, 10);
		if (rollNumber >4)
		{
			cheatText4.text = rightAnswer15;
		}
		else 
		{
			checkResults ();
		}
	}
	public void getAnswer16()
	{
		rollNumber = Random.Range (0, 10);
		if (rollNumber >4)
		{
			cheatText5.text = rightAnswer16;
		}
		else 
		{
			checkResults ();
		}
	}
}
