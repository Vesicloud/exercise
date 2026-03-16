/*
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
Console.WriteLine("Do you have glutten intolerance?");
string choice = Console.ReadLine();
if (choice.ToLower() == "yes") {
    Console.WriteLine("You will be served gluttenfree food");
 }else if (choice.ToLower() == "no") {
    Console.WriteLine("The regular menu will apply");
 }else Console.WriteLine("Unable to decide reference");





Console.WriteLine("Write some text:");
string text = Console.ReadLine();
string[] textArray = ["drop", "data", "base"];
foreach (string word in textArray)
{
    if (text.Contains(word))
    {
        Console.WriteLine("Error 103: unable to process");
    }
} 
*/
Console.WriteLine("Enter an email address:");
string email = Console.ReadLine();
string[] emailArray = email.Split(".");
if (email.Length < 10)
{
    Console.WriteLine("Invalid email address");
}

else if ((!emailArray.EndsWith(".se")) && emailArray.EndsWith(".com")){
    Console.WriteLine("accepted email address must end with .se or .com");
}

Console.WriteLine(" Enter a password:");

string password = Console.ReadLine();
bool passwordCheck = password.Length < 7;

if (passwordCheck)
{
    Console.WriteLine("The password must be at least 7 characters or longer");
}


else{
    Console.WriteLine("An account has been created successfully");
}