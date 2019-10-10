using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace MediaNota
{
    class Aluno
    {
        public string Nome { get; set; }
        public int Matricula { get; private set; }
        public double Nota1 { get; private set; }
        public double Nota2 { get; private set; }

        public Aluno(string nome, int matricula, double nota1, double nota2)
        {
            Nome = nome;
            Matricula = matricula;
            Nota1 = nota1;
            Nota2 = nota2;
        }
        public double Media()
        {
            return (double)(Nota1 + Nota2) / 2.0;
        }

        public override string ToString()
        {
            return Nome + " da matrícula de número " + Matricula + " a média da sua nota foi "
                + Media().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
