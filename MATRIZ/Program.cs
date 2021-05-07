using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATRIZ
{
    class Program
    {
        static void Main(string[] args)
        {
            //PROGRAMA QUE MUESTRA EL USO DE ARREGLOS EN DOS DIMENSIONES O MATRICES
            //VARIABKES DE CONTROL PARA EL CICLO FOR
            int m = 0;
            int n = 0;
            double sumatoria = 0;
            double promedio = 0.0;

            //utilizar variable random
            Random rnd = new Random();

            int[,] datos = new int[4, 7];

            for(n =0; n<4; n++)//avanzamos en renglones
            {
                for(m =0; m<7; m++)
                {
                    //para llevar acabo la asignacion nombre de la matriz, indice f y c y el valor
                    datos[n, m] = rnd.Next(30);

                }
            }

            //Imprimir los datos
            for (n = 0; n < 4; n++)
            {
                Console.WriteLine("Semana {0}", n);
                for (m = 0; m < 7; m++)
                {
                    Console.Write("{0} ", datos[n, m]);
                }
            }

            //Calcular el promedio por semana
            for (n = 0; n < 4; n++)
            {
                sumatoria = 0.0;
                promedio = 0.0;
                for (m = 0; m < 7; m++)
                {
                    sumatoria += datos[n, m];
                }

                promedio = sumatoria / 7.0;
                Console.WriteLine("El promedio de la semana {0} es {1}", n, promedio);
            }

            //Calcular el promedio total

            Console.ReadKey();

        }
    }
}