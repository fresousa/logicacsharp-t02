// Declaração de dois vetores
int[] numeros = { 7, 2, 3, 34, 5 }; // Vetor de inteiros
string[] nomes = { "Ana", "João", "Maria", "Carlos" }; // Vetor de strings

// Exibindo os elementos do vetor de números com loop for
Console.WriteLine("Vetor de Números (usando for):");
for  (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}

// Exibindo os elementos do vetor de nomes com loop foreach
Console.WriteLine("\nVetor de Nomes (usando foreach):");
foreach (var nome  in nomes)
{
    Console.WriteLine(nome);
}

// Ordenação do vetor de números
/*
Array.Sort(numeros);
Console.WriteLine("\nVetor de Números Ordenado:");
foreach (var n in nomes)
{
    Console.WriteLine(n);
}
*/

int valorProcurado = 5;
int posicaoSequencial  = PesquisaSequencial(numeros, valorProcurado);

if (posicaoSequencial != -1)
{
    Console.WriteLine($"\nPesquisa Sequencial: Valor {valorProcurado} encontrado na posição {posicaoSequencial}.");
}
else
{
    Console.WriteLine($"\nPesquisa Sequencial: Valor {valorProcurado} não encontrado.");
}

static int PesquisaSequencial(int[] vetor, int valor)
{
    for (int i = 0; i < vetor.Length;i++)
    {
        if (vetor[i] == valor)
            return i; // Retorna o índice do valor encontrado
    }
    return -1; // Retorna -1 se não encontrar
}