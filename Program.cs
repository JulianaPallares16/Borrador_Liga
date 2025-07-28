using System.ComponentModel.Design;
using System.Diagnostics;
using futbol;

internal class Program
{
    private static void Main(string[] args)
    {
        bool salir = false;
        while (!salir)
        {
            Console.Clear();
            Console.WriteLine(new string('*', 53));
            Console.WriteLine("*** Bienvenido Al Gestor De Campeonatos De Fútbol ***");
            Console.WriteLine(new string('*', 53));
            Console.WriteLine("1. Torneo");
            Console.WriteLine("2. Equipos");
            Console.WriteLine("3. Jugadores");
            Console.WriteLine("4. Transferencias (Compra, Prestamo)");
            Console.WriteLine("5. Estadisticas");
            Console.WriteLine("6. Salir");
            Console.WriteLine("Ingrese el número de la sección ha acceder:");
            string? opcion = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(opcion))
            {
                continue;
            }
            else
            {
                switch (opcion)
                {
                    case "1":
                        SubmenuTorneo.MenuTorneo();
                        break;
                    case "2":
                        SubmenuEquipo.MenuEquipo();
                        break;
                    case "3":
                        SubmenuJugadores.MenuJugador();
                        break;
                    case "4":
                        SubmenuTransf.MenuTransferencia();
                        break;
                    case "5":
                        SubmenuEstadistica.MenuEstadistica();
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("Vuleve pronto 👋");
                        salir = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opción no valida");
                        break;

                }

            }
        }
    }
}