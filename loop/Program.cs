//loop for
using System;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}


int soma = 0;
for(int i = 1; i <= 100; i++)
{
    soma += i; // Soma o valor de i à variável soma, exemplo: 1+2+3+4...+99+100
}

Console.WriteLine("A soma dos números de 1 a 100 é: " + soma);


//loop infinito
/*
for (;;)
{
    Console.WriteLine("Este é um loop infinito!");
}
*/


//Loop While (enquanto)
int contador = 1;

while (contador <=5)
{
    Console.WriteLine (contador);
    contador++; // Incrementa o contador
}


//Loop do While (faça enquanto)
int novocontador = 2;

do
{
    Console.WriteLine (novocontador);
    novocontador++; // Incrementa o contador
} while (novocontador <=5);



//Loop Infinito While
/*while (true)
{
    Console.WriteLine("Este é um loop infinito!");
}*/

//Laço foreach
// Uma lista de strings
List<string> nomes = new List<string> { "Ana", "Carlos", "João", "Maria" };

//Usando o foreach para percorrer a lista 
foreach (string nome in nomes)
{ 
    Console.WriteLine (nome); // Imprime cada nome exibindo na tela
}
// Um vetor de números inteiros
int[] numeros = { 1, 2, 3, 4, 5 };

//Usando o foreach para percorrer o vetor
foreach (int numero in numeros)
{
    Console.WriteLine(numero); // Imprime cada número exibindo na tela
}

// solicitando ao usuário a digitação
double preco, total = 0;

do
{
    Console.Write("Digite o preço do produto (ou 0 para sair): ");
    preco = Convert.ToDouble(Console.ReadLine());
    total += preco;
} while (preco != 0);

Console.WriteLine($"\nTotal da compra: R$ {total:F2}");