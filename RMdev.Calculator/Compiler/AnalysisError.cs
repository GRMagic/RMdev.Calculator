namespace RMdev.Calculator.Compiler
{
    public class AnalysisError : System.Exception
    {
        public int Position { get; private set; }

        public AnalysisError(string msg, int position) : base(msg) => Position = position;

        public AnalysisError(string msg) : base(msg) { }

        public override string ToString() => $"{base.ToString()}, @ {Position}";
    }
}