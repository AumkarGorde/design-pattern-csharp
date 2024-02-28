using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class FinanceDepartment : Approver
    {
        public override void ProcessRequest(string purpose, double amount)
        {
            if (amount > 5000)
            {
                Console.WriteLine("Purchase approved by Finance Department");
            }
            else if (amount > 10000)
            {
                Console.WriteLine("Purchase cannot be approved.");
            }
        }
    }
}
