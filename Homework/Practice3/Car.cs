using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Practice3
{
    public abstract class Car : IVehicle
    {
        public int _oil;
        public int _expenditure;
        public Car(int startOil, int expenditure)
        {
            _oil = startOil;
            _expenditure = expenditure;
        }

        public void Drive(int distance)
        {
            if (_oil > 0)
            {
                Console.WriteLine("Автомобиль движется");
            }
            else
                Console.WriteLine("Автомобиль без бензина не поедет");
        }

        public bool Refuel(int oil)
        {
            _oil += oil;
            return true;
        }
    }
}
