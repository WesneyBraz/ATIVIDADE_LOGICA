using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_logica_n13
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] A = new int[11];
            int[] B = new int[11];


            int j = 1;
            int AUX = 0;
            int loop1 = 1;

            Console.WriteLine("3º PERIODO - DESENVOLVIMENTO DE SISTEMAS - WESNEY BRAZ");
            Console.WriteLine("QUESTÃO NÚMERO 13º");
            Console.WriteLine("");

            //------------------------------------------------------------------------------------//
            while (loop1 == 1)
            {
                Console.WriteLine("DIGITE 10 NÚMEROS INTEIROS");
                Console.WriteLine("NÚMEROS IMPARES SERÃO SOMADO COM CINCO");
                Console.WriteLine("NÚMEROS PARES SERÃO MULTIPLICAR POR CINCO");


                for (int i = 1; i < 11; i++)
                {

                    Console.WriteLine("DIGITE O {0}º NÚMERO ", i);
                    A[i] = int.Parse(Console.ReadLine());
                    AUX = A[i] % 2;

                    if (AUX == 0)
                    {
                        B[i] = 5 * A[i];
                    }
                    else
                    {
                        B[i] = 5 + A[i];
                    }
               
                }
                for (int i1 = 1; i1 < 11; i1++)
                {
                    Console.WriteLine(" NÚMEROS DIGITADOS: Nº{0} - {1} ",i1, A[i1]);
                    Console.WriteLine(" ");
                }
                for (int i1 = 1; i1 < 11; i1++)
                {
                    Console.WriteLine(" RESULTADO DOS CÁLCULOS EFETUADOS: Nº{0} - {1} ", i1, B[i1]);
                    Console.WriteLine(" ");
                }

                Console.WriteLine("DIGITE NÚMERO 1 PARA REPETIR O CÁLCULO");
                Console.WriteLine("DIGITE OUTRO NÚMERO PARA SAIR");
                loop1 = int.Parse(Console.ReadLine());


            }

        }
    }
}
