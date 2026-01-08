namespace TestOvn;

public class StringmanupilationTest
{
    [Fact]
    public void ReverseString()
    {
        // Arrange
        var stringmanupilation = new Stringmanupilation();
        var input = "hello";
        var expected = "olleh";

        // Act
        var result = stringmanupilation.ReverseString(input);

        // Assert
        Assert.Equal(expected, result);

    }
}
