using System;

namespace lab4
{
	class input2
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("a? ");
			string a = Console.ReadLine();
			Console.WriteLine ("b? ");
			string b = Console.ReadLine();

			int sum = int.Parse(a) + int.Parse(b);

			Console.WriteLine ("sum: {0}", sum);
		}
	}
}

