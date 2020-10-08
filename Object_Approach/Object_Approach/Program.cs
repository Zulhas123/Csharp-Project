using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    abstract class Seller
    {
        protected string Name { set; get; }
        protected string Model { set; get; }
        //protected string Type { set; get; }

    }
    interface ISellableVehicle
    {
        string ListOFSellableVehicles(string VehicleName);
    }

    class BetweenSellerAndVehicle : Seller, ISellableVehicle
    {
        string ISellableVehicle.ListOFSellableVehicles(string VehicleName)
        {
            return VehicleName;
        }
    }
    sealed class Vehicle : BetweenSellerAndVehicle
    {


        public Vehicle(String Name, String Model)
        {
            this.Name = Name;
            this.Model = Model;
        }
        public string CodeNo { set; get; }


        public string Date_OF_Production { get; set; }


        public override string ToString()
        {
            return $"Name : {this.Name} , Model : {this.Model} , CodeNo:{CodeNo} ,  Date_OF_Production: {Date_OF_Production}";
        }

    }


    class Program
    {

        enum Vehicles
        {
            Bus = 0,
            Carriage = 1,
            Crane = 2,
            CamperVan = 3,
            DumpTruck = 4,
            Helicopter = 5,
            Motorcycle = 6,
            Ambulance = 7,
            Bulduzer = 8


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Available Vehicles");
            var enumlist = Enum.GetNames(typeof(Vehicles));
            foreach (var v in enumlist)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("*************************************");
            Console.WriteLine("Tell me Vehicle Name Please...........");
            string Name = Console.ReadLine();


            Console.WriteLine("*************************************");
            Console.WriteLine("Tell me the model of the car Please...........");
            string Model = Console.ReadLine();


            Vehicle vehicle = new Vehicle(Name, Model);

            Console.WriteLine("Enter The CodeNo OF Car Please...........");
            vehicle.CodeNo = Console.ReadLine();

            Console.WriteLine("Enter the Date_OF_Production Please...........");
            string Date_OF_Production = Console.ReadLine();


            Console.WriteLine("Vehicle Information is below");
            Console.WriteLine(vehicle.ToString());


            Console.WriteLine("Enter your  Sellabe Car Please... ");
            string Sellable_Car = Console.ReadLine();


            ISellableVehicle isl = (ISellableVehicle)vehicle;




            List<string> VehicleList = new List<string>();
            VehicleList.Add(isl.ListOFSellableVehicles(Sellable_Car));


            bool yesProceed = true;
            while (yesProceed)
            {
                Console.WriteLine("More Vehicles ? Yes Or No");
                string YesNoInput = Console.ReadLine();
                if (YesNoInput.ToUpper() == "Yes".ToUpper())
                {
                    Console.WriteLine("Vehicle_Name");
                    string VehicleName = Console.ReadLine();
                    VehicleList.Add(isl.ListOFSellableVehicles(VehicleName));



                }
                else
                {
                    yesProceed = false;
                }



            }
            Console.WriteLine("you have Sold more Vehicles");
            foreach (var s in VehicleList)
            {
                Console.WriteLine(s);

            }

            Console.ReadLine();
        }
    }
}
