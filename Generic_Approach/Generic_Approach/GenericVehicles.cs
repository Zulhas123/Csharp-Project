using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Approach
{
    public class GenericVehicle<T> : IGenericFeatures<T>
    {
        public string IGenericFeatures(T obj)
        {
            DataBuffer db = new DataBuffer();

            string Feature = string.Empty;
            if (obj is Vehicles)
            {
                Vehicles v = obj as Vehicles;
                switch (v.Type)
                {
                    case vehicleYType.WaterWay:
                        Feature = db.dataBuff.Where(w => w.Type == vehicleYType.WaterWay).FirstOrDefault().Feature;
                        break;
                    case vehicleYType.AirWay:
                        Feature = db.dataBuff.Where(w => w.Type == vehicleYType.AirWay).FirstOrDefault().Feature;
                        break;
                    case vehicleYType.pathWay:
                        Feature = db.dataBuff.Where(w => w.Type == vehicleYType.pathWay).FirstOrDefault().Feature;
                        break;
                    default:
                        Feature = "Unknown Feature";
                        break;
                }

            }
            else
            {
                Feature = "Not an Vehicle";
            }
            return Feature;
        }
    }
}
