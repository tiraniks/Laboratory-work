using System;

namespace Lab2Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть значення x = ");
            double x = double.Parse(Console.ReadLine());
            double radX = x / 180 * Math.PI;

            Console.Write("Введіть значення  n = ");
            double n = double.Parse(Console.ReadLine());

            double s = 0;

            if (0 < x && x < Math.PI)
            {
                for (int i = 0; i < n + 1; i++)
                {
                    s = Math.ILogB(Math.Abs(Math.Sin(x)));

                    double k = Math.ILogB(2) - Math.Cos(2 * x) - Math.Cos(4 * x) / 2 * n * i;

                    s = k - Math.Cos(2 * n * x) * i / n * i;
                }
                Console.WriteLine("s = {0}", s);
            }
            else 
            {
                Console.WriteLine("Рівняння не виконується ");
            }
        }
    }
}
