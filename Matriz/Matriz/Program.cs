Console.WriteLine("Bem-vindo à MATRIZ Senac!");
Console.Write("Digite seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine($"Bem-vindo, {nome}! Vamos conhecer matriz?\n");

// Exibe a matriz fixa 5x10
ExibirMatrizFixa();

Console.WriteLine("\nEstamos usando uma 'estrutura de repetição' para contar de 1 a 50.");
Console.WriteLine("Usando o FOR podemos repetir até dar o resultado que queremos.");
Console.WriteLine("Mas como visto já é um valor fixo, vamos testar um valor do seu agrado?\n");

// Loop do programa principal
while (true)
{
    if (DesejaContinuar())
    {
        Console.Clear();
        int opcao = EscolherOpcao();
        if (opcao == 1)
            ExecutarMatrizPersonalizada();
        else if (opcao == 2)
            RandomNumb();
    }
    else
    {
        Console.WriteLine("\nEncerrando o programa. Até mais!");
        break;
    }
}

static int EscolherOpcao()
{
    while (true)
    {
        Console.WriteLine("Escolha a opção para seguir:");
        Console.WriteLine("1 - Executar Matriz Personalizada");
        Console.WriteLine("2 - Gerar Matriz com Números Aleatórios");
        Console.Write("Digite 1 ou 2: ");
        string entrada = Console.ReadLine();

        if (entrada == "1")
            return 1;
        else if (entrada == "2")
            return 2;
        else
            Console.WriteLine("Opção inválida. Por favor, digite 1 ou 2.\n");
    }
}


// Exibe matriz 5x10 fixa
static void ExibirMatrizFixa()
{
    int[,] matriz = new int[5, 5];

    for (int linha = 0; linha < 5; linha++)
    {
        int cont = linha * 10 + 1;
        for (int coluna = 0; coluna < 5; coluna++)
        {
            matriz[linha, coluna] = cont++;
        }
    }

    for (int linha = 0; linha < 5; linha++)
    {
        for (int coluna = 0; coluna < 5; coluna++)
        {
            Console.Write($"{matriz[linha, coluna],3} ");
        }
        Console.WriteLine("");
    }

    int soma = 0;

    for (int linha = 0; linha < 5; linha++)
    {
        for (int coluna = 0; coluna < 5; coluna++)
        {
            soma += matriz[linha, coluna];
        }
    }

    Console.WriteLine($"\nA soma de tudo deu {soma}");
}

// Executa lógica da matriz personalizada
static void ExecutarMatrizPersonalizada()
{
    int linhas = LerNumeroPositivo("Digite o número de linhas:");
    int colunas = LerNumeroPositivo("Digite o número de colunas:");

    int[,] matriz = new int[linhas, colunas];
    int cont = 1;

    for (int linha = 0; linha < linhas; linha++)
    {
        for (int coluna = 0; coluna < colunas; coluna++)
        {
            matriz[linha, coluna] = cont++;
        }
    }

    Console.WriteLine("\nMatriz personalizada:");
    for (int linha = 0; linha < linhas; linha++)
    {
        for (int coluna = 0; coluna < colunas; coluna++)
        {
            Console.Write($"{matriz[linha, coluna],3} ");
        }
        Console.WriteLine();
    }

    Console.WriteLine("\nLegal né? Vamos para mais um teste?");
}

// Pergunta se deseja continuar e só sai com resposta válida
static bool DesejaContinuar()
{
    while (true)
    {
        Console.Write("Deseja continuar? (Y/N): ");
        ConsoleKeyInfo tecla = Console.ReadKey(true);

        if (tecla.Key == ConsoleKey.Y)
            return true;
        else if (tecla.Key == ConsoleKey.N)
            return false;
        else
            Console.WriteLine("Tecla inválida. Pressione apenas Y ou N.\n");
    }
}

// Lê e valida um número positivo
static int LerNumeroPositivo(string mensagem)
{
    int numero;
    while (true)
    {
        Console.Write($"{mensagem} ");
        string entrada = Console.ReadLine();

        if (int.TryParse(entrada, out numero) && numero > 0)
            return numero;
        else
            Console.WriteLine("Por favor, digite um número inteiro positivo.");
    }
}

static void RandomNumb()
{
    Random r = new Random();
    int[,] matriz = new int[r.Next(1, 101), r.Next(1, 101)];
    int soma = 0;
    int cont = 1;

    //faz o negocio
    for (int linha = 0; linha < 5; linha++)
    {
        for (int coluna = 0; coluna < 5; coluna++)
        {
            matriz[linha, coluna] = r.Next(1, 101);
        }
    }

    //exibe o negocio
    for (int linha = 0; linha < 5; linha++)
    {
        for (int coluna = 0; coluna < 5; coluna++)
        {
            Console.Write($"{matriz[linha, coluna],3} ");
        }
        Console.WriteLine("");
    }

    //soma
    for (int linha = 0; linha < 5; linha++)
    {
        for (int coluna = 0; coluna < 5; coluna++)
        {
            soma += matriz[linha, coluna];
        }
    }

    double media = soma / 25.0;

    Console.WriteLine($"\nA soma de tudo deu {soma}");
    Console.WriteLine($"\nA Média é de: {media}");
}