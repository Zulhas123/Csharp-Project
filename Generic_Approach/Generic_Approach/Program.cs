using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Approach
{
   
    class Program
    {

        static void Main(string[] args)
        {




            Vehicles Areoplan = new Vehicles { Name = "Areoplan", LifeSpan = 30, Type = vehicleYType.AirWay };
            GenericVehicle<Vehicles> vehicle = new GenericVehicle<Vehicles>();
            Console.WriteLine(vehicle.IGenericFeatures(Areoplan));


            Vehicles Launch = new Vehicles { Name = "Launch", LifeSpan = 40, Type = vehicleYType.WaterWay }; 
            TypeSpecificVehicle<Vehicles> obj2 = new TypeSpecificVehicle<Vehicles>();
            ITypeSpecificFeatures<Vehicles> iItemBe = obj2;
            Console.WriteLine(iItemBe.GetTypeSpecificFeature(Launch));
            Console.ReadLine();

        }
    }
}
