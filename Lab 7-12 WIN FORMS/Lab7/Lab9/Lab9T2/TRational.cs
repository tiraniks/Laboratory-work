using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9T2
{
    class TRational
    {
        public double a, b, n;

        public TRational()
        {}

        public TRational(double a, double b, double n) 
        {
            this.a = a;
            this.b = b;
            this.n = n;
        }

        public TRational(TRational previousTRational)
        {
            a = previousTRational.a;
            b = previousTRational.b;
            n = previousTRational.n;
        }

        public double Plus_Rational() 
        {
            
           double c = a / b;
            c = c + n;
            return c;
        }

        public double Minus_Rational()
        {
            
            double c = a / b;
            c = c - n;
            return c;
        }

        public double multiplication_Rational()
        {
            
            double c = a / b;
            c = c * n;
            return c;
        }

        public double division_Rational()
        {
            double c = a / b;
            c = c / n;
            return c;
        }

        public string Conclusion_Rational()
        {
            return $" {a}/{b}";
        }


    }
}
