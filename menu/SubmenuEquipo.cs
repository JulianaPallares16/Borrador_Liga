using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace futbol
{
    public class SubmenuEquipo
    {
        public static List<Equipo> equipos = new List<Equipo>();
        public static List<CuerpoTecnico> tecnicos = new List<CuerpoTecnico>();
        public static List<CuerpoMedico> medicos = new List<CuerpoMedico>();

        public static void MenuEquipo()
        {
            bool regresar = false;
            while (!regresar)
            {
                Console.Clear();
                Console.WriteLine(new string('*', 26));
                Console.WriteLine(" 🏟️  Gestor De Equipos 🏟️");
                Console.WriteLine(new string('*', 26));
                Console.WriteLine("1. Registrar Equipo");
                Console.WriteLine("2. Registrar Cuerpo Técnico");
                Console.WriteLine("3. Registrar Cuerpo Médico");
                Console.WriteLine("4. Inscripción Torneo");
                Console.WriteLine("5. Notificaciones");
                Console.WriteLine("6. Salir de Torneo");
                Console.WriteLine("7. Regresar");
                Console.WriteLine("Ingrese el número de la acción que desea realizar:");
                string? ope = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(ope))
                {
                    continue;
                }
                else
                {
                    switch (ope)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("== Registrar Equipo ==");
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
                                    Equipo objEquipo = new Equipo();
                                    equipos.Add(objEquipo.Addequipo());
                                }
                            }
                            Console.Clear();
                            Console.WriteLine("⭐ Torneos Creados:");
                            foreach (Equipo equipo in equipos)
                            {
                                Console.WriteLine(equipo.ToString());
                            }
                            Console.ReadKey();
                            break;
                        case "2":
                            Console.Clear();
                            Console.WriteLine("== Registrar Cuerpo Técnico ==");
                            Console.ReadKey();
                            break;
                        case "3":
                            Console.Clear();
                            Console.WriteLine("== Registrar Cuerpo Médico ==");
                            Console.ReadKey();
                            break;
                        case "4":
                            Console.Clear();
                            Console.WriteLine("== Inscripción Torneo ==");
                            Console.ReadKey();
                            break;
                        case "5":
                            Console.Clear();
                            Console.WriteLine("== Notificaciones ==");
                            Console.ReadKey();
                            break;
                        case "6":
                            Console.Clear();
                            Console.WriteLine("== Salir de Torneo ==");
                            Console.ReadKey();
                            break;
                        case "7":
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