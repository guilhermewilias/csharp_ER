/*
Escreva um programa que leia um conjunto de números positivos e exiba o menor e o maior. Suporemos que o 
número de elementos deste conjunto não é conhecido, e que um número negativo será utilizado para sinalizar o 
fim dos dados.
 */


/*
static void main()
{
    int numero;
    int maior = int.MinValue;
    int menor = int.MaxValue;

    Console.WriteLine("Digite um conjunto de números positivos, e para encerrar a digitação, digite um número negativo. ");

    do
    {
        Console.Write("\n\nDigite um número : ");
        numero = int.Parse(Console.ReadLine()!);

        if (numero >= 0)
        {
            if (numero < menor)
            {
                menor  = numero;
            }

            if (numero > maior)
            {
                maior = numero;
            }

            if (numero == numero)
            {
                numero = numero
            }
        }
    } while (numero >= 0);

    if (menor != int.MaxValue && maior != int.MinValue && numero == numero)
    {
        Console.WriteLine($"\nMenor número: {menor}");
        Console.WriteLine($"\nMaior número: {maior}");

    }else
    {
        Console.WriteLine("\nNenhum número foi inserido!");
    }
}

main();
*/

static void main()
{
    int numero;
    int menor = int.MaxValue;
    int maior = int.MinValue;

    Console.WriteLine("Programa identificador de maior ou menor numero. Para parar de passar numeros, digite um numero negativo.");

    do
    {
        Console.WriteLine("\nDigite um número : ");

        if (int.TryParse(Console.ReadLine(), out numero))
        {
            if (numero >= 0)
            {
                if (numero < menor)
                {
                    menor = numero;
                }

                if (numero > maior)
                {
                    maior = numero;
                }
            }else
            {
                Console.WriteLine("\nNumero negativo detectado. Encerrando.");
            }
        }
        else
        {
            Console.WriteLine("\n\nEntrada inválida. Por favor, insira um número válido.");
        }
    } while (numero >= 0);
      exibirResultado(menor,maior);
}

static void exibirResultado(int menor, int maior)
{
    if (menor != int.MaxValue && maior  != int.MinValue)
    {
        if (menor == maior)
        {
            Console.WriteLine("\nOs números que foram inseridos são iguais.");
        }
        else
        {
            Console.WriteLine($"\nO menor número digitado foi : {menor}");
            Console.WriteLine($"\nO maior número digitado foi : {maior}");
        }
    }
}

main();
