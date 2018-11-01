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
            bool invalid ;
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
                    Console.Out.Write("Enter amount to compute the tax of : ");
                    do
                    {
                        try
                        {
                            amount = double.Parse(Console.ReadLine());
                            invalid = false;
                            
                        }
                        catch(System.FormatException )
                        {
                            Console.Out.WriteLine("\n\n\nInvalid input try again");
                            invalid = true;
                        }
                        

                    } while (invalid);

                    tax = taxComputation.TaxCompute(choice, amount);
                    Console.Out.WriteLine("The tax you will owe on the amount of $" + amount + " is $" + tax+"\n\n");
                }
               
            } while (runAgain);
            Console.Out.WriteLine("Press any Key to exit");
            Console.Read();
        }

       
    }
}
