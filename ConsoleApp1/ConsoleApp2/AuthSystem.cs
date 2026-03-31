using System.Reflection.Metadata;

namespace ConsoleApp2;

public class AuthSystem
{
    public Dictionary<string, string> Users = new Dictionary<string, string>();

    public void SignUp(string email, string password)
    {
        if (Users.ContainsKey(email))
        {
            Console.WriteLine("This email already exists, Sign up failed.");
        }
        else
        {
            Users.Add(email, password);
            Console.WriteLine("Sign up completed.");
        }
    }
    public void SignIn(string email, string password)
    {
        if (!Users.ContainsKey(email))
        {
            Console.WriteLine("Error: No user with this email exists.");
        }
        else if (Users[email] == password)
        {
            Console.WriteLine("Signing in was successful.");
        }
        else
        {
            Console.WriteLine("Signing in was not successful.");
        }
    }
}
