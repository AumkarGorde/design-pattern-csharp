using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class AirTrafficControl : IAirTrafficControl
    {
        private List<Airplane> _airplanes = new List<Airplane>();

        public void RegisterAirplane(Airplane airplane)
        {
            _airplanes.Add(airplane);
        }

        public void SendMessage(Airplane sender, string message)
        {
            foreach (var airplane in _airplanes)
            {
                if (airplane != sender) // Don't send message to sender
                {
                    airplane.ReceiveMessage(message);
                }
            }
        }
    }
}
