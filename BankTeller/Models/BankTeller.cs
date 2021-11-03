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
            uint[] savingDurations = { 6, 9, 12, 24, 60 };

            Console.WriteLine("Input your account name: ");
            string accountName = Console.ReadLine();

            Console.WriteLine("Input your account number: ");
            int accountNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Specify your account type: ");
            string accountType = Console.ReadLine();

            Console.WriteLine("Input an amount: ");
            int principal = int.Parse(Console.ReadLine());

            switch (accountType)
            {
                case "Saving":
                    interestRate = 1.2F;
                    break;
                case "Current":
                    interestRate = 3.9F;
                    break;
                case "Domiciliary":
                    interestRate = 3.9F;
                    break;
                case "Corporate":
                    interestRate = 3.9F;
                    break;
                default:
                    interestRate = 5.5F;
                    break;
            }

            vat = principal * (7.5 / 100);
            foreach (var duration in savingDurations)
            {
                cummulativeInterest = principal * (1 + (interestRate / duration));
                response = $"In {duration} months, you will have {cummulativeInterest} interests.";
                Console.WriteLine(response);
            }

            return "";
        }
    }
}
