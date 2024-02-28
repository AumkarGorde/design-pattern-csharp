using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class Supervisor : Approver
    {
        public override void ProcessRequest(string purpose, double amount)
        {
            if(amount < 1000)
            {
                Console.WriteLine("Purchase approved by Supervisor");
            }
            else if(_nextApprover != null)
            {
                _nextApprover.ProcessRequest(purpose,amount);
            }
            else
            {
                Console.WriteLine("Purchase cannot be approved.");
            }
        }
    }
}
