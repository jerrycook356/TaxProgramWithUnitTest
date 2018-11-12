// ================================================================
// Jerry Cook
// 11/11/2018
//
//Application to compute the tax to be paid
//based on tax bracket selected and amount entered.
//===================================================================


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxRateProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            bool runAgain;
            bool invalid ; //true if not a double
            double amount;
            double tax ;

            TaxComputation taxComputation = new TaxComputation();

            do
            {
                amount = 0.0;
                tax = 0.0;
                runAgain = true;
                invalid = true;

                MenuDisplay menu = new MenuDisplay();
                int choice = menu.DisplayMenu();
                if (choice == 5)
                {
                    runAgain = false;
                }
                else
                {
                   
                    do
                    {
                        Console.Out.Write("Enter amount to compute the tax of : ");
                        try
                        {
                            amount = double.Parse(Console.ReadLine());
                            invalid = false;

                        }
                        catch (System.FormatException)
                        {
                            Console.Out.WriteLine("\n\n\nInvalid input try again");
                            invalid = true;
                        }
                       

                    } while (invalid);

                    tax = taxComputation.TaxCompute(choice, amount);

                    //  negative one is returned from taxcomputation.TaxCompute 
                    // because amount entered was negative. 

                    if (tax == -1)
                    {
                        Console.Out.WriteLine("No tax could be computed on number entered please try again.");
                        runAgain = true;
                    }
                    else

                    {

                        string taxString = tax.ToString("f2"); //format return to two decimal places

                        Console.Out.WriteLine("The tax you will owe on the amount of $" + amount + " is $ " +
                            "" + taxString + "\n\n");
                    }
                }
               
            } while (runAgain);


            Console.Out.WriteLine("Press any Key to exit");
            Console.Read();
        }

       
    }
}
