using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_oded_frig.BankApp
{
    public class Account
    {
        private const int Max_OverDraft = 90000;
        private Owner _owner;
        private double _balance;
        private int _overdraft;

        public Account(Owner owner, double balance, int overdraft)
        {
            this._owner = owner;
            this._balance = balance;
            this._overdraft = overdraft;
        }

        #region geters

        public Owner GetOwner()
        {
            return this._owner;
        }
        public double GetBalance()
        {
            return this._balance;
        }
        public int GetOverdraft()
        {
            return this._overdraft;
        }

        #endregion

        public void SetOverdraft(int overdraft)
        {
            if (overdraft > Max_OverDraft)
            {
                Console.WriteLine($"bank didnt approve max overdraft is {Max_OverDraft}");
            }
            else
                this._overdraft = overdraft;
        }

        public void Deposit(double money)
        {
            if (money > 0)
                this._balance += money;
        }

        public void Withdraw(double money)
        {
            if (this._balance - money > -this._overdraft)
                this._balance -= money;
            else
                Console.WriteLine($"exceeding the possible overdraft the maximum amount to withraw is {this._overdraft + this._balance}");
        }


    }
}
