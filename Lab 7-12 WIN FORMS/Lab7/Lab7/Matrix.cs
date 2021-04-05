using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Matrix
    {
        static public int n;

        int b = n;

        public Matrix(){}

        public Matrix(int b)
        {
            this.b = b;
        }     

        int[,] matrix = new int[n, n];

        public Matrix(int[,] matrix)
        {

        }

        public int[,] Print()
        {
            return matrix;
        }

        

        Random rand = new Random(DateTime.Now.Millisecond);

        //Введення матриці
        public int[,] InputMatrix()
        {
            

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rand.Next(-100, 100);
                }
            }

            return matrix;

        }
        
        public int Min()
        {
            int a = matrix[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] < a)
                    {
                        a = matrix[i, j];
                    }
                }
            }
            return a;

           
        }

        public int Max()
        {
            int a = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a < matrix[i, j])
                    {
                        a = matrix[i, j];
                    }
                }
            }
            return a;
        }
    }
}    
