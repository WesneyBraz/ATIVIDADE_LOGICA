using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_logica_n11
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] A = new int[11];
            int[] B = new int[11];

            int loop1 = 1;

            Console.WriteLine("3º PERIODO - DESENVOLVIMENTO DE SISTEMAS - WESNEY BRAZ");
            Console.WriteLine("QUESTÃO NÚMERO 11º");
            Console.WriteLine("");

            //------------------------------------------------------------------------------------//
            while (loop1 == 1)
            {
                Console.WriteLine("DIGITE 10 NÚMEROS INTEIROS");


                for (int i = 1; i < 11; i++)
                {
                    Console.WriteLine("DIGITE O {0}º NÚMERO ", i);
                    A[i] = int.Parse(Console.ReadLine());
                    B[i]=A[i] * 3;
                }


                for (int i = 0; i < 11; i++)
                {
                    if (i > 0)
                    {

                        Console.WriteLine(" NÚMERO DIGITADO: {0} - MULTIPLICADO POR 3 O RESULTADO EH: {1}", A[i], B[i]);
                        Console.WriteLine(" ");

                    }

                }


                Console.WriteLine("DIGITE NÚMERO 1 PARA REPETIR O CÁLCULO");
                Console.WriteLine("DIGITE OUTRO NÚMERO PARA SAIR");
                loop1 = int.Parse(Console.ReadLine());


            }

        }
    }
}
