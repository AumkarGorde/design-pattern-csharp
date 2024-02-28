using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class PizzaFactory
    {
        internal static Pizza GetPizza(PizzaType pizza)
        {
            Dictionary<string, Pizza> factoryMap = new Dictionary<string, Pizza>
            {
                { "cheese", new CheesePizza() },
                { "pepperoni", new PepperoniPizza() },
                { "farmhouse", new FarmHousePizza() }
            };

            if (factoryMap.ContainsKey(pizza.ToString().ToLower()))
            {
                return factoryMap[pizza.ToString().ToLower()];
            }
            else
            {
                return null;
            }
        }
    }
}
