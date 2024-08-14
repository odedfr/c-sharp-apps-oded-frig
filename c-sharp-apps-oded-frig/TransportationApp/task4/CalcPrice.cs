using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_oded_frig.TransportationApp.task4
{
    public class CalcPrice
    {
        private int _Volume;
        private int _Wieght;
        private bool _Fragile;

        public CalcPrice(bool fragile, int volume, int wieght)
        {
            this._Volume = volume / 100;
            this._Fragile = fragile;
            this._Wieght = wieght;
        }

        public int price()
        {
            if (this._Fragile)
            {
                return (this._Volume + this._Wieght) * 2;
            }
            else
                return (this._Volume + this._Wieght);
        }
    }
}
