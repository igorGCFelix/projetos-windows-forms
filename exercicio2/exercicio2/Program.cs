using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int numEleitores, brancos, nulos, validos, total;
            double pBrancos, pNulo, pValidos;
            Console.WriteLine("Digite o número total de eleitores: ");
            numEleitores = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número total de votos brancos: ");
            brancos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número total de votos nulos: ");
            nulos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número total de votos válidos: ");
            validos = int.Parse(Console.ReadLine());

            pBrancos = (brancos * 100) / numEleitores;
            pNulo = (nulos * 100) / numEleitores;
            pValidos = (validos * 100) / numEleitores;

            total = brancos+nulos+validos;

            if (total > numEleitores) {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Atenção, você digitou algum dado incorreto, verifique as informações anteriores e tente novamente.");
            }

            else{
                Console.WriteLine("A baixo está os percentuais votos: \n Número de eleitores: " + numEleitores + " \n Percentual de votos em branco: " + pBrancos + "% \n Percentual de votos nulos: " + pNulo + "% \n Percentual de votos válidos: " + pValidos + "%");
            }
            Console.ReadKey();
        }
    }
}
