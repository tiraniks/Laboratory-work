using System;

namespace Lab1T3
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.Write("Введіть значення х1 = ");
			double x1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введіть значення у1 = ");
			double y1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введіть значення х2 = ");
			double x2 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введіть значення у2 = ");
			double y2 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введіть значення х3 = ");
			double x3 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введіть значення у3 = ");
			double y3 = Convert.ToInt32(Console.ReadLine());

			double AB = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
			double AC = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
			double BC = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));

			if ((Math.Pow(AB, 2) < Math.Pow(AC, 2) + Math.Pow(BC, 2)) || (Math.Pow(AC, 2) < Math.Pow(AB, 2) + Math.Pow(BC, 2)) || (Math.Pow(BC, 2) < Math.Pow(AB, 2) + Math.Pow(AC, 2)))
			{
				Console.WriteLine("Трикутник буде гострокутнім");
			}
			else
			{
				Console.WriteLine("Трикутник не буде гострокутнім");
			}

			Console.ReadLine();


		}
    }
}
