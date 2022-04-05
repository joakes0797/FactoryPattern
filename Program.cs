using System;

namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a new console app that utilizes factory pattern by taking a user’s input of
            //      how many tires are on a vehicle and, based on their input, creates that type of vehicle. --done
            //Complete this using an interface. You must have at least 2 subclasses.        --done

            //	• Create an Interface named IVehicle that has a stubbed out public void Drive method.       --done
            //	• Create at least 2 new public classes that will conform to IVehicle.        --done

            //    These classes must conform to IVehicle and implement the Drive() method - which will
            //          just Console.WriteLine(“Building a new Car!”)       --done

            //	• Make a static VehicleFactory class.        --done
            //		○ It will contain a static method GetVehicle(), that will return an IVehicle based on
            //		    the amount of tires it’s given as a parameter.      --done
            //Call this functionality in the Main method.       --done

            Console.WriteLine("Welcome to the Vehicle Factory.");

            bool userTire;
            int result;

            do
            {
                Console.WriteLine("Enter the number of tires needed for your ride: ");
                userTire = int.TryParse(Console.ReadLine(), out result);
            } while (!userTire);

            IVehicle vehicle = VehicleFactory.GetVehicle(result);
            vehicle.Drive();

        }
    }
}
