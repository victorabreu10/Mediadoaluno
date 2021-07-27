using System;

namespace ExerciciosdeRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Media dos alunos");

            float soma = 0;
            float media = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite a nota do aluno" + i + ":");
                float nota = 0;
                float.TryParse(Console.ReadLine(), out nota);
                soma += nota;
            }
            media = soma / 5;
            Console.WriteLine("Média é igual a:" + media);
        }
    }
}
