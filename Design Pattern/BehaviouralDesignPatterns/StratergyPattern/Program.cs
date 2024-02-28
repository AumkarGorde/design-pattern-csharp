
using StratergyPattern;

Console.WriteLine();

SortService sortService = new SortService(new BubbleSort());
sortService.Add("abc");
sortService.Add("abc");
sortService.Add("abc");
sortService.Sort();

SortService sortService1 = new SortService(new MergeSort());
sortService1.Add("abc");
sortService1.Add("abc");
sortService1.Add("abc");
sortService1.Sort();

Console.ReadLine();