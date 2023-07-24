using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabla_de_Multiplicar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b, a;
            Console.WriteLine("ingrese un numero");            
            a=int.Parse(Console.ReadLine());
            for (int i = 0; i < 10; i++) {
                b = a * (i + 1);
                Console.WriteLine(a + "x" + (i + 1) + "=" + b);
                
            }
            Console.WriteLine("precione cuialquier tecla para salir");
            Console.ReadKey();


        }
    }
}
