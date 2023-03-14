using RMdev.Calculator.Compiler;

namespace RMdev.Calculator.Tests
{
    public class VariablesTest
    {
        [Trait("Variables", "Single")]
        [Fact(DisplayName = "Single Variable")]
        public void SingleVariable_Solve_Correctly()
        {
            // Arrange
            var calc = new Calc();
            var valueA = Convert.ToDecimal(Random.Shared.NextDouble());
            calc.SetVariable("a", valueA);
            var expression = "a";

            // Act
            var result = calc.Solve(expression);

            // Assert
            Assert.Equal(valueA, result);
        }

        [Trait("Variables", "Multiple")]
        [Fact(DisplayName = "Multiple Variables")]
        public void MultipleVariable_Solve_Correctly()
        {
            // Arrange
            var calc = new Calc();
            var valueA = Convert.ToDecimal(Random.Shared.NextDouble());
            var valueB = Convert.ToDecimal(Random.Shared.NextDouble());
            calc.SetVariable("a", valueA);
            calc.SetVariable("b", valueB);
            var expression = "a+b";

            // Act
            var result = calc.Solve(expression);

            // Assert
            Assert.Equal(valueA+valueB, result);
        }

        [Trait("Variables", "Not Defined")]
        [Fact(DisplayName = "Variable not defined")]
        public void NotDefinedVariable_Solve_ThrowsException()
        {
            // Arrange
            var calc = new Calc();
            var variableName = "a";
            var expression = $"1 + {variableName} * 2";

            // Act
            Action act = () => calc.Solve(expression);

            // Assert
            var exeption = Assert.Throws<SemanticError>(act);
            Assert.Equal(expression.IndexOf(variableName), exeption.Position);
        }

        [Trait("Variables", "Names")]
        [Theory(DisplayName = "Variable not defined")]
        [InlineData("_")]
        [InlineData("A")]
        [InlineData("a")]
        [InlineData("$")]
        [InlineData("asd")]
        [InlineData("ASD")]
        [InlineData("As")]
        [InlineData("aS")]
        [InlineData("_As1")]
        [InlineData("$1")]
        public void ValidNameVariable_Solve_Correctly(string variableName)
        {
            // Arrange
            var calc = new Calc();
            var expression = variableName;
            var value = Convert.ToDecimal(Random.Shared.NextDouble());
            calc.SetVariable(variableName, value);

            // Act
            var result = calc.Solve(expression);

            // Assert
            Assert.Equal(value, result);
        }
    }
}