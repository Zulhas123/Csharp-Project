using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            VehicleModel[] vmArray = new VehicleModel[]
           {
                new VehicleModel(){ModelID = 1,ModelName = "BMW2002",Type = "Compact executive Car",BasedON = "ZAZ_968Zeporozila"},
                 new VehicleModel(){ModelID = 2,ModelName = "1976Avto",Type = "Supermini",BasedON = "ZAZ-9678"},
                  new VehicleModel(){ModelID = 3,ModelName = "0023DER",Type = "Semihauler",BasedON = "WaW-8745"},
                  new VehicleModel(){ModelID = 4,ModelName = "733XYX",Type = "City Car",BasedON = "PPO-234"},
                  new VehicleModel(){ModelID = 5,ModelName = "TR9ooR",Type = "PickUp",BasedON = "RRR-8745"},
                  new VehicleModel(){ModelID = 6,ModelName = "200 1/2 ton",Type = "Semihauler",BasedON = "KKK-8745"}


           };

            Vehicle[] vArray = new Vehicle[]
            {
              new Vehicle(){VehicleID = 1,VehicleName = "Bulldozer",Color = "RED",LifeSpan ="Ten Years", ModelID = 1,CategoryID = 2},
              new Vehicle(){VehicleID = 2,VehicleName = "Bus",Color = "Yellow",LifeSpan ="Fifteen Years",ModelID=2,CategoryID= 3},
              new Vehicle(){VehicleID = 3,VehicleName = "Caraven",Color = "White",LifeSpan ="Twenty Years", ModelID=4, CategoryID =1},
              new Vehicle(){VehicleID = 4,VehicleName = "Cran",Color = "White",LifeSpan ="Thirty Years", ModelID=4, CategoryID =4},
              new Vehicle(){VehicleID = 5,VehicleName = "Dump Truk",Color = "Black",LifeSpan ="Five Years", ModelID=5, CategoryID =5},
              new Vehicle(){VehicleID = 6,VehicleName = "Bargaton",Color = "White",LifeSpan ="Twenty Years", ModelID=6, CategoryID =1},
              new Vehicle(){VehicleID = 3,VehicleName = "Totaya",Color = "Yellow",LifeSpan ="Twelve Years", ModelID=4, CategoryID =6},
             new Vehicle(){VehicleID = 3,VehicleName = "Torralla",Color = "RED",LifeSpan ="Ten Years", ModelID=1, CategoryID =4},





            };
            VehicleCategory[] vcArray = new VehicleCategory[]
            {
                new VehicleCategory(){CategoryID = 1,CategoryName = "Passenger Cars"},
                new VehicleCategory(){CategoryID = 2,CategoryName = "BusesAnd Coaches"},
                new VehicleCategory(){CategoryID = 3,CategoryName = "Cpmmercial Vehicles"},
                new VehicleCategory(){CategoryID = 4,CategoryName = "Heavy Van"},
                new VehicleCategory(){CategoryID = 5,CategoryName = "Light Trailers"},
                new VehicleCategory(){CategoryID = 6,CategoryName = "Non Specific"},
                new VehicleCategory(){CategoryID = 7,CategoryName = "Motorcycles"},
                new VehicleCategory(){CategoryID = 8,CategoryName = "SideCar MotorS"},
            };

            var result = from m in vmArray
                         join v in vArray
                         on m.ModelID equals v.ModelID 
                         join c in vcArray
                         on v.CategoryID equals c.CategoryID

                         select new {v.VehicleID, v.VehicleName,v.Color,v.LifeSpan,
                                    c.CategoryID,c.CategoryName,
                                    m.ModelID,m.Type,m.BasedON,m.ModelName };
            foreach (var a in result)
            {
                Console.WriteLine(a.ToString().Replace("{" , "").Replace(" }",""));
            }
            Console.ReadKey();

        }

    }
    
}
