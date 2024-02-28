using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class Circle : ICloneableShape
    {
        private int _radius;
        public Address Address;
        public Circle(int radius, Address address)
        {
            _radius = radius;
            Address = address;

        }

        public ICloneableShape Clone()
        {
            //shallow clone
            //return this.MemberwiseClone() as ICloneableShape;
            
            //deep clone
            var add = new Address(Address.City, Address.Country);
            return new Circle(_radius, add);
        }

        public void SetRadius(int radius)
        {
            _radius = radius;
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing circle with radius : {_radius} -> {Address.Country} : {Address.City}");
        }
    }

    public class Address
    {
        public string City;
        public string Country;

        public Address(string city, string country)
        {
            City = city;
            Country = country;
        }
    }
}
