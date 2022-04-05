using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Trike : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("A futuristic Slingshot trike is being built right now.");
        }
    }
}
