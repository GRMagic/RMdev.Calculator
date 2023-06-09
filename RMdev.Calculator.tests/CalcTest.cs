﻿using RMdev.Calculator.Compiler;

namespace RMdev.Calculator.Tests
{
    public class CalcTest
    {
        [Trait("Calc", "Comment")]
        [Theory(DisplayName = "Ignore cases")]
        [InlineData("2 //inline comment", 2)]
        [InlineData("2 // + 5", 2)]
        [InlineData("1 + 1 /* \n block comment here */ ", 2)]
        [InlineData("1 + 1 /* +5 */ ", 2)]
        [InlineData("1 + \t \r \n 1 ", 2)]
        [InlineData("/* block comment here */ 1 + 1", 2)]
        [InlineData("1 /* block comment here */ + 1", 2)]
        [InlineData("1 + /* block comment here */ 1", 2)]
        [InlineData("1 + 1 /* block comment here */ ", 2)]
        public void CommentedExpression_Check_Successful(string expression, decimal expected)
        {
            // Arrange
            var calc = new Calc();

            // Act
            var resut = calc.Solve(expression);

            // Assert
            Assert.Equal(expected, resut);
        }

        [Trait("Calc", "Check")]
        [Theory(DisplayName = "Check Lexical and Syntax")]
        [InlineData("0")]
        [InlineData("a")]
        [InlineData("1+a")]
        [InlineData("1+a*2")]
        [InlineData("1+a*2/3")]
        [InlineData("1+a*2/3^4")]
        [InlineData("1+a*2/3^4-Sum(1%1)")]
        [InlineData("Sum(1%1)/Avg(1,2,3)")]
        [InlineData("-Sum(1^1)/Sqrt(9)")]
        [InlineData("-Root(27,3)")]
        [InlineData("1+(2)*(3/4)")]
        [InlineData("-(3/4)")]
        [InlineData("(((((1)))))")]
        [InlineData("(((((1)+2)-3)))")]
        public void CorrectExpression_Check_Successful(string expression)
        {
            // Arrange
            var calc = new Calc();

            // Act and Assert
            calc.Check(expression);
        }

        [Trait("Calc", "Check")]
        [Theory(DisplayName = "Check Lexical, Syntax and Semantic")]
        [InlineData("0", null)]
        [InlineData("1+-2", null)]
        [InlineData("1--2", null)]
        [InlineData("a", new[] { "a" })]
        [InlineData("1+a", new[] { "a" })]
        [InlineData("a+b", new[] { "b", "a" })]
        [InlineData("1+a*b/3", new[] { "a", "b", "$" })]
        public void CorrectExpression_CheckSemantic_Successful(string expression, string[] variables)
        {
            // Arrange
            var calc = new Calc();
            foreach (var v in variables ?? new string[] { })
                calc.SetVariable(v, 0);

            // Act and Assert
            calc.Check(expression, true);
        }

        [Trait("Calc", "Check")]
        [Theory(DisplayName = "Check Lexical, Syntax and Semantic")]
        [InlineData("a", new[] { "a" })]
        [InlineData("a+b", new[] { "a", "b" })]
        [InlineData("1+(a*2)+b-c", new[] { "a", "b", "c" })]
        [InlineData("a+b^2*Avg(c,1,5)", new[] { "a", "b", "c" })]
        public void CorrectExpression_RequiredVariables_Successful(string expression, string[] expected)
        {
            // Arrange
            var calc = new Calc();

            // Act
            var variables = calc.RequiredVariables(expression);

            // Assert
            Assert.Equal(expected, variables);
        }

        [Trait("Calc", "Solve")]
        [Theory(DisplayName = "Solve expression with syntax error")]
        [InlineData("")]
        [InlineData("123A")]
        [InlineData("Soma+(1)")]
        [InlineData("2+(1))")]
        [InlineData("2+((1)")]
        [InlineData("+")]
        [InlineData("2+")]
        [InlineData("2+*2")]
        [InlineData("2++2")]
        [InlineData("()")]
        public void ExpressionWithSyntaxError_Solve_ThrowsExceptino(string expression)
        {
            // Arrange
            var calc = new Calc(System.Globalization.CultureInfo.CreateSpecificCulture("pt-BR"));

            // Act
            Action act = () => calc.Solve(expression);

            // Assert
            Assert.Throws<SyntaticError>(act);
        }

        [Trait("Calc", "Solve")]
        [Fact(DisplayName = "Solve the easiest expression many times per second")]
        public void ExpressionPerSecond_Solve_Fast()
        {
            // Arrange
            var calc = new Calc();
            var expression = "1";
            var count = 0;
            var seconds = 3;
            var timeLimit = TimeSpan.FromSeconds(seconds);

            // Act
            var start = DateTime.UtcNow;
            while (DateTime.UtcNow - start < timeLimit)
            {
                calc.Solve(expression);
                count++;
            }

            // Assert
            Assert.True(count / seconds > 10_000);
        }

        [Trait("Calc", "Result")]
        [Fact(DisplayName = "Get last expression result")]
        public void EvaluatedExpression_Result_LastResult()
        {
            // Arrange
            var calc = new Calc();
            var expected = calc.Solve("1+1");

            // Act
            var result = calc.Result();

            // Assert
            Assert.Equal(expected, result);
        }

        [Trait("Calc", "Result")]
        [Fact(DisplayName = "Get result without previous solve")]
        public void NotEvaluatedExpression_Result_ThrowsException()
        {
            // Arrange
            var calc = new Calc();

            // Act
            Action act = () => calc.Result();

            // Assert
            Assert.Throws<Exception>(act);
        }
    }
}
