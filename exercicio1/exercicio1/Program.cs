using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, resultado;
            Console.WriteLine("Digite sua idade em anos: ");
            idade = int.Parse(Console.ReadLine());

            resultado = idade * 365;
            Console.WriteLine("Sua idade em dias é: "+resultado);
            Console.ReadKey();
        }
    }
}
