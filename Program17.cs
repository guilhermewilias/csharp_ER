/*
Faça um programa que determine o maior e o menor entre N números lidos. A condição de parada é a entrada de 
um valor 0, ou seja, o programa deve ficar executando até que a entrada seja igual a 0 (ZERO). 
 */

using System.ComponentModel.Design;

static void main()
{
    int numero;
    int maior = int.MinValue;
    int menor = int.MaxValue;

    do
    {
        Console.Write("Digite um número (digite 0 para parar): ");
        numero = int.Parse(Console.ReadLine()!);

        if (numero != 0)
        {
            if (numero > maior)
            {
                maior = numero;
            }
            if (numero < menor)
            {
                numero = menor;
            }
        }
    } while (numero != 0);

    if (maior == int.MinValue && menor == int.MaxValue) 
    {
        Console.WriteLine("\nNenhum número foi insirido");
    }
    else
    {
        Console.WriteLine($"\nO maior número inserido foi: {maior}");
        Console.WriteLine($"\n menor número inserido foi: {menor}");
    }
    
}
main();