using RMdev.Calculator.Compiler;
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
            if (action == 0 || action == 1)
            {
                if (!_variables.Contains(token.Lexeme))
                {
                    throw new SemanticError($"A variável '{token.Lexeme}' não foi definida.", token.Position);
                }
            }
        }
    }
}
