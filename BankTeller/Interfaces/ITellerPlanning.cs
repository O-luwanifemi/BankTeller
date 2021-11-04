using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerApp.Interfaces
{
    public interface ITellerPlanning
    {
        public double ConvertMonthsToYear(double duration);

        public string ShowCummulativeInterest();
    }
}