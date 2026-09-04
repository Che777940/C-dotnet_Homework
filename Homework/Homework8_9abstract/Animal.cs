using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Homework8_9
{
    public abstract class Animal
    {
        public string _name { get; set; }

        public string SetName(string name)
        {
            _name = name;
            return name; 
        }

        public string getName()
        {
            Console.WriteLine($"Имя собаки: {_name}");
            return _name;
        }

        public abstract void Eat();

    }
}
