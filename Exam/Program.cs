using System;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] MyArray1 = new int[10, 10];
            int[,] MyArray2 = new int[10, 10];
            int[,] sum = new int [10, 10];
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {

                for (int j = 0; j < 10; j++)
                {
                    MyArray1[i, g] = random.Next(10, 100)
                    Console.Write(MyArray1[i, j] + ' ');


                }
                Console.WriteLine();
            for (int i = 0; i < 10; j++)

            {
                for (int j = 0; j < 10; j++)
                {
                    MyArray2[i,j] = random.Next(10, 100)
                        Console.Write(MyArray2[] + "");
                }
                Console.WriteLine()
            }
            Console.WriteLine("Щтвет")
                for (int i = 0; i < 10; i++)

                {
                for (int j = 0; j < 10; j++)
                {
                        sum[i, j] = MyArray2[] + MyArray1[i, g];
                        Console.Write(sum[] + "");
                }
                Console.WriteLine()
            }
              
            }

        } 
    }
}
