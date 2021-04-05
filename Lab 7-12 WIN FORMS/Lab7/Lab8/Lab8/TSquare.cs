using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class TSquare
    {
        public double n;

        public TSquare()
        {
            this.n = 0;
        }

        public TSquare(double n)
        {
            this.n = n;

        }

        public TSquare(TSquare previousTSquare)
        {
            n = previousTSquare.n;
        }


        public string Input_Output()
        {
            return $"ABCD {n}";
        }


        public double SSquare()
        {
            double S = n * n;
            return S;
        }


        public double PerimeterSquare()
        {
            double P = 4 * n;
            return P;
        }

        public string RandomSquare(TSquare OtherSquare)
        {
            if (PerimeterSquare() == OtherSquare.PerimeterSquare())
            {
                return "Квадрат рівний";
            }
            else
            {
                return "Квадрат не рівний";
            }
        }

        public static TSquare operator +(TSquare Square, TSquare randSquare)
        {
            TSquare n1 = new TSquare(Square);
            TSquare n2 = new TSquare(randSquare);
            return new TSquare(Math.Pow(Square.n + randSquare.n,2));
        }
        public static TSquare operator -(TSquare Square, TSquare randSquare)
        {
            TSquare m1 = new TSquare(Square);
            TSquare m2 = new TSquare(randSquare);
            return new TSquare(Math.Pow(Square.n - randSquare.n,2));
        }
        public static TSquare operator *(TSquare Square, double k)
        {
            return new TSquare(Math.Pow(Square.n * k,2));
        }
    }
}
