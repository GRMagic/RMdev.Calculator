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

        // TODO: Test Custom Functions

        [Trait("Functions", "Min")]
        [Theory(DisplayName = "Min")]
        [InlineData("Min(0)", 0)]
        [InlineData("Min(1,2)", 1)]
        [InlineData("Min(2,1,2)", 1)]
        [InlineData("Min(-1,0,1)", -1)]
        [InlineData("Min(-1,-2,-3)", -3)]
        [InlineData("Min(-0.5,0.5)", -.5)]
        public void SimpleMin_Solve_Correctly(string expression, decimal expected)
        {
            // Arrange
            var calc = new Calc();

            // Act
            var result = calc.Solve(expression);

            // Assert
            Assert.Equal(expected, result);
        }

        [Trait("Functions", "Max")]
        [Theory(DisplayName = "Max")]
        [InlineData("Max(0)", 0)]
        [InlineData("Max(1,2)", 2)]
        [InlineData("Max(1,2,1)", 2)]
        [InlineData("Max(-1,0,1)", 1)]
        [InlineData("Max(-1,-2,-3)", -1)]
        [InlineData("Max(-0.5,0.5)", .5)]
        public void SimpleMax_Solve_Correctly(string expression, decimal expected)
        {
            // Arrange
            var calc = new Calc();

            // Act
            var result = calc.Solve(expression);

            // Assert
            Assert.Equal(expected, result);
        }

        [Trait("Functions", "Truncate")]
        [Theory(DisplayName = "Truncate")]
        [InlineData("Truncate(0)", 0)]
        [InlineData("Truncate(1.2)", 1)]
        [InlineData("Truncate(1.6)", 1)]
        [InlineData("Truncate(-1.1)", -1)]
        public void SimpleTruncate_Solve_Correctly(string expression, decimal expected)
        {
            // Arrange
            var calc = new Calc();

            // Act
            var result = calc.Solve(expression);

            // Assert
            Assert.Equal(expected, result);
        }

        [Trait("Functions", "Round")]
        [Theory(DisplayName = "Round")]
        [InlineData("Round(0)", 0)]
        [InlineData("Round(1.2)", 1)]
        [InlineData("Round(1.5)", 2)]
        [InlineData("Round(1.6)", 2)]
        [InlineData("Round(-1.1)", -1)]
        [InlineData("Round(-1.8)", -2)]
        public void SimpleRound_Solve_Correctly(string expression, decimal expected)
        {
            // Arrange
            var calc = new Calc();

            // Act
            var result = calc.Solve(expression);

            // Assert
            Assert.Equal(expected, result);
        }

        [Trait("Functions", "Round")]
        [Theory(DisplayName = "Round with two params")]
        [InlineData("Round(0,0)", 0)]
        [InlineData("Round(1.23, 1)", 1.2)]
        [InlineData("Round(1.55, 1)", 1.6)]
        [InlineData("Round(1.678, 2)", 1.68)]
        [InlineData("Round(1.678, 28)", 1.678)]
        [InlineData("Round(1.678, 1.9)", 1.68)]
        [InlineData("Round(-1.1, 0)", -1)]
        public void SimpleRound2Params_Solve_Correctly(string expression, decimal expected)
        {
            // Arrange
            var calc = new Calc();

            // Act
            var result = calc.Solve(expression);

            // Assert
            Assert.Equal(expected, result);
        }

        [Trait("Functions", "Round")]
        [Theory(DisplayName = "Round with decimals params out of range")]
        [InlineData("Round(1.23, -1)")]
        [InlineData("Round(1.55, 29)")]
        public void InvalidParam_Round_ThrowsException(string expression)
        {
            // Arrange
            var calc = new Calc();

            // Act
            Action act = () => calc.Solve(expression);

            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(act);
        }

        [Trait("Functions", "Ceiling")]
        [Theory(DisplayName = "Ceiling")]
        [InlineData("Ceiling(0)", 0)]
        [InlineData("Ceiling(1.2)", 2)]
        [InlineData("Ceiling(1.5)", 2)]
        [InlineData("Ceiling(1.6)", 2)]
        [InlineData("Ceiling(-1.1)", -1)]
        [InlineData("Ceiling(-1.8)", -1)]
        public void SimpleCeiling_Solve_Correctly(string expression, decimal expected)
        {
            // Arrange
            var calc = new Calc();

            // Act
            var result = calc.Solve(expression);

            // Assert
            Assert.Equal(expected, result);
        }

        [Trait("Functions", "Floor")]
        [Theory(DisplayName = "Floor")]
        [InlineData("Floor(0)", 0)]
        [InlineData("Floor(1.2)", 1)]
        [InlineData("Floor(1.5)", 1)]
        [InlineData("Floor(1.6)", 1)]
        [InlineData("Floor(-1.1)", -2)]
        [InlineData("Floor(-1.8)", -2)]
        public void SimpleFloor_Solve_Correctly(string expression, decimal expected)
        {
            // Arrange
            var calc = new Calc();

            // Act
            var result = calc.Solve(expression);

            // Assert
            Assert.Equal(expected, result);
        }

        [Trait("Functions", "Sin")]
        [Theory(DisplayName = "Sin")]
        [InlineData("Sin(0)", 0)]
        [InlineData("Sin(30)", 0.5)]
        [InlineData("Sin(90)", 1)]
        [InlineData("Sin(180)", 0)]
        [InlineData("Sin(270)", -1)]
        [InlineData("Sin(360)", 0)]
        public void SimpleSin_Solve_Correctly(string expression, decimal expected)
        {
            // Arrange
            var calc = new Calc();

            // Act
            var result = calc.Solve(expression);

            // Assert
            Assert.Equal(expected, result, 13);
        }

        [Trait("Functions", "Cos")]
        [Theory(DisplayName = "Cos")]
        [InlineData("Cos(0)", 1)]
        [InlineData("Cos(60)", 0.5)]
        [InlineData("Cos(90)", 0)]
        [InlineData("Cos(180)", -1)]
        [InlineData("Cos(270)", 0)]
        [InlineData("Cos(360)", 1)]
        public void SimpleCos_Solve_Correctly(string expression, decimal expected)
        {
            // Arrange
            var calc = new Calc();

            // Act
            var result = calc.Solve(expression);

            // Assert
            Assert.Equal(expected, result, 13);
        }

        [Trait("Functions", "Tan")]
        [Theory(DisplayName = "Tan")]
        [InlineData("Tan(0)", 0)]
        [InlineData("Tan(45)", 1)]
        public void SimpleTan_Solve_Correctly(string expression, decimal expected)
        {
            // Arrange
            var calc = new Calc();

            // Act
            var result = calc.Solve(expression);

            // Assert
            Assert.Equal(expected, result, 13);
        }

    }
}