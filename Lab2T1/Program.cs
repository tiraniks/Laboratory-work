using System;

namespace Lab2T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть значення а = ");

            double a = double.Parse(Console.ReadLine());

            Console.Write("Введіть значення n = ");

            double n = double.Parse(Console.ReadLine());
            if (n > 0)
            {
                double k = Math.Pow(a + 1, 2);
                n--;
                while (n > 0 )
                {
                    k = Math.Pow(a + 1, 2)*Math.Pow(a+2,2)*Math.Pow(a+1,2)*Math.Pow(a,2)*Math.Pow(a,2);
                    n--;
                }
                k = k * Math.Pow(a, 2);
                Console.WriteLine(k);
            }
            else 
            {
                Console.WriteLine("Рівняння не виконуєтся");
            }

            Console.ReadLine();

        }
    }
}
