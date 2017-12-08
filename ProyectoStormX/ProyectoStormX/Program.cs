using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoStormX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROGRAMACION ESTRUCTURADA OYM 0463");
            Console.WriteLine("INGENIERIA INDUSTRIAL");

            Console.WriteLine("YANELIS MORETA       16-SIIT-1-052");
            Console.WriteLine("RICARDO CAPELLAN     16-SIIT-1-069");
            Console.WriteLine("RIQUELMI SANTOS      16-SIIT-1-070");

            /*PROGRAMA QUE CALCULA EL PROMEDIO DE CUATRO CALIFICACIONES*/
            //DECLARANDO LOS VALORES

            int CALIFICACION1, CALIFICACION2, CALIFICACION3, CALIFICACION4, SUMA, PROMEDIO;
            string linea;

            Console.Write("INGRESE LA PRIMERA CALIFICACION:");
            linea = Console.ReadLine();
            CALIFICACION1 = int.Parse(linea);



            Console.Write("INGRESE LA SEGUNDA CALIFICACION:");
            linea = Console.ReadLine();
            CALIFICACION2 = int.Parse(linea);


            Console.Write("INGRESE LA TERCERA CALIFICACION:");
            linea = Console.ReadLine();
            CALIFICACION3 = int.Parse(linea);



            Console.Write("INGRESE LA CUARTA CALIFICACION:");
            linea = Console.ReadLine();
            CALIFICACION4 = int.Parse(linea);


            // PROCEDEMOS A REALIZAR LA SUMA DE LAS CALIFICACIONES INGRESADAS
            SUMA = CALIFICACION1 + CALIFICACION2 + CALIFICACION3 + CALIFICACION4;
            PROMEDIO = SUMA / 4;

            Console.Write(" LA SUMA DE LAS CUATRO CALIFICACIONES ES :");
            Console.WriteLine(SUMA);


            Console.Write("EL PROMEDIO ES :");
            Console.WriteLine(PROMEDIO);


            // CONDICION IF
            if( PROMEDIO < 70)

            { Console.WriteLine("LAMENTABLEMENTE A REPROBADO LA MATERIA"); }

            else if(PROMEDIO>= 70)
                { Console.WriteLine("FELICIDADES A APROBADO LA MATERIA"); }



            // BUCLE FOR DE MULTIPLICACION
            int N;

            Console.WriteLine("INGRESE EL MULTIPLICADOR");
            int.TryParse(Console.ReadLine(), out N);



            for (int I = 1; I <= 15; I++)
            {
                Console.WriteLine(I + " X " + N + " = " + I*N );
 

            }

            //ENTRADA POR TECLADO

            string d;
            Console.WriteLine("EL PROFESOR ESTA SATISFECHO CON EL PROGRAMA?");
            d = Console.ReadLine();
            Console.WriteLine("GRACIAS, SU RESPUESTA FUE : " + d);

            Console.ReadKey();


            /*Hecho por:
             * RIQUELMI SANTOS   16-SIIT-1-070   SECCION 0463
             * RICARDO CAPELLAN  16-SIIT-1-069   SECCION 0463
             * YANELIS MORETA    16-SIIT-1-052   SECCION 0463*/





        }
    }
}
