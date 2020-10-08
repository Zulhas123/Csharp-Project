using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Approach
{
    public class VehicleFeature//AnimalBehaviour
    {
        public VehicleFeature[] behaveBuffer;
        public VehicleFeature(vehicleYType vehicleType, string Feature)
        {
            this.Type = vehicleType;
            this.Feature = Feature;//***

        }

        public VehicleFeature()
        {


        }
        public vehicleYType Type { get; set; }

        public string Feature { get; set; }
    }

    public class DataBuffer
    {

        public VehicleFeature[] dataBuff;

        public DataBuffer()
        {
            VehicleFeature vf = new VehicleFeature();
            
            vf.behaveBuffer = new VehicleFeature[]
            {
               new VehicleFeature(){Feature ="fly in the sky"  , Type = vehicleYType.AirWay } ,

               new VehicleFeature(){Feature ="Run in the water"  , Type = vehicleYType.WaterWay } ,
               new VehicleFeature(){Feature =" Run on the road"  , Type = vehicleYType.pathWay }
            };
            dataBuff = vf.behaveBuffer;
        }

    }
}
