using System;

namespace Session6homework
{
	public class BMI
	{
		public BMI ()
		{
			Console.Write ("What is your weight");
			float weight = float.Parse(Console.ReadLine ());
			Console.Write ("What is your height");
			float height = float.Parse(Console.ReadLine ());
			float BMI = weight / ((height / 100) * (height / 100));
			Console.WriteLine ("Your BMI number is " + BMI);
			if (BMI < 16) 
			{
				Console.WriteLine ("You are ultra underweight");
			}
			if (16 <= BMI && BMI < 18.5) 
			{
				Console.WriteLine ("You are pretty underweight");
			}
			if (18.5 <= BMI && BMI  < 25) 
			{
				Console.WriteLine ("Good shape boy");
			}
			if (25 <= BMI && BMI < 30) {
				Console.WriteLine ("Yo man! You look like a bear");
			} 
			else 
			{
				Console.WriteLine ("You must be an elephant");
			}
		}
	}
}

