using System;

namespace Lab1T1
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.Write("Введіть значення А = ");
			string a = Console.ReadLine();
			int A = Convert.ToInt32(a);

			Console.Write("Введіть значення H = ");
			string h = Console.ReadLine();
			int H = Convert.ToInt32(h);

			int S = A * H / 2;
			Console.WriteLine("Площа трикутника ");
			Console.Write(S);
			Console.ReadLine();

		}
	}
}
