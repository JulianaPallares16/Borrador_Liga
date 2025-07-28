using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Threading.Tasks;

namespace futbol
{
    public class SubmenuJugadores
    {
        public static List<Jugador> jugadores = new List<Jugador>();
        public static void MenuJugador()
        {
            bool regresar = false;
            while (!regresar)
            {
                Console.Clear();
                Console.WriteLine(new string('*', 28));
                Console.WriteLine(" ⚽ Gestor De Jugadores ⚽");
                Console.WriteLine(new string('*', 28));
                Console.WriteLine("1. Registrar Jugador");
                Console.WriteLine("2. Buscar Jugador");
                Console.WriteLine("3. Editar Jugador");
                Console.WriteLine("4. Eliminar Jugador");
                Console.WriteLine("5. Regresar");
                Console.WriteLine("Ingrese el número de la acción que desea realizar:");
                string? opj = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(opj))
                {
                    continue;
                }
                else
                {
                    switch (opj)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("== Registrar Jugador ==");
                            while (true)
                            {
                                Console.WriteLine("¿Desea registrar un nuevo jugador? (si/no)");
                                string? respuesta = Console.ReadLine();
                                if (respuesta?.ToLower() != "si")
                                {
                                    break;
                                }
                                else
                                {
                                    Jugador objJugador = new Jugador();
                                    jugadores.Add(objJugador.Addjugador());
                                }
                            }
                            Console.Clear();
                            Console.WriteLine("⭐ Jugadores Registrados:");
                            foreach (Jugador jugador in jugadores)
                            {
                                Console.WriteLine(jugador.ToString());
                            }
                            Console.ReadKey();
                            break;
                        case "2":
                            Console.Clear();
                            Console.WriteLine("== Buscar Jugador ==");
                            Console.WriteLine("Ingrese el Id del jugador que desea buscar");
                            int ingreseId = Convert.ToInt32(Console.ReadLine());
                            Jugador? jugadorEncontrado = jugadores.Find(j => j.Id == ingreseId);
                            if (jugadorEncontrado != null)
                            {
                                Console.WriteLine(jugadorEncontrado.ToString());
                            }
                            else
                            {
                                Console.WriteLine("⚠️ Id no encontrado.");
                                Console.ReadKey();
                                break;
                            }
                            Console.ReadKey();
                            break;
                        case "3":
                            Console.Clear();
                            Console.WriteLine("== Editar Jugador ==");
                            Console.WriteLine("Ingrese el Id del jugador que desea editar");
                            int idJugador = Convert.ToInt32(Console.ReadLine());
                            Jugador? idEncontrado = jugadores.Find(j => j.Id == idJugador);
                            if (idEncontrado != null)
                            {
                                Console.WriteLine(idEncontrado.ToString());
                                Console.WriteLine("Qué desea editar?");
                                string? respuesta = Console.ReadLine()?.ToLower();
                                switch (respuesta)
                                {
                                    case "nombre":
                                        Console.WriteLine("Ingrese el nuevo nombre del jugador");
                                        string? newNombre = Console.ReadLine();
                                        Console.WriteLine("¿Está seguro de realizar la actualización? si/no");
                                        string? answer = Console.ReadLine();
                                        if (answer?.ToLower() != "si")
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            idEncontrado.Nombre = newNombre;
                                            Console.WriteLine("✅ Nombre actualizado con éxito. ");

                                        }
                                        break;
                                    case "id":
                                        Console.WriteLine("Ingrese el nuevo Id del jugador");
                                        int newId = Convert.ToInt32(Console.ReadLine());
                                        if (jugadores.Any(j => j.Id == newId))
                                        {
                                            Console.WriteLine("Este Id pertenese a otro jugador");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("¿Está seguro de realizar la actualización? si/no");
                                            string? answer2 = Console.ReadLine();
                                            if (answer2?.ToLower() != "si")
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                idEncontrado.Id = newId;
                                                Console.WriteLine("✅ Id actualizado con éxito. ");
                                            }

                                        }
                                        break;
                                    case "apellido":
                                        Console.WriteLine("Ingrese el nuevo apellido del jugador");
                                        string? newApellido = Console.ReadLine();
                                        string? answer3 = Console.ReadLine();
                                        if (answer3?.ToLower() != "si")
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            idEncontrado.Apellido = newApellido;
                                            Console.WriteLine("✅  Apellido actualizado con éxito. ");
                                        }
                                        break;
                                    case "edad":
                                        Console.WriteLine("Ingrese la nueva edad del jugador");
                                        int newEdad = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("¿Está seguro de realizar la actualización? si/no");
                                        string? answer4 = Console.ReadLine();
                                        if (answer4?.ToLower() != "si")
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            idEncontrado.Edad = newEdad;
                                            Console.WriteLine("✅  Edad actualizada con éxito. ");
                                        }
                                        break;
                                    case "nacionalidad":
                                        Console.WriteLine("Ingrese la nueva nacionalidad del jugador");
                                        string? newNacionalidad = Console.ReadLine();
                                        Console.WriteLine("¿Está seguro de realizar la actualización? si/no");
                                        string? answer5 = Console.ReadLine();
                                        if (answer5?.ToLower() != "si")
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            idEncontrado.Nacionalidad = newNacionalidad;
                                            Console.WriteLine("✅  Nacionalidad actualizado con éxito. ");
                                        }
                                        break;
                                    case "dorsal":
                                        Console.WriteLine("Ingrese la nueva dorsal del jugador");
                                        int newDorsal = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("¿Está seguro de realizar la actualización? si/no");
                                        string? answer6 = Console.ReadLine();
                                        if (answer6?.ToLower() != "si")
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            idEncontrado.Dorsal = newDorsal;
                                            Console.WriteLine("✅  Dorsal actualizada con éxito. ");
                                        }
                                        break;
                                    case "posicion":
                                        Console.WriteLine("Ingrese la posición del jugador");
                                        string? newPosicion = Console.ReadLine();
                                        Console.WriteLine("¿Está seguro de realizar la actualización? si/no");
                                        string? answer7 = Console.ReadLine();
                                        if (answer7?.ToLower() != "si")
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            idEncontrado.Posicion = newPosicion;
                                            Console.WriteLine("✅  Posición actualizada con éxito. ");
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("Elemento no encontrado 😞");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("⚠️ Id no encontrado.");
                                break;
                            }
                            Console.ReadKey();
                            break;
                        case "4":
                            Console.Clear();
                            Console.WriteLine("== Eliminar Jugador ==");
                            Console.WriteLine("Ingrese el Id del jugador que desea eliminar: ");
                            int eliminarId = Convert.ToInt32(Console.ReadLine());
                            Jugador? findId = jugadores.Find(j => j.Id == eliminarId);
                            if (findId != null)
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
                                        jugadores.Remove(findId);
                                        Console.WriteLine("🗑️  Jugador eliminado exitosamente.");
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