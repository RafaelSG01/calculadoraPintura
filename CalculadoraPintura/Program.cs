using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPintura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a largura do cômodo?");
            double largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a profundidade do cômodo?");
            double profundidade = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a altura do cômodo?");
            double altura = double.Parse(Console.ReadLine());

            Calculadora calculadora = new Calculadora();

            Console.WriteLine("A área das paredes é: ");
            Console.WriteLine(calculadora.CalcularAreaParedes(largura, profundidade, altura));

            Console.WriteLine("A área do teto é: ");
            Console.WriteLine(calculadora.CalcularAreaTeto(largura, profundidade));

            Console.WriteLine("A litragem de tinta necessária é: ");
            Console.WriteLine((calculadora.CalcularLitragem()));

            Console.ReadLine();
        }
    }
}
