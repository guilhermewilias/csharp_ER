/*
Faça um programa que dada a idade de um nadador, classifique-o em uma das seguintes categorias: 
- Infantil A = 5 a 7 anos 
- Infantil B = 8 a 11 anos 
- Juvenil A = 12 a 13 anos 
- Juvenil B = 14 a 17 anos 
- Adultos = Maiores de 18 anos 
 */

static void main()
{
    Console.Write("Digite a idade do nadador : ");
    int idadeNadador = int.Parse(Console.ReadLine()!);

    if (idadeNadador == 5 || idadeNadador <= 7)
    {
        Console.WriteLine("\nClassificação do nadador : Infantil A.");

    }
    else if (idadeNadador == 8 || idadeNadador <= 11)
    {
        Console.WriteLine("\nClassificação do nadador : Infantil B.");

    }
    else if (idadeNadador == 12 || idadeNadador == 13)
    {
        Console.WriteLine("\nClassificação do nadador : Juvenil A.");

    }
    else if (idadeNadador == 14 || idadeNadador <= 17)
    {
        Console.WriteLine("\nClassificação do nadador : Juvenil B.");
    }
    else if (idadeNadador >= 18)
    {
        Console.WriteLine("\nClassificação do nadador : Adultos.");
    }
}
main();