using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    class Bank
    {
        private string _Sur;
        private long _Acc;
        delegate void uv();  
        public Bank(string sur, long Acc)
        {
            _Sur = sur;
            sur = sur.Trim();
            var firstLet1 = sur[0];
            var lastLet1 = sur.Remove(0, 1);
            _Sur = firstLet1.ToString().ToUpper() + lastLet1;
            if(Acc < 0)
            {
                Console.WriteLine("Недопустимое значение!");
                Console.WriteLine("Ведите повторно:");
                Acc = long.Parse(Console.ReadLine());               
            }
            _Acc = Acc;
        }
        public void man(int a)
        {
            Console.WriteLine("Выберите №: " + "\n" +
                "1 - Снять наличные" + "\n" +
                "2 - Внести наличные");
            int i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    {
                        Console.WriteLine("ВВедите значение: ");
                        long ca = long.Parse(Console.ReadLine());
                        if (ca < 0)
                        {
                            Console.WriteLine("Недопустимое значение!");
                            Console.WriteLine("Ведите повторно:");
                            ca = long.Parse(Console.ReadLine());
                            Console.WriteLine("Сняли налиные:");
                        }
                        _Acc -= ca;
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("ВВедите значение: ");
                        long ca = long.Parse(Console.ReadLine());
                        if (ca < 0)
                        {
                            Console.WriteLine("Недопустимое значение!");
                            Console.WriteLine("Ведите повторно:");
                            ca = long.Parse(Console.ReadLine());
                            Console.WriteLine("Внесли налиные:");                            
                        }
                        _Acc += ca;
                       
                        break;
                    }
                default:
                    Console.WriteLine("Вы ввели не верный номер!");
                    return;
            }


        } 
        private static void pay()
        {
            Console.WriteLine("Сняли налиные:");
        }
        private static void pop()
        {
            Console.WriteLine("Внесли налиные:");
        }
    }
}
