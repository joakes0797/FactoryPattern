using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Car : IVehicle
    {
        public Car()
        {
            Console.WriteLine("Acknowledged.");
        }
        public void Drive()
        {
            Console.WriteLine($"Building a new {GetType().Name}, one moment please.");
        }
    }
}
