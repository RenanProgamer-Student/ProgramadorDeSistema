//Crie um sistema que leia o capital, a taxa e o tempo para calcular o juros simples

double c;
double i;
double t;
double juros;
double montante;

Console.WriteLine("Bem-Vindo ao Curso Programador de sistema do SENAC");

Console.WriteLine("Por favor insire o seu nome como aluno");
//String nome para digitar o nome com o ReadLine
String nome = Console.ReadLine();

Console.WriteLine($"Olá {nome}, Vamos ao exercícios de Jurus Simples");

Console.WriteLine("Vamos comçear com a o Capital: ");
//Double c para guardar o valro da capital
c = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Agora Me diga a sua Taxa: ");
//double i para guardar o vlot da Taxa
i = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Agora vamos para o tempo");
//double t para guardar o Tempo
t = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Muito bem, Vamos calcular oo Juros");
//doubles Juros para guradar e calcular o Juros
juros = c * i * t;

Console.WriteLine($"O juros vai ser de: {Math.Round(juros, 2)}");

montante = c + juros;

Console.WriteLine($"O seu montante será de: {Math.Round(montante, 2)}");