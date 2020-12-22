using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    class BankAccount
    {
        private static string _familiya;
        private static string _imya;
        private static string _otchectvo;
        private static double _balance;
        private static string _datebirth;
        private static int _age;

        public void SetFam(string familiya)
        {
            _familiya = familiya;
        }
        public void SetImya(string imya)
        {
            _imya = imya;
        }
        public void SetOtch(string otchectvo)
        {
            _otchectvo = otchectvo;
        }
        public void SetBalance(int balance)
        {
            _balance = balance;
        }
        public void SetDateBirth(int day, int month, int year)
        {
            _datebirth = ($"{day}.{month}.{year}");
            if (DateTime.Now.Month >= month && DateTime.Now.Day >= day)
            { _age = DateTime.Now.Year - year; }
            else _age = DateTime.Now.Year - year - 1;
            if (_age == 17)
            {
                Console.WriteLine("Ваш возраст меньше 18 лет, вам запрещена регистрация банковского счёта");
            }
        }
        
        
    }
}
