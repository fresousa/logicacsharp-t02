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


//Ordenar o vetor antes da pesquisa binária
Array.Sort(numeros);

//Pesquisa Binária
int posicaoBinaria = Array.BinarySearch(numeros, valorProcurado);
if (posicaoBinaria >= 0)
{
    Console.WriteLine($"\nPesquisa Binária: Valor {valorProcurado} encontrado na posição {posicaoBinaria}.");
}
else
{
    Console.WriteLine($"\nPesquisa Binária: Valor {valorProcurado} não encontrado.");
}

//Declaração e manipulação de uma matriz 3x2
int[,] matriz = new int[3, 2]
{
    { 1, 2 },
    { 3, 4 },
    { 5, 6 }
};

Console.WriteLine("\nExibindo a Matriz 3x2:");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 2; j++)
    {
        Console.Write(matriz[i, j] + "\t");
    }
    Console.WriteLine();
}

//Manipulação: somando 10 a cada elemento 
Console.WriteLine("\nMatriz após somar 10 a cada elemento:");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 2; j++)
    {
        matriz[i, j] += 10;
        Console.Write(matriz[i, j] + "\t");
    }
    Console.WriteLine();
}