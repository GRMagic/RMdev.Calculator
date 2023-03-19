namespace RMdev.Calculator.Tests
{
    public class CultureTest
    {
        [Trait("Functions", "Culture")]
        [Theory(DisplayName = "Culture PT")]
        [InlineData("Abs(1)", 1)]
        [InlineData("Media(1)", 1)]
        [InlineData("Arredondar(1)", 1)]
        [InlineData("ArredondarParaCima(1)", 1)]
        [InlineData("ArredondarParaBaixo(1)", 1)]
        [InlineData("Seno(0)", 0)]
        [InlineData("Coseno(0)", 1)]
        [InlineData("Tangente(0)", 0)]
        [InlineData("Min(1)", 1)]
        [InlineData("Max(1)", 1)]
        [InlineData("RaizQuadrada(9)", 3)]
        [InlineData("Soma(1)", 1)]
        [InlineData("Truncar(1)", 1)]
        [InlineData("Raiz(1,2)", 1)]
        public void PortugueseFunctions_Solve_Correctly(string expression, decimal expected)
        {
            // Arrange
            var calc = new Calc(System.Globalization.CultureInfo.CreateSpecificCulture("pt"));

            // Act
            var result = calc.Solve(expression);

            // Assert
            Assert.Equal(expected, result);
        }

    }
}