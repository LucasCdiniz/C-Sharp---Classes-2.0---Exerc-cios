    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Primeiro Programa - Classe Retangulo
            // instancianciação 
            /*Retangulo r = new Retangulo();
            // chamada das váriáveis da Classe Retângulo
            Console.Write("Informe a Largura de seu Retângulo: ");
            r.Largura = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Informe a Altura de seu Retângulo: ");
            r.Altura = double.Parse(Console.ReadLine());
            // chamada dos Métodos da Classe Retangulo
            Console.WriteLine("AREA = " + r.Area().ToString("F2",CultureInfo.InvariantCulture));

            Console.WriteLine("PERÍMETRO = " + r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("DIAGONAL = " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));*/

            // Segundo Programa - Classe Funcionario

            /*Funcionario f = new Funcionario();

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f.Imposto = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            //override
            Console.WriteLine("Funcionário: " + f);

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double pct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            f.AumentaSalario(pct);
            Console.WriteLine("Dados Atualizados: " + f);*/


            // Terceiro Programa - Classe RegistroNotasAluno

            /*RegistroNotasAluno ra = new RegistroNotasAluno();
            //Pega os dados inseridos
            Console.Write("Nome do Aluno: ");
            ra.Nome = Console.ReadLine();
            Console.Write("Informe a nota da P1: ");
            ra.P1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Informe a nota da P2: ");
            ra.P2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe a nota da P3: ");
            ra.P3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            // Mostra o resultado da soma das notas das três provas
            Console.WriteLine("Nota Final = " + ra.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            //Se a nota for maior que a média (60) é Aprovado
            if (ra.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else // Se a nota final for menor que a media é Reprovado e mostra a quantidade de nota que faltou para você ser aprovado
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("Faltaram "
                    + ra.Reprovado().ToString("F2",CultureInfo.InvariantCulture)
                    + " Pontos.");
            }*/

        }
    }
}
