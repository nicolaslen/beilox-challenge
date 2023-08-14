namespace Tests;

public class MecanismShould
{
    [Fact]
    public void NotAllowInputWithSpecialChars()
    {
        var mecanism = new Mecanism.Library();

        var invalidInput = "invalidInput123$";

        Assert.Throws<Exception>(() => mecanism.Encrypt(invalidInput));
    }

    [Fact]
    public void AllowInputWithNoSpecialChars()
    {
        var mecanism = new Mecanism.Library();

        var validInput = "validInput123";
        var exception = Record.Exception(() => mecanism.Encrypt(validInput));

        Assert.Null(exception);
    }
}
