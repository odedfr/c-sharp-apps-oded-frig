using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_oded_frig.TransportationApp.task4
{
    public abstract class CargoVehicle : IContainable
    {
        private Driver driver;
        private double MaxWeight { get => this.MaxWeight; set => MaxWeight = value; }
        private double MaxVolume { get => this.MaxVolume; set => MaxVolume = value; }
        private bool driveAble;
        private bool overLoad;
        private StorageStructure currentLocation; 
        private StorageStructure nextLocation; 
        private int driveId;
        private Random rnd = new Random();
        private List<IPortable> ItamesToWareHouse { get; } = new List<IPortable>();
        double DrivePay; //IShippingPriceCalculator
        private double CurrentWeight { get => this.CurrentWeight; set => CurrentWeight = value; }
        private double currentVolume { get => this.currentVolume; set => currentVolume = value; }
        private double distance { get => this.distance; set => distance = value; }



        public CargoVehicle(Driver driver, double maxWeight, double maxVolume, bool driveable, bool overload)
        {
            this.driver = driver;
            this.MaxWeight = maxWeight;
            this.MaxVolume = maxVolume; 
            this.driveAble = driveable;
            this.overLoad = overload;
            this.CurrentWeight = 0;
            this.currentVolume = 0;
            this.driveId = rnd.Next(1000, 10000);
        }
        
        public abstract bool Load();

        public abstract bool Load(IPortable item);

        public abstract bool Load(List<IPortable> items);

        public abstract bool Unload();

        public abstract bool Unload(IPortable item);

        public abstract bool Unload(List<IPortable> items);
        
        public bool IsHaveRoom()
        {
            return currentVolume < MaxVolume && CurrentWeight < MaxWeight;
        }

        public bool IsOverload()
        {
            return currentVolume > MaxVolume || CurrentWeight > MaxWeight;
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
            return currentVolume;
        }

        public double GetCurrentWeight()
        {
            return CurrentWeight;
        }

        public virtual string GetPricingList()
        {
            return "";
        }
    }


}
