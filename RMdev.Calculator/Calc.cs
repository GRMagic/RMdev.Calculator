using RMdev.Calculator.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace RMdev.Calculator
{
    public class Calc : ICalc
    {
        private readonly CalcSemantic _semantic;
        private readonly CultureInfo _cultureInfo;

        /// <summary>
        /// Names and Custom Functions.
        /// </summary>
        public readonly Dictionary<string, CustomFunction> CustomFunctions = new Dictionary<string, CustomFunction>();

        Dictionary<string, CustomFunction> ICalc.CustomFunctions => CustomFunctions;

        /// <summary>
        /// Instance of a new Calculator.
        /// </summary>
        /// <param name="cultureInfo">Culture for function names</param>
        public Calc(CultureInfo cultureInfo = null)
        {
            _semantic = new CalcSemantic(cultureInfo, CustomFunctions);
            _cultureInfo = cultureInfo;
        }

        /// <summary>
        /// Validate expression lexically, syntactically and semantically.
        /// </summary>
        /// <param name="expression">Expression to check</param>
        /// <param name="checkSemantic">Check semantic too?</param>
        public void Check(string expression, bool checkSemantic = false)
        {
            LexicalCheck(expression);
            SyntaxCheck(expression);
            if (checkSemantic)
                SemanticCheck(expression);
        }

        private void LexicalCheck(string expression)
        {
            var lex = new Lexicon(expression, _cultureInfo, CustomFunctions.Keys);
            while (lex.NextToken() != null) ;
        }

        private void SyntaxCheck(string expression)
        {
            var lexicon = new Lexicon(expression, _cultureInfo, CustomFunctions.Keys);
            var syntatic = new Syntactic();
            var semantic = new NopSemantic();
            syntatic.Parse(lexicon, semantic);
        }

        private void SemanticCheck(string expression)
        {
            var lexicon = new Lexicon(expression, _cultureInfo, CustomFunctions.Keys);
            var syntatic = new Syntactic();
            var semantic = new CheckingSemantic(_semantic.DefinedVariables().Keys);
            syntatic.Parse(lexicon, semantic);
        }

        /// <summary>
        /// List all variables required to evaluate an expression.
        /// </summary>
        /// <param name="expression">Expression to see</param>
        /// <returns>List of variables</returns>
        public IEnumerable<string> RequiredVariables(string expression) => _semantic.RequiredVariables(expression);

        /// <summary>
        /// Set a variable to use in expressions.
        /// </summary>
        /// <param name="name">Name of variable (case-sensitive)</param>
        /// <param name="value">Value of variable</param>
        public void SetVariable(string name, decimal value) => _semantic.SetVariable(name, value);

        /// <summary>
        /// Solve an expression.
        /// </summary>
        /// <param name="expression">Expression to solve</param>
        /// <returns>The expression result</returns>
        public decimal Solve(string expression) => _semantic.Solve(expression);

        /// <summary>
        /// Get the last result.
        /// </summary>
        /// <returns>The last result</returns>
        public decimal Result() => _semantic.Result();
    }

    public delegate decimal CustomFunction(decimal[] parameters);
}
