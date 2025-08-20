var names = new List<string>{"Ali",  "Abubakr", "Yusuf", "Ismoil", "Muhammad" };

names.RemoveAt(1);
foreach (var name in names)
{
    Console.WriteLine(name);
}