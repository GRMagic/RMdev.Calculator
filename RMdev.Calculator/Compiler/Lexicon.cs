using RMdev.Calculator.Resources;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using static RMdev.Calculator.Compiler.Constants;
using static RMdev.Calculator.Compiler.ParserConstants;
using static RMdev.Calculator.Compiler.ScannerConstants;

namespace RMdev.Calculator.Compiler
{
    sealed class Lexicon
    {
        private readonly Dictionary<string, int> _specialCases;

        private int _position = 0;
        
        private string _input;
        public string Input 
        {
            get => _input;
            set 
            { 
                _input = value; 
                _position = 0;
            }
        }

        public Lexicon(string input, CultureInfo cultureInfo)
        {
            Input = input;
            _specialCases = SpecialCases(cultureInfo);
        }

        private char NextChar()
        {
            if (HasInput())
                return Input[_position++];
            else
                return char.MaxValue;
        }

        private char PeekNextChar()

        {
            return Input[_position];
        }

        private bool HasInput()
        {
            return _position < Input.Length;
        }


        public Token NextToken()
        {
            if (!HasInput())
                return null;

            int start = _position;

            int state = 0;
            int lastState = 0;
            int endState = -1;
            string lexeme = "";

            while (HasInput())
            {
                lastState = state;
                state = NextState(PeekNextChar(), state);

                if (state < 0)
                    break;

                else
                {
                    lexeme += NextChar();
                    if (TokenForState(state) >= 0)
                    {
                        endState = state;
                    }
                }
            }
            if (endState < 0 || (endState != state && TokenForState(lastState) == -2))
                throw new LexicalError(SCANNER_ERROR[lastState], start);


            int token = TokenForState(endState);

            if (token == 0)
                return NextToken();
            else
            {
                token = LookupToken(token, lexeme);
                return new Token(token, lexeme, start);
            }
        }

        private int NextState(char c, int state)
        {
            int next = SCANNER_TABLE[state][c];
            return next;
        }

        private int TokenForState(int state)
        {
            if (state < 0 || state >= TOKEN_STATE.Length)
                return -1;

            return TOKEN_STATE[state];
        }

        public int LookupToken(int @base, string key)
        {
            if (_specialCases.TryGetValue(key, out var value)) return value;
            return @base;
        }

    }

}