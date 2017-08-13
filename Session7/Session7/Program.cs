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
				// convert int to binary
				string binary = Convert.ToString (list [i], 2);
				Console.WriteLine ("Binary is " + binary);

			}
			// find min of the list
			int min = list [0];
			for (int i = 0; i < n; i++) 
			{
				if (list [i] <= min) 
				{
					min = list [i];
				}
			}
			// use min to find the greatest common factor, run x from min to 1
			int factor = 0;
			for (int x = min; 1 <= x && x <= min; x--) 
			{
				for (int i = 0; i < n; i++) 
				{
					if (list [i] % x != 0) 
					{
						break;
					}
					// use this to find the greatest common factor, which % x ==0. if an element % x !=0 then the inside loop will break and run again with a new x
					if (i == n-1) 
					{
						factor = x;
					}
					// if the loop does not break then x will be the greatest common factor	
				}
				if (factor != 0) 
				{
					break;
				}
			}
			Console.WriteLine ("");
			Console.WriteLine ("Greatest Common Factor "+ factor);

		}		
	}
}
