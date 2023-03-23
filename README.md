# rmdev.Calculator

Biblioteca para calcular expressões matemáticas respeitando a prioridade dos operadores com suporte a variáveis, e funções personalizadas.

Tanto no nome das variáveis como no nome das funções maiúsculas e minusculas fazem diferença. (Case-Sensitive)

## Números
O separador de decimal deve ser o ponto, independente de qual linguagem está sendo utilizada, não deve ser utilizado separador de milhar.

## Constantes
 - **PI** = 3.14159265358979
 - **E** = 2.71828182845904

## Variáveis

Variáveis podem ser declaradas usando **letras**, **números**, **$** e **underline**, mas não podem começar com números nem conter acentuação.

## Operadores

- **\+** Adição
- **\-** Subtração
- **\*** Multiplicação
- **/** Divisão
- **%** Resto da divisão
- **^** Potenciação
- **(** e **)** Priorização

Primeiro será calculado o que está entre parênteses,

seguido por potência,

depois multiplicações, divisões, e restos

e finalmente somas e subtrações.

Em caso de operações estarem no mesmo nível de prioridade, elas serão executadas da esquerda para a direita.


## Funções

- **Root(radicando, indice)** Enésima raiz de um número
- **Sqrt(radicando)** Raiz quadrada de um número
- **Abs(V)** Valor absoluto de V
- **Avg(V1, V2, ..., Vn )** Média dos valores
- **Sum(V1, V2, ..., Vn )** Soma dos valores
- **Round(V)** Arredonda um número 
- **Round(V, n)** Arredonda um número para até n casas decimais
- **Truncate(V)** Trunca um número
- **Ceiling(V)** Arredonda um número para cima
- **Floor(V)** Arredonda um número para baixo
- **Sin(V)** Seno de V (em graus)
- **Cos(V)** Coseno de V (em graus)
- **Tan(V)** Tangente de V (em graus)
- **Max(V1, V2, ..., Vn )** Maior entre os valores informados
- **Min(V1, V2, ..., Vn )** Menor entre os valores informados

Os parâmetros devem ser separados por **vírgula**.

## Funções Internacionalizadas

As mensagens de erro serão mostradas de acordo com a cultura da thread atual, mas para usar funções com seus nomes traduzidos é preciso informar a cultura ao criar um novo objeto *Calc*.

### Português

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

*Para adicionar suporte a novos idiomas basta adicionar os resources correspondentes na pasta Resources.*

## Funções Personalizadas

Funções podem ser declaradas usando **letras**, **números**, **$** e **underline**, mas não podem começar com números nem conter acentuação.

As funções devem seguir o delegate 
```csharp
delegate decimal CustomFunction(decimal[] parameters)
```

O array de parâmetros nunca será nulo, mas possivelmente será vazio.

Exemplo de função:
```csharp
decimal Somar(decimal[] parameters){
    return parameters.Sum();
}
```

Funções personalizadas podem sobrescrever funções nativas, mas funções personalizadas não são verificadas semanticamente durante as análises feitas pelo método *Calc.Check()*. Exeções lançadas dentro de uma função personalizada só irão estourar quando o método *Solve* tentar resolver uma expressão com essa função.

## Comentários e caracteres ignorados

Espaços em branco, tabulações e quebras de linha serão ignorados, o que permite escrever expressões com mais de uma linha.

Também é possível criar comentários de uma linha usando **//** ou comentários de bloco usando **/*** e ***/** para delimitar o início e o fim do bloco.

## Exemplo

```csharp
ICalc calc = new Calc();
calc.SetVariable("a", 10);
var result = calc.Solve("a + 2"); // result = 12
```