using System;

namespace Lab3T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть кількість елементів n = ");

            int n = int.Parse(Console.ReadLine());

            int[] z = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Введіть значення елементів = ");

                int b = int.Parse(Console.ReadLine());

                z[i] = b;
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0},", z[i]);
            }

            int a = 0;

            for (int i = 0; i < n; i++)
            {
                if (a < z[i])
                {
                    a = z[i];
                }

            }
            Console.WriteLine();
            Console.Write("Максимальний елемент = ");
            Console.Write(a);



        }
    }
}
