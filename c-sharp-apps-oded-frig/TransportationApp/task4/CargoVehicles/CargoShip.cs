using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_oded_frig.TransportationApp.task4
{
    public class CargoShip : CargoVehicle
    {
        private List<Container> itames;
        int Price;

        public CargoShip(Driver driver, double maxWeight, double maxVolume, bool driveable, bool overload, CalcPrice calc)
            : base(driver, maxWeight, maxVolume, driveable, overload)
        {
            this.Price = calc.price() * 20;
        }

        public override bool Load()
        {
            throw new NotImplementedException();
        }

        public override bool Load(IPortable item)
        {
            throw new NotImplementedException();
        }

        public override bool Load(List<IPortable> items)
        {
            throw new NotImplementedException();
        }

        public override bool Unload()
        {
            throw new NotImplementedException();
        }

        public override bool Unload(IPortable item)
        {
            throw new NotImplementedException();
        }

        public override bool Unload(List<IPortable> items)
        {
            throw new NotImplementedException();
        }


    }
}
