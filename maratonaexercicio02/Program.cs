/*1. Faça um programa para verificação de estoque
Um sistema de gerenciamento de estoque precisa notificar os funcionários
quando for hora de reabastecer um produto.
Escreva um código que verifique a quantidade de um produto em estoque. 
Se a quantidade for menor que 5, exiba a mensagem: 
"Alerta: Baixo estoque. Por favor, reabasteça este produto.". 
Caso contrário, exiba: "Estoque suficiente.".
*/

int quantidade = 3;

if (quantidade < 5)
{
    Console.WriteLine("Alerta: Baixo estoque. Por favor, reabasteça este produto.");
}
else
{
    Console.WriteLine("Estoque suficiente.");
}


/*2. Faça um programa de desconto
Uma loja oferece um desconto para compras acima de um certo valor como parte
de uma promoção de vendas. Escreva um código que determine o valor total da
compra de um cliente. Se o valor total for superior a R$ 200,00, aplique um
desconto de 10% e exiba: "Desconto de 10% aplicado!".
Se o valor total for R$ 200,00 ou menos, informe:
"Adicione mais itens ao carrinho para ganhar um desconto de 10%.".
*/

double valorTotal = 300.00;

if (valorTotal > 290.00)
{
    double valorComDesconto = valorTotal * 0.90;
    Console.WriteLine("Desconto de 10% aplicado!");
    Console.WriteLine("Valor final: R$ " + valorComDesconto);
}
else
{
    Console.WriteLine("Adicione mais itens ao carrinho para ganhar um desconto de 10%.");
}


/*1. Faça um programa que determine o dia da semana
O programa deve receber um número de 1 a 7, representando um dia da semana,
e imprimir o nome do dia correspondente (por exemplo, 1 = "Domingo", 2 =
"Segunda-feira", etc.).*/


Console.Write("Digite um número de 1 a 7: ");
int numeroDia = Convert.ToInt32(Console.ReadLine());

switch (numeroDia)
{
    case 1:
        Console.WriteLine("Domingo");
        break;

    case 2:
        Console.WriteLine("Segunda-feira");
        break;

    case 3:
        Console.WriteLine("Terça-feira");
        break;

    case 4:
        Console.WriteLine("Quarta-feira");
        break;

    case 5:
        Console.WriteLine("Quinta-feira");
        break;

    case 6:
        Console.WriteLine("Sexta-feira");
        break;

    case 7:
        Console.WriteLine("Sábado");
        break;

    default:
        Console.WriteLine("Número inválido. Digite de 1 a 7.");
        break;
}


/*2. Faça um programa que calcule o preço final de um produto com base em um
código de desconto.
O programa deve receber um código de desconto (de 1 a 3) e aplicar o desconto
correspondente ao preço do produto.
Código 1 = 10%
Código 2 = 20%
Código 3 = 30%
Se o código for inválido, mostrar mensagem de erro.
*/


double preco = 290.00;

Console.Write("Digite o código de desconto (1 a 3): ");
int codigo = Convert.ToInt32(Console.ReadLine());

switch (codigo)
{
    case 1:
        double precoFinal1 = preco * 0.90;
        Console.WriteLine("Desconto de 10% aplicado!");
        Console.WriteLine("Preço final: R$ " + precoFinal1);
        break;

    case 2:
        double precoFinal2 = preco * 0.80;
        Console.WriteLine("Desconto de 20% aplicado!");
        Console.WriteLine("Preço final: R$ " + precoFinal2);
        break;

    case 3:
        double precoFinal3 = preco * 0.70;
        Console.WriteLine("Desconto de 30% aplicado!");
        Console.WriteLine("Preço final: R$ " + precoFinal3);
        break;

    default:
        Console.WriteLine("Código inválido. Digite um número de 1 a 3.");
        break;
}


/*1. Faça um programa de tabuada de multiplicação
Crie um programa que mostre na tela as tabuadas do número 7, utilizando laço de
repetição for.
O programa deve exibir, para cada número de 7, a multiplicação desse número
pelos valores de 1 a 10.
*/

Console.WriteLine("Tabuada do 7:");

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("7 x " + i + " = " + (7 * i));
}

Console.ReadLine();

/*2. Faça um programa para calcular a média
Crie um programa que receba 10 números inteiros e calcule a média desses
números. Utilize o laço for para ler os números e calcular a média.
*/

int soma = 0;

Console.WriteLine("Digite 10 números inteiros:");

for (int i = 1; i <= 10; i++)
{
    Console.Write("Digite o " + i + "º número: ");
    int numero = Convert.ToInt32(Console.ReadLine());
    soma += numero;
}

double media = soma / 10.0;

Console.WriteLine("A média dos números digitados é: " + media);


/*1. Faça um programa contador de visitantes
Desenvolva um código que simula a entrada X visitantes aleatoriamente no
museu. A capacidade máxima é de 50 pessoas. Use um loop while para "contar"
cada visitante até que a capacidade máxima seja atingida. A cada visitante
adicional, exiba o número total de visitantes até o momento.
*/

int capacidadeMaxima = 50;
int visitantes = 0;

Random gerador = new Random();

Console.WriteLine("Contador de visitantes do museu:\n");

while (visitantes < capacidadeMaxima)
{
    int entrada = gerador.Next(1, 6);

    visitantes += entrada;

    if (visitantes > capacidadeMaxima)
    {
        visitantes = capacidadeMaxima;
    }

    Console.WriteLine("Visitantes até o momento: " + visitantes);
}

Console.WriteLine("\nCapacidade máxima atingida!");

/*2. Faça um programa de sistema de login
Um sistema de login precisa verificar a autenticidade do usuário, permitindo
múltiplas tentativas até que as credenciais corretas sejam fornecidas.
O usuário tem um máximo de 3 tentativas para inserir a senha correta.
Se a senha correta ("senha123") for inserida, exiba: "Login bem-sucedido!".
Se o limite de tentativas for atingido, exiba:
"Conta bloqueada por excesso de tentativas.".
*/

string senhaCorreta = "1996";
int tentativas = 0;
bool autenticado = false;

while (tentativas < 3 && autenticado == false)
{
    Console.Write("Digite sua senha: ");
    string senhaDigitada = Console.ReadLine();

    if (senhaDigitada == senhaCorreta)
    {
        autenticado = true;
        Console.WriteLine("Login bem-sucedido!");
    }
    else
    {
        tentativas++;
        Console.WriteLine("Senha incorreta. Tentativa " + tentativas + " de 3.");
    }
}

if (autenticado == false)
{
    Console.WriteLine("Conta bloqueada por excesso de tentativas.");
}