using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adição
{
    class Program
    {
        static void Main(string[] args)
        {
            int num01, num02, soma;
            Console.WriteLine("Aplicação para efetuar a soma de dois números!");

            Console.WriteLine("Digite um numero");
            var num1 = Console.ReadLine();
            Console.WriteLine("Digite um numero");
            var num2 = Console.ReadLine();

            num01 = Int32.Parse(num1);
            num02 = Int32.Parse(num2);
            soma = num01 + num02;

            Console.WriteLine("Resultado da soma dos numeros " + num1 + " e " + num2 + " é: " + soma.ToString());
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
