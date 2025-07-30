using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace futbol
{
    public class SubmenuTorneo
    {
        public static List<Torneo> torneos = new List<Torneo>();
        public static void MenuTorneo()
        {
            bool regresar = false;
            while (!regresar)
            {
                Console.Clear();
                Console.WriteLine(new string('*', 25));
                Console.WriteLine(" 🏆 Gestor De Torneos 🏆");
                Console.WriteLine(new string('*', 25));
                Console.WriteLine("1. Crear Torneo");
                Console.WriteLine("2. Buscar Torneo");
                Console.WriteLine("3. Eliminar Torneo");
                Console.WriteLine("4. Actualizar Torneo");
                Console.WriteLine("5. Regresar");
                Console.WriteLine("Ingrese el número de la acción que desea realizar:");
                string? opt = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(opt))
                {
                    continue;
                }
                else
                {
                    switch (opt)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("== Crear Torneo ==");
                            while (true)
                            {
                                Console.WriteLine("¿Desea crear un nuevo torneo? (si/no)");
                                string? respuesta = Console.ReadLine()?.ToLower();
                                if (respuesta?.ToLower() != "si")
                                {
                                    break;
                                }
                                else
                                {
                                    Torneo objTorneo = new Torneo();
                                    torneos.Add(objTorneo.Addtorneo());
                                }
                            }
                            Console.Clear();
                            Console.WriteLine("⭐ Torneos Creados:");
                            foreach (Torneo torneo in torneos)
                            {
                                Console.WriteLine(torneo.ToString());
                            }
                            Console.ReadKey();
                            break;
                        case "2":
                            Console.Clear();
                            Console.WriteLine("== Buscar Torneo ==");
                            Console.WriteLine("Ingrese el Id del torneo que desea buscar: ");
                            int ingreseId = Convert.ToInt32(Console.ReadLine());
                            Torneo? torneoEncontrado = torneos.Find(t => t.Id == ingreseId); // Busca el id dentro de los torneos.
                            if (torneoEncontrado != null)
                            {
                                Console.WriteLine(torneoEncontrado.ToString());
                            }
                            else
                            {
                                Console.WriteLine("⚠️ Id no encontrado.");
                            }

                            Console.ReadKey();
                            break;
                        case "3":
                            Console.Clear();
                            Console.WriteLine("== Eliminar Torneo ==");
                            Console.WriteLine("Ingrese el Id del torneo que desea eliminar: ");
                            int eliminarId = Convert.ToInt32(Console.ReadLine());
                            Torneo? idEncontrado = torneos.Find(t => t.Id == eliminarId);
                            if (idEncontrado != null)
                            {
                                while (true)
                                {
                                    Console.WriteLine("¿Está seguro de eliminarlo? (si/no)");
                                    string? eliminar = Console.ReadLine();
                                    if (eliminar?.ToLower() != "si")
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        torneos.Remove(idEncontrado);
                                        Console.WriteLine("🗑️ Torneo eliminado exitosamente.");
                                        break;

                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("⚠️ Id no encontrado");
                                break;
                            }
                            Console.ReadKey();
                            break;
                        case "4":
                            Console.Clear();
                            Console.WriteLine("== Actualizar Torneo ==");
                            Console.WriteLine("Ingrese el Id del torneo que desea Actualizar: ");
                            int idActualizar = Convert.ToInt32(Console.ReadLine());
                            Torneo? Encontrado = torneos.Find(t => t.Id == idActualizar);
                            if (Encontrado != null)
                            {
                                Console.WriteLine(Encontrado.ToString());
                                Console.WriteLine("¿Qué dese actualizar?");
                                string? respuesta = Console.ReadLine()?.ToLower();
                                switch (respuesta)
                                {
                                    case "nombre":
                                        Console.WriteLine("Ingrese el nuevo nombre del torneo");
                                        string? newNombre = Console.ReadLine();
                                        if (torneos.Any(t => t.Nombre?.ToLower() == newNombre?.ToLower()))
                                        {
                                            Console.WriteLine("Ese nombre ya está en uso. ");
                                        }
                                        else
                                        {
                                            Console.WriteLine("¿Está seguro de realizar la actualización? si/no");
                                            string? answer = Console.ReadLine();
                                            if (answer?.ToLower() != "si")
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Encontrado.Nombre = newNombre;
                                                Console.WriteLine("✅ Torneo actualizado con éxito. ");
                                            }
                                        }
                                        break;
                                    case "fecha de inicio":
                                        Console.WriteLine("Ingrese la nueva fecha de inicio dd/mm/aaaa");
                                        string? newInicio = Console.ReadLine();
                                        DateTime Inicio;
                                        while (!DateTime.TryParse(newInicio, out Inicio))
                                        {
                                            Console.WriteLine("⚠️ Fecha inválida. Intente de nuevo (formato: dd/mm/aaaa):");
                                            newInicio = Console.ReadLine();
                                        }
                                        Console.WriteLine("¿Está seguro de realizar la actualización? si/no");
                                            string? answer2 = Console.ReadLine();
                                            if (answer2?.ToLower() != "si")
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Encontrado.FechaInicio = Inicio;
                                                Console.WriteLine("✅ Torneo actualizado con éxito. ");
                                            }
                                        break;
                                    case "fecha de fin":
                                        Console.WriteLine("Ingrese la nueva fecha de inicio dd/mm/aaaa");
                                        string? newFin = Console.ReadLine();
                                        DateTime Fin;
                                        while (!DateTime.TryParse(newFin, out Fin))
                                        {
                                            Console.WriteLine("⚠️ Fecha inválida. Intente de nuevo (formato: dd/mm/aaaa):");
                                            newInicio = Console.ReadLine();
                                        }
                                        Console.WriteLine("¿Está seguro de realizar la actualización? si/no");
                                            string? answer3 = Console.ReadLine();
                                            if (answer3?.ToLower() != "si")
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Encontrado.FechaFin = Fin;
                                                Console.WriteLine("✅ Torneo actualizado con éxito. ");
                                            }
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("⚠️ Id no encontrado");
                                break;
                            }

                            Console.ReadKey();
                            break;
                        case "5":
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