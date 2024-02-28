
using CompositePattern;
using File = CompositePattern.File;

Folder rootFolder = new Folder("root");
rootFolder.AddItem(new File("ran.pdf"));
Folder docFolder = new Folder("documents");
docFolder.AddItem(new File("One.txt"));
docFolder.AddItem(new File("Two.txt"));
rootFolder.AddItem(docFolder);

Folder imageFolder = new Folder("images");
imageFolder.AddItem(new File("One.png"));
imageFolder.AddItem(new File("Two.png"));
rootFolder.AddItem(imageFolder);

rootFolder.Display();

Console.ReadLine();