using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplicação
{
    class Program
    {
        static void Main(string[] args)
        {
            int num01, num02, produto;
            Console.WriteLine("Aplicação para efetuar a Multiplicação de dois números!");

            Console.WriteLine("Digite um numero");
            var num1 = Console.ReadLine();
            Console.WriteLine("Digite um numero");
            var num2 = Console.ReadLine();

            num01 = Int32.Parse(num1);
            num02 = Int32.Parse(num2);
            produto = num01 * num02;

            Console.WriteLine("Resultado da multiplicação dos numeros " + num1 + " e " + num2 + " é: " + produto.ToString());
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
