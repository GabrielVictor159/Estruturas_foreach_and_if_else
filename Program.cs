using System;
using Estruturas_forEach_and_if_else.model; // Adicione esta linha para importar o namespace onde a classe Alunos está definida

class Program
{
    static void Main(string[] args)
    {
        Alunos[] alunos = new Alunos[]
      {
            new Alunos("Sophia", new int[] { 90, 86, 87, 98, 100, 94, 90 }),
            new Alunos("Andrew", new int[] { 92, 89, 81, 96, 90, 89 }),
            new Alunos("Emma", new int[] { 90, 85, 87, 98, 68, 89, 89, 89 }),
            new Alunos("Logan", new int[] { 90, 95, 87, 88, 96, 96 })
      };

        Console.WriteLine("Student\t\tExam Score\tOverall\tGrade\tExtra Credit");
        Console.WriteLine("--------------------------------------------------");

        foreach (Alunos aluno in alunos)
        {
            Console.WriteLine($"{aluno.Nome}\t\t{aluno.NotaExame}\t\t{aluno.NotaFinal}\t{aluno.Mencao}\t{aluno.CreditoExtra}");
        }
    }
}
