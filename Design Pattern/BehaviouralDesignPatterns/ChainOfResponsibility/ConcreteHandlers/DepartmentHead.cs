using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class DepartmentHead : Approver
    {
        public override void ProcessRequest(string purpose, double amount)
        {
            if (amount > 1000 && amount <= 5000)
            {
                Console.WriteLine("Purchase approved by Department Head");
            }
            else if (_nextApprover != null)
            {
                _nextApprover.ProcessRequest(purpose, amount);
            }
            else
            {
                Console.WriteLine("Purchase cannot be approved.");
            }
        }
    }
}
