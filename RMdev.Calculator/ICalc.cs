using System.Collections.Generic;

namespace RMdev.Calculator
{
    public interface ICalc
    {
        void Check(string expression, bool checkSemantic = false);
        decimal Solve(string expression);
        List<string> RequiredVariables(string expression);
        void SetVariable(string name, decimal value);
    }
}
