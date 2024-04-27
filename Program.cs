// Mensagem de saudação
Console.WriteLine("Olá, Aproveite o uso deste programa");
Console.Write("Aperte qualquer tecla para continuar:");
Console.ReadKey();
Console.Clear();

// Cria variável "resposta"
string resposta;

// Cria variáveis dos tipos de moedas
decimal euro = 0;
decimal iene = 0;
decimal real = 0;

// Começo do laço
do
{
    // Limpa o código cada vez que retornar
    Console.Clear();

    //  Escolha de cor
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.BackgroundColor = ConsoleColor.Red;

    //Apresentação de menu
    Console.WriteLine("CONVERSOR DE MOEDAS");
    Console.WriteLine("1 - Inserir cotação");
    Console.WriteLine("2 - Realizar conversão");
    Console.WriteLine("3 - Sair");

    // Escolha de cor
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.Black;

    // Pergunta a opção desejada
    Console.Write("Selecione uma opção: ");
    resposta = Console.ReadLine();

    // Limpa tela
    Console.Clear();

    // Condição de acordo com a opção 1
    if (resposta == "1")
    {
        // Pergunta o valor das cotações
        Console.WriteLine("Qual a cotação do Real?");
        decimal.TryParse(Console.ReadLine(), out real);

        Console.WriteLine("Qual a cotação do Euro?");
        decimal.TryParse(Console.ReadLine(), out euro);

        Console.WriteLine("Qual a cotação do Iene?");
        decimal.TryParse(Console.ReadLine(), out iene);

        Console.WriteLine("Aperte qualque tecla para continuar...");
        Console.ReadKey();
    }
    // Condição de acordo com a opção 2
    else if (resposta == "2")
    {
        // Escolhe a moeda de origem
        Console.WriteLine("Qual a moeda de origem?");

        // Escolhe a opção desejada
        Console.WriteLine("1 - Dolar");
        Console.WriteLine("2 - Euro");
        Console.WriteLine("3 - Real");
        Console.WriteLine("4 - Iene");
        string moedaOrigem = Console.ReadLine();

        // Pergunta o valor para poder converter
        Console.WriteLine("Qual a quantidade para converter?");
        decimal quantidadeMoeda = 0;
        decimal.TryParse(Console.ReadLine(), out quantidadeMoeda);

        // Pergunta o tipo de moeda para fazer conversão
        Console.WriteLine("Qual a moeda de destino?");
        Console.WriteLine("1 - Dolar");
        Console.WriteLine("2 - Euro");
        Console.WriteLine("3 - Real");
        Console.WriteLine("4 - Iene");
        string moedaDestino = Console.ReadLine();

        // Caso a moeda de origem não seja em dolar
        decimal fatorCotacao = 1;

        if (moedaOrigem == "2")
            fatorCotacao = euro;
        else if (moedaOrigem == "3")
            fatorCotacao = real;
        else if (moedaOrigem == "4")
            fatorCotacao = iene;

        //Converte o valor inicial para dolar
        decimal totalDolar = quantidadeMoeda * fatorCotacao;

        //Converte de dolar para moeda destino
        decimal valorConvertido = 0;

        if (moedaDestino == "1")
            valorConvertido = totalDolar;
        else if (moedaDestino == "2")
            valorConvertido = totalDolar * euro;
        else if (moedaDestino == "3")
            valorConvertido = totalDolar * real;
        else if (moedaDestino == "4")
            valorConvertido = totalDolar * iene;

        // Limpa a tela
        Console.Clear();

        // Escolhe a cor
        Console.ForegroundColor = ConsoleColor.Green;
        Console.BackgroundColor = ConsoleColor.White;

        // Resultado
        Console.WriteLine("Valor de cotação convertido:");
        Console.WriteLine(valorConvertido.ToString("C"));

        Console.WriteLine("Aperte qualque tecla para continuar...");
        Console.ReadKey();
    }
    // Condição de acordo com a opção 3
    else if (resposta == "3")
    {
        //Saída
        Console.WriteLine("Aperte qualque tecla para sair:");
        Console.ReadKey();
    }
    else
    {
        //"Opcao inválida" caso a pessoa coloque uma resposta inmválida
        Console.WriteLine("Opção inválida!");
        Console.WriteLine("Aperte qualque tecla para continuar...");
        Console.ReadKey();
    }

  // Encerra o laço caso a resposta seja a opção 3   
} while (resposta != "3");