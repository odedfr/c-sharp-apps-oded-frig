using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_oded_frig.BankApp
{
    public class Owner
    {
        private string FirstName;
        private string LastName;

        public Owner(string Fn, string LN)
        {
            this.FirstName = Fn;
            this.LastName = LN;
        }

        #region geters

        public string GetFirstName()
        {
            return this.FirstName;
        }
        public string GetLastName()
        {
            return this.LastName;
        }
        #endregion

    }
}
