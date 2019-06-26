using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Classes
{
    // Terceiro Programa
    class RegistroNotasAluno
    {
        public string Nome;
        public double P1;
        public double P2;
        public double P3;

        //Cálculo da soma das três notas que o aluno tirou
        public double NotaFinal()
        {
            return  P1 + P2 + P3;
        }

        //Se a Nota final for maior ou igual a 60, que é a media, retorna verdadeiro, se não é falso
        public bool Aprovado()
        {
            if(NotaFinal() >= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // E se for falso lá encima, ele vem para cá, e retorna o valor da media, 60 menos sua nota final
        public double Reprovado()
        {
            if (Aprovado())
            {
                return 0;
            }
            else
            {
                return 60 - NotaFinal();    
            }
        }
    

    }
}
