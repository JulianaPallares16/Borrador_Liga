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
        public Torneo(int id, string? nombre)
        {
            Id = id;
            Nombre = nombre;

        }
        public Torneo() { }
        public override string ToString()
        {
            return $"Id: {Id}, Nombre: {Nombre}";
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
            return new Torneo(Id, Nombre);
        }
    }
}
