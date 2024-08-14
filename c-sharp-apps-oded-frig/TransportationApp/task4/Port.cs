using System;
using System.Collections.Generic;

namespace c_sharp_apps_oded_frig.TransportationApp.task4
{
    public class Port : StorageStructure
    {
        private CargoType driverType;
        private List<IPortable> items;

        public Port(CargoType driverType, string country, string city, string street, int numAddress)
            : base(country, city, street, numAddress)
        {
            this.driverType = driverType;
            this.items = new List<IPortable>();
        }

        public override bool Load(IPortable item)
        {
            if (item == null)
            {
                return false;
            }

            items.Add(item);
            return true;
        }

        public override bool Load(List<IPortable> items)
        {
            if (items == null || items.Count == 0)
            {
                return false;
            }

            foreach (var item in items)
            {
                if (item == null)
                {
                    return false;
                }
                this.items.Add(item);
            }

            return true;
        }

        public override bool Unload(IPortable item)
        {
            if (item == null || !items.Contains(item))
            {
                return false;
            }

            items.Remove(item);
            return true;
        }

        public override bool Unload(List<IPortable> items)
        {
            if (items == null || items.Count == 0)
            {
                return false;
            }

            foreach (var item in items)
            {
                if (!this.items.Contains(item))
                {
                    return false;
                }
                this.items.Remove(item);
            }

            return true;
        }

        public override bool Load()
        {
            throw new NotImplementedException("Load method without parameters is not implemented.");
        }

        public override bool Unload()
        {
            throw new NotImplementedException("Unload method without parameters is not implemented.");
        }
    }
}
