using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxRateProgram
{
    class MenuDisplay
    {
        public MenuDisplay()
        {

        }

        public  int DisplayMenu()
        {
            bool again = true;
            int choice = 0;
            do
            {
                Console.WriteLine("\n\n\n");
                Console.WriteLine("Welcome to the tax information program");
                Console.WriteLine("\n\nPress the number corresponding to the menu choice you need");
                Console.WriteLine("1.) press for filing single");
                Console.WriteLine("2.) press for filing married-filing jointly or qualifying widow(er)");
                Console.WriteLine("3.) press for filing marred-filing serperately");
                Console.WriteLine("4.) press for filing head of household");
                Console.WriteLine("5.) press to quit");
                try
                {
                    Console.Out.Write("Choice: ");
                    choice = int.Parse(Console.ReadLine());
                    if ((choice > 5) || (choice < 1))
                    {
                        throw new System.FormatException();
                    }
                    again = false;
                }
                catch (System.FormatException )
                {
                    Console.WriteLine("Invalid choice please try again\n\n\n");
                    again = true;
                }


            } while (again == true);
            return choice;
        }
    }
}
