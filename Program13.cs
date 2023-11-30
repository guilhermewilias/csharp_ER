/*
Faça um programa que leia as variáveis C e N, respectivamente código e número de horas trabalhadas de um 
operário. E calcule o salário sabendo-se que ele ganha R$ 10,00 por hora. Quando o número de horas exceder a 
50, calcule o excesso de pagamento armazenando-o na variável E, caso contrário zerar tal variável. A hora 
excedente de trabalho vale R$ 20,00. No final do processamento imprimir o salário total e o salário excedente. O 
programa só deve parar de rodar quando o usuário responder "S" na seguinte pergunta, "Deseja encerrar o 
programa?".
 */

static void main()
{
    char encerrar;

    do
    {
        Console.WriteLine("Digite o código do operário : ");
        int codigo = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite o número de horas trabalhadas : ");
        int horasTrabalhadas = int.Parse(Console.ReadLine()!);

        double salarioTotal, salarioExcedente;

        if (horasTrabalhadas <= 50)
        {
            salarioTotal = horasTrabalhadas * 10;
            salarioExcedente = 0;
        }
        else
        {
            int horasExcedentes = horasTrabalhadas - 50;
            salarioTotal = 50 * 10 + horasExcedentes * 20;
            salarioExcedente = horasExcedentes * 20;
        }

        Console.WriteLine($"Salário Total: R$ {salarioTotal:F2}");
        Console.WriteLine($"Salário Excedente: R$ {salarioExcedente:F2}");

        Console.Write("Deseja encerrar o programa? (S/N): ");
        encerrar = char.ToUpper(Console.ReadKey().KeyChar);

    } while (encerrar != 'S');
}

main();