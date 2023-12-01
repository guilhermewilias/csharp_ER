/*
Faça um programa que exiba as opções: 
1 – Conversão de Graus Celsius em Graus Fahrenheit 
2 – Conversão de Graus Fahrenheit em Graus Celsius 
3 – Peso ideal do homem 
4 – Peso ideal da mulher 
O programa só deve encerrar quando o usuário digitar ´S´ para a pergunta “Deseja encerrar o programa?”
Obs.: Nas opções 3 e 4 informar se o usuário está acima ou abaixo do peso ideal.
 */

static void Main()
{
    char encerrar;

    do
    {
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1 - Conversão de Graus Celsius em Graus Fahrenheit");
        Console.WriteLine("2 - Conversão de Graus Fahrenheit em Graus Celsius");
        Console.WriteLine("3 - Peso ideal do homem");
        Console.WriteLine("4 - Peso ideal da mulher");
        Console.WriteLine("S - Encerrar o programa");

        char escolha = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine(); // Adiciona uma quebra de linha para melhor formatação

        switch (escolha)
        {
            case '1':
                Console.Write("Digite a temperatura em Graus Celsius: ");
                double celsius = double.Parse(Console.ReadLine());
                double fahrenheit = CelsiusParaFahrenheit(celsius);
                Console.WriteLine($"A temperatura em Fahrenheit é: {fahrenheit}°F");
                break;

            case '2':
                Console.Write("Digite a temperatura em Graus Fahrenheit: ");
                double fahrenheitInput = double.Parse(Console.ReadLine());
                double celsiusOutput = FahrenheitParaCelsius(fahrenheitInput);
                Console.WriteLine($"A temperatura em Celsius é: {celsiusOutput}°C");
                break;

            case '3':
                Console.Write("Digite a altura em metros: ");
                double alturaHomem = double.Parse(Console.ReadLine());
                double pesoIdealHomem = PesoIdealHomem(alturaHomem);
                Console.WriteLine($"O peso ideal para um homem com {alturaHomem} metros é: {pesoIdealHomem} kg");
                VerificarPeso(alturaHomem, pesoIdealHomem);
                break;

            case '4':
                Console.Write("Digite a altura em metros: ");
                double alturaMulher = double.Parse(Console.ReadLine());
                double pesoIdealMulher = PesoIdealMulher(alturaMulher);
                Console.WriteLine($"O peso ideal para uma mulher com {alturaMulher} metros é: {pesoIdealMulher} kg");
                VerificarPeso(alturaMulher, pesoIdealMulher);
                break;

            case 'S':
                Console.WriteLine("Programa encerrado. Até logo!");
                return;

            default:
                Console.WriteLine("Opção inválida. Tente novamente.");
                break;
        }

        Console.WriteLine("Deseja encerrar o programa? (S/N)");
        encerrar = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine(); // Adiciona uma quebra de linha para melhor formatação

    } while (encerrar != 'S');
}

static double CelsiusParaFahrenheit(double celsius)
{
    return (celsius * 9 / 5) + 32;
}

static double FahrenheitParaCelsius(double fahrenheit)
{
    return (fahrenheit - 32) * 5 / 9;
}

static double PesoIdealHomem(double altura)
{
    return 72.7 * altura - 58;
}

static double PesoIdealMulher(double altura)
{
    return 62.1 * altura - 44.7;
}

static void VerificarPeso(double altura, double pesoIdeal)
{
    Console.Write("Digite o peso atual: ");
    double pesoAtual = double.Parse(Console.ReadLine());

    if (pesoAtual < pesoIdeal)
    {
        Console.WriteLine($"Você está abaixo do peso ideal para uma altura de {altura} metros.");
    }
    else if (pesoAtual > pesoIdeal)
    {
        Console.WriteLine($"Você está acima do peso ideal para uma altura de {altura} metros.");
    }
    else
    {
        Console.WriteLine("Você está no peso ideal!");
    }
}

Main();