using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_15
{
    class Program
    {
        //Solicite un ingreso al usuario y determine si puede ser interpretado como un valor numérico.
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, ingrese un número: ");
            double ingreso;
            bool nrodecimal = Double.TryParse(Console.ReadLine(), out ingreso);
            Console.WriteLine("\r");

            if (nrodecimal)
            {
                Console.WriteLine("El ingreso es interpretado como un valor numérico.");
            }
            else
            {
                Console.WriteLine("El ingreso no es interpretado como un valor numérico.");
            }

            Console.WriteLine("Presione cualquier tecla para finalizar.");
            Console.ReadKey();
        }
    }
}
