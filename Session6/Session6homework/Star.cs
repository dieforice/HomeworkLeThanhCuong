using System;

namespace Session6homework
{
	public class Star
	{
		public Star ()
		{
			for (int x = 0; x < 40; x++) 
			{
				Console.Write ("*");
			}
			Console.WriteLine ();
			for (int y = 0; y < 50; y++) 
			{
				Console.Write ("X*");
			}		
			for (int z = 0; z <10; z++)
			{
				for (int t = 0; t < 10; t++)
				{
					Console.Write("X*");	
				}
			Console.WriteLine();
			}
		}
	}
}

