using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Task
{
    public static class Experiment
    {
        public static void ChangeValue(ref int x)
        {
            Console.WriteLine($"{x}");
            x = 100; 
        }


    }
}
