using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    class Bank
    {
        private string _Sum;
        private int _Acc;
            public void ABC(int a)
            {
                Console.WriteLine("Выберите действие: " + "1 - Снять " + "" + "2 - Внести ");
                int i = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        {
                            Console.WriteLine("ВВедите значение: ");
                            int M = int.Parse(Console.ReadLine());
                            if (M < 0)
                            {
                                M = int.Parse(Console.ReadLine());
                                Console.WriteLine("Сняли налиные:");
                            }
                            _Acc -= M;
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("ВВедите значение: ");
                            int M = int.Parse(Console.ReadLine());
                            if (M < 0)
                            {
                                M = int.Parse(Console.ReadLine());
                                Console.WriteLine("Внесли налиные:");
                            }
                            break;
                        }
                    default:
                        return;
                }

            }
            public static void snat()
            {
                Console.WriteLine("Сняли:");
            }
            public static void polosh()
            {
                Console.WriteLine("Внесли:");
            }
        

    }
}
