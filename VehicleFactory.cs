using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class VehicleFactory
    {
        public static IVehicle GetVehicle(int result)
        {
            //will return an IVehicle based on the amount of tires it’s given as a parameter
            
            switch (result)
            {
                case 0:
                    return new Foot();
                case 1:
                    return new Unicycle();
                case 2:
                    return new Motorcycle();
                case 3:
                    return new Trike();
                case 4:
                    return new Car();
                default:
                    return new Car();
            }
        }
    }
}
