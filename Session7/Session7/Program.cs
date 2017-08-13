using System;
using System.Collections.Generic;
namespace Session7
{
	class MainClass
	{
		

		public static void Main (string[] args)
		{
			Random randow = new Random();

			Console.Write ("How many numbers do you want?");
			int n = Convert.ToInt32(Console.ReadLine ());
			List<int> list = new List<int>();
			for (int i = 0; i < n; i++) 
			{
				int a = randow.Next (1, 100);
				list.Add (a);
				Console.WriteLine (list [i]);

				string binary = Convert.ToString (list [i], 2);
				Console.WriteLine ("Binary is " + binary);

			}

			int min = list [0];
			for (int i = 0; i < n; i++) 
			{
				if (list [i] <= min) 
				{
					min = list [i];
				}
			}
			int factor = 0;
			for (int x = min; 1 <= x && x <= min; x--) 
			{
				for (int i = 0; i < n; i++) 
				{
					if (list [i] % x != 0) {
						break;
					}
					if (i == n-1) {
						factor = x;
					}
						
				}
				if (factor != 0) {
					break;
				}
					
			}
			Console.WriteLine ("");
			Console.WriteLine ("Greatest Common Factor "+ factor);

		}		
	}
}
