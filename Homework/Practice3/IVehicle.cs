using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Practice3
{
    public interface IVehicle
    {
        public void Drive(int distance);
        public bool Refuel(int oil);
    }
}
