using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_oded_frig.TransportationApp.task4
{
    using System.Collections.Generic;

    public interface IContainable
    {
        bool Load();

        bool Load(IPortable item);

        bool Load(List<IPortable> items);

        bool Unload();

        bool Unload(IPortable item);

        bool Unload(List<IPortable> items);

        bool IsHaveRoom();

        bool IsOverload();

        double GetMaxVolume();

        double GetMaxWeight();

        double GetCurrentVolume();

        double GetCurrentWeight();

        string GetPricingList();
    }

}
