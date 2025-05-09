//Programa para calcular a média de quatro notas de dois alunos utilizando matriz e vetor.
import java.util.Scanner; //importação da classe Scanner

public class Matriz //Declação da calsse Matriz
{
    public static void main (String args[]) //Método principal para executar o programa
    {
        double[][] notas = new double[2][4];//Variável notas do tipo matriz
        double nota;//varivael nota do tipo double
        double[] media = new double [2];//variavel media do tipo vetor
        String[] nome = new String[2];//variavel nome do tipo vetor

        /*No porgama tem varivaeis notas do tipo Matriz que irá controlar as notas inseridas pelo usuário, temos 8 elementos, o mesmo que 2 vezes 4 = 8*/

        for (int i = 0; i < 2; i++) /* uma condição for que irá controlar a entrada de nome dos alunos, veja que será executado enquanto 'i' for menod que 2*/
        {
            System.out.println("Entre com o nome do aluno " + (i + 1) + ':');//Entrada dos anomes dos alunos
            nome[i] = new Scanner(System.in).nextLine();//Faz a leitrua dos nomes dos alunos

            //Nesse caso foi utilidado vetor, não é necessario uma entrada e leitura de código para cada aluno
        }
        System.out.println();//apenas para inserir um espaço em branco para dividir o terminal

        for (int i = 0; i < 2; i++) //For para controlar a entrada de dois alunos com 4 notas.
        {
            nota = 0;//a vairável é zerada para receber a nota do segundo aluno.
            System.out.print("nota "+(nome[i]+':'));

            for (int j = 0; j < 4; j++)//Aqui é a condição que irã controlar as 4 notas de cada aluno.
            {
                System.out.print("Nota "+(j+1)+':');//Exibe as notas de cada aluno
                nota += new Scanner(System.in).nextDouble();//Faz a leitura de cada nota de cada aluno. 
            }
            media[i] = nota /4;//A variavel média recebe a soma da varivael nota dividida por 4.
        }
        System.out.println();

        for (int i = 0; i < 2; i++) //Condição para controlar a exibição dea média de cada aluno
        {
            if (media[i] > 7)
            {
                System.out.println("Aluno "+ (nome[i])+" Aprovado, média: "+ (media[i]));//Exibe o nome do aluno aprovado caso a condição acima for vedadeira
            }
            else 
            {
                System.out.println("Aluno "+ (nome[i])+" Reprovado, média: "+ (media[i]));//Exibe o nome do aluno reprovado caso a condição acima for falsa
            }
        }
    }
}