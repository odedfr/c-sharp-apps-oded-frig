using c_sharp_apps_oded_frig.BankApp;
using c_sharp_apps_oded_frig.DraftApp;
using c_sharp_apps_oded_frig.SportApp;
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
                DraftAppMain.MainEntry();
            else if (choise == 3)
                SportAppMain.MainEntry();




        }
    }
}
