/*
Escrever um programa que leia um conjunto de números positivos, e exiba se o número lido é par ou ímpar. Exiba 
ao final a soma total dos números pares lidos e também a soma dos números ímpares lidos. Suporemos que o 
número de elementos deste conjunto não é conhecido, e que um número negativo será utilizado para sinalizar o 
fim dos dado
 */

static void main()
{
    int numero;
    int somaPar = 0;
    int somaImpar = 0;

    Console.WriteLine("Digite um conjunto de números positivos. Digite um número negativo para encerrar.");

    do
    {
        Console.WriteLine("Digite um numero : ");
        numero = int.Parse(Console.ReadLine()!);

        if (numero >= 0)
        {
            if (numero % 2 == 0)
            {
                Console.WriteLine($"{numero} é par");
                somaPar += numero;
            }
            else
            {
                Console.WriteLine($"{numero} é impar");
                somaImpar += numero;
            }

        }
    } while (numero >= 0);
        Console.WriteLine($"Soma dos números pares: {somaPar}");
        Console.WriteLine($"Soma dos números ímpares: {somaImpar}");
    
}

main();