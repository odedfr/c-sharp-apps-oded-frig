using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_oded_frig.TransportationApp.task4.CargoVehicles
{
    public class Container : ICloneable
    {
        public double Weight { get; private set; }
        public double Volume { get; private set; }

        public Container(double weight, double volume)
        {
            Weight = weight;
            Volume = volume;
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }

}
