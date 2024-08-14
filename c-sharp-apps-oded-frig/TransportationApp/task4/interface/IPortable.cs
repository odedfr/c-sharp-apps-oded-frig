using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_oded_frig.TransportationApp.task4
{
    public interface IPortable
    {
        double GetArea(); // חישוב שטח

        double[] GetSize();  // חישוב מימדי האובייקט: רוחב, אורך, גובה

        double GetVolume();  // חישוב נפח

        double GetWeight(); // חישוב משקל

        void PackageItem(); // אריזת הפריט

        bool IsPackaged(); // בדיקת האם הפריט ארוז

        void UnPackage(); // פתיחת אריזת הפריט

        bool IsFragile(); // בדיקת האם הפריט שביר

        string GetLocation(); // החזרת מיקום האחסון הנוכחי

        bool IsLoaded(); // בדיקת האם הפריט נמצא על רכב משא
    }

}
