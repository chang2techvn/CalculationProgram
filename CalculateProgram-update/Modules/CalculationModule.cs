using System;

namespace CalculateProgram.Modules
{
    public static class CalculationModule
    {
        public static (double Price, double TotalBill) CalculateBill(string customerType, int consumption, int numberOfPeople)
        {
            double price = 0;
            double envProtectionFee = 0;
            double consumPerPeople = consumption / numberOfPeople;

            if (customerType == "Household customer")
            {
                if (consumPerPeople > 0 && consumPerPeople <= 10)
                {
                    price = 5973;
                    envProtectionFee = 597.3;
                }
                else if (consumPerPeople <= 20)
                {
                    price = 7052;
                    envProtectionFee = 705.2;
                }
                else if (consumPerPeople <= 30)
                {
                    price = 8699;
                    envProtectionFee = 866.9;
                }
                else
                {
                    price = 15929;
                    envProtectionFee = 1592.9;
                }
            }
            else if (customerType == "Administrative agency, public service")
            {
                price = 9955;
                envProtectionFee = 995.5;
            }
            else if (customerType == "Production units")
            {
                price = 11615;
                envProtectionFee = 1161.5;
            }
            else if (customerType == "Business services")
            {
                price = 22068;
                envProtectionFee = 2206.8;
            }

            double totalBill = (consumption * price) + envProtectionFee;
            totalBill += totalBill * 0.10;
            totalBill = Math.Round(totalBill, 2);

            return (price, totalBill);
        }
    }
}
