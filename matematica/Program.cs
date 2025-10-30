
//Declarando constantes
const int valor1 = 10;
const int valor2 = 5;


//Soma
int soma = valor1 + valor2;
Console.WriteLine($"Soma: {valor1} + {valor2} = {soma}");

//Subtração
int subtracao = valor1 - valor2;
Console.WriteLine($"Subtração: {valor1} - {valor2} = {subtracao}");

//Multiplicação
int multiplicacao = valor1 * valor2;
Console.WriteLine($"Multiplicação: {valor1} * {valor2} = {multiplicacao}");

//Divisão (resultado)
int divisao  = valor1 / valor2;
Console.WriteLine($"Divisão: {valor1} / {valor2} = {divisao}");

//Resto da divisão
int restoDivisao = valor1 % valor2;
Console.WriteLine($"Resto da divisão: {valor1} / {valor2} = {restoDivisao}");

//Potenciação(usando. Math.Pow para calcular a potência)
double potencia = Math.Pow(valor2, valor2);
Console.WriteLine($"Potenciação: {valor1} elevado a {valor2} = {potencia}");


/*(comentário mais de 1 linha ao mesmo tempo)
ordem
de 
grandeza */


//Exemplo 1: Sem parênteses
int resultado1 = 3 + 5 * 2; // Multiplicacão tem prioridade
Console.WriteLine($"Resultado 1 (sem parênteses): 3 + 5 * 2 = {resultado1}");


//Exemplo 2: Com parênteses
int resultado2 = (3 + 5) * 2; // Parênteses alteram a ordem 
Console.WriteLine($"Resultado 2 (com parênteses): (3 + 5) * 2 = {resultado2}");

//Exemplo 3: Sem parênteses
int resultado3 = 8 / 4 + 3; // Divisão tem prioridade
Console.WriteLine($"Resultado 3 (sem parênteses): 8 / 4 + 3 = {resultado3}");

//Exemplo 4: Com parênteses
double resultado4 = 8.0 / (4 + 3); // Parênteses alteram a ordem 
Console.WriteLine($"Resultado 4 (com parênteses): 8 / (4 + 3) = {resultado4}");

