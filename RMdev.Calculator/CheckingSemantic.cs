using RMdev.Calculator.Compiler;
using RMdev.Calculator.Resources;
using System.Collections.Generic;
using System.Linq;

namespace RMdev.Calculator
{
    class CheckingSemantic : Semantic
    {
        private readonly IEnumerable<string> _variables;
        public CheckingSemantic(IEnumerable<string> variables) => _variables = variables;

        public override void ExecuteAction(int action, Token token)
        {
            if (action == 1 && !_variables.Contains(token.Lexeme))
                throw new SemanticError(string.Format(Messages.UndefinedVariable, token.Lexeme), token.Position);
        }
    }
}
