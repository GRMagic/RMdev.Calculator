using RMdev.Calculator.Compiler;

namespace RMdev.Calculator
{
    class NopSemantic : Semantic
    {
        public override void ExecuteAction(int action, Token token) { }
    }
}
