/*
Faça um programa que leia um número inteiro e mostre uma mensagem indicando se este número é par ou ímpar, 
e se é positivo ou negativo. O programa só deve parar de rodar quando o usuário responder "S" na seguinte 
pergunta, "Deseja encerrar o programa?" .
 */

using System.ComponentModel.Design;

static void main()
{
    char encerrar;

    Console.WriteLine("Digite um número inteiro positivo ou negativo : ");
    int numeroEscolhido = int.Parse(Console.ReadLine()!);

    if (numeroEscolhido % 2 == 0)
    {
        Console.WriteLine("\nO numero que vc digitou é par");
    }
    else
    {
        Console.WriteLine("\nO numero que você digitou é impar");
    }

    if (numeroEscolhido > 0)
    {
        Console.WriteLine("\nO numero escolhido é positivo");
    }
    else if (numeroEscolhido < 0)
    {
        Console.WriteLine("\nO numero escolhido é negativo");
    }
    else
    {
        Console.WriteLine("\nO numero escolhido é zero");
    }
    


    Console.WriteLine("Deseja sair do programa? (S/N)");
    encerrar = char.ToUpper(Console.ReadKey().KeyChar);
}
main();