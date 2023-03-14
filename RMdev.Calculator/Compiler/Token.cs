namespace RMdev.Calculator.Compiler
{
    sealed class Token
    {
        public int Id { get; private set; }
        public string Lexeme { get; private set; }
        public int Position { get; private set; }

        public Token(int id, string lexeme, int position)
        {
            Id = id;
            Lexeme = lexeme;
            Position = position;
        }

        public override string ToString() => $"{Id} ( {Lexeme} ) @ {Position}";

    }
}