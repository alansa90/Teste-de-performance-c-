using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan_sa_TP3
{
    class Program
    {
        static void Main(string[] args)
        {
            string var;

            Metodos.CarregarMenuPrincipal();
            var = Console.ReadLine();
            Metodos.MenuOpcoes(new List<Lista>(), var
                );

            Console.ReadKey();
        }
    }
}
