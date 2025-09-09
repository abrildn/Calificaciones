using System;

namespace Calificaciones
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la calificación para aprobar el curso:");
            string linea = Console.ReadLine();
            int aprob = int.Parse(linea);

            Console.WriteLine("Ingrese la nota calificación para ir a recuperatorio:");
            linea = Console.ReadLine();
            int recup = int.Parse(linea);

            Console.WriteLine("Ingrese su nota");
            linea = Console.ReadLine();
            int nota = int.Parse(linea);

            if (nota < recup)
            {
                Console.WriteLine("Usted desaprobó la materia");
            }
            else
            {
                if (nota >= aprob)
                {
                    Console.WriteLine("Usted aprobó la materia");
                }
                else
                {
                    Console.WriteLine("Debe ir a recuperatorio");
                }
            }

            Console.ReadKey();
        }
    }
}