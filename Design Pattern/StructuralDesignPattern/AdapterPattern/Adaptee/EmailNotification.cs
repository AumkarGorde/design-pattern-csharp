using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class EmailNotification 
    {
        public void SendEmail(string sender, string receiver)
        {
            Console.WriteLine($"The notification is sent via Email to {receiver} fom {sender}");
        }
    }
}
