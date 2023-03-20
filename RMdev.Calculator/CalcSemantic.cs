using RMdev.Calculator.Compiler;
using RMdev.Calculator.Resources;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using static RMdev.Calculator.CalcSemantic;

namespace RMdev.Calculator
{
    class CalcSemantic : Semantic
    {
        private Stack<decimal> _stack = new Stack<decimal>();
        private Stack<int> _params = new Stack<int>();
        private Stack<string> _stackCustomFunctions = new Stack<string>();
        
        private Dictionary<string, decimal> _variables = new Dictionary<string, decimal>();
        private readonly Dictionary<string, CustomFunction> _customFunctions = new Dictionary<string, CustomFunction>();

        private readonly decimal PI = Convert.ToDecimal(Math.PI);
        private readonly decimal E = Convert.ToDecimal(Math.E);
        private readonly string[] _reserved;
        private readonly CultureInfo _cultureInfo;

        public CalcSemantic(CultureInfo cultureInfo, Dictionary<string, CustomFunction> customFunctions)
        {
            _variables[nameof(PI)] = PI;
            _variables[nameof(E)] = E;

            _reserved = new[] { nameof(PI), nameof(E) }.Concat(ScannerConstants.SpecialCases(cultureInfo).Keys).ToArray();
            _cultureInfo = cultureInfo;
            _customFunctions = customFunctions;
        }

        public decimal Solve(string expression)
        {
            _params.Clear();
            _stack.Clear();
            _stackCustomFunctions.Clear();

            var scanner = new Lexicon(expression, _cultureInfo, _customFunctions.Keys);
            var syntatic = new Syntactic();
            syntatic.Parse(scanner, this);
            return _stack.Peek();
        }

        public void SetVariable(string name, decimal value)
        {
            if (_reserved.Contains(name))
                throw new ArgumentException(string.Format(Messages.ReservedWord, name));
            if (_customFunctions.ContainsKey(name))
                throw new ArgumentException(string.Format(Messages.ReservedWordForCustomFunction, name));
            _variables[name] = value;
        }

        public IEnumerable<string> RequiredVariables(string expression)
        {
            Lexicon lexicon = new Lexicon(expression, _cultureInfo, _customFunctions.Keys);
            var variables = new HashSet<string>();

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
                    Avg();
                    break;
                case 21:
                    Sum();
                    break;
                case 22:
                    Sin();
                    break;
                case 23:
                    Cos();
                    break;
                case 24:
                    Tan();
                    break;
                case 25:
                    Truncate();
                    break;
                case 26:
                    Round();
                    break;
                case 27:
                    Round2();
                    break;
                case 28:
                    Ceiling();
                    break;
                case 29:
                    Floor();
                    break;
                case 30:
                    Max();
                    break;
                case 31:
                    Min();
                    break;
                case 32:
                    NewCustomFunction(token);
                    break;
                case 33:
                    EvalCustomFunction();
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
                throw new SemanticError(string.Format(Messages.UndefinedVariable, token.Lexeme), token.Position);

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
                throw new ArgumentException(string.Format(Messages.PowNaN, a, b));
            
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
                throw new ArgumentException(string.Format(Messages.RootNaN, b, a));
            _stack.Push(Convert.ToDecimal(result));
        }

        public void Sqrt()
        {
            var a = Convert.ToDouble(_stack.Pop());
            var result = Math.Sqrt(a);
            if (double.IsNaN(result))
                throw new ArgumentException(string.Format(Messages.SqrtNaN, a));

            _stack.Push(Convert.ToDecimal(result));
        }

        public void Abs()
        {
            var a = _stack.Pop();
            _stack.Push(Math.Abs(a));
        }

        public void Avg()
        {
            var count = _params.Pop();
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
            var count = _params.Pop();
            decimal total = 0;
            for (int i = 0; i < count; i++)
            {
                total += _stack.Pop();
            }
            _stack.Push(total);
        }

        public void Sin()
        {
            var a = Convert.ToDouble(_stack.Pop() * PI / 180M);
            var result = Math.Sin(a);
            _stack.Push(Convert.ToDecimal(result));
        }

        public void Cos()
        {
            var a = Convert.ToDouble(_stack.Pop() * PI / 180M);
            var result = Math.Cos(a);
            _stack.Push(Convert.ToDecimal(result));
        }

        public void Tan()
        {
            var a = Convert.ToDouble(_stack.Pop() * PI / 180M);
            var result = Math.Tan(a);
            _stack.Push(Convert.ToDecimal(result));
        }

        public void Truncate()
        {
            var a = _stack.Pop();
            _stack.Push(Math.Truncate(a));
        }

        public void Round()
        {
            var a = _stack.Pop();
            _stack.Push(Math.Round(a));
        }

        public void Round2()
        {
            var b = Convert.ToInt32(_stack.Pop()); // TODO: gramática com tipos reais e inteiros
            var a = _stack.Pop();
            _stack.Push(Math.Round(a, b));
        }

        public void Ceiling()
        {
            var a = _stack.Pop();
            _stack.Push(Math.Ceiling(a));
        }

        public void Floor()
        {
            var a = _stack.Pop();
            _stack.Push(Math.Floor(a));
        }

        public void Max()
        {
            var count = _params.Pop();
            var max = _stack.Pop();
            for (int i = 1; i < count; i++)
            {
                var value = _stack.Pop();
                if(value > max)
                    max = value;
            }
            _stack.Push(max);
        }

        public void Min()
        {
            var count = _params.Pop();
            var min = _stack.Pop();
            for (int i = 1; i < count; i++)
            {
                var value = _stack.Pop();
                if (value < min)
                    min = value;
            }
            _stack.Push(min);
        }

        private void NewCustomFunction(Token token)
        {
            _stackCustomFunctions.Push(token.Lexeme);
        }

        private void EvalCustomFunction()
        {
            var functionName = _stackCustomFunctions.Pop();
            var customFunction = _customFunctions[functionName];

            var count = _params.Pop();
            var parameters = new decimal[count];
            for (int i = count-1; i >= 0; i--)
            {
                parameters[i] = _stack.Pop();
            }
            var result = customFunction(parameters);
            _stack.Push(result);
        }

        public decimal Result() => _stack.Peek();

    }
}
