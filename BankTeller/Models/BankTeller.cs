using System;
using BankTellerApp.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerApp.Models
{
    public class BankTeller : ITellerPlanning
    {
        private double SetInterestRate(string accountType)
        {
            double interestRate = 0;

            switch (accountType)
            {
                case "Savings":
                    interestRate = 2.3;
                    break;
                case "Current":
                    interestRate = 3.5;
                    break;
                case "Domiciliary":
                    interestRate = 5;
                    break;
                case "Corporate":
                    interestRate = 7;
                    break;
                default:
                    interestRate = 0;
                    break;
            }

            return (interestRate / 100);
        }

        public double ConvertMonthsToYear(double duration)
        {
            return Convert.ToDouble(duration / 12);
        }

        private double CalculateVat(double vatRate)
        {
            return (vatRate / 100);
        }

        private double ProcessCompoundInterest(double principal, double interestRate, double time)
        {
            double vat = CalculateVat(7.5);
            return ((principal * Math.Pow((1 + interestRate), time)) - vat);
        }

        public string ShowCummulativeInterest()
        {
            double cummulativeInterest;
            int[] savingDurationsInMonths = { 6, 9, 12, 24, 60 };

            Console.WriteLine("Input your account name: ");
            string accountName = Console.ReadLine();

            Console.WriteLine("Input your account number: ");
            double accountNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Specify account type:\n Options are: Savings, Current, Domiciliary, Corporate");
            string accountType = Console.ReadLine();

            Console.WriteLine("Specify amount to invest: ");
            double principal = Convert.ToDouble(Console.ReadLine());

            double interestRate = SetInterestRate(accountType);

            foreach (double duration in savingDurationsInMonths)
            {
                double time = ConvertMonthsToYear(duration);
                cummulativeInterest = ProcessCompoundInterest(principal, interestRate, time);
                Console.WriteLine($"In {duration} months, you will have N{Math.Round(cummulativeInterest, 2)} interests.");
            }

            return "";
        }
    }
}
