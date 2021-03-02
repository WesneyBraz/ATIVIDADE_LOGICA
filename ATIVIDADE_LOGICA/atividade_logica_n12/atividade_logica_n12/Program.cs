using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_logica_n12
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] A = new int[11];
            int SOMA = 0;
            int AUX = 0;
            int loop1 = 1;

            Console.WriteLine("3º PERIODO - DESENVOLVIMENTO DE SISTEMAS - WESNEY BRAZ");
            Console.WriteLine("QUESTÃO NÚMERO 12º");
            //------------------------------------------------------------------------------------//
            while (loop1 == 1)
            {
                Console.WriteLine("");
                Console.WriteLine("DIGITE 10 NÚMEROS INTEIROS");


                for (int i = 1; i < 11; i++)
                {
                    Console.WriteLine("DIGITE O {0}º NÚMERO ", i);
                    A[i] = int.Parse(Console.ReadLine());
                    AUX = A[i] % 2;

                    if(AUX!=0)
                    {
                        SOMA = SOMA + A[i];
                    }
                    
                }

                Console.WriteLine(" O RESULTADO DA SOMA DOS VALORES IMPARES EH: {0}", SOMA);
                Console.WriteLine(" ");
                SOMA = 0;


                Console.WriteLine("DIGITE NÚMERO 1 PARA REPETIR O CÁLCULO");
                Console.WriteLine("DIGITE OUTRO NÚMERO PARA SAIR");
                loop1 = int.Parse(Console.ReadLine());


            }

        }
    }
}
