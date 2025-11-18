using System;

class Program
{
    static void Main()
    {

        //Exercícios com if, else e elseif:

        /*1.Faça um programa para verificação de estoque
        Um sistema de gerenciamento de estoque precisa notificar os funcionários
        quando for hora de reabastecer um produto.
        Escreva um código que verifique a quantidade de um produto em estoque. Se a
        quantidade for menor que 5, exiba a mensagem: "Alerta: Baixo estoque. Por favor,
        reabasteça este produto.". Caso contrário, exiba: "Estoque suficiente.".*/


        /*2. Faça um programa de desconto
        Uma loja oferece um desconto para compras acima de um certo valor como parte
        de uma promoção de vendas. Escreva um código que determine o valor total da
        compra de um cliente. Se o valor total for superior a R$ 200,00, aplique um
        desconto de 10% e exiba: "Desconto de 10% aplicado!".Se o valor total for R$
        200,00 ou menos, informe: "Adicione mais itens ao carrinho para ganhar um
        desconto de 10%.".
        Exercícios com switch:*/


        //Exercícios com switch:

        /*1.Faça um programa que determine o dia da semana
        O programa deve receber um número de 1 a 7, representando um dia da semana,
        e imprimir o nome do dia correspondente (por exemplo, 1 = "Domingo", 2 =
        "Segunda-feira", etc.).*/


        /*2. Faça um programa que calcule o preço final de um produto com base em um
        código de desconto
        O programa deve receber um código de desconto (de 1 a 3) e aplicar o desconto
        correspondente ao preço do produto.
        o Código 1: 10 % de desconto
        o Código 2: 20 % de desconto
        o Código 3: 30 % de desconto
        o Se o código for inválido, deve mostrar uma mensagem de erro.
        Exercícios com for:*/


        //Exercícios com for:

        /*1.Faça um programa de tabuada de multiplicação
               Crie um programa que mostre na tela as tabuadas do número 7, utilizando laço de
               repetição for.
               O programa deve exibir, para cada número de 7, a multiplicação desse número
               pelos valores de 1 a 10.*/

        Console.WriteLine("Tabuada do 7:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("7 x " + i + " = " + (7 * i));
        }

        Console.WriteLine();


        /*2. Faça um programa para calcular a média
        Crie um programa que receba 10 números inteiros e calcule a média desses
        números. Utilize o laço for para ler os números e calcular a média.*/

        int soma = 0; // acumula os números digitados

        Console.WriteLine("Digite 10 números inteiros:");

        for (int i = 1; i <= 10; i++)
        {
            Console.Write("Digite o " + i + "º número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            soma += numero; // soma os números
        }

        // cálculo da média
        double media = soma / 10.0;

        Console.WriteLine("A média dos números digitados é: " + media);

        Console.WriteLine("\nPressione ENTER para continuar...");
        Console.ReadLine();


        //Exercícios com while:

        /*1.Faça um programa contador de visitantes
        Desenvolva um código que simula a entrada X visitantes aleatoriamente no
        museu. A capacidade máxima é de 50 pessoas. Use um loop while para "contar"
        cada visitante até que a capacidade máxima seja atingida. A cada visitante
        adicional, exiba o número total de visitantes até o momento.*/

        int capacidadeMaxima = 50;
        int visitantes = 0;

        Random aleatorio = new Random(); // gerador de números aleatórios

        Console.WriteLine("Contador de visitantes do museu:");
        Console.WriteLine("--------------------------------\n");

        while (visitantes < capacidadeMaxima)
        {
            int entrada = aleatorio.Next(1, 6); // visitantes aleatórios de 1 a 5

            visitantes += entrada;

            if (visitantes > capacidadeMaxima)
                visitantes = capacidadeMaxima;

            Console.WriteLine("Visitantes até o momento: " + visitantes);
        }

        Console.WriteLine("\nCapacidade máxima atingida!");
        Console.ReadLine();


        /*2. Faça um programa de sistema de login
        Um sistema de login precisa verificar a autenticidade do usuário, permitindo
        múltiplas tentativas até que as credenciais corretas sejam fornecidas.
        Desenvolva um código que simule um sistema de login usando um loop while. O
        usuário tem um máximo de 3 tentativas para inserir a senha correta. Se a senha
        correta ("senha123") for inserida, exiba "Login bem-sucedido!". Se o limite de
        tentativas for atingido, mostre "Conta bloqueada por excesso de tentativas.".*/

        string senhaCorreta = "senha123";
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

        Console.ReadLine();

    }
}