using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covarience
{
    internal class Vehicle
    {
        
        
            
            public Vehicle CreateVehicle()
            {
                Console.WriteLine("Vehicle created");
                return new Vehicle();
            }
         
            public void Display(Vehicle vehobj)
            {
                Console.WriteLine("Vehicles class Method" + vehobj);
            }

        }
        class Bike : Vehicle
        {
            public Bike CreateBike()
            {
                Console.WriteLine("BIKE Created");
                return new Bike();
            }
            public void DisplayBike(Bike Bikeobj)
            {
                Console.WriteLine("bike class Method" + Bikeobj);
            }
        }
    
}
