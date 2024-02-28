using IteratorPattern;

WorkList workList = new WorkList();
workList.AddWork(new Work("Work 1", "Description 1"));
workList.AddWork(new Work("Work 2", "Description 2"));
workList.AddWork(new Work("Work 3", "Description 3"));

IIterator<Work> iterator = workList.GetIterator();

while (iterator.HasNext())
{
    Work work = iterator.Next();
    Console.WriteLine($"Title: {work.Title}, Description: {work.Description}");
}

Console.ReadLine();