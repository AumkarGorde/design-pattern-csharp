using ProxyPattern;

IImage image = new ImageProxy("sample.jpg",true);
image.Display();
image.Display();

Console.ReadLine();