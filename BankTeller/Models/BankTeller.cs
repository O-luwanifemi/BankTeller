using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerApp.Models
{
    public class BankTeller
    {
        public string ShowCummulativeInterest()
        {
            string output;
            double cummulativeInterest;
            uint[] savingDurationsInMonths = { 6, 9, 12, 24, 60 };
            uint[] savingDurationsInYears = { 0.5, 0.75, 1, 2, 5 };

            Console.WriteLine("Input your account name: ");
            string accountName = Console.ReadLine();

            Console.WriteLine("Input your account number: ");
            int accountNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Specify your account type: ");
            string accountType = Console.ReadLine();

            Console.WriteLine("Input an amount: ");
            double principal = Convert.ToDouble(Console.ReadLine());

            float interestRate = SetInterestRate(accountType);

            const double vat = CalculateVat(7.5, principal);

            foreach (var duration in savingDurationsInYears)
            {
                cummulativeInterest = (principal * Math.Pow(1 + interestRate, duration)) - vat;
                output = $"In {duration} months, you will have {cummulativeInterest} interests.";
                Console.WriteLine(output);
            }

            return "";
        }

        private float SetInterestRate(string accountType)
        {
            float interestRate = 0F;

            switch (accountType)
            {
                case "Saving":
                    interestRate = 2F / 100;
                    break;
                case "Current":
                    interestRate = 3.5F / 100;
                    break;
                case "Domiciliary":
                    interestRate = 5F / 100;
                    break;
                case "Corporate":
                    interestRate = 7F / 100;
                    break;
                default:
                    interestRate = 0;
                    break;
            }

            return interestRate;
        }

        private double CalculateVat(double vatRate, double principal)
        {
            return (principal * (vatRate / 100));
        }
    }
}
