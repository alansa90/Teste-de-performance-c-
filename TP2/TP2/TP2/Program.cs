using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            string var;

            Metodos.CarregarMenuPrincipal();
            var = Console.ReadLine();
            Metodos.MenuOpcoes(new List<Lista>(), var);
            Console.ReadKey();

        }
    }
}
