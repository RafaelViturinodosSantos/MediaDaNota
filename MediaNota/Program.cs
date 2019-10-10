using System;
using System.Globalization;

namespace MediaNota
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a;

            Console.WriteLine("Olá prezado aluno !");
            Console.Write("Informe seu nome completo: ");
            string nome = Console.ReadLine();
            Console.Write("Informe seu número da matrícula: ");
            int matricula = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor da primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe o valor da segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            a = new Aluno(nome, matricula, nota1, nota2);

            Console.WriteLine(a);


            if (a.Media() >= 6.0)
            {
                Console.WriteLine("Você foi aprovado !");
            }
            else
            {
                Console.WriteLine("Você foi reprovado !");
            }
            Console.ReadLine();
        }
    }
}
