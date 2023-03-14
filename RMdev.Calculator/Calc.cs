using RMdev.Calculator.Compiler;
using System.Collections.Generic;

namespace RMdev.Calculator
{
    public class Calc : ICalc
    {
        private CalcSemantic _semantic = new CalcSemantic();

        public void Check(string expression, bool checkSemantic = false)
        {
            LexicalCheck(expression);
            SyntaxCheck(expression);
            if (checkSemantic)
                SemanticCheck(expression);
        }

        private void LexicalCheck(string expression)
        {
            var lex = new Lexicon(expression);
            while (lex.NextToken() != null) ;
        }

        private void SyntaxCheck(string expression)
        {
            var lexicon = new Lexicon(expression);
            var syntatic = new Syntactic();
            var semantic = new NopSemantic();
            syntatic.Parse(lexicon, semantic);
        }

        private void SemanticCheck(string expression)
        {
            var lexicon = new Lexicon(expression);
            var syntatic = new Syntactic();
            var semantic = new CheckingSemantic(_semantic.DefinedVariables().Keys);
            syntatic.Parse(lexicon, semantic);
        }

        public List<string> RequiredVariables(string expression) => _semantic.RequiredVariables(expression);

        public void SetVariable(string name, decimal value) => _semantic.SetVariable(name, value);

        public decimal Solve(string expression) => _semantic.Solve(expression);
    }
}
