using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Practice2
{
    public class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("Я учусь");
        }

        public void ShowAge()
        {
            Console.WriteLine($"Мой возраст: {_age}");
        }
    }
}
