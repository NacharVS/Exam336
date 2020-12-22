using System;

namespace Exam
{

    interface Damage
    {
        public string SetName(string name)
        {
            return name;
        }

        public int SetPower(int power)
        {
            return power;
        }

        public int SetLuck(int luck)
        {
            return luck;
        }

        public int SetLovk(int lovk)
        {
            return lovk;
        }
    }
    class Person : Damage
    {

        public void SetAct()
        {
            int act;
            Console.WriteLine("Совершается действие:");
            Random rnd = new Random();
            act = rnd.Next();
        }

       



    }
    class Program
    {
        static void Main(string[] args)
        {
            Person pers = new Person(); 
            Damage person = new Person();
            Console.WriteLine("Введите имя персонажа");
             
            person.SetName(Console.ReadLine());
           
            Console.WriteLine("Введите силу персонажа");

            person.SetPower(int.Parse(Console.ReadLine()));

            Console.WriteLine("Введите удачу персонажа");

            person.SetLuck(int.Parse(Console.ReadLine()));

            Console.WriteLine("Введите ловкость персонажа");

            person.SetLovk(int.Parse(Console.ReadLine()));

            Console.WriteLine("Введите имя персонажа");
            
            person.Set

        }
    }
}
