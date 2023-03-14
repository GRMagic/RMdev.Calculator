using System.Collections;
using static RMdev.Calculator.Compiler.Constants;
using static RMdev.Calculator.Compiler.ParserConstants;

namespace RMdev.Calculator.Compiler
{
    sealed class Syntactic
    {
        private readonly Stack _stack = new Stack();
        private Token _currentToken;
        private Token _previousToken;
        private Lexicon _scanner;
        private Semantic _semanticAnalyser;

        public void Parse(Lexicon scanner, Semantic semanticAnalyser)
        {
            _scanner = scanner;
            _semanticAnalyser = semanticAnalyser;

            _stack.Clear();
            _stack.Push(0);

            _currentToken = scanner.NextToken();

            while (!Step()) ;
        }

        private bool Step()
        {
            if (_currentToken == null)
            {
                int pos = 0;
                if (_previousToken != null)
                    pos = _previousToken.Position + _previousToken.Lexeme.Length;

                _currentToken = new Token(DOLLAR, "$", pos);
            }

            int token = _currentToken.Id;
            int state = (int)_stack.Peek();

            int[] cmd = PARSER_TABLE[state][token - 1];

            switch (cmd[0])
            {
                case SHIFT:
                    _stack.Push(cmd[1]);
                    _previousToken = _currentToken;
                    _currentToken = _scanner.NextToken();
                    return false;

                case REDUCE:
                    int[] prod = PRODUCTIONS[cmd[1]];

                    for (int i = 0; i < prod[1]; i++)
                        _stack.Pop();

                    int oldState = (int)_stack.Peek();
                    _stack.Push(PARSER_TABLE[oldState][prod[0] - 1][1]);
                    return false;

                case ACTION:
                    int action = FIRST_SEMANTIC_ACTION + cmd[1] - 1;
                    _stack.Push(PARSER_TABLE[state][action][1]);
                    _semanticAnalyser.ExecuteAction(cmd[1], _previousToken);
                    return false;

                case ACCEPT:
                    return true;

                case ERROR:
                    throw new SyntaticError($"O lexema '{_currentToken.Lexeme}' não era esperado aqui.", _currentToken.Position);
            }
            return false;
        }

    }

}