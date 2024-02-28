using OopsPlayGround;

Console.WriteLine("\nPoint 1 starts..");
Child child = new Child();
Console.WriteLine("\n");
Child child2 = new Child();
// Point 1
//Dog dog = new Animal(); 

//Point 2 ---> Both this cases the parent constructor is first triggerd
Console.WriteLine("\nPoint 2 starts..");
Animal animal = new Animal();
Console.WriteLine("\n");
Dog dog = new Dog();
Console.WriteLine("\n");
Animal adog = new Dog();
Console.WriteLine("\n");

//dog.DogSpecificMethod();
//adog.DogSpecificMethod();

string a = "a";
var t =a.Length;


animal.Sound();
dog.Sound(); 
adog.Sound(); // implement shadowing by default // i.e child class method is not invoked

Console.WriteLine("\nPoint 3 starts..");
//Point 3 ----> 
animal.Run();
dog.Run(); 
adog.Run();  // implement shadowing purposefully by using new keyword // i.e child class method not invoked

//Point 4 ----> Virtual and override are used in compination
Console.WriteLine("\nPoint 4 starts..");
animal.Stop();
dog.Stop();
adog.Stop();

//Point 5
Console.WriteLine("\nPoint 5 starts..");
animal.Sleep();
dog.Sleep();
adog.Sleep();

Console.ReadLine();

var t = new Ostrich();
t.Fly();

/* Points to Remember
   ------------------
    1. You cannot create an object of child class by initiating parent class, but vice-versa is possible.
    2. If child and parent has same method with same name, and no special keywords are used then the type of variable 
        declared at left side of equal to sign that type method is triggerd.
    3. New keyword -> behavour is same as that of without the new key word
    4. Virtual/Override -> only change for Animal adog = new Dog(); dog method is called as it is overriden 
    5. if override keyword not used in child class parent class method is called, use ovveride or specify you do not
        want by using new keyword
 */