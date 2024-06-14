using c_sharp_apps_oded_frig.BankApp;
using c_sharp_apps_oded_frig.DraftApp;
using c_sharp_apps_oded_frig.SportApp;
using c_sharp_apps_oded_frig.TransportationApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_oded_frig.common_system_shared
{
    public class ProcessManager
    {
        public static void Worker()
        {
            Console.WriteLine("Choose one options:\r\n1 – Bank App | 2 – Sport App | 3 – Transportation App | 4 – Draft App | 0- Exit");
            int choise = int.Parse(Console.ReadLine());
            if (choise == 1)
                BankAppMain.MainEntry();
            else if (choise == 2)
                SportAppMain.MainEntry();
            else if (choise == 3)
                TransportationAppMain.MainEntry();
            else if (choise == 4)
                DraftAppMain.MainEntry();




        }
    }
}
