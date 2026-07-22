using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Practice2
{
    public class Person
    {
        public int _age;
        public void Greet()
        {
            Console.WriteLine("Привет");
        }

        public void ShowAge()
        {
            Console.WriteLine($"Мой возраст: {_age}");
        }

        public int SetAge(int age)
       {
          _age = age;
          return _age;
       }
    }
}
