using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_logica_n3
{
    class Program
    {
        static void Main(string[] args)
        {


            int N1,N2,N3,N4 = 0;
            int[] N = new int[5];
            int A, B, C = 0;
            int AUX1 = 0;
            int AUX2 = 0;

            int loop1 = 1;

            Console.WriteLine("3º PERIODO - DESENVOLVIMENTO DE SISTEMAS - WESNEY BRAZ");
            Console.WriteLine("QUESTÃO NÚMERO 5º");
            Console.WriteLine("");

            //------------------------------------------------------------------------------------//
            while (loop1 == 1)
            {
                Console.WriteLine("DIGITE 4 NUMETOS INTEIROS  ");
                for (int i = 1; i < 5; i++)
                {
                    Console.WriteLine("DIGITE O {0}º NÚMERO ", i);
                    N[i] = int.Parse(Console.ReadLine());
                    
                    AUX1 = N[i] % 2;
                    AUX2 = N[i] % 3;


                    if ((AUX1 == 0) && (AUX2 == 0))
                    {
                        Console.WriteLine("O NÚMERO {0} EH DIVISIVEL POR 2 E 3", N[i]);
                    }
                    else
                    {
                        Console.WriteLine("O NÚMERO {0} NÃO EH DIVISIVEL POR 2 E 3", N[i]);
                    }

                }
              
                Console.WriteLine("DIGITE NÚMERO 1 PARA REPETIR O CÁLCULO");
                Console.WriteLine("DIGITE OUTRO NÚMERO PARA SAIR");
                loop1 = int.Parse(Console.ReadLine());


            }
        }
    }
}
