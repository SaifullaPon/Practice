using static Application.UserRegistration;

namespace TestProject;

public class UserRegistrationTests
{
    [Test]
    public void TestPasswordStrengthAsNone()
    {
        var password = "   ";

        var actual = GetPasswordStrength(password);

        var expected = PasswordStrength.None;


        Assert.That(actual, Is.EqualTo(expected));
    }


    [Test]
    public void TestPasswordStrengthAsEasy()
    {
        var password = "1234567";

        var actual = GetPasswordStrength(password);

        var expected = PasswordStrength.Easy;


        Assert.That(actual, Is.EqualTo(expected));
    }


    [Test]
    public void TestPasswordStrengthAsMedium()
    {
        var password = "12345678";

        var actual = GetPasswordStrength(password);

        var expected = PasswordStrength.Medium;


        Assert.That(actual, Is.EqualTo(expected));
    }


    [Test]
    public void TestPasswordStrengthAsHard()
    {
        var password = "12345678password";

        var actual = GetPasswordStrength(password);

        var expected = PasswordStrength.Hard;


        Assert.That(actual, Is.EqualTo(expected));
    }


    [Test]
    public void TestPasswordStrengthAsSecure()
    {
        var password = "_12345678password";

        var actual = GetPasswordStrength(password);

        var expected = PasswordStrength.Secure;


        Assert.That(actual, Is.EqualTo(expected));
    }
}
