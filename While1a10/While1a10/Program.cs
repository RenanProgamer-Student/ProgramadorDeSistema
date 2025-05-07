Console.WriteLine("Bem-vindo!");

Console.WriteLine("");

/*
int i = 0;//Inicialização
//condição
while (i <= 10)
{
    
    Console.WriteLine(i);
    i++; //incremento de 1 em 1
}
for  (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
*/
int num;

while (true)
{
    Console.Write("Digite um número para fazer a tabuada (ou digite 'sair' para encerrar): ");
    string input = Console.ReadLine();

    if (input.Trim().ToLower() == "sair")
    {
        Console.WriteLine("Encerrando o programa.");
        return;
    }

    if (int.TryParse(input, out num))
        break;

    Console.WriteLine("Erro: você deve digitar um número inteiro.\n");
}

Console.WriteLine();
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{num} * {i} = {num * i}");
}

