using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_logica_n6
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
                int numero = 0;
                int maior = 0;
                int menor = 0;
                int loop2 = 0;

                Console.WriteLine("DIGITE 5 NÚMEROS INTEIROS");

                while (loop2 < 5)
                {
                    Console.WriteLine("DIGITE UM NÚMERO ");
                    numero = int.Parse(Console.ReadLine());

                    ////////////////--MAIOR--//////////////////
                    
                    if (numero >= maior) 
                    {
                        maior = numero;
                    }

                    ////////////////--MENOR--//////////////////

                    if (numero <= menor)
                    {
                        menor = numero;
                    }
                    if (loop2<=0) 
                    {
                        menor = numero;
                    }
                    ///////////////////////////////////////////
                    loop2++;
                }
                
                Console.WriteLine("MAIOR {0}", maior);
                Console.WriteLine("MENOR {0}", menor);

                Console.WriteLine("DIGITE NÚMERO 1 PARA REPETIR O CÁLCULO");
                Console.WriteLine("DIGITE OUTRO NÚMERO PARA SAIR");
                loop1 = int.Parse(Console.ReadLine());
            }
            
        }
    }
}

    