using NSubstitute;

namespace Design.DependencyInjection.UnitTests;
public class GreeterTests
{
    private readonly IDateTimeProvider _mockDateTimeProvider;
    public GreeterTests()
    {
        _mockDateTimeProvider = Substitute.For<IDateTimeProvider>();
    }
    [Theory]
    [InlineData(6, "good morning")]  
    [InlineData(11, "good morning")] 
    [InlineData(12, "good afternoon")] 
    [InlineData(15, "good afternoon")] 
    [InlineData(16, "good evening")] 
    [InlineData(23, "good evening")] 
    public void CreateGreetMessage_ReturnsCorrectMessage(int hour, string expectedMessage)
    {
        // Arrange

        var now = new DateTime(2025, 2, 7, hour, 0, 0);
        _mockDateTimeProvider.DateTime.Returns(now);

        var greeter = new Greeter(_mockDateTimeProvider);

        // Act
        var result = greeter.CreateGreetMessage();

        // Assert
        Assert.Equal(expectedMessage, result);
    }
}
