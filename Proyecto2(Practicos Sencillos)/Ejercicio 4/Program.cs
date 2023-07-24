using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int primerDia = 0, mes = 0, cantidadDias = 0, i = 0, fechaUsuario = 0;

            string dia;

            //Se obvia el paso que pide que el usuario ingrese el primer dia de cada mes
            //porque para que el programa funcione esa informacion debe ser correcta
            //y es mas facil si ya viene incluida

            Console.WriteLine("Ingrese el mes (numero)");
            mes = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese una fecha del mes para saber en que dia cae");
            fechaUsuario = int.Parse(Console.ReadLine());




            switch (mes)
            {
                case 1:
                    {
                        primerDia = 7;
                        break;
                    }
                case 2:
                    {
                        primerDia = 3;
                        break;
                    }
                case 3:
                    {
                        primerDia = 3;

                        break;
                    }
                case 4:
                    {
                        primerDia = 6;

                        break;
                    }
                case 5:
                    {
                        primerDia = 1;

                        break;
                    }
                case 6:
                    {
                        primerDia = 4;

                        break;
                    }
                case 7:
                    {
                        primerDia = 6;

                        break;
                    }
                case 8:
                    {
                        primerDia = 2;

                        break;
                    }
                case 9:
                    {
                        primerDia = 5;

                        break;
                    }
                case 10:
                    {
                        primerDia = 7;

                        break;
                    }
                case 11:
                    {
                        primerDia = 3;

                        break;
                    }
                case 12:
                    {

                        primerDia = 5;

                        break;
                    }
            }

            int contadorDia = primerDia;

            for (i = 1; i < fechaUsuario; i++)
            {


                if (contadorDia < 7)
                {
                    contadorDia++;
                    //Console.WriteLine(contadorDia);

                }
                else
                {
                    contadorDia = 1;
                    //Console.WriteLine(contadorDia);
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

            //FIN DE SEMANA

            Console.WriteLine("Ingrese el mes");
            mes = int.Parse(Console.ReadLine());

            switch (mes)
            {
                case 1:
                    {
                        primerDia = 7;
                        cantidadDias = 31;
                        break;
                    }
                case 2:
                    {
                        primerDia = 3;
                        cantidadDias = 28;
                        break;
                    }
                case 3:
                    {
                        primerDia = 3;
                        cantidadDias = 31;
                        break;
                    }
                case 4:
                    {
                        primerDia = 6;
                        cantidadDias = 30;
                        break;
                    }
                case 5:
                    {
                        primerDia = 1;
                        cantidadDias = 31;
                        break;
                    }
                case 6:
                    {
                        primerDia = 4;
                        cantidadDias = 30;
                        break;
                    }
                case 7:
                    {
                        primerDia = 6;
                        cantidadDias = 31;
                        break;
                    }
                case 8:
                    {
                        primerDia = 2;
                        cantidadDias = 30;
                        break;
                    }
                case 9:
                    {
                        primerDia = 5;
                        cantidadDias = 31;
                        break;
                    }
                case 10:
                    {
                        primerDia = 7;
                        cantidadDias = 30;
                        break;
                    }
                case 11:
                    {
                        primerDia = 3;
                        cantidadDias = 31;
                        break;
                    }
                case 12:
                    {
                        primerDia = 5;
                        cantidadDias = 30;
                        break;
                    }
            }


            Console.WriteLine("Los fines de semana caeran en las siguientes fechas:");

            int dias = primerDia; //1 en este caso es lunes porque no nos manejamos con strings sino con numeros
            int fecha = 1; //1 en este caso es la fecha, 1 de mayo por ejemplo

            for (i = 1; i <= cantidadDias; i++)
            {
                //Console.WriteLine($"Dia {dias}");
                //Console.WriteLine($"Fecha {fecha}");

                if (dias == 6 || dias == 7)
                {
                    Console.WriteLine(">" + fecha);
                }

                if (dias < 7)
                {
                    dias++;

                }
                else
                {
                    dias = 1;
                }


                fecha++;
            }


        }
    }
}
