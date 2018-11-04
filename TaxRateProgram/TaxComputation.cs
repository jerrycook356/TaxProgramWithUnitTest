using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxRateProgram
{
    public class TaxComputation
    {
        
        private double amount;

        public TaxComputation()
        {
            
        }
        public double TaxCompute(int choice, double amount)
        {
            double tax = 0.0 ;
            this.amount = amount;
            switch(choice)
            {
                case 1:
                    {
                         tax = ComputeSingleTax(amount);
                        break;
                    };
                case 2:
                    {
                        tax = ComputeMarriedJointTax(amount);
                        break;
                    };
                case 3:
                    {
                        tax = ComputeMarriedSeperate(amount);
                        break;
                    };
                case 4:
                    {
                        tax = ComputeHeadOfHouse(amount);
                        break;
                    };
                    
            }
            return tax;
        }

        private double ComputeSingleTax(double amount)
        {
            double tax = 0.0;
            if(amount <= 0)
            {
                Console.Out.WriteLine("There is not tax for the amount of "+amount);
            }
          
                if((amount >0)&& (amount <= 9075.00))
                {
                     tax = amount * 0.1;
                }
                else if((amount > 9075.00)&& (amount <= 36900.00))
                {
                tax = ( 907.50) + ((amount - 9075) * 0.15);
                }
                else if((amount > 36900.00)&& (amount <= 89350.00))
                {
                tax = ( 5081.25) + ((amount - 36900) * 0.25);
                }
                else if((amount > 89350.00)&&(amount <= 186350.00))
                {
                    tax = ( 18193.75)+((amount - 89350)*0.28);
                }
                else if((amount > 186350.00)&&(amount <= 405100))
                {
                tax = (45353.75) + ((amount - 186350) * 0.33);
                }
                else if((amount > 405100)&&(amount <= 406750))
                {
                   tax = (117541.25 )+((amount - 405100)*0.35);
                }
           
                else
                {
                tax = (118118.75) + ((amount - 406750) * 0.396);
                }
              
            
            return tax;
        }

        private double ComputeMarriedJointTax(double amount)
        {
            double tax = 0.0;
            if(amount <= 0)
            {
                Console.Out.WriteLine("there is no tax for the amount of " + amount);
            }

            if((amount > 0  )&&(amount <= 18150))
            {
                tax = amount * 0.10;
            }
            else if ((amount >  18150 ) && (amount <= 73800))
            {
                tax = (1815) + ((amount - 18150) * 0.15);
                Console.Out.WriteLine("inside the function  tax = " + tax);
            }
            else if ((amount > 73800  ) && (amount <= 148850))
            {
                tax = (10162.50) + ((amount - 73800) * 0.25);
            }
            else if((amount >148850)&&(amount <= 226850))
            {
                tax = (28925) + ((amount - 148850) * 0.28);
            }
           else if((amount > 226850)&&(amount <= 405100))
            {
                tax = (50765)+((amount - 226850)*0.33);
            }
           else if ((amount > 405100) && (amount <= 457600))
            {
                tax = (109587.50) + ((amount - 405100) * 0.35);
            }
            else
                tax = (127962.50) + ((amount - 457600) * 0.396);
            return tax;
        }
        private double ComputeMarriedSeperate(double amount)
        {
            double tax = 0.0;
            
            if(amount <= 0)
            {
                Console.Out.WriteLine("There is no tax for the amount of " + amount);
            }

            else if((amount > 0)&&(amount <= 9075))
            {
                tax = amount * 0.10;
            }
            else if((amount > 9075)&& (amount <= 36900))
            {
                tax = (907.50) + ((amount - 9075) * 0.15);
            }
            else if ((amount > 36900) && (amount <= 74425))
            {
                tax = (5081.25) + ((amount - 36900) * 0.25);
            }
            else if ((amount > 74425) && (amount <= 113425))
            {
                tax = (14462.50) + ((amount - 74425) * 0.28);
            }
            else if ((amount >113425 ) && (amount <= 202550))
            {
                tax = (25382.50) + ((amount - 113425) * 0.33);
            }
            else if ((amount > 202550) && (amount <= 228800))
            {
                tax = (54793.75) + ((amount - 202550) * 0.35);
            }
            else
            {
                tax = (63981.25) + ((amount - 228800) * 0.396);
            }
                return tax;

        }

        private double ComputeHeadOfHouse(double amount)
        {
            double tax = 0.0;
            if(amount <= 0)
            {
                Console.Out.WriteLine("There is no tax for the amount of " + amount);
            }
            else if ((amount > 0) && (amount <= 12950))
            {
                tax = amount * 0.10;
            }
            else if ((amount > 12950) && (amount <= 49400))
            {
                tax = (1295) + ((amount - 12950) * 0.15);
            }
            else if ((amount > 49400) && (amount <= 127550))
            {
                tax = (6762.50) + ((amount - 49400) * 0.25);
            }
            else if ((amount > 127550) && (amount <= 206600))
            {
                tax = (26300) + ((amount - 127550) * 0.28);
            }
            else if ((amount > 206600) && (amount <= 405100))
            {
                tax = (48434) + ((amount - 206600) * 0.33);
            }
            else if ((amount > 405100) && (amount <= 432200))
            {
                tax = (113939) + ((amount - 405100) * 0.35);
            }
            else 
            {
                tax = (123424) + ((amount - 432200) * 0.396);
            }
            return tax;
        }

    }
}
