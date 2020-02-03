using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparar_Numero
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] arreglo = new long[10];
            String representar;
            long valor = 0;
            int cantidad = 10;
            long mayor;
            long menor;
            bool identificar;

            for(int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine("Insertar un numero entero, "+"(falta "+cantidad+")");
                representar = Console.ReadLine();

                identificar = long.TryParse(representar, out valor);

                if(identificar == true)
                {
                    valor = long.Parse(representar);
                    arreglo[i] = valor;
                    cantidad--;
                }
                else
                {
                    i--;
                }
            }

            mayor = arreglo[0];
            menor = arreglo[0];

            for(int j = 0; j < arreglo.Length; j++)
            {
                if (arreglo[j] > mayor)
                {
                    mayor = arreglo[j];
                }
                else if (arreglo[j] < menor)
                {
                    menor = arreglo[j];
                }
            }

            Console.WriteLine("El numero mayor es " + mayor + " y el numero menor es " + menor);
            Console.ReadKey();
        }
    }
}
