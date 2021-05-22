using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSimulation
{
    class PC
    {
        
        public string passport_data_name { get; set; }
        public string education { get; set; }
        public string specialty { get; set; }
        public string position { get; set; }


        private double _salary;
        public double salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value >= 0)
                    _salary = value;
                else
                    throw new Exception("Оклад не може бути відємним");
            }
        }

      

        public PC(string passport_data_name, string education, string specialty, string position, double salary)
        {
            this.passport_data_name = passport_data_name;
            this.education = education;
            this.specialty = specialty;
            this.position = position;
            this.salary = salary;
        }

    }
}
