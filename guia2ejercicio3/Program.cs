using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia2ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0)
            {
                Console.Write("El numero " + numero + " es Par.");
            }
            else
            {
                Console.Write("El numero " + numero + " es Impar.");
            }
            Console.ReadKey();
            
        }
    }
}
