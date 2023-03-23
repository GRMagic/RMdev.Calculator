# rmdev.Calculator

Library to calculate mathematical expressions respecting the priority of operators with support for variables, and custom functions.

The library is case sensitive for both function and variable names.


## Numbers
The decimal separator must be the point, regardless of which language is being used, the thousand separator must not be used.

## Consts
 - **PI** = 3.14159265358979
 - **E** = 2.71828182845904

## Variables

Variables can be declared using **letters**, **numbers**, **$**, and **underscore**, but they cannot start with numbers or contain accents.

## Operators

- **\+** Addition
- **\-** Subtraction
- **\*** Multiplication
- **/** Division
- **%** Rest of Division
- **^** Power
- **(** e **)** Prioritization

First it will calculate what is in parentheses,

followed by power,

then multiplications, divisions, and remainders

and finally additions and subtractions.

In case operations are at the same priority level, they will be executed from left to right.


## Functions

- **Root(radicand, index)** Nth root of a number
- **Sqrt(radicand)** Square root of a number
- **Abs(V)** Absolute value of V
- **Avg(V1, V2, ..., Vn )** Average of values
- **Sum(V1, V2, ..., Vn )** Sum of values
- **Round(V)** Rounds a number
- **Round(V, n)** Rounds a number to n decimal places
- **Truncate(V)** Truncates a number
- **Ceiling(V)** Rounds a number up
- **Floor(V)** Rounds a number down
- **Sin(V)** Sin of V (in degrees)
- **Cos(V)** Cosine of V (in degrees)
- **Tan(V)** Tangent of V (in degrees)
- **Max(V1, V2, ..., Vn )** Greater between the informed values
- **Min(V1, V2, ..., Vn )** Lowest between the values entered

Parameters must be separated by a **comma**.

## Internationalized Functions

Error messages will be displayed according to the current thread's culture, but to use functions with their translated names, you must inform the culture when creating a new *Calc* object.

### Português (pt)

- **Root** -> Raiz
- **Sqrt** -> RaizQuadrada
- **Abs** -> Abs
- **Avg** -> Media
- **Sum** -> Soma
- **Round** -> Arredondar
- **Truncate** -> Truncar
- **Ceiling** -> ArredondarParaCima
- **Floor** -> ArredondarParaBaixo
- **Sin** -> Seno
- **Cos** -> Coseno
- **Tan** -> Tangente
- **Max** -> Max
- **Min** -> Min

*To add support for new languages just add the corresponding resources in the Resources folder.*

## Custom Functions

Functions can be declared using **letters**, **numbers**, **$**, and **underscore**, but cannot start with numbers or contain accents.

Functions must follow the delegate
```csharp
delegate decimal CustomFunction(decimal[] parameters)
```

The parameter array will never be null, but it can be empty.

function example:
```csharp
decimal SumAll(decimal[] parameters){
    return parameters.Sum();
}
```

Custom functions can override native functions, but custom functions are not semantically checked during checks done by the *Calc.Check()* method. Exceptions thrown inside a custom function will only be thrown when the *Solve* method tries to solve an expression with that function.

## Comments and ignored characters

White spaces, tabs and line breaks will be ignored, which allows you to write expressions with more than one line.

You can also create single line comments using **//** or block comments using **/*** and ***/** to delimit the start and end of the block.

## Examples

```csharp
ICalc calc = new Calc();
var result = calc.Solve("1 + 2"); // result = 3
```

```csharp
ICalc calc = new Calc();
calc.SetVariable("a", 10);
var result = calc.Solve("a + 2"); // result = 12
```

```csharp
ICalc calc = new Calc();
var result = calc.Solve("Sum(1, 2, 3)"); // result = 6
```

```csharp
ICalc calc = new Calc();
calc.CustomFunctions["SumAll"] = args => args.Sum();
var result = calc.Solve("SumAll(1, 2, 3)"); // result = 6
```