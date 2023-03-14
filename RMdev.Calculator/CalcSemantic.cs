using RMdev.Calculator.Compiler;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RMdev.Calculator
{
    class CalcSemantic : Semantic
    {
        private Stack<decimal> _stack = new Stack<decimal>();

        private Stack<int> _params = new Stack<int>();

        private Dictionary<string, decimal> _variables = new Dictionary<string, decimal>();

        private readonly decimal PI = Convert.ToDecimal(Math.PI);
        private readonly decimal E = Convert.ToDecimal(Math.E);
        private readonly string[] _reserved = new[] { nameof(PI), nameof(E) };

        public CalcSemantic()
        {
            _variables[nameof(PI)] = PI;
            _variables[nameof(E)] = E;
        }

        public decimal Solve(string expression)
        {
            _params.Clear();
            _stack.Clear();

            var scanner = new Lexicon(expression);
            var syntatic = new Syntactic();
            syntatic.Parse(scanner, this);
            return _stack.Peek();
        }

        public void SetVariable(string name, decimal value)
        {
            if (_reserved.Contains(name))
                throw new ArgumentException($"A palavra '{name}' é uma palavra reservada.");
            _variables[name] = value;
        }

        public List<string> RequiredVariables(string expression)
        {
            Lexicon lexicon = new Lexicon(expression);
            var variables = new List<string>();

            var token = lexicon.NextToken();
            while (token != null)
            {
                if (token.Id == Constants.t_ID && !_reserved.Contains(token.Lexeme))
                {
                    variables.Add(token.Lexeme);
                }
                token = lexicon.NextToken();
            }

            return variables;
        }

        public IReadOnlyDictionary<string, decimal> DefinedVariables()
        {
            return _variables;
        }

        public override void ExecuteAction(int action, Token token)
        {
            switch (action)
            {
                case 0:
                    Const(token);
                    break;
                case 1:
                    Variable(token);
                    break;
                case 3:
                    StartParamScope();
                    break;
                case 4:
                    NewParameter();
                    break;
                case 10:
                    Add();
                    break;
                case 11:
                    Sub();
                    break;
                case 12:
                    Div();
                    break;
                case 13:
                    Mul();
                    break;
                case 14:
                    Rest();
                    break;
                case 15:
                    Pow();
                    break;
                case 16:
                    Neg();
                    break;
                case 17:
                    Root();
                    break;
                case 18:
                    Sqrt();
                    break;
                case 19:
                    Abs();
                    break;
                case 20:
                    Media();
                    break;
                case 21:
                    Sum();
                    break;
            }
        }

        private void Const(Token token)
        {
            _stack.Push(decimal.Parse(token.Lexeme, System.Globalization.CultureInfo.InvariantCulture));
        }

        private void Variable(Token token)
        {
            if (!_variables.ContainsKey(token.Lexeme))
                throw new SemanticError($"A variável '{token.Lexeme}' não foi definida.", token.Position);

            _stack.Push(_variables[token.Lexeme]);
        }

        public void StartParamScope()
        {
            _params.Push(0);
        }

        public void NewParameter()
        {
            _params.Push(_params.Pop() + 1);
        }

        private void Add()
        {
            var b = _stack.Pop();
            var a = _stack.Pop();
            _stack.Push(a + b);
        }

        private void Sub()
        {
            var b = _stack.Pop();
            var a = _stack.Pop();
            _stack.Push(a - b);
        }

        private void Mul()
        {
            var b = _stack.Pop();
            var a = _stack.Pop();
            _stack.Push(a * b);
        }

        private void Div()
        {
            var b = _stack.Pop();
            var a = _stack.Pop();
            _stack.Push(a / b);
        }

        private void Rest()
        {
            var b = _stack.Pop();
            var a = _stack.Pop();
            _stack.Push(a % b);
        }

        private void Pow()
        {
            var b = Convert.ToDouble(_stack.Pop());
            var a = Convert.ToDouble(_stack.Pop());
            var result = Math.Pow(a, b);
            if (double.IsNaN(result))
                throw new ArgumentException($"Não existe {a} elevado a {b}.");
            _stack.Push(Convert.ToDecimal(result));
        }

        public void Neg()
        {
            var a = _stack.Pop();
            _stack.Push(-a);
        }

        public void Root()
        {
            var b = Convert.ToDouble(_stack.Pop());
            var a = Convert.ToDouble(_stack.Pop());
            var result = Math.Pow(a, 1d / b);
            if (double.IsNaN(result))
                throw new ArgumentException($"Não existe raiz {b} de {a}.");
            _stack.Push(Convert.ToDecimal(result));
        }

        public void Sqrt()
        {
            var a = Convert.ToDouble(_stack.Pop());
            var result = Math.Sqrt(a);
            if (double.IsNaN(result))
                throw new ArgumentException($"Não existe raiz quadrada de {a}.");

            _stack.Push(Convert.ToDecimal(result));
        }

        public void Abs()
        {
            var a = _stack.Pop();
            _stack.Push(Math.Abs(a));
        }

        public void Media()
        {
            decimal count = _params.Pop();
            decimal total = 0;
            for (int i = 0; i < count; i++)
            {
                total += _stack.Pop();
            }
            var media = total / count;
            _stack.Push(media);
        }

        public void Sum()
        {
            decimal count = _params.Pop();
            decimal total = 0;
            for (int i = 0; i < count; i++)
            {
                total += _stack.Pop();
            }
            _stack.Push(total);
        }

        public decimal Result() => _stack.Peek();

    }
}
