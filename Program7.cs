/*
Escreva um programa que calcule e exiba a soma dos quadrados dos 20 primeiros números inteiros positivos 
ímpares a partir do número informado pelo usuário menor que 10 e maior que zero.
 */

static void main()
{
    Console.Write("Digite um numero menor que 10, e maior do que 0 : ");
    int numeroInicial = int.Parse(Console.ReadLine()!);
    

    if (numeroInicial > 0 || numeroInicial < 10)
    {
        int somaQuadrados = 0;
        int contadorImpares = 0;

        Console.WriteLine($"\n\nOs 20 primeiros números inteiros e positivos : {numeroInicial}");

        while (contadorImpares < 20)
        {
            if (numeroInicial % 2 != 0)
            {
                Console.Write($"{numeroInicial}");
                somaQuadrados += numeroInicial * numeroInicial;
                contadorImpares++;
            }
            numeroInicial++;
        }
        Console.Write($"\n\nSoma dos quadrados dos 20 primeiros numeros impares : {somaQuadrados}");


    }
    else
    {
        Console.WriteLine("Número inválido. Certifique-se de que está entre 1 e 9.");
    }
   
}

main();