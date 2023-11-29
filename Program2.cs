/*
Escreva um programa que leia: 
- a quantidade de números que deverá processar; 
- os números que deverá processar,e calcule e exiba, para cada número a ser processado o seu fatorial. 
Lembrete: O fatorial de um número N é dado pela fórmula: N! = 1 * 2 * 3 * 4 * 5 * ... * N
*/

static void main()
{
    Console.WriteLine("Escreva a quantidade de números que serão processados : ");
    int quantidadeNumeros = int.Parse(Console.ReadLine()!);  

    for (int i = 1; i <= quantidadeNumeros; i++)
    {
        Console.WriteLine($"\n\nDigite o numero {i} : ");
        int numero = int.Parse(Console.ReadLine()!);

        long fatorial = calcularFatorial (numero);

        Console.WriteLine($"O fatorial do {numero} é {fatorial}");
    }

    static long calcularFatorial(int numero)
    {
        if (numero == 0 || numero == 1)
        {
            return 1;
        }

        long resultado = 1;
        for (int i = 2; i  <= numero; i++)
        {
            resultado *= 1;
        }

        return resultado;
    }

}

main();
