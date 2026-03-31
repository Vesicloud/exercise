using Xunit;
using ConsoleApp2;

namespace ConsoleApp2Unit.Tests;

public class UserTests
{
    [Fact]
    public void SignUpShouldWork()
    {
        var manager = new UserManager();
        bool result = manager.SignUp("test@example.com", "password123");
        Assert.True(result);
        Assert.True(manager.Users.ContainsKey("test@example.com"));
        
    }
    [Fact]
    public void SignUpShouldNotWork()
    {
        var manager = new UserManager();
        manager.SignUp("duplicate@me.com", "firstPass");
        bool result = manager.SignUp("duplicate@me.com", "secondPass");
        Assert.False(result);
        Assert.Single(manager.Users);
    }

    [Fact]
    public void SignIn_WithCorrectCredentials()
    {
        var manager = new UserManager();
        manager.SignUp("user@test.com", "Secret123");
        bool result = manager.SignIn("user@test.com", "Secret123");
        Assert.True(result);
    }
    [Fact]
    public void SignInWrongPassword_ShouldReturnFalse()
    {
        var manager = new UserManager();
        manager.SignUp("user@test.com", "secret123");
        bool result = manager.SignIn("user@test.com", "wrongPassword");
        Assert.False(result);
    }
    [Fact]
    public void SignIn_WithNonExistentEmail_ShouldReturnFalse()
    {
        var manager = new UserManager();
        bool result = manager.SignIn("ghost@test.com", "anyPassword");
        Assert.False(result);
    }

    [Fact]
    public void SignUp_ShouldIncreaseDictionaryCount()
    {
        var auth = new AuthSystem();
        auth.SignUp("layla@saab.com", "secret123");
        Assert.Equal(1, auth.Users.Count);
        Assert.Equal("secret123", auth.Users["layla@saab.com"]);
    }
}