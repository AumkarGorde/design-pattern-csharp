using FactoryPattern;

Console.WriteLine("\n *** PROCESS CHEESE PIZZA ***");
var cheesePizza = PizzaFactory.GetPizza(PizzaType.Cheese);
cheesePizza.Prepare();
cheesePizza.Bake();
cheesePizza.Cut();
cheesePizza.Box();

Console.WriteLine("\n *** PROCESS Pepperoni PIZZA ***");
var pepperoniPizza = PizzaFactory.GetPizza(PizzaType.Pepperoni);
pepperoniPizza.Prepare();
pepperoniPizza.Bake();
pepperoniPizza.Cut();
pepperoniPizza.Box();

Console.WriteLine("\n *** PROCESS FarmHouse PIZZA ***");
var farmHousePizza = PizzaFactory.GetPizza(PizzaType.FarmHouse);
farmHousePizza.Prepare();
farmHousePizza.Bake();
farmHousePizza.Cut();
farmHousePizza.Box();

Console.WriteLine("\n *** PROCESS COMPLETE");

internal enum PizzaType
{
    Cheese,
    Pepperoni,
    FarmHouse
}