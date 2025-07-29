using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace futbol
{
    public class Torneo
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Tipo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public Torneo(int id, string? nombre, string? tipo, DateTime fechaInicio, DateTime fechaFin)
        {
            Id = id;
            Nombre = nombre;
            Tipo = tipo;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;

        }
        public Torneo() { }
        public override string ToString()
        {
            return $"Id: {Id}, Nombre: {Nombre}, Tipo: {Tipo}, Fecha de inicio: {FechaInicio} Fecha de fin: {FechaFin}";
        }
        public Torneo Addtorneo()
        {
            while (true)
            {
                Console.WriteLine("Ingrese el Id del torneo");
                string? dataIn = Console.ReadLine();
                if (int.TryParse(dataIn, out int id))
                {
                    Id = id;
                }
                if (SubmenuTorneo.torneos.Any(t => t.Id == id))
                {
                    Console.WriteLine("❗ Este Id ya existe, ingrese uno nuevo.");
                    continue;
                }
                else
                {
                    break;
                }
            }
            while (true)
            {
                Console.WriteLine("Ingrese el nombre del torneo");
                Nombre = Console.ReadLine();
                if (SubmenuTorneo.torneos.Any(t => t.Nombre?.ToLower() == Nombre?.ToLower()))
                {
                    Console.WriteLine("❗ Este nombre ya existe, ingrese uno nuevo.");
                    continue;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("¿Qué tipo de torneo es? (Liga/Torneo internacional)");
            Tipo = Console.ReadLine();
            Console.WriteLine("Ingrese la fecha de inicio (dd/mm/aaaa)");
            string? fechaTexto = Console.ReadLine();
            DateTime fechaInicio;
            while (!DateTime.TryParse(fechaTexto, out fechaInicio))
            {
                Console.WriteLine("⚠️ Fecha inválida. Intente de nuevo (formato: dd/mm/aaaa):");
                fechaTexto = Console.ReadLine();
            }
            FechaInicio = fechaInicio;
            Console.WriteLine("Ingrese la fecha de finalización (dd/mm/aaaa)");
            string? fechaText = Console.ReadLine();
            DateTime fechaFin;
            while (!DateTime.TryParse(fechaTexto, out fechaFin))
            {
                Console.WriteLine("⚠️ Fecha inválida. Intente de nuevo (formato: dd/mm/aaaa):");
                fechaText = Console.ReadLine();
            }
            FechaInicio = fechaFin;

            return new Torneo(Id, Nombre, Tipo, FechaInicio, FechaFin);
        }
    }
}
