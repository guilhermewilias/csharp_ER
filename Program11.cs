/*
Faça um programa que leia 10 valores inteiros e positivos e: 
- Encontre o maior valor 
- Encontre o menor valor 
- Calcule a média dos números lidos
 */


static void main()
{
    int quantidadeDeValores = 10;
    int soma = 0;
    int maior = int.MinValue;
    int menor = int.MaxValue;

    for (int i = 0; i < quantidadeDeValores; i++)
    {
        Console.WriteLine($"Digite o {i + 1}º valor : ");
        int valor = int.Parse( Console.ReadLine()!);
        
        if (valor > maior)
        {
            maior = valor;
        }

        if (valor < menor)
        {
            menor = valor;
        }

        soma += valor;
    }

    double media = (double)soma / quantidadeDeValores;

    Console.WriteLine($"O maior valor é : {maior}");
    Console.WriteLine($"O menor valor é : {menor}");
    Console.WriteLine($"A média dos valores é : {media}");
}
main();