using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preguntas_y_respuestas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,b,not=0,cont=0;
            
            string[] preguntas = new string[5];
            String[] respuestas = new String[15];
            int[] respuestasAlumnos=new int[5];
            
            int[] respuestasC = new int[5];

            Console.WriteLine("Bienvenido al sistema de preguntas y respuestas");
            do {
                Console.WriteLine("<--------------->");
                Console.WriteLine("Menu");
                Console.WriteLine("<--------------->");
                Console.WriteLine("1)Cargar preguntas");
                Console.WriteLine("2)Responder preguntas");
                Console.WriteLine("3)Salir");
                a=int.Parse(Console.ReadLine());

                switch (a) {
                    case 1: 
                        Console.WriteLine("Cargar preguntas");
                        Console.WriteLine("<--------------->");
                        for (int i=0;i<5;i++) {
                            if (i == 0)
                            {
                                Console.WriteLine("<--------------->");
                                Console.WriteLine("Primer pregunta");
                            }
                            else if (i == 4)
                            {
                                Console.WriteLine("<--------------->");
                                Console.WriteLine("Ultima pregunta");
                            }
                            else {
                                Console.WriteLine("<--------------->");
                                Console.WriteLine("Siguiente pregunta");
                            }
                            preguntas[i] = Console.ReadLine();
                            
                            //respuestas a preguntas
                            Console.WriteLine("Cargue 3 opciones para responder esta pregunta");
                            if (i == 0)
                            {
                                for (int o = 0; o < 3; o++)
                                {
                                    if (o == 0)
                                    {

                                        Console.WriteLine("respuesta 1)");
                                    }
                                    else if (o == 2)
                                    {

                                        Console.WriteLine("respuesta 2)");
                                    }
                                    else 
                                    {

                                        Console.WriteLine("respuesta 3)");
                                    }
                                    respuestas[o] = Console.ReadLine();

                                }
                            }
                            else if (i == 1)
                            {
                                for (int o = 3; o < 6; o++)
                                {
                                    if (o == 3)
                                    {

                                        Console.WriteLine("respuesta 1)");
                                    }
                                    else if (o == 4)
                                    {

                                        Console.WriteLine("respuesta 2)");
                                    }
                                    else
                                    {

                                        Console.WriteLine("respuesta 3)");
                                    }
                                    respuestas[o] = Console.ReadLine();

                                }
                            }
                            else if (i == 2)
                            {
                                for (int o = 6; o < 9; o++)
                                {
                                    if (o == 6)
                                    {
                                        Console.WriteLine("respuesta 1)");
                                    }
                                    else if (o == 7)
                                    {
                                        Console.WriteLine("respuesta 2)");
                                    }
                                    else
                                    {
                                        Console.WriteLine("respuesta 3)");
                                    }
                                    respuestas[o] = Console.ReadLine();

                                }
                            }
                            else if (i == 3)
                            {
                                for (int o = 9; o < 12; o++)
                                {
                                    if (o == 9)
                                    {
                                        Console.WriteLine("respuesta 1)");
                                    }
                                    else if (o == 10)
                                    {
                                        Console.WriteLine("respuesta 2)");
                                    }
                                    else
                                    {
                                        Console.WriteLine("respuesta 3)");
                                    }
                                    respuestas[o] = Console.ReadLine();

                                }
                            }
                            else {
                                for (int o = 12; o < 15; o++)
                                {
                                    if (o == 12)
                                    {
                                        Console.WriteLine("respuesta 1)");
                                    }
                                    else if (o == 13)
                                    {
                                        Console.WriteLine("respuesta 2)");
                                    }
                                    else
                                    {
                                        Console.WriteLine("respuesta 3)");
                                    }
                                    respuestas[o] = Console.ReadLine();

                                }

                            }
                            Console.WriteLine("<--------------->");
                            Console.WriteLine("¿Cual es la respuesta correcta 1, 2 o 3?");
                            respuestasC[i]=int.Parse(Console.ReadLine());
                                                
                        }
                        break;

                    case 2:
                        Console.WriteLine("Responder preguntas");
                        Console.WriteLine("<--------------->");
                        do {
                            int cont2 = 1;

                            Console.WriteLine(preguntas[cont]);
                            Console.WriteLine("opciones:");
                            if (cont == 0) {
                                for (int i = 0; i < 3; i++) {
                                    Console.WriteLine(cont2+") " + respuestas[i]);
                                    cont2 = cont2 + 1;
                                    
                                }
                            } else if(cont==1){
                                for (int i = 3; i < 6; i++) {
                                    
                                    Console.WriteLine(cont2 + ") " + respuestas[i]);
                                    cont2 = cont2 + 1;
                                }
                            }
                            else if (cont == 2)
                            {
                                for (int i = 6; i < 9; i++) {
                                    
                                    Console.WriteLine(cont2 + ") " + respuestas[i]);
                                    cont2 = cont2 + 1;
                                }
                            }
                            else if (cont == 3)
                            {
                                for (int i = 9; i < 12; i++) {
                                    
                                    Console.WriteLine(cont2 + ") " + respuestas[i]);
                                    cont2 = cont2 + 1;
                                }
                            }
                            else 
                            {
                                for (int i = 12; i < 15; i++) {
                                    Console.WriteLine(cont2 + ") " + respuestas[i]);
                                    cont2 = cont2 + 1;
                                }
                            }
                            Console.WriteLine("Elija su respuesta");
                            respuestasAlumnos[cont]=int.Parse(Console.ReadLine());

                            cont = cont+1;
                        } while (cont != 5);

                        //evaluar
                        for (int i = 0; i < 5; i++) {
                            if (respuestasC[i] == respuestasAlumnos[i])
                            {
                                Console.WriteLine(preguntas[i]);
                                Console.WriteLine("Respuesta correcta");
                                not = not + 2;
                            }
                            else {
                                Console.WriteLine(preguntas[i]);
                                Console.WriteLine("Respuesta incorrecta, la respuesta correcta era: ");
                                Console.WriteLine(respuestasC[i]);
                                
                            }
                            Console.WriteLine("<--------------->");

                        }
                        Console.WriteLine("Su nota final es: "+not);
                        break;
                        default: 
                        Console.WriteLine("Opcion incorrecta");
                        break;



                }





            } while (a!=3);

            Console.ReadKey();



        }
    }
}
