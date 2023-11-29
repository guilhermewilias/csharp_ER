/* 
 Escreva um programa que exiba os números de 1 a 100 na tela em ordem decrescente
 */

static void main()
{
    Console.WriteLine("Numeros de 1 a 100 em ordem decrescente :");

    for (int i = 100; i >= 1; i--)
    {
        Console.WriteLine(i);
    }
}

main();