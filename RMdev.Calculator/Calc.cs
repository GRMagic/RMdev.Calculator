using RMdev.Calculator.Compiler;
using System.Collections.Generic;
using System.Globalization;

namespace RMdev.Calculator
{
    public class Calc : ICalc
    {
        private readonly CalcSemantic _semantic;
        private readonly CultureInfo _cultureInfo;

        public Calc(CultureInfo cultureInfo = null)
        {
            _semantic = new CalcSemantic(cultureInfo);
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
            var lex = new Lexicon(expression, _cultureInfo);
            while (lex.NextToken() != null) ;
        }

        private void SyntaxCheck(string expression)
        {
            var lexicon = new Lexicon(expression, _cultureInfo);
            var syntatic = new Syntactic();
            var semantic = new NopSemantic();
            syntatic.Parse(lexicon, semantic);
        }

        private void SemanticCheck(string expression)
        {
            var lexicon = new Lexicon(expression, _cultureInfo);
            var syntatic = new Syntactic();
            var semantic = new CheckingSemantic(_semantic.DefinedVariables().Keys);
            syntatic.Parse(lexicon, semantic);
        }

        public IEnumerable<string> RequiredVariables(string expression) => _semantic.RequiredVariables(expression);

        public void SetVariable(string name, decimal value) => _semantic.SetVariable(name, value);

        public decimal Solve(string expression) => _semantic.Solve(expression);
    }
}
