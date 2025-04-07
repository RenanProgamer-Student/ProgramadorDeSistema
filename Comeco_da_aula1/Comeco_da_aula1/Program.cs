// See https://aka.ms/new-console-template for more information
Console.WriteLine("Senac");

/*
Console.WriteLine("Digite o primeiro numero: ");
//ira converter string para int e guardar.
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o primeiro numero: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int total = n1 + n2;
Console.WriteLine($"Total: {total}");
*/

//Faça um sistema que leia a quantidade de maçãs e o preço da unidade e calcule o total;
Console.WriteLine("Qual seu nome?");
String nome = Console.ReadLine();
Console.WriteLine($"Olá {nome} quantas maçãs você tem?");

int qtdmacas = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("O preço delas?");
double preco = Convert.ToDouble(Console.ReadLine());

double total  = qtdmacas * preco;
Console.WriteLine($"Total dos preços das Maçãs: {total}");