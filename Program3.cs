/*
 Faça um programa que gera e escreve os números ímpares dos números lidos entre 100 e 200.
 */

static void main()
{
    Console.WriteLine("Numeros impares lidos entre 100 e 200 : ");

    for (int i = 101; i <= 199; i += 2)
    {
        Console.WriteLine(i);
    } 
}

main();