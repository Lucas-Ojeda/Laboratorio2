using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2_Practicos_Sencillos_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Console.WriteLine("Con While: ");
            while (a!=101) {
                Console.WriteLine(a);
                a++;
            }
            Console.WriteLine("---------------");
            Console.WriteLine("Con for");
            Console.WriteLine("---------------");
            for (int i = 0; i < 101; i++) { 
                Console.WriteLine(i);
            }
            Console.WriteLine("---------------");
            Console.WriteLine("Con do-while");
            Console.WriteLine("---------------");
            a = 0;
            do {
                
                Console.WriteLine(a);
                a++;
            } while (a!=101);

            Console.ReadKey();



        }
    }
}
