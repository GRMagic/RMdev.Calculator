using System.Collections.Generic;
using static RMdev.Calculator.Compiler.Constants;
namespace RMdev.Calculator.Compiler
{
    abstract class Semantic
    {
        public abstract void ExecuteAction(int action, Token token);
        //{
        //    System.Console.WriteLine($"Ação #{action}, Token: {token}")
        //}

    }

}