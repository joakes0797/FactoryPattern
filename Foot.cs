using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Foot : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("You're walking, pal!");
        }
    }
}
