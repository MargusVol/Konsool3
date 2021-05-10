using System;

namespace Payroll
{
    public class Program
    {


        static void Main(string[] args)
        {


            Console.WriteLine("Enter your montly salary: ");
            double brutoIncome = Convert.ToDouble(Console.ReadLine());

            if (brutoIncome <= 1200 && brutoIncome >= 500)
            {
                RangeFrom500to1200(brutoIncome);
            }
            if (brutoIncome <= 2100 && brutoIncome >= 1201)
            {
                RangeFrom1201to2100(brutoIncome);
            }
            while (brutoIncome >= 2101)
            {
                RangeFrom2101andup(brutoIncome);
                break;
            }


        }
        static void RangeFrom500to1200(double brutoIncome)
        {

            double pensionFond = brutoIncome * 0.02;
            double unemploymentFund = brutoIncome * 0.016;
            double Tax = (brutoIncome - 500 - pensionFond - unemploymentFund) * 0.2;
            double Final1 = brutoIncome - pensionFond - unemploymentFund - Tax;
            Console.WriteLine("Your Neto is: " + Final1);
            return;

        }
        static void RangeFrom1201to2100(double brutoIncome)
        {
            

            double pensionFond = brutoIncome * 0.02;
            double unemploymentFund = brutoIncome * 0.016;
            double TaxFreeInc = 500 - 0.55556 * (brutoIncome - 1200);
            double Tax = (brutoIncome - TaxFreeInc - pensionFond - unemploymentFund) * 0.2;
            double Final2 = brutoIncome - Tax - pensionFond - unemploymentFund;


            Console.WriteLine("Your Neto is: " + Final2);

            return;
        }
        static void RangeFrom2101andup(double brutoIncome)
        {
            double pensionFond = brutoIncome * 0.02;
            double unemploymentFund = brutoIncome * 0.016;
            double Tax = (brutoIncome - pensionFond - unemploymentFund) * 0.2;
            double Final3 = brutoIncome - Tax - pensionFond - unemploymentFund;
            Console.WriteLine("Your Neto is: " + Final3);
            return;
        }
    }
}
