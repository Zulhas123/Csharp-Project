using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Approach
{
    public class TypeSpecificVehicle<T> : ITypeSpecificFeatures<T>
    {

  

        string ITypeSpecificFeatures<T>.GetTypeSpecificFeature<T>(T data)
        {
            DataBuffer db = new DataBuffer();

            string Feature = string.Empty;
            if (data is Vehicles)
            {
                Vehicles a = data as Vehicles;

                switch (a.Type)
                {
                    case vehicleYType.AirWay:
                        Feature = db.dataBuff.Where(imran => imran.Type == vehicleYType.AirWay).FirstOrDefault().Feature;
                        break;
                    case vehicleYType.WaterWay:
                        Feature = db.dataBuff.Where(sharmin => sharmin.Type == vehicleYType.WaterWay).FirstOrDefault().Feature;
                        break;
                    case vehicleYType.pathWay:
                        Feature = db.dataBuff.Where(w => w.Type == vehicleYType.pathWay).FirstOrDefault().Feature;
                        break;
                    default:
                        Feature = "Unknown behaviour";
                        break;

                }
            }
            else
            {

                Feature = "This is Another Type";

            }

            return Feature;
        }
    }
    
}     
