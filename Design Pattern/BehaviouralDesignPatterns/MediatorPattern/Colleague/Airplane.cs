using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class Airplane
    {
        private readonly string _name;
        private readonly IAirTrafficControl _atc;

        public Airplane(string name, IAirTrafficControl atc)
        {
            _name = name;
            _atc = atc;
            _atc.RegisterAirplane(this);
        }

        public void SendMessage(string message)
        {
            _atc.SendMessage(this, message);
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"Airplane {_name} received message: {message}");
        }
    }
}
