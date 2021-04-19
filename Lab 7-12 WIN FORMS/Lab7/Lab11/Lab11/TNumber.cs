using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class TNumber
    {
        public int a;
        int[] m;
        double[] n;

        public TNumber() { }

        public TNumber(int a) 
        {
            this.a = a;
        }

        public TNumber(TNumber previousTNumber) 
        {
            a = previousTNumber.a;
        }

        Random rand = new Random();
        public virtual int Random_Sum_Array() 
        {
            for (int i = 0; i < a; i++)
            {
                m[i] = rand.Next(-100,100);
                n[i] = rand.Next(-100, 100);
            }

            int sum = 0;

            for (int i = 0; i < a; i++)
            {
                sum += m[i];                
            }

            return sum;
            
        }

        public virtual double SumQ() 
        {
            double sumQ = 0;
            for (int i = 0; i < a; i++)
            {
                sumQ += n[i];
            }
            return sumQ;
        }

        public virtual string First_last() 
        {
            return $"Перша цифра{m[0]}Остання цифра{m[a - 1]}";
        }
        public virtual string First_lastQ() 
        {
            return $"Перша цифра{n[0]}Остання цифра{n[a - 1]}";
        }
    }
}
