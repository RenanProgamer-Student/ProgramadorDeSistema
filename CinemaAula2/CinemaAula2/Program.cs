Console.WriteLine("Bem-Vindo ao Curso Programador de sistema do SENAC");
Console.WriteLine("Por favor insire o seu nome como aluno");
//String nome para digitar o nome com o ReadLine
String nome = Console.ReadLine();

//Ler o preço dos ingresso e quantidade ventidas

Console.WriteLine("Em uma sala de cinema qual o valor do Ingresso Inteiro: ");
double precoINT = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Quantos Ingressos Inteiros foram vendindos: ");
int qtdINT = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Quantos Ingressos Meias foram vendindos: ");
int qtdMeias = Convert.ToInt32(Console.ReadLine());

//Ler o preço do ingresso (interia), qtd vendidos, qtd de ingressos (interio), preço do ingresso (meia), qtd ingresso (meia), total faturado

double precoMeia = precoINT / 2;

double total = precoINT * qtdINT + precoMeia * qtdMeias;
Console.WriteLine($"O total de faturamente da sala foi de: {Math.Round(total, 2)}R$");