using System;
using static System.Console;
namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// Develop a C# app that will determine whether any of several
    /// department-store customers has exceeded the credit limit on a charge
    /// account. For each customer, the following facts are available:
    ///    1) account number,
    ///    2) balance at the beginning of the month,
    ///    3) total of all items charged by the customer this month,
    ///    4) total of all credits applied to the customer’s account this month and,
    ///    5) allowed credit limit.
    /// The app should input all these facts as integers,
    /// calculate the new balance(= beginning balance + charges – credits),
    /// display the new balance and determine whether the new balance exceeds
    /// the customer’s credit limit.
    /// For those whose credit limit is exceeded, 
    /// the app should display the message "Credit limit exceeded" on a separate line. 
    /// Use sentinel-controlled iteration to obtain the data for each account
    /// (e.g. the iteration will terminate if the account number is a
    /// negative number).
    /// </summary>
    public class CreditLimitCalculator
    {
        public static void Main()
        {


            // read in account number
            // Enter your sentinel loop here

            int accnum;
            int startbalance;
            int charges;
            int credit;
            int creditlimit;
            int calnewbalance;
            string quit = "1";




            while ( quit == "1")
            {


                Console.WriteLine("Please enter account number");
                accnum = int.Parse(Console.ReadLine());


                Console.WriteLine("Please enter starting balance");
                startbalance = int.Parse(Console.ReadLine());


                Console.WriteLine("Please enter all charges");
                charges = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter credit added to the account");
                credit = int.Parse(Console.ReadLine());


                Console.WriteLine("Please enter credit limit");
                creditlimit = int.Parse(Console.ReadLine());

                // calculate new balance
                calnewbalance = startbalance + charges - credit;


                if (calnewbalance > creditlimit)
                {
                    Console.WriteLine($"Credit limit exceded! {calnewbalance}");
                }
                else
                {
                    Console.WriteLine($"Your current balance is {calnewbalance}");

                }

                Console.WriteLine("Please enter 1 to quit or 2 to continue");
                quit = Console.ReadLine();
            }


            /*
          while  (quit == "1");
            {
                Console.ReadLine(); 
            }
            */
           
        }
    }
}
