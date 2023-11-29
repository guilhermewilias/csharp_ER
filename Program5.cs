/*
 Faça um programa para imprimir uma tabuada. 
 */

static void main()
{
    Console.WriteLine("Digite o numero para ver a tabuada do mesmo : ");
    int numero = int.Parse(Console.ReadLine()!);

    Console.WriteLine($"\n\nA tabuada do {numero} é :");

    for (int i = 1; i <= 10; i++)
    {
        int resultado = numero * i;

        Console.WriteLine($"{numero} x {i} = {resultado}");
    }
}

main();