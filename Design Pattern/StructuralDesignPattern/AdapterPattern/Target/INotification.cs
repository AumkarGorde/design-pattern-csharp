using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public interface INotification
    {
        public void SendNotification(string sender, string receiver);
    }
}
