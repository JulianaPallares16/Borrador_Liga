using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace futbol
{
    public class SubmenuTransf
    {
        public static void MenuTransferencia()
        {
            bool regresar = false;
            while (!regresar)
            {
                Console.Clear();
                Console.WriteLine(new string('*', 30));
                Console.WriteLine(" 🔁 Gestor De Transferencias 🔁");
                Console.WriteLine(new string('*', 30));
                Console.WriteLine("1. Comprar Jugador");
                Console.WriteLine("2. Prestar Jugador");
                Console.WriteLine("3. Regresar");
                Console.WriteLine("Ingrese el número de la acción que desea realizar:");
                string? optr = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(optr))
                {
                    continue;
                }
                else
                {
                    switch (optr)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("== Comprar Jugador ==");
                            Console.ReadKey();
                            break;
                        case "2":
                            Console.Clear();
                            Console.WriteLine("== Prestar Jugador ==");
                            Console.ReadKey();
                            break;
                        case "3":
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
}