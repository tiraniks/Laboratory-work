using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_WF
{
    class Array
    {
        private double Construct;
        //Конструктор без параметра
        public Array()
        {
            this.Construct = 0;
        }
        //Конструктор з параметром
        public Array(double Arr)
        {
            this.Construct = Arr;
        }
        //Конструктор копіювання
        public Array(Array array)
        {
            this.Construct = array.Construct;
        }



    }
}
