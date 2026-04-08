namespace ConsoleApp2;

public class UserSession : IResettable
{
    public string UserName { get; set; } ="";
    public void Reset() => UserName = "Guest";
}