using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class TIntNumber : TNumber
    {
        public int a;
        int[] m;
        double[] n;

        public TIntNumber() { }

        public TIntNumber(int a)
        {
            this.a = a;
        }

        public TIntNumber(TIntNumber previousTIntNumber)
        {
            a = previousTIntNumber.a;
        }

        Random rand = new Random();
        public override int Random_Sum_Array()
        {
            for (int i = 0; i < a; i++)
            {
                m[i] = rand.Next(-100, 100);
                n[i] = rand.Next(-100, 100);
            }

            int sum = 0;

            for (int i = 0; i < a; i++)
            {
                sum += m[i];
            }

            return sum;

        }

        public override double SumQ()
        {
            double sumQ = 0;
            for (int i = 0; i < a; i++)
            {
                sumQ += n[i];
            }
            return sumQ;
        }

        public override string First_last()
        {
            return $"Перша цифра{m[0]}Остання цифра{m[a - 1]}";
        }
        public override string First_lastQ()
        {
            return $"Перша цифра{n[0]}Остання цифра{n[a - 1]}";
        }
    }
}
