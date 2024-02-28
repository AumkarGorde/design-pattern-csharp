using AdapterPattern;

var email = new EmailNotification();
NotificationService nfService = new NotificationService(email);
nfService.SendNotification("ABC@ok.com", "XYZ@ok.com");


Console.ReadLine();