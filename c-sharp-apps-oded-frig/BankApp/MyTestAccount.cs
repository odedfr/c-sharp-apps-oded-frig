using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_oded_frig.BankApp
{
    public class MyTestAccount
    {
        public MyTestAccount()
        {
            
            Console.WriteLine("test account - test 1");
            Console.WriteLine("testing owner creation");
            OwnerTest();
            TestDeposit();




        }
        public static void OwnerTest()
        {
            Owner owner = new Owner("oded", "frig");
            Console.WriteLine("Owner Test:");
            Console.WriteLine($"First Name: {owner.GetFirstName()}");
            Console.WriteLine($"Last Name: {owner.GetLastName()}");

            Console.WriteLine("passed");
        }

        public static void TestDeposit()
        {
            Owner owner = new Owner("oded", "frig");
            Account account = new Account(owner, 9000, 4000);
            Console.WriteLine("deposit test");

            Console.WriteLine($"currect balance {account.GetBalance()}");
            account.Deposit(500);
            if (account.GetBalance()==9500)
            {
                Console.WriteLine($"deposeted 500 now the balance is {account.GetBalance()}");
                Console.WriteLine("deposite sucsess");
                Console.WriteLine("passed");
            }


        }
    }
}
