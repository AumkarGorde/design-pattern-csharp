
using MediatorPattern;

IAirTrafficControl atc = new AirTrafficControl();

Airplane airplane1 = new Airplane("Flight 1", atc);
Airplane airplane2 = new Airplane("Flight 2", atc);
Airplane airplane3 = new Airplane("Flight 3", atc);

airplane1.SendMessage("Prepare for landing , speaking from flight 1 !!");
airplane2.SendMessage("Prepare for landing , speaking from flight 2 !!");

Console.WriteLine();
/**
 * IChatMediator defines the interface for the mediator, which includes a method for sending messages.
 * ChatMediator is a concrete mediator that keeps track of users and facilitates message exchange between them.
 * User is an abstract class representing users in the chat room. It holds a reference to the mediator and provides methods for sending and receiving messages.
 * ChatUser is a concrete implementation of the User class. It sends messages through the mediator and receives messages from other users via the mediator.
 * **/