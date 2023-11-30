/*
Escreva um programa que calcule e exiba a média da nota dos alunos de uma turma em uma prova. O número de 
alunos é desconhecido. Os dados de um aluno são: número de matrícula e a sua nota na prova em questão.
 */

static void main()
{
    int totalAlunos = 0;    
    double somaNotas = 0;

    Console.WriteLine("Calculadora de média de notas");

    while (true)
    {
        Console.WriteLine("\n\nInsira a matricula do aluno, ou digite 'sair' para encerrar o programa");
        string inputMatricula = Console.ReadLine()!;

        if (inputMatricula.ToLower() == "sair")
        {
            break;
        }
        if (!int.TryParse(inputMatricula, out totalAlunos) )
        {
            Console.WriteLine("\n\nInsira uma matrica válida.");
            continue;
        }

        Console.Write("\nDigite a nota do aluno : ");
        if (!double.TryParse(Console.ReadLine(), out double nota))
        {
            Console.WriteLine("\nPor vaor, insira uma nota válida.");
            continue;
        }
        totalAlunos++;
        somaNotas += nota;
    }
    if (totalAlunos > 0)
    {
        double media = somaNotas / totalAlunos;
        Console.WriteLine($"\nA media dos {totalAlunos} alunos foi : {media:F2}");
    }
    else
    {
        Console.WriteLine("Nenhum dado inserido.");
    }
}



main();