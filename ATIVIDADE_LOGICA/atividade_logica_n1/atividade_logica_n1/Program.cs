using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_logica_n1
{
    class Program
    {
        static void Main(string[] args)
            
        {
            Console.WriteLine("3º PERIODO - DESENVOLVIMENTO DE SISTEMAS - WESNEY BRAZ");
            Console.WriteLine("QUESTÃO NÚMERO 1º");

            float LITRO = 0;
            float TEMPO = 0;
            int TEMPO1 = 0;
            float TEMPO2 = 0;
            float DISTANCIA = 0; 
            float VELOCIDADE = 0;
            int loop1 = 1;

            //-------------------------------------------------------------------------//
            while (loop1 == 1)
            {
                Console.WriteLine("INFORME O TEMPO GASTO NA VIAGEM");
                Console.WriteLine("PRIMEIRO AS HORAS E DEPOIS OS MINUTOS");
                Console.WriteLine("HORAS");
                TEMPO1 = int.Parse(Console.ReadLine());
                Console.WriteLine("MINUTOS");
                TEMPO2 = int.Parse(Console.ReadLine());
                TEMPO = TEMPO1 + (TEMPO2 / 60);
         
                Console.WriteLine("INFORME A VELOCIDADE MÉDIA DURANTE A VIAGEM EM KM/H");
                VELOCIDADE = int.Parse(Console.ReadLine());
                DISTANCIA = VELOCIDADE * TEMPO;
                LITRO = DISTANCIA / 12;


                Console.WriteLine("A VELOCIDADE MÉDIA FOI: {0} KM/H ", VELOCIDADE);
                Console.WriteLine("O TEMPO GASTO FOI: {0} HR ", TEMPO);
                Console.WriteLine("A DISTANCIA PERCORRIDA FOI: {0} KM", DISTANCIA);
                Console.WriteLine("A QUANTIDADE DE LITROS GASTO FOI: {0} L", LITRO);



                Console.WriteLine("DIGITE NÚMERO 1 PARA REPETIR O CÁLCULO");
                Console.WriteLine("DIGITE OUTRO NÚMERO PARA SAIR");
                loop1 = int.Parse(Console.ReadLine());

            }
        }
    }
}
