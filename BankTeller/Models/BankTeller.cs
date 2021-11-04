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
            double vat;
            string response;
            float interestRate;
            double cummulativeInterest;
            // uint[] savingDurations = { 6, 9, 12, 24, 60 };
            uint[] savingDurations = { 0.5, 0.75, 1, 2, 5 };

            Console.WriteLine("Input your account name: ");
            string accountName = Console.ReadLine();

            Console.WriteLine("Input your account number: ");
            int accountNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Specify your account type: ");
            string accountType = Console.ReadLine();

            Console.WriteLine("Input an amount: ");
            double principal = Convert.ToDouble(Console.ReadLine());

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
                    interestRate = 1F / 100;
                    break;
            }

            vat = principal * (7.5 / 100);
            foreach (var duration in savingDurations)
            {
                cummulativeInterest = (principal * Math.Pow(1 + interestRate, duration)) - vat;
                response = $"In {duration} months, you will have {cummulativeInterest} interests.";
                Console.WriteLine(response);
            }

            return "";
        }
    }
}
