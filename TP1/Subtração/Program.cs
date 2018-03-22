using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtração
{
    class Program
    {
        static void Main(string[] args)
        {
            int num01, num02, subtracao;
            Console.WriteLine("Aplicação para efetuar a subtração de dois números!");

            Console.WriteLine("Digite um numero");
            var num1 = Console.ReadLine();
            Console.WriteLine("Digite um numero");
            var num2 = Console.ReadLine();

            num01 = Int32.Parse(num1);
            num02 = Int32.Parse(num2);
            subtracao = num01 - num02;


            Console.WriteLine("Resultado da subtração dos numeros " + num01.ToString() + " e " + num02.ToString() + " é: " + subtracao.ToString());
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();


        }
    }
}
