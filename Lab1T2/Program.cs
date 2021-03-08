using System;

namespace Lab1T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть любе дійсне число = ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine(a);
            if (a < 7 && a > 3)
            {
                Console.WriteLine("число належить інтервалу від 3 до 7");
            }
            else if (a > 8 && a < 9)
            {
                Console.WriteLine("число належить інтервалу від 8 до 9");
            }
            else if (a > 11 && a < 24.4)
            {
                Console.WriteLine("число належить інтервалу від 11 до 24.4");
            }
            else
            {
                Console.WriteLine("число не належить жодному інтервалу ");
            }

            Console.ReadLine();
        }
    }
}
