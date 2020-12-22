using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    class Class1
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int r = random.Next();
            int[,] Matrix = new int[r, r];
            int rand;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    rand = random.Next(0, 100);
                    Matrix[i, j] = rand;
                }
            }

 
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    Console.Write(Matrix[i, j]);
                }
                Console.WriteLine();
            }

            int max = 0;

            for(int i = 0; i < r; i++)
            {
                
            }
            
        }


        
    }
}
