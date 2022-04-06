using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
            Console.WriteLine("Two wheels...");
        }
        public void Drive()
        {
            Console.WriteLine($"Building a new {GetType().Name}, just for you.");
        }
    }
}
