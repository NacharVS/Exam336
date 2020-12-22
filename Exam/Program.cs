using System;

namespace Exam
{
    class Programm
    {
        public static void GenerationArray(int[] arr, int MinN, int MaxN)
        {
            Console.WriteLine("sgr mas");
            Random rnd = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                arr[i] = rnd.Next(MinN, MaxN);
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            return;
        }

        private static void SumArray(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                sum = sum + arr[i];
                Console.WriteLine($"Сумма - {sum} ");
            }

            return;
        }
        static void SortArray(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int n = i + 1; n < arr.Length; n++)
                {
                    if (arr[i] > arr[n])
                    {
                        temp = arr[i];
                        arr[i] = arr[n];
                        arr[n] = temp;
                    }
                }
            }
            return;
        }
        private static void PrArr(int[] arr)
        {
            int pr = arr[1];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                pr = pr * arr[i];
            }
            Console.WriteLine($"Произведение - {pr} ");
            return;
        }


        delegate void ObrMas(int[] Arr);
        static void Main(string[] args)
        {
            int[] Arr = new int[10];
            GenerationArray(Arr, 0, 10);
            ObrMas del;
            del = SumArray;
            del = PrArr;
            del = SortArray;
            del(Arr);
            //
        }
    }
}