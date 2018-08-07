using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleccionar_aspirantes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int edad;
            int ing;
            int exp;
            int i;

            int suma = 0;
            int ac = 0;

            Console.WriteLine("Ingrese la cantidad de aspirantes a la vacante:");
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                Console.WriteLine("El aspirante " + i, "es:");
                Console.WriteLine();
                Console.WriteLine("Mayor de edad? [1=Si ó 2=No]");
                edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingeniero titulado? [1=Si ó 2=No]");
                ing = int.Parse(Console.ReadLine());
                Console.WriteLine("Tiene experiencia laboral? [1=Si ó 2=No]");
                exp = int.Parse(Console.ReadLine());

                if (edad == 1 && ing == 1 && exp == 1)
                {
                    ac = suma + 1;
                }
            }

            Console.WriteLine("Total de aspirantes aceptados: " + ac);
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para continuar... ");
            Console.ReadKey();
        }
    }
}
