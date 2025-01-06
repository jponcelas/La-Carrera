using carrera2_0;

namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void TestCalcularDistancia()
    {
        // Arrange
        int[,] corredors = {
            { 1, 4, 3, 5, 4 },
            { 2, 8, 2, 5, 7 },
            { 3, 7, 4, 6, 2 },
            { 4, 4, 3, 1, 3 },
        };
        int[] expected = { 2, 6, 5, 3 };
        var pr = new corredor();
        // Act
        var result = pr.CalcularDistancia(corredors);

        // Assert
        Assert.Equal(expected, result);
    }
}