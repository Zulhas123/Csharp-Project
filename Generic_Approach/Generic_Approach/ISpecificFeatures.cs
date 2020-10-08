using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Approach
{
    public interface ITypeSpecificFeatures<T> 
    {
        string GetTypeSpecificFeature<T>(T data) where T : Vehicles;
    }
}
