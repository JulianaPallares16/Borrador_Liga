using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace futbol
{
    public class SubmenuEstadistica
    {
        public static void MenuEstadistica()
        {
            bool regresar = false;
            while (!regresar)
            {
                Console.Clear();
                Console.WriteLine(new string('*', 20));
                Console.WriteLine(" 📊 Estadísticas 📊");
                Console.WriteLine(new string('*', 20));
                Console.WriteLine("1. Jugadores Con Más Asistencias En Torneo");
                Console.WriteLine("2. Equipos Con Más Goles En Contra En Torneo");
                Console.WriteLine("3. Jugadores Más Caros Por Equipo");
                Console.WriteLine("4. Jugadores Menores Al Promedio De Edad Por Equipo");
                Console.WriteLine("5. Regresar");
                Console.WriteLine("Ingrese el número de la acción que desea realizar:");
                int opj = Convert.ToInt32(Console.ReadLine());

                switch (opj)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("== Jugadores Con Más Asistencias En Torneo ==");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("== Equipos Con Más Goles En Contra En Torneo ==");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("== Jugadores Más Caros Por Equipo ==");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("== Jugadores Menores Al Promedio De Edad Por Equipo ==");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Adios...");
                        regresar = true;
                        break;
                    default:
                        Console.WriteLine("Opción no valida");
                        break;
                }

            }

        }
    }
}