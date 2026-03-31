namespace ConsoleApp2;

public class UserManager
{
    public Dictionary<string, string> Users { get; } = new();
    public bool SignUp(string email, string password)
    {
        if (Users.ContainsKey(email))
        {
            Console.WriteLine("Error: This E-mail already exists!");
            return false;
        }
        Users.Add(email, password);
        Console.WriteLine($"User {email} registered successfully!");
        return true;
    }

    public bool SignIn(string email, string password)
    {
        if (!Users.ContainsKey(email))
        {
            Console.WriteLine("Error : no such email found!");
            return false;
        }

        if (Users[email] == password)
        {
            Console.WriteLine("Sign in successful! Welcome back!");
            return true;
        }
        else
        {
            Console.WriteLine("Error: incorrect password!");
            return false;
        }
    }
}