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

        //an array holding the table for the filing single rates
        private double[,] filingSingleArray = new double[7, 4] {{0,9075,0.10,0},{9075,36900,0.15,907.50},
        { 36900,89350,0.25,5081.25 },{89350,186350,0.28,18193.75 },{186350,405100,0.33,45353.75 },
            {405100,406750,0.35,117541.25 },{406750,double.MaxValue,0.396,118118.75 } };

        //an array holding the table for the  married filing joint rates
        private double[,] marriedFilingJointArray = new double[7, 4] { { 0, 18150, 0.10, 0 }, { 18150, 73800, 0.15, 1815.00 }, { 73800,148850,0.25,10162.50},
        {148850,226850,0.28,28925 },{226850,405100,0.33,50765},{405100,457600,0.35,109587.50},{457600,double.MaxValue,0.396,127962.50}};

        //an array holding the table for the married filing seperately rates
        private double[,] marriedFilingSeperateArray = new double[7, 4] { { 0,9075,0.10,0},{ 9075, 36900, 0.15, 907.50 },{ 36900, 74425, 0.25, 5081.25 },
        {74425,113425,0.28,14462.5 },{113425,202550,0.33,25382.50 },{202550,228800,0.35,54793.75 },{228800,double.MaxValue,0.396,63981.25 } };

        //an array holding the table for filing the head of household
        private double[,] headOfHouseArray = new double[7, 4] { { 0, 12950, 0.10, 0 }, { 12950, 49400, 0.15, 1295 }, { 49400,127550,0.25,6762.50},
        {127550,206600,0.28,26300 },{206600,405100,0.33,48434},{405100,432200,0.35,113939},{432200,double.MaxValue,0.396,123424}};


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
                         tax = ComputeTax(amount,filingSingleArray);
                        break;
                    };
                case 2:
                    {
                        tax = ComputeTax(amount,marriedFilingJointArray);
                        break;
                    };
                case 3:
                    {
                        tax = ComputeTax(amount,marriedFilingSeperateArray);
                        break;
                    };
                case 4:
                    {
                        tax = ComputeTax(amount,headOfHouseArray);
                        break;
                    };
                    
            }
            return tax;
        }

        private double ComputeTax(double amount,double[,] anArray)
        {
            double tax = 0.0;
          
            for (int index = 0; index < anArray.Length; index++)
            {
                if ((amount >= anArray[index, 0]) && (amount < anArray[index, 1])&&(index < 7))
                {

                    tax = anArray[index, 3] + ((amount - anArray[index, 0]) * anArray[index, 2]);
                    return tax;
                }
            }
            return tax;
            
        }

        

    }
}
