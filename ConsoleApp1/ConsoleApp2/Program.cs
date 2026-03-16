// 1
Console.WriteLine("Enter a instrument:");
string instrument = Console.ReadLine();
Console.WriteLine($"Can you play {instrument}?");
// 2 

Console.WriteLine("Enter your family name:");
string familyName = Console.ReadLine();
Console.WriteLine("Enter your name:");
string name = Console.ReadLine();

Console.WriteLine($"{familyName} {name} has joined the firm");

//3
Console.WriteLine("Enter your fullname:");
string fullname = Console.ReadLine();
string[] fullnamesplit = fullname.Split(' ');

Console.WriteLine($"{fullnamesplit[0].ToUpper()}  {fullnamesplit[1].ToLower()} : present");
// hello world