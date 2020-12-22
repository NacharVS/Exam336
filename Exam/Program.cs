using System;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[10, 10];
            int[,] sumnums = new int[10, 10];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                 
                    for matrix1[i, j] = rnd.Next(0, 100)
                }

            }
            int summ = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == j) ;
                    {
                        summ += matrix[i, j];
                    }
                }
                Console.WriteLine(matrix[i, j] + " ");
            }
            Console.WriteLine();

        }
        Console.WriteLine($"Сумма элемнтов равна: {summ}");
    }

}
