using RMdev.Calculator.Compiler;
using System.Collections.Generic;
using System.Globalization;

namespace RMdev.Calculator
{
    public class Calc : ICalc
    {
        private readonly CalcSemantic _semantic;
        private readonly CultureInfo _cultureInfo;

        public readonly Dictionary<string, CustomFunction> CustomFunctions = new Dictionary<string, CustomFunction>();

        Dictionary<string, CustomFunction> ICalc.CustomFunctions => CustomFunctions;

        public Calc(CultureInfo cultureInfo = null)
        {
            _semantic = new CalcSemantic(cultureInfo, CustomFunctions);
            _cultureInfo = cultureInfo;
        }

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

        public IEnumerable<string> RequiredVariables(string expression) => _semantic.RequiredVariables(expression);

        public void SetVariable(string name, decimal value) => _semantic.SetVariable(name, value);

        public decimal Solve(string expression) => _semantic.Solve(expression);
    }

    public delegate decimal CustomFunction(decimal[] parameters);
}
