using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_logica_n7
{
    class Program
    {
        static void Main(string[] args)
        {

            int loop1 = 1;

            Console.WriteLine("3º PERIODO - DESENVOLVIMENTO DE SISTEMAS - WESNEY BRAZ");
            Console.WriteLine("QUESTÃO NÚMERO 6º");
            Console.WriteLine(" ");

            while (loop1 == 1)
            {
                float A = 0;
                float B = 0;
                float C = 0;

                Console.WriteLine("DIGITE 3 NÚMEROS REFERENTE AOS LADOS DE UM TRIANGULO");
                Console.WriteLine("DIGITE O 1º LADO ");
                A = float.Parse(Console.ReadLine());

                Console.WriteLine("DIGITE O 2º LADO ");
                B = float.Parse(Console.ReadLine());

                Console.WriteLine("DIGITE O 3º LADO ");
                C = float.Parse(Console.ReadLine());

               if((A==B) && (A==C))
                {
                    Console.WriteLine("O TRIANGULO É EQUILATERO ");
                }

               if (((A==B) && (A!=C)) || ((A==C) && (A!=B)) || (A!=C) && (C==B))
                {
                    Console.WriteLine("O TRIANGULO É ISÓSCELES ");
                }

               if((A!=B) && (A!=C) && (C!=B))
                {
                    Console.WriteLine("O TRIANGULO É ESCALENO ");
                }
                
                Console.WriteLine("DIGITE NÚMERO 1 PARA REPETIR O CÁLCULO");
                Console.WriteLine("DIGITE OUTRO NÚMERO PARA SAIR");
                loop1 = int.Parse(Console.ReadLine());
            }

        }
    }
}
