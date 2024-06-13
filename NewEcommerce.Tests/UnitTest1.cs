using Xunit.Sdk;

namespace NewEcommerce.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // Arrange
        var item = true;

        // Act
        var expected = item;

        // Assert
        Assert.True(expected);
    }
}