/*
A Secretaria de Meio Ambiente que controla o índice de poluição mantém 03 grupos de indústrias que são 
altamente poluentes do meio ambiente. O índice de poluição aceitável varia de 0,05 até 0,25. Se o índice sobe 
para 0,3 as indústrias do 1º grupo são intimadas a suspenderem suas atividades, se o índice crescer para 0,4 as 
industrias do 1º e 2º grupo são intimadas a suspenderem suas atividades, se o índice atingir 0,5 todos os grupos 
devem ser notificados a paralisarem suas atividades. Faça um programa que leia o índice de poluição medido e 
emita a notificação adequada aos diferentes grupos de empresas. O algoritmo só deve parar de rodar quando o 
usuário responder "S" na seguinte pergunta, "Deseja encerrar o programa?". 
 */


/*static void main()
{
    char encerrar;

    Console.Write("Digite o nível de poluição : ");

    if (double.TryParse(Console.ReadLine(), out double indicePoluicao))
    {
        if (indicePoluicao >= 0.05 && indicePoluicao <= 0.25)
        {
            Console.WriteLine("\nÍndice de poluição dentro do aceitável.\n");
        }else if (indicePoluicao > 0.25 && indicePoluicao <= 0.3)
        {
            Console.WriteLine("\nIndústrias do 1º grupo devem ser intimadas a suspender suas atividades.\n");
        }else if (indicePoluicao > 0.3 && indicePoluicao <= 0.4)
        {
            Console.WriteLine("\nIndustrias do 1º e 2º grupo devem ser intimadas a suspender suas atividades\n");
        }else if (indicePoluicao > 0.4 && indicePoluicao < 0.5)
        {
            Console.WriteLine("\nTodos os grupos devem ser notificados a suspenderem suas atividades\n");
        }else if (indicePoluicao > 0.5)
        {
            Console.WriteLine("\nNivel de poluição extremamente alto. Parar atividades imediatamente.\n");
        }
        else
        {
            Console.WriteLine("\nPor favor, insira um nível de poluição válido.\n");
            encerrar = 'N';


        } 
    } 
}*/

static void Main()
{
    char encerrar;

    do
    {
        Console.WriteLine("Digite o índice de poluição medido: ");

        if (double.TryParse(Console.ReadLine(), out double indicePoluicao))
        {
            if (indicePoluicao >= 0.05 && indicePoluicao <= 0.25)
            {
                Console.WriteLine("Índice de poluição dentro do aceitável.");
            }
            else if (indicePoluicao > 0.25 && indicePoluicao <= 0.3)
            {
                Console.WriteLine("Indústrias do 1º grupo devem ser intimadas a suspender suas atividades.");
            }
            else if (indicePoluicao > 0.3 && indicePoluicao <= 0.4)
            {
                Console.WriteLine("Indústrias do 1º e 2º grupo devem ser intimadas a suspender suas atividades.");
            }
            else if (indicePoluicao > 0.4 && indicePoluicao <= 0.5)
            {
                Console.WriteLine("Todos os grupos devem ser notificados a paralisarem suas atividades.");
            }
            else if (indicePoluicao > 0.5)
            {
                Console.WriteLine("Índice de poluição muito alto. Todos os grupos devem paralisar imediatamente.");
            }

            Console.WriteLine("Deseja encerrar o programa? (S/N)");
            encerrar = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine(); // Adiciona uma quebra de linha para melhor formatação
        }
        else
        {
            Console.WriteLine("Por favor, insira um valor válido para o índice de poluição.");
            encerrar = 'N'; // Se houver um erro, não encerra o programa automaticamente
        }

    } while (encerrar != 'S');

    Console.WriteLine("O programa foi encerrado. Até logo!");
}


Main();