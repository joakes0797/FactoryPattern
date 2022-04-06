using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Unicycle : IVehicle
    {
        public Unicycle()
        {
            Console.WriteLine("What balance you must have!");
        }
        public void Drive()
        {
            Console.WriteLine($"One electric {GetType().Name}, coming right up!");
        }
    }
}
