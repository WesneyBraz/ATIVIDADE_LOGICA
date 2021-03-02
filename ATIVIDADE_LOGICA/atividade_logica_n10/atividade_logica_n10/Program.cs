using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_logica_n10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] NOME = new string[11];
            int loop1 = 1;

            Console.WriteLine("3º PERIODO - DESENVOLVIMENTO DE SISTEMAS - WESNEY BRAZ");
            Console.WriteLine("QUESTÃO NÚMERO 10º");
            Console.WriteLine("");

            //------------------------------------------------------------------------------------//
            while (loop1 == 1)
            {

                Console.WriteLine("DIGITE 10 NOMES");


                for (int i = 1; i < 11; i++)
                {
                    Console.WriteLine("DIGITE O {0}º NOME ", i);
                    NOME[i] = (Console.ReadLine());
                }
                for (int i = 0; i < 10; i++)
                {
                    if (i > 0)
                    {
                        Console.WriteLine(" OS NOMES DIGITADOS FORAM: {0}", NOME[i]);
                        Console.WriteLine(" ");
                    }
                }


                Console.WriteLine("DIGITE NÚMERO 1 PARA REPETIR O PROGRAMA");
                Console.WriteLine("DIGITE OUTRO NÚMERO PARA SAIR");
                loop1 = int.Parse(Console.ReadLine());


            }

        }
    }
}
