using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             //Esta solucion usaba el tipo TimeDate
            Console.WriteLine("Ingrese el año");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el mes");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el primer día del mes (ej. 'martes')");
            string day = Console.ReadLine();

            DateTime fechaPrimera = new DateTime(year, month, 1);

            Console.WriteLine("Ingrese una fecha de este mes para saber en que dia cae");
            int fecha = int.Parse(Console.ReadLine());

            DateTime fechaUsuario = new DateTime(year, month, fecha);

            
            Console.WriteLine($"La fecha {fechaUsuario.ToLongDateString()} cae el dia {fechaUsuario.DayOfWeek}");
            */


            int primerDia = 0, mes = 0, cantidadDias = 0, i = 0, fechaUsuario = 0;
            string dia;

            Console.WriteLine("Ingrese el mes (numero)");
            mes = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el primer día del mes");
            Console.WriteLine("1=Lunes");
            Console.WriteLine("2=Martes");
            Console.WriteLine("3=Miercoles");
            Console.WriteLine("4=Jueves");
            Console.WriteLine("5=Viernes");
            Console.WriteLine("6=Sabado");
            Console.WriteLine("7=Domingo");

            primerDia = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese una fecha del mes para saber en que dia cae");
            fechaUsuario = int.Parse(Console.ReadLine());


            switch (mes)
            {
                case 1:
                    {
                        cantidadDias = 31;
                        break;
                    }
                case 2:
                    {
                        cantidadDias = 28;
                        break;
                    }
                case 3:
                    {
                        cantidadDias = 31;
                        break;
                    }
                case 4:
                    {
                        cantidadDias = 30;
                        break;
                    }
                case 5:
                    {
                        cantidadDias = 31;
                        break;
                    }
                case 6:
                    {
                        cantidadDias = 30;
                        break;
                    }
                case 7:
                    {
                        cantidadDias = 31;
                        break;
                    }
                case 8:
                    {
                        cantidadDias = 30;
                        break;
                    }
                case 9:
                    {
                        cantidadDias = 31;
                        break;
                    }
                case 10:
                    {
                        cantidadDias = 30;
                        break;
                    }
                case 11:
                    {
                        cantidadDias = 31;
                        break;
                    }
                case 12:
                    {
                        cantidadDias = 30;
                        break;
                    }
            }

            int contadorDia = primerDia;

            for (i = 0; i < fechaUsuario; i++)
            {
                if (contadorDia <= 7)
                {
                    contadorDia++;
                }
                else
                {
                    contadorDia = 1;

                }
            }
            switch (contadorDia)
            {
                case 1: Console.WriteLine($"Esa fecha cae el dia lunes"); break;
                case 2: Console.WriteLine($"Esa fecha cae el dia martes"); break;
                case 3: Console.WriteLine($"Esa fecha cae el dia miercoles"); break;
                case 4: Console.WriteLine($"Esa fecha cae el dia jueves"); break;
                case 5: Console.WriteLine($"Esa fecha cae el dia viernes"); break;
                case 6: Console.WriteLine($"Esa fecha cae el dia sabado"); break;
                case 7: Console.WriteLine($"Esa fecha cae el dia domingo"); break;
            }


        }
    }
}
