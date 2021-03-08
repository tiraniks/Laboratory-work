using System;

namespace Lab3T3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Розмірність простору: ");
            int n = int.Parse(Console.ReadLine());
            int p = n;

            int[] x = new int[n];
            int[] y = new int[n];

            int s = 0;
            for (int i = 0; n > 0; i++)
            {
                n--;
                Console.Write("Координата х{0}: " , i + 1);

                int a = int.Parse(Console.ReadLine());

                x[i] = a;

                Console.Write(" Координата y{0}: ", i+1);

                int b = int.Parse(Console.ReadLine());

                y[i] = b;
            }

            for (int j = 0; p > 0; j++)
            {
                p--;
                int k = x[j] * y[j];
                s += k;
            }

            Console.WriteLine(s);
        }
    }
}
