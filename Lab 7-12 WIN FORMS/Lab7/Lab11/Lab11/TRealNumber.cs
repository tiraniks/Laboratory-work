using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class TRealNumber
    {
        public int a;
        int[] m;
        double[] n;

        public TRealNumber() { }

        public TRealNumber(int a)
        {
            this.a = a;
        }

        public TRealNumber(TRealNumber previousTRealNumber)
        {
            a = previousTRealNumber.a;
        }

        Random rand = new Random();
        public override int Random_Sum_Array()
        {
            int Redefined_RSA = Random_Sum_Array();
            return Redefined_RSA;
        }

        public override double SumQ()
        {
            double Redefined_Sum = SumQ();
            return Redefined_Sum;
        }

        public override string First_Last()
        {
            string Redefined_FL = First_Last();
            return Redefined_FL;
        }
        public override string First_lastQQ()
        {
            string Redefined_FLQ = First_Last();
            return Redefined_FLQ;
        }
    }
}
