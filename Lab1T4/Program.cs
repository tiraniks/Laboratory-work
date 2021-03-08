using System;

namespace Lab1T4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть значення х = ");

            double x = double.Parse(Console.ReadLine());

            if ((Math.Pow(x, 2)) + (Math.ILogB(x + 1)) > 0)
            {
                double Y = Math.Cos(Math.Pow(x, 2) + Math.ILogB(x + 1));
                Console.WriteLine(Y);
            }
            else if ((Math.Pow(x, 2)) + (Math.ILogB(x + 1)) < 0)
            {
                double Y = 1 / (Math.Pow(x, 2) + Math.ILogB(x + 1));
                Console.WriteLine(Y);
            }
            else if ((Math.Pow(x, 2)) + (Math.ILogB(x + 1)) == 0)
            {
                double Y = Math.Cos(x);
                Console.WriteLine(Y);
            }
            else 
            {
                Console.WriteLine("Порожня множина");
            }

            Console.ReadLine();

        }
    }
}
