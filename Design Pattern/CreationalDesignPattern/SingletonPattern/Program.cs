using SingletonPattern;

Singleton instance = Singleton.GetInstance();
instance.Show();
instance.Show();
instance.Show();
Console.WriteLine("***SHOULD GET SAME INSTANCE***");
Singleton instance2 = Singleton.GetInstance();
instance2.Show();
instance2.Show();
instance2.Show();
Console.ReadLine();