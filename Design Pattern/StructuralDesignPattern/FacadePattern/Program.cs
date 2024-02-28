using FacadePattern;

DvdPlayer dvdPlayer = new DvdPlayer();
Amplifier amplifier = new Amplifier();
Projector projector = new Projector();

HomeTheaterFacade homeTheater = new HomeTheaterFacade(dvdPlayer, amplifier, projector);

homeTheater.WatchMovie("Interstellar");
Console.WriteLine();
homeTheater.EndMovie();