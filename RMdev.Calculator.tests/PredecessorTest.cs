namespace RMdev.Calculator.Tests
{
    public class PredecessorTest
    {

        [Trait("Calc", "Predecessor")]
        [Theory(DisplayName = "Solve expression with operator predecessor")]
        [InlineData("2+3*4", 14)]
        [InlineData("2+(3*4)", 14)]
        [InlineData("(2+3)*4", 20)]
        [InlineData("2*3+4", 10)]
        [InlineData("2*3+4/2-1", 7)]
        [InlineData("2*(2+2)/2", 4)]
        [InlineData("1+2*(2+2)/2", 5)]
        [InlineData("1+2*(2+2)/2-10", -5)]
        [InlineData("3+3-4*9%4", 6)]
        [InlineData("4*10%4", 0)]
        [InlineData("4*(10%4)", 8)]
        [InlineData("(8+8)/2/2/2", 2)]
        [InlineData("256-(2^10-512)/2", 0)]
        [InlineData("100%80%8", 4)]
        [InlineData("(2+2)/((2+2)/((2+2)/((2+2)/2)))", 2)]
        [InlineData("((4/2)+(4/2))/2", 2)]
        [InlineData("7+7*7^Media(2+3,7,3^2)", 5_764_808)]
        [InlineData("((4+6)*2-8)/((5%2)+1)^2+7*(3-2*(9/(1+2)))", -18)]
        [InlineData("Abs(Soma((5*3+6^2)/Raiz((1+2)*3)*Media(1/4,7/4))-((100)-2*Abs(-4+5)+1))", 82)]
        public void ExpressionWithMultipleOperators_Solve_Corectly(string expression, decimal expected)
        {
            // Arrange
            var calc = new Calc();

            // Act
            var result = calc.Solve(expression);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}