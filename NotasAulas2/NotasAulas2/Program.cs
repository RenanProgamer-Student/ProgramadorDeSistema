//cire um sistema que calcule que leia 3 notas;

double n1;
double n2;
double n3;
//double n4;
double total;

Console.WriteLine("Bem-Vindo ao Curso Programador de sistema do SENAC");
Console.WriteLine("Por favor insire o seu nome como aluno");
//String nome para digitar o nome com o ReadLine
String nome = Console.ReadLine();

Console.WriteLine($"Olá {nome}, vamos ver suas notas");

Console.WriteLine("Qual foi sua primeira nota: ");
n1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Qual foi sua segunda nota: ");
n2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Qual foi sua terceira nota: ");
n3 = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Qual foi sua quarta nota: ");
//n4 = Convert.ToDouble(Console.ReadLine());

//calcule a soma das notas

total = n1 + n2 + n3;

//e calcule a média das notas

double media = total / 3;
//Math.Round(media, 1) para arredondar as casas deciamis.

Console.WriteLine($"Sua média foi de {Math.Round(media, 1)}");

    if  (media >= 7)
    {
        Console.WriteLine("Você foi Aprovado");
    }
    else if (media == 6)
    {
        Console.WriteLine("Você irá ter que fazer Recuperação");
    }
    else
    {
        Console.WriteLine("Você foi Reprovado");
    }