using PrototypePattern;

Address address = new Address("Mumbai", "India");

Circle c1 = new Circle(5,address);
c1.Draw();

var c1Cloned = c1.Clone() as Circle;
c1Cloned.Draw();
c1Cloned.SetRadius(2);
c1Cloned.Address.City = "Hyderabad";
c1Cloned.Draw();
c1.Draw(); // if you see here it is printing hyderabad , because it is shallow clone
           // to avoid this if wanted use deep clone where entire new object is return in clone method
Console.ReadLine();