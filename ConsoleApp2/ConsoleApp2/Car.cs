using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("car is Driving");
        }
    }
}
