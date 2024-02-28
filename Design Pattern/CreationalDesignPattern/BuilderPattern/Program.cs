using BuilderPattern;

IComputerBuilder gamingComputer = new GamingComputer();
var engineer = new Engineer(gamingComputer);
engineer.AssembleComputer();
Computer computer = engineer.GetComputer();
computer.Display();

Console.ReadLine();