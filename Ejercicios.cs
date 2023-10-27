using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_unidad2
{
    internal class Ejercicios
    {
        public void CienEstudiantes()
        {
            int[] calificaciones = new int[100];
            Random random = new Random();

            for (int i = 0; i < calificaciones.Length; i++)
            {
                calificaciones[i] = random.Next(0, 100);
            }
            Console.WriteLine("Matriz desordenada:");
            for (int i = 0; i < calificaciones.Length; i++)
            {
                Console.Write(calificaciones[i] + " ");
            }
            //
            Console.WriteLine("Ordenamiento descendente:");
            for (int i = calificaciones.Length; 0 <= i; i--)
            {
                int numMenor = 0; int j = i - 1;


                if (0 > i && calificaciones[numMenor] < calificaciones[j])
                {
                    numMenor = j;
                    j--;
                }

                int tem = calificaciones[numMenor];
                calificaciones[numMenor] = calificaciones[j];
                calificaciones[j] = tem;

            }
            Console.WriteLine("imprimir matriz ordenada:");
            for (int i = 0; i < calificaciones.Length; i++)
            {
                Console.Write(calificaciones[i] + ", ");
            }
        }
        //tabla
        public void tabla()
        {
            int[,] matriz = {
            {500, 3000, 100,  400 },//4000
            {1000,150,  200,  500 },//1850
            {250, 1800, 2900, 300 },//5250
            {400, 130,  90,   2400 },//3020
            {60,  20,   4000, 3600 }};//7680
           //2210, 5100, 7290, 7200
            Console.WriteLine("Tabla:");
            for(int i=0; i < matriz.GetLength(0); i++)
            {
                
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i,j]+" | ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Ganancia vendedor 1");
            int suma=0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                    if (matriz[i,0] > 0)
                    {
                        suma += matriz[i, 0];
                    }
            }
            Console.WriteLine("Ganancia total: "+suma);
            Console.WriteLine();
            int suma2 = 0;
            Console.WriteLine("Ganancia vendedor 2");
            for (int i = 1; i < matriz.GetLength(0); i++)
            {
                if (matriz[i, 1] > 0)
                {
                    suma2 += matriz[i, 1];
                }
            }
            Console.WriteLine("Ganancia total: " + suma2);
            Console.WriteLine();
            Console.WriteLine("Ganancia vendedor 3");
            for (int i = 2; i < matriz.GetLength(0); i++)
            {
                if (matriz[i, 2] > 0)
                {
                    suma += matriz[i, 2];
                }
            }
            Console.WriteLine("Ganancia total: " + suma);
            Console.WriteLine();
            Console.WriteLine("Ganancia vendedor 4");
            for (int i = 3; i < matriz.GetLength(0); i++)
            {
                if (matriz[i, 3] > 0)
                {
                    suma += matriz[i, 3];
                }
            }
            Console.WriteLine("Ganancia total: " + suma);
        }
    }
}
