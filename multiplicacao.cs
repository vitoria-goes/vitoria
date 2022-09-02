using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula01_soma
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero01, numero02, resultado;

            Console.WriteLine("insira o primeiro número");
            numero01 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("insira o segundo número");
            numero02 = Convert.ToInt32(Console.ReadLine());

            resultado = numero01 / numero02;

            Console.WriteLine("seu resultado é; " + resultado);

            Console.ReadKey();


        }
    }
}
