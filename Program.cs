using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_7___ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el valor de n: ");
            int n = int.Parse(Console.ReadLine());

            float suma = 0f;
            float termino = 0f;

            for (int i = 1; i <= n; i++)
            {
                termino = (16f - i) / (3.0f * i);
                suma += termino;
                Console.WriteLine("Resultado : " + termino);
            }

            Console.WriteLine(suma);
            Console.ReadKey();
        }
    }
}