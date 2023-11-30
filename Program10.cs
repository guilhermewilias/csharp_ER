//Faça um programa que conte de 1 até 100 e a cada múltiplo de 10 exiba uma mensagem: "Múltiplo de 10

static void main()
{
    int numero = 0;

    for (int i = 1; i <= 100; i++)
    {
        Console.WriteLine(i);

        if (i % 10 == 0)
        {
            Console.WriteLine("é multiplo de 10");
        }
    }
}

main();