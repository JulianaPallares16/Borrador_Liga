using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace futbol
{
    public class Equipo
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public Equipo(int id, string? nombre)
        {
            Id = id;
            Nombre = nombre;
        }
        public Equipo() {}
        public override string ToString()
        {
            return $"Id: {Id}. Equipo: {Nombre}.";
        }
        public Equipo Addequipo()
        {
            while (true)
            {
                Console.WriteLine("Ingrese el Id del equipo");
                string? dataIn = Console.ReadLine();
                if (int.TryParse(dataIn, out int id))
                {
                    Id = id;
                }
                if (SubmenuEquipo.equipos.Any(e => e.Id == id))
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
                Console.WriteLine("Ingrese el nombre del equipo");
                Nombre = Console.ReadLine();
                if (SubmenuEquipo.equipos.Any(e => e.Nombre?.ToLower() == Nombre?.ToLower()))
                {
                    Console.WriteLine("❗ Este nombre ya existe, ingrese uno nuevo.");
                    continue;
                }
                else
                {
                    break;
                }
            }
            return new Equipo(Id, Nombre);
        }
    }
    
}