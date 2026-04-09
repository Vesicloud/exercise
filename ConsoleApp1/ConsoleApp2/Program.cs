using System;
using ConsoleApp2;
using CalculatorApp;
System.Console.WriteLine("System Ready.");
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
string input = Console.ReadLine();
string cleanText = input.Replace(" ", "");
string[] textArray = ["drop", "data", "base"];
bool foundBadWord = false;
foreach (string word in textArray)
{
    if (cleanText.Contains(word))
    {
        foundBadWord = true;
        break;
    }
    
}

if (foundBadWord)
{
    Console.WriteLine("Error 103: unable to process");
    
}
else
{
    Console.WriteLine("proceed successfully!");
}

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

Console.WriteLine("Énter a sentence:");
string sentence = Console.ReadLine();
string[] words = sentence.Split(' ');
int wordsCount = words.Length;
if (wordsCount < 7)
{
    Console.WriteLine("Not a correct sentence.");
}
else
{
    Console.WriteLine("sentence accepted");
}

Console.WriteLine("Enter your name:");
string name =Console.ReadLine();
Console.WriteLine($"Welcome {name}!");
if (name.StartsWith("Lord"))
{
    Console.WriteLine("Welcome Your Exellency");
}

int totalMoney = 0;
int[] moneyAmount = [5506, 291, 500, 482, 963];
foreach (int money in moneyAmount){
    totalMoney += money;
}
Console.WriteLine($"Total money is {totalMoney}");


Console.WriteLine("Enter a sentence:");
string sentence = Console.ReadLine();
string[] word = sentence.Split(' ');
string transformedSentence = "";
for (int i = 0; i < word.Length; i++ )
    
{
    if (i % 2 == 0)
    {
        word[i] = word[i].ToUpper();
        transformedSentence += word[i] + " ";
    }
    else
    {
        word[i] = word[i].ToLower();
        transformedSentence += word[i] + " ";
    }
}
Console.WriteLine(transformedSentence);

Console.WriteLine("Enter Some Text:");
string input = Console.ReadLine();
if (!string.IsNullOrEmpty(input))
{
    string[] words = input.Split(' ');
    foreach (string word in words )
    {
        for (int i = 0; i < word.Length; i++)
        {
            Console.Write(word);
            if (i < word.Length - 1) 
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Write some text:");
string text = Console.ReadLine();
if (!string.IsNullOrEmpty(text))
{   string[] words  = text.Split(' ');
    for (int i = 0; i < words.Length; i++)
    {
        string currentText = words[i];
        if (currentText.Length > 6)
        {
            words[i] = currentText + "(long word)";
        }
    }string result = string.Join(" ", words);
    Console.WriteLine(result);
}






Console.WriteLine("--- HOT BREWS MENU ---");
Console.WriteLine("a. Espresso (1.95)            i. Mocha (250ml: 4.50 / 350ml: 4.00)");
Console.WriteLine("b. Double Espresso (2.85)     j. Latte Macchiato (250ml: 3.50 / 350ml: 3.00)");
Console.WriteLine("c. Espresso Macchiato (2.25)  k. Decaffeinated Espresso (2.50)");
Console.WriteLine("d. Americano (250ml: 2.50 / 350ml: 3.00)");
Console.WriteLine("e. Lungo (2.50)               l. Tea (1.85)");
Console.WriteLine("f. Flat White (250ml: 3.00 / 350ml: 2.50)");
Console.WriteLine("g. Cappuccino (250ml: 2.50 / 350ml: 3.00)");
Console.WriteLine("h. Hot Chocolate (250ml: 3.50 / 350ml: 4.00)");

Console.WriteLine("\nEnter your choice (a-l):");
string choice = Console.ReadLine()?.ToLower() ?? "";

string drinkName = "";
double price250 = 0;
double price350 = 0;

switch (choice)
{
    case "a": drinkName = "Espresso"; price250 = 1.95; break;
    case "b": drinkName = "Double Espresso"; price250 = 2.85; break;
    case "c": drinkName = "Espresso Macchiato"; price250 = 2.25; break;
    case "d": drinkName = "Americano"; price250 = 2.50; price350 = 3.00; break;
    case "e": drinkName = "Lungo"; price250 = 2.50; break;
    case "f": drinkName = "Flat White"; price250 = 3.00; price350 = 2.50; break;
    case "g": drinkName = "Cappuccino"; price250 = 2.50; price350 = 3.00; break;
    case "h": drinkName = "Hot Chocolate"; price250 = 3.50; price350 = 4.00; break;
    case "i": drinkName = "Mocha"; price250 = 4.50; price350 = 4.00; break;
    case "j": drinkName = "Latte Macchiato"; price250 = 3.50; price350 = 3.00; break;
    case "k": drinkName = "Decaffeinated Espresso"; price250 = 2.50; break;
    case "l": drinkName = "Tea"; price250 = 1.85; break;
    default:
        Console.WriteLine("Invalid selection.");
        return;
}


double finalPrice = price250;
string sizeName = "250ml";

if (price350 > 0) 
{
    Console.WriteLine("Choose size: 1) 250ml  2) 350ml");
    if (Console.ReadLine() == "2")
    {
        finalPrice = price350;
        sizeName = "350ml";
    }
}


string extras = "";

Console.WriteLine("Add Syrup? (+1.50) (y/n)");
if (Console.ReadLine()?.ToLower() == "y") { finalPrice += 1.50; extras += ", Additional Syrup Topping"; }

Console.WriteLine("Add Cream? (+1.50) (y/n)");
if (Console.ReadLine()?.ToLower() == "y") { finalPrice += 1.50; extras += ", Additional Cream"; }

Console.WriteLine("Soya/Almond/Lactose-Free Milk? (+1.00) (y/n)");
if (Console.ReadLine()?.ToLower() == "y") { finalPrice += 1.00; extras += ", Special Milk"; }


Console.WriteLine($"\nOrder: {drinkName} {sizeName}{extras}, {finalPrice:F2}");

int credits = 100;
int lives = 3;
Random randomizer = new Random();

Console.WriteLine("--- Welcome to the Dice Gamble! ---");
Console.WriteLine("Rules: Roll 1-2 = Lose life/bet. Roll 3-6 = Win credits!");


while (lives > 0 && credits > 0)
{
    Console.WriteLine($"\nCredits: {credits} | Lives: {lives}");
    int currentBet = 0;
    bool validBet = false;

    
    while (validBet == false)
    {
        Console.WriteLine("Enter your bet (10, 30, 50):");
        string input = Console.ReadLine();

        
        if (input == "10" || input == "30" || input == "50")
        {
            currentBet = int.Parse(input);

           
            if (currentBet > credits)
            {
                Console.WriteLine("You don't have enough credits for that bet!");
            }
            else
            {
                validBet = true;
            }
        }
        else
        {
            Console.WriteLine("Invalid option. Please choose 10, 30, or 50.");
        }
    }


    int roll = randomizer.Next(1, 7);
    Console.WriteLine($"You rolled a: {roll}");

    if (roll == 1 || roll == 2)
    {
        
        lives--;
        credits -= currentBet;
        Console.WriteLine("Bad luck! You lost a life and your bet.");
    }
    else
    {
       
        credits += currentBet;
        Console.WriteLine($"Winner! You gained {currentBet} credits.");
    }
}


Console.WriteLine("\n--- Game Over ---");
if (lives == 0) Console.WriteLine("Reason: You ran out of lives.");
if (credits <= 0) Console.WriteLine("Reason: You ran out of credits.");

Console.WriteLine($"Final Credit Score: {credits}");




CheckPassword();


void CheckPassword()
{
    Console.WriteLine("Enter your password:");
    string password = Console.ReadLine();
    
    bool passwordMatch = password.ToLower() == "pencil";

    if (passwordMatch)
    {
        Console.WriteLine("Success");
    }
    else
    {
        Console.WriteLine("Login failed");
    }
}

using System;


string[][] users = [["john", "plate"], ["michelle", "bike"], ["lisa", "pencil"]];


PerformLogin(users);


void PerformLogin(string[][] userList)
{
    Console.WriteLine("Enter your username:");
    string username = Console.ReadLine();

    Console.WriteLine("Enter your password:");
    string password = Console.ReadLine();

    int userMatch = -1;

    for (int i = 0; i < userList.Length; i++)
    {
        if (userList[i][0].ToLower() == username.ToLower())
        {
            userMatch = i;
        }
    }

    bool passwordMatch = false;

    if (userMatch > -1)
    {
        passwordMatch = password.ToLower() == userList[userMatch][1].ToLower();
    }

    if (passwordMatch)
    {
        Console.WriteLine("Success");
    }
    else
    {
        Console.WriteLine("Login failed");
    }
}

using System;

string[][] users = [["john", "plate"], ["michelle", "bike"], ["lisa", "pencil"]];


string[] inputs = GetUserInput();
bool isAuthorized = ValidateCredentials(inputs[0], inputs[1], users);

if (isAuthorized)
{
    Console.WriteLine("Success");
}
else
{
    Console.WriteLine("Login failed");
}


string[] GetUserInput()
{
    Console.WriteLine("Enter your username:");
    string user = Console.ReadLine();
    Console.WriteLine("Enter your password:");
    string pass = Console.ReadLine();
    return [user, pass];
}

bool ValidateCredentials(string username, string password, string[][] userList)
{
    int userMatch = -1;
    for (int i = 0; i < userList.Length; i++)
    {
        if (userList[i][0] == username.ToLower())
        {
            userMatch = i;
        }
    }

    if (userMatch > -1)
    {
        return password.ToLower() == userList[userMatch][1];
    }
    
    return false;
}

using System;

string[][] users = [["john", "plate"], ["michelle", "bike"], ["lisa", "pencil"]];


string[] inputs = GetUserInput();
bool isAuthorized = ValidateCredentials(inputs[0], inputs[1], users);

if (isAuthorized)
{
    Console.WriteLine("Success");
}
else
{
    Console.WriteLine("Login failed");
}


string[] GetUserInput()
{
    Console.WriteLine("Enter your username:");
    string user = Console.ReadLine();
    Console.WriteLine("Enter your password:");
    string pass = Console.ReadLine();
    return [user, pass];
}

bool ValidateCredentials(string username, string password, string[][] userList)
{
    int userMatch = -1;
    for (int i = 0; i < userList.Length; i++)
    {
        if (userList[i][0].ToLower() == username.ToLower())
        {
            userMatch = i;
        }
    }

    if (userMatch > -1)
    {
        return password.ToLower() == userList[userMatch][1].ToLower();
    }
    
    return false;
}

using System;
string [] someWords = ["Hi", "promise", "Tobias", "everyoneisgood"];
int longest = GetLongestStringLength(someWords);
Console.WriteLine($"The length of the longest string is :{longest}");

int GetLongestStringLength(string[] words)
{
    int maxLength = 0;
    foreach (string word in words)
    {
        if (word.Length > maxLength)
        {
            maxLength = word.Length;
        }
            
    }
    return maxLength;
}

using System;
bool result = IsSumGreater(10,9, 20);
Console.WriteLine($"Is the sum bigger?{result}");

bool IsSumGreater(int first, int second, int third)
{
    int sum = first + second;
    if (sum > third)
    {
        return true;
    }
    else
    {
        return false;
    }
}

using System;

class Program
{
    static void Main()
    {
        
        Employee empA = new Employee(40000m);
        Console.WriteLine($"Employee A Tax 40k salary: {empA.IncomeTax()}");
        Employee empB = new Employee(60000m);
        Console.WriteLine($"Employee B Tax 60k salary: {empB.IncomeTax()}");
        
        // int days = currentEmployee.VacationDays();
    }
}

using System;
using System.Collections.Generic;
List<string> names = new List<string>{"Ali", "Tobias", "Amin", "Jigar"};
names.Sort();
foreach (string name in names)
{
    Console.WriteLine(name);
}

using System;
using System.Collections.Generic;
using ConsoleApp2;


List<Tool> designerTools = new List<Tool>
{
    new Tool { Brand = "Versace", Name = "Golden Hammer" },
    new Tool { Brand = "Gucci", Name = "Leather Tape Measure" },
    new Tool { Brand = "Boss", Name = "Silver Wrench" }
};
designerTools.RemoveAt(1);
foreach (Tool tool in designerTools){
    Console.WriteLine(tool.Brand);
    }
    designerTools.Add(new Tool { Brand = "Dior", Name = "Sauvage" });
    designerTools.Add(new Tool { Brand = "YSL", Name = "Libre" });

    foreach (Tool tool in designerTools)
    {
        if (tool.Name == "Sauvage")
            Console.WriteLine($"The found perfume is :{tool.Brand} {tool.Name}");
    }
    
    //Tool brokenTool = null;
    //Console.WriteLine(brokenTool.Brand);
    //Tool phantomTool = designerTools[50];
    
    int money = 100;
    int people = 0;
    int result = money / people;
    Console.WriteLine(result);
    

using System;
Console.WriteLine("Enter a whole number:");
string input = Console.ReadLine();
try
{
int userNumber = int.Parse(input);
Console.WriteLine($"Success! You entered the number:{userNumber}");
}
catch (Exception ex)
{
    Console.WriteLine("--- An error occured ---");
    Console.WriteLine(ex.Message);
}
Console.WriteLine("The program is still running...");
try
{
    int salary = 100;
    int tax = 0;
    int result = salary / tax;

}
catch (DivideByZeroException ex)
{
    Console.WriteLine("--- Zero Division Error ---");
    Console.WriteLine(ex.Message);
}

    
int[] numbers = {10, 0};

try
{

    Console.WriteLine("Outer Try block started");

    try
    {
        int result = numbers[0] / numbers[1];

    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"0 division Error:{ex.Message
        }");
        throw;

        
    }int absolutNumber = numbers[5];
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine($"0 division Error:{ex.Message}");
}


UserManager manager = new UserManager();
Console.WriteLine("--- Welcome to the System ---");
Console.WriteLine("SIGN UP PHASE");
Console.Write("Enter a new email");
string? email = Console.ReadLine();
Console.Write("Enter a password");
string? password = Console.ReadLine();
manager.SignIn(email?? "", password?? "");
Console.WriteLine("\nSIGN IN PHASE");
Console.Write("Enter your email:");
string? loginEmail = Console.ReadLine();
Console.Write("Enter your password:");
string? loginPassword = Console.ReadLine();
bool success = manager.SignIn(loginEmail?? "", loginPassword?? "");
if (success)
{
    Console.WriteLine("Successfully logged in!");
}
else
{
    Console.WriteLine("Username or password is incorrect.");
}

HangmanGame game = new HangmanGame();
Console.WriteLine("Welcome to Hangman Game!");
while (!game.IsGameOver)
{
    game.ShowStatus();
    Console.Write("Enter a letter or guess the whole word: ");
    string input = Console.ReadLine();
    game.MakeGuess(input);
}

if (game.Won)
{
    game.ShowStatus();
    Console.WriteLine("\nCONGRATULATIONS! You won!");
}
else
{
    Console.WriteLine($" \nGAME OVER! The word was: {game.GetSecretWord()}");
}

Console.WriteLine("Write some text:");
string input = Console.ReadLine();
string cleanText = input.Replace(" ", "");
string[] textArray = ["drop", "data", "base"];
string toLowerCleanText = cleanText.ToLower();
bool foundBadWord = false;
foreach (string word in textArray)
{
    if (toLowerCleanText.Contains(word))
    {
        foundBadWord = true;
        break;
    }
    
}

if (foundBadWord)
{
    Console.WriteLine("Error 103: unable to process");
    
}
else
{
    Console.WriteLine("proceed successfully!");
}


ICalculator calc = new Calculator();
bool keepRunning = true;
while (keepRunning)
{
    Console.WriteLine("\n--- Calculator Menu ---");
    Console.WriteLine("1. Add");
    Console.WriteLine("2. Subtract");
    Console.WriteLine("3. Multiply");
    Console.WriteLine("4. Divide");
   
    Console.WriteLine("5.SquareRoot");
    Console.WriteLine("6.Power");
    Console.WriteLine("7.Exist");
    Console.WriteLine("Select a choice:");
    string choice = Console.ReadLine();
    if (choice == "7") {
        Console.WriteLine("Calculator is closed");
        keepRunning = false; continue;
        
    }
    if (choice == "5")
    {
        Console.WriteLine("enter the a number:");
        double number = double.Parse(Console.ReadLine());
        Console.WriteLine($"Result:{calc.SquareRoot(number)}");
    }
    else if (choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "6")
    {
           
        Console.WriteLine("enter the first number:");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("enter the second number:");
        double secondNumber = double.Parse(Console.ReadLine());
        
        try
        {
            if (choice == "4")
            {
               
            }
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");

        }
        catch (FormatException)
        {
            Console.WriteLine($"Error: Please enter valid numbers.");
        }
        switch (choice)
        {
            case "1": Console.WriteLine($"Result: {calc.Add(firstNumber, secondNumber)}"); break;
            case "2": Console.WriteLine($"Result:{calc.Subtract(firstNumber, secondNumber)}"); break;
            case "3": Console.WriteLine($"Result:{calc.Multiply(firstNumber, secondNumber)}"); break;
            case "4": Console.WriteLine($"Result:{calc.Divide(firstNumber, secondNumber)}"); break;
            case "5": Console.WriteLine($"Result:{calc.Power(firstNumber, secondNumber)}"); break;
        
            default: Console.WriteLine("Invalid choice"); break;
        }
    }


    
}
List<IResettable> thingsToReset = new List<IResettable>();
thingsToReset.Add(new Counter());
thingsToReset.Add(new UserSession());
foreach (IResettable item in thingsToReset)
{
    item.Reset();
}
*/


HandHeld drill = new HandHeld(new DateOnly(2026,5,20), 500.0,2.5);
Console.WriteLine(drill.BookService());
Machine machineDrill = drill;
Console.WriteLine(machineDrill.BookService());
