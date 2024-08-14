using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_oded_frig.TransportationApp.task4
{
    public class Driver 
    {
        private string fn;
        private string ln;
        private int id;
        private CargoType carType;

        public Driver(string fn, string ln, int id, CargoType carType)
        {
            this.fn = fn;
            this.ln = ln;
            this.id = id;
            this.carType = carType;
        }

        public bool approve(CargoType CarType, StorageStructure destnation) 
        {
            return true;
        }
    }
}
