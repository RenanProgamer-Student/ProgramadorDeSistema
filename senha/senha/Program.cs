using System.Xml;

Console.WriteLine("Bem-Vindo ao SENAC");
/*
int nota;
do
{
    Console.WriteLine("Digite uma nota");
    nota = Convert.ToInt32(Console.ReadLine());
}
while (nota < 0 || nota > 10);

String usuario, senha;

do
{
    Console.Write("Usuario: ");
    usuario = Console.ReadLine();
    Console.Write("Senha: ");
    senha = Console.ReadLine();
}
while (senha != "123" || usuario != "Senac");
*/

bool ficar = true;
do
{
    int opc;
    int n1 = 0;
    int n2 = 0;
    do
    {
        Console.WriteLine("Digite: \n1. Para somar\n2. Para subtrair\n3. Para sair");
        opc = Convert.ToInt32(Console.ReadLine());

    }
    while (opc < 1 || opc > 3);
        if (opc != 3 )
        {
            Console.WriteLine("Digite o primeiro número");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            n2 = Convert.ToInt32(Console.ReadLine());
        }


        switch (opc)
        {
            case 1: Console.WriteLine($"total: {n1 + n2}");
                break;
            case 2: Console.WriteLine($"total: {n1 - n2}");
                break;
            case 3: Console.WriteLine($"Saindo! {ficar = false}");
                break;
        }

}
while (ficar == true);