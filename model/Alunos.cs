using System;

namespace Estruturas_forEach_and_if_else.model
{
    class Alunos
    {
        public string Nome { get; set; }
        private decimal _notaExame;
        public decimal NotaExame
        {
            get { return _notaExame; }
            set { _notaExame = Math.Round(value, 2); }
        }
        private decimal _notaFinal;
        public decimal NotaFinal
        {
            get { return _notaFinal; }
            set { _notaFinal = Math.Round(value, 2); }
        }
        private string _creditoExtra;
        public string CreditoExtra
        {
            get { return _creditoExtra; }
            set { _creditoExtra = value; }
        }

        public string Mencao
        {
            get
            {
                decimal grade = NotaFinal;

                if (grade >= 97)
                    return "A+";
                else if (grade >= 93)
                    return "A";
                else if (grade >= 90)
                    return "A-";
                else if (grade >= 87)
                    return "B+";
                else if (grade >= 83)
                    return "B";
                else if (grade >= 80)
                    return "B-";
                else if (grade >= 77)
                    return "C+";
                else if (grade >= 73)
                    return "C";
                else if (grade >= 70)
                    return "C-";
                else if (grade >= 67)
                    return "D+";
                else if (grade >= 65)
                    return "D";
                else
                    return "F";
            }
        }

        public Alunos(string nome, int[] notas)
        {
            Nome = nome;

            foreach (int nota in notas)
            {
                NotaExame += nota;
            }
            NotaExame = (NotaExame / notas.Length);

            NotaFinal = (NotaExame + (NotaExame * 0.0399m));
            decimal a = NotaFinal - NotaExame;
            CreditoExtra = $"({Math.Round(a, 2)} pts)";
        }
    }
}
