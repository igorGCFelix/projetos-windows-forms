using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, media;
            Console.WriteLine("Digite a nota da atividade com peso '2' na média: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota da atividade com peso '3' na média: ");
            nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota da atividade com peso '5' na média: ");
            nota3 = double.Parse(Console.ReadLine());

            media =( (nota1 * 2) + (nota2 * 3) + (nota3 * 5))/10;
            Console.WriteLine("A nota da média final deste alunos é: "+media);
            Console.ReadKey();
        }
    }
}
