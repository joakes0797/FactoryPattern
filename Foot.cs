using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Foot : IVehicle
    {
        public Foot()
        {
            Console.WriteLine("Zero wheels?");
        }
        public void Drive()
        {
            Console.WriteLine($"You're walking, pal! Left {GetType().Name}, Right {GetType().Name}.");
        }
    }
}
