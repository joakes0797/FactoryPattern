using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Unicycle : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("One electric unicycle, coming right up!");
        }
    }
}
