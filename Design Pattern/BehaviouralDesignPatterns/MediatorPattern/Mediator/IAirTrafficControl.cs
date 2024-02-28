using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public interface IAirTrafficControl
    {
        void RegisterAirplane(Airplane airplane);
        void SendMessage(Airplane sender, string message);
    }
}
