using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Trike : IVehicle
    {
        public Trike()
        {
            Console.WriteLine("Go easy on those high-speed turns...");
        }
        public void Drive()
        {
            Console.WriteLine($"A futuristic Slingshot {GetType().Name} is being built right now.");
        }
    }
}
