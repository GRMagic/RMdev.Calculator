namespace RMdev.Calculator.Tests
{
    public class OperationsTest
    {
        [Trait("Operations", "Add")]
        [Theory(DisplayName = "Add")]
        [InlineData("1+0", 1)]
        [InlineData("0+1", 1)]
        [InlineData("0+0", 0)]
        [InlineData("1+2", 3)]
        [InlineData("-2+3", 1)]
        [InlineData("3+-4", -1)]
        [InlineData("10+(-5)", 5)]
        [InlineData("999999999+1", 1_000_000_000)]
        [InlineData("1.2+3.4", 4.6)]
        public void SimpleAddition_Solve_Correctly(string expression, decimal expected)
        {
            // Arrange
            var calc = new Calc();

            // Act
            var result = calc.Solve(expression);

            // Assert
            Assert.Equal(expected, result);
        }

        [Trait("Operations", "Sub")]
        [Theory(DisplayName = "Sub")]
        [InlineData("2-1", 1)]
        [InlineData("1-2", -1)]
        [InlineData("1-(-2)", 3)]
        [InlineData("-2-(-2)", 0)]
        [InlineData("-2-2", -4)]
        [InlineData("0-0", 0)]
        [InlineData("1-0", 1)]
        [InlineData("0-1", -1)]
        [InlineData("-2+3", 1)]
        [InlineData("1000000000-1", 999_999_999)]
        [InlineData("4.3-2.1", 2.2)]
        public void SimpleSubtraction_Solve_Correctly(string expression, decimal expected)
        {
            // Arrange
            var calc = new Calc();

            // Act
            var result = calc.Solve(expression);

            // Assert
            Assert.Equal(expected, result);
        }

        [Trait("Operations", "Mul")]
        [Theory(DisplayName = "Mul")]
        [InlineData("0*0", 0)]
        [InlineData("1*0", 0)]
        [InlineData("0*1", 0)]
        [InlineData("1*2", 2)]
        [InlineData("20*2", 40)]
        [InlineData("1*(-2)", -2)]
        [InlineData("-2*(-2)", 4)]
        [InlineData("-2*2", -4)]
        [InlineData("1.1*1.1", 1.21)]
        [InlineData("2*0.5", 1)]
        public void SimpleMultiplication_Solve_Correctly(string expression, decimal expected)
        {
            // Arrange
            var calc = new Calc();

            // Act
            var result = calc.Solve(expression);

            // Assert
            Assert.Equal(expected, result);
        }

        [Trait("Operations", "Div")]
        [Theory(DisplayName = "Div")]
        [InlineData("0/1", 0)]
        [InlineData("1/2", 0.5)]
        [InlineData("20/2", 10)]
        [InlineData("2/(-1)", -2)]
        [InlineData("-2/(-2)", 1)]
        [InlineData("-2/2", -1)]
        [InlineData("1.1/1.1", 1)]
        [InlineData("2/0.5", 4)]
        public void SimpleDivision_Solve_Correctly(string expression, decimal expected)
        {
            // Arrange
            var calc = new Calc();

            // Act
            var result = calc.Solve(expression);

            // Assert
            Assert.Equal(expected, result);
        }

        [Trait("Operations", "Div")]
        [Fact(DisplayName = "Div/0")]
        public void DivisionByZero_Solve_ThrowsException()
        {
            // Arrange
            var calc = new Calc();
            var expression = Random.Shared.Next() + "/0";

            // Act
            Action act = () => calc.Solve(expression);

            // Assert
            var result = Assert.Throws<DivideByZeroException>(act);
        }

        [Trait("Operations", "Rest")]
        [Theory(DisplayName = "Rest")]
        [InlineData("0%1", 0)]
        [InlineData("1%2", 1)]
        [InlineData("20%2", 0)]
        [InlineData("2%(-1)", 0)]
        [InlineData("-2%(-2)", 0)]
        [InlineData("-2%2", 0)]
        [InlineData("1.1%1.1", 0)]
        [InlineData("2%0.5", 0)]
        public void SimpleRestOfDivision_Solve_Correctly(string expression, decimal expected)
        {
            // Arrange
            var calc = new Calc();

            // Act
            var result = calc.Solve(expression);

            // Assert
            Assert.Equal(expected, result);
        }

        [Trait("Operations", "Pow")]
        [Theory(DisplayName = "Pow")]
        [InlineData("0^1", 0)]
        [InlineData("1^2", 1)]
        [InlineData("20^2", 400)]
        [InlineData("2^(-1)", 0.5)]
        [InlineData("-2^(-2)", 0.25)]
        [InlineData("-2^2", 4)]
        [InlineData("9^0.5", 3)]
        public void SimplePower_Solve_Correctly(string expression, decimal expected)
        {
            // Arrange
            var calc = new Calc();

            // Act
            var result = calc.Solve(expression);

            // Assert
            Assert.Equal(expected, result);
        }

        [Trait("Operations", "Pow")]
        [Fact(DisplayName = "Pow NaN")]
        public void NaNValuePow_Solve_ThrowsException()
        {
            // Arrange
            var calc = new Calc();
            var expression = "-27^(1/2)";

            // Act
            Action act = () => calc.Solve(expression);

            // Assert
            Assert.Throws<ArgumentException>(act);
        }

        [Trait("Operations", "Neg")]
        [Theory(DisplayName = "Neg")]
        [InlineData("-1", -1)]
        [InlineData("-2", -2)]
        [InlineData("-0", 0)]
        [InlineData("-(1)", -1)]
        [InlineData("-(0)", 0)]
        [InlineData("(-3)", -3)]
        public void SimpleNegative_Solve_Correctly(string expression, decimal expected)
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