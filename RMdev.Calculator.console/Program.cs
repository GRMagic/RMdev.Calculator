﻿// See https://aka.ms/new-console-template for more information
using RMdev.Calculator;
using RMdev.Calculator.Compiler;
using System.Diagnostics;
using static System.Console;

//Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("en");
//new Calc().SetVariable("E",0);

var calc = new Calc();
var stopWatch = Stopwatch.StartNew();
long i = 0;
do {
    calc.Solve("1+1");
    i++;
}while (stopWatch.ElapsedMilliseconds < 60000);
Console.WriteLine($"{i/60}/s");
return;

while (true)
{
    Ciclo();
    Console.WriteLine();
    Console.WriteLine("Precione ENTER para recomeçar!");
    while (Console.ReadKey(true).Key != ConsoleKey.Enter) ;
    Console.Clear();
}

void Ciclo()
{
    Write("Escreva uma expressão: ");
    var expressao = ReadLine();
    try
    {
        calc.Check(expressao);
        WriteLine("Expressão válida!");
    }
    catch (AnalysisError erro)
    {
        Error.WriteLine("A expressão não é válida!");
        Error.WriteLine(erro);
        return;
    }
    var variaveis = calc.RequiredVariables(expressao);
    if (variaveis.Any())
    {
        foreach (var variavel in variaveis)
        {
            Write($"Qual é o valor da variável {variavel}? ");
            var input = ReadLine();
            if (decimal.TryParse(input, out var valor))
                calc.SetVariable(variavel, valor);
        }
    }
    else
    {
        WriteLine("A expressão não possui variáveis.");
    }
    try
    {
        calc.Check(expressao, true);
        WriteLine("A expressão passou com sucesso pela análise léxica, sintática e semântica!");
    }
    catch (AnalysisError erro)
    {
        Error.WriteLine("A expressão não é válida!");
        Error.WriteLine(erro);
        return;
    }
    var resultado = 0m;
    stopWatch.Restart();
    resultado = calc.Solve(expressao);
    stopWatch.Stop();
    WriteLine($"O resultado é: {resultado}");
    WriteLine($"O tempo de cálculo foi de {stopWatch.Elapsed}");
}