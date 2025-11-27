using System;
class Program
{
  static void Main()
    {
        // Chama a função simples que imprime uma mensagem
        ImprimirMensagem();

        // Exemplo de função para cálculo de áreas (modularização)
        Console.WriteLine("\n--- Áreas ---");
        Console.WriteLine("Quadrado: " + CalcularAreaQuadrado(4));
        Console.WriteLine("Círculo: " + CalcularAreaCirculo(3));

        // Exemplo de programa dividido em funções: entrada, processamento e saída
        Console.WriteLine("\n--- Média de Notas ---");
        double[] notas = EntrarNotas(3);      // Entrada de dados
        double media = CalcularMedia(notas);  // Processamento
        Console.WriteLine("Média: " + media); // Saída 
    }

    // Função simples que exibi uma mensagem no console
    static void ImprimirMensagem() => Console.WriteLine("Olá, mundo!");

    // Função que calcula a área de um quadrado
    static double CalcularAreaQuadrado(double lado) => lado * lado;

    // Função que calcula a área de um circulo
    static double CalcularAreaCirculo(double raio) => Math.PI * raio * raio;

    // Função que lê notas digitadas pelo usuário e armazena em um vetor
    static double[] EntrarNotas(int qtd)
    {
        double[] notas = new double[qtd];
        for (int i = 0; i < qtd; i++)
        {
            Console.Write("Nota " + (i + 1) + ": ");
            notas[i] = double.Parse(Console.ReadLine());
        }
        return notas;
    }

    // Função que calcula a média de um vetor de notas
    static double CalcularMedia(double[] notas)
    {
        double soma = 0;
        foreach (double n in notas) soma += n;
        return soma / notas.Length;
    }

}