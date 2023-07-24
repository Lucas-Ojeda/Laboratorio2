using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Menu:");
            Console.WriteLine("1)Tabla de multiplicar");
            Console.WriteLine("2)suma de dos numeros");
            Console.WriteLine("3)resta de dos numeros");
            Console.WriteLine("4)multiplicacion de dos numeros");
            Console.WriteLine("5)division y resto de dos numeros");
            
            Console.WriteLine("<------------------------------>");
            Console.WriteLine("    elija una opcion");
            Console.WriteLine("<------------------------------>");
            c = Int32.Parse(Console.ReadLine());

            switch (c) { 
                case 1: Console.WriteLine("tabla de multiplicar");
                    Console.WriteLine("introduzca un numero");
                    a = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(a+"x"+0 + "="+a*0);
                    Console.WriteLine(a+"x"+1+ "="+a * 1);
                    Console.WriteLine(a+"x"+ 2+ "="+a * 2);
                    Console.WriteLine(a+"x"+ 3+ "="+a * 3);
                    Console.WriteLine(a+"x"+ 4+ "="+a * 4);
                    Console.WriteLine(a+"x"+ 5+ "="+a * 5);
                    Console.WriteLine(a+"x"+ 6 + "="+a * 6);
                    Console.WriteLine(a+"x"+ 7 + "="+a * 7);
                    Console.WriteLine(a+"x"+ 8 + "="+a * 8);
                    Console.WriteLine(a+"x"+ 9 + "="+a * 9);
                    Console.WriteLine(a+"x"+ 10 + "="+a* 10);
                    break;
                case 2: Console.WriteLine("Suma de dos numeros");
                    Console.WriteLine("introduzca a");
                    a = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("introduzca b");
                    b = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("La suma de a y b es: {0}", a + b);
                    break;
                    case 3: Console.WriteLine("Resta de dos numeros");
                    Console.WriteLine("introduzca a");
                    a = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("introduzca b");
                    b = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("La resta de a y b es: {0}", a - b);
                    break;
                    case 4: Console.WriteLine("Multiplicacion entre dos numeros");
                    Console.WriteLine("introduzca a");
                    a = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("introduzca b");
                    b = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("La multiplicacion de a y b es: {0}", a * b);
                    break;
                    case 5: Console.WriteLine("Division y resto de dos numeros");
                    Console.WriteLine("introduzca a");
                    a = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("introduzca b");
                    b = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("La division de a y b es: {0}", a / b);
                    Console.WriteLine("El resto de a y b es: {0}", a % b);
                    break;
                    default: Console.WriteLine("Error");
                    Console.WriteLine("Precione cualquier tecla para salir");
                    Console.ReadKey();
                    break;

            }
            Console.WriteLine("Precione cualquier tecla para salir");
            Console.ReadKey();




        }
    }
}
