namespace RMdev.Calculator.Tests
{
    public class FunctionsTest
    {
        [Trait("Functions", "Root")]
        [Theory(DisplayName = "Root")]
        [InlineData("Root(4,2)", 2)]
        [InlineData("Root(8,3)", 2)]
        [InlineData("Root(27,3)", 3)]
        [InlineData("Root(8,-3)", 0.5)]
        public void SimpleRoot_Solve_Correctly(string expression, decimal expected)
        {
            // Arrange
            var calc = new Calc();

            // Act
            var result = calc.Solve(expression);

            // Assert
            Assert.Equal(expected, result);
        }

        [Trait("Functions", "Root")]
        [Fact(DisplayName = "Root NaN")]
        public void NaNValueRoot_Solve_ThrowsException()
        {
            // Arrange
            var calc = new Calc();
            var expression = "Root(-9,2)";

            // Act
            Action act = () => calc.Solve(expression);

            // Assert
            Assert.Throws<ArgumentException>(act);
        }

        [Trait("Functions", "Sqrt")]
        [Theory(DisplayName = "Sqrt")]
        [InlineData("Sqrt(9)", 3)]
        public void SimpleSqrt_Solve_Correctly(string expression, decimal expected)
        {
            // Arrange
            var calc = new Calc();

            // Act
            var result = calc.Solve(expression);

            // Assert
            Assert.Equal(expected, result);
        }

        [Trait("Functions", "Sqrt")]
        [Fact(DisplayName = "Sqrt NaN")]
        public void NaNValueSqrt_Solve_ThrowsException()
        {
            // Arrange
            var calc = new Calc();
            var expression = "Sqrt(-9)";

            // Act
            Action act = () => calc.Solve(expression);

            // Assert
            Assert.Throws<ArgumentException>(act);
        }

        [Trait("Functions", "Abs")]
        [Theory(DisplayName = "Abs")]
        [InlineData("Abs(0)", 0)]
        [InlineData("Abs(1)", 1)]
        [InlineData("Abs(-1)", 1)]
        public void SimpleAbs_Solve_Correctly(string expression, decimal expected)
        {
            // Arrange
            var calc = new Calc();

            // Act
            var result = calc.Solve(expression);

            // Assert
            Assert.Equal(expected, result);
        }

        [Trait("Functions", "Media")]
        [Theory(DisplayName = "Media")]
        [InlineData("Avg(0)", 0)]
        [InlineData("Avg(1,2)", 1.5)]
        [InlineData("Avg(0,1,2)", 1)]
        [InlineData("Avg(-1,0,1)", 0)]
        [InlineData("Avg(-1,-2,-3)", -2)]
        [InlineData("Avg(-0.5,0.5)", 0)]
        public void SimpleMedia_Solve_Correctly(string expression, decimal expected)
        {
            // Arrange
            var calc = new Calc();

            // Act
            var result = calc.Solve(expression);

            // Assert
            Assert.Equal(expected, result);
        }

        [Trait("Functions", "Sum")]
        [Theory(DisplayName = "Sum")]
        [InlineData("Sum(0)", 0)]
        [InlineData("Sum(1,2)", 3)]
        [InlineData("Sum(0,1,2)", 3)]
        [InlineData("Sum(-1,0,1)", 0)]
        [InlineData("Sum(-1,-2,-3)", -6)]
        [InlineData("Sum(-0.5,0.5)", 0)]
        public void SimpleSum_Solve_Correctly(string expression, decimal expected)
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