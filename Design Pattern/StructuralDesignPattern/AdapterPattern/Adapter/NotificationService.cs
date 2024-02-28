using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class NotificationService : INotification
    {
        EmailNotification _emailNotification;
        public NotificationService(EmailNotification emailNotification)
        {
            _emailNotification = emailNotification;
        }

        public void SendNotification(string sender, string receiver)
        {
            _emailNotification.SendEmail(sender, receiver); 
        }
    }
}
