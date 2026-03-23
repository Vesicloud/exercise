using System;
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


*/



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
/*
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

    */
