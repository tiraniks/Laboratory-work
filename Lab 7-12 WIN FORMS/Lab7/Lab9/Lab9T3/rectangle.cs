using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9T3
{
    class rectangle
    {
        public int a;


        public int b;        

        public rectangle() { }

        public rectangle(int a, int b) 
        {
            this.a = a;
            this.b = a;
        }

        public rectangle(rectangle previousrectangle) 
        {
            a = previousrectangle.a;
            b = previousrectangle.b;
        }

        public int Rectangle_S() 
        {
            int S = a * b;
            return S;
        }

        public int Rectangle_P() 
        {
            int P = 2 * (a + b);
            return P;
        }

    }
}
