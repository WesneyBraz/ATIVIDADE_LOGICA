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

            int[] n = new int[4];
            int s =  0;
            int m = 0;
            int loop1 = 1;

            Console.WriteLine("3º PERIODO - DESENVOLVIMENTO DE SISTEMAS - WESNEY BRAZ");
            Console.WriteLine("QUESTÃO NÚMERO 3º");
            Console.WriteLine("");

            //------------------------------------------------------------------------------------//
            while (loop1 == 1)
            {
                Console.WriteLine("DIGITE 4 NUMETOS INTEIROS  ");
                Console.WriteLine("DIGITE O 1º NÚMERO ");
                n[0] = int.Parse(Console.ReadLine());
                Console.WriteLine("DIGITE O 2º NÚMERO ");
                n[1] = int.Parse(Console.ReadLine());
                Console.WriteLine("DIGITE O 3º NÚMERO ");
                n[2] = int.Parse(Console.ReadLine());
                Console.WriteLine("DIGITE O 4º NÚMERO ");
                n[3] = int.Parse(Console.ReadLine());

             
                s = n[1] + n[3];
                m = n[0] * n[2];


                Console.WriteLine("OS NÚMEROS DIGITADOS FORAM: {0} - {1} - {2} - {3} ", n[0], n[1], n[2], n[3]);
                Console.WriteLine("RESULTADO DA SOMA ENTRE OS NÚMEROS {0} E {1}  EH: {2} ", n[1], n[3], s);
                Console.WriteLine("RESULTADO DA MULTIPLICAÇÃO ENTRE OS NÚMEROS {0} E {1}  EH: {2} ",n[0], n[2], m);

                Console.WriteLine("DIGITE NÚMERO 1 PARA REPETIR O CÁLCULO");
                Console.WriteLine("DIGITE OUTRO NÚMERO PARA SAIR");
                loop1 = int.Parse(Console.ReadLine());


            }
        }
    }
}
