using AbstractFactoryPattern;

Console.WriteLine("\n Showing dell Laptops");
ILaptopFactory dellFactory = new DellFactory();
var dellClient = new Client(dellFactory);
Console.WriteLine("\nShowing dell gaming Laptops");
dellClient.ShowGamingLaptop();
Console.WriteLine("\nShowing dell business Laptops");
dellClient.ShowBusinessLaptop();

Console.WriteLine("\n Showing HP Laptops");
ILaptopFactory hpFactory = new HPFactory();
var hpClient = new Client(hpFactory);
Console.WriteLine("\nShowing hp gaming Laptops");
hpClient.ShowGamingLaptop();
Console.WriteLine("\nShowing hp business Laptops");
hpClient.ShowBusinessLaptop();

Console.ReadLine();





public class Client
{
    private readonly ILaptopFactory _laptopFactory;
    public Client(ILaptopFactory laptopFactory)
    {
        _laptopFactory = laptopFactory;
    }

    public void ShowBusinessLaptop()
    {
        var bus = _laptopFactory.CreateBusinessLaptop();
        bus.LaptopProcessor();
        bus.UseExcel();
    }

    public void ShowGamingLaptop()
    {
        var game = _laptopFactory.CreateGamingLaptop();
        game.LaptopBattery();
        game.PlayGame();
    }
}