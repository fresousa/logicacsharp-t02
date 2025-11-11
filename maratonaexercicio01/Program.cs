/*1.Saudação com Nome
Objetivo: Declarar variáveis, usar concatenação e interpolação.
Descrição: Crie um script que declare uma variável para o nome de
uma pessoa e exiba uma saudação personalizada, por exemplo: "Olá,
João! Bem - vindo ao nosso site!".
Dica: Utilize tanto a concatenação (.) quanto a interpolação dentro de
uma string com aspas duplas.*/

string name = "Rico";
Console.WriteLine($"Olá {name}, seja bem-vindo!");
Console.WriteLine("Olá " + name + ", seja bem-vindo!");


/*2. Conversão de Temperatura (Celsius para Fahrenheit)
Objetivo: Trabalhar com cálculos matemáticos e variáveis.
Descrição: Crie um script que converta uma temperatura em Celsius
para Fahrenheit. A fórmula para conversão é: F = (C x 9 / 5) + 32
Dica: Declare uma constante para armazenar o valor 9/5 e faça o
cálculo com a variável fornecida.*/

const double fatorConversao = 9.0 / 5.0;
double celsius = 29.0;
double fahrenheit = (celsius * fatorConversao) + 32;
Console.WriteLine("Temperatura em Celsius: " + celsius);
Console.WriteLine("Temperatura em Fahrenheit: " + fahrenheit);


/*3. Impressão de Dados do Usuário
Objetivo: Concatenar e interpolar dados.
Descrição: Crie um script que solicite ao usuário seu nome, idade e
cidade e depois mostre uma mensagem com essas informações.
Exemplo: "Meu nome é João, tenho 25 anos e moro em São Paulo".
Dica: Use tanto concatenação quanto interpolação.*/

string nome = "Rico";
int idade = 29;
string cidade = "Belo Horizonte";
Console.WriteLine($"Meu nome é {nome}, tenho {idade} anos e moro em {cidade}.");
Console.WriteLine("Meu nome é " + nome + ", tenho " + idade + " anos e moro em " + cidade + ".");


/*4. Empréstimo Bancário
Objetivo: Cálculos financeiros e declaração de variáveis.
Descrição: Crie um script que calcule o valor de uma parcela de um
empréstimo, dado o valor total do empréstimo, a taxa de juros e o
número de parcelas. Exemplo de fórmula:
Dica: Utilize variáveis para o valor do empréstimo, a taxa de juros e o
número de parcelas.*/

double valorEmprestimo = 87000.00; // valor total do empréstimo
double taxaJuros = 2.9; // taxa de juros (2.9%)
int numeroParcelas = 18; // número de parcelas

// Cálculo do valor da parcela
double valorParcela = (valorEmprestimo * (1 + taxaJuros)) / numeroParcelas;

// Exibição dos resultados
Console.WriteLine("Valor total do empréstimo: R$ " + valorEmprestimo);
Console.WriteLine("Taxa de juros: " + (taxaJuros * 10) + "%");
Console.WriteLine("Número de parcelas: " + numeroParcelas);
Console.WriteLine("Valor de cada parcela: R$ " + valorParcela.ToString("F2"));

/*5. Conversor de Moeda
Objetivo: Trabalhar com variáveis, operadores e arredondamento.
Descrição: Crie um script que converta uma quantia em reais para
dólares, com base em uma taxa de câmbio fornecida. Mostre o valor
convertido com 2 casas decimais.
Dica: Use round() para arredondar o valor para 2 casas decimais.*/

double valorEmReais = 2900.00;    // valor em reais
double taxaCambio = 5.33;        // 1 dólar = 5,33 reais
double valorEmDolares = valorEmReais / taxaCambio;
double valorArredondado = Math.Round(valorEmDolares, 2);
Console.WriteLine("Valor em reais: R$ " + valorEmReais);
Console.WriteLine("Taxa de câmbio: R$ " + taxaCambio + " por dólar");
Console.WriteLine("Valor convertido em dólares: US$ " + valorArredondado);


/*6 . Calculadora de Desconto
Objetivo: Cálculos matemáticos e uso de variáveis.
Descrição: Crie um script que calcule o valor do desconto de um
produto, dado o preço original e a porcentagem de desconto. Exemplo
de fórmula:
Dica: Use variáveis para armazenar o preço e a porcentagem do
desconto e calcule o valor final.*/

double precoOriginal = 1029.00;  // preço original do produto
double percentualDesconto = 9.2; // desconto em %
double valorFinal = precoOriginal - (precoOriginal * percentualDesconto / 100);
Console.WriteLine("Preço original: R$ " + precoOriginal);
Console.WriteLine("Desconto: " + percentualDesconto + "%");
Console.WriteLine("Preço com desconto: R$ " + valorFinal.ToString("F2"));