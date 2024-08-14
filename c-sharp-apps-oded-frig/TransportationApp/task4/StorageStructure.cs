using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_oded_frig.TransportationApp.task4
{
    public abstract class StorageStructure : IContainable
    {
        private string _Country { get => this._Country; }
        private string _City { get => this._City; }
        private string _Street { get => this._Street; }
        private int _Number { get => this._Number; }


        private double MaxVolume { get => this.MaxVolume; }
        private double MaxWeight { get => this.MaxWeight; }

        protected double CurrentVolume { get => this.CurrentVolume; private set => CurrentVolume = value; }
        protected double CurrentWeight { get => this.CurrentWeight; private set => CurrentWeight = value; }

        private List<IPortable> Items { get; } = new List<IPortable>();

        public StorageStructure(string country, string city, string street, int number)
        {
            country = this._Country;
            city = this._City;
            street = this._Street;
            number = this._Number;
        }

        public abstract bool Load();

        public abstract bool Load(IPortable item);

        public abstract bool Load(List<IPortable> items);

        public abstract bool Unload();

        public abstract bool Unload(IPortable item);

        public abstract bool Unload(List<IPortable> items);

        public bool IsHaveRoom()
        {
            return (CurrentVolume < MaxVolume) && (CurrentWeight < MaxWeight);
        }

        public bool IsOverload()
        {
            return (CurrentVolume > MaxVolume) || (CurrentWeight > MaxWeight);
        }

        public double GetMaxVolume()
        {
            return MaxVolume;
        }

        public double GetMaxWeight()
        {
            return MaxWeight;
        }

        public double GetCurrentVolume()
        {
            return CurrentVolume;
        }

        public double GetCurrentWeight()
        {
            return CurrentWeight;
        }


        public string GetPricingList()
        {
            return "";
        }
        public override string ToString()
        {
            return $"{base.ToString()} ";
        }

        // פונקציות עזר להוספה והסרה של פריטים

        protected bool AddItem(IPortable item)
        {
            double itemVolume = item.GetVolume();
            double itemWeight = item.GetWeight();

            if (CurrentVolume + itemVolume <= MaxVolume && CurrentWeight + itemWeight <= MaxWeight)
            {
                Items.Add(item);
                CurrentVolume += itemVolume;
                CurrentWeight += itemWeight;
                return true;
            }
            return false;
        }

        protected bool RemoveItem(IPortable item)
        {
            if (Items.Remove(item))
            {
                CurrentVolume -= item.GetVolume();
                CurrentWeight -= item.GetWeight();
                return true;
            }
            return false;
        }
    }

}
