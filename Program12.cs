/*
Faça um programa de conversão de base numérica. O programa deverá apresentar uma tela de entrada com as 
seguintes opções: 
1 – Adição 
2 – Subtração 
3 – Multiplicação 
4 – Divisão 
Informe a opção: 
A partir da opção escolhida, o programa deverá solicitar para que o usuário digite dois números. Em seguida, o 
programa deve exibir o resultado da opção indicada pelo usuário e perguntar ao usuário se ele deseja voltar ao 
menu principal. Caso a resposta seja ´S´ ou ´s´, deverá voltar ao menu, caso contrário deverá encerrar o 
programa.
*/

using System.ComponentModel.Design;
using System.Net.Http.Headers;

static void main()
{
    bool continuar = true;

    do
    {
        Console.WriteLine("Selecione alguma das opções abaixo : ");
        Console.WriteLine("1. Adição");
        Console.WriteLine("2. Subtração");
        Console.WriteLine("3. Multiplicação");
        Console.WriteLine("4. Divisão");

        Console.Write("\n\nDigite a opção selecionada : ");
        string opcao = Console.ReadLine()!; 
        
        switch(opcao)
        {
            case "1":
                realizarOperacoes(Adicao);
                break;
            case "2":
                realizarOperacoes(Subtracao); 
                break;
            case "3":
                realizarOperacoes(Multiplicacao); 
                break;
            case "4":
                realizarOperacoes(Divisao); 
                break;
            default:
                Console.WriteLine("\nOpção invalida");
                break;
        }
      
    } while (continuar);
}

static void realizarOperacoes(Func<double, double, double> operacao)
{

    Console.Clear();

    Console.WriteLine("Digite o primeiro número : ");
    double numero1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("\nDigite o segundo número : ");
    double numero2 = Convert.ToDouble(Console.ReadLine());

    double resultado = operacao(numero1, numero2);

    Console.WriteLine($"\nResultado foi : {resultado}");

   Console.WriteLine("\n\nTecle qualquer coisa para retornar ao menu");
    Console.ReadKey();
    Console.Clear();
    main();

}

static double Adicao(double a, double b)
{
    return a + b;
}

static double Subtracao (double a, double b)
{
    return a - b;
}

static double Multiplicacao (double a, double b)
{
    return (a * b);
}
static double Divisao (double a, double b)
{
   if (b != 0)
    {
        return a / b;
    }
    else
    {
        Console.WriteLine("\nDivisão por zero não é permitida.");
        return 0;
    }
    
}
main();
