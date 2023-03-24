using System.Collections.Generic;

namespace RMdev.Calculator
{
    public interface ICalc
    {
        /// <summary>
        /// Validate expression lexically, syntactically and semantically.
        /// </summary>
        /// <param name="expression">Expression to check</param>
        /// <param name="checkSemantic">Check semantic too?</param>
        void Check(string expression, bool checkSemantic = false);

        /// <summary>
        /// Solve an expression.
        /// </summary>
        /// <param name="expression">Expression to solve</param>
        /// <returns>The expression result</returns>
        decimal Solve(string expression);

        /// <summary>
        /// List all variables required to evaluate an expression.
        /// </summary>
        /// <param name="expression">Expression to see</param>
        /// <returns>List of variables</returns>
        IEnumerable<string> RequiredVariables(string expression);

        /// <summary>
        /// Set a variable to use in expressions.
        /// </summary>
        /// <param name="name">Name of variable (case-sensitive)</param>
        /// <param name="value">Value of variable</param>
        void SetVariable(string name, decimal value);

        /// <summary>
        /// Names and Custom Functions.
        /// </summary>
        Dictionary<string, CustomFunction> CustomFunctions { get; }
    }
}
